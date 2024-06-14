using System.Text;

namespace Search_Suggestions_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuggestedProducts(["mobile", "mouse", "moneypot", "monitor", "mousepad"], "mouse");
            Console.WriteLine("Hello, World!");
        }

        public static IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            var trie = new Trie();
            var ans = new List<IList<string>>();

            for (int i = 0; i < products.Length; i++)
            {
                trie.Insert(products[i]);
            }

            for (int i = 0; i < searchWord.Length; i++)
            {
                List<string> suggestions = trie.GetWordsWithPrefix(searchWord[..(i + 1)]);
                suggestions.Sort();
                
                if(suggestions.Count > 3) suggestions.RemoveRange(3, suggestions.Count - 3);
                ans.Add(suggestions);
            }

            return ans;
        }
    }

    public class Trie
    {
        private TrieNode _root;

        public Trie()
        {
            _root = new TrieNode();
        }

        public void Insert(string word)
        {
            var current = _root;

            for (int i = 0; i < word.Length; i++)
            {
                if (!current.Childs.ContainsKey(word[i]))
                {
                    current.Childs.Add(word[i], new TrieNode());
                }

                current = current.Childs[word[i]];
            }

            current.IsTerminal = true;
        }

        public List<string> GetWordsWithPrefix(string prefix)
        {
            var sb = new StringBuilder(prefix);
            var ans = new List<string>();

            TrieNode curNode = _root;
            for (int i = 0;i < prefix.Length; i++)
            {
                if (curNode.Childs.ContainsKey(prefix[i]))
                {
                    curNode = curNode.Childs[prefix[i]];
                }
                else
                {
                    return ans;
                }
            }

            if(curNode.IsTerminal) ans.Add(sb.ToString());

            DFS(curNode);

            return ans;

            void DFS(TrieNode node)
            {
                foreach (var child in node.Childs) 
                {
                    sb.Append(child.Key);
                    if(child.Value.IsTerminal) ans.Add(sb.ToString());

                    DFS(child.Value);

                    sb.Remove(sb.Length - 1, 1);
                }
            }
        }

        private class TrieNode
        {
            public Dictionary<char, TrieNode> Childs;
            public bool IsTerminal;

            public TrieNode()
            {
                Childs = new Dictionary<char, TrieNode>();
                IsTerminal = false;
            }
        }
    }
}
