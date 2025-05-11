// If Else Statement Example


// Driving Age Example

Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

if(age >= 17)
{
    Console.WriteLine("\n\nYou are allowed to drive.\n\n");

} 

else

{
    Console.WriteLine("\n\nYou are not allowed to drive!\n\n");
}



// Temperature Example

int temp = 20;
Boolean isMoreThan30 = temp > 30;

if(isMoreThan30)
{
     Console.WriteLine("\n\nTemp is More than 30C\n\n");

} 

else 
   {

     Console.WriteLine("\n\nTemp is Less than 30C\n\n");  
   }


// Guess correct number Example

int correctNumber = 8;

Console.WriteLine("Guess the number (1-10)");

int guess = int.Parse(Console.ReadLine());

if (guess == correctNumber)
{
    Console.WriteLine("\n\nYou've guessed the correct number! \n\n");
    
} 

else if (guess > correctNumber)
{
    Console.WriteLine("\n\nYou've guessed too high.\n\n");
} 

else
{
    Console.WriteLine("\n\nYou've guessed too low.\n\n");
}
