using System;

namespace UserInput
{
    class Program
    {
		public static void Main(string[] args)
		{
			float Length;
			float Width;
			float Area;
			float Perimenter;
			
			Console.Write("Enter the width of the rectangle ");
			Width = float.Parse(Console.ReadLine());
			Console.Write("Enter the lenght of the rectangle ");
			Length = float.Parse(Console.ReadLine());
			Area = Width * Length;
			Perimenter = Width * 2 + Length * 2;
			Console.WriteLine("The area of the square is " + Area);
			Console.WriteLine("The perimenter of the square is " + Perimenter);

		}
	}
}
