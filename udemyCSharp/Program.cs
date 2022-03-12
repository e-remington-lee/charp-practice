using System;


namespace udemyCSharp
{
    internal class Program
    {
         
        static void Main(string[] args)
        {

            #region Ints and Doubles

            //Console.WriteLine("what we doing here dafds");
            //sbyte xy = -128;
            //byte yx = 255;

            //float x = 99.99f;

            //double yy = 99.99d;

            //decimal? hh = null;
            //long long1 = 123456789456;
            //short s = -8;
            //Console.WriteLine($"f strings are great {hh ??= 5.0m / 1.5m}");
            #endregion


            #region Strings
            //string? name = "Denise";

            //bool normal = name.IsNormalized();
            //string name2 = name.ToUpperInvariant();
            //Console.WriteLine(name2);
            #endregion


            #region Casting
            //double d1 = 12.45;
            //int i1;

            //i1 = (int)d1;


            //int i2 = 50;
            //long l1 = i2;


            //string s1 = "15";
            //string s2 = "14";
            //try
            //{
            //    int num2 = Int32.Parse(s1);
            //    int num3 = Int32.Parse(s2);
            //    Console.WriteLine(num2 + num3);
            //}
            //catch (FormatException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}


            #endregion

            #region automatic properties


            //Class1 c1 = new Class1();
            //Console.WriteLine(c1.Name);
            //c1.Name = "derek";
            //Console.WriteLine(c1.Name);

            //Program program = new Program();
            //program.two();
            #endregion

            #region multiple projects
           
            #endregion
        }

        public void two()
        {
            Console.WriteLine("two");
        }
    }
}
