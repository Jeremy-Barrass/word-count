using System;
using NUnit.Framework;
using WordCountLibrary;
using System.Collections.Generic;

namespace WordCountTest
{
	[TestFixture]
	public class WCTest
	{
		WordCounter wc = new WordCounter();

		public void ItHasAList ()
		{
			Assert.That (wc.WordList, Is.InstanceOf (typeof(Dictionary<string,int>)));
		}
	}
}

