namespace MinecraftDistributionMapLiquidationer.Progresses.liquidation
{
    internal class Recommend : MDML
    {
        internal static void DoRecommend(string path, List<bool> exists)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            //pros
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
            if (exists[2] && 1 > Directory.GetDirectories(Path.Combine(path, datapacks)).Length)
            {
                Directory.Delete(Path.Combine(path, datapacks), true);
                Console.WriteLine(datapacks + " has been delete.");
            }
            if (exists[3] && 100 >= GetFolderSize(Path.Combine(path, DIM1)))
            {
                Directory.Delete(Path.Combine(path, DIM1), true);
                Console.WriteLine(DIM1 + " has been delete.");
            }
            if (exists[4] && 100 >= GetFolderSize(Path.Combine(path, DIM_1)))
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

            Liquidation.StartZip(path);
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
    }
}