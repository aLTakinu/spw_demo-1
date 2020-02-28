using System;

namespace FibonacciSeries {
  class Program {
    static void Main(string[] args) {
      int[] fibonacci = CreateFibonacciSeries(10);

      for (int i = 0; i < fibonacci.Length; i++) {
        Console.Out.Write(fibonacci[i]);
        Console.Out.Write(" ");
      }
      Console.Out.WriteLine();
    }
	// aLTakinu added some comment to Milenas code
    static int CreateFibonacciNumber(int index) {
      if (index == 0) return 0;
      if (index == 1) return 1;
      return CreateFibonacciNumber(index - 1) + CreateFibonacciNumber(index - 2);
    }

    static int[] CreateFibonacciSeries(int count) {
      int[] fibonacciSeries = new int[count];
      for (int j = 0; j < count; j++)
        fibonacciSeries[j] = CreateFibonacciNumber(j);
      return fibonacciSeries;
    }
  }
}
