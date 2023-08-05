using System;

namespace Script.CSharpToLua.Editor.input {
    public class TestField {
        private const String hello = "hello";
        private static int a = 1;
        public readonly float b = 3f;
        public int c = 0;
        
        [Obsolete("This is obsolete")]
        public int testAttribute = 1;
    }

    public static class Test {
        private static int a = 1;
    }
}