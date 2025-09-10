using System;
using CoreLearning.OopPrinciples.ClassFiles;
using CoreLearning.LogicalProgram.SwappingProgram;

namespace CoreLearning;

public class Program
{
    static void Main()
    {
        SwappingCode tp = new SwappingCode();
        tp.SwappingValue(10, 20);
        tp.SwappingValueMulDiv(10, 20);
    }
}