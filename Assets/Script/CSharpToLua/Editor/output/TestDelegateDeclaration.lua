-- Generated by Assembly-CSharp-Editor Compiler
local System = System
local Scriptinput
System.import(function (out)
  Scriptinput = Script.CSharpToLua.Editor.input
end)
System.namespace("Script.CSharpToLua.Editor.input", function (namespace)

  namespace.class("MyClass", function (namespace)
    local SayHello
    SayHello = function (this, name)
      System.Console.WriteLine("Hello, " .. name .. "!")
    end
    return {
      SayHello = SayHello
    }
  end)

  namespace.class("Program", function (namespace)
    local Main
    Main = function (args)
      local obj = Scriptinput.MyClass()

      local myDelegate = System.fn(obj, obj.SayHello)

      myDelegate("John")
    end
    return {
      Main = Main
    }
  end)
end)
