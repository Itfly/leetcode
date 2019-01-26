public class Solution {
    public int OpenLock(string[] deadends, string target)
        {
            const string start = "0000";
            var visited = new HashSet<string>(deadends);
            if (visited.Contains(start))
            {
                return -1;
            }
            if (start == target)
            {
                return 0;
            }

            var queue = new Queue<string>();
            queue.Enqueue(start);
            visited.Add(start);

            var steps = 0;
            while (queue.Count > 0)
            {
                
                var count = queue.Count;
                for (var i = 0; i < count; i++)
                {
                    var cur = queue.Dequeue();
                    if (cur == target)
                    {
                        return steps;
                    }

                    var chs = cur.ToCharArray();
                    for (var j = 0; j < 4; j++)
                    {
                        var ch = chs[j];
                        chs[j] = (char) ((ch == '9' ? '0' : ch + 1));
                        var s1 = new String(chs);
                        chs[j] = (char) ((ch == '0' ? '9' : ch - 1));
                        var s2 = new String(chs);
                        chs[j] = ch;

                        if (!visited.Contains(s1))
                        {
                            queue.Enqueue(s1);
                            visited.Add(s1);

                        }
                        if (!visited.Contains(s2))
                        {
                            queue.Enqueue(s2);                    
                            visited.Add(s2);

                        }
                    }
                }
                ++steps;

            }

            return -1;
        }
}

// TODO: add bi-bfs solution: https://blog.csdn.net/LaputaFallen/article/details/79456432
