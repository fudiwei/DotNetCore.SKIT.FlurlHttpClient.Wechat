using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMarketingShoppingReceiptExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /marketing/shopping-receipt/shoppingreceipts 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/shopping-receipt/shopping-receipts/upload-shopping-receipt.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadMarketingShoppingReceiptResponse> ExecuteUploadMarketingShoppingReceiptAsync(this WechatTenpayClient client, Models.UploadMarketingShoppingReceiptRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName == null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".png";

            if (request.FileHash == null)
                request.FileHash = BitConverter.ToString(Utilities.SHA256Utility.Hash(request.FileBytes)).Replace("-", string.Empty).ToLower();

            if (request.FileContentType == null)
                request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForImage(request.FileName!) ?? "image/png";

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "marketing", "shopping-receipt", "shoppingreceipts");

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, fileMetaJson: client.JsonSerializer.Serialize(request));
            return await client.SendRequestAsync<Models.UploadMarketingShoppingReceiptResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/shopping-receipt/merchantshoppingreceiptjumpinfos 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/shopping-receipt/merchant-shopping-receipt-jump-infos/create-merchant-shopping-receipt-jump-info.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetMarketingShoppingReceiptJumpInfoResponse> ExecuteSetMarketingShoppingReceiptJumpInfoAsync(this WechatTenpayClient client, Models.SetMarketingShoppingReceiptJumpInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "marketing", "shopping-receipt", "merchantshoppingreceiptjumpinfos");

            return await client.SendRequestWithJsonAsync<Models.SetMarketingShoppingReceiptJumpInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region CustomEntrance
        /// <summary>
        /// <para>异步调用 [POST] /marketing/shopping-receipt/customentrances 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/shopping-receipt/custom-entrances/create-custom-entrance.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMarketingShoppingReceiptCustomEntranceResponse> ExecuteCreateMarketingShoppingReceiptCustomEntranceAsync(this WechatTenpayClient client, Models.CreateMarketingShoppingReceiptCustomEntranceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "marketing", "shopping-receipt", "customentrances");

            return await client.SendRequestWithJsonAsync<Models.CreateMarketingShoppingReceiptCustomEntranceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/shopping-receipt/customentrances/{brand_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/shopping-receipt/custom-entrances/query-custom-entrance.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingShoppingReceiptCustomEntranceByBrandIdResponse> ExecuteGetMarketingShoppingReceiptCustomEntranceByBrandIdAsync(this WechatTenpayClient client, Models.GetMarketingShoppingReceiptCustomEntranceByBrandIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "marketing", "shopping-receipt", "customentrances", request.BrandId);

            return await client.SendRequestWithJsonAsync<Models.GetMarketingShoppingReceiptCustomEntranceByBrandIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /marketing/shopping-receipt/customentrances/{brand_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/shopping-receipt/custom-entrances/update-custom-entrance.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ModifyMarketingShoppingReceiptCustomEntranceResponse> ExecuteModifyMarketingShoppingReceiptCustomEntranceAsync(this WechatTenpayClient client, Models.ModifyMarketingShoppingReceiptCustomEntranceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, new HttpMethod("PATCH"), "marketing", "shopping-receipt", "customentrances", request.BrandId);

            return await client.SendRequestWithJsonAsync<Models.ModifyMarketingShoppingReceiptCustomEntranceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
