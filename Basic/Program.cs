using System;
using System.Collections;
namespace Basic;

public class Program {
    static void Main() {
        var arrayOfInts = Enumerable.Range(69,420).ToArray();
        var arrayList = new ArrayList(arrayOfInts);
    }   
}