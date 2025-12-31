
// Console.WriteLine("Hello, World!");
// Console.WriteLine(10+25);

// Console.Write("hello");
// Console.Write("World");


//  operators


// int a=10;
// int b=15;

// double a=10;
// double b=15;

// Console.WriteLine(a+b);
// Console.WriteLine(a-b);
// Console.WriteLine(a*b);
// Console.WriteLine(a/b);
// Console.WriteLine(a%b);


// user input

// Console.WriteLine("enter a name");
// // String name=Console.ReadLine();
// String? name=Console.ReadLine();

// Console.WriteLine("your name is "+name);


// Console.WriteLine("enter a number");
// int number=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Your number is :"+number);



// Console.WriteLine("enter first number");
// int number1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter second number");
// int number2=Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("sum of " + number1 + " and " + number2 + " is " + (number1 + number2));


// Console.WriteLine($"sum of {number1} and {number2} is {number1 + number2}");




// Conditional statement

//if statement

// Console.WriteLine("enter your age");
// int age=Convert.ToInt32(Console.ReadLine());

// if (age >= 18)
// {
//     Console.WriteLine("your eligible");
// }


//if else statement


// Console.WriteLine("enter your age");
// int age=Convert.ToInt32(Console.ReadLine());

// if (age >= 18)
// {
//     Console.WriteLine("your eligible");
// } else
// {
//     Console.WriteLine("your not eligible");
// }


// if else if

// Console.WriteLine("Enter your marks");
// int marks = Convert.ToInt32(Console.ReadLine());

// if (marks >= 90)
// {
//     Console.WriteLine("Grade A");
// }
// else if (marks >= 75)
// {
//     Console.WriteLine("Grade B");
// }
// else if (marks >= 50)
// {
//     Console.WriteLine("Grade C");
// }
// else
// {
//     Console.WriteLine("Fail");
// }




// nested if


// Console.WriteLine("Enter your age");
// int age = Convert.ToInt32(Console.ReadLine());

// if (age >= 18)
// {
//     if (age <= 60)
//     {
//         Console.WriteLine("You are eligible to work");
//     }
//     else
//     {
//         Console.WriteLine("Retired age");
//     }
// }
// else
// {
//     Console.WriteLine("Not eligible to work");
// }





// switch case statement 



// Console.WriteLine("Enter a number (1–3)");
// int num = Convert.ToInt32(Console.ReadLine());

// switch (num)
// {
//     case 1:
//         Console.WriteLine("One");
//         break;
//     case 2:
//         Console.WriteLine("Two");
//         break;
//     case 3:
//         Console.WriteLine("Three");
//         break;
//     default:
//         Console.WriteLine("Invalid number");
//         break;
// }



// Console.WriteLine("Enter your age");
// int age = Convert.ToInt32(Console.ReadLine());

// string result = (age >= 18) ? "Eligible" : "Not Eligible";
// Console.WriteLine(result);




//  for loop 

// for(int x = 1; x < 6; x++)
// {
//     Console.WriteLine("C Sharp");
// }

// while loop


// int x = 1;

// while (x < 6)
// {
//     Console.WriteLine("C Sharp");
//     x++;
// }





// int x = 1;

// do
// {
//     Console.WriteLine("C Sharp");
//     x++;
// }
// while (x < 6);



// function


//  void PrintMessage()
// {
//     Console.WriteLine("Welcome to C Sharp");
// }

// PrintMessage();


// void SumFunction(int x, int y)
// {
//     Console.WriteLine("Sum is " + (x + y));
// }


// SumFunction(23,45);






//  int Add(int a, int b)
// {
//     return a + b;
// }

// int a=Add(4,5);
// Console.WriteLine(a);











// string CheckEvenOdd(int number)
// {
//     if (number % 2 == 0)
//     {
//         return "Even Number";
//     }
//     else
//     {
//         return "Odd Number";
//     }
// }

// Console.WriteLine("Enter a number");
// int num = Convert.ToInt32(Console.ReadLine());

// string result = CheckEvenOdd(num);
// Console.WriteLine(result);









// ARRAY 


// int[] numbers = { 10, 20, 30, 40, 50 };
// Console.WriteLine(numbers[0]); 
// Console.WriteLine(numbers[2]); 





// int[] numbers = { 10, 20, 30, 40, 50 };

// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine(numbers[i]);
// }





// int[] numbers = { 5, 10, 15, 20 };
// int sum = 0;

// foreach (int n in numbers)
// {
//     sum += n;
// }

// Console.WriteLine("Sum = " + sum);



// string[] names = { "Athul", "Anu", "Rahul" };

// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }











// simple calculator


Console.WriteLine("enter first number");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter second number");
int num2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" first num is {num1} and second num is {num2}");

Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");


        Console.Write("Enter your choice (1-4): ");

        int choice=Convert.ToInt32(Console.ReadLine());

        int result = 0;
         

         switch(choice)
         {
            case 1:
            result=num1+num2;
              Console.WriteLine("Result = " + result);
                break;

                case 2:
            result=num1+num2;
              Console.WriteLine("Result = " + result);
                break;

                case 3:
            result=num1-num2;
              Console.WriteLine("Result = " + result);
                break;

                case 4:
                result=num1/num2;
                Console.WriteLine("Result = ",+ result);
                break;
                
                default:
                Console.WriteLine("Invalid choice");
                break;
         }


        //  --------------------------------------------------------
        // ---------------------------------------------------------




        