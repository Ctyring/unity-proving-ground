using System;
using System.Diagnostics;
namespace Script.CSharpToLua.Editor.input {
    public class Person
    {
        /// <summary>
        /// @CSharpLua.Metadata
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Test(int a, int b) {
            return a + b;
        }
    }
}