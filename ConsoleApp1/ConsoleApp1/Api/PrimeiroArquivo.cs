using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api
{
    class PrimeiroArquivo
    {
        public static class ExtensaoString
        {
            public static string ParseHome(this string path)
            {
                string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                    Environment.OSVersion.Platform == PlatformID.MacOSX)
                    ? Environment.GetEnvironmentVariable("HOME")
                    : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
                return path.Replace("~", home);

            }
        }


        public static void Executar()
        {
            var path = @"~/primwiro_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {

                }
            }
        }
    }
}
