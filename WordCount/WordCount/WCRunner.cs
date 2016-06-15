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
			string file;

			try {
				using  (StreamReader sr = new StreamReader(wcr.getFilePath())) {
					file = sr.ReadToEnd();
					wc.setWordsArray (file);
					wc.CountWords (wc.getWordsArray ());

					foreach (string key in wc.WordList.Keys) {
						Console.WriteLine ("The word '{0}' appears {1} times, which {2} a prime number.", key, wc.WordList [key], pn.PrimeCheck (wc.WordList [key]) ? "is" : "is not");
					}

				} 
			} catch (Exception e) {
					Console.WriteLine("This file cannot be read.");
					Console.WriteLine(e.Message);
			}

		}

		private string filePath;

		public WCRunner(string filepath = "/home/jeremy/Dropbox/Github/CTM-tech-test/TestText.txt") {
			filePath = filepath;
		}

		public string getFilePath() {
			return filePath;
		}

		public void setFilePath(string fp) {
			filePath = fp;
		} 
	}
}
