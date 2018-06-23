using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace StatisticalFunctions

{

    class Program

    {

        static void Main(string[] args)

        {

            RanNum start = new RanNum();



        }

    }

    class RanNum

    {

        int Min = 0;

        int Max = 1000;



        public RanNum()

        {

            Random index = new Random();

            int[] array = new int[index.Next(10-1000)];



            Random randNum = new Random();



            for (int i = 0; i < array.Length; i++)

            {

                array[i] = randNum.Next(Min, Max);

            }

            foreach (int i in array)

            {

                Console.WriteLine(i);

            }

        }

		

		        public static int Mean(List<int> intList)

        {

            return (int)intList.Average();

        }



		

        // method to give the median (halfway point) of a list of sorted integers

        public static double Median(List<int> intList)

        {

            intList.Sort();

            // integer division requires the addition of one to get the midpoint

            if (intList.Count % 2 != 0)

                return (intList[intList.Count / 2 + 1]);



            // if the size of the list is even it needs to be split in half which requires a double casting

            else

            {

                double half1 = intList[intList.Count / 2];

                double half2 = intList[intList.Count / 2 + 1];

                return (half1 + half2) / 2;

            }

        }

        // method to get the standard deviation of a list of integers

        public static int StandardDeviation(List<int> intList)

        {

            List<int> numerator = new List<int>();

            double median = Median(intList);

            double average = Mean(intList);



            // the formula is: square root of the sum of the integer value minus the mean squared 

            // for every value, over the number of integers in the list

            foreach (int num in intList)

            {

                int temp = (int)(Math.Pow(num - average, 2));

                numerator.Add(temp);

            }

            int total = numerator.Sum();

            return (int)Math.Sqrt(total / intList.Count);

        }

        // method get the median absolute deviation

        public static double MedianAD(List<int> intList)

        {

            intList.Sort();

            double median = Median(intList);

            List<int> absList = new List<int>();



            // formula is median(|num - median(intList)|)

            foreach (int num in intList)

            {

                absList.Add((int)Math.Abs(num - median));

            }

            return Median(absList);

        }

    }

}