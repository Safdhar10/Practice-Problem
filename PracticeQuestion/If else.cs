using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOne
{
    class Program
    {
        private static double nt;
        static void Main(string[] args)
        {
            #region 2. Calculation
           // Calculation();
            #endregion
            #region 3. power of  b
           // PowerOf();
            #endregion
            #region 4. Rectangular
         //   VolumeofRectangle();
            #endregion
            #region 5. PerimeterofCircle
           // PerimeterofCircle();
            #endregion
            #region 6. Remainder
            //  QuotientAndRemainder();
            #endregion
            #region 7.Square
            //SquareofNumber();
            #endregion
            #region 8. SquareRoot
         SquareRoot();
            #endregion
            #region 9. AreaofTriangle
           // AreaofTriangle();
            #endregion
            #region 10. Km to Mile
           // KiloMetertoMile();
            #endregion
            #region 11. Celsius to Fahrenheit
           // Celsius();
            #endregion
            #region 12. SwapwithTemp
           // Swap();
            #endregion
            #region 13. SwapwithoutTemp
            //Swapwithout();
            #endregion
            #region 14. CausingOverflow
            //Swapover();
            #endregion
            #region 15. Random Number
          //  randomnumber();
            #endregion
            #region 16.Acres
           // acres();
            #endregion
            #region 17.SumofNaturals
           // SumofN();
            #endregion
            #region 18.Tips
           // tip();
            #endregion
            #region 19. Tax
           // tax();
            #endregion
            #region 20. Grosspay
         //   Grosspay();
            #endregion
            #region 21.SimpleInterest
           // simple();
            #endregion
            #region 22.CompoundInterest
           // compound();
            #endregion
            #region 23. Height of person
            // height();
            #endregion
            #region 24. BMI
           // bmi();
            #endregion
            #region 25. marks
         //   Total();
            #endregion
            Console.ReadLine();
        }
        #region commonmethods
        public static void PrintMessage(String Message)
        {
            Console.WriteLine(Message);

        }
        public static int GetInt(String Message)
        {
            PrintMessage(Message);
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
        public static double GetDouble(String Message)
        {
            PrintMessage(Message);
            double input = Convert.ToDouble(Console.ReadLine());
            return input;
        }
        public static string GetString(String Message)
        {
            PrintMessage(Message);
            string input = Console.ReadLine();
            return input;
        }
        public static int Additon(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        public static int Difference(int num1, int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1 - num2;
                return result;
            }
            else
            {
                result = num2 - num1;
                return result;
            }
        }
        public static int Product(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
        public static bool checkrange(int num1, int num2)
        {
            if (num1 > 0 && num2 > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double checkdouble(double number)
        {
            if (number > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static int checkint (int num)
        {
            if (num > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        #endregion   
        #region 2. calculation
		 public static void Calculation()
        {
            int number1 =GetInt("Enter A First Number");
            int number2 =GetInt("Enter A Second Number");
            if (checkrange(number1,number2)==true)
            {
               PrintMessage( string.Format("The sum is of {0} and {1} is {2}.", number1, number2, (number1+number2)));
               // PrintMessage("The Sum is:"+Additon(number1,number2));
                PrintMessage("The Product is:"+Product(number1,number2));
                PrintMessage("The Difference is:" + Difference(number1, number2));  
            }         
            else
            {
                Console.Clear();
                PrintMessage("Enter Positive Numbers");
                Calculation();
            }
        }
	#endregion
        #region 3. Powerof
		public static void PowerOf()
        {
            int a = GetInt("Enter value of a");
            int b = GetInt("Enter value of b");
            if (checkrange(a, b) == true)
            {
                PrintMessage(string.Format("The value of {0} power of {1} is {2}", a, b, Math.Pow(a, b)));
            }
            else
            {
                Console.Clear();
                PrintMessage("Please Enter valid values");
                PowerOf();
            }
        } 
	#endregion
        #region 4. Rectanglar   
        public static void VolumeofRectangle()
        {
            double l = GetDouble("Enter value of Length");
            double w = GetDouble("Enter value of Width");
            double h = GetDouble("Enter value of height");
            if (checkdouble(l) == 1 & checkdouble(w) == 1 & checkdouble(h) == 1)
            {
                PrintMessage(String.Format("The volume of Rectangular is {0}", l * w * h));
            }
            else
            {
                Console.Clear();
                PrintMessage("Please Enter valid values");
                VolumeofRectangle();
            }


        }
        #endregion
        #region 5.PerimeterofCircle
        public static void PerimeterofCircle()
        {
            double radius = GetDouble("Enter radius of circle");
            double pi=3.143; 
            if (checkdouble(radius)==1)
            {
                PrintMessage(string.Format("The perimeter of circle is {0}", 2 * pi * radius));
            }
        }
        #endregion
        #region 6. Remainder
        public static void QuotientAndRemainder()
        {
            double numerator = GetDouble("Enter Numerator Value");
            double Denominator = GetDouble("Enter Denominator value");
            if (checkdouble(numerator) == 1 & checkdouble(Denominator) == 1)
            {
                PrintMessage(string.Format("The Quotient {0} of {1} is {2} and Remainder is {3}", numerator, Denominator, (numerator / Denominator), (numerator % Denominator)));
            }
            else
            {
                Console.Clear();
                PrintMessage("Enter valid values");
                QuotientAndRemainder();
            }
        }
        #endregion
        #region 7. Square
        public static void SquareofNumber()
        {
            double num = GetDouble("Enter a number");
            if (checkdouble(num) == 1)
            {
                PrintMessage(String.Format("The Square value of {0} is {1}", num, (num*num)));
            }
        }
        #endregion
        #region 8. SquareRoot
        public static void SquareRoot()
        {
            double num = GetDouble("Enter a number");
            
                PrintMessage(String.Format("The Square Root value of {0} is {1}", num, Math.Sqrt(num)));
            
        }
        #endregion
        #region 9. AreaofTriangle
        public static void AreaofTriangle()
        {
            double b = GetDouble("Enter the value of b");
            double h = GetDouble("Enter the value of h");
            if (checkdouble(b)==1 & checkdouble(h)==1)
            {
                PrintMessage(string.Format("Area of Triangle is {0}", ((b * h)/2)));
            }
        }
        #endregion
        #region 10. km to mile
        public static void KiloMetertoMile()
        {
            double km = GetDouble("Enter a value of KiloMETER");
            //  1 mile=1.60934km and 1 km=0.621371mile
           
            if (checkdouble(km) == 1)
            {
                PrintMessage(String.Format("{0} Kilometer is Equal to {1} miles", km, (km /1.60934)));
            }
        }
        #endregion
        #region 11.celsius to fahrenheit
        public static void Celsius()
        {
            double c = GetDouble("Enter value of celusius");
            if (checkdouble(c) == 1)
            {
                PrintMessage(String.Format("{0} Celsius is equal to {1} degree Fahrenheit", c, (c * 9 / 5) + 32));
            }
        }
        #endregion
        #region 12.SwapwithTemp
        public static void Swap()
        {
            int a = GetInt("Enter a number");
            int b = GetInt("Enter a number");
            int temp = 0 ;
            temp = b;
            b = a;
            a = temp;
            PrintMessage(string.Format("The Swap value is {0} and {1}", a, b));

        }
        #endregion
        #region 13. SwapwithoutTemp
        public static void Swapwithout()
        {
            int a = GetInt("Enter a number");
            int b = GetInt("Enter a second number");
                a = a + b;
                b = a - b;
                a = a - b;
            PrintMessage(string.Format("The Swap value without temp is {0} and {1}", a, b));
        }
        #endregion
        #region 14. CausingOverFlow
        public static void Swapover()
        {
            int a = GetInt("Enter a first number");
            int b = GetInt("Entern a Second Number");
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            PrintMessage(String.Format("After Swaping with CausingOverFlow is {0} and {1}", a, b));
        }
        #endregion
        #region 15. Random Number
        public static void randomnumber()
        {
            Random r=new Random();
            PrintMessage(String.Format("Random Number Between 1 and 100 is {0}", r.Next(1, 100)));
        }
        #endregion
        #region 16. Acres
        public static void acres()
        {
            double l = GetDouble("Enter length of field in feet");
            double w = GetDouble("Enter width of field in feet");
            if(checkdouble(l)==1 & checkdouble(w)==1)
            {
            double a= (l*w)/43560;
            PrintMessage(string.Format("Area of the Field of length {0} ft and width {1} ft is {2} acres", l, w, a));
            }
        }
        #endregion
        #region 17. SumofNatural
        public static void SumofN()
        {
            int n =GetInt("Enter any number");
            PrintMessage(String.Format("Sum of {0} is {1}", n, (n * (n + 1) / 2)));
            int sum=0;
            if (n > 0)
            {
                for (int i = 1; i <=n; i++)
                {
                    sum = sum + i;
                }
                PrintMessage(String.Format("Sum of {0} Natural Number is {1}",n,sum));
            }
        }
        #endregion
        #region 18. Tip
        public static void tip()
        {
            int billamount = GetInt("Enter Bill Amount");
            double tip=billamount * 5 / 100;
            if (billamount > 10)
            {
                PrintMessage(String.Format("The tip for Rs.{0} is Rs.{1}", billamount, tip));
            }
        }
        #endregion
        #region 19. Tax
        public static void tax()
        {
            double amount = GetDouble("Enter Total Amount");
            double tax = GetInt("Enter Tax Percentage");
            double netamount =amount+(amount *( tax/100)) ;
            PrintMessage(String.Format("The Net Amount is {0} where it have as Tax {1} % and Total Amount is {2}",netamount,tax,amount));

        }
        #endregion      
        #region 20. GrossPay
        public static void Grosspay()
        {
            int basicpay = GetInt("Enter Basic PAY");
            double da = GetDouble("Enter DA in %")/100;
            double ta = GetDouble("Enter TA in %")/100;
            double pf=basicpay*8/100;
            if (checkint(basicpay) == 1 & checkdouble(da) == 1 & checkdouble(ta)==1)
            {
                PrintMessage(String.Format("The gross pay is {0}", (basicpay + da + ta - pf)));
            }

        }
        #endregion
        #region 21.SimpleInterest
        public static void simple()
        {
            int p = GetInt("Enter Principal amount");
            int n = GetInt("Enter No. of Month");
            double r = GetDouble("Enter Rate of Interest in %");
            double si = p * n * r / 100;
            PrintMessage(String.Format("Simple Interest is {0}",si));

        }
        #endregion
        #region 22. CompoundInterest
        public static void compound()
        {
            double p = GetInt("Enter the principal amount");
            double n = 12;
            double r = GetDouble("Enter rate of interest")/100;
            double t = GetDouble("Enter No of Time Periods");
            double ci = p * Math.Pow((1 + r / n), (n * t));
            PrintMessage(String.Format("Compount Interest after {0} years is {1}",t,ci));
        }
        #endregion
        #region 23.Height of Person
        public static void height()
        {
            double h = GetDouble("Enter the Height of person in cm");
            PrintMessage(string.Format("Height of person in inches is {0} inches and {1} ft", (h / 2.54), (h * 0.0328084)));
        }
        #endregion
        #region 24. BMI
        public static void bmi()
        {
            double w = GetDouble("Enter Wieght in kg");
            double h = GetDouble("Enter Height in mt");
            PrintMessage(string.Format("BMI is {0}", (w / (h * h))));
        }
        #endregion
        #region 25. Total
        public static void Total()
        {
            string rollno = GetString("Enter Rollno");
            string name = GetString("Enter Name");
            int mark1 = GetInt("Enter Mark1");
            int mark2 = GetInt("Enter mark2");
            int mark3 = GetInt("Enter mark3");

            PrintMessage(string.Format("RollNo\tName\tMark1\tMark2\tMark3\tTotal\tAverage\n{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", rollno, name, mark1, mark2, mark3, (mark1 + mark2 + mark3), (mark1 + mark2 + mark3) / 3));
        }
        #endregion
    }
}
