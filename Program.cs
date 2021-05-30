using System;

namespace My_Awesome_Program
{
    class Program
    {   
        
        public static double RoundUp(double input, int places)
        {
        double multiplier = Math.Pow(10, Convert.ToDouble(places));
        return Math.Ceiling(input * multiplier) / multiplier;
        }

        static void Main(string[] args)
        {   

            // Change the appearance

            Console.Title = "[MathTrainer] 3000";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WindowHeight = 40;
            Console.WindowWidth = 50;


            /////////////////Working Area/////////////////

            Console.WriteLine("Welcome to the Ultimate [Math Trainer] 3000");
            Console.WriteLine("A program by Developer iTzMarsi aka Marius\n");



            bool loop = true;
            while (loop) {

            Console.WriteLine("How many rounds do you want to play?");
            int rounds = Convert.ToInt16(Console.ReadLine());
            int points = 0;
            bool correctAnswers;

            if(rounds == 1) 
            {
                Console.WriteLine(rounds + " round. Okay, Press any key to start...");
            } else {
                Console.WriteLine(rounds + " rounds. Okay, Press any key to start...");
            }

            
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");

            Console.WriteLine("----------------------------------------");

            Console.ReadKey();
            for (int i = 0; i < rounds; i++)
            {
                correctAnswers = MathTest(false); 
                if (correctAnswers)
                {
                    points++;
                }
            }

            //Console.WriteLine("Well done, you did it!"); 

/////////////////////////////////////

            if (points == rounds) 
            Console.WriteLine("Score: " + points + "/" + rounds + "\nWell done, you did it!"); 
            
            
            else if (points == 0)
            Console.WriteLine("Score: " + points + "/" + rounds + "\nLooooser!");

            else
            Console.WriteLine("Score: " + points + "/" + rounds + "\nTry Again.");

            Console.WriteLine("Do you want to play again? (Y/N)");
            string playerAnswer = Console.ReadLine().ToUpper();

            if (playerAnswer == "Y")
            {   
                Console.WriteLine("Do you want to clear the screen first? (Y/N)");
                string playerAnswerNew = Console.ReadLine().ToUpper();


                if (playerAnswerNew == "Y") {
                    Console.Clear();
                } else if (playerAnswerNew == "N") {

                } else {

                }

                continue;
            } else if (playerAnswer == "N") {
                loop = false;
                Exit();
            }
            else {
                loop = false;
                Exit();
            }

            }
            
////////////////////////////////////

            //Wait before closing
            
            /////////////////////


        }

        

        static bool MathTest(bool correct)
        {   
            
            correct = false;

            var rand = new Random();

            //Define the range of numbers
            //rand.Next(0, 100) takes numbers including 0-99    ----- The last number (100) won't be included!
            //You can either go crazy with something like (0, 100000) and also use multiplications and Divisions
            //Play around as much as you want :D

            int num1 = rand.Next(0, 100);
            int num2 = rand.Next(0, 100);

            //Define what types of calculations you want to do: 1: Add, 2: Sub, 3: Mult, 4: Div
            //so rand.Next(1,2) would just be Addition and Substraction
            int num3 = rand.Next(1, 4);

            double result;

            switch (num3) {
                case 1:
                    Console.WriteLine(num1 + "+" + num2);
                    result = num1 + num2;
                    Console.WriteLine("What's the result?");

                    if (result == Convert.ToDouble(Console.ReadLine())){
                        Console.WriteLine("That's Correct! You are a genius!");
                        correct = true;
                    } else{
                        Console.WriteLine("Maybe next time :)");
                        Console.WriteLine("The result is: " + result);
                        correct = false;
                    }

                    break;
                case 2:
                    Console.WriteLine(num1 + "-" + num2);
                    result = num1 - num2;
                    Console.WriteLine("What's the result?");

                    if (result == Convert.ToDouble(Console.ReadLine())){
                        Console.WriteLine("That's Correct! You are a genius!");
                        correct = true;
                    } else{
                        Console.WriteLine("Maybe next time :)");
                        Console.WriteLine("The result is: " + result);
                        correct = false;
                    }
                    
                    break;
                case 3:
                    Console.WriteLine(num1 + "*" + num2);
                    result = num1 * num2;
                    Console.WriteLine("What's the result?");

                    if (result == Convert.ToDouble(Console.ReadLine())){
                        Console.WriteLine("That's Correct! You are a genius!");
                        correct = true;
                    } else{
                        Console.WriteLine("Maybe next time :)");
                        Console.WriteLine("The result is: " + result);
                        correct = false;
                    }
                    
                    break;
                case 4:
                    Console.WriteLine(num1 + "/" + num2);
                    result = num1 / num2;
                    Console.WriteLine("What's the result?");

                    if (result == Convert.ToDouble(Console.ReadLine())){
                        Console.WriteLine("That's Correct! You are a genius!");
                        correct = true;
                    } else{
                        Console.WriteLine("Maybe next time :)");
                        Console.WriteLine("The result is: " + result);
                        correct = false;
                    }
                    
                    break;
                 
            }     
            return correct;
        }

        static void Exit(){
            Console.WriteLine("-----------Close by pressing any key-----------");
            Console.ReadKey();
            
        }

    }
}
