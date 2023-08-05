namespace Script.CSharpToLua.Editor.input {
    public class TestGenericMethod {
        public T Test<T>(T t) {
            return t;
        }

        public void TestDo() {
            Test<int>(5);
        }
    }
}