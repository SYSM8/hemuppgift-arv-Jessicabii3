using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class ComputerPlayer:Player
    {
        Random random = new Random(); //Skapar ett random-obj för att generera slumpmässiga tal.

        //Konstruktor
        public ComputerPlayer(string userId): base(userId)
        {

        }
        //Metod
        public override int TakePins(Board board)
        {
            //Slumpmässigt väljer 1 eller 2 stickor.


            int noPins = board.GetNoPins();
            int taken;
            if (noPins == 1)
            {
                taken = 1;
                Console.WriteLine($"Siri tar {taken} sticka.");

            }
            else
            {
                //Slumpmässigt mellan 1 och 2
                taken=random.Next(1,Math.Min(3,noPins+1));
                Console.WriteLine($"Siri tar {taken} stickor.");
            }
             board.TakePins(taken);
            return taken;
           
        }
    }
}
