using System;

namespace ConsoleApp

{
    class MyArr
    {
        public int x, y, z;
        public MyArr(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static bool operator false(MyArr ss1)
        {
            if ((ss1.x % 2 == 0) || (ss1.y % 2 == 0) || (ss1.z % 2 == 0))
                return true;
            return false;
        }

        public static bool operator true(MyArr ss1)
        {
            if ((ss1.x % 2 != 0) || (ss1.y % 2 != 0) || (ss1.z % 2 != 0))
                return false;
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArr p = new MyArr(6, 8, 10);
            if (p)
            {
                Console.WriteLine("четные числа");
            }
            else
            {
                Console.WriteLine("присутствуют нечетные числа");
            }
        }
    }
}
