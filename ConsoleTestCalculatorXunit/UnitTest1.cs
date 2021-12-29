using System;
using Xunit;
using ConsoleTestCalculator;

namespace ConsoleTestCalculatorXunit
{
    public class UnitTest1
    {
        [Fact]
        public void Div()
        {
            double tal1 = 1;
            double tal2 = 3;
            double expectedResult = 0.3333;

            double Resultat = Program.Div(tal1, tal2);

            Assert.Equal(expectedResult, Resultat, 4);

        }
        [Theory]
        [InlineData(8, 4, 2)]
        [InlineData(10, 3, 3.333)]
        [InlineData(15, 10, 1.5)]
        [InlineData(1, 3, 0.333)]
        public void DivTheory(double tal1, double tal2, double expected)
        {
            /*double Resultat =*/
            Program.Div(tal1, tal2);
        }

        [Fact]
        public void GetNumberFromUserTest()
        {
            double userInput = 45;
            double expectedResult = 45;



            Assert.Equal(expectedResult, userInput);

        }







        [Fact]
        public void Add()
        {
            double tal1 = 24.5;
            double tal2 = 25.5;
            double expectedReult = 50;

            double Resultat = Program.Add(tal1, tal2);

            Assert.Equal(expectedReult, Resultat);

        }
        [Theory]
        [InlineData(8, 4, 2)]
        [InlineData(10, 3, 3.333)]
        [InlineData(15, 10, 1.5)]
        [InlineData(1, 3, 0.333)]
        public void AddTheory(double tal1, double tal2, double expected)
        {
            double Resultat = Program.Add(tal1, tal2);
        }

        [Fact]

        public void AddTestArray()
        {
            double expectedResult = 64.5;
            double[] array = new double[5] { 4.52, 5, 10, 20, 25 };
            double Resultat = Program.Add(array);
            Assert.Equal(expectedResult, Resultat, 1);



        }


        [Fact]

        public void SubTestArray()
        {
            double expectedResult = 39.5;
            double[] array = new double[5] { 100, 5, 10, 20, 25.5 };
            double Resultat = Program.Sub(array);
            Assert.Equal(expectedResult, Resultat, 1);



        }


        [Fact]
        public void Sub()
        {
            double tal1 = 4.5;
            double tal2 = 5;
            double expectedReult = -0.5;

            double Resultat = Program.Sub(tal1, tal2);

            Assert.Equal(expectedReult, Resultat, 1);

        }
        [Theory]
        [InlineData(8, 4, 2)]
        [InlineData(10, 3, 3.333)]
        [InlineData(15, 10, 1.5)]
        [InlineData(1, 3, 0.333)]
        public void SubTheory(double tal1, double tal2, double expected)
        {
            double Resultat = Program.Sub(tal1, tal2);
        }


        [Fact]
        public void Mult()
        {
            double tal1 = 2.5;
            double tal2 = 4;
            double expectedReult = 10;

            double Resultat = Program.Mult(tal1, tal2);

            Assert.Equal(expectedReult, Resultat);

        }
        [Theory]
        [InlineData(8, 4, 2)]
        [InlineData(10, 3, 3.333)]
        [InlineData(15, 10, 1.5)]
        [InlineData(1, 3, 0.333)]
        public void MultTheory(double tal1, double tal2, double expected)
        {
            double Resultat = Program.Mult(tal1, tal2);
        }


    }
}
