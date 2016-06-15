using System;
using NUnit.Framework;
using WordCountLibrary;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Collections.Concurrent;

namespace WordCountTest
{
	[TestFixture]
	public class WCTest
	{
		WordCounter wc = new WordCounter();

	 	[Test]
		public void ItHasAList ()
		{
			Assert.That (wc.WordList, Is.InstanceOf (typeof(Dictionary<string,int>)));
		}
	}
}

