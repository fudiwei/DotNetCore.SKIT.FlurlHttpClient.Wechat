using System.IO;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Utilities
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

        public static string? GetContentTypeForVideo(string fileName)
        {
            string extension = Path.GetExtension(fileName ?? "/")?.ToLower() ?? string.Empty;
            switch (extension)
            {
                case ".avi":
                    return "video/x-msvideo";
                case ".wmv":
                    return "video/x-ms-wmv";
                case ".mpeg":
                    return "video/mpeg";
                case ".mov":
                    return "video/quicktime";
                case ".mkv":
                    return "video/mkv";
                case ".m4v":
                    return "video/x-m4v";
                case ".flv":
                    return "video/x-flv";
                case ".f4v":
                    return "video/x-f4v";
                case ".rmvb":
                    return "video/vnd.rn-realvideo";
                case ".mp4":
                    return "video/mp4";
            }

            return null;
        }
    }
}
