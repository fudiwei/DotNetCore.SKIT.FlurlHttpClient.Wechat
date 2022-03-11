using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Ads
{
    public static class WechatAdsClientExecuteCustomAudiencesExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /custom_audiences/add 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomAudiencesAddResponse> ExecuteCustomAudiencesAddAsync(this WechatAdsClient client, Models.CustomAudiencesAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "custom_audiences", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CustomAudiencesAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /custom_audiences/update 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomAudiencesUpdateResponse> ExecuteCustomAudiencesUpdateAsync(this WechatAdsClient client, Models.CustomAudiencesUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "custom_audiences", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CustomAudiencesUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /custom_audiences/get 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomAudiencesGetResponse> ExecuteCustomAudiencesGetAsync(this WechatAdsClient client, Models.CustomAudiencesGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "custom_audiences", "get")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.CustomAudienceId != null)
                flurlReq.SetQueryParam("audience_id", request.CustomAudienceId.Value);

            if (request.PageSize != null)
                flurlReq.SetQueryParam("page_size", request.PageSize.Value);

            if (request.Page != null)
                flurlReq.SetQueryParam("page", request.Page.Value);

            return await client.SendRequestWithJsonAsync<Models.CustomAudiencesGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Files
        /// <summary>
        /// <para>异步调用 [POST] /custom_audience_files/add 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomAudienceFilesAddResponse> ExecuteCustomAudienceFilesAddAsync(this WechatAdsClient client, Models.CustomAudienceFilesAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            string filename = "file.zip";
            using var fileContent = new ByteArrayContent(request.FileBytes ?? Array.Empty<byte>());
            using var httpContent = new MultipartFormDataContent(boundary);
            httpContent.Add(new StringContent(request.CustomAudienceId.ToString()), "audience_id");
            httpContent.Add(new StringContent(request.UserIdType), "user_id_type");
            httpContent.Add(new StringContent(request.OperationType), "operation_type");
            httpContent.Add(fileContent, "\"file\"", $"\"{filename}\"");
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/zip");
            fileContent.Headers.ContentLength = request.FileBytes?.Length;
            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "custom_audience_files", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestAsync<Models.CustomAudienceFilesAddResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /custom_audience_files/get 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CustomAudienceFilesGetResponse> ExecuteCustomAudienceFilesGetAsync(this WechatAdsClient client, Models.CustomAudienceFilesGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "custom_audience_files", "get")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.CustomAudienceId != null)
                flurlReq.SetQueryParam("audience_id", request.CustomAudienceId.Value);

            if (request.CustomAudienceFileId != null)
                flurlReq.SetQueryParam("custom_audience_file_id", request.CustomAudienceFileId.Value);

            if (request.PageSize != null)
                flurlReq.SetQueryParam("page_size", request.PageSize.Value);

            if (request.Page != null)
                flurlReq.SetQueryParam("page", request.Page.Value);

            return await client.SendRequestWithJsonAsync<Models.CustomAudienceFilesGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
