using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace system_abstracting_cell_poo.Models
{
    public abstract class Smartphone
    {
        public Smartphone()
        {

        }

        public string Number { get; set; }
        private string Model { get; set; }
        private string Imei { get; set; }
        private int Memory { get; set; }

        public Smartphone(string number, string model, string imei, int memory)
        {
            Number = number;
            Model = model;
            Imei = imei;
            Memory = memory;
        }

        public void TurnOn()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstallApp(string nameApp);
    }
}