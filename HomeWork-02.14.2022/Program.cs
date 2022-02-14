using System;

namespace HomeWork_02._14._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1 
            //int num = Convert.ToInt32(Console.ReadLine());
            //int divide = 0;
            //int sum = 0;

            //if (num % 7 == 0)
            //{
            //    Console.WriteLine("7 ye bolunur");
            //}
            //else
            //{
            //    divide = num / 7;
            //    sum = divide * 7;

            //}
            //Console.WriteLine(sum);

            //2-ci helli

            //int num = Convert.ToInt32(Console.ReadLine());
            //int divide = num / 7;
            //int sum = divide * 7;
            //if (num % 7 == 0)
            //{
            //    Console.WriteLine("7-ye bolunur");
            //}
            //else
            //{
            //    for (int i = num; i < num + 6; i++)
            //    {
            //        while (num % 7 == 0)
            //        {
            //            divide = num / 7;
            //            sum = divide * 7;
            //        }

            //    }
            //    Console.WriteLine(sum);
            //}

            #endregion

            #region task2
            //Console.WriteLine("Reqem daxil edin");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Operator daxil edin");
            //string ope = Console.ReadLine();
            //Console.WriteLine("Reqem daxil edin");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int sum=1;
            //if (ope=="*")
            //{
            //    sum = num1 * num2;
            //    Console.WriteLine(sum);
            //}else if (ope =="/")
            //{
            //    sum=num1 / num2;
            //    Console.WriteLine(sum);
            //}
            //else if (ope == "+")
            //{
            //    sum = num1 + num2;
            //    Console.WriteLine(sum);
            //}
            //else if (ope == "-")
            //{
            //    sum = num1 - num2;
            //    Console.WriteLine(sum);
            //}

            #endregion

            #region Method task1
            CheckNumberinDivide();
            #endregion

            #region Method task2
            //MathProcess();
            #endregion
        }

        #region Medhod task1

        public static void CheckNumberinDivide()
        {
            int num =Convert.ToInt32(Console.ReadLine());
            int x = num % 7;
            if (num % 7 == 0)
            {
                Console.WriteLine("7-ye bolunur");
            }
            else
            {
                while (x>=4)
                {
                    if (num%7==0)
                    {
                        Console.WriteLine(num);
                        break;
                    }
                    num++;
                } while (x<4)
                {
                    if (num%7==0)
                    {
                        Console.WriteLine(num);
                        break;
                    }
                    num--;
                }
            }
        }

        #endregion

        #region Methos task2

        //public static void MathProcess()
        //{
        //    Console.WriteLine("Bir eded daxil edin");
        //    int num1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Bir operator daxil edin");
        //    string ope = Console.ReadLine();
        //    Console.WriteLine("Bir eded daxil edin");
        //    int num2=Convert.ToInt32(Console.ReadLine());
        //    if (ope=="*")
        //    {
        //        Console.WriteLine(num1*num2);
        //    }
        //    else if (ope == "/")
        //    {
        //        Console.WriteLine(num1 / num2);
        //    }
        //    else if (ope == "+")
        //    {
        //        Console.WriteLine(num1 + num2);
        //    }
        //    else if (ope == "-")
        //    {
        //        Console.WriteLine(num1 - num2);
        //    }

        //}

        #endregion
    }
}
