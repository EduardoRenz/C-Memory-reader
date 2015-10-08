namespace Rebot
{
    partial class ProcessoWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessoWindow));
            this.titulo = new System.Windows.Forms.Label();
            this.conteiner_lista = new System.Windows.Forms.GroupBox();
            this.ulmem = new System.Windows.Forms.TableLayoutPanel();
            this.labelTValor = new System.Windows.Forms.Label();
            this.labelTValorCondi = new System.Windows.Forms.Label();
            this.labelTEndereco = new System.Windows.Forms.Label();
            this.idProcesso = new System.Windows.Forms.Label();
            this.pesquisa = new System.Windows.Forms.TextBox();
            this.BtScan = new System.Windows.Forms.Button();
            this.progresso = new System.Windows.Forms.ProgressBar();
            this.conteiner_lista.SuspendLayout();
            this.ulmem.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.Snow;
            this.titulo.Location = new System.Drawing.Point(12, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(181, 26);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Processo Nome";
            // 
            // conteiner_lista
            // 
            this.conteiner_lista.Controls.Add(this.ulmem);
            this.conteiner_lista.Location = new System.Drawing.Point(17, 91);
            this.conteiner_lista.Name = "conteiner_lista";
            this.conteiner_lista.Size = new System.Drawing.Size(697, 347);
            this.conteiner_lista.TabIndex = 2;
            this.conteiner_lista.TabStop = false;
            // 
            // ulmem
            // 
            this.ulmem.AutoSize = true;
            this.ulmem.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.None;
            this.ulmem.ColumnCount = 3;
            this.ulmem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ulmem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 401F));
            this.ulmem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.ulmem.Controls.Add(this.labelTValor, 1, 0);
            this.ulmem.Controls.Add(this.labelTValorCondi, 2, 0);
            this.ulmem.Controls.Add(this.labelTEndereco, 0, 0);
            this.ulmem.ForeColor = System.Drawing.Color.Snow;
            this.ulmem.Location = new System.Drawing.Point(0, 7);
            this.ulmem.Name = "ulmem";
            this.ulmem.RowCount = 2;
            this.ulmem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ulmem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.ulmem.Size = new System.Drawing.Size(697, 41);
            this.ulmem.TabIndex = 0;
            // 
            // labelTValor
            // 
            this.labelTValor.AutoSize = true;
            this.labelTValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTValor.ForeColor = System.Drawing.Color.Snow;
            this.labelTValor.Location = new System.Drawing.Point(145, 1);
            this.labelTValor.Name = "labelTValor";
            this.labelTValor.Size = new System.Drawing.Size(46, 17);
            this.labelTValor.TabIndex = 1;
            this.labelTValor.Text = "Valor";
            // 
            // labelTValorCondi
            // 
            this.labelTValorCondi.AutoSize = true;
            this.labelTValorCondi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTValorCondi.ForeColor = System.Drawing.Color.Transparent;
            this.labelTValorCondi.Location = new System.Drawing.Point(547, 1);
            this.labelTValorCondi.Name = "labelTValorCondi";
            this.labelTValorCondi.Size = new System.Drawing.Size(135, 17);
            this.labelTValorCondi.TabIndex = 2;
            this.labelTValorCondi.Text = "Valor Condicional";
            // 
            // labelTEndereco
            // 
            this.labelTEndereco.AutoSize = true;
            this.labelTEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTEndereco.ForeColor = System.Drawing.Color.Snow;
            this.labelTEndereco.Location = new System.Drawing.Point(4, 1);
            this.labelTEndereco.Name = "labelTEndereco";
            this.labelTEndereco.Size = new System.Drawing.Size(77, 17);
            this.labelTEndereco.TabIndex = 0;
            this.labelTEndereco.Text = "Endereço";
            this.labelTEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idProcesso
            // 
            this.idProcesso.AutoSize = true;
            this.idProcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProcesso.ForeColor = System.Drawing.Color.Snow;
            this.idProcesso.Location = new System.Drawing.Point(13, 35);
            this.idProcesso.Name = "idProcesso";
            this.idProcesso.Size = new System.Drawing.Size(45, 20);
            this.idProcesso.TabIndex = 3;
            this.idProcesso.Text = "0000";
            // 
            // pesquisa
            // 
            this.pesquisa.Location = new System.Drawing.Point(17, 65);
            this.pesquisa.Name = "pesquisa";
            this.pesquisa.Size = new System.Drawing.Size(293, 20);
            this.pesquisa.TabIndex = 0;
            // 
            // BtScan
            // 
            this.BtScan.Location = new System.Drawing.Point(334, 63);
            this.BtScan.Name = "BtScan";
            this.BtScan.Size = new System.Drawing.Size(75, 23);
            this.BtScan.TabIndex = 4;
            this.BtScan.Text = "Scan";
            this.BtScan.UseVisualStyleBackColor = true;
            this.BtScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // progresso
            // 
            this.progresso.Location = new System.Drawing.Point(425, 65);
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(289, 23);
            this.progresso.TabIndex = 5;
            // 
            // ProcessoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.progresso);
            this.Controls.Add(this.BtScan);
            this.Controls.Add(this.pesquisa);
            this.Controls.Add(this.idProcesso);
            this.Controls.Add(this.conteiner_lista);
            this.Controls.Add(this.titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcessoWindow";
            this.Text = "processo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProcessoWindow_FormClosed);
            this.conteiner_lista.ResumeLayout(false);
            this.conteiner_lista.PerformLayout();
            this.ulmem.ResumeLayout(false);
            this.ulmem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.GroupBox conteiner_lista;
        private System.Windows.Forms.Label idProcesso;
        private System.Windows.Forms.TextBox pesquisa;
        private System.Windows.Forms.TableLayoutPanel ulmem;
        private System.Windows.Forms.Label labelTEndereco;
        private System.Windows.Forms.Label labelTValor;
        private System.Windows.Forms.Label labelTValorCondi;
        private System.Windows.Forms.Button BtScan;
        private System.Windows.Forms.ProgressBar progresso;
    }
}