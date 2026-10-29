namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static partial class WechatTenpayClientExecutePartnerExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /rate-activity/applications 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012698774 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateRateActivityApplicationResponse> ExecuteCreateRateActivityApplicationAsync(this WechatTenpayClient client, Models.CreateRateActivityApplicationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "rate-activity", "applications");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateRateActivityApplicationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /rate-activity/applications/id/{application_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012471722 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetRateActivityApplicationByApplicationIdResponse> ExecuteGetRateActivityApplicationByApplicationIdAsync(this WechatTenpayClient client, Models.GetRateActivityApplicationByApplicationIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            Utilities.HttpRequestGuard.AgainstEmptyPathVariable(request.ApplicationId, "application_id");

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "rate-activity", "applications", "id", request.ApplicationId!);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetRateActivityApplicationByApplicationIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /rate-activity/applications/id/{application_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012698885 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateRateActivityApplicationResponse> ExecuteUpdateRateActivityApplicationAsync(this WechatTenpayClient client, Models.UpdateRateActivityApplicationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            Utilities.HttpRequestGuard.AgainstEmptyPathVariable(request.ApplicationId, "application_id");

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, new HttpMethod("PATCH"), "rate-activity", "applications", "id", request.ApplicationId!);

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateRateActivityApplicationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
