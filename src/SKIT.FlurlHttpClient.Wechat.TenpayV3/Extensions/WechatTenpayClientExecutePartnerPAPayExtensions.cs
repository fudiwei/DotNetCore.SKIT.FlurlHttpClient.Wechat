using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecutePartnerPAPayExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /partner-papay/contracts/{contract_id}/notify 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011988373 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePartnerPAPayContractNotificationResponse> ExecuteCreatePartnerPAPayContractNotificationAsync(this WechatTenpayClient client, Models.CreatePartnerPAPayContractNotificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "partner-papay", "contracts", request.ContractId, "notify");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePartnerPAPayContractNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /partner-papay/contracts/{contract_id}/fail-notify 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay_v2/papay/chapter5_16.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePartnerPAPayContractFailedNotificationResponse> ExecuteCreatePartnerPAPayContractFailedNotificationAsync(this WechatTenpayClient client, Models.CreatePartnerPAPayContractFailedNotificationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "partner-papay", "contracts", request.ContractId, "fail-notify");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePartnerPAPayContractFailedNotificationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
