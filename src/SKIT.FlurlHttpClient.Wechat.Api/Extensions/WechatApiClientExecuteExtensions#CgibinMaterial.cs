namespace SKIT.FlurlHttpClient.Wechat.Api
{
    using SKIT.FlurlHttpClient;

    public static partial class WechatApiClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/material/add_material 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/material/permanent/api_addmaterial.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/material/permanent/api_addmaterial.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMaterialAddMaterialResponse> ExecuteCgibinMaterialAddMaterialAsync(this WechatApiClient client, Models.CgibinMaterialAddMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            const string TYPE_IMAGE = "image";
            const string TYPE_THUMB = "thumb";
            const string TYPE_VOICE = "voice";
            const string TYPE_VIDEO = "video";

            if (request.FileName is null)
            {
                string ext = string.Empty;
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

            if (request.FileContentType is null)
            {
                request.FileContentType = MimeTypes.GetMimeMapping(request.FileName);
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "material", "add_material")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.Type);

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, formDataName: "media");
            if (TYPE_VIDEO.Equals(request.Type))
            {
                httpContent.Add(new StringContent(client.JsonSerializer.Serialize(request), Encoding.UTF8), "\"description\"");
            }

            return await client.SendFlurlRequestAsync<Models.CgibinMaterialAddMaterialResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/material/get_material 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/material/permanent/api_getmaterial.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/material/permanent/api_getmaterial.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "material", "get_material")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinMaterialGetMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/material/get_material 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/material/permanent/api_getmaterial.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/material/permanent/api_getmaterial.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "material", "get_material")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinMaterialGetMaterialAsVideoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/material/del_material 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/material/permanent/api_delmaterial.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/material/permanent/api_delmaterial.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "material", "del_material")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinMaterialDeleteMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/material/get_materialcount 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/material/permanent/api_getmaterialcount.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/material/permanent/api_getmaterialcount.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "material", "get_materialcount")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinMaterialGetMaterialCountResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/material/batchget_material 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/material/permanent/api_batchgetmaterial.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/material/permanent/api_batchgetmaterial.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "material", "batchget_material")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinMaterialBatchGetMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
