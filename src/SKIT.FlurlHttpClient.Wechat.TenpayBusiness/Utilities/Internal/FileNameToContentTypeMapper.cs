using System.IO;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Utilities
{
    internal static class FileNameToContentTypeMapper
    {
        public static string? GetContentTypeForImage(string fileName)
        {
            string extension = Path.GetExtension(fileName ?? "/")?.ToLower() ?? string.Empty;
            switch (extension)
            {
                case ".jpg":
                case ".jpeg":
                    return "image/jpeg";
                case ".bmp":
                    return "image/bmp";
                case ".png":
                    return "image/png";
            }

            return null;
        }
    }
}
