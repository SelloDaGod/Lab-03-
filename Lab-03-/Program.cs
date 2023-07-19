namespace Lab_03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 3 numbers separated by spaces:");
            string input = Console.ReadLine();
            // Calculate the product of the 3 numbers provided by the user
            int product = CalculateProduct(input);

            // Display the result to the user
            Console.WriteLine("The product of these 3 numbers is: " + product);
        }

        static int CalculateProduct(string input)
        {
            // Split the input string into an array of strings using spaces as the separator
            string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int product = 1;

            // Iterate through the first parsedCount numbers and try to parse them as integers
            for (int i = 0; i < 3; i++)
            {
                // Try parsing the current number from the array
                // If parsing succeeds, store the parsed value in parsedNumbers[i]
                // If parsing fails, set parsedNumbers[i] to 1 as a default value
                string numberString = numbers[i];
                int number = int.Parse(numberString);
                product = product * number;
            }
            // Return the calculated product to the caller
            return product;
        }
    }

}