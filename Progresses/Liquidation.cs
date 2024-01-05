namespace MinecraftDistributionMapLiquidationer.Progresses
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
        loopRec:

            //ask
            Console.WriteLine("\nDo you use recommended method?\n(y/n)");
            ConsoleKeyInfo useRecommend = Console.ReadKey();

            if (!useRecommend.Key.ToString().Equals("Y") &&
                !useRecommend.Key.ToString().Equals("N"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSelect y/n.");
                Console.ForegroundColor = defaultColor;
                goto loopRec;
            }

            Console.WriteLine("");

            //recommend
            if (useRecommend.Key.ToString().Equals("Y")) liquidation.Recommend.DoRecommend(path, exists);

            if (useRecommend.Key.ToString().Equals("N")) liquidation.Custom.DoCustom(path, exists);
        }
    }
}