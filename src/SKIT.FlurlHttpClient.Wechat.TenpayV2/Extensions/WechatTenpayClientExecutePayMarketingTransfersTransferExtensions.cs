using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecutePayMarketingTransfersTransferExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /mmpaymkttransfers/promotion/transfers 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011989673 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayMarketingTransfersPromotionTransferResponse> ExecuteCreatePayMarketingTransfersPromotionTransferAsync(this WechatTenpayClient client, Models.CreatePayMarketingTransfersPromotionTransferRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mmpaymkttransfers", "promotion", "transfers");

            return await client.SendFlurlRequestAsXmlAsync<Models.CreatePayMarketingTransfersPromotionTransferResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mmpaymkttransfers/gettransferinfo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v2/merchant/4011989767 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayMarketingTransfersTransferInfoResponse> ExecuteGetPayMarketingTransfersTransferInfoAsync(this WechatTenpayClient client, Models.GetPayMarketingTransfersTransferInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mmpaymkttransfers", "gettransferinfo");

            return await client.SendFlurlRequestAsXmlAsync<Models.GetPayMarketingTransfersTransferInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region WeWork
        /// <summary>
        /// <para>异步调用 [POST] /mmpaymkttransfers/promotion/paywwsptrans2pocket 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://open.work.weixin.qq.com/api/doc/90000/90135/90278 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePayMarketingTransfersPromotionWeWorkTransferResponse> ExecuteCreatePayMarketingTransfersPromotionWeWorkTransferAsync(this WechatTenpayClient client, Models.CreatePayMarketingTransfersPromotionWeWorkTransferRequest request, CancellationToken cancellationToken = default)
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
                        { "amount", request.Amount.ToString() },
                        { "appid", request.AppId },
                        { "desc", request.Description },
                        { "mch_id", request.MerchantId },
                        { "nonce_str", request.NonceString },
                        { "openid", request.OpenId },
                        { "partner_trade_no", request.PartnerTradeNumber },
                        { "ww_msg_type", request.MessageType }
                    },
                    secretKey: "secret",
                    secretValue: client.Credentials.WeWorkPaymentSecret!,
                    signType: Constants.SignTypes.MD5
                );
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mmpaymkttransfers", "promotion", "paywwsptrans2pocket");

            return await client.SendFlurlRequestAsXmlAsync<Models.CreatePayMarketingTransfersPromotionWeWorkTransferResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
