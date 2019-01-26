public class Solution
    {
        public int MaxPoints(Point[] points)
        {
            if (points == null || points.Length == 0)
            {
                return 0;
            }

            var result = 0;
            for (var i = 0; i < points.Length; i++)
            {
                var dups = 1;
                var map = new Dictionary<Tuple<int, int>, int>();
                for (var j = i + 1; j < points.Length; j++)
                {
                    if (points[i].x == points[j].x && points[i].y == points[j].y)
                    {
                        dups++;
                        continue;
                    }

                    var slope = CalculateSlope(points[i], points[j]);
                    if (!map.ContainsKey(slope))
                    {
                        map[slope] = 1;
                    }
                    else
                    {
                        map[slope]++;
                    }
                }
                
                
                result = Math.Max(result, dups);
                foreach (var cnt in map.Values)
                {
                    result = Math.Max(result, cnt + dups);
                }
                
            }

            return result;
        }

    
        private int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        private Tuple<int, int> CalculateSlope(Point a, Point b)
        {
            var x = a.x - b.x;
            var y = a.y - b.y;
            var gcd = GCD(x, y);
            return new Tuple<int, int>(x / gcd, y / gcd);
        }
    }
