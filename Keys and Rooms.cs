public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        var visited = new bool[rooms.Count];
        DFS(rooms as List<IList<int>>, visited, 0);
        
        foreach (var v in visited) {
            if (!v) {
                return false;
            }
        }
        return true;
    }
    
    private void DFS(List<IList<int>> rooms, bool[] visited, int index) {
        visited[index] = true;
        foreach (var key in rooms[index]) {
            if (!visited[key]) {
                DFS(rooms, visited, key);
            }
        }
    }
}
