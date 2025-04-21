using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteFundAppExtensions
    {
        #region MerchantTransfer
        #region MerchantTransfer/Elecsign
        /// <summary>
        /// <para>异步调用 [POST] /fund-app/mch-transfer/elecsign/out-bill-no 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012716452 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateFundAppMerchantTransferElecsignByOutBillNumberResponse> ExecuteCreateFundAppMerchantTransferElecsignByOutBillNumberAsync(this WechatTenpayClient client, Models.CreateFundAppMerchantTransferElecsignByOutBillNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fund-app", "mch-transfer", "elecsign", "out-bill-no");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateFundAppMerchantTransferElecsignByOutBillNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fund-app/mch-transfer/elecsign/out-bill-no/{out_bill_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012716436 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetFundAppMerchantTransferElecsignByOutBillNumberResponse> ExecuteGetFundAppMerchantTransferElecsignByOutBillNumberAsync(this WechatTenpayClient client, Models.GetFundAppMerchantTransferElecsignByOutBillNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "fund-app", "mch-transfer", "elecsign", "out-bill-no", request.OutBillNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetFundAppMerchantTransferElecsignByOutBillNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fund-app/mch-transfer/elecsign/transfer-bill-no 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012716456 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateFundAppMerchantTransferElecsignByTransferBillNumberResponse> ExecuteCreateFundAppMerchantTransferElecsignByTransferBillNumberAsync(this WechatTenpayClient client, Models.CreateFundAppMerchantTransferElecsignByTransferBillNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fund-app", "mch-transfer", "elecsign", "transfer-bill-no");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateFundAppMerchantTransferElecsignByTransferBillNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fund-app/mch-transfer/elecsign/transfer-bill-no/{transfer_bill_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012716455 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetFundAppMerchantTransferElecsignByTransferBillNumberResponse> ExecuteGetFundAppMerchantTransferElecsignByTransferBillNumberAsync(this WechatTenpayClient client, Models.GetFundAppMerchantTransferElecsignByTransferBillNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "fund-app", "mch-transfer", "elecsign", "transfer-bill-no", request.TransferBillNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetFundAppMerchantTransferElecsignByTransferBillNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region MerchantTransfer/TransferBills
        /// <summary>
        /// <para>异步调用 [POST] /fund-app/mch-transfer/transfer-bills 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012716434 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateFundAppMerchantTransferBillResponse> ExecuteCreateFundAppMerchantTransferBillAsync(this WechatTenpayClient client, Models.CreateFundAppMerchantTransferBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fund-app", "mch-transfer", "transfer-bills");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateFundAppMerchantTransferBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fund-app/mch-transfer/transfer-bills/out-bill-no/{out_bill_no}/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012716458 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CancelFundAppMerchantTransferBillResponse> ExecuteCancelFundAppMerchantTransferBillAsync(this WechatTenpayClient client, Models.CancelFundAppMerchantTransferBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fund-app", "mch-transfer", "transfer-bills", "out-bill-no", request.OutBillNumber, "cancel");

            return await client.SendFlurlRequestAsJsonAsync<Models.CancelFundAppMerchantTransferBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fund-app/mch-transfer/transfer-bills/out-bill-no/{out_bill_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012716437 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetFundAppMerchantTransferBillByOutBillNumberResponse> ExecuteGetFundAppMerchantTransferBillByOutBillNumberAsync(this WechatTenpayClient client, Models.GetFundAppMerchantTransferBillByOutBillNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "fund-app", "mch-transfer", "transfer-bills", "out-bill-no", request.OutBillNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetFundAppMerchantTransferBillByOutBillNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fund-app/mch-transfer/transfer-bills/transfer-bill-no/{transfer_bill_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012716457 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetFundAppMerchantTransferBillByTransferBillNumberResponse> ExecuteGetFundAppMerchantTransferBillByTransferBillNumberAsync(this WechatTenpayClient client, Models.GetFundAppMerchantTransferBillByTransferBillNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "fund-app", "mch-transfer", "transfer-bills", "transfer-bill-no", request.TransferBillNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetFundAppMerchantTransferBillByTransferBillNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region MerchantTransfer/TransferToQQWalletBills
        /// <summary>
        /// <para>异步调用 [POST] /fund-app/mch-transfer/transfer-to-qq-wallet-bills 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4014297386 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateFundAppMerchantTransferToQQWalletBillResponse> ExecuteCreateFundAppMerchantTransferToQQWalletBillAsync(this WechatTenpayClient client, Models.CreateFundAppMerchantTransferToQQWalletBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fund-app", "mch-transfer", "transfer-to-qq-wallet-bills");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateFundAppMerchantTransferToQQWalletBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fund-app/mch-transfer/transfer-to-qq-wallet-bills/{out_bill_no}/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4014297396 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CancelFundAppMerchantTransferToQQWalletBillResponse> ExecuteCancelFundAppMerchantTransferToQQWalletBillAsync(this WechatTenpayClient client, Models.CancelFundAppMerchantTransferToQQWalletBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fund-app", "mch-transfer", "transfer-to-qq-wallet-bills", request.OutBillNumber, "cancel");

            return await client.SendFlurlRequestAsJsonAsync<Models.CancelFundAppMerchantTransferToQQWalletBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fund-app/mch-transfer/transfer-to-qq-wallet-bills/{out_bill_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4014297440 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetFundAppMerchantTransferToQQWalletBillByOutBillNumberResponse> ExecuteGetFundAppMerchantTransferToQQWalletBillByOutBillNumberAsync(this WechatTenpayClient client, Models.GetFundAppMerchantTransferToQQWalletBillByOutBillNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "fund-app", "mch-transfer", "transfer-to-qq-wallet-bills", request.OutBillNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetFundAppMerchantTransferToQQWalletBillByOutBillNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion
    }
}
