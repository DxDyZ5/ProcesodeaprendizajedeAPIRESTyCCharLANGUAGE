using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_EX
{
    public class Cuenta 
    {
        public Persona Titular;
        private decimal balance;

        public Cuenta(Persona titular, decimal balance = 0)
        {
            this.Titular = titular;
            this.balance = balance;
        }



        public void depositar(decimal cantidad)
        {
           balance += cantidad;
        }

        public void retirar(decimal cantidad)
        {
            if (cantidad <= balance)
            {
                balance -= cantidad;
            }
            else
            {
                Console.WriteLine("No hay balance suficiente en la cuenta");
            }
        }

        public override string ToString()
        {
            return "Titular: " + Titular.ToString() + ", Balance: " + balance;
        }

    }
}
