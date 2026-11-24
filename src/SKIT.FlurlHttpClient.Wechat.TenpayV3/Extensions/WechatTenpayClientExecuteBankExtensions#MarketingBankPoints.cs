namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static partial class WechatTenpayClientExecuteBankExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /marketing/bank-points/activity/{activity_id}/users/remove 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/institution/4020978687 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RemoveMarketingBankPointsActivityUsersResponse> ExecuteRemoveMarketingBankPointsActivityUsersAsync(this WechatTenpayClient client, Models.RemoveMarketingBankPointsActivityUsersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            Utilities.HttpRequestGuard.AgainstEmptyPathVariable(request.ActivityId, "activity_id");

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "bank-points", "activity", request.ActivityId!, "users", "remove");

            return await client.SendFlurlRequestAsJsonAsync<Models.RemoveMarketingBankPointsActivityUsersResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
