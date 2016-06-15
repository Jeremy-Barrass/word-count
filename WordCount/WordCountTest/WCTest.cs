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
		WordCounter wc;
		string testWords;

		[SetUp]
		public void BeforeEach() {
			wc = new WordCounter();
			testWords = "The quick brown fox jumps over the lazy dog.";
		}
			
	 	[Test]
		public void ItHasAList ()
		{
			Assert.That (wc.WordList, Is.InstanceOf (typeof(Dictionary<string,int>)));
		}

		[Test]
		public void ItCountsWords() {
			wc.Count (testWords);
			Assert.That (wc.WordList ["The"], Is.EqualTo (2));
		}

		[Test]
		public void ItAddsWordsToTheList() {
			wc.Count (testWords);
			Assert.That (wc.WordList.Count, Is.GreaterThan (0));
		}
	}
}

