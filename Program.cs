using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            GameEngineFacade gameFacade = new GameEngineFacade(
                new CodeRedactor(),
                new Compilation(),
                new Render(),
                new AppControl());
            Client person = new Client();
            person.createApp(gameFacade);

            Console.ReadKey();
        }
    }
}
