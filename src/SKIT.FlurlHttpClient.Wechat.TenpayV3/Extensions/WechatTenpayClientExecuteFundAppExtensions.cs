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

        /// <summary>
        /// <para>异步调用 [POST] /fund-app/mch-transfer/transfer-bills/pre-transfer-with-authorization 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4014399293 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateFundAppMerchantTransferBillPreTransferWithAuthorizationResponse> ExecuteCreateFundAppMerchantTransferBillPreTransferWithAuthorizationAsync(this WechatTenpayClient client, Models.CreateFundAppMerchantTransferBillPreTransferWithAuthorizationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fund-app", "mch-transfer", "transfer-bills", "pre-transfer-with-authorization");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateFundAppMerchantTransferBillPreTransferWithAuthorizationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fund-app/mch-transfer/transfer-bills/transfer 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4014399371 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateFundAppMerchantTransferBillTransferResponse> ExecuteCreateFundAppMerchantTransferBillTransferAsync(this WechatTenpayClient client, Models.CreateFundAppMerchantTransferBillTransferRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fund-app", "mch-transfer", "transfer-bills", "transfer");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateFundAppMerchantTransferBillTransferResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fund-app/mch-transfer/user-confirm-authorization 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4015901167 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateFundAppMerchantTransferUserConfirmAuthorizationResponse> ExecuteCreateFundAppMerchantTransferUserConfirmAuthorizationAsync(this WechatTenpayClient client, Models.CreateFundAppMerchantTransferUserConfirmAuthorizationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fund-app", "mch-transfer", "user-confirm-authorization");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateFundAppMerchantTransferUserConfirmAuthorizationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fund-app/mch-transfer/user-confirm-authorization/out-authorization-no/{out_authorization_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4014399423 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetFundAppMerchantTransferUserConfirmAuthorizationByOutAuthorizationNumberResponse> ExecuteGetFundAppMerchantTransferUserConfirmAuthorizationByOutAuthorizationNumberAsync(this WechatTenpayClient client, Models.GetFundAppMerchantTransferUserConfirmAuthorizationByOutAuthorizationNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "fund-app", "mch-transfer", "user-confirm-authorization", "out-authorization-no", request.OutAuthorizationNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetFundAppMerchantTransferUserConfirmAuthorizationByOutAuthorizationNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /fund-app/mch-transfer/user-confirm-authorization/out-authorization-no/{out_authorization_no}/close 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4015653811 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CloseFundAppMerchantTransferUserConfirmAuthorizationResponse> ExecuteCloseFundAppMerchantTransferUserConfirmAuthorizationAsync(this WechatTenpayClient client, Models.CloseFundAppMerchantTransferUserConfirmAuthorizationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fund-app", "mch-transfer", "user-confirm-authorization", "out-authorization-no", request.OutAuthorizationNumber, "close");

            return await client.SendFlurlRequestAsJsonAsync<Models.CloseFundAppMerchantTransferUserConfirmAuthorizationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
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

        #region BrandRedPacket
        /// <summary>
        /// <para>异步调用 [POST] /fund-app/brand-redpacket/brand-merchant-batches 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4014310358 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateFundAppBrandRedPacketBrandMerchantBatchResponse> ExecuteCreateFundAppBrandRedPacketBrandMerchantBatchAsync(this WechatTenpayClient client, Models.CreateFundAppBrandRedPacketBrandMerchantBatchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "fund-app", "brand-redpacket", "brand-merchant-batches");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateFundAppBrandRedPacketBrandMerchantBatchResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fund-app/brand-redpacket/brand-merchant-out-batches/{out_batch_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4014310378 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetFundAppBrandRedPacketBrandMerchantBatchByOutBatchNumberResponse> ExecuteGetFundAppBrandRedPacketBrandMerchantBatchByOutBatchNumberAsync(this WechatTenpayClient client, Models.GetFundAppBrandRedPacketBrandMerchantBatchByOutBatchNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "fund-app", "brand-redpacket", "brand-merchant-out-batches", request.OutBatchNumber)
                .SetQueryParam("need_query_detail", request.RequireQueryDetail)
                .SetQueryParam("detail_state", request.DetailState);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetFundAppBrandRedPacketBrandMerchantBatchByOutBatchNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fund-app/brand-redpacket/brand-merchant-batches/{batch_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4014310369 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetFundAppBrandRedPacketBrandMerchantBatchByBatchNumberResponse> ExecuteGetFundAppBrandRedPacketBrandMerchantBatchByBatchNumberAsync(this WechatTenpayClient client, Models.GetFundAppBrandRedPacketBrandMerchantBatchByBatchNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "fund-app", "brand-redpacket", "brand-merchant-batches", request.BatchNumber)
                .SetQueryParam("need_query_detail", request.RequireQueryDetail)
                .SetQueryParam("detail_state", request.DetailState);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetFundAppBrandRedPacketBrandMerchantBatchByBatchNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fund-app/brand-redpacket/brand-merchant-out-batches/{out_batch_no}/out-details/{out_detail_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4014310391 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetFundAppBrandRedPacketBrandMerchantBatchDetailByOutDetailNumberResponse> ExecuteGetFundAppBrandRedPacketBrandMerchantBatchDetailByOutDetailNumberAsync(this WechatTenpayClient client, Models.GetFundAppBrandRedPacketBrandMerchantBatchDetailByOutDetailNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "fund-app", "brand-redpacket", "brand-merchant-out-batches", request.OutBatchNumber, "out-details", request.OutDetailNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetFundAppBrandRedPacketBrandMerchantBatchDetailByOutDetailNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fund-app/brand-redpacket/brand-merchant-batches/{batch_no}/details/{detail_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4014310384 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetFundAppBrandRedPacketBrandMerchantBatchDetailByDetailNumberResponse> ExecuteGetFundAppBrandRedPacketBrandMerchantBatchDetailByDetailNumberAsync(this WechatTenpayClient client, Models.GetFundAppBrandRedPacketBrandMerchantBatchDetailByDetailNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "fund-app", "brand-redpacket", "brand-merchant-batches", request.BatchNumber, "out-details", request.DetailNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetFundAppBrandRedPacketBrandMerchantBatchDetailByDetailNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
