using System;

namespace My_Asweso_varibles
{
  class Program
    
    {
        static void Main(string[] args)
        {


        int scorePlayer =0;
        int scoreCPU=0;

            String inputplayer,inputCPU;
         for(int i=0;i<5;i++)
         {
        Console.WriteLine("Chose between ROCK, PAPER and SCISSOR: ");
        inputplayer=Console.ReadLine();

        Random rnd = new Random();
        int randomInt  = rnd.Next(1,4);

            switch (randomInt)
        {
//CASE 11111111111111111111111111111111111111111111111111111
            case 1:
            inputCPU ="ROCK";
            Console.WriteLine("Computer chose: " + inputCPU);
           
            if (inputplayer=="ROCK")
                {
                Console.WriteLine("Draw ");
                }

            else if (inputplayer=="PAPER")
                {
                Console.WriteLine("Player got 1 point");
                scorePlayer=scorePlayer+1;
                }

            else 
                {
                Console.WriteLine("CPU got 1 point");
                scoreCPU=scoreCPU+1;
                }
            break;
//CASE 222222222222222222222222222222222222222222222222222
            case 2:
            inputCPU = "PAPER";
            Console.WriteLine("Computer chose: " + inputCPU);
            if (inputplayer=="PAPER")
                {
                Console.WriteLine("Draw ");
                }

            else if (inputplayer=="SCISSOR")
                {
                Console.WriteLine("Player got 1 point");
                scorePlayer=scorePlayer+1;
                }

            else 
                {
                Console.WriteLine("CPU got 1 point");
                scoreCPU=scoreCPU+1;
                }
 
            break;
//CASE 33333333333333333333333333333333333333333333333333333
            case 3:
            inputCPU = "SCISSOR";
            Console.WriteLine("Computer chose: " + inputCPU);
            if (inputplayer=="SCISSOR")
                {
                Console.WriteLine("Draw ");
                }

            else if (inputplayer=="STONE")
                {
                Console.WriteLine("Player got 1 point");
                scorePlayer=scorePlayer+1;
                }

            else 
                {
                Console.WriteLine("CPU got 1 point");
                scoreCPU=scoreCPU+1;
                }

            break;
//Defalt TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
            default:
                Console.WriteLine("Invali Entry!!");
            break;
        }
         }

    Console.WriteLine("FINAL SCORE");
    Console.WriteLine("PLAYER SCORE"+scorePlayer);
    Console.WriteLine("CPU SCORE"+scoreCPU);

    if (scoreCPU>scorePlayer)
    {
        Console.WriteLine("CPU Wins");
    }
    else
    {
        Console.WriteLine("Player Wins");
    }

Console.ReadKey();
        }
    }
}