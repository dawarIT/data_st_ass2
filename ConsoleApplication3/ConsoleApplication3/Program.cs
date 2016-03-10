using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {  
                                int rowa,columa;
                                Console.Write("Enter the no. of Rows: ");
                                rowa = int.Parse(Console.ReadLine());
                                Console.Write("\nEnter the no. of columns: ");
                                columa = int.Parse(Console.ReadLine());
                                float[,] a = new float[rowa + 1, columa + 1];                    
                                Program.createarray(a,rowa,columa);

                                for (int i = 1; i <=rowa ; i++)
                                {
                                    for (int j=1; j<=columa; j++)
                                    {
                                        Console.Write(a[i,j]+"\t");

                                    }
                                    Console.WriteLine();
                                }

                                Program ob = new Program();
                                float x = ob.determinant(a, rowa, columa);
                                Console.WriteLine("determinant is: "+x);
                                Program.transpose(a, rowa, columa);
                                Console.WriteLine();
                                Program.transpose(a, rowa, columa);
                                Console.WriteLine();                    
            Program.transpose(a, rowa, columa);
            Console.WriteLine();                    
            Program.transpose(a, rowa, columa);


            Console.ReadLine();

        }

        public static void transpose(float[,]a,int r,int c)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <=c; j++)
                {
                    Console.Write(a[j,i]+"\t");
                }
                Console.WriteLine();
            }


        }

        public static float[,] createarray(float[,] a, int rows, int columns)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    Console.Write("\nenter the element at A[{0},{1}]",i,j);
                    a[i, j] = float.Parse(Console.ReadLine()); 
                }
                Console.WriteLine();
            }

            return a;
        } //end of method......
    

        public float determinant(float[,]a,int rowa,int colmuna)
        {
            int counter = 0;
            int n = rowa;
            float temp = 0;
            float det = 0;
            int p = 2, q = 1, r =1, x = 1;
            l1:
            for (int k = r; k <=rowa; k++)
            {
                a[x, k] = a[x, k] / a[x, x]; 

            }
            for (int i = p; i <=rowa ; i++)
            {
                counter++;
                temp = a[x, p];
                
                for (int j = q; j <=colmuna; j++)
                {
                    a[j, i] = a[j, i] - (a[j, x] * temp);
                }
                p++;
            }
            //for (int i = 1; i < counter; i++)
            //{
            //    p--;
            //}
            if (n>3)
            {
                p++; q++; r++; x++;
                n--;
                goto l1;
            }
            Program.display(a, rowa, colmuna);

            det=(a[rowa-1,colmuna-1]*a[rowa,colmuna])-(a[rowa-1,colmuna]*a[rowa,colmuna-1]);

            return det;
        
        } //end of method.....


        public static void display(float[,] a, int rows, int columns)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("==========matrix {0}==========");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    Console.Write(a[i, j] + "\t");

                }
                Console.WriteLine();

            }

        }
       
















    }
}
