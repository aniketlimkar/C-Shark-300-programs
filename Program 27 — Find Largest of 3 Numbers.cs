using System;
class Program {
    static void Main() {
        int a = 10, b = 25, c = 15;
        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        Console.WriteLine("Largest = " + max);
    }
}
