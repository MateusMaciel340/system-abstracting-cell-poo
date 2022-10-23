using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace system_abstracting_cell_poo.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string number, string model, string imei, int memory) : base(number, model, imei, memory)
        {

        }

        public override void InstallApp(string nameApp)
        {
            Console.WriteLine($"Aplicativo {nameApp} instalado no iphone!");
        }
    }
}