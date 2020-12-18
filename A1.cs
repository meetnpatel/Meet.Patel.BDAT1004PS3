using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static void Main(String[] args) {

        var totalCases = int.Parse(Console.ReadLine());
            for (int a = 0; a < totalCases; a++)
            {
                var n_tokens = Console.ReadLine().Split(' ');
                var cancellationThreshold = int.Parse(n_tokens[1]);
                var a_temp = Console.ReadLine().Split(' ');
                var EntryTimings = Array.ConvertAll(a_temp, Int32.Parse);
                var onTimeStudents = 0;
                foreach (var studentTiming in EntryTimings)
                {
                    if (studentTiming <= 0)
                        onTimeStudents++;

                    if (onTimeStudents == cancellationThreshold)
                        break;
                }
                if (onTimeStudents < cancellationThreshold)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
    }
}