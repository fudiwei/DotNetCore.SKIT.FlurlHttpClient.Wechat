namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static partial class WechatTenpayClientExecutePartnerExtensions
    {
        #region Exposure
        /// <summary>
        /// <para>异步调用 [POST] /pay/instal/partner/exposure 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016196820 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayPartnerInstallmentExposureResponse> ExecuteCreatePayPartnerInstallmentExposureAsync(this WechatTenpayClient client, Models.CreatePayPartnerInstallmentExposureRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
            {
                request.MerchantId = client.Credentials.MerchantId;
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pay", "instal", "partner", "exposure");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePayPartnerInstallmentExposureResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
