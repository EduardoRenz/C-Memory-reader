using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rebot
{
    public partial class ProcessoWindow : Form
    {
        private bool isRodando = false;
        private int id;
        private string tituloProcesso;
        public List<string> memoria = new List<string>();
        Tasker farejadorProcessos = new Tasker();
        BackgroundWorker workerThread;

        public ProcessoWindow(string var_nao_tratada)
        {
            // TRATANDO DO PARAMETRO DE ENTRADA
            string[] divisão = var_nao_tratada.Split(' ');
            tituloProcesso = divisão[1].ToString();
            id = Convert.ToInt32(divisão[0]);
            // ==================================
            InitializeComponent();
            // ==== Setar a GUI ====================
            Text = titulo.Text = tituloProcesso;
            idProcesso.Text = divisão[0];
            // ===================================
            workerThread = new BackgroundWorker();
            workerThread.WorkerReportsProgress = true;
            workerThread.WorkerSupportsCancellation = true;
            workerThread.DoWork += Worker_DoWork;
            workerThread.ProgressChanged += workerRetorno;
            workerThread.RunWorkerCompleted += workercompleto;
        }

        private void btnScan_Click(object sender, EventArgs e) // CLICAR no BOTAO DO SCAN
        {
            isRodando = !isRodando;
            if (isRodando)
            {
                if (pesquisa.Text != "")
                {
                    BtScan.Text = "Cancelar";
                    progresso.Value = 0;
                    ulmem.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                    memoria.Clear();
                    ulmem.Controls.Clear();
                    workerThread.RunWorkerAsync();
                    farejadorProcessos.isRodando = true;       
                }
                else
                {
                    MessageBox.Show("È muita coisa para pesquisar!");
                }
            }
            else
            {
                BtScan.Text = "Scan";
                farejadorProcessos.isRodando = false;
                memoria = farejadorProcessos.memoria;
            }
        }
        // RETORNO DO WORKER
        private void workerRetorno(object sender, ProgressChangedEventArgs e)
        {
            // Console.WriteLine(e.UserState + " progresso = "+e.ProgressPercentage);
            progresso.Value = e.ProgressPercentage;
        }
        // WOKER FAZER TRABALHO
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            farejadorProcessos.lerProcesso(id, workerThread, pesquisa.Text);

        }
        // WORKER COMPLETO
        private void workercompleto(object sender, RunWorkerCompletedEventArgs e)
        {
            ulmem.Enabled = false;
            isRodando = false;
            listarMemoria();
            ulmem.Enabled = true;
            BtScan.Text = "Scan";
            Console.WriteLine("Completo");
        }
        private void ProcessoWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            memoria.Clear();
            farejadorProcessos.isRodando = false;
        }
        private void listarMemoria()
        {
            Console.WriteLine(" tem " + memoria.Count + " na Lista");
            for (int i = 0; i < memoria.Count; i++)
            {
                string[] divisão = memoria[i].Split(':');
                ulmem.Controls.Add(new Label() { Text = divisão[1] }, 0, i - 1);
                ulmem.Controls.Add(new TextBox() { Text = divisão[0], ReadOnly = true, BackColor = BackColor, BorderStyle = 0, ForeColor = System.Drawing.Color.White }, 0, i - 1);
                ulmem.Controls.Add(new TextBox() { Text = " " }, 2, i - 1);
            }
            ulmem.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        }
    }
}
