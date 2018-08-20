// https://segmentfault.com/a/1190000003786782

class Solution {
    public List<int[]> getSkyline(int[][] buildings) {
        List<int[]> result = new ArrayList<int[]>();
        List<int[]> height = new ArrayList<int[]>();
        
        for (int[] b: buildings) {
            height.add(new int[]{b[0], -b[2]}); // difference with right point.
            height.add(new int[]{b[1], b[2]});
        }
        
        Collections.sort(height, new Comparator<int[]>() {
            public int compare(int[] a, int[] b){
                if(a[0] != b[0]){
                    return a[0] - b[0];
                } else {
                    return a[1] - b[1];
                }
            }
        });
        
        Queue<Integer> queue = new PriorityQueue<Integer>(Collections.reverseOrder());
            
        queue.offer(0);
        int prev = 0;
        for (int[] h : height) {
            if (h[1] < 0) {
                queue.offer(-h[1]);
            } else {
                queue.remove(h[1]);
            }
            
            int cur = queue.peek();
            if (prev != cur) {
                result.add(new int[] {h[0], cur});
                prev = cur;
            }
        }
        
        return result;
    }
}
