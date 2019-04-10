using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    partial class Practice
    {
        //B4-P1/25. If_TimeOfDayGreeting
        public static void B4_P1_25_If_TimeOfDayGreeting()
        {
        }

        //B4-P2/25. If_NumbersComparing
        public static void B4_P2_25_If_NumbersComparing()
        {
        }

        //B4-P3/25. If_PositiveNumbersComparing
        public static void B4_P3_25_If_PositiveNumbersComparing()
        {
        }

        //B4-P4/25. If_Akinator5Numbers
        public static void B4_P4_25_If_Akinator5Numbers()
        {
            
        }

        //B4-P5/25. Switch_DayOfWeek
        public static void B4_P5_25_Switch_DayOfWeek()
        {
        }

        //B4-P6/25. Switch_GameNavigation
        public static void B4_P6_25_Switch_GameNavigation()
        {
            
        }

        //B4-P7/25. For_10OddEven
        public static void B4_P7_25_For_10OddEven()
        {
            
        }


        //B4-P8/25. For_3DevideNumbers
        public static void B4_P8_25_For_3DevideNumbers()
        {
        }


        //B4-P9/25. For_Matrix10x10
        public static void B4_P9_25_For_Matrix10x10()
        {
           
        }


        //B4-P10/25. For_HelloWorld
        public static void B4_P10_25_For_HelloWorld()
        {
        }


        //B4_P11/25. For_Afrochildren
        public static void B4_P11_25_For_Afrochildren()
        {
            
        }


        //B4-P12/25. For_Minus10OddEven
        public static void B4_P12_25_For_Minus10OddEven()
        {
        }


        //B4-P13/25 For_LettersCount
        public static void B4_P13_25_For_LettersCount()
        {
            Console.Write("enter the word: ");
            string word = Console.ReadLine();
            int lettersCount = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    lettersCount++;
                }
            }
            Console.WriteLine(lettersCount);
        }


        //B4-P14/25 *For_AlphabetBack
        public static void B4_P14_25_For_AlphabetBack()
        {
            for (int i = 'z'; i >= 'a'; i--)
            {
                Console.Write(Convert.ToChar(i) + " ");
            }
        }


        //B4-P15/25 While_OddEventNumber
        public static void B4_P15_25_While_OddEventNumber()
        {
            
        }


        //B4-P16/25 DoWhile_OddEventNumber
        public static void B4_P16_25_DoWhile_OddEventNumber()
        {
           
        }


        //B4-P17/25 While_HelloWorld
        public static void B4_P17_25_While_HelloWorld()
        {
        }


        //B4-P18/25 While_Multiplier
        public static void B4_P18_25_While_Multiplier()
        {
            Console.Write("enter the number: ");
            int.TryParse(Console.ReadLine(), out var num);
            Console.Write("enter the degree of number: ");
            int.TryParse(Console.ReadLine(), out var degree);
            int count = 1;
            int result = num;
            while (count < degree)
            {
                result *= num;
                count++;
            }
            if (degree == 0) { result = 1; }
        }


        //B4-P19/25 While_SolveNumberAdding
        public static void B4_P19_25_While_SolveNumberAdding()
        {
            
        }


        //B4-P20/25 While_DiceGame
        public static void B4_P20_25_While_DiceGame()
        {
            
        }


        //B4-P21/25 *While_DiceGameMultiplePlayers
        public static void dB4_P21_25_While_DiceGameMultiplePlayers()
        {
            int PositionPlayerOne = 0;
            int PositionPlayerTwo = 0;
            int count = 0;
            while (PositionPlayerOne < 25 && PositionPlayerTwo < 25)
            {
                var rand = new Random(DateTime.Now.Millisecond);
                int move = rand.Next(1, 7);
                Console.Write("number of steps: " + move);
                Console.WriteLine();
                if (count == 0)
                {
                    PositionPlayerOne += move;
                    Console.Write("Player one move and his new position: " + PositionPlayerOne);
                    Console.WriteLine();
                    count++;
                }
                else
                {
                    PositionPlayerTwo += move;
                    Console.Write("Player two move and his new position: " + PositionPlayerTwo);
                    Console.WriteLine();
                    count--;
                }
            }
            Console.WriteLine(PositionPlayerOne >= 25 ? "Player one win" : "Player two win");
        }


        //B4-P22_25 *While_Akinator100Numbers
        public static void B4_P22_25_While_Akinator100Numbers()
        {
            int a = 1;
            int b = 100;
            Console.WriteLine("make a number. answer 'yes' or 'no' only");
            while (b - a != 1)
            {
                Console.WriteLine("is it more or equal " + (a + (b - a) / 2) + "?");
                if (Console.ReadLine() == "yes")
                {
                    a = a + (b - a) / 2;
                }
                else
                {
                    b = a + (b - a) / 2;
                }
            }
            Console.WriteLine($"is it {a}?");
            if (Console.ReadLine() == "no")
            {
                Console.WriteLine($"the number you made is {b}");
            }
        }


        //B4-P23/25 IfElse_Calcultor
        public static void B4_P23_25_IfElse_Calcultor()
        {
            
        }


        //B4-P24_25 Switch_Calculator
        public static void B4_P24_25_Switch_Calculator()
        {
            
        }


        //B4-P25/25 Cycle_WordRevercse
        public static void B4_P25_25_Cycle_WordRevercse()
        {
            Console.Write("enter the word: ");
            string word = Console.ReadLine();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
            Console.WriteLine();
        }
    }
}
