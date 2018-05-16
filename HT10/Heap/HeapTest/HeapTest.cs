using Heap;
using System;
using Xunit;

namespace HeapTest
{
	public class HeapTest
	{
		[Fact]
		public void HeapSort() {
			int[] arr = new int[] { 30,2,0,12,5};

			Program.HeapSort(arr);

			Assert.Equal(new int[] { 0,2,5,12,30}, arr);
		}
	}
}
