using System;
using System.Runtime.InteropServices.Marshalling;

namespace Implement_Trie__Prefix_Tree_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = new Trie();
            t.Insert("app");
            t.Insert("apple");
            t.Insert("beer");
            t.Insert("add");
            t.Insert("jam");
            t.Insert("rental");


            Console.WriteLine(t.Search("apps"));
            Console.WriteLine(t.Search("app"));
        }
    }

    public class Trie
    {
        public List<Trie> Child { get; private set; }
        public bool IsTerminal { get; private set; }
        public char Value { get; private set; }

        public Trie()
        {
            IsTerminal = false;
            Value = ' ';
            Child = new List<Trie>();
        }
        
        private Trie(bool  isTerminal, char value)
        {
            IsTerminal = isTerminal;
            Value = value;
            Child = new List<Trie>();
        }

        public void Insert(string word)
        {
            Insert(word, 0);
        }
        private void Insert(string word, int index)
        {
            char letter = word[index];
            bool isLastLetter = index == word.Length - 1;

            for (int i = 0; i < Child.Count; i++)
            {
                char childVal = Child[i].Value;
                if (childVal == letter)
                {
                    if (!isLastLetter)
                    {
                        Child[i].Insert(word, index + 1);
                    }
                    else
                    {
                        Child.Add(new Trie(true, letter));
                    }
                    return;
                }
            }

            Trie t;
            if (isLastLetter)
            {
                t = new Trie(true, letter);
            }
            else
            {
                t = new Trie(false, letter);
                t.Insert(word, index + 1);
            }
            Child.Add(t);
        }

        public bool Search(string word)
        {
            return Search(word, 0);
        }
        private bool Search(string word, int index)
        {
            bool ans = false;
            bool isLastLetter = index == word.Length - 1;

            for (int i = 0; i < Child.Count; i++)
            {
                if (Child[i].Value == word[index])
                {
                    if (!isLastLetter)
                    {
                        ans = Child[i].Search(word, index + 1);
                        return ans;
                    }
                    else if (Child[i].IsTerminal)
                    {
                        return true;
                    }
                }
            }
            return ans;
        }

        public bool StartsWith(string prefix)
        {
            return StartsWith(prefix, 0);
        }
        private bool StartsWith(string prefix, int index)
        {
            bool ans = false;
            bool isLastLetter = index == prefix.Length - 1;

            for (int i = 0; i < Child.Count; i++)
            {
                if (Child[i].Value == prefix[index])
                {
                    if (!isLastLetter)
                    {
                        ans = Child[i].StartsWith(prefix, index + 1);
                        return ans;
                    }
                    else
                    {
                        return true;
                    }
                }
            }

            return ans;
        } 
    }
}
