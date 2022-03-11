using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecuteMerchantMediaExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /secapi/mch/uploadmedia 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/tool/chapter3_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadMerchantMediaResponse> ExecuteUploadMerchantMediaAsync(this WechatTenpayClient client, Models.UploadMerchantMediaRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName == null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";

            if (request.FileHash == null)
                request.FileHash = BitConverter.ToString(Utilities.MD5Utility.Hash(request.FileBytes ?? Array.Empty<byte>())).Replace("-", "").ToLower();

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "secapi", "mch", "uploadmedia");

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            string sign = Utilities.RequestSigner.Sign(new Dictionary<string, string?>() { { "mch_id", client.Credentials.MerchantId }, { "media_hash", request.FileHash } }, client.Credentials.MerchantSecret, Constants.SignTypes.MD5);
            using var fileContent = new ByteArrayContent(request.FileBytes ?? Array.Empty<byte>());
            using var httpContent = new MultipartFormDataContent(boundary);
            httpContent.Add(fileContent, "\"media\"", $"\"{HttpUtility.UrlEncode(request.FileName)}\"");
            httpContent.Add(new StringContent(client.Credentials.MerchantId, Encoding.UTF8), $"\"mch_id\"");
            httpContent.Add(new StringContent(request.FileHash, Encoding.UTF8), $"\"media_hash\"");
            httpContent.Add(new StringContent(sign, Encoding.UTF8), $"\"sign\"");
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg");
            fileContent.Headers.ContentLength = request.FileBytes?.Length;

            return await client.SendRequestAsync<Models.UploadMerchantMediaResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }
    }
}
