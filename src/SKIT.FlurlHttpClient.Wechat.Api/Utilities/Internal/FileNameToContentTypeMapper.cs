using System.IO;

namespace SKIT.FlurlHttpClient.Wechat.Api.Utilities
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
                    return "image/bmp";
            }

            return null;
        }

        public static string? GetContentTypeForVoice(string fileName)
        {
            string extension = Path.GetExtension(fileName ?? "/")?.ToLower() ?? string.Empty;
            switch (extension)
            {
                case ".mp3":
                    return "audio/mpeg";
                case ".amr":
                    return "audio/amr";
            }

            return null;
        }

        public static string? GetContentTypeForVideo(string fileName)
        {
            string extension = Path.GetExtension(fileName ?? "/")?.ToLower() ?? string.Empty;
            switch (extension)
            {
                case ".mp4":
                    return "video/mp4";
            }

            return null;
        }
    }
}
