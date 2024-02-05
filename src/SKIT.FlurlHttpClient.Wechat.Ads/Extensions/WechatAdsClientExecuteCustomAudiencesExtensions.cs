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

            return await client.SendFlurlRequestAsJsonAsync<Models.CustomAudiencesAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CustomAudiencesUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
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

            if (request.CustomAudienceId is not null)
                flurlReq.SetQueryParam("audience_id", request.CustomAudienceId.Value);

            if (request.PageSize is not null)
                flurlReq.SetQueryParam("page_size", request.PageSize.Value);

            if (request.Page is not null)
                flurlReq.SetQueryParam("page", request.Page.Value);

            return await client.SendFlurlRequestAsJsonAsync<Models.CustomAudiencesGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
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

            return await client.SendFlurlRequestAsync<Models.CustomAudienceFilesAddResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
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

            if (request.CustomAudienceId is not null)
                flurlReq.SetQueryParam("audience_id", request.CustomAudienceId.Value);

            if (request.CustomAudienceFileId is not null)
                flurlReq.SetQueryParam("custom_audience_file_id", request.CustomAudienceFileId.Value);

            if (request.PageSize is not null)
                flurlReq.SetQueryParam("page_size", request.PageSize.Value);

            if (request.Page is not null)
                flurlReq.SetQueryParam("page", request.Page.Value);

            return await client.SendFlurlRequestAsJsonAsync<Models.CustomAudienceFilesGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
