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

// using System;
// using System.Collections.Generic;

// namespace Program
// {
//     public class Program
//     {
//         public static void Main(String[] args)
//         {
//             // Console.WriteLine(Add(10,5));

//             // ====================================

//             // int result=Add(30,20);
//             // Console.WriteLine(result);

//             // =====================================

//               int num1 = 30;
//             int num2 = 20;

//             int result = Add(num1, num2);
//             Console.WriteLine($"Sum of {num1} and {num2} is {result}");

//         }

//         public static int Add(int num1,int num2)
//         {
//             return num1+num2;
//         }
//     }
// }



// ========================================


// conditional statement



//  using System;
// using System.Collections.Generic;

// namespace Program
// {
//     public class Program
//     {
//         public static void Main(String[] args)
//         {
//              Console.Write("Enter first number: ");
//         int num1 = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Enter second number: ");
//         int num2 = Convert.ToInt32(Console.ReadLine());

//         int sum = Add(num1, num2);
//         Console.WriteLine("Sum = " + sum);

//         }

//         public static int Add(int num1,int num2)
//         {
//             return num1+num2;
//         }
//     }
// }



// ==========================================




//  using System;
// using System.Collections.Generic;

// namespace Program
// {
//     public class Program
//     {
//         public static void Main(String[] args)
//         {
//              Console.Write("Enter your age: ");
//         int age = Convert.ToInt32(Console.ReadLine());

//             if (age >= 18)
//             {
//                 Console.WriteLine("your eligilbe for vote");
//             }
//             else
//             {
//                 Console.WriteLine("your minnor");
//             }



//         }


//     }
// }



// ========================================



//  using System;
// using System.Collections.Generic;

// namespace Program
// {
//     public class Program
//     {
//         public static void Main(String[] args)
//         {
//              Console.Write("Enter first number: ");
//         int num1 = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Enter second number: ");
//         int num2 = Convert.ToInt32(Console.ReadLine());

//         int sum = Add(num1, num2);
//         Console.WriteLine("Sum = " + sum);

//         }

//         public static int Add(int num1,int num2)
//         {
//             return num1+num2;
//         }
//     }
// }



// ==========================================




//  using System;
// using System.Collections.Generic;

// namespace Program
// {
//     public class Program
//     {
//         public static void Main(String[] args)
//         {
//             Console.WriteLine("enter your Review 1 - 3: ");
//             int mark=Convert.ToInt32(Console.ReadLine());

//             switch (mark)
//             {
//                 case 1 :
//                 Console.WriteLine("thank you !!! your review is 1");
//                 break;

//                    case 2 :
//                 Console.WriteLine("thank you !!! your review is 2");
//                 break;
//                    case 3 :
//                 Console.WriteLine("thank you !!! your review is 3");
//                 break;
//                 default:
//                 Console.WriteLine("invalid entry");
//                 break;
//             }



//         }


//     }
// }






// =============================================


// Loops 


// using System;
// using System.Collections.Generic;

// namespace Program
// {
//     public class Program
//     {
//         public static void Main()
//         {
//             // //for looop

//             // for (int i = 1; i <= 5; i++)
//             // {
//             //     Console.WriteLine("C#");
//             // }


//             // ---------------

//             //while loop


//             // int i = 1;

//             // while (i <= 5)
//             // {
//             //     Console.WriteLine(i);
//             //     i++;
//             // }


//             // ------------------


//             //do while loop



//             // int i = 1;

//             // do
//             // {
//             //     Console.WriteLine(i);
//             //     i++;
//             // }
//             // while (i <= 5);


//             // -------------------


//             //         for (int i = 1; i <= 10; i++)
//             // {
//             //     if (i % 2 == 0)
//             //     {
//             //         Console.WriteLine(i);
//             //     }
//             // }


//         }
//     }
// }




// =========================================


// exception handling



// using System;

// namespace Program
// {
//     public class Program
//     {
//         public static void Main(String [] args)
//         {
//              try
//         {
//             int a = 10;
//             int b = 0;
//             int result = a / b;
//             Console.WriteLine(result);
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("Error: " + ex.Message);
//         }

//         }
//     }
// }




// ===========================================


// structure



// using System;

// namespace Program
// {
//     struct student
//     {
//         public int id;
//         public string name;
//         public int age;

//     }

//     public class Program
//     {
//         public static void Main(String [] args)
//         {
//             student S1;
//             S1.id=100;
//             S1.name="athul";
//             S1.age=25;

//             Console.WriteLine($"stduent id : {S1.id}");
//         }
//     }
// }


// ==========================================================



// using System;

// struct Rectagle
// {
//     public int length;
//     public int width;
//     public int Area()
//     {
//         return length*width;
//     }
// }

// public class Program
// {
//     public static void Main(String [] args)
//     {
//         Rectagle r;
//         r.length=10;
//         r.width=6;

//         Console.WriteLine("area: "+r.Area());
//     }
// }



// ============================================

//class

//============================================

// using System;
// using System.Collections.Generic;
// using fruitsClass;
// namespace Program
// {
//     public class Program
//     {
//         public static void Main(String[] args)
//         {
//             Fruits fruit1=new Fruits("apple","red");
//             fruit1.DisplayFruits();
//         }
//     }
// }




// ==========================================

// file management

// ============================================

// namespace Program
// {
//     public class Program
//     {
//         public static void Main(String [] args)
//         {
//             string content="hello world";
//             File.WriteAllText("sample.txt",content);
//             Console.Write(File.ReadAllText("sample.txt"));
            
//         }
//     }
// }





