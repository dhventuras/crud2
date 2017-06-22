using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WebApplication1.Utils
{
    public class Tools // a classe tools é um conjuntos de validação ontem fica algumas validações.
    {
        
        public static DateTime validaDate(string dados, string Nomecampo, Label label)//este método faz a conversão do modelo de data americano para o modelo brasileiro.
        {
            DateTime data;

            if (DateTime.TryParse(dados, System.Globalization.CultureInfo.GetCultureInfo("pt-br"),
                System.Globalization.DateTimeStyles.None, out data) == false)
            {
                label.Text = Nomecampo + " inválido!";
                return default(DateTime);
            }
            return data;
        }

        public static string validaString(string dados, string Nomecampo, Label label)// valida as string e email 
        {

            if (dados.Trim().Length == 0)
            {
                label.Text = Nomecampo + " não pode estar em branco";
                return null;
            }

            if (Nomecampo == "Email")
            {
                string email = dados.Trim();
                int arroba, arroba2, ponto;

                arroba = email.IndexOf('@');
                arroba2 = email.LastIndexOf('@');
                ponto = email.LastIndexOf('.');

                if (arroba <= 0 || ponto <= (arroba + 1) || ponto == (email.Length - 1) || arroba2 != arroba)
                {
                    label.Text = Nomecampo + " Inválido";
                    return null;
                }
            }
            return dados;
        }

        public static int validaInt(string dados, string Nomecampo, Label label)// aqui valida se o int e maior que zero se for menor ja acusa erro.
        {
            int vlRetornado;

            if (int.TryParse(dados, out vlRetornado) == false)
            {
                label.Text = Nomecampo + " inválido!";
                return -1;
            }

            if (vlRetornado <= 0)
            {
                label.Text = Nomecampo + " tem que ser acima de 0";
                return -1;
            }
            return vlRetornado;
        }
    }
}