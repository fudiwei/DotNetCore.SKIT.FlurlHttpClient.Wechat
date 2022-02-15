using System.IO;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Utilities
{
    internal static class FileNameToContentTypeMapper
    {
        public static string? GetContentTypeForImage(string fileName)
        {
            string extension = Path.GetExtension(fileName ?? "/")?.ToLower() ?? string.Empty;
            switch (extension)
            {
                case ".swf":
                    return "application/x-shockwave-flash";
                case ".jpg":
                case ".jpeg":
                    return "image/jpeg";
                case ".gif":
                    return "image/gif";
                case ".png":
                    return "image/png";
            }

            return null;
        }
    }
}
