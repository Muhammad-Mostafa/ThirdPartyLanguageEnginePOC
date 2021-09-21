using System;
using IronPython.Hosting;

namespace ThirdPartyLanguageEnginePOC
{
    public class IronPython_Python_Engine_POC
    {
        public static void RunIronPythonEngine()
        {
            try
            {
                Console.WriteLine("\n======= Utilizing IronPython JS Engine =======\n");

                //instance of python engine
                var engine = Python.CreateEngine();

                //reading code from file
                var pythonCode = GetPythonCode();
                var source = engine.CreateScriptSourceFromString(pythonCode, kind: Microsoft.Scripting.SourceCodeKind.Statements);
                var scope = engine.CreateScope();

                //executing script in scope
                source.Execute(scope);
                var classCalculator = scope.GetVariable("calculator");

                //initializing class
                var calculatorInstance = engine.Operations.CreateInstance(classCalculator);

                Console.WriteLine("Result values from Python code:");
                Console.WriteLine("5 + 10 = {0}", calculatorInstance.add(5, 10));
                Console.WriteLine("5++ = {0}\n", calculatorInstance.increment(5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static string GetPythonCode()
        {
            string pythonCode = 
                @"
class calculator:
    def add(self, x, y):
        return x + y
    def increment(self, x):
        x += 1
        return x
                        ";
            return pythonCode;
        }
    }
}
