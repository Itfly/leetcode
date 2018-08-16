public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        if (wordList == null || !wordList.Contains(endWord)) {
            return 0;
        }
        
        var result = 1;
        var visited = new HashSet<string>();
        var wordSet = new HashSet<string>(wordList);
        var queue = new Queue<string>();
        queue.Enqueue(beginWord);
        while (queue.Count > 0) {
            var size = queue.Count;
            for (var i = 0; i < size; i++) {
                var curWord = queue.Dequeue();
                for (var j = 0; j < curWord.Length; j++) {
                    for (var k = 'a'; k <= 'z'; k++) {
                        var str = ReplaceAt(curWord, j, k);
                        if (str == curWord) {
                            continue;
                        }
                        
                        if (str == endWord) {
                            return result + 1;
                        }
                        
                        if (wordSet.Contains(str) && !visited.Contains(str)) {
                            visited.Add(str);
                            queue.Enqueue(str);
                        }
                    }
                }
            }
            result++;
        }
        
        return 0;
    }
    
    private static string ReplaceAt(string str, int index, char newChar)
    {
        var chars = str.ToCharArray();
        chars[index] = newChar;
        return new string(chars);
    }
}
