
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



Console.WriteLine("Enter your age");
int age = Convert.ToInt32(Console.ReadLine());

string result = (age >= 18) ? "Eligible" : "Not Eligible";
Console.WriteLine(result);
