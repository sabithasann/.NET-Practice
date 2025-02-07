//loops
//for loop - Count controlled loop; pre-test loop [The condition is tested before the body executes the first iteration of the loop]
//Print 100 98 96 ... 2 
//Do not print 0
//for(int i = 100; i > 0; i-= 2)
//{
//    Console.WriteLine($"The current value of i is {i}");
//}
//Print half of initial value each time from 100
//for(float i = 100; i > 1; i/=2)
//{
//    Console.WriteLine($"The current value of i is {i}");
//}
//while loop - pre-test loop ; Also, used when the end value is not known
//int j = 0;
//while(j < 10)
//{
//    Console.WriteLine($"The current value of j is {j}");
//    j++;
//}
//do while loop - post-test loop
//int k = 100;
//do
//{
//    Console.WriteLine($"The current value of k is {k}");
//    k++;
//} while (k < 10);
//foreach
//foreach (var item in args)
//{

//}
//conditionals
//if-else
//int age = 60;
//if(age < 50)
//{
//    Console.WriteLine("You are not over the hill!");
//}else
//{
//    Console.WriteLine("You ARE over the hill!");
//}
//int testScore = 50;
//if (testScore >= 90)
//    Console.WriteLine("You got an A");
//else if (testScore >= 80)
//    Console.WriteLine("You got a B");
//else if (testScore >= 70)
//    Console.WriteLine("You got a C");
//else
//    Console.WriteLine("You got a F");

int age = 1;
switch(age)
{
    case 1:
        Console.WriteLine("You are an infant");
        break;
    case 2:
        Console.WriteLine("You are a toddler");
        break;
    case 3:
        Console.WriteLine("You are a young child");
        break;
    default:
        Console.WriteLine("I don't know how old are you");
        break;
}