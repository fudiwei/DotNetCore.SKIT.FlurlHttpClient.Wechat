using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    using SKIT.FlurlHttpClient.Primitives;

    public static class WechatTenpayClientExecuteMerchantOperationManageExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /mch-operation-manage/merchant-limitations/sub-mchid/{sub_mchid} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012803072 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantOperationManageMerchantLimitationsBySubMerchantIdResponse> ExecuteGetMerchantOperationManageMerchantLimitationsBySubMerchantIdAsync(this WechatTenpayClient client, Models.GetMerchantOperationManageMerchantLimitationsBySubMerchantIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "mch-operation-manage", "merchant-limitations", "sub-mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantOperationManageMerchantLimitationsBySubMerchantIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region EnhancedDueDiligence
        /// <summary>
        /// <para>异步调用 [POST] /mch-operation-manage/enhanced-due-diligence/{due_diligence_id}/submit 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015631033 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMerchantOperationManageEnhancedDueDiligenceSubmitResponse> ExecuteCreateMerchantOperationManageEnhancedDueDiligenceSubmitAsync(this WechatTenpayClient client, Models.CreateMerchantOperationManageEnhancedDueDiligenceSubmitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mch-operation-manage", "enhanced-due-diligence", request.DueDiligenceId, "submit");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMerchantOperationManageEnhancedDueDiligenceSubmitResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /mch-operation-manage/enhanced-due-diligence/{due_diligence_id}/upload 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015631033 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadMerchantOperationManageEnhancedDueDiligenceFileResponse> ExecuteUploadMerchantOperationManageEnhancedDueDiligenceFileAsync(this WechatTenpayClient client, Models.UploadMerchantOperationManageEnhancedDueDiligenceFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));


            if (request.FileName is null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".png";

            if (request.FileHash is null)
                request.FileHash = EncodedString.ToHexString(Utilities.SHA256Utility.Hash(request.FileBytes)).Value!.ToUpper();

            if (request.FileContentType is null)
                request.FileContentType = MimeTypes.GetMimeMapping(request.FileName!);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "mch-operation-manage", "enhanced-due-diligence", request.DueDiligenceId, "upload");

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, fileMetaJson: client.JsonSerializer.Serialize(request), formDataName: "due_diligence_file");
            return await client.SendFlurlRequestAsync<Models.UploadMerchantOperationManageEnhancedDueDiligenceFileResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mch-operation-manage/enhanced-due-diligence/{due_diligence_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015631048 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantOperationManageEnhancedDueDiligenceByDueDiligenceIdResponse> ExecuteGetMerchantOperationManageEnhancedDueDiligenceByDueDiligenceIdAsync(this WechatTenpayClient client, Models.GetMerchantOperationManageEnhancedDueDiligenceByDueDiligenceIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "mch-operation-manage", "enhanced-due-diligence", request.DueDiligenceId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantOperationManageEnhancedDueDiligenceByDueDiligenceIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
