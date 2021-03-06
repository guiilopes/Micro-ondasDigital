﻿using System;
using DevExpress.XtraEditors;
using MicroondasDigital.Domain.MicroondasDigitais.Results;

namespace MicroondasDigital.Domain.MicroondasDigitais.Helpers
{
    public class MicroondasHelper
    {
        public static string ObterInstrucao(string alimento)
        {
            string retorno;

            if (alimento.Equals("Arroz"))
                retorno = Resources.Resource.ArrozRtf;
            else if (alimento.Equals("Carne"))
                retorno = Resources.Resource.CarneRtf;
            else if (alimento.Equals("Coxinha"))
                retorno = Resources.Resource.CoxinhaRtf;
            else if (alimento.Equals("Frango"))
                retorno = Resources.Resource.FrangoRtf;
            else if (alimento.Equals("Leite"))
                retorno = Resources.Resource.LeiteRtf;
            else
                retorno = "Alimento inválido!";

            return retorno;
        }

        public static PreDefinidosResult PreencherResult(string nome, int potencia, TimeSpan tempo, string caractere)
        {
            return new PreDefinidosResult
            {
                Nome = nome,
                Potencia = potencia,
                Tempo = tempo,
                Caractere = caractere
            };
        }

        public static bool ValidarHorarioInformado(TextEdit tempo)
        {
            return tempo.Text.Equals("00:00");
        }

        public static bool ValidarPotenciaInformada(TextEdit potencia)
        {
            var valor = Convert.ToInt32(potencia.Text);

            return valor >= 1 && valor <= 10;
        }
    }
}
