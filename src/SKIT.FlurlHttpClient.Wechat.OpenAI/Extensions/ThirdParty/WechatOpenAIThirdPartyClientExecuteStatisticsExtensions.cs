using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    public static class WechatOpenAIThirdPartyClientExecuteStatisticsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /v2/dialog_user_specified_date 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/statistic/dialog_user_specified_date.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ThirdParty.DialogUserSpecifiedDateResponse> ExecuteDialogUserSpecifiedDateAsync(this WechatOpenAIThirdPartyClient client, Models.ThirdParty.DialogUserSpecifiedDateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "dialog_user_specified_date");

            return await client.SendRequestWithJsonAsync<Models.ThirdParty.DialogUserSpecifiedDateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/user_query_yesterday_data 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/statistic/user_query_yesterday_data.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ThirdParty.UserQueryYesterdayDataResponse> ExecuteUserQueryYesterdayDataAsync(this WechatOpenAIThirdPartyClient client, Models.ThirdParty.UserQueryYesterdayDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "user_query_yesterday_data");

            return await client.SendRequestWithJsonAsync<Models.ThirdParty.UserQueryYesterdayDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
