using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMerchantAlterApplyExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /mchalterapply/mchsubjectalterapplyment 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014090649 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMerchantAlterApplyMerchantSubjectAlterApplymentResponse> ExecuteCreateMerchantAlterApplyMerchantSubjectAlterApplymentAsync(this WechatTenpayClient client, Models.CreateMerchantAlterApplyMerchantSubjectAlterApplymentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mchalterapply", "mchsubjectalterapplyment");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMerchantAlterApplyMerchantSubjectAlterApplymentResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mchalterapply/mchsubjectalterapplyment/{apply_id}/revoke 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014090672 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RevokeMerchantAlterApplyMerchantSubjectAlterApplymentResponse> ExecuteRevokeMerchantAlterApplyMerchantSubjectAlterApplymentAsync(this WechatTenpayClient client, Models.RevokeMerchantAlterApplyMerchantSubjectAlterApplymentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mchalterapply", "mchsubjectalterapplyment", request.ApplymentId, "revoke");

            return await client.SendFlurlRequestAsJsonAsync<Models.RevokeMerchantAlterApplyMerchantSubjectAlterApplymentResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mchalterapply/mchsubjectalterapplyment/merchant/{merchant_code}/out-request-no/{out_request_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014090667 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantAlterApplyMerchantSubjectAlterApplymentByOutRequestNumberResponse> ExecuteGetMerchantAlterApplyMerchantSubjectAlterApplymentByOutRequestNumberAsync(this WechatTenpayClient client, Models.GetMerchantAlterApplyMerchantSubjectAlterApplymentByOutRequestNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "mchalterapply", "mchsubjectalterapplyment", "merchant", request.SubMerchantId, "out-request-no", request.OutRequestNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantAlterApplyMerchantSubjectAlterApplymentByOutRequestNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mchalterapply/mchsubjectalterapplyment/{apply_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014090655 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantAlterApplyMerchantSubjectAlterApplymentByApplymentIdResponse> ExecuteGetMerchantAlterApplyMerchantSubjectAlterApplymentByApplymentIdAsync(this WechatTenpayClient client, Models.GetMerchantAlterApplyMerchantSubjectAlterApplymentByApplymentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "mchalterapply", "mchsubjectalterapplyment", request.ApplymentId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantAlterApplyMerchantSubjectAlterApplymentByApplymentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
