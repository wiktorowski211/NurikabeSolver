using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SbsSW.SwiPlCs;
using System.IO;

namespace NurikabeSolver
{
    class PrologCommunication
    {
        public static void InitializeProlog()
        {
            if (!PlEngine.IsInitialized)
            {
                try
                {
                    Console.WriteLine("Used Prolog directory: " + System.Environment.GetEnvironmentVariable("SWI_HOME_DIR"));
                    var project_dir = Directory.GetCurrentDirectory().Replace(@"\", @"/");
                    Console.WriteLine("Used project directory: " + project_dir);
                    String[] param = { "-q" };  // suppressing informational and banner messages
                    PlEngine.Initialize(param);
                    PlQuery.PlCall($"working_directory(_, '{project_dir}').");
                    PlQuery.PlCall("[nurikabe]");
                    Console.WriteLine("Initialized Prolog succesfully.");
                    return;
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine("Failure initializing Prolog: " + ex.Message);
                    return;
                }
            }
            Console.WriteLine("Prolog already initialized.");
        }

        public static void CleanupProlog()
        {
            PlEngine.PlCleanup();
        }

        // Send island data and board size, returns null or board as array, where 1 is sea and 0 island.
        // example of properly formatted islands string: [[1,3,3],[2,2,3],[5,1,2],[5,5,4]]
        public static int[][] SendIslands(int size, string islands)
        {
            // Prolog interface indexed from 1
            using (var q = new PlQuery($"delay_test({size}, {islands} ,EG)"))
            {
                Console.WriteLine("Returned board:");
                //  q.Variables["P"].Unify("uwe");
                foreach (PlQueryVariables v in q.SolutionVariables)
                {
                    var result = v["EG"].Select(a => a.Select(b => (int)b).ToArray()).ToArray();

                    // No access to documentation if it can return null at all.
                    // Specification of NurikabeSolver says that Prolog might return empty list [[]] when there's no solution.
                    if (result != null && result[0].Length != size)
                    {
                        Console.WriteLine("No result found. Empty list.");
                        return null;
                    }

                    foreach (var row in result)
                    {
                        foreach (int value in row)
                        {
                            Console.Write(value + ", ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Board returned succesfully.");
                    return result;
                }
            }
            Console.WriteLine("No result found. False.");
            return null;
        }
    }
}
