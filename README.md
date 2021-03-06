
# Word Counter in C-Sharp
#### (Forgot how markdown works for a moment there.)

## Initial Design Ideas

In keeping with SOLID principles, I test drove the word counter and the prime number checker and made sure both classes are in separate libraries.

I considered putting the Dictionary to hold the counted words in its own data-only class file, but decided against it in favour of a minor saving in test time.

I briefly wondered if it was worth setting up a web socket to get files with, but this wasn't in the spec, so I haven't.  Having set up a stream reader for reading local files, however, I suspect this would not be difficult to do.

## Current Working App (17/06/16)

The response time is much improved now that reducing the size of the Search List as it searches has been implemented.  I would be happy to submit this as a final version, however, I will continue to work on test driving the refactoring of WCRunner until 17:00.

##### 16:57 update
Unfortunately, WCRunner.cs had a protected status in the solution, which I meant I could not test it effectively - not without extracting everything to a whole new library.  Time was pressing so I elected to refactor without testing and checked it via a manual run instead, which was successful.

## Final thoughts

This was an interesting challenge and has taught me a lot about how the C-Sharp language works.  It is a shame I did not get the opportunity to run mocks or stubs in my testing, which test driving the refactor of my main class runner would have given me.  I expect there will ample opportunity to learn more about stubbing and mocking in Nunit on the job, however - should I receive an offer.

### Previous iteration(16/06/16)

It's response time is very slow.  I'm wondering if I could change things to improve it.  There are parts of the word counter which need refactoring and I would like to add some additional parsing logic to get rid of carriage returns and punctuation in the text, which annoy me and look sloppy.  They would also stop so many 'words' appearing once and there might even be a few that get pushed into double digits as a result.

## Additional Solutions

Other ways to solve this include storing the words and their counts in multi-dimensional arrays, or using a List<string> instead of a Dictionary.  However, Dictionary is arguably the most efficient way that I can think of to store the relevant information.

### Improvements in progress

While I have a Minimum Viable Product for spec purposes, there's a lot that could be done to improve it.  In addition to the improvements mentioned above, there is currently an array which holds the text, which the program checks through with each word before adding that word to a Dictionary as "word => word's count".  Removing each word from the array after it's counted (seeing as the Dictionary only allows a key to appear once, and the count value is established with the first appearance of the word) may speed up the program, since the check for each successive word will become incrementally faster.

I would like to move the try-catch block out of main into its own file loader class, and possibly extract the other code that runs the word counter and prime number check from Main method in the WCRunner class to a Go method which Main can run.  The principle issue here will be maintaining the current decoupling of my objects, which should be achievable with appropriately written interfaces within the Go method.

I'm also wondering about adding a callback method, similar to how they work in Javascript, to the try block.  I'm not sure if C-Sharp supports this, but if so it would allow me to move the code that interacts with the loaded file into a seperate method from the try block, improving separation of concerns.

It would also be nice to enable the Console output to be dynamically loaded as the Dictionary is updated, rather than waiting for the whole process to run before receiving the output.  I am presently investigating how this might be achieved.

Please see the Improvements branch of this repo for my progress with these ideas.
