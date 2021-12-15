using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProWay.OrientacaoObjetos.Models.ContaBancaria
{
    public class ContaCorrente: Conta
    {

        public ContaCorrente(double saldo)
        {
            if(saldo <= 0)
            {
                throw new Exception("Saldo da conta não pode ser negativo");
            }
            Saldo = saldo;
        }

        public override void Depositar(double valorDeposito)
        {
            if(valorDeposito < 0)
            {
                throw new Exception("Valor do desposito deve ser maior do que 0.");
            }
            Saldo += valorDeposito;
        }

        public override void Sacar(double valorSaque)
        {
            //Ejecutando el metodo sacar de la clase conta,
            // que vino atraves de la herencia
            base.Sacar(valorSaque);

            Saldo -= 5;
        }
    }
}
