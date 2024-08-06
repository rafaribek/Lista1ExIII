using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ExIII
{
    public class Conta
    {
        private string numero;
        private string titular;

        public string Numero { get; set; }
        public string Titular { get; set; }

        public Conta(string Numero, string Titular)
        {
            this.Numero = Numero;
            this.Titular = Titular;
        }
    }
    public class ContaBancaria : Conta
    {
        private double saldo;

        public double Saldo { get; set; }

        public ContaBancaria(string Numero, string Titular, double Saldo) : base(Numero, Titular)
        {
            this.Saldo = Saldo;
        }

        public void Depositar(double Valor)
        {
            if (Valor > 0)
            {
                Saldo += Valor;
                Console.WriteLine("Depósito realizado no valor de: R$" + Valor);
            }
            else
            {
                throw new ArgumentException("O valor de depósito não pode ser menor ou igual a zero");
            }
            

        }
        public void Sacar(double Valor)
        {
            if (Valor > 0)
            {
                Saldo -= Valor;
                Console.WriteLine("Saque realizado no valor de: R$" + Valor);
            }
            else
            {
                throw new ArgumentException("O valor de saque não pode ser menor ou igual a zero");
            }
            
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    ContaBancaria conta = new ContaBancaria("127005-2", "Flávio", 1720.29);
                    Console.WriteLine($"Número da conta: {conta.Numero}");
                    Console.WriteLine($"Titular da conta: {conta.Titular}");
                    Console.WriteLine($"Saldo inicial: R${conta.Saldo}");
                    conta.Sacar(250.72);
                    Console.WriteLine($"o valor do saldo após o saque é de : R${conta.Saldo}");
                    conta.Depositar(150.50);
                    Console.WriteLine($"o valor do saldo após o depósito é de : R${conta.Saldo}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
