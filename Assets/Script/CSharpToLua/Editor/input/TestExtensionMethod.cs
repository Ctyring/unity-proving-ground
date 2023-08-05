using System;

namespace Script.CSharpToLua.Editor.input {
    public static class TestExtensionMethod {
        public static string Reverse(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
    
    public class TestExtensionMethodString {
        void Test() {
            string originalString = "Hello World";
            string reversedString = originalString.Reverse();
        }
    }
}