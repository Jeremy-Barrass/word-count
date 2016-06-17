using System;
using System.IO;
using WordCountLibrary;
using WordCountTest;
using PrimeNumber;
using PrimeNumberTest;

namespace WordCount
{
	class WCRunner
	{
		public static void Main (string[] args)
		{
			WCRunner wcr = new WCRunner ();
			WordCounter wc = new WordCounter();
			PrimeNum pn = new PrimeNum ();

			wcr.LoadFile ();
			wcr.ProcessFile (wcr.GetFile (), wc, pn);

		}

		private string filePath;
		private string file;

		public WCRunner(string filepath = "/home/jeremy/Dropbox/Github/CTM-tech-test/TestText.txt") {
			filePath = filepath;
		}

		public string getFilePath() {
			return filePath;
		}

		public void setFilePath(string fp) {
			filePath = fp;
		}

		private void SetFile(string f) {
			file = f;
		}

		public string GetFile() {
			return file;
		}

		public void LoadFile() {
			try {
				using  (StreamReader sr = new StreamReader(filePath)) {
					SetFile(sr.ReadToEnd());
				} 
			} catch (Exception e) {
				Console.WriteLine("This file cannot be read.");
				Console.WriteLine(e.Message);
			}
		}

		public void ProcessFile(string f, WordCounter wc, PrimeNum pn) {
			wc.SetWordsSearchList (f);
			wc.CountWords (wc.GetWordsSearchList ());

			foreach (string key in wc.WordList.Keys) {
				Console.WriteLine ("The word '{0}' appears {1} times, which {2} a prime number.", key, wc.WordList [key], pn.PrimeCheck (wc.WordList [key]) ? "is" : "is not");
			}
		}
	}
}
