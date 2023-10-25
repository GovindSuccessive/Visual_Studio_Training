using System;
/*using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace First_Project
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Player 1 Name");
            string p1 = Console.ReadLine();
            Console.WriteLine("Enter Player 2 Name");
            string p2 = Console.ReadLine();
            bool flag = true;
            int p1_score = 0, p2_score = 0;

            while (flag && p1_score < 3 && p2_score < 3)
            {

                Console.WriteLine(p1 + "\tChoose between\t1.Stone\t2.Paper\t3.Scissor");
                string p1_choice = Console.ReadLine();
                Random rd = new Random();
                int num = rd.Next(1, 3);
                string p2_choice = "";


                switch (num)
                {
                    case 1:
                        {
                            p2_choice = "Stone";
                            if (p1_choice == "Stone")
                            {
                                Console.WriteLine(p1 + "choose "+p1_choice);
                                Console.WriteLine(p2 + "choose "+p2_choice);
                                Console.WriteLine("Draw match");
                            }
                            else if (p1_choice == "Paper")
                            {
                                Console.WriteLine(p1 + "choose " + p1_choice);
                                Console.WriteLine(p2 + "choose " + p2_choice);
                                Console.WriteLine("P1 Wins");
                                p1_score++;
                            }
                            else if (p1_choice == "Scissor")
                            {
                                Console.WriteLine(p1 + "choose " + p1_choice);
                                Console.WriteLine(p2 + "choose " + p2_choice);
                                Console.WriteLine("P2 Wins");
                                p2_score++;
                            }
                        }
                        break;

                    case 2:
                        {
                            p2_choice = "Paper";
                            if (p1_choice == "Paper")
                            {
                                Console.WriteLine(p1 + "choose " + p1_choice);
                                Console.WriteLine(p2 + "choose " + p2_choice);
                                Console.WriteLine("Draw match");
                            }
                            else if (p1_choice == "Scissor")
                            {
                                Console.WriteLine(p1 + "choose " + p1_choice);
                                Console.WriteLine(p2 + "choose " + p2_choice);
                                Console.WriteLine("P1 Wins");
                                p1_score++;
                            }
                            else if (p1_choice == "Stone")
                            {
                                Console.WriteLine(p1 + "choose " + p1_choice);
                                Console.WriteLine(p2 + "choose " + p2_choice);
                                Console.WriteLine("P2 Wins");
                                p2_score++;
                            }
                        }
                        break;

                    case 3:
                        {
                            p2_choice = "Scissor";
                            if (p1_choice == "Scissor")
                            {
                                Console.WriteLine(p1 + "choose " + p1_choice);
                                Console.WriteLine(p2 + "choose " + p2_choice);
                                Console.WriteLine("Draw match");
                            }
                            else if (p1_choice == "Stone")
                            {
                                Console.WriteLine(p1 + "choose " + p1_choice);
                                Console.WriteLine(p2 + "choose " + p2_choice);
                                Console.WriteLine("P1 Wins");
                                p1_score++;
                            }
                            else if (p1_choice == "Paper")
                            {
                                Console.WriteLine(p1 + "choose " + p1_choice);
                                Console.WriteLine(p2 + "choose " + p2_choice);
                                Console.WriteLine("P2 Wins");
                                p2_score++;
                            }
                        }
                        break;
                    default: break;

                }
                if (p1_score == 3)
                {
                    flag = false;
                    Console.WriteLine("congratulation " + p1 + "! you are wins the game");
                }
                if (p2_score == 3)
                {
                    flag = false;
                    Console.WriteLine("congratulation " + p2 + "! you are wins the game");
                }

            }
        }
    }
}
