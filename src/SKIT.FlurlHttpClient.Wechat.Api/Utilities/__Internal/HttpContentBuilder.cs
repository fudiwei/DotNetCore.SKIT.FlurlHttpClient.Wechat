using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.Api.Utilities
{
    using SKIT.FlurlHttpClient;

    internal static class HttpContentBuilder
    {
        public static MultipartFormDataContent BuildWithFile(string fileName, byte[] fileBytes, string? fileContentType, string formDataName, Action<HttpContent>? configureFileHttpContent = null)
        {
            if (fileName is null) throw new ArgumentNullException(nameof(fileName));
            if (formDataName is null) throw new ArgumentNullException(nameof(formDataName));

            fileName = fileName.Replace("\"", string.Empty);
            fileBytes = fileBytes ?? Array.Empty<byte>();
            fileContentType = string.IsNullOrEmpty(fileContentType) ? MimeTypes.Binary : fileContentType;
            formDataName = formDataName.Replace("\"", string.Empty);

            // HACKED: 默认不支持 Unicode 文件名 https://github.com/dotnet/runtime/issues/22996
            byte[] bytesFileName = Encoding.UTF8.GetBytes(fileName);
            char[] bytesHackedFileName = new char[bytesFileName.Length];
            Array.Copy(bytesFileName, 0, bytesHackedFileName, 0, bytesFileName.Length);
            string hackedFileName = new string(bytesHackedFileName);

            ByteArrayContent fileContent = new ByteArrayContent(fileBytes);
            fileContent.Headers.ContentDisposition = ContentDispositionHeaderValue.Parse($"form-data; name=\"{formDataName}\"; filename=\"{hackedFileName}\"");
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(fileContentType);
            fileContent.Headers.ContentLength = fileBytes.Length;
            configureFileHttpContent?.Invoke(fileContent);

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            MultipartFormDataContent httpContent = new MultipartFormDataContent(boundary);
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse($"{MimeTypes.FormData}; boundary={boundary}");
            httpContent.Add(fileContent);
            return httpContent;
        }
    }
}
