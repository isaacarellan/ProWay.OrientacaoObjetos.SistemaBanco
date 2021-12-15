using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProWay.OrientacaoObjetos.Models.ContaBancaria
{
    public class ContaPoupanca: Conta
    {
        public readonly string DescricaoConta;
        //Constructor es una forma de garantizar que el objeto
        // es construido de la forma correcta, es decir , en este escenario
        //para abrir una conta poupança e obligatorio
        // tener nombre y saldo de la cuenta antes de conseguir abror
        // efectivamente
        public ContaPoupanca  (string nome, double saldo)
        {
            Nome = nome;
            Saldo = saldo;
            DescricaoConta = "Meu Texto";
        }

        public override void Depositar(double valorDeposito)
        {
            var novoValor = valorDeposito * 1.05;
            Saldo += novoValor;
        }
        /*internal class ContaSalario
         * 
         * public int Nome {get ; set; }
         * public double Saldo {get; set;}
         * public void Depositar(double valor)
         * 
         * */
    }
}
