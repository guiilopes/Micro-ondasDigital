using MicroondasDigital.Domain.MicroondasDigitais.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using MicroondasDigital.Domain.MicroondasDigitais.Results;

namespace MicroondasDigital.App.Controles
{
    public partial class FrmAdicionarPredefinicao : DevExpress.XtraEditors.XtraForm
    {
        public List<PreDefinidosResult> _preDefinidos;

        public FrmAdicionarPredefinicao(IEnumerable<PreDefinidosResult>  preDefinidos)
        {
            _preDefinidos = preDefinidos.ToList();

            InitializeComponent();
        }

        private void CmdAdicionarPredefinicao_Click(object sender, System.EventArgs e)
        {
            var tempoInformado = TimeSpan.Parse($"00:{txtTempo.Text}");

            var novaDefinicao = MicroondasHelper.PreencherResult(txtNome.Text, Convert.ToInt32(txtPotencia.Text), tempoInformado, txtCaractere.Text);

            _preDefinidos.Add(novaDefinicao);

            this.Close();
        }
    }
}