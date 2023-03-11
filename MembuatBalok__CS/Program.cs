using System;

class Program {
    static void Main(string[] args) {
        int length = 10;
        int width = 5;
        int height = 3;

        for (int i = 0; i < height; i++) {
            for (int j = 0; j < width; j++) {
                for (int k = 0; k < length; k++) {
                    if (i == 0 || i == height - 1 || j == 0 || j == width - 1 || k == 0 || k == length - 1) {
                        Console.Write("*");
                    } else {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}