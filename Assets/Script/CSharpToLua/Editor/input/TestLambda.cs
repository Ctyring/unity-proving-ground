using System;
using System.Collections.Generic;
using UnityEngine;

namespace Script.CSharpToLua.Editor.input {
    public class TestLambda {
        void Test() {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // simple lambda expression
            numbers.ForEach(n => Console.WriteLine(n));
            
            // Parenthesized Lambda Expression
            numbers.ForEach((n) => Console.WriteLine(n));
            
            // Anonymous Method Expression
            numbers.ForEach(delegate(int n) { Console.WriteLine(n); });
        }
    }
}