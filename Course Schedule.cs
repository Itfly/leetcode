public class Solution {
    public bool CanFinish(int numCourses, int[,] prerequisites) {
        if (prerequisites == null || prerequisites.Length == 0) {
            return true;
        } 
        
        var degrees = new int[numCourses];
        for(var i = 0; i < prerequisites.GetLength(0); i++) {
            degrees[prerequisites[i, 0]]++;
        }
        
        var queue = new Queue<int>();
        for (var i = 0; i < numCourses; i++) {
            if (degrees[i] == 0) {
                queue.Enqueue(i);
            }
        }
        
        var count = queue.Count;
        while (queue.Count > 0) {
            var cur = queue.Dequeue();
            for (var i = 0; i < prerequisites.GetLength(0); i++) {
                if (prerequisites[i, 1] == cur) {
                    degrees[prerequisites[i, 0]]--;
                    if (degrees[prerequisites[i, 0]] == 0) {
                        count++;
                        queue.Enqueue(prerequisites[i, 0]);
                    }
                }
            }
        }
        
        return count == numCourses;
    }
}
