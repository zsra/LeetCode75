namespace LeetCode75.Main.Trie;

public class Trie
{
    private class TrieNode(char key)
    {
        public char Key { get; set; } = key;
        public bool IsEndOfWord { get; set; }
        public Dictionary<char, TrieNode> Children { get; set; } = [];
    }

    private readonly TrieNode root;

    public Trie() => root = new TrieNode('*');

    public void Insert(string word)
    {
        var current = root;
        foreach (var c in word)
        {
            if (!current.Children.TryGetValue(c, out var childNode))
            {
                current.Children[c] = childNode = new TrieNode(c);
            }

            current = childNode;
        }

        current.IsEndOfWord = true;
    }

    public bool Search(string word)
    {
        var current = root;

        foreach (var c in word)
        {
            if (!current.Children.TryGetValue(c, out var childNode))
            {
                return false;
            }

            current = childNode;
        }
        return current.IsEndOfWord;
    }

    public bool StartsWith(string prefix)
    {
        var current = root;

        foreach (var c in prefix)
        {
            if (!current.Children.TryGetValue(c, out var child))
            {
                return false;
            }

            current = child;
        }
        return true;
    }
}
