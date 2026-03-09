using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public  class Professor : Pessoa
    {
        public Professor()
        {
            
        }
        public Professor(string nome) : base(nome)
        {
            
        }
        public double Salario { get; set; }
        public override void Aprensentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um professor(a) e o meu salário é {Salario}.");
        }
    }
}