namespace MinecraftDistributionMapLiquidationer.Programs
{
    internal class SelectFolder
    {
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
            return folderPath ?? throw new NullReferenceException();
        }
    }
}