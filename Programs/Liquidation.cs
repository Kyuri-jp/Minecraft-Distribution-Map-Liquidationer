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
            string? useRecommend = Console.ReadLine();
            if (useRecommend != "y" && useRecommend != "n")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Select y/n.");
                Console.ForegroundColor = defaultColor;
                goto loop;
            }
            if (useRecommend == "y")
            {
                return;
            }
        }
    }
}
