public class Solution {
    public int[,] ReconstructQueue(int[,] people) {
        var tuples = new Tuple<int, int>[people.GetLength(0)];
        for (var i = 0; i < people.GetLength(0); i++) {
            tuples[i] = new Tuple<int, int>(people[i, 0], people[i, 1]);
        }
        
        Array.Sort(tuples, delegate(Tuple<int, int> a, Tuple<int, int> b) {
            if (a.Item1 < b.Item1) {
                return 1;
            } else if (a.Item1 > b.Item1) {
                return -1;
            } else {
                return a.Item2 - b.Item2;
            }
        });
        
        for (var i = 1; i < tuples.Length; i++) {
            var temp = tuples[i];            
            for (var j = i - 1; j >= temp.Item2; j--) {
                tuples[j + 1] = tuples[j];
            }
            tuples[temp.Item2] = temp;
        }
        
        for (var i = 0; i < tuples.Length; i++) {
            people[i, 0] = tuples[i].Item1;
            people[i, 1] = tuples[i].Item2;
        }
        return people;
    }
}
