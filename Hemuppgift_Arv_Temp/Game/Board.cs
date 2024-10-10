using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class Board
    {
        //Private field som håller koll på antalet stickor
        private int noPins;

        //Public field för tillgång till andra klasser
        public int NoPins
        {
            get { return NoPins; } //Hämtar antalet stickor
            set { NoPins = value; } //Sätter ett nytt värde anatalet stickor
        }

        //Metod 
        //För att ange antalet stickor
        public void SetUp(int setup, int maxValue)
        {
            if (setup > 0 && setup <= maxValue) //Kontrollera att antalet stickor är mellan 1 och maxvärdet
            {
                {
                    NoPins = setup;////Tilldeling för det giltiga värdet till NoPins-egenskapen
                    Console.WriteLine($"Antal stickor vid start: {NoPins}");
                }
            }
            else
            {
                //Felmeddelande
                Console.WriteLine($"Vänligen ange stickor mellan 1 och {maxValue}");
            }
        }
        
        public void TakePins(int takePins)
        {
            //Kontrollera att antalet stickor som plockas inte överstiger kvarande och att antalet stickor är positivt
            if (takePins == 1 || takePins == 2 && takePins <= NoPins)
            {
                NoPins -= takePins;
                Console.WriteLine($"Tagna stickor: {takePins}, kvarvarande stickor: {NoPins}");
            }
            else if(takePins > noPins)
            {
                Console.WriteLine("Ogiltig antal stickor att ta.");
            }
            else
            {
                Console.WriteLine("Du får endast ta 1 eller 2.");
            }
        }
        public void GetNoPins()
        {
            Console.WriteLine($"Antal stickor kvar: {NoPins}"); //Utskrift av antal kvarstående stickor.
        }
    }
}
