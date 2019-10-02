using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_02
{


    class Program
    {
        static TriangleSolver tri;
        static int TriOne, TriTwo, TriThree;
        public int flag = 0;

        static void Main(string[] args)
        {
            
            
                GetUserInput();
            
            TriOne = GetTrisideOne();
            TriTwo = GetTrisideTwo();
            TriThree = GetTrisideThree();
            tri = new TriangleSolver(TriOne, TriTwo, TriThree);

            tri.Analyze();
            Console.Read();
        }
        private enum Value
        {
            GetTrisideOne,
            GetTrisideTwo,
            GetTrisideThree,
            
            Exit=2 
        }

        

        static void GetUserInput()
        {
            int choiceValue;
            Menu();
            bool valid;
            void Menu()
            {
                Console.WriteLine("1 = Enter Triangle Dimensions");
                Console.WriteLine("2 = Exit");
                Console.WriteLine(" ");
            }
            do
            {
                valid = TryGetUserInput("Please enter your value", out choiceValue);
                if (!valid)
                    Menu();
                else
                {
                    if (choiceValue == (int)Value.Exit)
                        Environment.Exit(0);
                    
                    // HandleChoice(choiceValue);
                }
            } while (!true);
        }
        static void HandleChoice(int value)
        {
            switch (value)
            {
                case (int)Value.GetTrisideOne:
                    Console.WriteLine("First side of Triangle", tri.GetTrisideOne());
                    break;

                case (int)Value.GetTrisideTwo:
                    Console.WriteLine("Second side of Triangle", tri.GetTrisideTwo());
                    break;

                case (int)Value.GetTrisideThree:
                    Console.WriteLine("Third side of Triangle", tri.GetTrisideThree());
                    break;

            }
        }

        static bool TryGetUserInput(string msg, out int choiceValue)
        {
            Console.WriteLine(msg);
            choiceValue = 0;
            try
            {
                if (!int.TryParse(Console.ReadLine(), out choiceValue))
                    throw new FormatException("Value should be an integer");
                else if (choiceValue < 0)
                {
                    Console.WriteLine("InCorrect Value");
                    return false;
                }
                return true;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }


        static int GetTrisideOne()
        {
            int sizeOne = 0;
            bool valid = TryGetTrisideOne("Please enter the First size of Triangle", out sizeOne);
            while (!valid)
            {
                valid = TryGetTrisideOne("Please enter side", out sizeOne);
            }
            return sizeOne;
        }
        static bool TryGetTrisideOne(string message, out int TrisideOne)
        {
            Console.WriteLine(message);
            TrisideOne = 0;
            try
            {
                if (!int.TryParse(Console.ReadLine(), out TrisideOne))
                    throw new FormatException("Value should be an integer");
                else if (TrisideOne < 0)
                {
                    Console.WriteLine("Value should be greater than 0");
                    return false;
                }
                return true;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        static int GetTrisideTwo()
        {
            int sizeTwo = 0;
            bool valid = TryGetTrisideTwo("Please enter the Secondside of Triangle", out sizeTwo);
            while (!valid)
            {
                valid = TryGetTrisideTwo("Please enter the side2", out sizeTwo);
            }
            return sizeTwo;
        }
        static bool TryGetTrisideTwo(string msg, out int sizeTwo)
        {
            Console.WriteLine(msg);
            sizeTwo = 0;
            try
            {
                if (!int.TryParse(Console.ReadLine(), out sizeTwo))
                    throw new Exception("Value should be an integer");
                else if (sizeTwo < 0)
                {
                    Console.WriteLine("Value shouldnot be less then 0");
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        static int GetTrisideThree()
        {
            int sizeThree = 0;
            bool valid = TryGetTrisideThree("Please enter the Third side of Triangle", out sizeThree);
            while (!valid)
            {
                valid = TryGetTrisideThree("Please enter the side3", out sizeThree);
            }
            return sizeThree;
        }
        static bool TryGetTrisideThree(string msg, out int sizeThree)
        {
            Console.WriteLine(msg);
            sizeThree = 0;
            try
            {
                if (!int.TryParse(Console.ReadLine(), out sizeThree))
                    throw new Exception("Value should be an integer");
                else if (sizeThree < 0)
                {
                    Console.WriteLine("Value shouldnot be less then 0");
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }





    }
}
