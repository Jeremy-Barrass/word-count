using System;

namespace PrimeNumber
{
	public class PrimeNum
	{
		public bool PrimeCheck (int value)
		{
			bool isPrime = false;
			if (TestDivisors (value) < 3) {
				isPrime = true;
			}
			return isPrime;
		}

		private int TestDivisors(int num) {
			int count = 0;
			for (int x = 1; x <= num; x++) {
				if (num % x == 0) {
					count++;
				}
			}
			return count;
		}
	}
}

