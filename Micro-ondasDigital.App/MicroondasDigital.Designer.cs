namespace MicroondasDigital.App
{
    partial class MicroondasDigital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MicroondasDigital));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAquecimentoRapido = new System.Windows.Forms.CheckBox();
            this.txtString = new System.Windows.Forms.TextBox();
            this.txtAquecido = new System.Windows.Forms.Label();
            this.cmbPredefinido = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPotencia = new DevExpress.XtraEditors.TextEdit();
            this.txtTempo = new DevExpress.XtraEditors.TextEdit();
            this.cmdLigar = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdPausar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdInstrucoes = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSair = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAdicionarPredefinicao = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPredefinido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPotencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempo.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(214)))), ((int)(((byte)(225)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(46, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "POTÊNCIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(214)))), ((int)(((byte)(225)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(182, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "TEMPO";
            // 
            // chkAquecimentoRapido
            // 
            this.chkAquecimentoRapido.AutoSize = true;
            this.chkAquecimentoRapido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(214)))), ((int)(((byte)(225)))));
            this.chkAquecimentoRapido.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAquecimentoRapido.Location = new System.Drawing.Point(49, 37);
            this.chkAquecimentoRapido.Margin = new System.Windows.Forms.Padding(4);
            this.chkAquecimentoRapido.Name = "chkAquecimentoRapido";
            this.chkAquecimentoRapido.Size = new System.Drawing.Size(133, 21);
            this.chkAquecimentoRapido.TabIndex = 0;
            this.chkAquecimentoRapido.Text = "INÍCIO RÁPIDO?";
            this.chkAquecimentoRapido.UseVisualStyleBackColor = false;
            this.chkAquecimentoRapido.CheckedChanged += new System.EventHandler(this.ChkAquecimentoRapido_CheckedChanged);
            // 
            // txtString
            // 
            this.txtString.Font = new System.Drawing.Font("Segoe UI", 4F);
            this.txtString.Location = new System.Drawing.Point(49, 164);
            this.txtString.Margin = new System.Windows.Forms.Padding(4);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(232, 83);
            this.txtString.TabIndex = 1;
            this.txtString.TabStop = false;
            // 
            // txtAquecido
            // 
            this.txtAquecido.AutoSize = true;
            this.txtAquecido.BackColor = System.Drawing.Color.White;
            this.txtAquecido.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAquecido.ForeColor = System.Drawing.Color.Tomato;
            this.txtAquecido.Location = new System.Drawing.Point(65, 182);
            this.txtAquecido.Name = "txtAquecido";
            this.txtAquecido.Size = new System.Drawing.Size(201, 47);
            this.txtAquecido.TabIndex = 4;
            this.txtAquecido.Text = "Aquecido";
            this.txtAquecido.Visible = false;
            // 
            // cmbPredefinido
            // 
            this.cmbPredefinido.EditValue = "Arroz";
            this.cmbPredefinido.Location = new System.Drawing.Point(151, 65);
            this.cmbPredefinido.Name = "cmbPredefinido";
            this.cmbPredefinido.Properties.Appearance.Font = new System.Drawing.Font("DS-Digital", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPredefinido.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.cmbPredefinido.Properties.Appearance.Options.UseFont = true;
            this.cmbPredefinido.Properties.Appearance.Options.UseForeColor = true;
            this.cmbPredefinido.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPredefinido.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbPredefinido.Properties.DisplayMember = "Nome";
            this.cmbPredefinido.Properties.DropDownRows = 8;
            this.cmbPredefinido.Properties.NullText = "Arroz";
            this.cmbPredefinido.Properties.PopupSizeable = false;
            this.cmbPredefinido.Properties.ShowFooter = false;
            this.cmbPredefinido.Properties.ShowHeader = false;
            this.cmbPredefinido.Properties.Tag = "";
            this.cmbPredefinido.Properties.ValueMember = "Nome";
            this.cmbPredefinido.Size = new System.Drawing.Size(130, 28);
            this.cmbPredefinido.TabIndex = 1;
            this.cmbPredefinido.EditValueChanged += new System.EventHandler(this.CmbPredefinido_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(214)))), ((int)(((byte)(225)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.label3.Location = new System.Drawing.Point(46, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "PREDEFINIDO";
            // 
            // txtPotencia
            // 
            this.txtPotencia.EditValue = "10";
            this.txtPotencia.Location = new System.Drawing.Point(49, 121);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Properties.Appearance.Font = new System.Drawing.Font("DS-Digital", 20.25F);
            this.txtPotencia.Properties.Appearance.Options.UseFont = true;
            this.txtPotencia.Properties.Mask.EditMask = "[0-1]\\d";
            this.txtPotencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPotencia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPotencia.Size = new System.Drawing.Size(96, 34);
            this.txtPotencia.TabIndex = 2;
            this.txtPotencia.ToolTip = "Informe uma potência entre 1 e 10.";
            // 
            // txtTempo
            // 
            this.txtTempo.EditValue = "";
            this.txtTempo.Location = new System.Drawing.Point(185, 123);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Properties.Appearance.Font = new System.Drawing.Font("DS-Digital", 20.25F);
            this.txtTempo.Properties.Appearance.Options.UseFont = true;
            this.txtTempo.Properties.Mask.EditMask = "[0-1]:[0-5]\\d";
            this.txtTempo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtTempo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTempo.Size = new System.Drawing.Size(96, 34);
            this.txtTempo.TabIndex = 3;
            this.txtTempo.ToolTip = "Informe um tempo entre 00:01 e 02:00";
            // 
            // cmdLigar
            // 
            this.cmdLigar.Appearance.BackColor = System.Drawing.Color.YellowGreen;
            this.cmdLigar.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdLigar.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.cmdLigar.Appearance.Options.UseBackColor = true;
            this.cmdLigar.Appearance.Options.UseFont = true;
            this.cmdLigar.Appearance.Options.UseForeColor = true;
            this.cmdLigar.Location = new System.Drawing.Point(3, 2);
            this.cmdLigar.Name = "cmdLigar";
            this.cmdLigar.Size = new System.Drawing.Size(68, 46);
            this.cmdLigar.TabIndex = 5;
            this.cmdLigar.Text = "Ligar";
            this.cmdLigar.ToolTip = "Ligar";
            this.cmdLigar.Click += new System.EventHandler(this.CmdLigar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.panel1.Controls.Add(this.cmdCancelar);
            this.panel1.Controls.Add(this.cmdPausar);
            this.panel1.Controls.Add(this.cmdLigar);
            this.panel1.Location = new System.Drawing.Point(368, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(74, 90);
            this.panel1.TabIndex = 6;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Appearance.BackColor = System.Drawing.Color.Tomato;
            this.cmdCancelar.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.cmdCancelar.Appearance.Options.UseBackColor = true;
            this.cmdCancelar.Appearance.Options.UseFont = true;
            this.cmdCancelar.Appearance.Options.UseForeColor = true;
            this.cmdCancelar.Location = new System.Drawing.Point(43, 54);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(28, 31);
            this.cmdCancelar.TabIndex = 7;
            this.cmdCancelar.Text = "X";
            this.cmdCancelar.ToolTip = "Cancelar";
            this.cmdCancelar.Click += new System.EventHandler(this.CmdCancelar_Click);
            // 
            // cmdPausar
            // 
            this.cmdPausar.Appearance.BackColor = System.Drawing.Color.Gold;
            this.cmdPausar.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdPausar.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.cmdPausar.Appearance.Options.UseBackColor = true;
            this.cmdPausar.Appearance.Options.UseFont = true;
            this.cmdPausar.Appearance.Options.UseForeColor = true;
            this.cmdPausar.Location = new System.Drawing.Point(3, 54);
            this.cmdPausar.Name = "cmdPausar";
            this.cmdPausar.Size = new System.Drawing.Size(28, 31);
            this.cmdPausar.TabIndex = 6;
            this.cmdPausar.Text = "||";
            this.cmdPausar.ToolTip = "Pausar";
            this.cmdPausar.Click += new System.EventHandler(this.CmdPausar_Click);
            // 
            // cmdInstrucoes
            // 
            this.cmdInstrucoes.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.cmdInstrucoes.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmdInstrucoes.Appearance.Options.UseBackColor = true;
            this.cmdInstrucoes.Appearance.Options.UseFont = true;
            this.cmdInstrucoes.Location = new System.Drawing.Point(371, 134);
            this.cmdInstrucoes.Name = "cmdInstrucoes";
            this.cmdInstrucoes.Size = new System.Drawing.Size(68, 33);
            this.cmdInstrucoes.TabIndex = 7;
            this.cmdInstrucoes.Text = "Instruções";
            this.cmdInstrucoes.Click += new System.EventHandler(this.CmdInstrucoes_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.Appearance.BackColor = System.Drawing.Color.Tomato;
            this.cmdSair.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.cmdSair.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.cmdSair.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 7F, System.Drawing.FontStyle.Bold);
            this.cmdSair.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.cmdSair.Appearance.Options.UseBackColor = true;
            this.cmdSair.Appearance.Options.UseBorderColor = true;
            this.cmdSair.Appearance.Options.UseFont = true;
            this.cmdSair.Appearance.Options.UseForeColor = true;
            this.cmdSair.Location = new System.Drawing.Point(385, 34);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(39, 16);
            this.cmdSair.TabIndex = 8;
            this.cmdSair.Text = "Sair";
            this.cmdSair.ToolTip = "Sair do programa";
            this.cmdSair.Click += new System.EventHandler(this.CmdSair_Click);
            // 
            // cmdAdicionarPredefinicao
            // 
            this.cmdAdicionarPredefinicao.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.cmdAdicionarPredefinicao.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.cmdAdicionarPredefinicao.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.cmdAdicionarPredefinicao.Appearance.Options.UseBackColor = true;
            this.cmdAdicionarPredefinicao.Appearance.Options.UseFont = true;
            this.cmdAdicionarPredefinicao.Appearance.Options.UseForeColor = true;
            this.cmdAdicionarPredefinicao.Appearance.Options.UseTextOptions = true;
            this.cmdAdicionarPredefinicao.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmdAdicionarPredefinicao.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.cmdAdicionarPredefinicao.Location = new System.Drawing.Point(378, 76);
            this.cmdAdicionarPredefinicao.Name = "cmdAdicionarPredefinicao";
            this.cmdAdicionarPredefinicao.Size = new System.Drawing.Size(53, 31);
            this.cmdAdicionarPredefinicao.TabIndex = 6;
            this.cmdAdicionarPredefinicao.Text = "+";
            this.cmdAdicionarPredefinicao.ToolTip = "Adicionar predefinição";
            this.cmdAdicionarPredefinicao.Click += new System.EventHandler(this.CmdAdicionarPredefinicao_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MicroondasDigital.App.Properties.Resources.microondas;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MicroondasDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 291);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.cmdAdicionarPredefinicao);
            this.Controls.Add(this.cmdInstrucoes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.cmbPredefinido);
            this.Controls.Add(this.txtAquecido);
            this.Controls.Add(this.chkAquecimentoRapido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MicroondasDigital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Microondas Digital";
            this.Load += new System.EventHandler(this.MicroondasDigital_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPredefinido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPotencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempo.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAquecimentoRapido;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Label txtAquecido;
        private DevExpress.XtraEditors.LookUpEdit cmbPredefinido;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtPotencia;
        private DevExpress.XtraEditors.TextEdit txtTempo;
        private DevExpress.XtraEditors.SimpleButton cmdLigar;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton cmdCancelar;
        private DevExpress.XtraEditors.SimpleButton cmdPausar;
        private DevExpress.XtraEditors.SimpleButton cmdInstrucoes;
        private DevExpress.XtraEditors.SimpleButton cmdSair;
        private DevExpress.XtraEditors.SimpleButton cmdAdicionarPredefinicao;
    }
}

