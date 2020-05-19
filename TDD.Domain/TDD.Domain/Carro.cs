using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Test;

namespace TDD.Domain
{
    public class Carro
    {
        public Motor Motor { get; private set; }
        public Lataria Lataria { get; private set; }
        public List<Roda> Rodas
        {
            get
            {
                return Rodas;
            }
            set
            {

            }

        }
        public List<Porta> Portas
        {
            get
            {
                return Portas;
            }
            set
            {

            }
        }


        public Carro()
        {
            Motor = new Motor();
            Motor = Motor;
            Lataria = Lataria;
            Portas = new List<Porta>();
            Rodas = new List<Roda>();
        }

    }
}
