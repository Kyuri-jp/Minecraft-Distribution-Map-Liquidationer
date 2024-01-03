namespace MinecraftDistributionMapLiquidationer.Programs
{
    internal class LevelFileNotFound : Exception
    { }

    internal class SelectFolder
    {
        private const string level_dat = "level.dat";

        internal string ReadFolderPath()
        {
            //ask
            Console.WriteLine("Write Target Folder Path.");

            string? folderPath = Console.ReadLine();

            //exceptions
            if (!Directory.Exists(folderPath))
            {
                throw new DirectoryNotFoundException();
            }
            if (!File.Exists(Path.Combine(folderPath, level_dat)))
            {
                throw new LevelFileNotFound();
            }
            return folderPath ?? throw new NullReferenceException();
        }
    }
}