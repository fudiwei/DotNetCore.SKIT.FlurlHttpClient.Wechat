using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    using SKIT.FlurlHttpClient.Primitives;

    public static class WechatTenpayClientExecuteMerchantManageExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /mch-manage/mch-manage-records/sub-mchid/{sub_mchid} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014940381 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMerchantManageRecordsResponse> ExecuteQueryMerchantManageRecordsAsync(this WechatTenpayClient client, Models.QueryMerchantManageRecordsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "mch-manage", "mch-manage-records", "sub-mchid", request.SubMerchantId)
                .SetQueryParam("manage_record_type", request.ManageRecordType)
                .SetQueryParam("manage_record_state", request.ManageRecordState)
                .SetQueryParam("limit", request.Limit)
                .SetQueryParam("offset", request.Offset);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMerchantManageRecordsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mch-manage/mch-manage-records/{manage_record_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014940383 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantManageRecordResponse> ExecuteGetMerchantManageRecordAsync(this WechatTenpayClient client, Models.GetMerchantManageRecordRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "mch-manage", "mch-manage-records", request.ManageRecordId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantManageRecordResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mch-manage/mch-manage-records/{manage_record_id}/mch-manage-submissions 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014940417 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMerchantManageRecordSubmissionResponse> ExecuteCreateMerchantManageRecordSubmissionAsync(this WechatTenpayClient client, Models.CreateMerchantManageRecordSubmissionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mch-manage", "mch-manage-records", request.ManageRecordId, "mch-manage-submissions");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMerchantManageRecordSubmissionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mch-manage/submission-files/sub-mchid/{sub_mchid}/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4014940425 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadMerchantManageSubmissionFileResponse> ExecuteUploadMerchantManageSubmissionFileAsync(this WechatTenpayClient client, Models.UploadMerchantManageSubmissionFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName is null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower();

            if (request.FileHash is null)
                request.FileHash = EncodedString.ToHexString(Utilities.SHA256Utility.Hash(request.FileBytes)).Value!.ToLower();

            if (request.FileContentType is null)
                request.FileContentType = MimeTypes.GetMimeMapping(request.FileName!);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mch-manage", "submission-files", "sub-mchid", request.SubMerchantId, "upload");

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, fileMetaJson: client.JsonSerializer.Serialize(request), formDataName: "submission_file");
            httpContent.Add(new StringContent(request.ItemId), "item_id");
            return await client.SendFlurlRequestAsync<Models.UploadMerchantManageSubmissionFileResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
