using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Test
{
    internal class WorldsDumbestFunctionTest
    {
        // Naming Convections ClassName_MethodName_returnType
        public static void WorldsDumbestFunction_CheckNumbers_ReturnsString()
        {
            try
            {
                // Arrange - Resoruce Requirements
                int number = 0;
                WorldsDumbestFunction worldsDumbestFunction = new WorldsDumbestFunction();

                // Act - Method Execution
                string Result = worldsDumbestFunction.CheckNumber(number);

                // Assert
                if (Result == "result is 0")
                {
                    Console.WriteLine("TEST PASSED: WorldsDumbestFunction_CheckNumber_returnString");
                }
                else
                {
                    Console.WriteLine("TEST FAILED: WorldsDumbestFunction_CheckNumber_returnString");
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
