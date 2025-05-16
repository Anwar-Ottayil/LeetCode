public class Solution {
    public int MySqrt(int x) {
        if (x == 0) return 0;

        long guess = x;

        while (guess * guess > x) {
            guess = (guess + x / guess) / 2;
        }

        return (int)guess;
    }
}
