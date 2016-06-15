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
		public void ThePrimeCheckMethodReturnsABoolean(){
			Assert.That (pn.PrimeCheck (7), Is.True);
		}
	}
}

