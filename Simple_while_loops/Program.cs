using System;

namespace Simple_while_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region format 1
            //var count = 1;
            //while (count <= 10)
            //{
            //Console.WriteLine($"{count}");
            //    count++;

            //}
            #endregion

            #region format 2
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);

            }
            #endregion

        }
    }
}
