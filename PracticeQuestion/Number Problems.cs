using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Count the number of digits
            //Console.WriteLine(Count_Number_of_digits(123));
            #endregion
            #region 2. Check given number length is odd or even
            //Console.WriteLine( Check_Odd_or_Even_length(1111));
            #endregion
            #region 3. Sum of digits
            //Console.WriteLine(Sum_of_Digits(234));
            #endregion
            #region 4. Sum of Odd positions Digits
            //Console.WriteLine(Sum_of_odd_position_Digits(5234));
            #endregion
            #region 5. Sum of Even Position Digits
            //Console.WriteLine(Sum_of_Even_position_Digits(5234));
            #endregion
            #region 6. Count the no of Even digits in Integer
            //Console.WriteLine(Count_No_Of_Even_Digits(0));
            #endregion
            #region 7. Count the no of Odd Digits in INteger
            // Console.WriteLine(Count_no_Odd_digits(1111));
            #endregion
            #region 8. Sum of Odd Digits in Number
            //Console.WriteLine(Sum_of_Odd_Digits(1234));
            #endregion
            #region 9. Sum of Even Digits in Number
            // Console.WriteLine(Sum_of_Even_Digits(1234));
            #endregion
            #region 10. Find Last Digit of the number
            //Console.WriteLine(Last_digit_of_Number(978965));
            #endregion
            #region 11. First Digit of the Number
            //  Console.WriteLine(First_Digit_Of_Number(978915));
            #endregion
            #region 12. First and last digits are the same
            //Console.WriteLine(First_Last_Digit_Are_Same(1234));
            #endregion
            #region 13. Max Value Digit
            //Console.WriteLine(Max_Value_Digit(1890));
            #endregion
            #region 14. Tense Location
            //Console.WriteLine(TenseLocation(12345321)+"s");
            #endregion
            #region 15. MinValueDigit
            //Console.WriteLine(MinValueDigit(1234583));
            #endregion
            #region 16. TenseLocationOFMinValue
            //Console.WriteLine(TenseLocationOfMinValue(12345)+"s");
            #endregion
            #region 17. Reverse A Given Integer
            // Console.WriteLine(ReverseNumber(1234));
            #endregion
            #region 18. Digital Root

            #endregion
            #region 19. 

            #endregion
            #region 21 Palindrome
            Console.WriteLine(Palindrom(121));
            #endregion
        }
        #region 1. count the number of digits
        public static int Count_Number_of_digits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count++;
                n = n / 10;
            }
            return count;
        }
        #endregion
        #region 2. Check given number is oddd or even length
        public static string Check_Odd_or_Even_length(int n)
        {
            string result = "";
            int count = 0;
            while(n>0)
            {
                count++;
               n= n / 10;
            }
            return count % 2 == 0 ? "Even" : "Odd";
        }
        #endregion
        #region 3. Sum of digits
        public static int Sum_of_Digits(int n)
        {
            int result = 0;
            while (n > 0)
            {
                result = result + n % 10;
                n = n / 10;
            }
            return result;
        }
        #endregion
        #region 4. Sum of Odd Position Digits
        public static int ReverseNumber(int n)
        {
            int reverse = 0;
            while (n != 0)
            {
                reverse = (reverse * 10) + (n % 10);
                n = n / 10;
            }
            return reverse;
        }
        public static int Sum_of_odd_position_Digits(int n)
        {
            int reverse = ReverseNumber(n);
            bool odd = true;
            int sumOdd = 0;
            while(reverse>0)
            {
                if(odd==true)
                {
                    sumOdd =sumOdd+ reverse % 10;
                    reverse = reverse / 10;
                    odd = false;
                }
                else if(odd==false)
                {
                    reverse = reverse / 10;
                    odd = true;
                }
            }
            return sumOdd;
        }
        #endregion
        #region 5. Sum of Even Position Digits
       
        public static int Sum_of_Even_position_Digits(int n)
        {
            int reverse = ReverseNumber(n);
            bool even = false;
            int SumEven = 0;
            while (reverse > 0)
            {
               
                if (even == false)
                {
                    reverse = reverse / 10;
                    even = true;
                }
                else if (even == true)
                {
                    SumEven = SumEven + reverse % 10;
                    reverse = reverse / 10;
                    even = false;
                }
            }
            return SumEven;
        }
        #endregion
        #region 6. count the number of Even digits in integer
        public static int Count_No_Of_Even_Digits(int n)
        {
            int digits = 0;
            int count = 0;
            while(n!=0)
            {
                digits = n % 10;
                n = n / 10;
                if(digits%2==0)
                {
                    count++;
                }
            }
            return count;
        }
        #endregion
        #region 7. Count the number of Odd digits in integer
        public static int Count_no_Odd_digits(int n)
        {
            int digit = 0;
            int count = 0;
            while(n!=0)
            {
                digit = n % 10;
                n = n / 10;
                if(digit%2!=0)
                {
                    count++;
                }
            }
            return count;
        }
        #endregion
        #region 8. Sum of The odd Digits in integer
        public static int Sum_of_Odd_Digits(int n)
        {
            int digit = 0;
            int sum = 0;
            while(n!=0)
            {
                digit = n % 10;
                if(digit%2!=0)
                {
                    sum = sum + digit;
                }
                n /= 10;
            }
            return sum;
        }
        #endregion
        #region 9. Sum of The Even Digits in integer
        public static int Sum_of_Even_Digits(int n)
        {
            int digit = 0;
            int sum = 0;
            while (n != 0)
            {
                digit = n % 10;
                if (digit % 2 == 0)
                {
                    sum = sum + digit;
                }
                n /= 10;
            }
            return sum;
        }
        #endregion
        #region 10. Find last Digit of the number
        public static int Last_digit_of_Number(int n)
        {
            int last_digit = n % 10;
            return last_digit;
        }
        #endregion
        #region 11. First Digit of the number
        public static int First_Digit_Of_Number(int n)
        {
            while(n>=10)
            {
                n = n / 10;
            }
            return n;
        }
        #endregion
        #region 12. First and last digit is same
        public static string First_Last_Digit_Are_Same(int n)
        {
            string Check = "";
            int first_Digit = First_Digit_Of_Number(n);
            int last_Digit = Last_digit_of_Number(n);
            if(first_Digit==last_Digit)
            {
                Check = "Same";
            }
            else
            {
                Check = "Not Same";
            }
            return Check;
        }
        #endregion
        #region 13. Max value Digit
        public static int Max_Value_Digit(int n)
        {
            int max = 0;
            int digit = 0;
            while(n!=0)
            {
                digit = n % 10;
                if(max<digit)
                {
                    max = digit;
                }
                n /= 10;
            }
            return max;
        }
        #endregion
        #region 14. Tense Location
        public static double TenseLocation(int n)
        {
            double Pos = 0;
            int count = 0;
            int digit = 0;
            int max = Max_Value_Digit(n);
            while(n!=0)
            {
                digit = n % 10;
                count++;
                n /= 10;
                if(max==digit)
                {
                    break;
                }
            }
            Pos = Math.Pow(10, (count-1));
            return Pos;
        }
        #endregion
        #region 15. Min Value Digit
        public static int MinValueDigit(int n)
        {
            int min = int.MaxValue;
            int digit = 0;
            while (n != 0)
            {
                digit = n % 10;
                if (min > digit)
                {
                    min = digit;
                }
                n /= 10;
            }
            return min;
        }
        #endregion
        #region 16. TenseLocationOfMinValue
        public static double TenseLocationOfMinValue(int n)
        {
            int min = MinValueDigit(n);
            int digit = 0;
            int count = 0;
            while(n!=0)
            {
                digit = n % 10;
                count++;
                if(digit==min)
                {
                    break;
                }
                n /= 10;
            }
            double pos = Math.Pow(10, (count - 1));
            return pos;
        }
        #endregion
        #region 18. DigitalRoot
        #endregion
        #region 21. Palindrome
        public static string Palindrom(int n)
        {
            int Reverse = ReverseNumber(n);
            string check = "Not Palindrome";
            if(Reverse==n)
            {
                check = "Is Palindrome";
            }
            return check;
        }
        #endregion
    }
}
