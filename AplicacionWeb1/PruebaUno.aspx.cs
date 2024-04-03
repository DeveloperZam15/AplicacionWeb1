using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.WebSockets;
using static System.Net.Mime.MediaTypeNames;

namespace AplicacionWeb1
{
    public partial class PruebaUno : System.Web.UI.Page
    {
        ////////////////////////////////////////////////////////////////////////////////        
        //VARIABLES 

        double b, c, d;
        bool tareasPV, practicasPV, examenPV;

        string alerta1 = "Introduce un valor del 0 al 10";

        string sivalido = "form-control is-valid text-center";
        string invalido = "form-control is-invalid";

        ////////////////////////////////////////////////////////////////////////////////V

        // VISUALES DEL PROGRAMA
        void alertaProcessInvalido(TextBox labelValue)
        {
            if (labelValue == examenVal)
            {
                alert1.Text = alerta1;
                alert1.CssClass = invalido;

                examenVal.CssClass = "form-control text-center";
            }
            else if (labelValue == practicasVal)
            {
                alert2.Text = alerta1;
                alert2.CssClass = invalido;

                practicasVal.CssClass = "form-control text-center";
            }
            else if (labelValue == tareasVal)
            {
                alert3.Text = alerta1;
                alert3.CssClass = invalido;

                tareasVal.CssClass = "form-control text-center";
            }
        }

        void alertaProcessValido(TextBox labelValue)
        {
            if (labelValue == examenVal)
            {
                alert1.Text = "";
                alert1.CssClass = "";

                examenVal.CssClass = sivalido;
            }
            else if (labelValue == practicasVal)
            {
                alert2.Text = "";
                alert2.CssClass = "";

                practicasVal.CssClass = sivalido;
            }
            else if (labelValue == tareasVal)
            {
                alert3.Text = "";
                alert3.CssClass = "";

                tareasVal.CssClass = sivalido;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////V

        void valuacion(TextBox labelValue)
        {
            if (String.IsNullOrWhiteSpace(labelValue.Text))
            {
                alertaProcessInvalido(labelValue);
            }
            else
            {
                if (labelValue.Text.All(char.IsDigit) == true)
                {
                    labelProcess(labelValue);
                }
                else
                {
                    alertaProcessInvalido(labelValue);
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////V

        void labelProcess(TextBox labelName)
        {
            double valor;

            valor = Convert.ToDouble(labelName.Text);

            if (valor >= 0 && valor <= 10)
            {
                if (labelName == examenVal)
                {
                    b = (valor * 50) / 10;
                    alertaProcessValido(examenVal);
                    examenPV = true;
                }
                else if (labelName == practicasVal)
                {
                    c = (valor * 30) / 10;
                    alertaProcessValido(practicasVal);
                    practicasPV = true;
                }
                else if (labelName == tareasVal)
                {
                    d = (valor * 20) / 10;
                    alertaProcessValido(tareasVal);
                    tareasPV = true;
                }

            }
            else
            {
                if (labelName == examenVal)
                {
                    alertaProcessInvalido(examenVal);
                }
                else if (labelName == practicasVal)
                {
                    alertaProcessInvalido(examenVal);
                }
                else if (labelName == tareasVal)
                {
                    alertaProcessInvalido(examenVal);
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////V

        void sumaCampos(bool var1, bool var2, bool var3)
        {
            double total;

            if (var1 == true && var2 == true && var3 == true)
            {
                total = b + c + d;

                totalText.Text = total.ToString();
            }
            else
            {
                totalText.Text = string.Empty;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////V

        void calculadora(TextBox var1, TextBox var2, TextBox var3)
        {
            valuacion(var1);
            valuacion(var2);
            valuacion(var3);

            sumaCampos(examenPV, tareasPV, practicasPV);
        }

        ////////////////////////////////////////////////////////////////////////////////V
        protected void btnEnv_Click(object sender, EventArgs e)
        {
            calculadora(practicasVal, tareasVal, examenVal);
        }
    }
}