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
        MemoryReader farejadorProcessos = new MemoryReader();
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
                    memoria.Clear();
                    gridResult.Rows.Clear();
                    farejadorProcessos.isRodando = true;
                    workerThread.RunWorkerAsync();      
                }
                else
                {
                    MessageBox.Show("È muita coisa para pesquisar!");
                    isRodando = false;
                }
            }
            else
            {
                BtScan.Text = "Scan";
                farejadorProcessos.isRodando = false;
            }
            memoria = farejadorProcessos.memoria;
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
            isRodando = false;
            listarMemoria();
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
                gridResult.Rows.Add(divisão[0], divisão[1]);
            }
        }
    }
}
