using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberProblem2_Question6_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Factors of N
            // Console.WriteLine(FactorsOfN());
            #endregion
            #region 2. PRime or Not
            //bool result = PrimeOrNot(18);
            //PrintMessage(result ? "YES" : "NO");
            #endregion
            #region 3. Print All Number From 1 to N
            //PrimeNumberFrom1toN();
            #endregion
            #region 4. Print N PRime number
            //FirstNPrimeNumber();
            #endregion
            #region 5. Number of Prime Number less than or Equal to N
            //PrintMessage(string.Format("Number of PrimeNumbers Between N is {0}", NumberofPrimeNumberLestThanOREqualToN().ToString()));
            #endregion
            #region 6. Sum of First N prime Numbers
            //PrintMessage(string.Format("Sum of PRime Number is {0}", SumOfFirstPRimeNUmbers()));
            #endregion
            #region 7. Sum of All Prime Numbers less than N
            //PrintMessage(SumOfAllPrimeNumberLessThanN().ToString());
            #endregion
            #region 8. Print All Prime Number Between M and N
            //PrimeNumber_Between_M_and_N(1, 30);
            #endregion
            #region 9. PrimeFactorsofGivenNumberN
            //PrimeFactorsofN(6);
            #endregion
            #region 10. Number of Prime Number Between M and N
            //PrintMessage(NumberOfPrimeNumberBetweenMandN(5,30).ToString());
            #endregion
            #region 11. Prime Number Between M and N and M > N
            //PRimeBetweenMandN_(30,2);
            #endregion
            #region 12. Number of Prime Number Between M and N and M>N
            //PrintMessage(NumberOfPrimeNumberBetweenM_N(30, 5).ToString());
            #endregion
            #region 15. Next Prime Number 
            // PrintMessage(NextPrime(11).ToString());
            #endregion
            #region 16. Previous Prime Number
            //PrintMessage(PreviousPrime(1001).ToString());
            #endregion
            #region 17. Nearest Prime Number
            //PrintMessage(NearestPrime(1000).ToString());
            #endregion
            #region 18. Kth Prime Number
            //PrintMessage(KthPrimeNumber(1,3).ToString());
            #endregion
            #region 19. Check if there exist prime number or not
            //PrintMessage(checkIfExistPrimeNumber(1,22) ? "We found prime number" : "We cant found any prime number");
            #endregion
            #region 20. Max Number of Distinct Prime Factors
            //MaxNumberOfDistinctPrime(10,31);
            #endregion
            #region 21. Check if N is represented By Product of Two Prime NUmber
            //PrintMessage(N_Is_RepresentedBy_Product_Two_Prime_Number(4).ToString());
            #endregion
            #region 22. Check if N is represented By Product of Two Unique Prime Number
            //PrintMessage(N_Can_Be_Represented_By_Unique_PRime(6).ToString());
            #endregion
            #region 23. Represent a Product of PRime Number
            //for(int i=2;i<=30;i++)
            //{
            //    ProductOfPRimeNumber(i);
            //}
            #endregion
            #region 24. LargestprimeNumber
            //PrintMessage(LargestPrimeNumber(200,10).ToString());
            #endregion
            #region 25. SmallestPrimeNumber
            //PrintMessage(SmallestPrimeNumber(200, 10).ToString());
            #endregion
            
        }
        #region CommonMethods
        public static int GetInt(string message)
        {
            PrintMessage(message);
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        public static void PrintMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion
        #region 1. Factors of N
        public static int FactorsOfN(int n)
        {
            int x = 1;
            int count = 0;
            while(x<=n)
            {
                if(n%x==0)
                {
                    count++;
                }
                x++;
            }
            return count;
        }
        #endregion
        #region PrimeFactorsOfN
        public static int Count_OF_PrimeFactorOfN(int n)
        {
            int count = 0;
            if(n%2==0)
            {
                count++;
            }
            int x = 3;
            while(x<=n)
            {
                if(n%x==0 && PrimeOrNot(x))
                {
                    count++;
                }
                x = x + 2;
            }
            return count;
        }
        #endregion
        #region 2. PrimeNumber
        public static bool PrimeOrNot(int n)
        {
            bool check = true;
            if(n<2)
            {
                check = false;
                return check;
            }
            //using root n method
            for(int j=2;j*j<=n;j++)
            {
                if(n%j==0)
                {
                    check = false;
                    return check;
                }
            }
            //using n/2 method

            for (int k=2;k<n/2;k++)
            {
                if(n%k==0)
                {
                    check = false;
                    return check;
                }
            }
            //using by factors

            int count = FactorsOfN(n);
            if (count != 2)
            {
                check = false;
            }

            //normal method

            int i = 2;

            while (i < n)
            {
                if (n % i == 0)
                {
                    check = false;
                    return check;
                }
                i++;
            }
            return check;
        }
        #endregion
        #region 3. Print All Prime Number From 1 to N
        public static void PrimeNumberFrom1toN()
        {
            PrintMessage("Enter N value");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 3;
            while(i<=n)
            {
                bool check = PrimeOrNot(i);
                if(check)
                {
                    PrintMessage(i.ToString());
                }
                i = i + 2 ;
            }
        }
        #endregion
        #region 4. First N PrimeNumber
        public static void FirstNPrimeNumber()
        {
            int n = GetInt("Enter N");
            int i = 3;
            while(n>0)
            {
                if(PrimeOrNot(i))
                {
                    PrintMessage(i.ToString());
                    n--;
                }
                i=i+2;
            }

        }
        #endregion
        #region 5. Number of Prime Number less than or Equal to N
        public static int NumberofPrimeNumberLestThanOREqualToN()
        {
            int n = GetInt("enter n ");
            int i = 3;
            int count = 0;
            if(n>=2)
            {
                count = 1;
            }
            while(i<=n)
            {
                if(PrimeOrNot(i))
                {
                    count++;
                }
                i=i+2;
            }
            return count;
        }
        #endregion
        #region 6. Sum of First N prime Numbers
        public static int SumOfFirstPRimeNUmbers()
        {
            PrintMessage("Enter N value");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 3;
            int sum = 0;
            if(n>=2)
            {
                sum = 2;
            }
            while (i <= n)
            {
                bool check = PrimeOrNot(i);
                if (check)
                {
                    sum += i;
                }
                i=i+2;
            }
            return sum;
        }
        #endregion
        #region 7. Sum of All Prime Numbers less than N
        public static int SumOfAllPrimeNumberLessThanN()
        {
            int n = GetInt("Enter N");
            int i = 3;
            int sum = 0;
            if(n>=2)
            {
                sum = 2;
            }
            PrintMessage(string.Format("Sum of Prime Number Less than {0} is",n ));
            while (n>0)
            {
                if(PrimeOrNot(i))
                {
                    sum += i;
                    n--;
                }
                i=i+2;
            }
            return sum;
        }
        #endregion
        #region 8. Print All Prime Number Between M and N and M<N
        public static void PrimeNumber_Between_M_and_N(int m,int n)
        {
            if(m<=2)
            {
                PrintMessage("2");
            }
            if(m%2==0)
            {
                m = m + 1;
            }
            while(m<=n)
            {
                if(PrimeOrNot(m))
                {
                    PrintMessage(m.ToString());
                }
                m=m+2;
            }
        }
        #endregion
        #region 9. PrimeFactorsofGivenNumberN
        public static void PrimeFactorsofN(int n)
        {
            if(n%2==0)
            {
                PrintMessage("2");
            }
            int x = 3;
            while(x<=n)
            {
                if(n%x==0)
                {
                    if(PrimeOrNot(x))
                    {
                        PrintMessage(x.ToString());
                    }
                }
                x=x+2;
            }
        }
        #endregion
        #region 10. Number of Prime Number Between M and N
        public static int NumberOfPrimeNumberBetweenMandN(int m,int n)
        {
            int count = 0;
            PrintMessage(string.Format("Number Of Prime Number Between {0} and {1} is", m, n));
            if (m <= 2)
            {
                count++;
            }
            if (m % 2 == 0)
            {
                m = m + 1;
            }
            while (m <= n)
            {
                if (PrimeOrNot(m))
                {
                    count++;
                }
                m = m + 2;
            }
            return count;
        }
        #endregion
        #region 11. Print All Prime Number Between M and N and M>N
        public static void PRimeBetweenMandN_(int m,int n)
        {
            if(m>n)
            {
                int temp = n;
                n = m;
                m = temp;
            }
            PrimeNumber_Between_M_and_N(m, n);
        }
        #endregion
        #region 12. Number of Prime Number between M and N m>n
        public static int NumberOfPrimeNumberBetweenM_N(int m,int n)
        {
            if (m > n)
            {
                int temp = n;
                n = m;
                m = temp;
            }
            PrintMessage(string.Format("Number Of Prime Number Between {0} and {1} is", m, n));
            int count = 0;
            count = NumberOfPrimeNumberBetweenMandN(m, n);
            return count;
        }
        #endregion
        #region 13. What if Even
        public static int Check_M_Even(int m)
        {
            if(m%2==0)
            {
                m = m + 1;
            }
            return m;
        }
        #endregion
        #region 15. Next Prime Number 
        public static int NextPrime(int n)
        {
            int count = 0;
            if(n<2)
            {
                return 2;
            }
            int check = n;
            n = Check_M_Even(n);
            while(count!=1 )
            {
                if (PrimeOrNot(n) & n!=check)
                {
                    count++;
                }
                n=n+2;
            }
            return n-2;
        }
        #endregion
        #region 16. Previous Prime Number
        public static int PreviousPrime(int n)
        {
            int count = 1;
           // PrintMessage(string.Format("Previous Prime Number after {0} is", n));
            if (n <= 2)
            {
                return -1;
            }
            if(n==3)
            {
                return 2;
            }
            int check = n;
            n = Check_M_Even(n);
            while (count != 0)
            {
                n = n - 2;
                if (PrimeOrNot(n) & n != check)
                {
                    count--;
                }
            }
            return n;

        }
        #endregion
        #region 17. Nearest Prime Number
        public static int NearestPrime(int n)
        {
            int previous = PreviousPrime(n);
            int next = NextPrime(n);
            PrintMessage(string.Format("Nearest Prime Number of {0} is" , n));
            if((n-previous)>(next-n))
            {
                return next;
            }
            else
            {
                return previous;
            }
        }
        #endregion
        #region 18. Kth Prime Number
        public static int KthPrimeNumber(int n,int k)
        {
            PrintMessage(string.Format("{0}th Prime Number After {1} is", k,n));
            int count = 0;
            int check = n;
            if(n<2)
            {
                count++;
            }
            n = Check_M_Even(n);
            while (count != k)
            {
                if (PrimeOrNot(n) & n != check)
                {
                    count++;
                }
                n=n+2;
            }
            return n - 2;
        }
        #endregion
        #region 19. Check if There Exist Prime Number Between M and N
        public static bool checkIfExistPrimeNumber(int m , int n)
        {
            bool check = false;
            PrintMessage(string.Format("Between {0} and {1} ", m, n));
            if(m<=2)
            {
                check = true;
                return check;
            }
            m = Check_M_Even(m);
            while(m<=n)
            {
                if(PrimeOrNot(m))
                {
                    check = true;
                    break;
                }
                m=m+2;
            }
            return check;
        }
        #endregion
        #region 20. Max Number of Distinct Prime Factors
        public static void MaxNumberOfDistinctPrime(int m, int n)
        {
            int maxcount = 0;
            PrintMessage(string.Format("Between {0} and {1}", m, n));
            int result = 0;
            int i = m;
            while(m<=n)
            {
                    int x = 1;
                    int current_Count =Count_OF_PrimeFactorOfN(m); 
                    if(current_Count>=maxcount)
                    {
                        maxcount = current_Count;
                        result = m;
                    }
                m++;
            }
            Console.WriteLine(result.ToString() + " has factor " + maxcount.ToString());
     }
        #endregion
        #region 21. Check if N is represented By Product of Two Prime NUmber
        public static bool N_Is_RepresentedBy_Product_Two_Prime_Number(int n)
        {
            bool check = false;
            int r = 0;
            int i = 3;
            if(2*2==n)
            {
                check = true;
                return check;
            }
            while(i<=(n/2))
            {
                if(PrimeOrNot(i))
                {
                    if (n % i == 0)
                    {
                        r = n / i;
                        if (PrimeOrNot(r))
                        {
                            check = true;
                            break;
                        }
                    }
                }
                
                i = i + 2;
            }
            return check;
        }
        #endregion
        #region 22. Check if the number N can be represented as the product of two distinct/unique prime numbers
        public static bool N_Can_Be_Represented_By_Unique_PRime(int n)
        {
            bool check = false;
            int r = 0;
            int i = 3;
            while (i <= (n / 2))
            {
                r = 0;
                if (PrimeOrNot(i))
                {
                    if (n % i == 0)
                    {
                        r = n / i;
                        if (r!=i & PrimeOrNot(r))
                        {
                            check = true;
                            break;
                        }
                    }
                }

                i = i + 2;
            }
            return check;

        }
        #endregion
        #region 23. Represent The Given Number as a Product of PRime Number
        public static void ProductOfPRimeNumber(int n)
        {
            int i = 3;
            int r = 0;
            PrintMessage(string.Format("PRoduct of Prime Number for {0} is", n));
            bool check = false;
            if(n==4)
            {
                PrintMessage(string.Format("{0} * {1} ",2,2));
                return;
            }
            while (i<=(n/2))
            {
                if(PrimeOrNot(i))
                {
                    if (n % i == 0)
                    {
                        r = n / i;
                        if(PrimeOrNot(r))
                        {
                            PrintMessage(string.Format("{0} * {1} ", i, r));
                            check = true;
                        }
                    }
                }
                i = i + 2;
            }
            if(check==false)
            {
                Console.WriteLine("Sorry We Cant Represent This Number Product of Two Prime Number");
            }
        }
        #endregion
        #region 24. Largest Prime Number Between M and N
        public static int LargestPrimeNumber(int m ,int n)
        {
            
            int Large = 0; 
            if (m > n)
            {
                int temp = n;
                n = m;
                m = temp;
            } 
            Large = PreviousPrime(n);
            //if (m<=2)
            //{
            //    Large = 2;
            //}
            //m = Check_M_Even(m);
            //while(m<=n)
            //{
            //    if(PrimeOrNot(m))
            //    {
            //        if(Large<=m)
            //        {
            //            Large = m;
            //        }
            //    }
            //    m = m + 2;
            //}
            return Large;

        }
        #endregion
        #region 25. Smallest Prime Number Between M and N
        public static int SmallestPrimeNumber(int m, int n)
        {

            int small = 0;
            if (m > n)
            {
                int temp = n;
                n = m;
                m = temp;
            }
            if (m <= 2)
            {
                small = 2;
                return small;
            }
            small = NextPrime(m);
            //if (m<=2)
            //{
            //    small = 2;
            //}
            //m = Check_M_Even(m);
            //while(m<=n)
            //{
            //    if(PrimeOrNot(m))
            //    {
            //        if(small>=m)
            //        {
            //            small = m;
            //        }
            //    }
            //    m = m + 2;
            //}
            return small;

        }
        #endregion
    }
}
