using System.IO.Compression;

namespace MinecraftDistributionMapLiquidationer.Programs
{
    internal class FolderZiper
    {
        internal static void Zip(object? path)
        {
            //null
            if (path == null) { throw new NullReferenceException(); }

            //ex
            try { ZipFile.CreateFromDirectory((string)path, (string)path + ".zip"); }
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
                    "<Stack Trace>\n" +
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
        }
    }
}
