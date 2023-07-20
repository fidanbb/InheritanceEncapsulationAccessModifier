using System;
namespace ClassWorkInheritanceEncapsulationAccessMod.Models
{
	internal class Animal
	{
		public int id;
		public string name;
		public string color;

		public Animal(string name )
		{
			this.name = name;
			
		}


		public void Eating()
		{
			Console.WriteLine($"{name} - eating");
		}
	}
}

