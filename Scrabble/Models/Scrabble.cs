using System;
// using System.Linq;
// using System.Collections.Generic;

namespace ScrabbleScorer.Models 
{
  public class Scrabble
  {
    public static Dictionary<char[], int> MyScrabble = new Dictionary<char[], int>() { {new char[]{'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'}, 1}, {new char[]{'D', 'G'}, 2}};

  }
}
