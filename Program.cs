using System;

namespace assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Minneapolis Dog Boarding Company! Please enter your username: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Nice to have you back {userName}! What is your dog's name?");
            string dogName = Console.ReadLine();
            Console.WriteLine($"Okay thank you and what is {dogName}'s breed?");
            string dogBreed = Console.ReadLine();
            Console.WriteLine($"What is {dogName}'s age?");
            int dogAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"And how many weeks will {dogName} be with us?");
            int numOfWeeks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Our last question for you is how much does {dogName} weigh?");
            int dogWeight = Convert.ToInt32(Console.ReadLine());
            if (dogWeight < 15){
                int total = 55 * numOfWeeks;
                Console.WriteLine($"The total cost for {dogName}'s care will be {total}!");
                if (total > 124){
                Console.WriteLine("A 2% discount will be added to your bill because it exceeds $125!");
                }
            }
            else{
                if (dogWeight < 31){
                    int total = 75 * numOfWeeks;
                    Console.WriteLine($"The total cost for {dogName}'s care will be {total}!");
                    if (total > 124){
                    Console.WriteLine("A 2% discount will be added to your bill because it exceeds $125!");
                    }
                }
               
                else{
                    if (dogWeight < 80){
                        int total = 105 * numOfWeeks;
                        Console.WriteLine($"The total cost for {dogName}'s care will be {total}!");
                        if (total > 124){
                        Console.WriteLine("A 2% discount will be added to your bill because it exceeds $125!");
                        }
                    }
                
                    else{
                        if (dogWeight > 80){
                            int total = 125 * numOfWeeks;
                            Console.WriteLine($"The total cost for {dogName}'s care will be {total}!");
                            if (total > 124){
                            Console.WriteLine("A 2% discount will be added to your bill because it exceeds $125!");
                            }
                        }
                    }
                }
            }
        }
    }
}
