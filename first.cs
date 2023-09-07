using System;

namespace ConsoleApp1
{
    class MyArr
    {
        public int x, y, z;

        public MyArr(int x = 0, int y = 0, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static bool operator ==(MyArr ss1, MyArr ss2)
        {
            if ((ss1.x == ss2.x) && (ss1.y == ss2.y) && (ss1.z == ss2.z))
                return true;
            return false;
        }
        public static bool operator !=(MyArr ss1, MyArr ss2)
        {
            if ((ss1.x != ss2.x) || (ss1.y != ss2.y) || (ss1.z != ss2.z))
                return true;
            return false;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArr ss1 = new MyArr(4, 5, 12);
            MyArr ss2 = new MyArr(4, 5, 12);
            if (ss1 == ss2 )
            {
                Console.WriteLine("Объекты равны");
            }
            MyArr ss3 = new MyArr(4, 6, 12);
            MyArr ss4 = new MyArr(4, 5, 12);
            if (ss3 == ss4)
            {
                Console.WriteLine("Объекты равны");
            }
            else
            {
                Console.WriteLine("Объекты не равны");
            }
        }
    }
}
      
