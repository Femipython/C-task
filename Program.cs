using System.Security.AccessControl;
using System;
using System.Text;

namespace Guess_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string play_again = "";
            
            bool status = true;
            
            string level = "";

            while (status == true)
            { 
                Console.Write("Choose game level(easy, medium , hard): ");
                level = Console.ReadLine();

                //Guessing Game for easy level
                
                if (level == "easy")
                {
                    Random r = new Random();
                    int secret_number = r.Next(1, 10);
                    int guess = 0;
                    int guess_count = 0;
                    int guess_limit = 6;
                    bool out_of_guesses = false;
                    int chances = 6;
                
                    while (guess_count < guess_limit){
                        try
                        {
                            if (out_of_guesses == false){
                                if (guess_count < guess_limit){
                                    chances -= 1;
                                    guess_count += 1;
                                    Console.Write($"Guess a number between 1 -10, you have {chances} chances left: ");
                                    guess = int.Parse(Console.ReadLine());

                                    if (guess == secret_number){
                                        Console.WriteLine("You got it right"); 
                                        break;
                                    }else{
                                        Console.WriteLine("That was wrong");
                                    }
                                }
                            }
                        if(guess_count == guess_limit)
                        {
                            Console.WriteLine("Game over");
                        }
                        }
                        catch
                        {
                            Console.WriteLine("Invalid entry, numbers only");
                        }
                    }
                }
                else if (level == "medium")
                {
                    Random r = new Random();
                    int secret_number_medium = r.Next(1, 20);
                    int guess = 0;
                    int guess_count = 0;
                    int guess_limit = 4;
                    bool out_of_guesses = false;
                    int chances = 4;

                    while (guess_count < guess_limit){
                        try
                        {
                            if (out_of_guesses == false){
                                if (guess_count < guess_limit){
                                    guess_count += 1;
                                    chances -= 1;
                                    Console.Write($"Guess a number between 1-20, you have {chances} chances left: ");
                                    guess = int.Parse(Console.ReadLine());
                                    if (guess == secret_number_medium){
                                        Console.WriteLine("You got it right!");
                                        break;
                                    }else{
                                        Console.WriteLine("That was wrong");
                                    }       
                                }
                            }
                        if (guess_limit == guess_count)
                        {
                            Console.WriteLine("Game Over");
                        }
                        }
                        catch 
                        {
                            Console.WriteLine("Invalid entry, numbers only");
                        }
                    }
                }
                else if (level == "hard")
                {
                    Random r = new Random();
                    int secret_number_hard = r.Next(1, 50);
                    int guess = 0;
                    int guess_count = 0;
                    int guess_limit = 3;
                    bool out_of_guesses = false;
                    int chances = 3;

                    while (guess_count < guess_limit){
                        try
                        {
                            if (out_of_guesses == false){
                                if (guess_count < guess_limit){
                                    guess_count += 1;
                                    chances -= 1;
                                    Console.Write($"Guess a number between 1-50, you have {chances} chances left: ");
                                    guess = int.Parse(Console.ReadLine());
                                    if (guess == secret_number_hard){
                                        Console.WriteLine("You got it right!");
                                        break;
                                    }else{
                                        Console.WriteLine("That was wrong");
                                    }
                                }
                            }
                        if (guess_limit == guess_count)
                        {
                            Console.WriteLine("Game Over");
                        }
                        }
                        catch 
                        {
                            Console.WriteLine("Invalid entry, numbers only");
                        }
                    }
                }
                Console.Write("Do you still want to play(Enter Yes/No): ");
                play_again = Console.ReadLine();
                if (play_again == "Yes"){
                    status = true;
                }else{
                    status = false;
                }
            }
        }
    }
}
