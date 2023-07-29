using CSharpLua;
using UnityEditor;
using UnityEngine;

namespace Script.CSharpToLua.Editor {
    struct CSharpToLuaSettings {
        public static string input = "Assets/Script/CSharpToLua/Editor/input";
        public static string output = "Assets/Script/CSharpToLua/Editor/output";
    }
    public class CSharpToLuaWindow : EditorWindow {
        [MenuItem("测试/生成Lua代码")]
        public static void Test()
        {
            Debug.Log("Hello World!");
            Compiler compiler = new Compiler(
                input: CSharpToLuaSettings.input,
                output: CSharpToLuaSettings.output,
                lib:getLib(),
                meta:"Assets/Script/CSharpToLua/Editor/UnityEngine.xml",
                csc:"",
                isClassic:false,
                atts:"",
                enums:""
                );
            compiler.Compile();
        }

        /// <summary>
        /// 获取unity依赖的库
        /// </summary>
        /// <returns></returns>
        private static string getLib() {
            string unityObject = typeof(UnityEngine.Object).Assembly.Location;
            string baseDir = System.IO.Path.GetDirectoryName(unityObject);
            string[] libs = System.IO.Directory.GetFiles(baseDir, "*.dll");
            string lib = string.Join(";", libs);
            return lib;
        }
    }
}