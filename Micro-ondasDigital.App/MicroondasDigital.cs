using MicroondasDigital.App.Entities;
using MicroondasDigital.Domain.MicroondasDigitais.Entities;
using MicroondasDigital.Domain.MicroondasDigitais.Enums;
using MicroondasDigital.Domain.MicroondasDigitais.Results;
using MicroondasDigital.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MicroondasDigital.App
{
    public partial class MicroondasDigital : Form
    {
        private IEnumerable<ProgramasPreDefinidosResult> _preDefinidos;
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

            Servicos.Microondas.InicioRapido(Convert.ToInt32(txtPotencia.Text),
                                             TimeSpan.Parse($"00:{txtTempo.Text}"));
        }

        private void MicroondasDigital_Load(object sender, EventArgs e)
        {
            AtribuirValoresPadrao();
        }

        public void AtribuirValoresPadrao()
        {
            txtPotencia.Text = "1";
            txtTempo.Text = "00:00";

            Servicos.Microondas.Adicionar(new Microondas(MicroondasOperacao.Cozimento,
                                          new Tempo(new TimeSpan(0, 0, 1),
                                                    new TimeSpan(0, 2, 0)),
                                          MicroondasStatus.EmFuncionamento,
                                          Convert.ToInt32(txtPotencia.Text)));

            _preDefinidos = Servicos.Microondas.ObterProgramasPreDefinidos().OrderBy(x => x.Nome);

            cmbPredefinido.Properties.DataSource = _preDefinidos;
        }

        public void AtribuirPontuacaoDeAcordoComAPotencia(int potencia)
        {
            var tempoInformado = TimeSpan.Parse($"00:{txtTempo.Text}");
            var tempo = tempoInformado.Minutes * 60 + tempoInformado.Seconds;
            TimeSpan tempoHoraMinuto;

            var relogio = new Timer
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
                retorno.Append("" + (char)46);

            return retorno;
        }

        private void CmdLigar_Click(object sender, EventArgs e)
        {
            if (txtTempo.Text.Equals("00:00"))
            {
                MessageBox.Show("Horário não informado!", "", MessageBoxButtons.OK);
                return;
            }

            txtAquecido.Visible = false;
            AtribuirPontuacaoDeAcordoComAPotencia(Convert.ToInt32(txtPotencia.Text));
        }

        private void CmbPredefinido_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbPredefinido.EditValue.Equals("Arroz"))
            {
                var result = _preDefinidos.FirstOrDefault(x => x.Nome == "Arroz");
                txtTempo.Text = $"{result?.Tempo.Minutes:00}:{result?.Tempo.Seconds:00}";
                txtPotencia.Text = result?.Potencia.ToString();
            }
            else if (cmbPredefinido.EditValue.Equals("Carne"))
            {
                var result = _preDefinidos.FirstOrDefault(x => x.Nome == "Carne");
                txtTempo.Text = $"{result?.Tempo.Minutes:00}:{result?.Tempo.Seconds:00}";
                txtPotencia.Text = result?.Potencia.ToString();
            }
            else if (cmbPredefinido.EditValue.Equals("Coxinha"))
            {
                var result = _preDefinidos.FirstOrDefault(x => x.Nome == "Coxinha");
                txtTempo.Text = $"{result?.Tempo.Minutes:00}:{result?.Tempo.Seconds:00}";
                txtPotencia.Text = result?.Potencia.ToString();
            }
            else if (cmbPredefinido.EditValue.Equals("Frango"))
            {
                var result = _preDefinidos.FirstOrDefault(x => x.Nome == "Frango");
                txtTempo.Text = $"{result?.Tempo.Minutes:00}:{result?.Tempo.Seconds:00}";
                txtPotencia.Text = result?.Potencia.ToString();
            }
            else if (cmbPredefinido.EditValue.Equals("Leite"))
            {
                var result = _preDefinidos.FirstOrDefault(x => x.Nome == "Leite");
                txtTempo.Text = $"{result?.Tempo.Minutes:00}:{result?.Tempo.Seconds:00}";
                txtPotencia.Text = result?.Potencia.ToString();
            }
            else
            {
                MessageBox.Show("Alimento incompatível com o programa!", "", MessageBoxButtons.OK);
            }
        }
    }
}