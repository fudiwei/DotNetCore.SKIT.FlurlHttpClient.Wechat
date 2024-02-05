using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteApplyForSubjectExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /apply4subject/applyment 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/confirmation-of-account-creation/applyment/submit-applyment.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "apply4subject", "applyment");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateApplyForSubjectApplymentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /apply4subject/applyment 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/confirmation-of-account-creation/applyment/get-audit-result.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "apply4subject", "applyment")
                .SetQueryParam("business_code", request.BusinessCode);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetApplyForSubjectApplymentByBusinessCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /apply4subject/applyment 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/confirmation-of-account-creation/applyment/get-audit-result.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "apply4subject", "applyment")
                .SetQueryParam("applyment_id", request.ApplymentId.ToString());

            return await client.SendFlurlRequestAsJsonAsync<Models.GetApplyForSubjectApplymentByApplymentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apply4subject/applyment/{business_code}/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/confirmation-of-account-creation/applyment/cancel-applyment.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "apply4subject", "applyment", request.BusinessCode, "cancel");

            return await client.SendFlurlRequestAsJsonAsync<Models.CancelApplyForSubjectApplymentByBusinessCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /apply4subject/applyment/{applyment_id}/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/confirmation-of-account-creation/applyment/cancel-applyment.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "apply4subject", "applyment", request.ApplymentId.ToString(), "cancel");

            return await client.SendFlurlRequestAsJsonAsync<Models.CancelApplyForSubjectApplymentByApplymentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /apply4subject/applyment/merchants/{sub_mchid}/state 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/confirmation-of-account-creation/applyment/get-authorize-state.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "apply4subject", "applyment", "merchants", request.SubMerchantId, "state");

            return await client.SendFlurlRequestAsJsonAsync<Models.GetApplyForSubjectApplymentMerchantStateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
