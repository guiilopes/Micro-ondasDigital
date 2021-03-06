﻿namespace MicroondasDigital.App.Controles
{
    partial class FrmInstrucoes
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtInstrucoes = new System.Windows.Forms.RichTextBox();
            this.txtPotencia = new DevExpress.XtraEditors.TextEdit();
            this.txtTempo = new DevExpress.XtraEditors.TextEdit();
            this.txtNome = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPotencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtInstrucoes);
            this.layoutControl1.Controls.Add(this.txtPotencia);
            this.layoutControl1.Controls.Add(this.txtTempo);
            this.layoutControl1.Controls.Add(this.txtNome);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(399, 283, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(475, 352);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtInstrucoes
            // 
            this.txtInstrucoes.Location = new System.Drawing.Point(12, 90);
            this.txtInstrucoes.Name = "txtInstrucoes";
            this.txtInstrucoes.Size = new System.Drawing.Size(451, 250);
            this.txtInstrucoes.TabIndex = 10;
            this.txtInstrucoes.Text = "";
            // 
            // txtPotencia
            // 
            this.txtPotencia.Enabled = false;
            this.txtPotencia.Location = new System.Drawing.Point(358, 37);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtPotencia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPotencia.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.txtPotencia.Properties.Appearance.Options.UseBackColor = true;
            this.txtPotencia.Properties.Appearance.Options.UseFont = true;
            this.txtPotencia.Properties.Appearance.Options.UseForeColor = true;
            this.txtPotencia.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtPotencia.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPotencia.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.txtPotencia.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtPotencia.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtPotencia.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtPotencia.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtPotencia.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPotencia.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.txtPotencia.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtPotencia.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtPotencia.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtPotencia.Properties.Mask.EditMask = "[0-1]\\d";
            this.txtPotencia.Size = new System.Drawing.Size(105, 24);
            this.txtPotencia.StyleController = this.layoutControl1;
            this.txtPotencia.TabIndex = 7;
            // 
            // txtTempo
            // 
            this.txtTempo.Enabled = false;
            this.txtTempo.Location = new System.Drawing.Point(256, 37);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTempo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTempo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.txtTempo.Properties.Appearance.Options.UseBackColor = true;
            this.txtTempo.Properties.Appearance.Options.UseFont = true;
            this.txtTempo.Properties.Appearance.Options.UseForeColor = true;
            this.txtTempo.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtTempo.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTempo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.txtTempo.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtTempo.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtTempo.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtTempo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtTempo.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTempo.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.txtTempo.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtTempo.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtTempo.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtTempo.Properties.Mask.EditMask = "[0-1]:[0-5]\\d";
            this.txtTempo.Size = new System.Drawing.Size(98, 24);
            this.txtTempo.StyleController = this.layoutControl1;
            this.txtTempo.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(12, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtNome.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.txtNome.Properties.Appearance.Options.UseBackColor = true;
            this.txtNome.Properties.Appearance.Options.UseFont = true;
            this.txtNome.Properties.Appearance.Options.UseForeColor = true;
            this.txtNome.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtNome.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNome.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtNome.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtNome.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtNome.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNome.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtNome.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtNome.Size = new System.Drawing.Size(240, 24);
            this.txtNome.StyleController = this.layoutControl1;
            this.txtNome.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(475, 352);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtNome;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(244, 53);
            this.layoutControlItem1.Text = "Nome";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(100, 20);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtTempo;
            this.layoutControlItem3.Location = new System.Drawing.Point(244, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(102, 53);
            this.layoutControlItem3.Text = "Tempo";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtPotencia;
            this.layoutControlItem2.Location = new System.Drawing.Point(346, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(109, 53);
            this.layoutControlItem2.Text = "Potência";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(50, 20);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.txtInstrucoes;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 53);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(455, 279);
            this.layoutControlItem4.Text = "Instruções";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(50, 20);
            this.layoutControlItem4.TextToControlDistance = 5;
            // 
            // FrmInstrucoes
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 352);
            this.Controls.Add(this.layoutControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.LookAndFeel.SkinName = "The Bezier";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInstrucoes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instruções do alimento";
            this.Load += new System.EventHandler(this.FrmInstrucoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPotencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtNome;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtTempo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit txtPotencia;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.RichTextBox txtInstrucoes;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}