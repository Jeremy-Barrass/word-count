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
			wc.SetWordsArray (testWords);
		}
			
	 	[Test]
		public void ItHasAList ()
		{
			Assert.That (wc.WordList, Is.InstanceOf (typeof(Dictionary<string,int>)));
		}

		[Test]
		public void ItCountsWords() {
			wc.CountWords(wc.GetWordsArray());
			Assert.That (wc.WordList ["the"], Is.EqualTo (2));
		}

		[Test]
		public void ItAddsWordsToTheList() {
			wc.CountWords(wc.GetWordsArray());
			Assert.That (wc.WordList.Count, Is.GreaterThan (0));
		}

		[Test]
		public void ItRemovesPunctuation() {
			testWords = "Hello.  I am Don-Juan!!  What, may I ask,  is your name?";
			wc.SetWordsArray (testWords);
			wc.CountWords (wc.GetWordsArray());
			Assert.That (wc.WordList.ContainsKey ("donjuan"));
		}

		[Test]
		public void ItRemovesCarriageReturns() {
			testWords = "Hello.\nMy name\nis...";
			wc.SetWordsArray (testWords);
			wc.CountWords (wc.GetWordsArray ());
			foreach (string key in wc.WordList.Keys) {
				Console.WriteLine (key);
			}
			Assert.That (!wc.WordList.ContainsKey ("hello.\nmy"));
			Assert.That (!wc.WordList.ContainsKey ("name\nis"));
		}

		[Test]
		public void ItDeletesWordsFromTheWordsArrayAsItCountsThem() {
			wc.CountWords (wc.GetWordsArray ());
			Assert.That(wc.GetWordsArray().GetLength(0), Is.EqualTo(0));
		}
	}
}

