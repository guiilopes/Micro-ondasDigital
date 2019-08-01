﻿using MicroondasDigital.Domain.MicroondasDigitais.Results;

namespace MicroondasDigital.App.Controles
{
    public partial class FrmInstrucoes : DevExpress.XtraEditors.XtraForm
    {
        private PreDefinidosResult _preDefinido;
        public FrmInstrucoes(PreDefinidosResult preDefinido)
        {
            _preDefinido = preDefinido;

            InitializeComponent();
        }

        private void FrmInstrucoes_Load(object sender, System.EventArgs e)
        {
            txtNome.Text = _preDefinido.Nome;
            txtTempo.Text = $"{_preDefinido.Tempo.Minutes:00}:{_preDefinido.Tempo.Seconds:00}";
            txtInstrucoes.Text = _preDefinido.Instrucao;
            txtPotencia.Text = _preDefinido.Potencia.ToString();
        }
    }
}