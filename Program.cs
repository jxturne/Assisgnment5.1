namespace Assisgnment5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("Palindrome Check:");
           bool result = isPalindrome(121);
            Console.WriteLine(result);

            Console.WriteLine("\nSum of Digits:");
            int sum = SumOfDigits(12345);
            Console.WriteLine($"The sum of the digits is: {sum}");

            Console.WriteLine("\nUnique Elements Check:");
            int[] nums = { 1, 2, 3, 1};
            bool uniqueResult = IsUnique(nums);


        }
        static bool isPalindrome(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Negative numbers are not palindromes.");
            }
            
            int original = n;  
            int reverse = 0;
            
            while (n > 0)
            {
                int tempo = n % 10;
                reverse = reverse * 10 + tempo;
                n = n / 10;
            }
            
            if (reverse == original)
            {
                Console.WriteLine($"The number {original} is a palindrome. Backwards it is {reverse} ");
                return true;
            }
            else
            {
                Console.WriteLine($"The number {original} is not a palindrome. Backwards it is {reverse}");
                return false;
            }


        }
        static int SumOfDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            return sum;
        }
        static bool IsUnique(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j =i+1;j<nums.Length;j++)
                {
                    if (nums[i] == nums[j])
                    {
                        foreach (var item in nums)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine($"\nThe array contains duplicates {nums[i]} at index {i} and {j}");
                        return false;
                    }
                }
            }
            Console.WriteLine("The array contains all unique elements.");
            return true;

        }

    }
}
