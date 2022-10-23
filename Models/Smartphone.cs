using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace system_abstracting_cell_poo.Models
{
    public abstract class Smartphone
    {
        public string Number { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string number)
        {
            Number = number;
            // TODO: Passar os parâmetros do construtor para as propriedades
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