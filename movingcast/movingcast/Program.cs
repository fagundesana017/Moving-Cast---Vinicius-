using System;
using System.Collections.Generic;
namespace movingcast
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            int escolhaP;
            menu.ExibeMenu();
         
                escolhaP = int.Parse(Console.ReadLine());
                menu.ExibeMenuPodcast(escolhaP);

        
        }
    }
}
