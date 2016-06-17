using System;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Collections.Concurrent;

namespace WordCountLibrary
{
	public class WordCounter
	{
		private string[] wordsArray;
		private Dictionary<string,int> wordList;

		public WordCounter ()
		{
			wordList = new Dictionary<string,int> ();
		}

		public void SetWordsArray(string words) {
			string newWords = RemoveCarriageReturns (words);
			char delimiter = ' ';
			wordsArray = newWords.ToLower().Split (delimiter);
			wordsArray = RemovePunctuation (wordsArray);
		}

		public string[] GetWordsArray() {
			return wordsArray;
		}

		public Dictionary<string,int> WordList {
			get {return wordList;}
		}

		public void CountWords(string[] wordsArray) {
			foreach(string word in wordsArray) {
				wordList[word] = Count(word);
			}
		}

		private int Count(string w) {
			int count = 0;
			foreach (string word in wordsArray) {
				if (w == word) {
					count ++;
				}
			}
			return count;
		}

		private string RemoveCarriageReturns (string oldWords) {
			string cr = "\\r|\\n";
			string replace = " ";
			Regex rgx = new Regex (cr);
			string newWords = rgx.Replace (oldWords, replace);
			return newWords;
		}

		private string[] RemovePunctuation (string[] wAry){
			string punct = "\\b\\.|\\b\\W+";
			string replace = String.Empty;
			Regex rgx = new Regex (punct);
			foreach (string word in wAry) {
				Console.WriteLine ("Before: {0}", word); 
				rgx.Replace (word, replace);
				Console.WriteLine ("After: {0}", word); 
			}
			return wAry;
		}
	}
}

