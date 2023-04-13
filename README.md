<div dir='rtl' align="center">
In the name of the Lord who guides to the right path

   University of Esfahan

   Data Building - Dr. Ramezani

   Autumn 01-02

   The fourth project - search engine


<img src="https://s24.picofile.com/file/8456084100/Picture44.png" width="500"/>
  
   Project designers: Amir Ali Goli - Mohammad Hossein Dehghani - Mohammad Tawakli
</div>

<div dir='ltr' align="justify">
  
### Topic: Tree
Project goals:
+ Work with the tree data structure
+ Familiarity with search engines and how they work



In this project, you are going to simulate a search engine using the tree data structure.

## Project steps
### step one:
In the first step, clone the project from the repository to have it in your system.
### Second step:
We have document files that contain English words.
https://star-academy.github.io/codestar-documents/assets/files/the-20-newsgroups-b28960092a8cf8e833bba736d4f3d433.zip

Read and edit the given documents in such a way that there are no punctuation marks and the words are separated by spaces. (The space character separates all words.)


### The third step:
   See the tree below.
  
<img src="https://s24.picofile.com/file/8456084134/Picture45.png" width="500"/>

In fact, in this tree, we spread the letters of the words of the given text on the edges in such a way that by scrolling from the root of the tree to the leaves, upon reaching each leaf, the set of letters that are scrolled is one of the words in the text. There is. Using this method to find a word of length m in a text of length n instead of the time complexity of the order of O(n), our time order will be equal to O(m).
Also, in each sheet, there is a list of the names of the documents in which the word in the sheet was, so that we can access the names of the documents when navigating the tree to search for the word.
Your program should generate a single tree similar to the one above for all given text that supports the following operations:

- Checking the presence or absence of a word in the given texts
- Search for a word and determine the name of the documents containing that word (that is, enter the desired word in the console or search box and the number of all the documents that contain that word will be output.)
- Support for conditional expressions:
For example, we need to find documents that must include the terms get and help, as well as at least one of the terms illness and disease and do not include the term cough.

get help +illness +disease -cough

- Note that you do not have the right to use hashMap and the like for this project.
- Note that your search operation must be done using a built tree.
- Please note that you must implement the tree data structure yourself and you do not have the right to use ready-made trees. Also, your tree should have add, delete, update node search operations.

### Fourth step:
  Finally, he designed a user interface (console or graphic) that receives an input string of words to be searched and gives the desired answers. (The desired answers are actually a list of document names containing words.)



### Bonus section:
• If there is no word in all the texts, show the similar words with a difference (change in letters, decrease and increase in the number of letters) and then search.


## Additional points:
+ This project must be implemented by a single person.
+ The project implementation platform is on GitHub.
+ Try to do each part in a separate commit.
+ Compliance with the principles of clean coding takes a large part of the grade and if the code is completely implemented in an unprincipled way. It will not be delivered.
+ The use of any language, framework and graphical interfaces is completely free.
+ People who use new technologies will be given an additional renewal token.




</div>
