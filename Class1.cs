using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_02;
using NUnit.Framework;

namespace Assignment_02
{
    public class Class1
    {
        [TestFixture]
        class CalcTests
        {
            [Test]
            public void TrysideOne_1TrysideTwo_2TrysideThree_3NoTriangle()
            {
                //Arrange
                int TrisideOne = 1;
                int TrisideTwo = 2;
                int TrisideThree = 3;

                // double expectedResult = RecWidth;
                TriangleSolver triTest = new TriangleSolver(TrisideOne, TrisideTwo, TrisideThree);
                //Act 
               string actualResult = triTest.Analyze();
                //Assert 
                Assert.AreEqual("Scalene", actualResult);
            }

            [Test]
            public void TrysideOne_12TrysideTwo_2TrysideThree_5NoTriangle()
            {
                //Arrange
                int TrisideOne = 12;
                int TrisideTwo = 2;
                int TrisideThree = 5;

                // double expectedResult = RecWidth;
                TriangleSolver triTest = new TriangleSolver(TrisideOne, TrisideTwo, TrisideThree);
                //Act 
                string actualResult = triTest.Analyze();
                //Assert 
                Assert.AreEqual("Scalene", actualResult);
            }

            [Test]
            public void TrysideOne_18TrysideTwo_8TrysideThree_33Scalen()
            {
                //Arrange
                int TrisideOne = 18;
                int TrisideTwo = 8;
                int TrisideThree = 33;

                // double expectedResult = RecWidth;
                TriangleSolver triTest = new TriangleSolver(TrisideOne, TrisideTwo, TrisideThree);
                //Act 
                string actualResult = triTest.Analyze();
                //Assert 
                Assert.AreEqual("Scalene", actualResult);
            }

            [Test]
            public void TrysideOne_4TrysideTwo_4TrysideThree_7Isosceles()
            {
                //Arrange
                int TrisideOne = 4;
                int TrisideTwo = 4;
                int TrisideThree = 7;

                // double expectedResult = RecWidth;
                TriangleSolver triTest = new TriangleSolver(TrisideOne, TrisideTwo, TrisideThree);
                //Act 
                string actualResult = triTest.Analyze();
                //Assert 
                Assert.AreEqual("Isosceles", actualResult);
            }

            [Test]
            public void TrysideOne_5TrysideTwo_8TrysideThree_3Scalen()
            {
                //Arrange
                int TrisideOne = 5;
                int TrisideTwo = 8;
                int TrisideThree = 3;

                // double expectedResult = RecWidth;
                TriangleSolver triTest = new TriangleSolver(TrisideOne, TrisideTwo, TrisideThree);
                //Act 
                string actualResult = triTest.Analyze();
                //Assert 
                Assert.AreEqual("Scalene", actualResult);
            }



            [Test]
            public void TrysideOne_21TrysideTwo_14TrysideThree_14Isosceles()
            {
                //Arrange
                int TrisideOne = 21;
                int TrisideTwo = 14;
                int TrisideThree = 14;

                // double expectedResult = RecWidth;
                TriangleSolver triTest = new TriangleSolver(TrisideOne, TrisideTwo, TrisideThree);
                //Act 
                string actualResult = triTest.Analyze();
                //Assert 
                Assert.AreEqual("Isosceles", actualResult);
            }

            [Test]
            public void TrysideOne_24TrysideTwo_24TrysideThree_2Isosceles()
            {
                //Arrange
                int TrisideOne = 24;
                int TrisideTwo = 24;
                int TrisideThree = 2;

                // double expectedResult = RecWidth;
                TriangleSolver triTest = new TriangleSolver(TrisideOne, TrisideTwo, TrisideThree);
                //Act 
                string actualResult = triTest.Analyze();
                //Assert 
                Assert.AreEqual("Isosceles", actualResult);
            }

            [Test]
            public void TrysideOne_35TrysideTwo_28TrysideThree_13Scalen()
            {
                //Arrange
                int TrisideOne = 35;
                int TrisideTwo = 28;
                int TrisideThree = 13;

                // double expectedResult = RecWidth;
                TriangleSolver triTest = new TriangleSolver(TrisideOne, TrisideTwo, TrisideThree);
                //Act 
                string actualResult = triTest.Analyze();
                //Assert 
                Assert.AreEqual("Scalene", actualResult);
            }

        }
    }
}
