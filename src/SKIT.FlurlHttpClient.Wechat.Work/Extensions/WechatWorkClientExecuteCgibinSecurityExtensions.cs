using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinSecurityExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/security/get_file_oper_record 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98079 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSecurityGetFileOperateRecordResponse> ExecuteCgibinSecurityGetFileOperateRecordAsync(this WechatWorkClient client, Models.CgibinSecurityGetFileOperateRecordRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "security", "get_file_oper_record")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinSecurityGetFileOperateRecordResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
