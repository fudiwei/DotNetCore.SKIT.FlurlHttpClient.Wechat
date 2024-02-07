using System;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.Finance
{
    public interface IWechatWorkFinanceClient : IDisposable
    {
        /// <summary>
        /// <para>异步调用会话内容存档之获取会话记录数据接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91774 ]]>
        /// </para>
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<Models.GetChatRecordsResponse> ExecuteGetChatRecordsAsync(Models.GetChatRecordsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// <para>异步调用会话内容存档之解密会话记录数据接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91774 ]]>
        /// </para>
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<Models.DecryptChatRecordResponse> ExecuteDecryptChatRecordAsync(Models.DecryptChatRecordRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// <para>异步调用会话内容存档之获取媒体文件分片接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91774 ]]>
        /// </para>
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<Models.GetMediaFileBufferResponse> ExecuteGetMediaFileBufferAsync(Models.GetMediaFileBufferRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// <para>异步调用会话内容存档之获取媒体文件接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91774 ]]>
        /// </para>
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<Models.GetMediaFileResponse> ExecuteGetMediaFileAsync(Models.GetMediaFileRequest request, CancellationToken cancellationToken = default);
    }
}
