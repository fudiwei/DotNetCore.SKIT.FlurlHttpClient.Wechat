using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供商户开户意愿确认相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteApplyForSubjectExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /apply4subject/applyment 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_1_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateApplyForSubjectApplymentResponse> ExecuteCreateApplyForSubjectApplymentAsync(this WechatTenpayClient client, Models.CreateApplyForSubjectApplymentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apply4subject", "applyment");

            return await client.SendRequestWithJsonAsync<Models.CreateApplyForSubjectApplymentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /apply4subject/applyment 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_1_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetApplyForSubjectApplymentByBusinessCodeResponse> ExecuteGetApplyForSubjectApplymentByBusinessCodeAsync(this WechatTenpayClient client, Models.GetApplyForSubjectApplymentByBusinessCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "apply4subject", "applyment")
                .SetQueryParam("business_code", request.BusinessCode);

            return await client.SendRequestWithJsonAsync<Models.GetApplyForSubjectApplymentByBusinessCodeResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /apply4subject/applyment 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_1_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetApplyForSubjectApplymentByApplymentIdResponse> ExecuteGetApplyForSubjectApplymentByApplymentIdAsync(this WechatTenpayClient client, Models.GetApplyForSubjectApplymentByApplymentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "apply4subject", "applyment")
                .SetQueryParam("applyment_id", request.ApplymentId.ToString());

            return await client.SendRequestWithJsonAsync<Models.GetApplyForSubjectApplymentByApplymentIdResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apply4subject/applyment/{business_code}/cancel 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_1_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CancelApplyForSubjectApplymentByBusinessCodeResponse> ExecuteCancelApplyForSubjectApplymentByBusinessCodeAsync(this WechatTenpayClient client, Models.CancelApplyForSubjectApplymentByBusinessCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apply4subject", "applyment", request.BusinessCode, "cancel");

            return await client.SendRequestWithJsonAsync<Models.CancelApplyForSubjectApplymentByBusinessCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apply4subject/applyment/{applyment_id}/cancel 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_1_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CancelApplyForSubjectApplymentByApplymentIdResponse> ExecuteCancelApplyForSubjectApplymentByApplymentIdAsync(this WechatTenpayClient client, Models.CancelApplyForSubjectApplymentByApplymentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "apply4subject", "applyment", request.ApplymentId.ToString(), "cancel");

            return await client.SendRequestWithJsonAsync<Models.CancelApplyForSubjectApplymentByApplymentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /apply4subject/applyment/merchants/{sub_mchid}/state 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter10_1_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetApplyForSubjectApplymentMerchantStateResponse> ExecuteGetApplyForSubjectApplymentMerchantStateAsync(this WechatTenpayClient client, Models.GetApplyForSubjectApplymentMerchantStateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "apply4subject", "applyment", "merchants", request.SubMerchantId, "state");

            return await client.SendRequestWithJsonAsync<Models.GetApplyForSubjectApplymentMerchantStateResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
