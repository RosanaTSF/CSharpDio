using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanade.cs.Design
{
    public class Stylist
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Cat: {Nome}\nTenho: {Idade} anos");
        }   
    }
} 