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
            for (int i = 122; i >= 97; i--)
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
            int result = num;
            do
            {
                result *= num;
            } while (result != Math.Pow(num, degree));
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
            Console.WriteLine("make a number. answer 'yes' or 'no' only");
            string answer = null;
            Console.WriteLine("is it even number?");
            answer = Console.ReadLine().ToLower();
            if (answer == "yes")
            {
                Console.WriteLine("is it contains zero?");
                answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                {
                    Console.WriteLine("is the first digit a simple number?");
                    answer = Console.ReadLine().ToLower();
                    if (answer == "yes")
                    {
                        Console.WriteLine("is it more then 40?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes")
                        {
                            Console.WriteLine("is it multiple of 15?");
                            answer = Console.ReadLine().ToLower();
                            if (answer == "yes")
                            {
                                Console.WriteLine("you made a number 30");
                            }
                            else
                            {
                                Console.WriteLine("you made a number 10");
                            }
                        }
                        else
                        {
                            Console.WriteLine("is it multiple of 25?");
                            answer = Console.ReadLine().ToLower();
                            if (answer == "yes")
                            {
                                Console.WriteLine("you made a number 50");
                            }
                            else
                            {
                                Console.WriteLine("you made a number 70");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("is it more than 50?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes")
                        {
                            Console.WriteLine("is it multiple of 3?");
                            answer = Console.ReadLine().ToLower();
                            if (answer == "yes")
                            {
                                Console.WriteLine("is it multiple of 4?");
                                answer = Console.ReadLine().ToLower();
                                if (answer == "yes")
                                {
                                    Console.WriteLine("you made a number 60");
                                }
                                else
                                {
                                    Console.WriteLine("you made a number 90");
                                }
                            }
                            else
                            {
                                Console.WriteLine("is it multiple of 40?");
                                answer = Console.ReadLine().ToLower();
                                if (answer == "yes")
                                {
                                    Console.WriteLine("you made a number 80");
                                }
                                else
                                {
                                    Console.WriteLine("you made a number 100");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("is it multiple of 8?");
                            answer = Console.ReadLine().ToLower();
                            if (answer == "yes")
                            {
                                Console.WriteLine("you made a number 40");
                            }
                            else
                            {
                                Console.WriteLine("you made a number 20");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("is it consist of two digits?");
                    answer = Console.ReadLine().ToLower();
                    if (answer == "yes")
                    {
                        Console.WriteLine("is the first digit a simple number?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes")
                        {
                            Console.WriteLine("is the number rounded up?");
                            answer = Console.ReadLine().ToLower();
                            if (answer == "yes")
                            {
                                Console.WriteLine("is it multiple of 4?");
                                answer = Console.ReadLine().ToLower();
                                if (answer == "yes")
                                {
                                    Console.WriteLine("is it more than 50?");
                                    answer = Console.ReadLine().ToLower();
                                    if (answer == "yes")
                                    {
                                        Console.WriteLine("is it multiply of 28?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 56");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 76");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("is it multiple of 8?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 16");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 36");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("is it more than 50?");
                                    answer = Console.ReadLine().ToLower();
                                    if (answer == "yes")
                                    {
                                        Console.WriteLine("is it multiple of 29?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 58");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 78");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("is it multiple of 9?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 18");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 38");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("is it multiple of 4?");
                                answer = Console.ReadLine().ToLower();
                                if (answer == "yes")
                                {
                                    Console.WriteLine("is it more than 50?");
                                    answer = Console.ReadLine().ToLower();
                                    if (answer == "yes")
                                    {
                                        Console.WriteLine("is the sum of digits more than 8?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 72");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 52");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("is the sum of digits more than 4?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 32");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 12");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("is it more than 50?");
                                    answer = Console.ReadLine().ToLower();
                                    if (answer == "yes")
                                    {
                                        Console.WriteLine("is the sum of digits more than 10?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 74");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 54");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("is the sum of digits more than 6?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 34");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 14");
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("is the number rounded up?");
                            answer = Console.ReadLine().ToLower();
                            if (answer == "yes")
                            {
                                Console.WriteLine("is it multiple of 4?");
                                answer = Console.ReadLine().ToLower();
                                if (answer == "yes")
                                {
                                    Console.WriteLine("is it more than 50?");
                                    answer = Console.ReadLine().ToLower();
                                    if (answer == "yes")
                                    {
                                        Console.WriteLine("is it consist of similar numbers?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 88");
                                        }
                                        else
                                        {
                                            Console.WriteLine("all digits are even numbers?");
                                            answer = Console.ReadLine().ToLower();
                                            if (answer == "yes")
                                            {
                                                Console.WriteLine("you made the 68");
                                            }
                                            else
                                            {
                                                Console.WriteLine("you made the 96");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("is the sum of digits more than 11?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 48");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 28");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("is it more than 50?");
                                    answer = Console.ReadLine().ToLower();
                                    if (answer == "yes")
                                    {
                                        Console.WriteLine("is it consist of similar numbers?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 66");
                                        }
                                        else
                                        {
                                            Console.WriteLine("all digits are even numbers?");
                                            answer = Console.ReadLine().ToLower();
                                            if (answer == "yes")
                                            {
                                                Console.WriteLine("you made the 86");
                                            }
                                            else
                                            {
                                                Console.WriteLine("you made the 98");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("is the sum of digits more than 9?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 46");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 26");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("is it multiple of 4?");
                                answer = Console.ReadLine().ToLower();
                                if (answer == "yes")
                                {
                                    Console.WriteLine("is it more than 50?");
                                    answer = Console.ReadLine().ToLower();
                                    if (answer == "yes")
                                    {
                                        Console.WriteLine("all digits are even numbers?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("is the sum of digits more than 11?");
                                            answer = Console.ReadLine().ToLower();
                                            if (answer == "yes")
                                            {
                                                Console.WriteLine("you made the 84");
                                            }
                                            else
                                            {
                                                Console.WriteLine("you made the 64");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 92");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("all digits are similar?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 44");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 24");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("is it more than 50?");
                                    answer = Console.ReadLine().ToLower();
                                    if (answer == "yes")
                                    {
                                        Console.WriteLine("all digits are even numbers?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 94");
                                        }
                                        else
                                        {
                                            Console.WriteLine("is the sum of digits more than 9?");
                                            answer = Console.ReadLine().ToLower();
                                            if (answer == "yes")
                                            {
                                                Console.WriteLine("you made the 82");
                                            }
                                            else
                                            {
                                                Console.WriteLine("you made the 62");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("all digits are similar?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 22");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 42");
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("is it multiple of 4?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes")
                        {
                            Console.WriteLine("is it looks like the infinity?");
                            answer = Console.ReadLine().ToLower();
                            if (answer == "yes")
                            {
                                Console.WriteLine("you made the 8");
                            }
                            else
                            {
                                Console.WriteLine("you made the 4");
                            }
                        }
                        else
                        {
                            Console.WriteLine("is it multiple of 3?");
                            answer = Console.ReadLine().ToLower();
                            if (answer == "yes")
                            {
                                Console.WriteLine("you made the 6");
                            }
                            else
                            {
                                Console.WriteLine("you made the 2");
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("is it consist of two digits?");
                answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                {
                    Console.WriteLine("is the first digit simple number?");
                    answer = Console.ReadLine().ToLower();
                    if (answer == "yes")
                    {
                        Console.WriteLine("is it multiple of 5?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes")
                        {
                            Console.WriteLine("is it more than 50?");
                            answer = Console.ReadLine().ToLower();
                            if (answer == "yes")
                            {
                                Console.WriteLine("is the sum of digits more than 11?");
                                answer = Console.ReadLine().ToLower();
                                if (answer == "yes")
                                {
                                    Console.WriteLine("you made the 75");
                                }
                                else
                                {
                                    Console.WriteLine("you made the 55");
                                }
                            }
                            else
                            {
                                Console.WriteLine("is the sum of digits more than 7?");
                                answer = Console.ReadLine().ToLower();
                                if (answer == "yes")
                                {
                                    Console.WriteLine("you made the 35");
                                }
                                else
                                {
                                    Console.WriteLine("you made the 15");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("is it rounded up?");
                            answer = Console.ReadLine().ToLower();
                            if (answer == "yes")
                            {
                                Console.WriteLine("is it more than 50?");
                                answer = Console.ReadLine().ToLower();
                                if (answer == "yes")
                                {
                                    Console.WriteLine("is it a simple number?");
                                    answer = Console.ReadLine().ToLower();
                                    if (answer == "yes")
                                    {
                                        Console.WriteLine("is the sum of digits more than 15?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 79");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 59");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("is it multiple of 7?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 77");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 57");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("is the second digit a simple number?");
                                    answer = Console.ReadLine().ToLower();
                                    if (answer == "yes")
                                    {
                                        Console.WriteLine("is the sum of digits more than 9?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 37");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 17");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("is the sum of digits more than 11?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 39");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 19");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("is it more than 50?");
                                answer = Console.ReadLine().ToLower();
                                if (answer == "yes")
                                {
                                    Console.WriteLine("is the multiplying of digits more than 10?");
                                    answer = Console.ReadLine().ToLower();
                                    if (answer == "yes")
                                    {
                                        Console.WriteLine("is the sum of digits more than 9?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 73");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 53");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("is the sum of digits more than 7?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 71");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 51");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("the digits are similar?");
                                    answer = Console.ReadLine().ToLower();
                                    if (answer == "yes")
                                    {
                                        Console.WriteLine("it the sum of digits more than 5?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 33");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 11");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("is the subtraction of digits positive?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 31");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 13");
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("is it multiple of 5?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes")
                        {
                            Console.WriteLine("is the digits more than 50?");
                            answer = Console.ReadLine().ToLower();
                            if (answer == "yes")
                            {
                                Console.WriteLine("the first digit are even?");
                                answer = Console.ReadLine().ToLower();
                                if (answer == "yes")
                                {
                                    Console.WriteLine("is the sum of digits more than 12?");
                                    answer = Console.ReadLine().ToLower();
                                    if (answer == "yes")
                                    {
                                        Console.WriteLine("you mede the 85");
                                    }
                                    else
                                    {
                                        Console.WriteLine("you mede the 65");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("you mede the 95");
                                }
                            }
                            else
                            {
                                Console.WriteLine("is the sum of digits more than 8?");
                                answer = Console.ReadLine().ToLower();
                                if (answer == "yes")
                                {
                                    Console.WriteLine("you made the 45");
                                }
                                else
                                {
                                    Console.WriteLine("you made the 25");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("is it rounded up?");
                            answer = Console.ReadLine().ToLower();
                            if (answer == "yes")
                            {
                                Console.WriteLine("is it a simple number?");
                                answer = Console.ReadLine().ToLower();
                                if (answer == "yes")
                                {
                                    Console.WriteLine("is it more than 50?");
                                    answer = Console.ReadLine().ToLower();
                                    if (answer == "yes")
                                    {
                                        Console.WriteLine("is the first digit even?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("is the sum of digits more than 15?");
                                            answer = Console.ReadLine().ToLower();
                                            if (answer == "yes")
                                            {
                                                Console.WriteLine("you made the 89");
                                            }
                                            else
                                            {
                                                Console.WriteLine("you made the 67");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 97");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("is the multiplying of digits more than 20?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 47");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 29");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("is it more than 50?");
                                    answer = Console.ReadLine().ToLower();
                                    if (answer == "yes")
                                    {
                                        Console.WriteLine("the digits are similar?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 99");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 69");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("is the sum of digits more than 10?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 49");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 27");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("is it more than 50?");
                                answer = Console.ReadLine().ToLower();
                                if (answer == "yes")
                                {
                                    Console.WriteLine("is the first digit even?");
                                    answer = Console.ReadLine().ToLower();
                                    if (answer == "yes")
                                    {
                                        Console.WriteLine("is it multiple of 3?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("is the subtraction of digits more than 5?");
                                            answer = Console.ReadLine().ToLower();
                                            if (answer == "yes")
                                            {
                                                Console.WriteLine("you made the 81");
                                            }
                                            else
                                            {
                                                Console.WriteLine("you made the 63");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("is the sum of digits more than 10?");
                                            answer = Console.ReadLine().ToLower();
                                            if (answer == "yes")
                                            {
                                                Console.WriteLine("you made the 83");
                                            }
                                            else
                                            {
                                                Console.WriteLine("you made the 61");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("is the sum of digits more than 11?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 93");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 91");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("is the multiplying of digits more than 5?");
                                    answer = Console.ReadLine().ToLower();
                                    if (answer == "yes")
                                    {
                                        Console.WriteLine("is the sum of the digits more than 6?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 43");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 23");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("is the sum of the digits more than 4?");
                                        answer = Console.ReadLine().ToLower();
                                        if (answer == "yes")
                                        {
                                            Console.WriteLine("you made the 41");
                                        }
                                        else
                                        {
                                            Console.WriteLine("you made the 21");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("is it a simple number?");
                    answer = Console.ReadLine().ToLower();
                    if (answer == "yes")
                    {
                        Console.WriteLine("is it more than 4?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes")
                        {
                            Console.WriteLine("is it looks like 'S'?");
                            answer = Console.ReadLine().ToLower();
                            if (answer == "yes")
                            {
                                Console.WriteLine("you made the 5");
                            }
                            else
                            {
                                Console.WriteLine("you made the 7");
                            }
                        }
                        else
                        {
                            Console.WriteLine("is it looks like a bird?");
                            answer = Console.ReadLine().ToLower();
                            if (answer == "yes")
                            {
                                Console.WriteLine("you made the 3");
                            }
                            else
                            {
                                Console.WriteLine("you made the 1");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("you made the 9");
                    }
                }
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
