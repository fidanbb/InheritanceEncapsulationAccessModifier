using System;
namespace ClassWorkInheritanceEncapsulationAccessMod.Models
{
	public class Car
	{
		public string  Name { get; set; }

		protected string color;

		private int _speed;

		public int Speed
		{
			get
			{
				if (_speed > 300)
				{
					return _speed;
				}
				return -1;

			} set

			{
				_speed = value;

			}
		}
	}
}

