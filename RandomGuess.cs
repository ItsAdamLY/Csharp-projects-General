namespace RandomGuess
{
    public class RandomGuess
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int randomNo = random.Next(1, 20);
            string input;
            int guess = 5, inputNo = 0, prevGuess = 0, hint = 3;

            while (guess != 0)
            {
                do
                {
                    Console.WriteLine("Enter a number between 1 and 20. You have " + 
                        hint + " hints left and " + guess + " guesses left.");

                    input = Console.ReadLine();

                    while (true)
                    {
                        if (input.ToLower() == "hint" && guess < 5)
                        {
                            if (prevGuess > randomNo && hint > 0)
                            {
                                Console.WriteLine("Your previous number " + prevGuess + " is HIGHER than " +
                                    "the correct answer.");
                                --hint;
                            }

                            else if (prevGuess < randomNo && hint > 0)
                            {
                                Console.WriteLine("Your previous number " + prevGuess + " is LOWER than " +
                                    "the correct answer.");
                                --hint;
                            }

                            else if (hint == 0)
                            {
                                Console.WriteLine("You are out of hints.");
                            }
                        }

                        else if (input.ToLower() == "hint" && guess == 5)
                            Console.Write("Make a guess first!\n");

                        else if (int.TryParse(input, out inputNo))
                            break;

                        else
                            Console.WriteLine("That is not an integer!");

                        Console.WriteLine("\nEnter a number between 1 and 20. You have " +
                        hint + " hints left and " + guess + " guesses left.");

                        input = Console.ReadLine();
                    }
                    
                    inputNo = Convert.ToInt32(input);

                    if (inputNo < 1 || inputNo > 20)
                    {
                        Console.WriteLine("Your guess is out of range!");
                    }


                } while (inputNo < 1 || inputNo > 20);

                --guess;
                prevGuess = inputNo;

                if (inputNo != randomNo && guess != 0)
                {
                    Console.WriteLine("\nSorry, your guess is incorrect. You have " + guess +
                        " guesses left.");
                }

                else if (inputNo != randomNo && guess == 0)
                    Console.WriteLine("\nSorry, all of your guesses are incorrect. The correct " +
                        "answer is : " + randomNo);


                else
                {
                    Console.WriteLine("\nCongratulations! You have guessed the correct number : " + randomNo + "!");
                    break;
                }

            }
        }
    }
}