using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCgibinTemplateExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/template/api_set_industry 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Template_Message_Interface.html#0 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTemplateSetIndustryResponse> ExecuteCgibinTemplateSetIndustryAsync(this WechatApiClient client, Models.CgibinTemplateSetIndustryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "template", "api_set_industry")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTemplateSetIndustryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/template/get_industry 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Template_Message_Interface.html#1 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTemplateGetIndustryResponse> ExecuteCgibinTemplateGetIndustryAsync(this WechatApiClient client, Models.CgibinTemplateGetIndustryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "template", "get_industry")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTemplateGetIndustryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/template/api_add_template 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Template_Message_Interface.html#2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTemplateAddTemplateResponse> ExecuteCgibinTemplateAddTemplateAsync(this WechatApiClient client, Models.CgibinTemplateAddTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "template", "api_add_template")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTemplateAddTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/template/get_all_private_template 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Template_Message_Interface.html#3 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTemplateGetAllPrivateTemplateResponse> ExecuteCgibinTemplateGetAllPrivateTemplateAsync(this WechatApiClient client, Models.CgibinTemplateGetAllPrivateTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "template", "get_all_private_template")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTemplateGetAllPrivateTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/template/del_private_template 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Template_Message_Interface.html#4 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTemplateDeletePrivateTemplateResponse> ExecuteCgibinTemplateDeletePrivateTemplateAsync(this WechatApiClient client, Models.CgibinTemplateDeletePrivateTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "template", "del_private_template")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTemplateDeletePrivateTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

    }
}
