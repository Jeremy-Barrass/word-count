using System;
using WordCount;
using NUnit.Framework;

namespace WCRunnerTest
{
	[TestFixture]
	public class TestWCRunner
	{
		[SetUp]
		public void BeforeEach()
		{
			WCRunner wcr = new WCRunner();
		}
	}
}

