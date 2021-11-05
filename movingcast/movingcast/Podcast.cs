using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movingcast
{
    class Menu
    {
        public int EscolhaC { get; set; }
        public int EscolhaP { get; set; }
        public int EscolhaE { get; set; }

        public Menu()
        {
            //EscolhaC = escolhaC;
            //EscolhaP = escolhaP;
            //EscolhaE = escolhaE;

        }
        public void SetEscolhaC(int escolhac)
        {
            EscolhaC = escolhac;
        }
        public void SetEscolhaP(int escolhap)
        {
            EscolhaP = escolhap;
        }
        public void SetEscolhaE(int escolhae)
        {
            EscolhaE = escolhae;
        }

        public void ExibeMenu()
        {
            Console.WriteLine("1. Finanças");
            Console.WriteLine("2. Sociais");
            Console.WriteLine("3. Técnicas");
            Console.WriteLine("Sair");
        }
        public void ExibeMenuPodcast(int tipopodcast)
        {
            if (tipopodcast == 1)
            {
                Console.WriteLine("1. NathFinanças");
                Console.WriteLine("2. Financast");
                Console.WriteLine("3. Nerdcash");
            }
            else

            if (tipopodcast == 2)
            {

                Console.WriteLine("1. ImaginaJuntas");
                Console.WriteLine("2. HubCast");
                Console.WriteLine("3. Diario de bordo");

            }
            else

            if (tipopodcast == 3)
            {
                Console.WriteLine("1. ImaginaJuntas");
                Console.WriteLine("2. HubCast");
                Console.WriteLine("3. Diario de bordo");
            }
            else 
            {
                ExibeMenu();
                Console.WriteLine();
            }
            

        }
        public void SetEscolha(int escolhaG)
        {

        }


    }
}
