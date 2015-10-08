namespace Rebot
{
    partial class Rebot
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rebot));
            this.tempo = new System.Windows.Forms.TextBox();
            this.grpconfig = new System.Windows.Forms.GroupBox();
            this.lbltempo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Reiniciar = new System.Windows.Forms.RadioButton();
            this.Desligar = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.grpcondi = new System.Windows.Forms.GroupBox();
            this.processos = new System.Windows.Forms.ListBox();
            this.lblcont = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.aguardar = new System.Windows.Forms.CheckBox();
            this.lblprocesso = new System.Windows.Forms.Label();
            this.processo = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.grpconfig.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpcondi.SuspendLayout();
            this.SuspendLayout();
            // 
            // tempo
            // 
            this.tempo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tempo, "tempo");
            this.tempo.Name = "tempo";
            // 
            // grpconfig
            // 
            resources.ApplyResources(this.grpconfig, "grpconfig");
            this.grpconfig.Controls.Add(this.lbltempo);
            this.grpconfig.Controls.Add(this.tempo);
            this.grpconfig.Name = "grpconfig";
            this.grpconfig.TabStop = false;
            // 
            // lbltempo
            // 
            resources.ApplyResources(this.lbltempo, "lbltempo");
            this.lbltempo.Name = "lbltempo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Reiniciar);
            this.panel1.Controls.Add(this.Desligar);
            this.panel1.Controls.Add(this.label2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // Reiniciar
            // 
            resources.ApplyResources(this.Reiniciar, "Reiniciar");
            this.Reiniciar.Name = "Reiniciar";
            this.Reiniciar.UseVisualStyleBackColor = true;
            // 
            // Desligar
            // 
            resources.ApplyResources(this.Desligar, "Desligar");
            this.Desligar.Checked = true;
            this.Desligar.Name = "Desligar";
            this.Desligar.TabStop = true;
            this.Desligar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // grpcondi
            // 
            resources.ApplyResources(this.grpcondi, "grpcondi");
            this.grpcondi.Controls.Add(this.processos);
            this.grpcondi.Controls.Add(this.lblcont);
            this.grpcondi.Controls.Add(this.ok);
            this.grpcondi.Controls.Add(this.aguardar);
            this.grpcondi.Controls.Add(this.lblprocesso);
            this.grpcondi.Controls.Add(this.processo);
            this.grpcondi.Name = "grpcondi";
            this.grpcondi.TabStop = false;
            // 
            // processos
            // 
            resources.ApplyResources(this.processos, "processos");
            this.processos.FormattingEnabled = true;
            this.processos.Name = "processos";
            this.processos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.processos_MouseDoubleClick);
            // 
            // lblcont
            // 
            resources.ApplyResources(this.lblcont, "lblcont");
            this.lblcont.Name = "lblcont";
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.Black;
            this.ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok.FlatAppearance.BorderSize = 0;
            this.ok.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.ok, "ok");
            this.ok.Name = "ok";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // aguardar
            // 
            resources.ApplyResources(this.aguardar, "aguardar");
            this.aguardar.Name = "aguardar";
            this.aguardar.UseVisualStyleBackColor = true;
            // 
            // lblprocesso
            // 
            resources.ApplyResources(this.lblprocesso, "lblprocesso");
            this.lblprocesso.Name = "lblprocesso";
            // 
            // processo
            // 
            resources.ApplyResources(this.processo, "processo");
            this.processo.Name = "processo";
            this.processo.TextChanged += new System.EventHandler(this.processo_TextChanged);
            // 
            // Rebot
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.grpcondi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpconfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Rebot";
            this.grpconfig.ResumeLayout(false);
            this.grpconfig.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpcondi.ResumeLayout(false);
            this.grpcondi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tempo;
        private System.Windows.Forms.GroupBox grpconfig;
        private System.Windows.Forms.Label lbltempo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Desligar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Reiniciar;
        private System.Windows.Forms.GroupBox grpcondi;
        private System.Windows.Forms.Label lblprocesso;
        private System.Windows.Forms.TextBox processo;
        private System.Windows.Forms.CheckBox aguardar;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label lblcont;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ListBox processos;
    }
}

