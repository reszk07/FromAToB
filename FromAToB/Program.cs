using System;



namespace FromAToB

{

    class Program

    {

        static void Main(string[] args)

        {

            int a, b, count;

            string[] data = Console.ReadLine().Split();



            a = int.Parse(data[0]);

            b = int.Parse(data[1]);



            if (a < b)

                count = b - a;

            else

            {

                count = 0;

                while (a > b)

                {

                    if (a % 2 != 0)

                        a += 1;

                    else

                        a /= 2;

                    count++;

                }



                if (a < b)

                {

                    count += b - a;

                }

            }



            Console.WriteLine(count);

        }

    }

}
