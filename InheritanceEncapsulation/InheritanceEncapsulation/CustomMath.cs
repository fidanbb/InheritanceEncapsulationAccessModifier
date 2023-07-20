using System;
namespace InheritanceEncapsulation
{
	internal class CustomMath
	{
		public int GetSumOfOddArrayEls(int[] nums)
		{
			int sum = 0;

			foreach (var num in nums)
			{
				if (num%2==1)
				{
                    sum += num;
                }
			}

			return sum;

		}



		public bool IsEven(int num)
		{
			if (num%2==0)
			{
				return true;
			}
			return false;
		}


		public int GetSquareOfSumOfArrayEls(int[] nums)
		{
            int sum = 0;

			int result;

            foreach (var num in nums)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
			result = sum * sum;

			return result;
			
        }


		public int GetProduct(int n)
		{
			int product = 1;

			for (int i = 1; i < n; i++)
			{
				product *= i;
			}

			return product;
		}


	}
}

