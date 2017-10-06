using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Gesture
    {
        //member variables
        Random rdm = new Random();

        //constructor
        //wins against:
        //loses against:
        //ties against itself

        //member methods
        void HumanGesture()
        {
            Console.WriteLine("Make your choice:\n[1] Rock\n[2] Paper\n[3] Scissors\n[4] Lizard\n[5] Spock");
            string playerNumberChoice = Console.ReadLine();
            //switch (playerNumberChoice)
            //{
            //    case "1":
            //        Rock;
            //        break;
            //    case "2":
            //        type playerGesture = Gesture.Paper;
            //        break;
            //    case "3":
            //        Gesture = Scissors;
            //        break;
            //    case "4":
            //        //select Lizard
            //        break;
            //    case "5":
            //        //select Spock
            //        break;
            //    default:
            //        Console.WriteLine("Invalid selection.  Please type in '1' '2' '3' '4' or '5'");
            //        SelectGesture();
            //        break;
            }

        }
        //void ComputerGesture(rdm)
        //{
        //    int num = rdm.Next(1, 6);
        //    switch (num)
        //    {
        //        case 1:
        //            //select Rock
        //            break;
        //        case 2:
        //            //select Paper
        //            break;
        //        case 3:
        //            //select Scissors
        //            break;
        //        case 4:
        //            //select Lizard
        //            break;
        //        case 5:
        //            //select Spock
        //            break;
        //    }
        //}
    }

