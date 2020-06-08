using System.Collections;
using System.Collections.Generic;
using System;

public class Test
{
    static void Main(string[] args) 
        {
        List<List<int>> testList = new List<List<int>>();
        List<int> test2 = new List<int>();

        test2.Add(0);
        test2.Add(1);
        testList.Add(test2);
        
        Console.WriteLine(testList[0]);
        }
}
        
 
    

