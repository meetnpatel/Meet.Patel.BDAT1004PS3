using System;
using System.Collections.Generic;
using System.IO;

static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ');
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        int[] a = new int[n];
        var in1 = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(in1[i]);
        }
        int[] b = new int[m];
        var input2 = Console.ReadLine().Split(' ');
        int gcd = 0;
        for (int j = 0; j < m; j++)
        {
            b[j] = int.Parse(input2[j]);
            gcd = findGCD(b[j], gcd);
        }
        Console.WriteLine(getTotalX(a, b, n, gcd));
    }

public static int getTotalX(int[] a, int[] b, int n, int gcd)
    {
        int lcm = a[0];
        for (int i = 0; i < n - 1; i++)
        {
            lcm = (lcm * a[i + 1]) / findGCD(a[i + 1], lcm);
        }
        int count = 0, t = 0;
        for (int i = 1; i <= gcd && t <= gcd; i++)
        {
            t = lcm * i;
            if (gcd % (lcm * i) == 0)
            {
                count++;
            }
        }
        return count;
    }
    
public static int findGCD(int a, int b)
    {
        return b == 0 ? a : findGCD(b, a % b);
    }