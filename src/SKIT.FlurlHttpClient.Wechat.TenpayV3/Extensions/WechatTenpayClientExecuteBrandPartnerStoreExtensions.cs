using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteBrandPartnerStoreExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /brand/partner/store/brandstores 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015783183 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateBrandPartnerStoreResponse> ExecuteCreateBrandPartnerStoreAsync(this WechatTenpayClient client, Models.CreateBrandPartnerStoreRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "partner", "store", "brandstores");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateBrandPartnerStoreResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /brand/partner/store/brandstores/{store_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015783153 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBrandPartnerStoreByStoreIdResponse> ExecuteGetBrandPartnerStoreByStoreIdAsync(this WechatTenpayClient client, Models.GetBrandPartnerStoreByStoreIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "brand", "partner", "store", "brandstores", request.StoreId)
                .SetQueryParam("brand_id", request.BrandId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBrandPartnerStoreByStoreIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /brand/partner/store/brandstores/{store_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015783158 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ModifyBrandPartnerStoreResponse> ExecuteModifyBrandPartnerStoreAsync(this WechatTenpayClient client, Models.ModifyBrandPartnerStoreRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, new HttpMethod("PATCH"), "brand", "partner", "store", "brandstores", request.StoreId);

            return await client.SendFlurlRequestAsJsonAsync<Models.ModifyBrandPartnerStoreResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [DELETE] /brand/partner/store/brandstores/{store_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015783113 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeleteBrandPartnerStoreResponse> ExecuteDeleteBrandPartnerStoreAsync(this WechatTenpayClient client, Models.DeleteBrandPartnerStoreRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Delete, "brand", "partner", "store", "brandstores", request.StoreId);

            return await client.SendFlurlRequestAsJsonAsync<Models.DeleteBrandPartnerStoreResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /brand/partner/store/brandstores/{store_id}/bindrecipient 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015783177 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.BindBrandPartnerStoreRecipientResponse> ExecuteBindBrandPartnerStoreRecipientAsync(this WechatTenpayClient client, Models.BindBrandPartnerStoreRecipientRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "partner", "store", "brandstores", request.StoreId, "bindrecipient");

            return await client.SendFlurlRequestAsJsonAsync<Models.BindBrandPartnerStoreRecipientResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /brand/partner/store/brandstores/{store_id}/unbindrecipient 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015783188 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnbindBrandPartnerStoreRecipientResponse> ExecuteUnbindBrandPartnerStoreRecipientAsync(this WechatTenpayClient client, Models.UnbindBrandPartnerStoreRecipientRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "partner", "store", "brandstores", request.StoreId, "unbindrecipient");

            return await client.SendFlurlRequestAsJsonAsync<Models.UnbindBrandPartnerStoreRecipientResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
