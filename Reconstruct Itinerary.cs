public class Solution {
    public IList<string> FindItinerary(string[,] tickets) {
        var graph = new Dictionary<string, List<string>>();
        for (var i = 0; i < tickets.GetLength(0); i++) {
            if (!graph.ContainsKey(tickets[i, 0])) {
                graph[tickets[i, 0]] = new List<string> { tickets[i, 1] };
            } else {
                var index = graph[tickets[i, 0]].BinarySearch(tickets[i, 1]);
                if (index < 0) {
                    index = ~index;
                }
                graph[tickets[i, 0]].Insert(index, tickets[i, 1]);
            }
        }
        
        var itinerary = new List<string> { "JFK" };
        DFS("JFK", graph, itinerary, tickets.GetLength(0));
        
        return itinerary;
    }
    
    private void DFS(string from, Dictionary<string, List<string>> graph, List<string> itinerary, int numOfTickets) {
        if (!graph.ContainsKey(from)) {
            return;
        }
        var dests = graph[from];
        for (var i = 0; i < dests.Count; i++) {
            var dest = dests[i];
            dests.RemoveAt(i);
            itinerary.Add(dest);
            
            DFS(dest, graph, itinerary, numOfTickets);
            // the first valid route is the final answer
            if (itinerary.Count == numOfTickets + 1) {
                return;
            }
            
            dests.Insert(i, dest);
            itinerary.RemoveAt(itinerary.Count - 1);
        }     
    }
}
