using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinWedriveExtensions
    {
        #region Space
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/space_create 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93655 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveSpaceCreateResponse> ExecuteCgibinWedriveSpaceCreateAsync(this WechatWorkClient client, Models.CgibinWedriveSpaceCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "space_create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveSpaceCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/space_rename 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97856 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveSpaceRenameResponse> ExecuteCgibinWedriveSpaceRenameAsync(this WechatWorkClient client, Models.CgibinWedriveSpaceRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "space_rename")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveSpaceRenameResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/space_dismiss 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97857 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveSpaceDismissResponse> ExecuteCgibinWedriveSpaceDismissAsync(this WechatWorkClient client, Models.CgibinWedriveSpaceDismissRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "space_dismiss")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveSpaceDismissResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/space_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97858 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveSpaceInfoResponse> ExecuteCgibinWedriveSpaceInfoAsync(this WechatWorkClient client, Models.CgibinWedriveSpaceInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "space_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveSpaceInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/new_space_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97950 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveNewSpaceInfoResponse> ExecuteCgibinWedriveNewSpaceInfoAsync(this WechatWorkClient client, Models.CgibinWedriveNewSpaceInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "new_space_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveNewSpaceInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/space_setting 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97876 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveSpaceSettingResponse> ExecuteCgibinWedriveSpaceSettingAsync(this WechatWorkClient client, Models.CgibinWedriveSpaceSettingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "space_setting")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveSpaceSettingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/space_share 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97877 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveSpaceShareResponse> ExecuteCgibinWedriveSpaceShareAsync(this WechatWorkClient client, Models.CgibinWedriveSpaceShareRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "space_share")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveSpaceShareResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region SpaceACL
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/space_acl_add 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93656 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveSpaceACLAddResponse> ExecuteCgibinWedriveSpaceACLAddAsync(this WechatWorkClient client, Models.CgibinWedriveSpaceACLAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "space_acl_add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveSpaceACLAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/space_acl_del 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97875 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveSpaceACLDeleteResponse> ExecuteCgibinWedriveSpaceACLDeleteAsync(this WechatWorkClient client, Models.CgibinWedriveSpaceACLDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "space_acl_del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveSpaceACLDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region File
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/file_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93657 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveFileListResponse> ExecuteCgibinWedriveFileListAsync(this WechatWorkClient client, Models.CgibinWedriveFileListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "file_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveFileListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/file_upload 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97880 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveFileUploadResponse> ExecuteCgibinWedriveFileUploadAsync(this WechatWorkClient client, Models.CgibinWedriveFileUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "file_upload")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveFileUploadResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/file_download 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97881 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveFileDownloadResponse> ExecuteCgibinWedriveFileDownloadAsync(this WechatWorkClient client, Models.CgibinWedriveFileDownloadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "file_download")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveFileDownloadResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/file_create 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97882 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveFileCreateResponse> ExecuteCgibinWedriveFileCreateAsync(this WechatWorkClient client, Models.CgibinWedriveFileCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "file_create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveFileCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/file_rename 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97883 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveFileRenameResponse> ExecuteCgibinWedriveFileRenameAsync(this WechatWorkClient client, Models.CgibinWedriveFileRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "file_rename")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveFileRenameResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/file_move 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97884 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveFileMoveResponse> ExecuteCgibinWedriveFileMoveAsync(this WechatWorkClient client, Models.CgibinWedriveFileMoveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "file_move")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveFileMoveResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/file_delete 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97885 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveFileDeleteResponse> ExecuteCgibinWedriveFileDeleteAsync(this WechatWorkClient client, Models.CgibinWedriveFileDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "file_delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveFileDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/file_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97886 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveFileInfoResponse> ExecuteCgibinWedriveFileInfoAsync(this WechatWorkClient client, Models.CgibinWedriveFileInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "file_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveFileInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/file_setting 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97889 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveFileSettingResponse> ExecuteCgibinWedriveFileSettingAsync(this WechatWorkClient client, Models.CgibinWedriveFileSettingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "file_setting")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveFileSettingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/file_secure_setting 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97965 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveFileSecureSettingResponse> ExecuteCgibinWedriveFileSecureSettingAsync(this WechatWorkClient client, Models.CgibinWedriveFileSecureSettingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "file_secure_setting")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveFileSecureSettingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/file_share 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97890 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveFileShareResponse> ExecuteCgibinWedriveFileShareAsync(this WechatWorkClient client, Models.CgibinWedriveFileShareRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "file_share")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveFileShareResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/get_file_permission 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97962 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveGetFilePermissionResponse> ExecuteCgibinWedriveGetFilePermissionAsync(this WechatWorkClient client, Models.CgibinWedriveGetFilePermissionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "get_file_permission")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveGetFilePermissionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region FileACL
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/file_acl_add 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93658 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveFileACLAddResponse> ExecuteCgibinWedriveFileACLAddAsync(this WechatWorkClient client, Models.CgibinWedriveFileACLAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "file_acl_add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveFileACLAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/file_acl_del 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97888 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveFileACLDeleteResponse> ExecuteCgibinWedriveFileACLDeleteAsync(this WechatWorkClient client, Models.CgibinWedriveFileACLDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "file_acl_del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveFileACLDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Manage
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/mng_pro_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95861 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveManageProfessionalInfoResponse> ExecuteCgibinWedriveManageProfessionalInfoAsync(this WechatWorkClient client, Models.CgibinWedriveManageProfessionalInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "mng_pro_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveManageProfessionalInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/wedrive/mng_capacity 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95861 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinWedriveManageCapacityResponse> ExecuteCgibinWedriveManageCapacityAsync(this WechatWorkClient client, Models.CgibinWedriveManageCapacityRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "wedrive", "mng_capacity")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinWedriveManageCapacityResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
