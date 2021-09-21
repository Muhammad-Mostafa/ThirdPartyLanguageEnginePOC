using System;
using Microsoft.ClearScript;
using Microsoft.ClearScript.JavaScript;
using Microsoft.ClearScript.V8;

namespace ThirdPartyLanguageEnginePOC
{
    public class ClearScript_JS_Engine_POC
    {
        public static void RunClearScripttJSEngine()
        {
            try
            {
                Console.WriteLine("\n======= Utilizing ClearScript JS Engine =======\n");

                V8ScriptEngine engine = new V8ScriptEngine();

                string JavaScriptCode = GetJavaScriptCode();

                engine.Execute(JavaScriptCode);

                var value = engine.Script.getCustomValue("abx", "xyz");

                Console.WriteLine($"Result value from js code: {value}\n");
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static string GetJavaScriptCode()
        {
            string jsCode = @"
                            function getCustomValue(value1, value2) 
                            {
                               return value1 + ', ' + value2;
                            }
                        ";
            return jsCode;
        }
    }
}
