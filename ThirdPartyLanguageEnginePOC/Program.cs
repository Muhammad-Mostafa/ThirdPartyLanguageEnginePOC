using System;

namespace ThirdPartyLanguageEnginePOC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Execute a sample python code using IronPython
            IronPython_Python_Engine_POC.RunIronPythonEngine();

            // Execute a js sample code using Jint  
            Jint_JS_Engine_POC.RunJintJSEngine();

            // Execute a js sample code using ClearScript
            ClearScript_JS_Engine_POC.RunClearScripttJSEngine();


        }
    }
}
