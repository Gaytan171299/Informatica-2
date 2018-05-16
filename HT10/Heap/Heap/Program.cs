using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
	public class Program
	{
		public static int Heap;
			
		static void Main(string[] args)
		{
		}

		public static int[] HeapSort(int[] arr) {
			int n = arr.Length;

			
			for (int i = n / 2 - 1; i >= 0; i--)
				ShiftDown(arr, n, i);

			for (int i = n - 1; i >= 0; i--)
			{
				int temp = arr[0];
				arr[0] = arr[i];
				arr[i] = temp;

				ShiftDown(arr, i, 0);
			}
			return arr;
		}

		public static void ShiftDown(int[] arr, int n, int i)
		{

			int largest = i;
			int l = 2 * i + 1;
			int r = 2 * i + 2;

			if (l < n && arr[l] > arr[largest])
				largest = l;

			if (r < n && arr[r] > arr[largest])
				largest = r;

			if (largest != i)
			{
				int swap = arr[i];
				arr[i] = arr[largest];
				arr[largest] = swap;

				ShiftDown(arr, n, largest);
			}

		}

		private static int floop(int currentIndex)
		{
			return (currentIndex - 1)/ 2;
		}

		private static int Izquierdo(int currentIndex)
		{
			return currentIndex * 2 + 2;
		}

		private static int Derecho(int currentIndex)
		{
			return currentIndex * 2 + 1;
		}

	}
}
