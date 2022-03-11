using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCgibinMaterialExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/material/add_news 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Asset_Management/Adding_Permanent_Assets.html#%E6%96%B0%E5%A2%9E%E6%B0%B8%E4%B9%85%E5%9B%BE%E6%96%87%E7%B4%A0%E6%9D%90 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2022-02-25 下线。")]
        public static async Task<Models.CgibinMaterialAddNewsResponse> ExecuteCgibinMaterialAddNewsAsync(this WechatApiClient client, Models.CgibinMaterialAddNewsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "material", "add_news")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMaterialAddNewsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/material/add_material 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Asset_Management/Adding_Permanent_Assets.html#%E6%96%B0%E5%A2%9E%E5%85%B6%E4%BB%96%E7%B1%BB%E5%9E%8B%E6%B0%B8%E4%B9%85%E7%B4%A0%E6%9D%90 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2022-02-25 下线。")]
        public static async Task<Models.CgibinMaterialAddMaterialResponse> ExecuteCgibinMaterialAddMaterialAsync(this WechatApiClient client, Models.CgibinMaterialAddMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            const string TYPE_IMAGE = "image";
            const string TYPE_THUMB = "thumb";
            const string TYPE_VOICE = "voice";
            const string TYPE_VIDEO = "video";

            if (request.FileName == null)
            {
                string ext = "";
                if (TYPE_IMAGE.Equals(request.Type))
                    ext = ".png";
                else if (TYPE_THUMB.Equals(request.Type))
                    ext = ".jpg";
                else if (TYPE_VOICE.Equals(request.Type))
                    ext = ".mp3";
                else if (TYPE_VIDEO.Equals(request.Type))
                    ext = ".mp4";

                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ext;
            }

            if (request.FileContentType == null)
            {
                if (TYPE_IMAGE.Equals(request.Type) || TYPE_THUMB.Equals(request.Type))
                    request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForImage(request.FileName!) ?? "image/png";
                else if (TYPE_VOICE.Equals(request.Type))
                    request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForVoice(request.FileName!) ?? "audio/mp3";
                else if (TYPE_VIDEO.Equals(request.Type))
                    request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForVideo(request.FileName!) ?? "video/mp4";
                else
                    request.FileContentType = "application/octet-stream";
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "material", "add_material")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.Type);

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            using var fileContent = new ByteArrayContent(request.FileBytes ?? Array.Empty<byte>());
            using var descContent = new ByteArrayContent(Encoding.UTF8.GetBytes(client.JsonSerializer.Serialize(request)));
            using var httpContent = new MultipartFormDataContent(boundary);
            httpContent.Add(fileContent, "\"media\"", $"\"{HttpUtility.UrlEncode(request.FileName)}\"");
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.FileContentType);
            fileContent.Headers.ContentLength = request.FileBytes?.Length;

            if (TYPE_VIDEO.Equals(request.Type))
            {
                httpContent.Add(descContent, "\"description\"");
            }

            return await client.SendRequestAsync<Models.CgibinMaterialAddMaterialResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/material/get_material 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Asset_Management/Getting_Permanent_Assets.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMaterialGetMaterialResponse> ExecuteCgibinMaterialGetMaterialAsync(this WechatApiClient client, Models.CgibinMaterialGetMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "material", "get_material")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMaterialGetMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/material/get_material 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Asset_Management/Getting_Permanent_Assets.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2022-02-25 下线。")]
        public static async Task<Models.CgibinMaterialGetMaterialAsNewsResponse> ExecuteCgibinMaterialGetMaterialAsNewsAsync(this WechatApiClient client, Models.CgibinMaterialGetMaterialAsNewsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "material", "get_material")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMaterialGetMaterialAsNewsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/material/get_material 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Asset_Management/Getting_Permanent_Assets.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMaterialGetMaterialAsVideoResponse> ExecuteCgibinMaterialGetMaterialAsVideoAsync(this WechatApiClient client, Models.CgibinMaterialGetMaterialAsVideoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "material", "get_material")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMaterialGetMaterialAsVideoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/material/del_material 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Asset_Management/Deleting_Permanent_Assets.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMaterialDeleteMaterialResponse> ExecuteCgibinMaterialDeleteMaterialAsync(this WechatApiClient client, Models.CgibinMaterialDeleteMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "material", "del_material")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMaterialDeleteMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/material/update_news 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Asset_Management/Editing_Permanent_Rich_Media_Assets.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2022-02-25 下线。")]
        public static async Task<Models.CgibinMaterialUpdateNewsResponse> ExecuteCgibinMaterialUpdateNewsAsync(this WechatApiClient client, Models.CgibinMaterialUpdateNewsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "material", "update_news")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMaterialUpdateNewsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/material/get_materialcount 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Asset_Management/Get_the_total_of_all_materials.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMaterialGetMaterialCountResponse> ExecuteCgibinMaterialGetMaterialCountAsync(this WechatApiClient client, Models.CgibinMaterialGetMaterialCountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "material", "get_materialcount")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMaterialGetMaterialCountResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/material/batchget_material 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Asset_Management/Get_materials_list.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMaterialBatchGetMaterialResponse> ExecuteCgibinMaterialBatchGetMaterialAsync(this WechatApiClient client, Models.CgibinMaterialBatchGetMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "material", "batchget_material")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMaterialBatchGetMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
