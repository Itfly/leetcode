class Solution {
public:
    int numDecodings(string s) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int n = s.length();
        if (n == 0) return 0;
        if (s[0] == '0') return 0;
        if (n == 1) return 1;
        vector<int> dp(n);
        dp[0] = 1;
        if (s[1] == '0') {
            if (s[0] > '2') return 0;
            dp[1] = 1;
        } else {
            dp[1] = (s[0] == '1' || s[0] == '2' && s[1] <= '6') ? 2 : 1;
        }
        
        for (int i = 2; i < n; i++) {
            if (s[i] != '0') {
                dp[i] = dp[i-1];
            } else {
                dp[i] = 0;
            }
            if (s[i-1] == '1' || s[i-1] == '2' && s[i] <= '6') {
                dp[i] += dp[i-2];
            }
            if (dp[i] == 0) return 0;
        }
        return dp[n-1];
    }
};



public Set<String> decode(String prefix, String code) {
		Set<String> set = new HashSet<String>();
		if (code.length() == 0) {
			set.add(prefix);
			return set;
		}

		if (code.charAt(0) == '0')
			return set;

		set.addAll(decode(prefix + (char) (code.charAt(0) - '1' + 'a'),
				code.substring(1)));
		if (code.length() >= 2 && code.charAt(0) == '1') {
			set.addAll(decode(
					prefix + (char) (10 + code.charAt(1) - '1' + 'a'),
					code.substring(2)));
		}
		if (code.length() >= 2 && code.charAt(0) == '2'
				&& code.charAt(1) <= '6') {
			set.addAll(decode(
					prefix + (char) (20 + code.charAt(1) - '1' + 'a'),
					code.substring(2)));
		}
		return set;
}
