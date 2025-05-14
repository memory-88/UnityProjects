using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _04_25_CSharp
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            #region for foreach 차이
            //int[] arr = new int[5] { 1, 2, 3, 4, 5 };//1차원배열 :
            //int[,] arr2D = new int[4, 4];//2차원배열
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] += 2;
            //}
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = new int[100];
            //Random random = new Random(); //랜덤 클래스 동적 할당
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = random.Next(1, 100);
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"1에서 100사이 랜덤값 {i + 1}번째 출력 : {numbers[i]}");
            //}
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            #endregion

            //    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            //    for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 3 == 0) continue;
            //    Console.WriteLine(arr[i]);
            //}
            //for (int i = 2; i < 10; i++)
            //{
            //    if (i % 2 != 0)
            //        continue;
            //    for (int j = 1; j < 10; j++)
            //    {
            //        if (i < j) break;
            //        Console.WriteLine($"{i}×{j}={i * j}");
            //    }

            //int sum = 0;
            //int i = 0;
            //do
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //    i++;
            //} while (i <= 100);
            //Console.WriteLine($"짝수의합: {sum}");

            //Console.Write($"첫번째 정수를 입력하세요.");
            //int num1 = int.Parse(Console.ReadLine()!);
            //Console.Write($"두번째 정수를 입력하세요.");
            //int num2 = int.Parse(Console.ReadLine()!);
            //int start = (num1 < num2) ? num1 : num2;
            //int end = (num1 > num2) ? num1 : num2;
            //for (int i = start; i <= end; i++)
            //{
            //    Console.WriteLine($"\n{i}단");
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        Console.WriteLine($"{i}×{j}={i * j}");
            //    }
            //}

            //int money = 3500;
            //Console.WriteLine($"당신이 가지고 있는 돈 {money}원");
            //int bread = 500;
            //Console.WriteLine($"크림빵 {bread}원");
            //int snack = 700;
            //Console.WriteLine($"새우깡 {snack}원");
            //int coke = 400;
            //Console.WriteLine($"콜라 {coke}원");
            //int count = 0;
            //for (int b = 1; b <= money / bread; b++)
            //{
            //    for (int s = 1; s <= money / snack; s++)
            //    {
            //        for (int c = 1; c <= money / coke; c++)
            //        {
            //            int total = (b * bread) + (s * snack) + (c * coke);
            //            if (total == money)
            //            {
            //                Console.WriteLine($"크림빵:{b}개 새우깡:{s}개 콜라:{c}개");
            //                Console.WriteLine($"{++count}개 입니다.");
            //            }
            //        }
            //    }
            //}

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //int i = 1;
            //while (i <= 5)
            //{
            //    int j = 1;
            //    while (j <= i)
            //    {
            //        Console.Write("*");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}

            //int i = 5;
            //while (i >= 1)
            //{
            //    int j = 1;
            //    while (j <= i)
            //    {
            //        Console.Write("*");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i--;
            //}

            //int i = 1;
            //do
            //{
            //    int j = 1;
            //    do
            //    {
            //        Console.Write("*");
            //        j++;
            //    } while (j <= i);
            //    Console.WriteLine();
            //    i++;
            //} while (i <= 5);

            //int i = 5;
            //do
            //{
            //    int j = 1;
            //    do
            //    {
            //        Console.Write("*");
            //        j++;
            //    } while (j <= i);
            //    Console.WriteLine();
            //    i--;
            //} while (i >= 1);

            Console.Write($"반복 횟수를 입력하세요.");
            int input = int.Parse(Console.ReadLine()!);
            if (input < 0)
            {
                Console.WriteLine($"0보다 같거나 작은 숫자는 사용할 수 없습니다.");
            }
            else
            {
                for (int i = 1; i <= input; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                
            }






        }
    }
}

            

