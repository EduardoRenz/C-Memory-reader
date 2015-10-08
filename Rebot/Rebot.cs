using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rebot
{
    public partial class Rebot : Form
    {


        public bool ativo = false;
        public int seconds = 0;
        public TimeSpan tempo_restante;
        Tasker tasker = new Tasker();
        public Rebot(){
          InitializeComponent();
          timer.Tick += new EventHandler(regresso);
          update();
        }
        private void update()
        {
            if (processo.Text == "" || processo.Text == null) {
                processos.DataSource = tasker.listarprocesos();
            }
            else {
                processos.DataSource = tasker.procura_processo(processo.Text);
            }
        }
        private void ok_Click(object sender, EventArgs e)
        {
            ativo = !ativo ;
            if(ativo == true)
            {
                ok.Text = "Parar";
                Start();
            }
            else
            {
                ok.Text = "Ok";
                timer.Stop();
            }

        }

        private void Start()
        {
            if ((tempo.Text != null) && (tempo.Text.Contains(":")) && (tempo.Text != ""))
            {
                seconds = timeconvert(tempo.Text);
                tempo_restante = TimeSpan.FromSeconds(seconds);
                timer.Interval = 1000;
                lblcont.Text = tempo_restante.ToString();
                timer.Start();
            }
            else
            {
                MessageBox.Show("Valor de tempo inválido!");
            }
        }// Inicia a contagem de tempo
        private void regresso(object sender, EventArgs e)
        {
            seconds--;
            tempo_restante = TimeSpan.FromSeconds(seconds);
            lblcont.Text = tempo_restante.ToString();
            if(seconds == 0)
            {
                timer.Stop();
                if (ativo)
                {
                    if (Reiniciar.Checked)
                    {
                        MessageBox.Show("Reiniciando");
                    }
                    else
                    {
                        MessageBox.Show("Desligando");
                    }
                }
                ativo = false;
            }     
        } // Faz a contagem regressiva
        private int timeconvert(string var)
        {
            int[] tempo = var.Split(':').Select(n => Convert.ToInt32(n)).ToArray();
            Console.WriteLine("{0} horas {1} minutos {2} segundos DEFINIDOS PELO USUÁRIO", tempo[0], tempo[1], tempo[2]);
            int totalsegundos = ((tempo[0] * 60 * 60) + (tempo[1] * 60)) + tempo[2];
            Console.WriteLine("{0} segundos CONVERTIDO", totalsegundos);
            return totalsegundos;
        } // converte a string recebida do usuario para segundos

        private void processo_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void processos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        ProcessoWindow janelawindow =  new ProcessoWindow(processos.SelectedItem.ToString());
            janelawindow.Show();
        }
    }
}
