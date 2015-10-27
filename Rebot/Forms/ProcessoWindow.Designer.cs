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
            this.progresso = new System.Windows.Forms.ProgressBar();
            this.titulo = new System.Windows.Forms.Label();
            this.pesquisa = new System.Windows.Forms.TextBox();
            this.idProcesso = new System.Windows.Forms.Label();
            this.BtScan = new System.Windows.Forms.Button();
            this.gridResult = new System.Windows.Forms.DataGridView();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.painelTopo = new System.Windows.Forms.Panel();
            this.divScan = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.painelTopo.SuspendLayout();
            this.divScan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progresso
            // 
            this.progresso.Location = new System.Drawing.Point(90, 56);
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(279, 21);
            this.progresso.TabIndex = 5;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.Snow;
            this.titulo.Location = new System.Drawing.Point(3, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(181, 26);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Processo Nome";
            // 
            // pesquisa
            // 
            this.pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisa.Location = new System.Drawing.Point(8, 55);
            this.pesquisa.Name = "pesquisa";
            this.pesquisa.Size = new System.Drawing.Size(400, 20);
            this.pesquisa.TabIndex = 0;
            // 
            // idProcesso
            // 
            this.idProcesso.AutoSize = true;
            this.idProcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProcesso.ForeColor = System.Drawing.Color.Snow;
            this.idProcesso.Location = new System.Drawing.Point(4, 26);
            this.idProcesso.Name = "idProcesso";
            this.idProcesso.Size = new System.Drawing.Size(45, 20);
            this.idProcesso.TabIndex = 3;
            this.idProcesso.Text = "0000";
            // 
            // BtScan
            // 
            this.BtScan.Location = new System.Drawing.Point(0, 55);
            this.BtScan.Name = "BtScan";
            this.BtScan.Size = new System.Drawing.Size(74, 22);
            this.BtScan.TabIndex = 4;
            this.BtScan.Text = "Scan";
            this.BtScan.UseVisualStyleBackColor = true;
            this.BtScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // gridResult
            // 
            this.gridResult.AllowUserToDeleteRows = false;
            this.gridResult.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.gridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Endereco,
            this.valor});
            this.gridResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridResult.Location = new System.Drawing.Point(3, 94);
            this.gridResult.MinimumSize = new System.Drawing.Size(800, 0);
            this.gridResult.Name = "gridResult";
            this.gridResult.ReadOnly = true;
            this.gridResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridResult.Size = new System.Drawing.Size(880, 459);
            this.gridResult.TabIndex = 3;
            // 
            // valor
            // 
            this.valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // Endereco
            // 
            this.Endereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            this.Endereco.ToolTipText = "Endereço na memória";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.painelTopo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridResult, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.36691F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.63309F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(886, 556);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // painelTopo
            // 
            this.painelTopo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelTopo.Controls.Add(this.panel1);
            this.painelTopo.Controls.Add(this.divScan);
            this.painelTopo.Location = new System.Drawing.Point(3, 3);
            this.painelTopo.Name = "painelTopo";
            this.painelTopo.Size = new System.Drawing.Size(880, 85);
            this.painelTopo.TabIndex = 0;
            // 
            // divScan
            // 
            this.divScan.Controls.Add(this.BtScan);
            this.divScan.Controls.Add(this.progresso);
            this.divScan.Dock = System.Windows.Forms.DockStyle.Right;
            this.divScan.Location = new System.Drawing.Point(498, 0);
            this.divScan.Name = "divScan";
            this.divScan.Size = new System.Drawing.Size(382, 85);
            this.divScan.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titulo);
            this.panel1.Controls.Add(this.pesquisa);
            this.panel1.Controls.Add(this.idProcesso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 85);
            this.panel1.TabIndex = 7;
            // 
            // ProcessoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(886, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ProcessoWindow";
            this.Text = "processo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProcessoWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.painelTopo.ResumeLayout(false);
            this.divScan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progresso;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.TextBox pesquisa;
        private System.Windows.Forms.Label idProcesso;
        private System.Windows.Forms.Button BtScan;
        private System.Windows.Forms.DataGridView gridResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel painelTopo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel divScan;
    }
}