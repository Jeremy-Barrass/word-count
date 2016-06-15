using System;
using NUnit.Framework;
using PrimeNumber;

namespace PrimeNumberTest
{
	[TestFixture]
	public class PrimeNumTest
	{
		PrimeNum pn;

		[SetUp]
		public void BeforeEach() {
			pn = new PrimeNum();
		}

		[Test]
		public void ThePrimeCheckMethodReturnsTrueWhenTheNumberIsPrime(){
			Assert.That (pn.PrimeCheck (7), Is.True);
		}

		[Test]
		public void ThePrimeCheckMethodReturnsFalseWhenTheNumberIsNotPrime() {
			Assert.That (pn.PrimeCheck (9), Is.False);
		}
	}
}

