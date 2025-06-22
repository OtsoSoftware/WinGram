using System.IO;
using System;

namespace WinGram
{
    internal static class Stor
    {
        public static readonly string appFolder = Program.IsPortable ? Path.Combine(AppContext.BaseDirectory, "WinGram_Data") : Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WinGram");
        public static readonly string configFolder = Path.Combine(appFolder, "config");
        public static readonly string configPath = Path.Combine(configFolder, "default.ini");
        public static readonly string cacheFolder = Path.Combine(appFolder, "cache");
        public static readonly string downloadsFolder = Path.Combine(appFolder, "Downloads");


        public static readonly string imageExt = ".photo";


        public static void CreateCrucialDirectories()
        {
            try
            {
                Directory.CreateDirectory(appFolder);
                Directory.CreateDirectory(configFolder);
                Directory.CreateDirectory(cacheFolder);
                Directory.CreateDirectory(downloadsFolder);
            }
            catch
            {
            }
        }
    }
}