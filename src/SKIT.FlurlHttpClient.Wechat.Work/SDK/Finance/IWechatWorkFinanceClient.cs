using System;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance
{
    public interface IWechatWorkFinanceClient : IDisposable
    {
        Task<Models.GetChatRecordsResponse> ExecuteGetChatRecordsAsync(Models.GetChatRecordsRequest request, CancellationToken cancellationToken = default);

        // TODO: 接入会话内容存档
    }
}
