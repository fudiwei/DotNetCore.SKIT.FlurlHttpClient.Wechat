using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global
{
    public static class WechatTenpayGlobalClientExecuteMerchantH5PermissionExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /merchant/h5/permission/applications 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter4_4_1.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMerchantH5PermissionApplicationResponse> ExecuteCreateMerchantH5PermissionApplicationAsync(this WechatTenpayGlobalClient client, Models.CreateMerchantH5PermissionApplicationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "merchant", "h5", "permission", "applications");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMerchantH5PermissionApplicationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant/h5/permission/applications/{applyment_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter4_4_2.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantH5PermissionApplicationByApplymentIdResponse> ExecuteGetMerchantH5PermissionApplicationByApplymentIdAsync(this WechatTenpayGlobalClient client, Models.GetMerchantH5PermissionApplicationByApplymentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "merchant", "h5", "permission", "applications", request.ApplymentId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantH5PermissionApplicationByApplymentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /merchant/h5/permission/applications/{applyment_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter4_4_3.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMerchantH5PermissionApplicationResponse> ExecuteUpdateMerchantH5PermissionApplicationAsync(this WechatTenpayGlobalClient client, Models.UpdateMerchantH5PermissionApplicationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, new HttpMethod("PATCH"), "merchant", "h5", "permission", "applications", request.ApplymentId);

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMerchantH5PermissionApplicationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/h5/permission/domain/applications 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter4_4_4.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMerchantH5PermissionDomainApplicationResponse> ExecuteCreateMerchantH5PermissionDomainApplicationAsync(this WechatTenpayGlobalClient client, Models.CreateMerchantH5PermissionDomainApplicationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "merchant", "h5", "permission", "domain", "applications");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMerchantH5PermissionDomainApplicationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant/h5/permission/domain/applications/{applyment_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter4_4_5.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantH5PermissionDomainApplicationByApplymentIdResponse> ExecuteGetMerchantH5PermissionDomainApplicationByApplymentIdAsync(this WechatTenpayGlobalClient client, Models.GetMerchantH5PermissionDomainApplicationByApplymentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "merchant", "h5", "permission", "domain", "applications", request.ApplymentId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantH5PermissionDomainApplicationByApplymentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /merchant/h5/permission/domain/applications/{applyment_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter4_4_6.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMerchantH5PermissionDomainApplicationResponse> ExecuteUpdateMerchantH5PermissionDomainApplicationAsync(this WechatTenpayGlobalClient client, Models.UpdateMerchantH5PermissionDomainApplicationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, new HttpMethod("PATCH"), "merchant", "h5", "permission", "domain", "applications", request.ApplymentId);

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMerchantH5PermissionDomainApplicationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant/h5/permission/{sub_mchid} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter4_4_7.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantH5PermissionBySubMerchantIdResponse> ExecuteGetMerchantH5PermissionBySubMerchantIdAsync(this WechatTenpayGlobalClient client, Models.GetMerchantH5PermissionBySubMerchantIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "merchant", "h5", "permissions", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantH5PermissionBySubMerchantIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
