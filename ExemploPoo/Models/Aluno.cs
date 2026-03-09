using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Aluno : Pessoa
    {
        public Aluno()
        {
            
        }
        public Aluno(string nome) : base(nome)
        {
            
        }
        public double Nota { get; set; }
        public override void Aprensentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um aluno(a) nota{ Nota}!");
        }
    }
}