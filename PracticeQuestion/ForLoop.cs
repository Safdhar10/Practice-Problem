using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4_For_loop_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Print N numbers
        //    print_n_numbers();
            #endregion
            #region 2. Print M to N numbers
           // print_m_to_n_number();
            #endregion
            #region 3. Print Even upt N 
           // even_number_upto_n();
            #endregion
            #region 4. Print Even upt N
            //odd_number_upto_n();
            #endregion
            #region 5. Print All Even number from M upto N(M<N)
          //  even_number_from_M_to_N();
            #endregion
            #region 6. Print All Even number from M upto N(M<N)
           // odd_number_from_M_to_N();
            #endregion
            #region 7. Print Numbers between 1 and 100 divisible by N
         //   num_between_1and100_divbyN();
            #endregion
            #region 8. Multiplication
           // Multiplication(10);
            #endregion
            Multiplication_upto_5();
        }
        
        #region common methods
            public static void Printmessage(String message)
        {
            Console.WriteLine(message);
        }
        public static int Getint(String message)
        {
            Printmessage(message);
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
        public static double Getdouble(String message)
        {
            Printmessage(message);
            double input = Convert.ToDouble(Console.ReadLine());
            return input;
        }
        public static string Getstring(String message)
        {
            Printmessage(message);
            String input = Console.ReadLine();
            return input;
        }
            #endregion
        #region 1. Print N number
        public static void print_n_numbers()
        {
            int n = Getint("Enter N value");
            //for (int i = 0; i <= n; i++)
            //{
            //    Printmessage(string.Format("\n{0}", i));
            //}
            int i=n;
            while(n!=0)
            {
                Printmessage(string.Format("\n{0}",(i-n)));
                n--;
            }
        }
        #endregion
        #region 2. Print M to N numbers
        public static void print_m_to_n_number()
        {
            try
            {
                int m = Getint("Enter From value");
                int n = Getint("Enter To value");
                for (int i = m; i < n; i++)
                {
                    Printmessage(string.Format("\n{0}", i));
                }
            }
            catch (FormatException ex)
            {
                Printmessage(string.Format("{0}", ex.Message));
                print_m_to_n_number();
            }

        }
        #endregion
        #region 3. Even Number Upto N
        public static void even_number_upto_n()
        {
            int n = Getint("Enter N value");
            for (int i = 2; i <=n; i=i+2)
            {
                Printmessage(string.Format("Even Number are {0}\n",i));
            }
        }
        #endregion
        #region 4. Odd Number Upto N
        public static void odd_number_upto_n()
        {
            int n = Getint("Enter N value");
            for (int i = 1; i <=n; i=i+2)
            {
                Printmessage(string.Format("Odd Number are {0}\n", i));
            }
        }
        #endregion
        #region 5. Print All Even number from M upto N(M<N)
        public static void even_number_from_M_to_N()
        {
            int m = Getint("Enter M value");
            int n = Getint("Enter N value");
            for (int i = m; i <= n; i = i + 2)
            {
                Printmessage(string.Format("Even Number are {0}\n", i));
            }
        }
        #endregion
        #region 6. Print All Odd number from M upto N(M<N)
        public static void odd_number_from_M_to_N()
        {
            int m = Getint("Enter M value");
            int n = Getint("Enter N value");
            for (int i = m; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Printmessage(string.Format("Odd Number are {0}\n", i));
                }
            }
        }
        #endregion
        #region 7. Print Numbers Between 1 and 100 Divisible By N
        public static void num_between_1and100_divbyN()
        {
            int Division_Number = Getint("Enter the Divison Value");
            for (int i = 1; i <= 100; i++)
            {
                if(i%Division_Number==0)
                {
                    Printmessage(string.Format("Divisible Numbers Between 1 and 100 are: {0}\t", i));
                }
            }
        }
        #endregion
        #region 8. Multiplication Table 
        public static void Multiplication(int n)
        {
            //int i=1;
            //while (i <= n)
            //{
            //     i++;
            //}
            for (int i = 1; i < n; i++)
            {
                Printmessage(string.Format("{0} * {1} = {2}", i, n, i * n));
            }
        }
        #endregion
        #region Multiplication Upto 5(
        public static void Multiplication_upto_5()
        {
            int num = 0;
            int rows=1;
            while ( num++ < 5)
            {
                rows = 1;
                while (rows <= 20 )
                {
                    Printmessage(string.Format("{0} * {1} = {2}", rows,num,rows*num));
                    rows++;
                }
            }
        }
        #endregion

    }
}
