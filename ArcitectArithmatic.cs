using System;

namespace ArchitectArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this Architect Arithmetic program!");
            Console.WriteLine("To see the estimated cost and area for Teotihuacan in Mexico, type 1");
            Console.WriteLine("To see the estimated cost and area for the Taj Mahal in India, type 2");
            
            int userInput = Convert.ToInt32(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    EstimateTotalCostTeotihuacan();
                    break;
                case 2:
                    EstimateTotalCostTajMahal();
                    break;
                default:
                    Console.WriteLine("Incorrect input: Press enter to exit.");
                    break;
            }

            Console.ReadLine();
        }
        public static double RectangleArea(double rectangleLength, double rectangleWidth)
        {
            return rectangleLength * rectangleWidth;
        }
        public static double CircleArea(double circleRadius)
        {
            return Math.PI * Math.Pow(circleRadius, 2);
        }
        public static double TriangleArea(double triangleBottom, double triangleHeight)
        {
            return 0.5 * triangleBottom * triangleHeight;
        }
        //Estimated cost of Teotihuacan
        public static void EstimateTotalCostTeotihuacan()
        {
            double rectangleLength = 2500;
            double rectangleWidth = 1500;
            double circleRadius = 187.5;
            double triangleBottom = 750;
            double triangleHeight = 500;
            double rectangleArea = rectangleLength * rectangleWidth;
            double circleArea = Math.PI * Math.Pow(circleRadius, 2);
            double triangleArea = (0.5 * triangleBottom) * triangleHeight;
            double totalArea = rectangleArea + circleArea + triangleArea;
            double materialCost = 180 * totalArea;
            materialCost = Math.Round(materialCost, 2);
            Console.WriteLine($"For a total area of {totalArea} meters squared, the estimated constuction cost of Teotihuacan in pesos is {materialCost}.");
        }

      //Estimated cost of TajMahal
        public static void EstimateTotalCostTajMahal()
        {
            double rectangleLength = 90.5;
            double rectangleWidth = 90.5;
            double circleRadius = 0;
            double triangleBottom = 24;
            double triangleHeight = 24;
            double rectangleArea = rectangleLength * rectangleWidth;
            double circleArea = Math.PI * Math.Pow(circleRadius, 2);
            double triangleArea = (0.5 * triangleBottom) * triangleHeight;
            double totalArea = rectangleArea + circleArea - (4 * triangleArea);
            double materialCost = 180 * totalArea;
            materialCost = Math.Round(materialCost, 2);
            Console.WriteLine($"For a total area of {totalArea} meters squared, the estimated constuction cost of the Taj Mahal in pesos is {materialCost}.");
        }
    }
}
