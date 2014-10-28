class Solution {
public:
    vector<int> searchRange(int A[], int n, int target) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int low = 0, high = n-1;
        int x = target;
        vector<int> result(2);
        int lrange = -1, rrange;
        int mid;
        
        while (low <= high) {
        	mid = (low + high) / 2;
	    		if (A[mid] == x) {
						if (mid == 0 || A[mid-1] < x) {
								lrange = mid;
								break;
						} else {
								high = mid - 1;
						}
	    		} else if (A[mid] > x) {
						high = mid - 1;
	    		} else {
						low = mid + 1;
	    		}
        }

        if (lrange == -1) {
    				result[0] = -1;
            result[1] = -1;
            return result;
        }

        low = lrange + 1;
        high = n - 1;
        rrange = lrange;
        while (low <= high) {
		    mid = (low + high) / 2;
		    if (A[mid] == x) {
			   	if (mid == n-1 || A[mid+1] > x) {
						rrange = mid;
						break;
				} else {
						low = mid + 1;
				}
		    } else if (A[mid] > x) {
				high = mid - 1;
		    } else {
				low = mid + 1;
		    }
        }
        result[0] = lrange;
        result[1] = rrange;
        return result;
    }
};



class Solution {
public:
    int searchRangehelper(int A[], int n, int target, bool isLrange) {
        int low = 0, high = n - 1;
        int mid;
        while (low <= high) {
            mid = low + ((high - low) >> 1);
            if (A[mid] == target) {
                if (isLrange) {
                    high = mid;
                    if (low < high && A[high-1] == target) {
                        high--;
                    } else {
                        return high;
                    }
                } else {
                    low = mid;
                    if (low < high && A[low+1] == target) {
                        low++;
                    } else {
                        return low;
                    }
                }
                
            } else if (A[mid] > target) {
                high = mid - 1;
            } else {
                low = mid + 1;
            }
        }
        
        return -1;
    }
    vector<int> searchRange(int A[], int n, int target) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<int> range(2);
        range[0] = searchRangehelper(A, n, target, true);
        range[1] = searchRangehelper(A, n, target, false);
        return range;
        
    }
};