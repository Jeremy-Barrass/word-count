
# Word Counter in C-Sharp
#### (Forgot how markdown works for a moment there.)

## Initial Design Ideas

In keeping with SOLID principles, I test drove the word counter and the prime number checker and made sure both classes are in separate libraries.

I considered putting the Dictionary to hold the counted words in its own data-only class file, but decided against it in favour of a minor saving in test time.

I briefly wondered if it was worth setting up a web socket to get files with, but this wasn't in the spec, so I haven't.  Having set up a stream reader for reading local files, however, I suspect this would not be difficult to do.

## Current Working App (16/06/16)

It's response time is very slow.  I'm wondering if I could change things to improve it.  There are parts of the word counter which need refactoring and I would like to add some additional parsing logic to get rid of carriage returns and punctuation in the text, which annoy me and look sloppy.  They would also stop so many 'words' appearing once and there might even be a few that get pushed into double digits as a result.

## Additional Solutions

Other ways to solve this include storing the words and their counts in multi-dimensional arrays, or using a List<string> instead of a Dictionary.  However, Dictionary is arguably the most efficient way that I can think of to store the relevant information.
