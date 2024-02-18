using System.Linq;

namespace LeetCode75.Main.Trie;

internal class SearchSuggestionsSystem
{
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
    {
        var lists = new List<IList<string>>();
        List<string> list = [.. products.ToList().OrderBy(w => w)];

        for (int i = 0; i < searchWord.Length; i++)
        {
            list = list.Where(w => w.StartsWith(searchWord[..(i + 1)])).ToList();
            lists.Add(list.Take(3).ToList());
        }
        return lists;
    }
}
