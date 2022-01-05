using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainMenu;
namespace StartProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;//змінюємо кодування консолі
            Console.InputEncoding = Encoding.Unicode;
            Menu.StartProject();
        }
    }
}
