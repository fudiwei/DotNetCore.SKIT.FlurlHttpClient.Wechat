using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance
{
    using SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance.InteropServices;

    /// <summary>
    /// 一个企业微信会话内容存档 API HTTP 客户端。
    /// </summary>
    public sealed class WechatWorkFinanceClient : CommonClientBase, ICommonClient, IWechatWorkFinanceClient, IDisposable
    {
        private static readonly object _lockObj = new object();

        private readonly int _timeout;
        private readonly string? _proxyAddress;
        private readonly string? _proxyAuthentication;

        private IntPtr _sdk;
        private bool _initialized;
        private bool _disposed;

        /// <summary>
        /// 获取当前客户端使用的企业微信凭证。
        /// </summary>
        public Settings.Credentials Credentials { get; }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="WechatWorkFinanceClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public WechatWorkFinanceClient(WechatWorkFinanceClientOptions options)
            : base()
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);

            _timeout = options.Timeout;
            _proxyAddress = options.ProxyAddress;
            _proxyAuthentication = options.ProxyAuthentication;

            _sdk = /* 申请用于构造 SDK 的内存空间 */
                IsRunOnWindows() ? FinanceDllWindowsPInvoker.NewSdk() :
                IsRunOnLinux() ? FinanceDllLinuxPInvoker.NewSdk() :
                throw new PlatformNotSupportedException();
        }

        ~WechatWorkFinanceClient()
        {
            Dispose(disposing: false);
        }

        private static bool IsRunOnWindows()
        {
#if NET471_OR_GREATER || NETSTANDARD
            return RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
#else
            return Environment.OSVersion.Platform == PlatformID.Win32NT;
#endif
        }

        private static bool IsRunOnLinux()
        {
#if NET471_OR_GREATER || NETSTANDARD
            return RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ||
                   RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
#elif NETFRAMEWORK
            return Environment.OSVersion.Platform == PlatformID.Unix ||
                   Environment.OSVersion.Platform == PlatformID.MacOSX;
#else
            return Environment.OSVersion.Platform == PlatformID.Unix;
#endif
        }

        public Task<Models.GetChatRecordsResponse> ExecuteGetChatRecordsAsync(Models.GetChatRecordsRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            EnsureInitialized();

            return Task.Run(() =>
            {
                IntPtr slice = /* 申请用于存储聊天记录数据的内存空间 */
                    IsRunOnWindows() ? FinanceDllWindowsPInvoker.NewSlice() :
                    IsRunOnLinux() ? FinanceDllLinuxPInvoker.NewSlice() :
                    throw new PlatformNotSupportedException();

                Models.GetChatRecordsResponse response = new Models.GetChatRecordsResponse();
                try
                {
                    int ret = /* 获取聊天记录数据 */
                        IsRunOnWindows() ? FinanceDllWindowsPInvoker.GetChatData(_sdk, request.LastSequence, request.Limit, _proxyAddress!, _proxyAuthentication!, (request.Timeout ?? _timeout) / 1000, slice) :
                        IsRunOnLinux() ? FinanceDllLinuxPInvoker.GetChatData(_sdk, request.LastSequence, request.Limit, _proxyAddress!, _proxyAuthentication!, (request.Timeout ?? _timeout) / 1000, slice) :
                        throw new PlatformNotSupportedException();
                    if (ret == 0)
                    {
                        //int sliceLength = /* 获取聊天记录数据内容长度 */
                        //    IsRunOnWindows() ? FinanceDllWindowsPInvoker.GetSliceLen(slice) :
                        //    IsRunOnLinux() ? FinanceDllLinuxPInvoker.GetSliceLen(slice) :
                        //    throw new PlatformNotSupportedException();
                        string sliceContent = /* 获取聊天记录数据内容 */
                            IsRunOnWindows() ? FinanceDllWindowsPInvoker.GetContentFromSlice(slice) :
                            IsRunOnLinux() ? FinanceDllLinuxPInvoker.GetContentFromSlice(slice) :
                            throw new PlatformNotSupportedException();

                        response = JsonSerializer.Deserialize<Models.GetChatRecordsResponse>(sliceContent);
                        response.RawBytes = Encoding.UTF8.GetBytes(sliceContent);
                    }

                    response.ReturnCode = ret;
                    return response;
                }
                catch (Exception ex)
                {
                    throw new WechatWorkFinanceException("Failed to fetch chat data.", ex);
                }
                finally
                {
                    if (IsRunOnWindows())
                        FinanceDllWindowsPInvoker.FreeSlice(slice);
                    else if (IsRunOnLinux())
                        FinanceDllLinuxPInvoker.FreeSlice(slice);
                }
            }, cancellationToken);
        }

        private void EnsureInitialized()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(WechatWorkFinanceClient));

            if (!_initialized)
            {
                lock (_lockObj)
                {
                    if (!_initialized)
                    {
                        int ret = /* 初始化 SDK */
                            IsRunOnWindows() ? FinanceDllWindowsPInvoker.Init(_sdk, Credentials.CorpId, Credentials.SecretKey) :
                            IsRunOnLinux() ? FinanceDllLinuxPInvoker.Init(_sdk, Credentials.CorpId, Credentials.SecretKey) :
                            throw new PlatformNotSupportedException();
                        if (ret != 0)
                            throw new WechatWorkFinanceException($"Failed to initialize Wechat Work Finance SDK (ret: {ret}).");

                        _initialized = true;
                    }
                }
            }
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // 释放托管资源
                }

                // 释放非托管资源
                IntPtr tmpptr = _sdk;
                if (tmpptr != IntPtr.Zero)
                {
                    if (IsRunOnWindows())
                        FinanceDllWindowsPInvoker.DestroySdk(tmpptr);
                    else if (IsRunOnLinux())
                        FinanceDllLinuxPInvoker.DestroySdk(tmpptr);

                    _sdk = IntPtr.Zero;
                }

                _disposed = true;
            }
        }

        public override void Dispose()
        {
            base.Dispose();

            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
