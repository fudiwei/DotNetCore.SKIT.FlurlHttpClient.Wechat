using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMerchantAlterApplyExtensions
    {
        #region MerchantContact
        /// <summary>
        /// <para>异步调用 [POST] /mchalterapply/mchcontactalterapplyment 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014090649 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMerchantAlterApplyMerchantContactAlterApplymentResponse> ExecuteCreateMerchantAlterApplyMerchantContactAlterApplymentAsync(this WechatTenpayClient client, Models.CreateMerchantAlterApplyMerchantContactAlterApplymentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mchalterapply", "mchcontactalterapplyment");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMerchantAlterApplyMerchantContactAlterApplymentResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mchalterapply/mchcontactalterapplyment/{apply_id}/revoke 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014090672 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RevokeMerchantAlterApplyMerchantContactAlterApplymentResponse> ExecuteRevokeMerchantAlterApplyMerchantContactAlterApplymentAsync(this WechatTenpayClient client, Models.RevokeMerchantAlterApplyMerchantContactAlterApplymentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mchalterapply", "mchcontactalterapplyment", request.ApplymentId, "revoke");

            return await client.SendFlurlRequestAsJsonAsync<Models.RevokeMerchantAlterApplyMerchantContactAlterApplymentResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mchalterapply/mchcontactalterapplyment/merchant/{merchant_code}/out-request-no/{out_request_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014090667 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantAlterApplyMerchantContactAlterApplymentByOutRequestNumberResponse> ExecuteGetMerchantAlterApplyMerchantContactAlterApplymentByOutRequestNumberAsync(this WechatTenpayClient client, Models.GetMerchantAlterApplyMerchantContactAlterApplymentByOutRequestNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "mchalterapply", "mchcontactalterapplyment", "merchant", request.SubMerchantId, "out-request-no", request.OutRequestNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantAlterApplyMerchantContactAlterApplymentByOutRequestNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mchalterapply/mchcontactalterapplyment/{apply_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014090655 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantAlterApplyMerchantContactAlterApplymentByApplymentIdResponse> ExecuteGetMerchantAlterApplyMerchantContactAlterApplymentByApplymentIdAsync(this WechatTenpayClient client, Models.GetMerchantAlterApplyMerchantContactAlterApplymentByApplymentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "mchalterapply", "mchcontactalterapplyment", request.ApplymentId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantAlterApplyMerchantContactAlterApplymentByApplymentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region MerchantName
        /// <summary>
        /// <para>异步调用 [POST] /mchalterapply/merchantnamealterapplyment 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016166071 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMerchantAlterApplyMerchantNameAlterApplymentResponse> ExecuteCreateMerchantAlterApplyMerchantNameAlterApplymentAsync(this WechatTenpayClient client, Models.CreateMerchantAlterApplyMerchantNameAlterApplymentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mchalterapply", "merchantnamealterapplyment");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMerchantAlterApplyMerchantNameAlterApplymentResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mchalterapply/merchantnamealterapplyment/{apply_id}/revoke 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016166090 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RevokeMerchantAlterApplyMerchantNameAlterApplymentResponse> ExecuteRevokeMerchantAlterApplyMerchantNameAlterApplymentAsync(this WechatTenpayClient client, Models.RevokeMerchantAlterApplyMerchantNameAlterApplymentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mchalterapply", "merchantnamealterapplyment", request.ApplymentId, "revoke");

            return await client.SendFlurlRequestAsJsonAsync<Models.RevokeMerchantAlterApplyMerchantNameAlterApplymentResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mchalterapply/merchantnamealterapplyment/merchant/{sub_mchid}/out-request-no/{out_request_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016166085 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantAlterApplyMerchantNameAlterApplymentByOutRequestNumberResponse> ExecuteGetMerchantAlterApplyMerchantNameAlterApplymentByOutRequestNumberAsync(this WechatTenpayClient client, Models.GetMerchantAlterApplyMerchantNameAlterApplymentByOutRequestNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "mchalterapply", "merchantnamealterapplyment", "merchant", request.SubMerchantId, "out-request-no", request.OutRequestNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantAlterApplyMerchantNameAlterApplymentByOutRequestNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mchalterapply/merchantnamealterapplyment/{apply_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016166074 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantAlterApplyMerchantNameAlterApplymentByApplymentIdResponse> ExecuteGetMerchantAlterApplyMerchantNameAlterApplymentByApplymentIdAsync(this WechatTenpayClient client, Models.GetMerchantAlterApplyMerchantNameAlterApplymentByApplymentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "mchalterapply", "merchantnamealterapplyment", request.ApplymentId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantAlterApplyMerchantNameAlterApplymentByApplymentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region MerchantSubject
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
        #endregion
    }
}
