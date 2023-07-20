using System;
namespace ClassWorkInheritanceEncapsulationAccessMod.Models
{
	internal class Cat
	{
		public int age;

		public Cat()
		{

		}

		public void Test1()
		{
			Console.WriteLine("test1");
			Test2();
		}

		private void Test2()
		{
			Console.WriteLine("Test2");
		}
	}
}

