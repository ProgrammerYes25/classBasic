using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Math {
        public static int abs(int i) {
            return 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Math.abs(-1);
            OtherClass oc = new OtherClass();

            Console.WriteLine("Hello World!");

            List<Student> list = new List<Student>() {
                new Student() { name = "최승철", grade = 1 },
                new Student() { name = "권순영", grade = 2 },
                new Student() { name = "전원우", grade = 3 },
                new Student() { name = "문준휘", grade = 4 },
                new Student() { name = "유정한", grade = 1 },
                new Student() { name = "홍지수", grade = 2 }
                };
            foreach (var item in list) { 
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");
            for(int i = list.Count-1; i >= 0; i-- )
            {
                if (list[i].grade > 1)
                {
                    list.RemoveAt(i);
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        class ThridClass{ 
        }
    }
}