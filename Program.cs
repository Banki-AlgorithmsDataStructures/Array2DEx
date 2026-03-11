/*
 Array2DEx - 2D Array Operations
 Write a C# program that performs the following tasks:
 
 - Create and populate a 2D array with random numbers [1,10]
 - Display the array in tabular format
 - Calculate and display the sum of all array elements
 - Calculate and display the sum of each row individually
 - Normalize the array values to the [0,1] interval and display results
 
 */
namespace Array2DEx
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Declare a 2D array with 3 rows and 4 columns
			int[,] a = new int[3, 4];
			
			// Create a Random object for generating random numbers
			Random rnd = new Random();
			
			// Populate the 2D array with random integers and display them in tabular format
			// Outer loop iterates through rows (i = 0 to 2)
			for (int i = 0; i < a.GetLength(0); i++)
			{
				// Inner loop iterates through columns (j = 0 to 3)
				for (int j = 0; j < a.GetLength(1); j++)
				{
					// Generate a random number between 10 (inclusive) and 100 (exclusive)
					a[i, j] = rnd.Next(10, 100);
					
					// Display the current element with tab spacing for alignment
					Console.Write(a[i, j] + "\t");
				}
				// Move to the next line after completing a row
				Console.WriteLine();
			}

			// Initialize min and max with the first element of the array
			int min = a[0, 0];
			int max = a[0, 0];
			
			// Find the minimum and maximum values in the entire 2D array
			// Iterate through all rows
			for (int i = 0; i < a.GetLength(0); i++)
				// Iterate through all columns
				for (int j = 0; j < a.GetLength(1); j++)
				{
					// Check if current element is smaller than current minimum
					if (a[i,j]<min)
						min = a[i,j];
					else
						// Check if current element is larger than current maximum
						if(a[i,j]>max)
							max = a[i,j];
				}
			
			// Display the minimum and maximum values found
			Console.WriteLine($"min={min}\tmax={max}");
			
			// Create a new 2D double array with the same dimensions as array 'a'
			// This will store the normalized values
			double[,] b = 
				new double[a.GetLength(0), a.GetLength(1)];
			
			// Normalize all values in the array to the range [0,1]
			// Iterate through all rows
			for (int i = 0; i < a.GetLength(0); i++)
			{
				// Iterate through all columns
				for (int j = 0; j < a.GetLength(1); j++)
				{
					// Normalization formula: (value - min) / (max - min)
					// Multiply by 1.0 to ensure floating-point division
					b[i, j] = (a[i,j]-min)*1.0/(max-min);
					
					// Display the normalized value with tab spacing for alignment
					Console.Write(b[i, j] + "\t");
				}
				// Move to the next line after completing a row
				Console.WriteLine();
			}
		}
	}
}
