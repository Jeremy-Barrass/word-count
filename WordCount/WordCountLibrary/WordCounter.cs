﻿using System;
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
		private List<string> wordsSearchList;
		private Dictionary<string,int> wordList;

		public WordCounter ()
		{
			wordList = new Dictionary<string,int> ();
			wordsSearchList = new List<string>();
		}

		public void SetWordsSearchList(string words) {
			words = RemoveCarriageReturns (words);
			words = RemovePunctuation (words);
			char delimiter = ' ';
			wordsSearchList.AddRange(words.ToLower().Split (delimiter));
		}

		public List<string> GetWordsSearchList() {
			return wordsSearchList;
		}

		public Dictionary<string,int> WordList {
			get {return wordList;}
		}

		public void CountWords(List<string> wordsSearchList) {
			foreach(string word in wordsSearchList) {
				wordList[word] = Count(word);
			}
		}

		private int Count(string w) {
			int count = 0;
			foreach (string word in wordsSearchList) {
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

