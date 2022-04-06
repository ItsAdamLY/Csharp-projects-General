namespace RandomGuess
{
    public class RandomGuess
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int randomNo = random.Next(1, 20);
            int inputNo = 0, guess = 5;

            while (guess != 0)
            {
                do
                {
                    Console.WriteLine("Enter a number between 1 and 20.");

                    try
                    {
                        inputNo = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("This is not an integer!");
                        continue;
                    }

                    if (inputNo < 1 || inputNo > 20)
                        Console.WriteLine("Your input number is out of range, dummy!");

                } while (inputNo < 1 || inputNo > 20);

                --guess;

                if (inputNo != randomNo && guess != 0)
                {
                    Console.WriteLine("Sorry, your guess is incorrect. You have " + guess +
                        " guesses left.");
                }

                else if (inputNo != randomNo && guess == 0)
                    Console.WriteLine("Sorry, all of your guesses are incorrect. The correct " +
                        "answer is : " + randomNo);


                else
                {
                    Console.WriteLine("Congratulations! You have guessed the correct number : " + randomNo + "!");
                    break;
                }

            }
        }
    }
}