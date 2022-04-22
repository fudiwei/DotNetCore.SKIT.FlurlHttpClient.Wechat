using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.Work.Utilities
{
    internal static class FileHttpContentBuilder
    {
        public static MultipartFormDataContent Build(string fileName, byte[] fileBytes, string fileContentType, string formDataName)
        {
            return Build(fileName: fileName, fileBytes: fileBytes, fileContentType: fileContentType, formDataName: formDataName, (_) => { });
        }

        public static MultipartFormDataContent Build(string fileName, byte[] fileBytes, string fileContentType, string formDataName, Action<HttpContent> configureFileHttpContent)
        {
            if (fileName == null) throw new ArgumentNullException(nameof(fileName));
            if (formDataName == null) throw new ArgumentNullException(nameof(formDataName));
            if (configureFileHttpContent == null) throw new ArgumentNullException(nameof(configureFileHttpContent));

            fileName = fileName.Replace("\"", "");
            fileBytes = fileBytes ?? Array.Empty<byte>();
            fileContentType = string.IsNullOrEmpty(fileContentType) ? "application/octet-stream" : fileContentType;
            formDataName = formDataName.Replace("\"", "");

            // HACKED: 默认不支持 Unicode 文件名 https://github.com/dotnet/runtime/issues/22996
            byte[] bytesFileName = Encoding.UTF8.GetBytes(fileName);
            char[] bytesHackedFileName = new char[bytesFileName.Length];
            Array.Copy(bytesFileName, 0, bytesHackedFileName, 0, bytesFileName.Length);
            string hackedFileName = new string(bytesHackedFileName);

            ByteArrayContent fileContent = new ByteArrayContent(fileBytes);
            fileContent.Headers.ContentDisposition = ContentDispositionHeaderValue.Parse($"form-data; name=\"{formDataName}\"; filename=\"{hackedFileName}\"");
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(fileContentType);
            fileContent.Headers.ContentLength = fileBytes.Length;
            configureFileHttpContent(fileContent);

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            MultipartFormDataContent httpContent = new MultipartFormDataContent(boundary);
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse($"multipart/form-data; boundary={boundary}");
            httpContent.Add(fileContent);
            return httpContent;
        }
    }
}
