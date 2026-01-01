// using System;
// using System.Collections.Generic;
// using System.Text;
// using System.Linq;
// using System.Threading.Tasks;

// namespace MyProgram
// {
//     public class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World");
//         }
//     }
// }





// List

// using System;
// using System.Collections.Generic;
// namespace Program
// {
//     public class Program
//     {
//         public static void Main(String[] args)
//         {
//             List<string> fruits= new List<string>();
//             fruits.Add("apple");
//             fruits.Add("graps");

//             Console.WriteLine(fruits[0]);
//         }
//     }
// }






// Dictionary


// using System;
// using System.Collections.Generic;

// namespace Program
// {
//     public class Program
//     {
//         public static void Main(String[] args)
//         {
//             Dictionary<string,string> fruits = new Dictionary<string, string>();
//             fruits.Add("apple","fruitsApple");
//             fruits.Add("grapes","fruitsGrape");

//             Console.WriteLine(fruits["apple"]);
//         }
//     }
// }



// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         List<string> courses = new List<string>()
//         {
//             "C#",
//             "Java",
//             "React"
//         };

//         Dictionary<string, int> coursePrice = new Dictionary<string, int>()
//         {
//             { "C#", 3000 },
//             { "Java", 2500 },
//             { "React", 3500 }
//         };

//         foreach (string course in courses)
//         {
//             Console.WriteLine(course + " - ₹" + coursePrice[course]);
//         }
//     }
// }






// methods



// using System;
// using System.Collections.Generic;

// namespace Program
// {
//     public class Program
//     {
//         public static void Main(String [] args)
//         {
//             SayHi();
//         }

// static void SayHi()
//         {
//             Console.WriteLine("Hello Good Mrng");
//         }

//     }
// }

// ============================================

// using System;
// using System.Collections.Generic;

// namespace Program
// {
//     public class Program
//     {
//         public static void Main(String [] args)
//         {
//             fruits("Apple","Red");
//             fruits("Grape","Black");
//         }

// static void fruits(string name,string color)
//         {
//             Console.WriteLine("fruit name is {0} and color is{1}",name,color);
//         }

//     }
// }



// ====================================================



// method with retun

using System;
using System.Collections.Generic;

namespace Program
{
    public class Program
    {
        public static void Main(String[] args)
        {
            // Console.WriteLine(Add(10,5));

            // ====================================

            // int result=Add(30,20);
            // Console.WriteLine(result);

            // =====================================

              int num1 = 30;
            int num2 = 20;

            int result = Add(num1, num2);
            Console.WriteLine($"Sum of {num1} and {num2} is {result}");
            
        }

        public static int Add(int num1,int num2)
        {
            return num1+num2;
        }
    }
}