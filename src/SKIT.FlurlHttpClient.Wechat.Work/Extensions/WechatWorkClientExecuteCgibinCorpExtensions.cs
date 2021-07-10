using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinCorpExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/corp/get_join_qrcode 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/91039 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGetJoinQrcodeResponse> ExecuteCgibinCorpGetJoinQrcodeAsync(this WechatWorkClient client, Models.CgibinCorpGetJoinQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "corp", "get_join_qrcode")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.SizeType.HasValue)
                flurlReq.SetQueryParam("size_type", request.SizeType.Value);

            return await client.SendRequestWithJsonAsync<Models.CgibinCorpGetJoinQrcodeResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/corp/getopenapprovaldata 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90269 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93798 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/91188 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGetOpenApprovalDataResponse> ExecuteCgibinCorpGetOpenApprovalDataAsync(this WechatWorkClient client, Models.CgibinCorpGetOpenApprovalDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "corp", "getopenapprovaldata")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCorpGetOpenApprovalDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
