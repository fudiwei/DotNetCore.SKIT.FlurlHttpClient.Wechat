using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;
using SKIT.FlurlHttpClient.Wechat.TenpayV2.Settings;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecutePayMarketingTransfersRedPackExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /mmpaymkttransfers/sendredpack 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon.php?chapter=13_4 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon_sl.php?chapter=13_4 ]]>
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

            return await client.SendFlurlRequestAsXmlAsync<Models.SendPayMarketingTransfersRedPackResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mmpaymkttransfers/sendgroupredpack 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon.php?chapter=13_5 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon_sl.php?chapter=13_5 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendPayMarketingTransfersGroupRedPackResponse> ExecuteSendPayMarketingTransfersGroupRedPackAsync(this WechatTenpayClient client, Models.SendPayMarketingTransfersGroupRedPackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mmpaymkttransfers", "sendgroupredpack");

            return await client.SendFlurlRequestAsXmlAsync<Models.SendPayMarketingTransfersGroupRedPackResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mmpaymkttransfers/sendminiprogramhb 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon_xcx.php?chapter=18_2 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon_sl.php?chapter=18_2 ]]>
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

            return await client.SendFlurlRequestAsXmlAsync<Models.SendPayMarketingTransfersMiniProgramRedPackResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mmpaymkttransfers/gethbinfo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon.php?chapter=13_6 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon_xcx.php?chapter=18_6 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon_sl.php?chapter=13_6 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon_sl.php?chapter=18_6 ]]>
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

            return await client.SendFlurlRequestAsXmlAsync<Models.GetPayMarketingTransfersRedPackInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region WeWork
        /// <summary>
        /// <para>异步调用 [POST] /mmpaymkttransfers/sendworkwxredpack 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/96697 ]]>
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

            return await client.SendFlurlRequestAsXmlAsync<Models.SendPayMarketingTransfersWeWorkRedPackResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
