using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供电商收付通进件相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteEcommerceApplymentsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/applyments/ 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_1_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateEcommerceApplymentResponse> ExecuteCreateEcommerceApplymentAsync(this WechatTenpayClient client, Models.CreateEcommerceApplymentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            // NOTICE: 注意本接口 URL 结尾的反斜杠不能删除
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "ecommerce", "applyments/");

            return await client.SendRequestWithJsonAsync<Models.CreateEcommerceApplymentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/applyments/{applyment_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_1_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceApplymentByApplymentIdResponse> ExecuteGetEcommerceApplymentByApplymentIdAsync(this WechatTenpayClient client, Models.GetEcommerceApplymentByApplymentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "ecommerce", "applyments", request.ApplymentId.ToString());

            return await client.SendRequestWithJsonAsync<Models.GetEcommerceApplymentByApplymentIdResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/applyments/out-request-no/{out_request_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_1_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceApplymentByOutRequestNumberResponse> ExecuteGetEcommerceApplymentByOutRequestNumberAsync(this WechatTenpayClient client, Models.GetEcommerceApplymentByOutRequestNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "ecommerce", "applyments", "out-request-no", request.OutRequestNumber);

            return await client.SendRequestWithJsonAsync<Models.GetEcommerceApplymentByOutRequestNumberResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
