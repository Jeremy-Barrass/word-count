using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Collections.Concurrent;

namespace WordCountLibrary
{
	public class WordCounter
	{
		private Dictionary<string,int> wordList;

		public WordCounter ()
		{
			wordList = new Dictionary<string,int> ();
		}

		public Dictionary<string,int> WordList {
			get {return wordList;}
		}

		public void Count(string words) {
			
		}
	}
}

