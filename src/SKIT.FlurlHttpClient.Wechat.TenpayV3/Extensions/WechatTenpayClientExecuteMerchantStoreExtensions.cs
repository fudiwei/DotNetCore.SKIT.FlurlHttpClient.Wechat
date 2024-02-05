using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMerchantStoreExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /merchant-store/stores 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMerchantStoreResponse> ExecuteCreateMerchantStoreAsync(this WechatTenpayClient client, Models.CreateMerchantStoreRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "merchant-store", "stores");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMerchantStoreResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant-store/stores/{store_id} 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantStoreByStoreIdResponse> ExecuteGetMerchantStoreByStoreIdAsync(this WechatTenpayClient client, Models.GetMerchantStoreByStoreIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "merchant-store", "stores", request.StoreId);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantStoreByStoreIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /merchant-store/stores/{store_id} 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ModifyMerchantStoreResponse> ExecuteModifyMerchantStoreAsync(this WechatTenpayClient client, Models.ModifyMerchantStoreRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, new HttpMethod("PATCH"), "merchant-store", "stores", request.StoreId);

            return await client.SendFlurlRequestAsJsonAsync<Models.ModifyMerchantStoreResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region
        /// <summary>
        /// <para>异步调用 [POST] /merchant-store/stores/{store_id}/recipients/bind 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.BindMerchantStoreRecipientResponse> ExecuteBindMerchantStoreRecipientAsync(this WechatTenpayClient client, Models.BindMerchantStoreRecipientRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "merchant-store", "stores", request.StoreId, "recipients", "bind");

            return await client.SendFlurlRequestAsJsonAsync<Models.BindMerchantStoreRecipientResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant-store/stores/{store_id}/recipients/unbind 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnbindMerchantStoreRecipientResponse> ExecuteUnbindMerchantStoreRecipientAsync(this WechatTenpayClient client, Models.UnbindMerchantStoreRecipientRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "merchant-store", "stores", request.StoreId, "recipients", "unbind");

            return await client.SendFlurlRequestAsJsonAsync<Models.UnbindMerchantStoreRecipientResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
