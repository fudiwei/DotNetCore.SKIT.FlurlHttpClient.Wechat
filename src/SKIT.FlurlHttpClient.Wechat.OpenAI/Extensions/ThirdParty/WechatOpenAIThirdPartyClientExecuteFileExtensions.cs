using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    public static class WechatOpenAIThirdPartyClientExecuteFileExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /v1/file/upload 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v1/file_upload.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ThirdParty.FileUploadResponse> ExecuteFileUploadAsync(this WechatOpenAIThirdPartyClient client, Models.ThirdParty.FileUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName == null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".csv";

            if (request.FileContentType == null)
                request.FileContentType = "text/csv";

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v1", "file", "upload");

            using var fileContent = new ByteArrayContent(request.FileBytes ?? Array.Empty<byte>());
            using var httpContent = new MultipartFormDataContent();
            httpContent.Add(fileContent, "\"file\"", $"\"{HttpUtility.UrlEncode(request.FileName)}\"");
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.FileContentType);
            fileContent.Headers.ContentLength = request.FileBytes?.Length;

            return await client.SendRequestAsync<Models.ThirdParty.FileUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }
    }
}
