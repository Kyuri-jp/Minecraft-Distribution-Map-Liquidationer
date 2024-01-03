using System.IO.Compression;

namespace MinecraftDistributionMapLiquidationer.Progresses
{
    internal class FolderZiper
    {
        internal static void Zip(string path, string outPut)
        {
            //null
            if (path == null)
                throw new NullReferenceException();

            //ex
            try { ZipFile.CreateFromDirectory(path, Path.Combine(outPut, $"{Path.GetFileName(path)}.zip")); }
            catch (NullReferenceException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine
                    ("**Error**\n" +
                    "This File Path is Null.\n\n" +
                    "<Stack Trace>\n" +
                    ex.StackTrace);
                return;
            }
            catch (IOException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine
                    ("**Error**\n" +
                    ex.Message +
                    "\n<Stack Trace>\n" +
                    ex.StackTrace);
                return;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine
                    ("**Error**\n\n" +
                    "<Stack Trace>\n" +
                    ex.StackTrace);
                return;
            }
            finally { Console.ForegroundColor = ConsoleColor.White; }

            Console.WriteLine("Completed");
            Console.WriteLine("Output Path : " + Path.Combine(outPut, $"{Path.GetFileName(path)}.zip"));
            Console.WriteLine("\nPress Any Key...");
            Console.ReadKey(false);
        }
    }
}