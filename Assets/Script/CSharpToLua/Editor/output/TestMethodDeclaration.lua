-- Generated by Assembly-CSharp-Editor Compiler
local System = System
System.namespace("Script.CSharpToLua.Editor.input", function (namespace)
  namespace.class("Person", function (namespace)
    local Test
    -- <summary>
    -- </summary>
    -- <param name="a"></param>
    -- <param name="b"></param>
    -- <returns></returns>
    Test = function (this, a, b)
      return a + b
    end
    return {
      Test = Test,
      __metadata__ = function (out)
        return {
          methods = {
            { "Test", 0x286, Test, System.Int32, System.Int32, System.Int32 }
          }
        }
      end
    }
  end)
end)
