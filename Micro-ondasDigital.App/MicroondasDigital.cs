﻿using System;
using System.Text;
using System.Windows.Forms;

namespace MicroondasDigital.App
{
    public partial class MicroondasDigital : Form
    {
        public MicroondasDigital()
        {
            InitializeComponent();
        }

        private void ChkAquecimentoRapido_CheckedChanged(object sender, EventArgs e)
        {
            AtribuirValoresPadrao();

            if (!chkAquecimentoRapido.Checked) return;

            txtPotencia.Text = "8";
            txtTempo.Text = "00:30";
        }

        private void MicroondasDigital_Load(object sender, EventArgs e)
        {
            AtribuirValoresPadrao();
        }

        public void AtribuirValoresPadrao()
        {
            txtPotencia.Text = "1";
            txtTempo.Text = "00:00";
        }

        public void AtribuirPontuacaoDeAcordoComAPotencia()
        {
            var portencia = Convert.ToInt32(txtPotencia.Text);

            AtribuirTempo(portencia);
        }

        public void AtribuirTempo(int potencia)
        {
            var tempoInformado = TimeSpan.Parse($"00:{txtTempo.Text}");
            var tempo = tempoInformado.Minutes * 60 + tempoInformado.Seconds;
            TimeSpan tempoHoraMinuto;

            var relogio = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };

            relogio.Tick += delegate
            {
                tempo -= 1;

                tempoHoraMinuto = TimeSpan.FromSeconds(tempo);

                txtTempo.Text = $"{tempoHoraMinuto.Minutes:00}:{tempoHoraMinuto.Seconds:00}";

                txtString.Text += AtribuirContagemAsterisco(potencia);

                if (tempo != 0) return;

                relogio.Stop();

                txtString.Text = "";
                txtAquecido.Visible = true;
            };

            relogio.Start();
        }

        private StringBuilder AtribuirContagemAsterisco(int potencia)
        {
            var retorno = new StringBuilder();

            for (var i = 0; i < potencia; i++)
            {
                retorno.Append("" + (char)46);
                //retorno.Append(" ");
            }

            return retorno;
        }

        private void BtnLigar_Click(object sender, EventArgs e)
        {
            if (txtTempo.Text.Equals("00:00"))
            {
                MessageBox.Show("Horário não informado!", "", MessageBoxButtons.OK);
                return;
            }

            txtAquecido.Visible = false;
            AtribuirPontuacaoDeAcordoComAPotencia();
        }
    }
}