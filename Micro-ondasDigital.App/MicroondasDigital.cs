﻿using MicroondasDigital.App.Controles;
using MicroondasDigital.Domain.MicroondasDigitais.Entities;
using MicroondasDigital.Domain.MicroondasDigitais.Enums;
using MicroondasDigital.Domain.MicroondasDigitais.Results;
using MicroondasDigital.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MicroondasDigital.Domain.MicroondasDigitais.Helpers;

namespace MicroondasDigital.App
{
    public partial class MicroondasDigital : Form
    {
        private Timer _relogio;
        private bool _pausado;
        private string _caractere;

        private IEnumerable<PreDefinidosResult> _preDefinidos;

        public MicroondasDigital()
        {
            InitializeComponent();
        }

        private void ChkAquecimentoRapido_CheckedChanged(object sender, EventArgs e)
        {
            AtribuirValoresPadrao();

            if (!chkAquecimentoRapido.Checked) return;

            txtPotencia.Text = "08";
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
            _preDefinidos = Servicos.Microondas.ObterProgramasPreDefinidos().OrderBy(x => x.Nome);
            cmbPredefinido.Properties.DataSource = _preDefinidos;
            cmbPredefinido.EditValue = "Arroz";
            _caractere = "a";

            var result = _preDefinidos.FirstOrDefault(x => x.Nome == "Arroz");
            txtTempo.Text = $"{result?.Tempo.Minutes:00}:{result?.Tempo.Seconds:00}";
            txtPotencia.Text = result?.Potencia.ToString("00");

            Servicos.Microondas.Adicionar(new Microondas(MicroondasOperacao.Cozimento,
                                          new Tempo(new TimeSpan(0, 0, 1),
                                                    new TimeSpan(0, 2, 0)),
                                          MicroondasStatus.EmFuncionamento,
                                          Convert.ToInt32(txtPotencia.Text)));
        }

        public void AtribuirPontuacaoDeAcordoComAPotencia(int potencia)
        {
            var tempoInformado = TimeSpan.Parse($"00:{txtTempo.Text}");
            var tempo = tempoInformado.Minutes * 60 + tempoInformado.Seconds;
            TimeSpan tempoHoraMinuto;

            _relogio = new Timer
            {
                Interval = 1000
            };

            _relogio.Tick += delegate
            {
                tempo -= 1;

                tempoHoraMinuto = TimeSpan.FromSeconds(tempo);

                txtTempo.Text = $"{tempoHoraMinuto.Minutes:00}:{tempoHoraMinuto.Seconds:00}";

                txtString.Text += AtribuirContagemAsterisco(potencia);

                if (tempo != 0) return;

                _relogio.Stop();

                txtString.Text = "";
                txtAquecido.Visible = true;

                PodeEditarOsCampos(true);

            };

            _relogio.Start();
        }

        public void PodeEditarOsCampos(bool valor)
        {
            txtTempo.Properties.Enabled = valor;
            txtPotencia.Properties.Enabled = valor;
        }

        private StringBuilder AtribuirContagemAsterisco(int potencia)
        {
            var retorno = new StringBuilder();

            for (var i = 0; i < potencia; i++)
                retorno.Append("" + _caractere);

            return retorno;
        }

        private void CmdLigar_Click(object sender, EventArgs e)
        {
            if (MicroondasHelper.ValidarHorarioInformado(txtTempo))
            {
                MessageBox.Show("Horário não informado!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!MicroondasHelper.ValidarPotenciaInformada(txtPotencia))
            {
                MessageBox.Show("Potência incorreta!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtAquecido.Visible = false;

            PodeEditarOsCampos(false);

            AtribuirPontuacaoDeAcordoComAPotencia(Convert.ToInt32(txtPotencia.Text));
        }

        private void CmbPredefinido_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbPredefinido.EditValue.Equals("Arroz"))
            {
                var result = _preDefinidos.FirstOrDefault(x => x.Nome == "Arroz");

                txtTempo.Text = $"{result?.Tempo.Minutes:00}:{result?.Tempo.Seconds:00}";
                txtPotencia.Text = result?.Potencia.ToString("00");
                _caractere = result?.Caractere;
            }
            else if (cmbPredefinido.EditValue.Equals("Carne"))
            {
                var result = _preDefinidos.FirstOrDefault(x => x.Nome == "Carne");

                txtTempo.Text = $"{result?.Tempo.Minutes:00}:{result?.Tempo.Seconds:00}";
                txtPotencia.Text = result?.Potencia.ToString("00");
                _caractere = result?.Caractere;
            }
            else if (cmbPredefinido.EditValue.Equals("Coxinha"))
            {
                var result = _preDefinidos.FirstOrDefault(x => x.Nome == "Coxinha");

                txtTempo.Text = $"{result?.Tempo.Minutes:00}:{result?.Tempo.Seconds:00}";
                txtPotencia.Text = result?.Potencia.ToString("00");
                _caractere = result?.Caractere;
            }
            else if (cmbPredefinido.EditValue.Equals("Frango"))
            {
                var result = _preDefinidos.FirstOrDefault(x => x.Nome == "Frango");

                txtTempo.Text = $"{result?.Tempo.Minutes:00}:{result?.Tempo.Seconds:00}";
                txtPotencia.Text = result?.Potencia.ToString("00");
                _caractere = result?.Caractere;
            }
            else if (cmbPredefinido.EditValue.Equals("Leite"))
            {
                var result = _preDefinidos.FirstOrDefault(x => x.Nome == "Leite");

                txtTempo.Text = $"{result?.Tempo.Minutes:00}:{result?.Tempo.Seconds:00}";
                txtPotencia.Text = result?.Potencia.ToString("00");
                _caractere = result?.Caractere;
            }
            else if (cmbPredefinido.EditValue == cmbPredefinido?.EditValue)
            {
                var result = _preDefinidos.FirstOrDefault(x => x.Nome.Equals(cmbPredefinido.EditValue));

                txtTempo.Text = $"{result?.Tempo.Minutes:00}:{result?.Tempo.Seconds:00}";
                txtPotencia.Text = result?.Potencia.ToString("00");
                _caractere = result?.Caractere;
            }
            else
            {
                MessageBox.Show("Alimento incompatível com o programa!", "Alerta!", MessageBoxButtons.OK);
            }
        }

        private void CmdPausar_Click(object sender, EventArgs e)
        {
            if (_relogio == null) return;

            if (_pausado)
            {
                _relogio.Start();
                _pausado = false;
            }
            else
            {
                _relogio.Stop();
                _pausado = true;
            }
        }

        private void CmdCancelar_Click(object sender, EventArgs e)
        {
            if (_relogio == null) return;

            _relogio.Stop();
            txtTempo.Text = "00:00";
            txtString.Text = "";

            PodeEditarOsCampos(true);
        }

        private void CmdInstrucoes_Click(object sender, EventArgs e)
        {
            var result = _preDefinidos.FirstOrDefault(x => x.Nome.Equals(cmbPredefinido.EditValue));

            var formInstrucoes = new FrmInstrucoes(result);
            formInstrucoes.ShowDialog();
        }

        private void CmdSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CmdAdicionarPredefinicao_Click(object sender, EventArgs e)
        {
            var adicionarPredefinicao = new FrmAdicionarPredefinicao(_preDefinidos);
            adicionarPredefinicao.ShowDialog();

            _preDefinidos = adicionarPredefinicao._preDefinidos;

            cmbPredefinido.Properties.DataSource = _preDefinidos;
        }
    }
}