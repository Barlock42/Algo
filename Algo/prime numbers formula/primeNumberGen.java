import java.lang.Math;

public class PrimeGenerator {

    public static int prime(int n) {
        return 1 + sumFunction(n);
    }

    private static double sumFunction(int n) {
        double sum = 0;
        for (int i = 1; i <= Math.pow(2, n); i++) {
            sum += Math.floor(Math.pow(n / sumInnerFunction(i), 1.0 / n));
        }
        return sum;
    }

    private static double sumInnerFunction(int i) {
        double innerSum = 0;
        for (int j = 1; j <= i; j++) {
            innerSum += Math.floor(Math.pow(Math.cos(Math.PI * (factorial(j - 1) + 1) / j), 2));
        }
        return innerSum;
    }

    private static int factorial(int num) {
        if (num <= 1)
            return 1;
        else
            return num * factorial(num - 1);
    }

    public static void main(String[] args) {
        int n = 5; // Example usage
        int result = prime(n);
        System.out.println(result);
    }
}
