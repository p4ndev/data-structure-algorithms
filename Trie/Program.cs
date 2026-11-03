/*
       ROOT
        |
        C
        |
        A
       / \
      R   T*
      |
      S*

* IsEndOfWord = true

*/

Node trie = new();

trie.Fill("CAR");
trie.Fill("CARS");
trie.Fill("CAT");

Console.WriteLine(trie.Search("CAR"));  // True
Console.WriteLine(trie.Search("CARS")); // True
Console.WriteLine(trie.Search("CA"));   // False
Console.WriteLine(trie.Search("DOG"));  // False

Console.WriteLine("Exiting...");