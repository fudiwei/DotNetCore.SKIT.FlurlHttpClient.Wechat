namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global
{
    using SKIT.FlurlHttpClient;
    using SKIT.FlurlHttpClient.Primitives;

    public static partial class WechatTenpayGlobalClientExecutePartnerExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /merchants 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356964 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddSubMerchantResponse> ExecuteAddSubMerchantAsync(this WechatTenpayGlobalClient client, Models.AddSubMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
            {
                request.MerchantId = client.Credentials.MerchantId;
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "merchants")
                .WithHeader("Idempotency-Key", request.IdempotencyKey);

            return await client.SendFlurlRequestAsJsonAsync<Models.AddSubMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchants/{sub_mchid} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356965 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetSubMerchantResponse> ExecuteGetSubMerchantAsync(this WechatTenpayGlobalClient client, Models.GetSubMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            Utilities.HttpRequestGuard.AgainstEmptyPathVariable(request.SubMerchantId, "sub_mchid");

            if (request.MerchantId is null)
            {
                request.MerchantId = client.Credentials.MerchantId;
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "merchants", request.SubMerchantId!)
                .SetQueryParam("sp_mchid", request.MerchantId)
                .SetQueryParam("sp_appid", request.AppId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetSubMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /merchants 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356969 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ModifySubMerchantResponse> ExecuteModifySubMerchantAsync(this WechatTenpayGlobalClient client, Models.ModifySubMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
            {
                request.MerchantId = client.Credentials.MerchantId;
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Put, "merchants");

            return await client.SendFlurlRequestAsJsonAsync<Models.ModifySubMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/media/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356972 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadMerchantMediaImageResponse> ExecuteUploadMerchantMediaImageAsync(this WechatTenpayClient client, Models.UploadMerchantMediaImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName is null)
            {
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".jpg";
            }

            if (request.FileContentType is null)
            {
                request.FileContentType = MimeTypes.GetMimeMapping(request.FileName);
            }

            if (request.FileHash is null)
            {
                if (request.FileBytes is not null)
                {
                    request.FileHash = EncodedString.ToHexString(Utilities.SHA256Utility.Hash(request.FileBytes)).Value!.ToLower();
                }
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "merchant", "media", "upload");

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, fileMetaJson: client.JsonSerializer.Serialize(request));
            return await client.SendFlurlRequestAsync<Models.UploadMerchantMediaImageResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
