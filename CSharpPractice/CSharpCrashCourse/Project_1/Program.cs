Console.WriteLine("Hello Good People!!");

//byte - 8 bit ; 256 values; 0 to 255
//sbyte - 8 bit ; 256 values; -128 to 127
//short - 16 bit
//int - 32 bit
//uint 
//long - 64 bit

//Data types can be marked as nullable by adding a ? after the data type. Default in C# is non-nullable.
//int? myInt = 32;
//Int32 myInt32 = new Int32();

//signed and unsigned

//float - 32 bit
//double - 64 bit
//decimal - 128 bit

//boolean - true or false
//char - 16 bit

//reference or object
//string
//object
//array
//interface
//dynamic
//pointer

Console.WriteLine("Please, Enter your name: ");
string name = Console.ReadLine();
Console.WriteLine("Please, Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Hello " + name);
//Console.WriteLine($"Hello {name}");
Console.WriteLine($"Hello {name}, you are {age} years old."); 