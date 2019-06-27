using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpFeatures
{
    class Program
    {
        static void ViewNames(params  string[]names)
        {
            foreach ( string name in names)
            {
                Console.WriteLine(name);
            }
        }

         static void  Swap( ref int num1, ref int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;

        }


        static void  Calculate(float radius, out double area, out double circum)
        {
             area = 3.14 * radius * radius;
             circum = 2 * 3.15 * radius;
             
        }


        static void DemoRectangularArray()
        {
            int[,] mtrx = new int[2, 3] {
                                            { 10, 20, 30 },
                                            { 40, 50, 60 }
                                        };

            Console.WriteLine("Rectangule Array Elements");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mtrx[i, j] + "\t");
                }
            }


        }


        static void DemoJaggedArray()
        {
            object[][] mtrxjagged = new object[3][];

            mtrxjagged[0] = new object[] { "Rajan", "Ganesh" };
            mtrxjagged[1] = new object[] { 56, 45, 999 };
            mtrxjagged[2] = new object[] { new DateTime(2018, 12, 7), 45.56, true, "Hitesh" };

            Console.WriteLine("\n\n\n Jagged Array Elements\n");
            for (int i = 0; i < mtrxjagged.Length; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < mtrxjagged[i].Length; j++)
                {
                    Console.Write(mtrxjagged[i][j] + "\t");
                }
            }

        }

        static void Main(string[] args)
        {

            /*
            ViewNames("Nitin", "Nilesh");

            ViewNames("Nitin", "Nilesh","Shrinivas");
            ViewNames("Nitin", "Nilesh", "Shrinivas", "Reena","Manu");
            ViewNames("Nitin", "Nilesh", "Shrinivas");
            */

            /*
             double  area, circum;
             Calculate(5,out area, out circum);
             Console.WriteLine("Area ={0}  Circum ={1}", area, circum);
           */

            Team india = new Team();
            india[0] = new Player { ID = 1, Name = "Virat", Runs = 25000 };
            india[1]= new Player { ID = 1, Name = "Mahi", Runs = 50000 };



            Console.WriteLine(india[1]);



            //Exception Handling Demo

            try
            {
                Console.WriteLine("Started Exeucting Main function");

                int i = 0;
                int count = 56;

                throw new Exception("Generate exception from main");


            }
            catch (Exception exp)
            {
                string msg = exp.Message;
                Console.WriteLine("Exception : {0}", msg);
            }

            finally
            {
                Console.WriteLine("Finally Block Invoked");
            }

            Console.ReadLine();
       }
    }
}
