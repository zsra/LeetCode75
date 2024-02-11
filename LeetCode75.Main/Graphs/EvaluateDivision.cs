namespace LeetCode75.Main.Graphs;

internal class EvaluateDivision
{
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
    {
        var graph = new Dictionary<string, Dictionary<string, double>>();
        for (int i = 0; i < equations.Count; i++)
        {
            string arg1 = equations[i][0];
            string arg2 = equations[i][1];

            if (!graph.ContainsKey(arg1))
            {
                graph.Add(arg1, new Dictionary<string, double>());
            }
            if (!graph.ContainsKey(arg2))
            {
                graph.Add(arg2, new Dictionary<string, double>());
            }

            graph[arg1][arg2] = values[i];
            graph[arg2][arg1] = 1 / values[i];
        }

        double DFS(string a, string b, HashSet<string> visited)
        {
            if (!graph.ContainsKey(a) || !visited.Add(a))
            {
                return -1;
            }
            else if (a == b)
            {
                return 1;
            }

            foreach (var node in graph[a])
            {
                double product = DFS(node.Key, b, visited);
                if (product > 0)
                {
                    return product * node.Value;
                }
            }

            return -1;
        }

        int n = queries.Count;
        double[] result = new double[n];
        for (int i = 0; i < n; i++)
        {
            result[i] = DFS(queries[i][0], queries[i][1], new HashSet<string>());
        }

        return result;
    }
}
