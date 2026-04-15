using System;
class Program {
    static void Main() {
        for (int num = 2; num <= 100; num++) {
            bool isPrime = true;
            for (int i = 2; i <= num / 2; i++) {
                if (num % i == 0) {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime) Console.Write(num + " ");
        }
    }
}
