using System;
namespace InheritanceEncapsulation.Controllers
{
	internal class CustomMathController
	{
		public void GetSumOfOddArrayEls()
		{
            CustomMath customMath = new();

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = customMath.GetSumOfOddArrayEls(arr);

            Console.WriteLine($"Sum of odd numbers in array: {result}");
        }


        public void IsEven()
        {
            CustomMath customMath = new();

            Console.WriteLine("Add number: ");
            int num;
            Num:  bool isNumber = int.TryParse(Console.ReadLine(),out num);

            if (isNumber)
            {
                if (num<=0)
                {
                    Console.WriteLine($"{num} is not even or odd, add again");
                    goto Num;
                }

                else
                {
                    if (customMath.IsEven(num))
                    {
                        Console.WriteLine($"{num} is even number");
                    }
                    else
                    {
                        Console.WriteLine($"{num} is odd number");
                    }
                }


            }
            else
            {
                Console.WriteLine("Can not convert to number, add again: ");
                goto Num;
            }

        }



        public void GetSquareOfSumOfArrayEls()
        {
            CustomMath customMath = new();

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = customMath.GetSquareOfSumOfArrayEls(arr);

            Console.WriteLine(result);        

        }




        public void GetProduct()
        {
            CustomMath customMath = new();

            Console.WriteLine("Add number: ");
            int num;

        Num: bool isNumber = int.TryParse(Console.ReadLine(), out num);

            if (isNumber)
            {
                if (num<=0)
                {
                    Console.WriteLine("Wrong number, add again: ");
                    goto Num;
                }
                else
                {
                    var result = customMath.GetProduct(num);
                    Console.WriteLine(result);
                }
         
            }
            else
            {
                Console.WriteLine("Can not convert to number, add again: ");
                goto Num;
            }
        }


    }
}

