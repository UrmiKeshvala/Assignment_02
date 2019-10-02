using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_02
{
    public class TriangleSolver
    {
        private int TrisideOne;
        private int TrisideTwo;
        private int TrisideThree;
        string output;


        public TriangleSolver()
        {
            TrisideOne = 1;
            TrisideTwo = 1;
            TrisideThree = 1;
        }

        public TriangleSolver(int TrisideOne, int TrisideTwo, int TrisideThree)
        {
            this.TrisideOne = TrisideOne;
            this.TrisideTwo = TrisideTwo;
            this.TrisideThree = TrisideThree;

        }
        public int GetTrisideOne()
        {

            return TrisideOne;
        }
        public int GetTrisideTwo()
        {

            return TrisideTwo;
        }
        public int GetTrisideThree()
        {

            return TrisideThree;
        }

        public string Analyze()
        {
            
            if (TrisideOne == TrisideTwo && TrisideTwo == TrisideThree)
            {
               output= "Equilateral";
           
               
                //Console.WriteLine("Equilaterel");
            }
            else if (TrisideOne == TrisideTwo || TrisideOne == TrisideThree || TrisideTwo == TrisideThree)
            {
                output= "Isosceles";
               
               // Console.WriteLine("Isosceles");

            }
            else
            {
                output= "Scalene";
               // Console.ReadKey();
               
                // Console.WriteLine("Scalene");
            }

            return output;
        }
       
    }
}
