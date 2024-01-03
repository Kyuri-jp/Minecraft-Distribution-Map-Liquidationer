using System.IO;
using System.IO.Compression;

namespace MinecraftDistributionMapLiquidationer.Programs
{
    internal class Liquidation : MDML
    {
        internal void Liquidationer(string path)
        {
            //exists
            List<bool> exists = [
                Directory.Exists(Path.Combine(path, advancements)),
                Directory.Exists(Path.Combine(path, data)),
                Directory.Exists(Path.Combine(path, datapacks)),
                Directory.Exists(Path.Combine(path, DIM1)),
                Directory.Exists(Path.Combine(path, DIM_1)),
                Directory.Exists(Path.Combine(path, playerdata)),
                Directory.Exists(Path.Combine(path, poi)),
                Directory.Exists(Path.Combine(path, stats)),

                //files
                File.Exists(Path.Combine(path, level_dat_old)),
                File.Exists(Path.Combine(path, session_lock))
            ];

            //write
            Console.WriteLine("");

            Console.WriteLine($"{advancements} : " + Directory.Exists(Path.Combine(path, advancements)));
            Console.WriteLine($"{data} : " + Directory.Exists(Path.Combine(path, data)));
            Console.WriteLine($"{datapacks} : " + Directory.Exists(Path.Combine(path, datapacks)));
            Console.WriteLine($"{DIM1} : " + Directory.Exists(Path.Combine(path, DIM1)));
            Console.WriteLine($"{DIM_1} : " + Directory.Exists(Path.Combine(path, DIM_1)));
            Console.WriteLine($"{playerdata} : " + Directory.Exists(Path.Combine(path, playerdata)));
            Console.WriteLine($"{poi} : " + Directory.Exists(Path.Combine(path, poi)));
            Console.WriteLine($"{stats} : " + Directory.Exists(Path.Combine(path, stats)));
            Console.WriteLine($"{level_dat_old} : " + File.Exists(Path.Combine(path, level_dat_old)));
            Console.WriteLine($"{session_lock} : " + File.Exists(Path.Combine(path, session_lock)));

        //goto label
        loop:

            //ask
            Console.WriteLine("\nDo you use recommended method?\n(y/n)");
            ConsoleKeyInfo useRecommend = Console.ReadKey();

            if (!useRecommend.Key.ToString().Equals("Y") &&
                !useRecommend.Key.ToString().Equals("N"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSelect y/n.");
                Console.ForegroundColor = defaultColor;
                goto loop;
            }

            Console.WriteLine("");

            //recommend
            if (useRecommend.Key.ToString().Equals("Y"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                if (exists[0])
                {
                    Directory.Delete(Path.Combine(path, advancements), true);
                    Console.WriteLine(advancements + " has been delete.");
                }
                if (exists[1] && File.Exists(Path.Combine(path, data, "raids.dat")))
                {
                    File.Delete(Path.Combine(path, data, "raids.dat"));
                    Console.WriteLine(data + " has been delete.");
                }
                if (exists[2] && 0 <= Directory.GetDirectories(Path.Combine(path, datapacks)).Length)
                {
                    Directory.Delete(Path.Combine(path, datapacks), true);
                    Console.WriteLine(datapacks + " has been delete.");
                }
                if (exists[3] && 100 < GetFolderSize(Path.Combine(path, DIM1)))
                {
                    Directory.Delete(Path.Combine(path, DIM1), true);
                    Console.WriteLine(DIM1 + " has been delete.");
                }
                if (exists[4] && 100 < GetFolderSize(Path.Combine(path, DIM_1)))
                {
                    Directory.Delete(Path.Combine(path, DIM_1), true);
                    Console.WriteLine(DIM_1 + " has been delete.");

                }
                if (exists[5])
                {
                    Directory.Delete(Path.Combine(path, playerdata), true);
                    Console.WriteLine(playerdata + " has been delete.");
                }
                if (exists[6])
                {
                    Directory.Delete(Path.Combine(path, poi), true);
                    Console.WriteLine(poi + " has been delete.");
                }
                if (exists[7])
                {
                    Directory.Delete(Path.Combine(path, stats), true);
                    Console.WriteLine(stats + " has been delete.");
                }
                if (exists[8])
                {
                    File.Delete(Path.Combine(path, level_dat_old));
                    Console.WriteLine(level_dat_old + " has been delete.");
                }
                if (exists[9])
                {
                    File.Delete(Path.Combine(path, session_lock));
                    Console.WriteLine(session_lock + " has been delete.");
                }

                Console.ForegroundColor = ConsoleColor.White;

                //zip
                Console.WriteLine("\nCompress in Zip format...");
                Thread thread = new(new ParameterizedThreadStart(Zip));
                thread.Start(path);
            }

            if (useRecommend.Key.ToString().Equals("N"))
            {

            }
        }

        private static long GetFolderSize(string path)
        {
            //init
            long size = 0;

            foreach (string file in Directory.GetFiles(path))
            {
                FileInfo fileInfo = new(path);
                size += file.Length;
            }
            return size;
        }

        private void Zip(object? path)
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
            finally { Console.ForegroundColor = defaultColor; }

            Console.WriteLine("Completed");
        }
    }
}