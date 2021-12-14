using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProWay.OrientacaoObjetos.Models.ContaBancaria
{
    public class ContaPopanca: Conta
    {
        //Constructor es una forma de garantizar que el objeto
        // es construido de la forma correcta, es decir , en este escenario
        //para abrir una conta poupança e obligatorio
        // tener nombre y saldo de la cuenta antes de conseguir abror
        // efectivamente
        public ContaPopanca  (string nome, double saldo)
        {
            Nome = nome;
            Saldo = saldo;
        }

    }
}
