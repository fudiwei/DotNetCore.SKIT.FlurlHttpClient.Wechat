using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecutePayAcquiringBankTransactionsExtensions
    {
        #region Exposure
        /// <summary>
        /// <para>异步调用 [POST] /pay/acquiring-bank/transactions/exposure 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014326541 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayAcquiringBankTransactionExposureResponse> ExecuteCreatePayAcquiringBankTransactionExposureAsync(this WechatTenpayClient client, Models.CreatePayAcquiringBankTransactionExposureRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pay", "acquiring-bank", "transactions", "exposure");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePayAcquiringBankTransactionExposureResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
