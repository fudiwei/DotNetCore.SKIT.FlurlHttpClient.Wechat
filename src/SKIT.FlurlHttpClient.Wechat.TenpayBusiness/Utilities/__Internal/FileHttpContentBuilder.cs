using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Utilities
{
    internal static class FileHttpContentBuilder
    {
        public static MultipartFormDataContent Build(string fileName, byte[] fileBytes, string fileContentType, string fileMetaJson, string formDataName = "file")
        {
            return Build(fileName: fileName, fileBytes: fileBytes, fileContentType: fileContentType, fileMetaJson: fileMetaJson, formDataName: formDataName, (_) => { }, (_) => { });
        }

        public static MultipartFormDataContent Build(string fileName, byte[] fileBytes, string fileContentType, string fileMetaJson, string formDataName, Action<HttpContent> configureMetaHttpContent, Action<HttpContent> configureFileHttpContent)
        {
            if (fileName is null) throw new ArgumentNullException(nameof(fileName));
            if (fileMetaJson is null) throw new ArgumentNullException(nameof(fileMetaJson));
            if (formDataName is null) throw new ArgumentNullException(nameof(formDataName));
            if (configureFileHttpContent is null) throw new ArgumentNullException(nameof(configureFileHttpContent));

            fileBytes = fileBytes ?? Array.Empty<byte>();
            fileContentType = string.IsNullOrEmpty(fileContentType) ? "application/octet-stream" : fileContentType;
            formDataName = formDataName.Replace("\"", string.Empty);

            ByteArrayContent metaContent = new ByteArrayContent(Encoding.UTF8.GetBytes(fileMetaJson));
            metaContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            configureMetaHttpContent(metaContent);

            ByteArrayContent fileContent = new ByteArrayContent(fileBytes);
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(fileContentType);
            configureFileHttpContent(fileContent);

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            MultipartFormDataContent httpContent = new MultipartFormDataContent(boundary);
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse($"multipart/form-data; boundary={boundary}");
            httpContent.Add(metaContent, $"\"{Constants.FormDataFields.FORMDATA_META}\"");
            httpContent.Add(fileContent, $"\"{formDataName}\"", $"\"{HttpUtility.UrlEncode(fileName)}\"");
            return httpContent;
        }
    }
}
