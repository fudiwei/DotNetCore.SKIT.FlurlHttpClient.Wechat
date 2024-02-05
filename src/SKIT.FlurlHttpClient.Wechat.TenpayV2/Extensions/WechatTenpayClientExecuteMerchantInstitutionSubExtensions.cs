using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecuteMerchantInstitutionSubExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /secapi/mch/addInstitutionsub 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/sub_merchant_entry/chapter3_1.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddSubMerchantInstitutionResponse> ExecuteAddSubMerchantInstitutionAsync(this WechatTenpayClient client, Models.AddSubMerchantInstitutionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "secapi", "mch", "addInstitutionsub");

            return await client.SendFlurlRequestAsXmlAsync<Models.AddSubMerchantInstitutionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /secapi/mch/queryInstitutionsub 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/sub_merchant_entry/chapter3_2.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetSubMerchantInstitutionResponse> ExecuteGetSubMerchantInstitutionAsync(this WechatTenpayClient client, Models.GetSubMerchantInstitutionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "secapi", "mch", "queryInstitutionsub");

            return await client.SendFlurlRequestAsXmlAsync<Models.GetSubMerchantInstitutionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /secapi/mch/modifyInstitutionsub 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/sub_merchant_entry/chapter3_3.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ModifySubMerchantInstitutionResponse> ExecuteModifySubMerchantInstitutionAsync(this WechatTenpayClient client, Models.ModifySubMerchantInstitutionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "secapi", "mch", "modifyInstitutionsub");

            return await client.SendFlurlRequestAsXmlAsync<Models.ModifySubMerchantInstitutionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
