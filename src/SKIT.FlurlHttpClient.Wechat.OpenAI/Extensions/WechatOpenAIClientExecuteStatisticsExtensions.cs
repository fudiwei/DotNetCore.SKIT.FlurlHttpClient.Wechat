using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    public static class WechatOpenAIClientExecuteStatisticsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /v2/dialog_user_specified_date 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/statistic/dialog_user_specified_date.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DialogUserSpecifiedDateResponse> ExecuteDialogUserSpecifiedDateAsync(this WechatOpenAIClient client, Models.DialogUserSpecifiedDateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "dialog_user_specified_date");

            return await client.SendRequestWithJsonAsync<Models.DialogUserSpecifiedDateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/user_query_yesterday_data 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/statistic/user_query_yesterday_data.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UserQueryYesterdayDataResponse> ExecuteUserQueryYesterdayDataAsync(this WechatOpenAIClient client, Models.UserQueryYesterdayDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "user_query_yesterday_data");

            return await client.SendRequestWithJsonAsync<Models.UserQueryYesterdayDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
