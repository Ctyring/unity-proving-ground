namespace Script.CSharpToLua.Editor.input {
    public class TestLifeMethod {
        // 构造函数
        public TestLifeMethod() {
            UnityEngine.Debug.Log("构造函数");
        }
        
        public TestLifeMethod(string str) : this() {}
        
        // 析构函数
        ~TestLifeMethod() {
            UnityEngine.Debug.Log("析构函数");
        }
    }
}