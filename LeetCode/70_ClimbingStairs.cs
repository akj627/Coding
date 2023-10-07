public class Solution {
    public int ClimbStairs(int n) {
        if (n == 1)
            return 1;
    
        var last = 1;
        var secondLast = 1;
        var sum = 0;
        for (var i = 2; i <= n; i++)
        {
            sum = secondLast + last;
            last = secondLast;
            secondLast = sum;
        }
        return sum;        
    }
}