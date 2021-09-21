using System;
using Jint;

namespace ThirdPartyLanguageEnginePOC
{
    public class Jint_JS_Engine_POC
    {
        public static void RunJintJSEngine()
        {
            try
            {
                Console.WriteLine("\n======= Utilizing Jint JS Engine =======\n");

                string JavaScriptCode = GetJavaScriptCode();

                var ExecuteLogicOnSSOFieldsFunction = new Engine()
                    .Execute(JavaScriptCode).GetValue("getCustomValue");

                bool membershipField = true;
                var customValue = ExecuteLogicOnSSOFieldsFunction.Invoke(membershipField);

                Console.WriteLine($"Result value from js code: {customValue}\n");

            }
            catch (Jint.Runtime.JavaScriptException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
        }
        public static string GetJavaScriptCode()
        {
            string jsCode = @"
                            function getCustomValue(membershipField) 
                            {
                                var membership = '';
                                if (membershipField == true){
                                    membership = 'Member';
                                }
                                else {
                                    membership = 'Not A Member';
                                }
                                return membership;
                            }
                        ";
            return jsCode;
        }
    }
}
