using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProWay.OrientacaoObjetos.Models.ContaBancaria
{
    public abstract class Conta
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public double Saldo { get; set; }
        public abstract void Depositar(double valorSaque);

        //Virtual permite a la clase hija modificar el comportamiento del metodo
        // es decir, hacer e lsqque de manera diferente
        public virtual void Sacar(double valorSaque)
        {   
            if(valorSaque <= Saldo)
            {
                Saldo -= valorSaque;
            }
            else
            {
                throw new Exception("Valor deo saque maior do que o saldo, não e possivel realizar o saque.");
            }
        }
        public override string ToString()
        {
            return $"Código: {Codigo} Nome: {Nome} Saldo: {Saldo}";
        }
    }
}
