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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.btnLigar = new System.Windows.Forms.Button();
            this.chkAquecimentoRapido = new System.Windows.Forms.CheckBox();
            this.txtString = new System.Windows.Forms.TextBox();
            this.txtAquecido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(214)))), ((int)(((byte)(225)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(46, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "POTÊNCIA";
            // 
            // txtPotencia
            // 
            this.txtPotencia.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPotencia.Location = new System.Drawing.Point(49, 110);
            this.txtPotencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPotencia.Size = new System.Drawing.Size(96, 34);
            this.txtPotencia.TabIndex = 1;
            this.txtPotencia.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(214)))), ((int)(((byte)(225)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(182, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "TEMPO";
            // 
            // txtTempo
            // 
            this.txtTempo.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempo.Location = new System.Drawing.Point(185, 110);
            this.txtTempo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTempo.Size = new System.Drawing.Size(96, 34);
            this.txtTempo.TabIndex = 2;
            this.txtTempo.Text = "00:00";
            // 
            // btnLigar
            // 
            this.btnLigar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.btnLigar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLigar.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.btnLigar.Location = new System.Drawing.Point(371, 176);
            this.btnLigar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(68, 63);
            this.btnLigar.TabIndex = 2;
            this.btnLigar.Text = "LIGAR";
            this.btnLigar.UseVisualStyleBackColor = false;
            this.btnLigar.Click += new System.EventHandler(this.BtnLigar_Click);
            // 
            // chkAquecimentoRapido
            // 
            this.chkAquecimentoRapido.AutoSize = true;
            this.chkAquecimentoRapido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(214)))), ((int)(((byte)(225)))));
            this.chkAquecimentoRapido.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAquecimentoRapido.Location = new System.Drawing.Point(49, 51);
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
            this.txtString.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtString.Location = new System.Drawing.Point(49, 164);
            this.txtString.Margin = new System.Windows.Forms.Padding(4);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(232, 83);
            this.txtString.TabIndex = 1;
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
            this.txtAquecido.TabIndex = 3;
            this.txtAquecido.Text = "Aquecido";
            this.txtAquecido.Visible = false;
            // 
            // MicroondasDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 291);
            this.Controls.Add(this.txtAquecido);
            this.Controls.Add(this.chkAquecimentoRapido);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.txtPotencia);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.CheckBox chkAquecimentoRapido;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Label txtAquecido;
    }
}

