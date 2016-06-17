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
			words = RemoveCarriageReturns (words);
			words = RemovePunctuation (words);
			char delimiter = ' ';
			wordsArray = words.ToLower().Split (delimiter);
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

		private string RemovePunctuation (string oldWords){
			string punct = "\\W[^\\s'A-Za-z0-9]|\\,|\\-|\\?|\\.";
			string replace = String.Empty;
			Regex rgx = new Regex (punct);
			string newWords = rgx.Replace (oldWords, replace);
			return newWords;
		}
	}
}

