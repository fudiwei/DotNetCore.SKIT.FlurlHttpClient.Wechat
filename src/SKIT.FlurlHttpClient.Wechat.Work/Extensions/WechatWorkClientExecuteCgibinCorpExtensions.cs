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
                .CreateRequest(HttpMethod.Get, "cgi-bin", "corp", "get_join_qrcode")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            if (request.SizeType.HasValue)
                flurlReq.SetQueryParam("size_type", request.SizeType.Value);

            return await client.SendRequestAsync<Models.CgibinCorpGetJoinQrcodeResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
