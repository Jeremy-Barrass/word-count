using System;
using WordCountLibrary;
using WordCountTest;

namespace WordCount
{
	class WCRunner
	{
		public static void Main (string[] args)
		{
			WordCounter wc = new WordCounter();

			WCTest wctest = new WCTest ();

			wctest.BeforeEach ();

			wctest.ItHasAList ();

//			wctest.wordMaker ();

			wctest.ItCountsWords ();

			wctest.ItAddsWordsToTheList ();
		}
	}
}
