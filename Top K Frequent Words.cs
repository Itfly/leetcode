public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        var map = new Dictionary<string, int>();
        foreach (var word in words) {
            if (map.Containskey(word)) {
                map[word]++;
            } else {
                map[word] = 1;
            }
        }
    }
    
    class Heap {
        (string word, int freq)[] items;
        int size;
        
        public void Heapify(int k) {
            var temp = items[k];
            var i = k;
            for (var j = 2*i+1; j < size; j = 2*j + 1) {
                if (j < size-1 && (items[j].freq < items[j + 1].freq 
                        || (items[j].freq == items[j + 1].freq && items[j].word < items[j + 1].word)])) {
                    j = j + 1;
                }
                if
            }
        }
    }
}


https://www.jianshu.com/p/48ebffa146db
