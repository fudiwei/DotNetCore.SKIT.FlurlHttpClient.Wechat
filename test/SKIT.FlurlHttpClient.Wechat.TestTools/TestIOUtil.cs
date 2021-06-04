using System;
using System.Collections.Generic;
using System.IO;

namespace SKIT.FlurlHttpClient.Wechat
{
    public static class TestIOUtil
    {
        public static string[] GetAllFiles(string path)
        {
            if (path == null) throw new ArgumentNullException(nameof(path));

            List<string> results = new List<string>();
            string[] dirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            results.AddRange(files);

            foreach (string dir in dirs)
            {
                results.AddRange(GetAllFiles(dir));
            }

            return results.ToArray();
        }
    }
}
