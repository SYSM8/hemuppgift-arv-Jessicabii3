using Hemuppgift_Arv_Temp.Game;
using System;
using System.Net.WebSockets;

namespace Hemuppgift_Arv_Temp
{
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        /*F2 a) Klassen player är en basklass.
         
             b) De korrekta tilldelningsatserna är: 
                2) Player p = new HumanPlayer("Alicent");
                3) HumanPlayer p = new HumanPlayer("Rhaenyra");*/
        static void Main(string[] args)
        {
            

            // Skapa ett Board-objekt
            Board board = new Board();
            board.SetUp(40);

            Player player1 = new HumanPlayer("Jenny Nguyen");
            //Player player2 = new ComputerPlayer("Siri Jobs");
            Player player3 = new SmartComputer("Alexa Google");

            Console.WriteLine($"Välkommen {player1.GetUserId()}!" +
                $" Du ska nu plocka upp den sista stickan från vårt mystiska bord." +
                $" Varje drag ger dig möjlighet att ta antingen 1-2 stickor, så välj klokt." +
                $" Den som tar den sista stickan kommer att bli vår hedersamma vinnare!");

            // While-loop för spelets gång
            while (board.GetNoPins() > 0)
            {
                // Spelare 1 (Human)
               
                int player1Taken = player1.TakePins(board);
                board.TakePins(player1Taken);
                Console.WriteLine($"Kvarvarande stickor: {board.NoPins} efter {player1.GetUserId()}'s tur.");




                // Kontrollera om spelaren har vunnit.
                if (board.GetNoPins() == 0)
                {
                    Console.WriteLine("Grattis, du vann!!");
                    return; // Avslutar spelet
                }

                // Spelare 2 (Computer)
                
                //int player2taken=player2.TakePins(board);
                //Console.WriteLine($"Kvarvarande stickor efter {player2.GetUserId()}'s tur");

                //// Kontrollera om datorn har vunnit
                //if (board.GetNoPins() == 0)
                //{
                //    Console.WriteLine("Game Over, Siri Jobs vann.");
                //    return; // Avslutar spelet
                //}

                //Spelare 3 (SmartComputer)
                int player3taken=player3.TakePins(board);
                board.TakePins(player3taken);
                Console.WriteLine($"Alexa tar: {player3taken}. Kvarvarande stickor: {board.NoPins} efter {player3.GetUserId()}'s tur.");
                if(board.GetNoPins() == 0)
                {
                    Console.WriteLine("Game over, Alexa vann!!");
                    return; //Avslutar spelet
                }
            }


        }

    }
}
