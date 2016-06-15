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
		private string[] wordsArray;
		private Dictionary<string,int> wordList;

		public WordCounter ()
		{
			wordList = new Dictionary<string,int> ();
		}

		public void setWordsArray(string words) {
			char delimiter = ' ';
			wordsArray = words.ToLower().Split (delimiter);
		}

		public string[] getWordsArray() {
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
					count += 1;
				}
			}
			return count;
		}
	}
}

