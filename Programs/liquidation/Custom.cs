namespace MinecraftDistributionMapLiquidationer.Programs.liquidation
{
    internal class Custom : MDML
    {
        internal static void DoCustom(string path, List<bool> exists)
        {

            ConsoleKeyInfo yn;
        //label
        loopAdvancements:

            //skip
            if (!exists[0]) { goto loopData; }

            //ask
            Console.WriteLine
                ("Do you Delete " +
                advancements +
                " File? (y/n)");
            yn = Console.ReadKey();

            Console.WriteLine("");

            //loop
            if (!yn.Key.ToString().Equals("Y") &&
            !yn.Key.ToString().Equals("N"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSelect y/n.");
                Console.ForegroundColor = defaultColor;
                goto loopAdvancements;
            }

            //delete
            if (yn.Key.ToString().Equals("Y"))
            {
                Directory.Delete(Path.Combine(path, advancements), true);
                Console.WriteLine(advancements + " has been delete.");
            }

        //label
        loopData:

            //skip
            if (!exists[1]) { goto loopDataPacks; }

            //ask
            Console.WriteLine
                ("Do you Delete " +
                data +
                " File? (y/n)");
            yn = Console.ReadKey();

            Console.WriteLine("");

            //loop
            if (!yn.Key.ToString().Equals("Y") &&
            !yn.Key.ToString().Equals("N"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSelect y/n.");
                Console.ForegroundColor = defaultColor;
                goto loopData;
            }

            //delete
            if (yn.Key.ToString().Equals("Y"))
            {
                foreach (string file in Directory.GetFiles(Path.Combine(path, data)))
                {
                    Console.WriteLine
                        ("Do you Delete " +
                        file +
                        " ?(y/n)");
                    yn = Console.ReadKey();
                    Console.WriteLine("");
                    if (yn.Key.ToString().Equals("Y"))
                    {
                        File.Delete(file);
                        Console.WriteLine(file + " has been delete.");
                    }
                }

                if (0 <= Directory.GetDirectories(Path.Combine(path, data)).Length)
                {
                    Directory.Delete(Path.Combine(path, data), true);
                    Console.WriteLine("The data folder is now empty and has been deleted.");
                }
            }

        //label
        loopDataPacks:

            //skip
            if (!exists[2]) { goto loopDIM1; }

            //ask
            Console.WriteLine
                ("Do you Delete " +
                datapacks +
                " File? (y/n)");
            yn = Console.ReadKey();

            Console.WriteLine("");

            //loop
            if (!yn.Key.ToString().Equals("Y") &&
            !yn.Key.ToString().Equals("N"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSelect y/n.");
                Console.ForegroundColor = defaultColor;
                goto loopDataPacks;
            }

            //delete
            if (yn.Key.ToString().Equals("Y"))
            {
                foreach (string dir in Directory.GetDirectories(Path.Combine(path, datapacks)))
                {
                    Console.WriteLine
                        ("Do you Delete " +
                        dir +
                        " ?(y/n)");
                    yn = Console.ReadKey();
                    Console.WriteLine("");
                    if (yn.Key.ToString().Equals("Y"))
                    {
                        Directory.Delete(dir, true);
                        Console.WriteLine(dir + " has been delete.");
                    }
                }

                if (0 <= Directory.GetDirectories(Path.Combine(path, datapacks)).Length)
                {
                    Directory.Delete(Path.Combine(path, datapacks), true);
                    Console.WriteLine("The datapacks folder is now empty and has been deleted.");
                }
            }

        //label
        loopDIM1:

            //skip
            if (!exists[3]) { goto loopDIM_1; }

            //ask
            Console.WriteLine
                ("Do you Delete " +
                DIM1 +
                " File? (y/n)");
            yn = Console.ReadKey();

            Console.WriteLine("");

            //loop
            if (!yn.Key.ToString().Equals("Y") &&
            !yn.Key.ToString().Equals("N"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSelect y/n.");
                Console.ForegroundColor = defaultColor;
                goto loopDIM1;
            }

            //delete
            if (yn.Key.ToString().Equals("Y"))
            {
                Directory.Delete(Path.Combine(path, DIM1), true);
                Console.WriteLine(DIM1 + " has been delete.");
            }

        //looplabel
        loopDIM_1:

            //skip
            if (!exists[4]) { goto loopPlayerData; }

            //ask
            Console.WriteLine
                ("Do you Delete " +
                DIM_1 +
                " File? (y/n)");
            yn = Console.ReadKey();

            Console.WriteLine("");

            //loop
            if (!yn.Key.ToString().Equals("Y") &&
            !yn.Key.ToString().Equals("N"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSelect y/n.");
                Console.ForegroundColor = defaultColor;
                goto loopDIM_1;
            }

            //delete
            if (yn.Key.ToString().Equals("Y"))
            {
                Directory.Delete(Path.Combine(path, DIM_1), true);
                Console.WriteLine(DIM_1 + " has been delete.");
            }

        //looplabel
        loopPlayerData:

            //skip
            if (!exists[5]) { goto loopPoi; }

            //ask
            Console.WriteLine
                ("Do you Delete " +
                playerdata +
                " File? (y/n)");
            yn = Console.ReadKey();

            Console.WriteLine("");

            //loop
            if (!yn.Key.ToString().Equals("Y") &&
            !yn.Key.ToString().Equals("N"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSelect y/n.");
                Console.ForegroundColor = defaultColor;
                goto loopPlayerData;
            }

            //delete
            if (yn.Key.ToString().Equals("Y"))
            {
                Directory.Delete(Path.Combine(path, playerdata), true);
                Console.WriteLine(playerdata + " has been delete.");
            }

        //looplabel
        loopPoi:

            //skip
            if (!exists[6]) { goto loopStats; }

            //ask
            Console.WriteLine
                ("Do you Delete " +
                poi +
                " File? (y/n)");
            yn = Console.ReadKey();

            Console.WriteLine("");

            //loop
            if (!yn.Key.ToString().Equals("Y") &&
            !yn.Key.ToString().Equals("N"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSelect y/n.");
                Console.ForegroundColor = defaultColor;
                goto loopPoi;
            }

            //delete
            if (yn.Key.ToString().Equals("Y"))
            {
                Directory.Delete(Path.Combine(path, poi), true);
                Console.WriteLine(poi + " has been delete.");
            }

        //looplabel
        loopStats:

            //skip
            if (!exists[7]) { goto loopLevel; }

            //ask
            Console.WriteLine
                ("Do you Delete " +
                stats +
                " File? (y/n)");
            yn = Console.ReadKey();

            Console.WriteLine("");

            //loop
            if (!yn.Key.ToString().Equals("Y") &&
            !yn.Key.ToString().Equals("N"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSelect y/n.");
                Console.ForegroundColor = defaultColor;
                goto loopStats;
            }

            //delete
            if (yn.Key.ToString().Equals("Y"))
            {
                Directory.Delete(Path.Combine(path, stats), true);
                Console.WriteLine(stats + " has been delete.");
            }

        //looplabel
        loopLevel:

            //skip
            if (!exists[8]) { goto loopSession; }

            //ask
            Console.WriteLine
                ("Do you Delete " +
                level_dat_old +
                " File? (y/n)");
            yn = Console.ReadKey();

            Console.WriteLine("");

            //loop
            if (!yn.Key.ToString().Equals("Y") &&
            !yn.Key.ToString().Equals("N"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSelect y/n.");
                Console.ForegroundColor = defaultColor;
                goto loopLevel;
            }

            //delete
            if (yn.Key.ToString().Equals("Y"))
            {
                File.Delete(Path.Combine(path, level_dat_old));
                Console.WriteLine(level_dat_old + " has been delete.");
            }

        //looplabel
        loopSession:

            //skip
            if (!exists[9]) { goto zip; }

            //ask
            Console.WriteLine
                ("Do you Delete " +
                session_lock +
                " File? (y/n)");
            yn = Console.ReadKey();

            Console.WriteLine("");

            //loop
            if (!yn.Key.ToString().Equals("Y") &&
            !yn.Key.ToString().Equals("N"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSelect y/n.");
                Console.ForegroundColor = defaultColor;
                goto loopSession;
            }

            //delete
            if (yn.Key.ToString().Equals("Y"))
            {
                File.Delete(Path.Combine(path, session_lock));
                Console.WriteLine(session_lock + " has been delete.");
            }

        //label
        zip:
            Liquidation.StartZip(path);
        }
    }
}
