ushort num1 = 123;
            
//UInt32 num2 = 456;
uint num2 = 456;
// UInt64 num3 = 789;
ulong num3 = 789;
Console.WriteLine($"ushort Min Value:{ushort.MinValue} and Max Value:{ushort.MaxValue}");
Console.WriteLine($"short Size:{sizeof(ushort)} Byte");
Console.WriteLine($"uint Min Value:{uint.MinValue} and Max Value:{uint.MaxValue}");
Console.WriteLine($"uint Size:{sizeof(uint)} Byte");
Console.WriteLine($"ulong Min Value:{ulong.MinValue} and Max Value:{ulong.MaxValue}");
Console.WriteLine($"ulong Size:{sizeof(ulong)} Byte");
Console.ReadKey();