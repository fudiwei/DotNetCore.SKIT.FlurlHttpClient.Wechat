using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance
{
    /// <summary>
    /// 一个企业微信会话内容存档 API HTTP 客户端。
    /// </summary>
    public sealed class WechatWorkFinanceClient : IDisposable
    {
        private static readonly object _lockObj = new object();

        private readonly int _timeout; // （单位：秒）
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
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);

            _timeout = options.Timeout / 1000;
            _proxyAddress = options.ProxyAddress;
            _proxyAuthentication = options.ProxyAuthentication;

            _sdk = IsRunOnWindows() ? FinanceDllWindowsPInvoker.NewSdk() :
                   IsRunOnLinux() ? FinanceDllLinuxPInvoker.NewSdk() :
                   throw new PlatformNotSupportedException();
            // TODO: 接入会话内容存档
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
                        int ret = IsRunOnWindows() ? FinanceDllWindowsPInvoker.Init(_sdk, Credentials.CorpId, Credentials.SecretKey) :
                           IsRunOnLinux() ? FinanceDllLinuxPInvoker.Init(_sdk, Credentials.CorpId, Credentials.SecretKey) :
                           throw new PlatformNotSupportedException();
                        if (ret != 0)
                            throw new WechatWorkFinanceException($"Failed to initialize Wechat Work Finance SDK (code: {ret}).");

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

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
