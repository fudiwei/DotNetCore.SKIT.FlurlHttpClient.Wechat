using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecutePayMarketingTransfersRedPackExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /mmpaymkttransfers/sendredpack 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011983137 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendPayMarketingTransfersRedPackResponse> ExecuteSendPayMarketingTransfersRedPackAsync(this WechatTenpayClient client, Models.SendPayMarketingTransfersRedPackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mmpaymkttransfers", "sendredpack");

            return await client.SendFlurlRequestAsXmlAsync<Models.SendPayMarketingTransfersRedPackResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mmpaymkttransfers/sendminiprogramhb 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011974053 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011937425 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011941282 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendPayMarketingTransfersMiniProgramRedPackResponse> ExecuteSendPayMarketingTransfersMiniProgramRedPackAsync(this WechatTenpayClient client, Models.SendPayMarketingTransfersMiniProgramRedPackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mmpaymkttransfers", "sendminiprogramhb");

            return await client.SendFlurlRequestAsXmlAsync<Models.SendPayMarketingTransfersMiniProgramRedPackResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mmpaymkttransfers/gethbinfo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011981612 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011937431 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011983160 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/partner/4011941290 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayMarketingTransfersRedPackInfoResponse> ExecuteGetPayMarketingTransfersRedPackInfoAsync(this WechatTenpayClient client, Models.GetPayMarketingTransfersRedPackInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mmpaymkttransfers", "gethbinfo");

            return await client.SendFlurlRequestAsXmlAsync<Models.GetPayMarketingTransfersRedPackInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region WeWork
        /// <summary>
        /// <para>异步调用 [POST] /mmpaymkttransfers/sendworkwxredpack 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://open.work.weixin.qq.com/api/doc/90000/90135/90275 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendPayMarketingTransfersWeWorkRedPackResponse> ExecuteSendPayMarketingTransfersWeWorkRedPackAsync(this WechatTenpayClient client, Models.SendPayMarketingTransfersWeWorkRedPackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.WeWorkSign is null)
            {
                if (request.MerchantId is null)
                {
                    request.MerchantId = client.Credentials.MerchantId;
                }

                if (request.AppId is null)
                {
                    request.AppId = client.Credentials.AppId;
                }

                if (request.NonceString is null)
                {
                    request.NonceString = Guid.NewGuid().ToString("N");
                }

                request.WeWorkSign = Utilities.RequestSigner.Sign(
                    paramsMap: new Dictionary<string, string?>()
                    {
                        { "act_name", request.ActivityName },
                        { "mch_billno", request.MerchantBillNumber },
                        { "mch_id", request.MerchantId },
                        { "nonce_str", request.NonceString },
                        { "re_openid", request.OpenId },
                        { "total_amount", request.TotalAmount.ToString() },
                        { "wxappid", request.AppId }
                    },
                    secretKey: "secret",
                    secretValue: client.Credentials.WeWorkPaymentSecret!,
                    signType: Constants.SignTypes.MD5
                );
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mmpaymkttransfers", "sendworkwxredpack");

            return await client.SendFlurlRequestAsXmlAsync<Models.SendPayMarketingTransfersWeWorkRedPackResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mmpaymkttransfers/queryworkwxredpack 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90276 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayMarketingTransfersWeWorkRedPackResponse> ExecuteGetPayMarketingTransfersWeWorkRedPackAsync(this WechatTenpayClient client, Models.GetPayMarketingTransfersWeWorkRedPackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mmpaymkttransfers", "queryworkwxredpack");

            return await client.SendFlurlRequestAsXmlAsync<Models.GetPayMarketingTransfersWeWorkRedPackResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
