using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr) {
        int res = int.MinValue;
        for (var i = 0; i < 16; i++) {
            var row = i/4;
            var col = i%4;
            var tot = arr[row][col] + arr[row][col+1] + arr[row][col+2] +
                                    arr[row+1][col+1]+
                arr[row+2][col] + arr[row+2][col+1] + arr[row+2][col+2];
            if (tot > res) {
                res = tot;
            }
        }
        return res;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
