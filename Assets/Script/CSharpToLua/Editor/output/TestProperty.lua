-- Generated by Assembly-CSharp-Editor Compiler
local System = System
System.namespace("Script.CSharpToLua.Editor.input", function (namespace)
  namespace.class("TestProperty", function (namespace)
    local getTest, setTest
    getTest = function (this)
      return ""
    end
    setTest = function (this, value)
      this.Name = value
    end
    return {
      getTest = getTest,
      setTest = setTest
    }
  end)
end)
