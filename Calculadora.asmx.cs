using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Operaciones
{
    /// <summary>
    /// Descripción breve de Calculadora
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Calculadora : System.Web.Services.WebService
    {

        [WebMethod(Description = "Suma de numeros")]
        public double Suma(double nro1, double nro2)
        {
            double resultado;
            resultado = nro1 + nro2;
            return resultado;
        }
        [WebMethod(Description = "Resta de dos numeros")]
        public double Resta(double nro1, double nro2)
        {
            double resultado;
            resultado = nro1 - nro2;
            return resultado;
        }
        [WebMethod(Description = "Multiplicacion de dos numeros")]
        public double Multiplicacion(double nro1, double nro2)
        {
            double resultado;
            resultado = nro1*nro2;
            return resultado;
        }
        [WebMethod(Description = "Division de dos numeros")]
        public double Division(double nro1, double nro2)
        {
            double resultado;
            resultado = nro1/nro2;
            return resultado;
        }
        [WebMethod(Description = "Residuo de dos numeros")]
        public double Residuo(double nro1, double nro2)
        {
            double resultado;
            resultado = nro1%nro2;
            return resultado;
        }
        private double Factorial(int n)
        {
            if (n == 0) return 1;
            else return n * Factorial(n - 1);
        }
        [WebMethod(Description = "Factorial de un numero")]
        public double Fact(int n)
        {
            return Factorial(n);
        }
        [WebMethod(Description = "Potencia de un numero")]
        public double Potencia(int potencia, int exponente)
        {
            double resultado;
            resultado = Math.Pow(potencia, exponente);
            return resultado;
        }
        [WebMethod(Description = "Logaritmo natural de un numero")]
        public double Logaritmo_Natural(int n)
        {
            double resultado;
            resultado = Math.Log(n);
            return resultado;
        }
        [WebMethod(Description = "Logaritmo base 10 de un numero")]
        public double Logaritmo_base10(int n)
        {
            double resultado;
            resultado = Math.Log10(n);
            return resultado;
        }
        [WebMethod(Description = "Raiz cuadrada de un numero")]
        public double Raiz_cuadrada(int n)
        {
            double resultado;
            resultado = Math.Sqrt(n);
            return resultado;
        }

    }
    }

