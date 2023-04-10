using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    public static class WechatTenpayBusinessClientExecuteFileUploadsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /mse-pay/file-uploads 接口。</para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E6%96%87%E4%BB%B6%E4%B8%8A%E4%BC%A0 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadFileResponse> ExecuteUploadFileAsync(this WechatTenpayBusinessClient client, Models.UploadFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName == null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".png";

            if (request.FileHash == null)
                request.FileHash = BitConverter.ToString(Utilities.SM3Utility.Hash(request.FileBytes)).Replace("-", string.Empty).ToLower();

            if (request.FileContentType == null)
                request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForImage(request.FileName!) ?? "image/png";

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mse-pay", "file-uploads");

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, fileMetaJson: client.JsonSerializer.Serialize(request));
            return await client.SendRequestAsync<Models.UploadFileResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }
    }
}
