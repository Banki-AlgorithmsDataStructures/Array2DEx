namespace Array2DEx
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[,] a = new int[3, 4];
			Random rnd = new Random();
			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					a[i, j] = rnd.Next(10, 100);
					Console.Write(a[i, j] + "\t");
				}
				Console.WriteLine();
			}

			int min = a[0, 0];
			int max = a[0, 0];
			for (int i = 0; i < a.GetLength(0); i++)
				for (int j = 0; j < a.GetLength(1); j++)
				{
					if (a[i,j]<min)
						min = a[i,j];
					else
						if(a[i,j]>max)
							max = a[i,j];
				}
			Console.WriteLine($"min={min}\tmax={max}");
			double[,] b = 
				new double[a.GetLength(0), a.GetLength(1)];
			for (int i = 0; i < a.GetLength(0); i++)
				for (int j = 0; j < a.GetLength(1); j++)
					b[i, j] = (a[i,j]-min)*1.0/(max-min);


		}
	}
}
