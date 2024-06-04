using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteChannelsExtensions
    {
        #region ECAftersale
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/getaftersalelist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/aftersale/getaftersalelist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleGetAftersaleListResponse> ExecuteChannelsECAftersaleGetAftersaleListAsync(this WechatApiClient client, Models.ChannelsECAftersaleGetAftersaleListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "getaftersalelist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleGetAftersaleListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/getaftersaleorder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/aftersale/getaftersaleorder.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleGetAftersaleOrderResponse> ExecuteChannelsECAftersaleGetAftersaleOrderAsync(this WechatApiClient client, Models.ChannelsECAftersaleGetAftersaleOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "getaftersaleorder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleGetAftersaleOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/acceptapply 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/aftersale/acceptapply.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleAcceptApplyResponse> ExecuteChannelsECAftersaleAcceptApplyAsync(this WechatApiClient client, Models.ChannelsECAftersaleAcceptApplyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "acceptapply")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleAcceptApplyResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/rejectapply 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/aftersale/rejectapply.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleRejectApplyResponse> ExecuteChannelsECAftersaleRejectApplyAsync(this WechatApiClient client, Models.ChannelsECAftersaleRejectApplyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "rejectapply")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleRejectApplyResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/uploadrefundcertificate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/aftersale/uploadrefundcertificate.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleUploadRefundCertificateResponse> ExecuteChannelsECAftersaleUploadRefundCertificateAsync(this WechatApiClient client, Models.ChannelsECAftersaleUploadRefundCertificateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "uploadrefundcertificate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleUploadRefundCertificateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region ECAftersale/Complaint
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/addcomplaintmaterial 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/complaint/addcomplaintmaterial.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleAddComplaintMaterialResponse> ExecuteChannelsECAftersaleAddComplaintMaterialAsync(this WechatApiClient client, Models.ChannelsECAftersaleAddComplaintMaterialRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "addcomplaintmaterial")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleAddComplaintMaterialResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/addcomplaintproof 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/complaint/addcomplaintproof.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleAddComplaintProofResponse> ExecuteChannelsECAftersaleAddComplaintProofAsync(this WechatApiClient client, Models.ChannelsECAftersaleAddComplaintProofRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "addcomplaintproof")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleAddComplaintProofResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/getcomplaintorder 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/complaint/getcomplaintorder.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleGetComplaintOrderResponse> ExecuteChannelsECAftersaleGetComplaintOrderAsync(this WechatApiClient client, Models.ChannelsECAftersaleGetComplaintOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "getcomplaintorder")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleGetComplaintOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECAftersale/Reason
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/reason/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/aftersale/getaftersalereason.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleReasonGetResponse> ExecuteChannelsECAftersaleReasonGetAsync(this WechatApiClient client, Models.ChannelsECAftersaleReasonGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "reason", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleReasonGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/aftersale/rejectreason/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/aftersale/getrejectreason.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECAftersaleRejectReasonGetResponse> ExecuteChannelsECAftersaleRejectReasonGetAsync(this WechatApiClient client, Models.ChannelsECAftersaleRejectReasonGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "aftersale", "rejectreason", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECAftersaleRejectReasonGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region ECBasics
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/basics/img/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/basics/img_upload.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsImageUploadResponse> ExecuteChannelsECBasicsImageUploadAsync(this WechatApiClient client, Models.ChannelsECBasicsImageUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "basics", "img", "upload")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("resp_type", request.ResponseType);

            if (request.ImageUrl is not null)
            {
                flurlReq.SetQueryParam("upload_type", 1)
                        .SetQueryParam("img_url", request.ImageUrl);

                return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBasicsImageUploadResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                flurlReq.SetQueryParam("upload_type", 0)
                        .SetQueryParam("height", request.Height)
                        .SetQueryParam("width", request.Width);

                using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: "image.png", fileBytes: request.ImageFileBytes!, fileContentType: "image/png", formDataName: "media");
                return await client.SendFlurlRequestAsync<Models.ChannelsECBasicsImageUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// <para>异步调用 [GET] /channels/ec/basics/info/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/basics/getbasicinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsInfoGetResponse> ExecuteChannelsECBasicsInfoGetAsync(this WechatApiClient client, Models.ChannelsECBasicsInfoGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "channels", "ec", "basics", "info", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBasicsInfoGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/basics/qualification/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/basics/qualificationupload.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsQualificationUploadResponse> ExecuteChannelsECBasicsQualificationUploadAsync(this WechatApiClient client, Models.ChannelsECBasicsQualificationUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName is null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".png";

            if (request.FileContentType is null)
                request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForImage(request.FileName!) ?? "image/png";

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "basics", "qualification", "upload")
                .SetQueryParam("access_token", request.AccessToken);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, formDataName: "media");
            return await client.SendFlurlRequestAsync<Models.ChannelsECBasicsQualificationUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/basics/addresscode/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/basics/getaddresscode.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsAddressCodeGetResponse> ExecuteChannelsECBasicsAddressCodeGetAsync(this WechatApiClient client, Models.ChannelsECBasicsAddressCodeGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "basics", "addresscode", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBasicsAddressCodeGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /channels/ec/basics/media/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/basics/getdatabymediaid.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsMediaGetResponse> ExecuteChannelsECBasicsMediaGetAsync(this WechatApiClient client, Models.ChannelsECBasicsMediaGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "channels", "ec", "basics", "media", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("media_id", request.MediaId);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBasicsMediaGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECBrand
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/all 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/brand/all_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBrandAllResponse> ExecuteChannelsECBrandAllAsync(this WechatApiClient client, Models.ChannelsECBrandAllRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "brand", "all")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBrandAllResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/brand/add.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBrandAddResponse> ExecuteChannelsECBrandAddAsync(this WechatApiClient client, Models.ChannelsECBrandAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "brand", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBrandAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/brand/update.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBrandUpdateResponse> ExecuteChannelsECBrandUpdateAsync(this WechatApiClient client, Models.ChannelsECBrandUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "brand", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBrandUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/audit/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/brand/audit_cancel.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBrandAuditCancelResponse> ExecuteChannelsECBrandAuditCancelAsync(this WechatApiClient client, Models.ChannelsECBrandAuditCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "brand", "audit", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBrandAuditCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/brand/delete.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBrandDeleteResponse> ExecuteChannelsECBrandDeleteAsync(this WechatApiClient client, Models.ChannelsECBrandDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "brand", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBrandDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/brand/get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBrandGetResponse> ExecuteChannelsECBrandGetAsync(this WechatApiClient client, Models.ChannelsECBrandGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "brand", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBrandGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/brand/list_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBrandListGetResponse> ExecuteChannelsECBrandListGetAsync(this WechatApiClient client, Models.ChannelsECBrandListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "brand", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBrandListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/brand/valid/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/brand/valid_list_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBrandValidListGetResponse> ExecuteChannelsECBrandValidListGetAsync(this WechatApiClient client, Models.ChannelsECBrandValidListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "brand", "valid", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECBrandValidListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECCategory
        /// <summary>
        /// <para>异步调用 [GET] /channels/ec/category/all 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/category/getallcategory.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCategoryAllResponse> ExecuteChannelsECCategoryAllAsync(this WechatApiClient client, Models.ChannelsECCategoryAllRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "channels", "ec", "category", "all")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCategoryAllResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/category/detail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/category/getcategorydetail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCategoryDetailResponse> ExecuteChannelsECCategoryDetailAsync(this WechatApiClient client, Models.ChannelsECCategoryDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "category", "detail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCategoryDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/category/availablesoncategories/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/category/getavailablesoncategories.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCategoryAvailableSonCategoriesGetResponse> ExecuteChannelsECCategoryAvailableSonCategoriesGetAsync(this WechatApiClient client, Models.ChannelsECCategoryAvailableSonCategoriesGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "category", "availablesoncategories", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCategoryAvailableSonCategoriesGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/category/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/category/add.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCategoryAddResponse> ExecuteChannelsECCategoryAddAsync(this WechatApiClient client, Models.ChannelsECCategoryAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "category", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCategoryAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/category/audit/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/category/audit_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCategoryAuditGetResponse> ExecuteChannelsECCategoryAuditGetAsync(this WechatApiClient client, Models.ChannelsECCategoryAuditGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "category", "audit", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCategoryAuditGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/category/audit/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/category/cancelauditcategory.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCategoryAuditCancelResponse> ExecuteChannelsECCategoryAuditCancelAsync(this WechatApiClient client, Models.ChannelsECCategoryAuditCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "category", "audit", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCategoryAuditCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /channels/ec/category/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/category/getavailablebizcat.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCategoryListGetResponse> ExecuteChannelsECCategoryListGetAsync(this WechatApiClient client, Models.ChannelsECCategoryListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "channels", "ec", "category", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCategoryListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECCoupon
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/coupon/create 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/coupon/create.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCouponCreateResponse> ExecuteChannelsECCouponCreateAsync(this WechatApiClient client, Models.ChannelsECCouponCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "coupon", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCouponCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/coupon/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/coupon/update.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCouponUpdateResponse> ExecuteChannelsECCouponUpdateAsync(this WechatApiClient client, Models.ChannelsECCouponUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "coupon", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCouponUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/coupon/update_status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/coupon/update_status.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCouponUpdateStatusResponse> ExecuteChannelsECCouponUpdateStatusAsync(this WechatApiClient client, Models.ChannelsECCouponUpdateStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "coupon", "update_status")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCouponUpdateStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/coupon/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/coupon/get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCouponGetResponse> ExecuteChannelsECCouponGetAsync(this WechatApiClient client, Models.ChannelsECCouponGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "coupon", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCouponGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/coupon/get_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/coupon/get_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCouponGetListResponse> ExecuteChannelsECCouponGetListAsync(this WechatApiClient client, Models.ChannelsECCouponGetListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "coupon", "get_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCouponGetListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/coupon/get_user_coupon_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/coupon/get_user_coupon_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCouponGetUserCouponListResponse> ExecuteChannelsECCouponGetUserCouponListAsync(this WechatApiClient client, Models.ChannelsECCouponGetUserCouponListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "coupon", "get_user_coupon_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCouponGetUserCouponListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/coupon/get_user_coupon 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/coupon/get_user_coupon.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCouponGetUserCouponResponse> ExecuteChannelsECCouponGetUserCouponAsync(this WechatApiClient client, Models.ChannelsECCouponGetUserCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "coupon", "get_user_coupon")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECCouponGetUserCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECFinderLive
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/finderlive/getfinderliverecordlist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/live/getfinderliverecordlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ECFinderLiveGetFinderLiveRecordListResponse> ExecuteECFinderLiveGetFinderLiveRecordListAsync(this WechatApiClient client, Models.ECFinderLiveGetFinderLiveRecordListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "finderlive", "getfinderliverecordlist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ECFinderLiveGetFinderLiveRecordListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/finderlive/getfinderlivenoticerecordlist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/live/getfinderlivenoticerecordlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ECFinderLiveGetFinderLiveNoticeRecordListResponse> ExecuteECFinderLiveGetFinderLiveNoticeRecordListAsync(this WechatApiClient client, Models.ECFinderLiveGetFinderLiveNoticeRecordListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "finderlive", "getfinderlivenoticerecordlist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ECFinderLiveGetFinderLiveNoticeRecordListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECFunds
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/funds/getbalance 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/funds/getbalance.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECFundsGetBalanceResponse> ExecuteChannelsECFundsGetBalanceAsync(this WechatApiClient client, Models.ChannelsECFundsGetBalanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "funds", "getbalance")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECFundsGetBalanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region ECFunds/BankAccount
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/funds/getbankacct 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/funds/getbankacct.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECFundsGetBankAccountResponse> ExecuteChannelsECFundsGetBankAccountAsync(this WechatApiClient client, Models.ChannelsECFundsGetBankAccountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "funds", "getbankacct")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECFundsGetBankAccountResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/funds/setbankacct 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/funds/setbankacct.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECFundsSetBankAccountResponse> ExecuteChannelsECFundsSetBankAccountAsync(this WechatApiClient client, Models.ChannelsECFundsSetBankAccountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "funds", "setbankacct")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECFundsSetBankAccountResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECFunds/Withdraw
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/funds/getwithdrawdetail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/funds/getwithdrawdetail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECGetWithdrawDetailResponse> ExecuteChannelsECGetWithdrawDetailAsync(this WechatApiClient client, Models.ChannelsECGetWithdrawDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "funds", "getwithdrawdetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECGetWithdrawDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/funds/getwithdrawlist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/funds/getwithdrawlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECGetWithdrawListResponse> ExecuteChannelsECGetWithdrawListAsync(this WechatApiClient client, Models.ChannelsECGetWithdrawListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "funds", "getwithdrawlist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECGetWithdrawListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/funds/submitwithdraw 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/funds/submitwithdraw.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECFundsSubmitWithdrawResponse> ExecuteChannelsECFundsSubmitWithdrawAsync(this WechatApiClient client, Models.ChannelsECFundsSubmitWithdrawRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "funds", "submitwithdraw")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECFundsSubmitWithdrawResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region ECLeague
        #region ECLeague/Funds
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/funds/getfundsflowdetail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_getfundsflowdetail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueFundsGetFundsFlowDetailResponse> ExecuteChannelsECLeagueFundsGetFundsFlowDetailAsync(this WechatApiClient client, Models.ChannelsECLeagueFundsGetFundsFlowDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "funds", "getfundsflowdetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueFundsGetFundsFlowDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/funds/getfundsflowlist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_getfundsflowlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueFundsGetFundsFlowListResponse> ExecuteChannelsECLeagueFundsGetFundsFlowListAsync(this WechatApiClient client, Models.ChannelsECLeagueFundsGetFundsFlowListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "funds", "getfundsflowlist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueFundsGetFundsFlowListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLeague/HeadSupplier
        #region ECLeague/HeadSupplier/Funds
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/funds/balance/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getbalance.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierFundsBalanceGetResponse> ExecuteChannelsECLeagueHeadSupplierFundsBalanceGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierFundsBalanceGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "funds", "balance", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierFundsBalanceGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/funds/flowdetail/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getfundsflowdeatail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierFundsFlowDetailGetResponse> ExecuteChannelsECLeagueHeadSupplierFundsFlowDetailGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierFundsFlowDetailGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "funds", "flowdetail", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierFundsFlowDetailGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/funds/flowlist/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getfundsflowlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierFundsFlowListGetResponse> ExecuteChannelsECLeagueHeadSupplierFundsFlowListGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierFundsFlowListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "funds", "flowlist", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierFundsFlowListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLeague/HeadSupplier/Item
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/item/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getitemlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierItemListGetResponse> ExecuteChannelsECLeagueHeadSupplierItemListGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierItemListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "item", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierItemListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/item/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getitem.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierItemGetResponse> ExecuteChannelsECLeagueHeadSupplierItemGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierItemGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "item", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierItemGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/item/upd 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/updateitem.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierItemUpdateResponse> ExecuteChannelsECLeagueHeadSupplierItemUpdateAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierItemUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "item", "upd")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierItemUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLeague/HeadSupplier/Order
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/order/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getorderlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierOrderListGetResponse> ExecuteChannelsECLeagueHeadSupplierOrderListGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierOrderListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "order", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierOrderListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/order/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getorder.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierOrderGetResponse> ExecuteChannelsECLeagueHeadSupplierOrderGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierOrderGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "order", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierOrderGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLeague/HeadSupplier/Shop
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/shop/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getshoplist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierShopListGetResponse> ExecuteChannelsECLeagueHeadSupplierShopListGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierShopListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "shop", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierShopListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/shop/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getshop.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierShopGetResponse> ExecuteChannelsECLeagueHeadSupplierShopGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierShopGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "shop", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierShopGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLeague/HeadSupplier/Window
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/window/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/windowproduct/add.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierWindowAddResponse> ExecuteChannelsECLeagueHeadSupplierWindowAddAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierWindowAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "window", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierWindowAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/window/remove 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/removewindow.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierWindowRemoveResponse> ExecuteChannelsECLeagueHeadSupplierWindowRemoveAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierWindowRemoveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "window", "remove")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierWindowRemoveResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/window/getall 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getallwindow.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierWindowGetAllResponse> ExecuteChannelsECLeagueHeadSupplierWindowGetAllAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierWindowGetAllRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "window", "getall")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierWindowGetAllResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/window/getdetail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getwindowdetail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierWindowGetDetailResponse> ExecuteChannelsECLeagueHeadSupplierWindowGetDetailAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierWindowGetDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "window", "getdetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierWindowGetDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/windowauth/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getauth.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierWindowAuthGetResponse> ExecuteChannelsECLeagueHeadSupplierWindowAuthGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierWindowAuthGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "windowauth", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierWindowAuthGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/headsupplier/windowauth/status/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leagueheadsupplier/getauthstatus.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueHeadSupplierWindowAuthStatusGetResponse> ExecuteChannelsECLeagueHeadSupplierWindowAuthStatusGetAsync(this WechatApiClient client, Models.ChannelsECLeagueHeadSupplierWindowAuthStatusGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "headsupplier", "windowauth", "status", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueHeadSupplierWindowAuthStatusGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region ECLeague/Item
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/item/batchadd 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_batchadditem.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueItemBatchAddResponse> ExecuteChannelsECLeagueItemBatchAddAsync(this WechatApiClient client, Models.ChannelsECLeagueItemBatchAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "item", "batchadd")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueItemBatchAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/item/upd 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_upditem.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueItemUpdateResponse> ExecuteChannelsECLeagueItemUpdateAsync(this WechatApiClient client, Models.ChannelsECLeagueItemUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "item", "upd")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueItemUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/item/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_deleteitem.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueItemDeleteResponse> ExecuteChannelsECLeagueItemDeleteAsync(this WechatApiClient client, Models.ChannelsECLeagueItemDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "item", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueItemDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/item/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_getitem.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueItemGetResponse> ExecuteChannelsECLeagueItemGetAsync(this WechatApiClient client, Models.ChannelsECLeagueItemGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "item", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueItemGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/item/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_getitemlist.htmll ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeagueItemListGetResponse> ExecuteChannelsECLeagueItemListGetAsync(this WechatApiClient client, Models.ChannelsECLeagueItemListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "item", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeagueItemListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLeague/Promoter
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/promoter/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_addpromoter.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeaguePromoterAddResponse> ExecuteChannelsECLeaguePromoterAddAsync(this WechatApiClient client, Models.ChannelsECLeaguePromoterAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "promoter", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeaguePromoterAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/promoter/upd 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_updpromoter.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeaguePromoterUpdateResponse> ExecuteChannelsECLeaguePromoterUpdateAsync(this WechatApiClient client, Models.ChannelsECLeaguePromoterUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "promoter", "upd")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeaguePromoterUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/promoter/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_deletepromoter.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeaguePromoterDeleteResponse> ExecuteChannelsECLeaguePromoterDeleteAsync(this WechatApiClient client, Models.ChannelsECLeaguePromoterDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "promoter", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeaguePromoterDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/promoter/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_getpromoter.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeaguePromoterGetResponse> ExecuteChannelsECLeaguePromoterGetAsync(this WechatApiClient client, Models.ChannelsECLeaguePromoterGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "promoter", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeaguePromoterGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/league/promoter/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/league/ecleague_getpromoterlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLeaguePromoterListGetResponse> ExecuteChannelsECLeaguePromoterListGetAsync(this WechatApiClient client, Models.ChannelsECLeaguePromoterListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "league", "promoter", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLeaguePromoterListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region ECLogistics
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/phonenumberpool/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/logistics/delivery_virtual_number.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsPhoneNumberPoolGetResponse> ExecuteChannelsECLogisticsPhoneNumberPoolGetAsync(this WechatApiClient client, Models.ChannelsECLogisticsPhoneNumberPoolGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "phonenumberpool", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsPhoneNumberPoolGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/phonenumber/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/logistics/delivery_virtual_number_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsPhoneNumberGetResponse> ExecuteChannelsECLogisticsPhoneNumberGetAsync(this WechatApiClient client, Models.ChannelsECLogisticsPhoneNumberGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "phonenumber", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsPhoneNumberGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/virtualnumber/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/logistics/delivery_virtual_number_get_virtual.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsVirtualNumberGetResponse> ExecuteChannelsECLogisticsVirtualNumberGetAsync(this WechatApiClient client, Models.ChannelsECLogisticsVirtualNumberGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "virtualnumber", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsVirtualNumberGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region ECLogistics/EWaybill
        #region ECLogistics/EWaybill/Account
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/account/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/get_account.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillAccountGetResponse> ExecuteChannelsECLogisticsEWaybillAccountGetAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillAccountGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "account", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillAccountGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLogistics/EWaybill/Delivery
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/delivery/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/get_acctdeliverylist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillDeliveryGetResponse> ExecuteChannelsECLogisticsEWaybillDeliveryGetAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillDeliveryGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "delivery", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillDeliveryGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLogistics/EWaybill/Order
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/order/precreate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/precreate_order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillOrderPrecreateResponse> ExecuteChannelsECLogisticsEWaybillOrderPrecreateAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillOrderPrecreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "order", "precreate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillOrderPrecreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/order/create 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/create_order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillOrderCreateResponse> ExecuteChannelsECLogisticsEWaybillOrderCreateAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillOrderCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "order", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillOrderCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/order/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/cancel_order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillOrderCancelResponse> ExecuteChannelsECLogisticsEWaybillOrderCancelAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillOrderCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "order", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillOrderCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/order/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/get_order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillOrderGetResponse> ExecuteChannelsECLogisticsEWaybillOrderGetAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillOrderGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "order", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillOrderGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/order/print 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/notify_print.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillOrderPrintResponse> ExecuteChannelsECLogisticsEWaybillOrderPrintAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillOrderPrintRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "order", "print")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillOrderPrintResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/order/batchprint 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/batchnotify_print.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillOrderBatchPrintResponse> ExecuteChannelsECLogisticsEWaybillOrderBatchPrintAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillOrderBatchPrintRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "order", "batchprint")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillOrderBatchPrintResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLogistics/EWaybill/Print
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/print/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/get_print_info.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillPrintGetResponse> ExecuteChannelsECLogisticsEWaybillPrintGetAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillPrintGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "print", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillPrintGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECLogistics/EWaybill/Template
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/template/config 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/get_template_config.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillTemplateConfigResponse> ExecuteChannelsECLogisticsEWaybillTemplateConfigAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillTemplateConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "template", "config")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillTemplateConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/template/create 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/add_template.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillTemplateCreateResponse> ExecuteChannelsECLogisticsEWaybillTemplateCreateAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillTemplateCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "template", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillTemplateCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/template/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/update_template.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillTemplateUpdateResponse> ExecuteChannelsECLogisticsEWaybillTemplateUpdateAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillTemplateUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "template", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillTemplateUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/template/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/delete_template.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillTemplateDeleteResponse> ExecuteChannelsECLogisticsEWaybillTemplateDeleteAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillTemplateDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "template", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillTemplateDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/template/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/get_template.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillTemplateGetResponse> ExecuteChannelsECLogisticsEWaybillTemplateGetAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillTemplateGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "template", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillTemplateGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/logistics/ewaybill/biz/template/getbyid 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/ewaybill/get_templatebyid.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECLogisticsEWaybillTemplateGetByIdResponse> ExecuteChannelsECLogisticsEWaybillTemplateGetByIdAsync(this WechatApiClient client, Models.ChannelsECLogisticsEWaybillTemplateGetByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "logistics", "ewaybill", "biz", "template", "getbyid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECLogisticsEWaybillTemplateGetByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion
        #endregion

        #region ECMerchant
        #region ECMerchant/FreightTemplate
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/getfreighttemplatelist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/deliverycompanylist_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECMerchantGetFreightTemplateListResponse> ExecuteChannelsECMerchantGetFreightTemplateListAsync(this WechatApiClient client, Models.ChannelsECMerchantGetFreightTemplateListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "getfreighttemplatelist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECMerchantGetFreightTemplateListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/getfreighttemplatedetail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/merchant/getfreighttemplatedetail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECMerchantGetFreightTemplateDetailResponse> ExecuteChannelsECMerchantGetFreightTemplateDetailAsync(this WechatApiClient client, Models.ChannelsECMerchantGetFreightTemplateDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "getfreighttemplatedetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECMerchantGetFreightTemplateDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/addfreighttemplate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/merchant/addfreighttemplate.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECMerchantAddFreightTemplateResponse> ExecuteChannelsECMerchantAddFreightTemplateAsync(this WechatApiClient client, Models.ChannelsECMerchantAddFreightTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "addfreighttemplate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECMerchantAddFreightTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/updatefreighttemplate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/merchant/updatefreighttemplate.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECMerchantUpdateFreightTemplateResponse> ExecuteChannelsECMerchantUpdateFreightTemplateAsync(this WechatApiClient client, Models.ChannelsECMerchantUpdateFreightTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "updatefreighttemplate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECMerchantUpdateFreightTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECMerchant/Address
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/address/list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/merchant/address/list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECMerchantAddressListResponse> ExecuteChannelsECMerchantAddressListAsync(this WechatApiClient client, Models.ChannelsECMerchantAddressListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "address", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECMerchantAddressListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/address/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/merchant/address/get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECMerchantAddressGetResponse> ExecuteChannelsECMerchantAddressGetAsync(this WechatApiClient client, Models.ChannelsECMerchantAddressGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "address", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECMerchantAddressGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/address/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/merchant/address/add.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECMerchantAddressAddResponse> ExecuteChannelsECMerchantAddressAddAsync(this WechatApiClient client, Models.ChannelsECMerchantAddressAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "address", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECMerchantAddressAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/address/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/merchant/address/update.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECMerchantAddressUpdateResponse> ExecuteChannelsECMerchantAddressUpdateAsync(this WechatApiClient client, Models.ChannelsECMerchantAddressUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "address", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECMerchantAddressUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/merchant/address/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/merchant/address/delete.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECMerchantAddressDeleteResponse> ExecuteChannelsECMerchantAddressDeleteAsync(this WechatApiClient client, Models.ChannelsECMerchantAddressDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "merchant", "address", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECMerchantAddressDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region ECOrder
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/search 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/search.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderSearchResponse> ExecuteChannelsECOrderSearchAsync(this WechatApiClient client, Models.ChannelsECOrderSearchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "search")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderSearchResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/list_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderListGetResponse> ExecuteChannelsECOrderListGetAsync(this WechatApiClient client, Models.ChannelsECOrderListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderGetResponse> ExecuteChannelsECOrderGetAsync(this WechatApiClient client, Models.ChannelsECOrderGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/price/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/price_update.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderPriceUpdateResponse> ExecuteChannelsECOrderPriceUpdateAsync(this WechatApiClient client, Models.ChannelsECOrderPriceUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "price", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderPriceUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/merchantnotes/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/merchantnotes_update.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderMerchantNotesUpdateResponse> ExecuteChannelsECOrderMerchantNotesUpdateAsync(this WechatApiClient client, Models.ChannelsECOrderMerchantNotesUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "merchantnotes", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderMerchantNotesUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/sensitiveinfo/decode 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/decode_order_sensitive_info.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderSensitiveInfoDecodeResponse> ExecuteChannelsECOrderSensitiveInfoDecodeAsync(this WechatApiClient client, Models.ChannelsECOrderSensitiveInfoDecodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "sensitiveinfo", "decode")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderSensitiveInfoDecodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/virtualtelnumber/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/virtualtelnumber_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderVirtualTeleNumberGetResponse> ExecuteChannelsECOrderVirtualTeleNumberGetAsync(this WechatApiClient client, Models.ChannelsECOrderVirtualTeleNumberGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "virtualtelnumber", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderVirtualTeleNumberGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region ECOrder/Address
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/address/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/address_update.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderAddressUpdateResponse> ExecuteChannelsECOrderAddressUpdateAsync(this WechatApiClient client, Models.ChannelsECOrderAddressUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "address", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderAddressUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/addressmodify/accept 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/accept_address_modify_apply.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderAddressModifyAcceptResponse> ExecuteChannelsECOrderAddressModifyAcceptAsync(this WechatApiClient client, Models.ChannelsECOrderAddressModifyAcceptRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "addressmodify", "accept")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderAddressModifyAcceptResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/addressmodify/reject 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/reject_address_modify_apply.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderAddressModifyRejectResponse> ExecuteChannelsECOrderAddressModifyRejectAsync(this WechatApiClient client, Models.ChannelsECOrderAddressModifyRejectRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "addressmodify", "reject")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderAddressModifyRejectResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ECOrder/Delivery
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/deliverycompanylist/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/deliverycompanylist_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderDeliveryCompanyListGetResponse> ExecuteChannelsECOrderDeliveryCompanyListGetAsync(this WechatApiClient client, Models.ChannelsECOrderDeliveryCompanyListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "deliverycompanylist", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderDeliveryCompanyListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/delivery/send 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/delivery_send.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderDeliverySendResponse> ExecuteChannelsECOrderDeliverySendAsync(this WechatApiClient client, Models.ChannelsECOrderDeliverySendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "delivery", "send")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderDeliverySendResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/order/deliveryinfo/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/order/deliveryinfo_update.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECOrderDeliveryInfoUpdateResponse> ExecuteChannelsECOrderDeliveryInfoUpdateAsync(this WechatApiClient client, Models.ChannelsECOrderDeliveryInfoUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "order", "deliveryinfo", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECOrderDeliveryInfoUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion

        #region ECProduct
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/add.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductAddResponse> ExecuteChannelsECProductAddAsync(this WechatApiClient client, Models.ChannelsECProductAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/update.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductUpdateResponse> ExecuteChannelsECProductUpdateAsync(this WechatApiClient client, Models.ChannelsECProductUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/delete.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductDeleteResponse> ExecuteChannelsECProductDeleteAsync(this WechatApiClient client, Models.ChannelsECProductDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductGetResponse> ExecuteChannelsECProductGetAsync(this WechatApiClient client, Models.ChannelsECProductGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/list_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductListGetResponse> ExecuteChannelsECProductListGetAsync(this WechatApiClient client, Models.ChannelsECProductListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/listing 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/listing.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductListingResponse> ExecuteChannelsECProductListingAsync(this WechatApiClient client, Models.ChannelsECProductListingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "listing")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductListingResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/delisting 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/delisting.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductDelistingResponse> ExecuteChannelsECProductDelistingAsync(this WechatApiClient client, Models.ChannelsECProductDelistingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "delisting")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductDelistingResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/audit/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/audit_cancel.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductAuditCancelResponse> ExecuteChannelsECProductAuditCancelAsync(this WechatApiClient client, Models.ChannelsECProductAuditCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "audit", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductAuditCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/h5url/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/get_h5url.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductH5UrlGetResponse> ExecuteChannelsECProductH5UrlGetAsync(this WechatApiClient client, Models.ChannelsECProductH5UrlGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "h5url", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductH5UrlGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/taglink/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/get_taglink.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductTagLinkGetResponse> ExecuteChannelsECProductTagLinkGetAsync(this WechatApiClient client, Models.ChannelsECProductTagLinkGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "taglink", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductTagLinkGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/qrcode/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/get_qrcode.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductQrcodeGetResponse> ExecuteChannelsECProductQrcodeGetAsync(this WechatApiClient client, Models.ChannelsECProductQrcodeGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "qrcode", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductQrcodeGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region ECProduct/LimitedDiscountTask
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/limiteddiscounttask/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/limiteddiscounttask/add.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductLimitedDiscountTaskAddResponse> ExecuteChannelsECProductLimitedDiscountTaskAddAsync(this WechatApiClient client, Models.ChannelsECProductLimitedDiscountTaskAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "limiteddiscounttask", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductLimitedDiscountTaskAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/limiteddiscounttask/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/limiteddiscounttask/list_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductLimitedDiscountTaskListGetResponse> ExecuteChannelsECProductLimitedDiscountTaskListGetAsync(this WechatApiClient client, Models.ChannelsECProductLimitedDiscountTaskListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "limiteddiscounttask", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductLimitedDiscountTaskListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/limiteddiscounttask/stop 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/limiteddiscounttask/stop.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductLimitedDiscountTaskStopResponse> ExecuteChannelsECProductLimitedDiscountTaskStopAsync(this WechatApiClient client, Models.ChannelsECProductLimitedDiscountTaskStopRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "limiteddiscounttask", "stop")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductLimitedDiscountTaskStopResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/limiteddiscounttask/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/limiteddiscounttask/delete.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductLimitedDiscountTaskDeleteResponse> ExecuteChannelsECProductLimitedDiscountTaskDeleteAsync(this WechatApiClient client, Models.ChannelsECProductLimitedDiscountTaskDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "limiteddiscounttask", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductLimitedDiscountTaskDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECProduct/Stock
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/stock/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/stock_update.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductStockUpdateResponse> ExecuteChannelsECProductStockUpdateAsync(this WechatApiClient client, Models.ChannelsECProductStockUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "stock", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductStockUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/stock/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/get_stock.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductStockGetResponse> ExecuteChannelsECProductStockGetAsync(this WechatApiClient client, Models.ChannelsECProductStockGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "stock", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductStockGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/stock/batchget 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/batchget_stock.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductStockBatchGetResponse> ExecuteChannelsECProductStockBatchGetAsync(this WechatApiClient client, Models.ChannelsECProductStockBatchGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "stock", "batchget")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductStockBatchGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/product/stock/getflow 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/product/get_stock_flow.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECProductStockGetFlowResponse> ExecuteChannelsECProductStockGetFlowAsync(this WechatApiClient client, Models.ChannelsECProductStockGetFlowRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "product", "stock", "getflow")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECProductStockGetFlowResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region ECQIC
        /// <summary>
        /// <para>异步调用 [GET] /channels/ec/qic/inspect/config/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/qic/getinspectconfig.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECQICInspectConfigGetResponse> ExecuteChannelsECQICInspectConfigGetAsync(this WechatApiClient client, Models.ChannelsECQICInspectConfigGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "channels", "ec", "qic", "inspect", "config", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECQICInspectConfigGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /channels/ec/qic/inspect/submitconfig/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/qic/getinspectsubmitconfig.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECQICInspectSubmitConfigGetResponse> ExecuteChannelsECQICInspectSubmitConfigGetAsync(this WechatApiClient client, Models.ChannelsECQICInspectSubmitConfigGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "channels", "ec", "qic", "inspect", "submitconfig", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECQICInspectSubmitConfigGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/qic/inspect/code/print 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/qic/printinspectcode.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECQICInspectCodePrintResponse> ExecuteChannelsECQICInspectCodePrintAsync(this WechatApiClient client, Models.ChannelsECQICInspectCodePrintRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "qic", "inspect", "code", "print")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECQICInspectCodePrintResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/qic/inspect/submit 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/qic/submitinspectinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECQICInspectSubmitResponse> ExecuteChannelsECQICInspectSubmitAsync(this WechatApiClient client, Models.ChannelsECQICInspectSubmitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "qic", "inspect", "submit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECQICInspectSubmitResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECSharer
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/bind 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/sharer/bindsharer.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECSharerBindResponse> ExecuteChannelsECSharerBindAsync(this WechatApiClient client, Models.ChannelsECSharerBindRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "bind")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECSharerBindResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/unbind 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/sharer/unbindsharer.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECSharerUnbindResponse> ExecuteChannelsECSharerUnbindAsync(this WechatApiClient client, Models.ChannelsECSharerUnbindRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "unbind")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECSharerUnbindResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/search_sharer 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/sharer/search_sharer.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECSharerSearchSharerResponse> ExecuteChannelsECSharerSearchSharerAsync(this WechatApiClient client, Models.ChannelsECSharerSearchSharerRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "search_sharer")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECSharerSearchSharerResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/get_sharer_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/sharer/get_sharer_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECSharerGetSharerListResponse> ExecuteChannelsECSharerGetSharerListAsync(this WechatApiClient client, Models.ChannelsECSharerGetSharerListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "get_sharer_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECSharerGetSharerListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/get_sharer_order_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/sharer/get_sharer_order_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECSharerGetSharerOrderListResponse> ExecuteChannelsECSharerGetSharerOrderListAsync(this WechatApiClient client, Models.ChannelsECSharerGetSharerOrderListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "get_sharer_order_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECSharerGetSharerOrderListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/get_sharer_product_h5url 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/sharer/get_sharer_product_h5url.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECSharerGetSharerProductH5UrlResponse> ExecuteChannelsECSharerGetSharerProductH5UrlAsync(this WechatApiClient client, Models.ChannelsECSharerGetSharerProductH5UrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "get_sharer_product_h5url")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECSharerGetSharerProductH5UrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/get_sharer_product_taglink 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/sharer/get_sharer_product_taglink.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECSharerGetSharerProductTagLinkResponse> ExecuteChannelsECSharerGetSharerProductTagLinkAsync(this WechatApiClient client, Models.ChannelsECSharerGetSharerProductTagLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "get_sharer_product_taglink")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECSharerGetSharerProductTagLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/get_sharer_product_qrcode 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/sharer/get_sharer_product_qrcode.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECSharerGetSharerProductQrcodeResponse> ExecuteChannelsECSharerGetSharerProductQrcodeAsync(this WechatApiClient client, Models.ChannelsECSharerGetSharerProductQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "get_sharer_product_qrcode")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECSharerGetSharerProductQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/get_shop_finder_live_notice_sharer_url 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/sharer/promote_finder_notice.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECSharerGetShopFinderLiveNoticeSharerUrlResponse> ExecuteChannelsECSharerGetShopFinderLiveNoticeSharerUrlAsync(this WechatApiClient client, Models.ChannelsECSharerGetShopFinderLiveNoticeSharerUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "get_shop_finder_live_notice_sharer_url")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECSharerGetShopFinderLiveNoticeSharerUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/sharer/get_shop_finder_live_sharer_url 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/sharer/promote_finder_live.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECSharerGetShopFinderLiveSharerUrlResponse> ExecuteChannelsECSharerGetShopFinderLiveSharerUrlAsync(this WechatApiClient client, Models.ChannelsECSharerGetShopFinderLiveSharerUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "sharer", "get_shop_finder_live_sharer_url")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECSharerGetShopFinderLiveSharerUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ECVip
        #region ECVip/ExperienceValue
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/vip/experiencevalue/set 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/vip/experiencevalue/set.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECVipExperienceValueSetResponse> ExecuteChannelsECVipExperienceValueSetAsync(this WechatApiClient client, Models.ChannelsECVipExperienceValueSetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "vip", "experiencevalue", "set")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECVipExperienceValueSetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECVip/Grade
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/vip/grade/card/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/vip/grade/add.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECVipGradeCardAddResponse> ExecuteChannelsECVipGradeCardAddAsync(this WechatApiClient client, Models.ChannelsECVipGradeCardAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "vip", "grade", "card", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECVipGradeCardAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /channels/ec/vip/grade/card/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/vip/grade/get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECVipGradeCardGetResponse> ExecuteChannelsECVipGradeCardGetAsync(this WechatApiClient client, Models.ChannelsECVipGradeCardGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "channels", "ec", "vip", "grade", "card", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECVipGradeCardGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/vip/grade/card/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/vip/grade/add.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECVipGradeCardUpdateResponse> ExecuteChannelsECVipGradeCardUpdateAsync(this WechatApiClient client, Models.ChannelsECVipGradeCardUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "vip", "grade", "card", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECVipGradeCardUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECVip/Score
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/vip/score/set 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/vip/score/set_conf.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECVipScoreSetResponse> ExecuteChannelsECVipScoreSetAsync(this WechatApiClient client, Models.ChannelsECVipScoreSetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "vip", "score", "set")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECVipScoreSetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /channels/ec/vip/score/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/vip/score/get_conf.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECVipScoreGetResponse> ExecuteChannelsECVipScoreGetAsync(this WechatApiClient client, Models.ChannelsECVipScoreGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "channels", "ec", "vip", "score", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECVipScoreGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ECVip/User
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/vip/user/info/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/vip/member/get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECVipUserInfoGetResponse> ExecuteChannelsECVipUserInfoGetAsync(this WechatApiClient client, Models.ChannelsECVipUserInfoGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "vip", "user", "info", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECVipUserInfoGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/vip/user/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/vip/member/get_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECVipUserListGetResponse> ExecuteChannelsECVipUserListGetAsync(this WechatApiClient client, Models.ChannelsECVipUserListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "vip", "user", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECVipUserListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/vip/user/experiencevalue/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/vip/experiencevalue/update_user.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECVipUserExperienceValueUpdateResponse> ExecuteChannelsECVipUserExperienceValueUpdateAsync(this WechatApiClient client, Models.ChannelsECVipUserExperienceValueUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "vip", "user", "experiencevalue", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECVipUserExperienceValueUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/vip/user/grade/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/vip/grade/update_user.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECVipUserGradeUpdateResponse> ExecuteChannelsECVipUserGradeUpdateAsync(this WechatApiClient client, Models.ChannelsECVipUserGradeUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "vip", "user", "grade", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECVipUserGradeUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/vip/user/score/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/vip/score/get_user_score.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECVipUserScoreGetResponse> ExecuteChannelsECVipUserScoreGetAsync(this WechatApiClient client, Models.ChannelsECVipUserScoreGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "vip", "user", "score", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECVipUserScoreGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/vip/user/score/flowrecord/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/vip/score/get_user_flow_record.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECVipUserScoreFlowRecordGetResponse> ExecuteChannelsECVipUserScoreFlowRecordGetAsync(this WechatApiClient client, Models.ChannelsECVipUserScoreFlowRecordGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "vip", "user", "score", "flowrecord", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECVipUserScoreFlowRecordGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/vip/user/score/increase 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/vip/score/incr_user_score.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECVipUserScoreIncreaseResponse> ExecuteChannelsECVipUserScoreIncreaseAsync(this WechatApiClient client, Models.ChannelsECVipUserScoreIncreaseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "vip", "user", "score", "increase")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECVipUserScoreIncreaseResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/vip/user/score/decrease 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/vip/score/incr_user_score.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECVipUserScoreDecreaseResponse> ExecuteChannelsECVipUserScoreDecreaseAsync(this WechatApiClient client, Models.ChannelsECVipUserScoreDecreaseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "vip", "user", "score", "decrease")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECVipUserScoreDecreaseResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region ECWarehouse
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/create 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/warehouse/create.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWarehouseCreateResponse> ExecuteChannelsECWarehouseCreateAsync(this WechatApiClient client, Models.ChannelsECWarehouseCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWarehouseCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/warehouse/get_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWarehouseListGetResponse> ExecuteChannelsECWarehouseListGetAsync(this WechatApiClient client, Models.ChannelsECWarehouseListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWarehouseListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/warehouse/get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWarehouseGetResponse> ExecuteChannelsECWarehouseGetAsync(this WechatApiClient client, Models.ChannelsECWarehouseGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWarehouseGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/detail/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/warehouse/update_detail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWarehouseDetailUpdateResponse> ExecuteChannelsECWarehouseDetailUpdateAsync(this WechatApiClient client, Models.ChannelsECWarehouseDetailUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "detail", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWarehouseDetailUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Warehouse/CoverLocation
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/coverlocations/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/warehouse/add_coverlocations.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWarehouseCoverLocationsAddResponse> ExecuteChannelsECWarehouseCoverLocationsAddAsync(this WechatApiClient client, Models.ChannelsECWarehouseCoverLocationsAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "coverlocations", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWarehouseCoverLocationsAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/coverlocations/del 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/warehouse/del_coverlocations.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWarehouseCoverLocationsDeleteResponse> ExecuteChannelsECWarehouseCoverLocationsDeleteAsync(this WechatApiClient client, Models.ChannelsECWarehouseCoverLocationsDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "coverlocations", "del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWarehouseCoverLocationsDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Warehouse/Address
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/address/prioritysort/set 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/warehouse/set_prioritysort.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWarehouseAddressPrioritySortSetResponse> ExecuteChannelsECWarehouseAddressPrioritySortSetAsync(this WechatApiClient client, Models.ChannelsECWarehouseAddressPrioritySortSetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "address", "prioritysort", "set")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWarehouseAddressPrioritySortSetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/address/prioritysort/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/warehouse/get_prioritysort.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWarehouseAddressPrioritySortGetResponse> ExecuteChannelsECWarehouseAddressPrioritySortGetAsync(this WechatApiClient client, Models.ChannelsECWarehouseAddressPrioritySortGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "address", "prioritysort", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWarehouseAddressPrioritySortGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Warehouse/Address
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/stock/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/warehouse/update_stock.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWarehouseStockUpdateResponse> ExecuteChannelsECWarehouseStockUpdateAsync(this WechatApiClient client, Models.ChannelsECWarehouseStockUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "stock", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWarehouseStockUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/warehouse/stock/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/warehouse/get_stock.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWarehouseStockGetResponse> ExecuteChannelsECWarehouseStockGetAsync(this WechatApiClient client, Models.ChannelsECWarehouseStockGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "warehouse", "stock", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWarehouseStockGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region ECWindow
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/window/product/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/windowproduct/add.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWindowProductAddResponse> ExecuteChannelsECWindowProductAddAsync(this WechatApiClient client, Models.ChannelsECWindowProductAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "window", "product", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWindowProductAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/window/product/off 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/windowproduct/off.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWindowProductOffResponse> ExecuteChannelsECWindowProductOffAsync(this WechatApiClient client, Models.ChannelsECWindowProductOffRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "window", "product", "off")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWindowProductOffResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/window/product/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/windowproduct/get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWindowProductGetResponse> ExecuteChannelsECWindowProductGetAsync(this WechatApiClient client, Models.ChannelsECWindowProductGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "window", "product", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWindowProductGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/window/product/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/windowproduct/list_get.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWindowProductListGetResponse> ExecuteChannelsECWindowProductListGetAsync(this WechatApiClient client, Models.ChannelsECWindowProductListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "ec", "window", "product", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsECWindowProductListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region FinderLive
        /// <summary>
        /// <para>异步调用 [POST] /channels/finderlive/get_finder_attr_by_appid 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/live/get_finder_attr_by_appid.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsFinderLiveGetFinderAttributeByAppIdResponse> ExecuteChannelsFinderLiveGetFinderAttributeByAppIdAsync(this WechatApiClient client, Models.ChannelsFinderLiveGetFinderAttributeByAppIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "finderlive", "get_finder_attr_by_appid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsFinderLiveGetFinderAttributeByAppIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/finderlive/get_finder_live_data_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/live/get_finder_live_data_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsFinderLiveGetFinderLiveDataListResponse> ExecuteChannelsFinderLiveGetFinderLiveDataListAsync(this WechatApiClient client, Models.ChannelsFinderLiveGetFinderLiveDataListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "finderlive", "get_finder_live_data_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsFinderLiveGetFinderLiveDataListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/finderlive/get_finder_live_leads_data 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/live/get_finder_live_leads_data.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsFinderLiveGetFinderLeadsDataListResponse> ExecuteChannelsFinderLiveGetFinderLeadsDataListAsync(this WechatApiClient client, Models.ChannelsFinderLiveGetFinderLeadsDataListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "finderlive", "get_finder_live_leads_data")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsFinderLiveGetFinderLeadsDataListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Leads
        /// <summary>
        /// <para>异步调用 [POST] /channels/leads/get_leads_info_by_component_id 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leads/get_leads_info_by_component_id.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsLeadsGetLeadsInfoByComponentIdResponse> ExecuteChannelsLeadsGetLeadsInfoByComponentIdAsync(this WechatApiClient client, Models.ChannelsLeadsGetLeadsInfoByComponentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "leads", "get_leads_info_by_component_id")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsLeadsGetLeadsInfoByComponentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/leads/get_leads_info_by_request_id 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leads/get_leads_info_by_request_id.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsLeadsGetLeadsInfoByRequestIdResponse> ExecuteChannelsLeadsGetLeadsInfoByRequestIdAsync(this WechatApiClient client, Models.ChannelsLeadsGetLeadsInfoByRequestIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "leads", "get_leads_info_by_request_id")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsLeadsGetLeadsInfoByRequestIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/leads/get_leads_request_id 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leads/get_leads_request_id.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsLeadsGetLeadsRequestIdResponse> ExecuteChannelsLeadsGetLeadsRequestIdAsync(this WechatApiClient client, Models.ChannelsLeadsGetLeadsRequestIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "leads", "get_leads_request_id")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsLeadsGetLeadsRequestIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/leads/get_leads_component_promote_record 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leads/get_leads_component_promote_record.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsLeadsGetLeadsComponentPromoteRecordResponse> ExecuteChannelsLeadsGetLeadsComponentPromoteRecordAsync(this WechatApiClient client, Models.ChannelsLeadsGetLeadsComponentPromoteRecordRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "leads", "get_leads_component_promote_record")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsLeadsGetLeadsComponentPromoteRecordResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/leads/get_leads_component_id 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/leads/get_leads_component_id.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsLeadsGetLeadsComponentIdResponse> ExecuteChannelsLeadsGetLeadsComponentIdAsync(this WechatApiClient client, Models.ChannelsLeadsGetLeadsComponentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "channels", "leads", "get_leads_component_id")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.ChannelsLeadsGetLeadsComponentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
