using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.Finance
{
    using SKIT.FlurlHttpClient.Primitives;
    using SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.Finance.InteropServices;

    /// <summary>
    /// 一个企业微信会话内容存档 API HTTP 客户端。
    /// </summary>
    public sealed class WechatWorkFinanceClient : CommonClientBase, ICommonClient, IWechatWorkFinanceClient, IDisposable
    {
        private static readonly object _lockObj = new object();

        private readonly int _timeout;
        private readonly string? _proxyAddress;
        private readonly string? _proxyAuthentication;

        private IntPtr _sdkPtr;
        private bool _initialized;
        private bool _disposed;

        /// <summary>
        /// 获取当前客户端使用的企业微信会话内容存档凭证。
        /// </summary>
        public Settings.Credentials Credentials { get; }

        /// <summary>
        /// 获取当前客户端使用的企业微信会话内容存档消息加解密密钥管理器。
        /// </summary>
        public Settings.EncryptionKeyManager EncryptionKeyManager { get; }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="WechatWorkFinanceClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public WechatWorkFinanceClient(WechatWorkFinanceClientOptions options)
            : base()
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);
            EncryptionKeyManager = options.EncryptionKeyManager;

            _timeout = options.Timeout;
            _proxyAddress = options.ProxyAddress;
            _proxyAuthentication = options.ProxyAuthentication;

            _sdkPtr = /* 申请用于构造 SDK 的内存空间 */
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
                            IsRunOnWindows() ? FinanceDllWindowsPInvoker.Init(_sdkPtr, Credentials.CorpId, Credentials.SecretKey) :
                            IsRunOnLinux() ? FinanceDllLinuxPInvoker.Init(_sdkPtr, Credentials.CorpId, Credentials.SecretKey) :
                            throw new PlatformNotSupportedException();
                        if (ret != 0)
                            throw new WechatWorkFinanceException($"Failed to initialize Wechat Work Finance SDK (ret: {ret}).");

                        _initialized = true;
                    }
                }
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Models.GetChatRecordsResponse> ExecuteGetChatRecordsAsync(Models.GetChatRecordsRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null) throw new ArgumentNullException(nameof(request));

            EnsureInitialized();

            return Task.Run(() =>
            {
                IntPtr dataPtr = IntPtr.Zero;
                Action freeDataPtr = () =>
                {
                    if (dataPtr != IntPtr.Zero)
                    {
                        if (IsRunOnWindows()) FinanceDllWindowsPInvoker.FreeSlice(dataPtr);
                        else if (IsRunOnLinux()) FinanceDllLinuxPInvoker.FreeSlice(dataPtr);
                        else Marshal.FreeHGlobal(dataPtr);

                        dataPtr = IntPtr.Zero;
                    }
                };
                cancellationToken.Register(freeDataPtr);

                dataPtr = /* 申请用于存储聊天记录数据的内存空间 */
                    IsRunOnWindows() ? FinanceDllWindowsPInvoker.NewSlice() :
                    IsRunOnLinux() ? FinanceDllLinuxPInvoker.NewSlice() :
                    throw new PlatformNotSupportedException();

                Models.GetChatRecordsResponse response = new Models.GetChatRecordsResponse();
                try
                {
                    int ret = /* 获取聊天记录数据 */
                        IsRunOnWindows() ? FinanceDllWindowsPInvoker.GetChatData(_sdkPtr, request.LastSequence, request.Limit, _proxyAddress!, _proxyAuthentication!, (long)(request._InternalTimeout?.TotalMilliseconds ?? _timeout) / 1000, dataPtr) :
                        IsRunOnLinux() ? FinanceDllLinuxPInvoker.GetChatData(_sdkPtr, request.LastSequence, request.Limit, _proxyAddress!, _proxyAuthentication!, (long)(request._InternalTimeout?.TotalMilliseconds ?? _timeout) / 1000, dataPtr) :
                        throw new PlatformNotSupportedException();
                    if (ret == 0)
                    {
                        //int dataSize = /* 获取聊天记录数据内容长度 */
                        //    IsRunOnWindows() ? FinanceDllWindowsPInvoker.GetSliceLen(dataPtr) :
                        //    IsRunOnLinux() ? FinanceDllLinuxPInvoker.GetSliceLen(dataPtr) :
                        //    throw new PlatformNotSupportedException();
                        IntPtr dataContentPtr = /* 获取聊天记录数据内容 */
                            IsRunOnWindows() ? FinanceDllWindowsPInvoker.GetContentFromSlice(dataPtr) :
                            IsRunOnLinux() ? FinanceDllLinuxPInvoker.GetContentFromSlice(dataPtr) :
                            throw new PlatformNotSupportedException();
                        string dataContent = MarshalerHelper.PtrToStringUTF8(dataContentPtr);

                        response = JsonSerializer.Deserialize<Models.GetChatRecordsResponse>(dataContent);
                        response._InternalRawBytes = Encoding.UTF8.GetBytes(dataContent);
                    }

                    response.ReturnCode = ret;
                    return response;
                }
                catch (Exception ex)
                {
                    throw new WechatWorkFinanceException("Failed to fetch chat data. Please see the inner exception for more details.", ex);
                }
                finally
                {
                    freeDataPtr();
                }
            }, cancellationToken);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Models.DecryptChatRecordResponse> ExecuteDecryptChatRecordAsync(Models.DecryptChatRecordRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null) throw new ArgumentNullException(nameof(request));

            EnsureInitialized();

            return Task.Run(() =>
            {
                string encryptKey;

                try
                {
                    Settings.EncryptionKeyEntry? encryptionKeyEntry = EncryptionKeyManager.GetEntry(request.PublicKeyVersion);
                    if (!encryptionKeyEntry.HasValue)
                        throw new WechatWorkFinanceException($"Failed to decrypt random key of the encrypted chat data, because there is no private key matched the verion: \"{request.PublicKeyVersion}\".");

                    encryptKey = Utilities.RSAUtility.DecryptWithECB(
                        privateKeyPem: encryptionKeyEntry.Value.PrivateKey,
                        encodingCipher: new EncodedString(request.EncryptedRandomKey, EncodingKinds.Base64)
                    )!;
                }
                catch (WechatWorkFinanceException)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw new WechatWorkFinanceException("Failed to decrypt random key of the encrypted chat data. Please see the inner exception for more details.", ex);
                }

                IntPtr dataPtr = IntPtr.Zero;
                Action freeDataPtr = () =>
                {
                    if (dataPtr != IntPtr.Zero)
                    {
                        if (IsRunOnWindows()) FinanceDllWindowsPInvoker.FreeSlice(dataPtr);
                        else if (IsRunOnLinux()) FinanceDllLinuxPInvoker.FreeSlice(dataPtr);
                        else Marshal.FreeHGlobal(dataPtr);

                        dataPtr = IntPtr.Zero;
                    }
                };
                cancellationToken.Register(freeDataPtr);

                dataPtr = /* 申请用于存储聊天记录数据的内存空间 */
                    IsRunOnWindows() ? FinanceDllWindowsPInvoker.NewSlice() :
                    IsRunOnLinux() ? FinanceDllLinuxPInvoker.NewSlice() :
                    throw new PlatformNotSupportedException();

                Models.DecryptChatRecordResponse response = new Models.DecryptChatRecordResponse();
                try
                {
                    int ret = /* 解密聊天记录数据 */
                        IsRunOnWindows() ? FinanceDllWindowsPInvoker.DecryptData(encryptKey, request.EncryptedChatMessage, dataPtr) :
                        IsRunOnLinux() ? FinanceDllLinuxPInvoker.DecryptData(encryptKey, request.EncryptedChatMessage, dataPtr) :
                        throw new PlatformNotSupportedException();
                    if (ret == 0)
                    {
                        //int dataSize = /* 获取聊天记录数据内容长度 */
                        //    IsRunOnWindows() ? FinanceDllWindowsPInvoker.GetSliceLen(dataPtr) :
                        //    IsRunOnLinux() ? FinanceDllLinuxPInvoker.GetSliceLen(dataPtr) :
                        //    throw new PlatformNotSupportedException();
                        IntPtr dataContentPtr = /* 获取聊天记录数据内容 */
                            IsRunOnWindows() ? FinanceDllWindowsPInvoker.GetContentFromSlice(dataPtr) :
                            IsRunOnLinux() ? FinanceDllLinuxPInvoker.GetContentFromSlice(dataPtr) :
                            throw new PlatformNotSupportedException();
                        string dataContent = MarshalerHelper.PtrToStringUTF8(dataContentPtr);

                        try
                        {
                            response = JsonSerializer.Deserialize<Models.DecryptChatRecordResponse>(dataContent);
                        }
                        catch (System.Text.Json.JsonException)
                        {
                            // NOTICE: 某些情况下微信返回的 JSON 字符串中包含设备控制符，可能导致 System.Text.Json 反序列化抛出异常
                            if (JsonSerializer is SystemTextJsonSerializer)
                            {
                                string fixedDataContent = dataContent
                                    .Replace("\\u0011", string.Empty)
                                    .Replace("\\u0012", string.Empty)
                                    .Replace("\\u0013", string.Empty)
                                    .Replace("\\u0014", string.Empty);
                                response = JsonSerializer.Deserialize<Models.DecryptChatRecordResponse>(fixedDataContent);
                            }
                            else
                            {
                                throw;
                            }
                        }

                        response._InternalRawBytes = Encoding.UTF8.GetBytes(dataContent);
                    }

                    response.ReturnCode = ret;
                    return response;
                }
                catch (Exception ex)
                {
                    throw new WechatWorkFinanceException("Failed to decrypt chat data. Please see the inner exception for more details.", ex);
                }
                finally
                {
                    freeDataPtr();
                }
            }, cancellationToken);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Models.GetMediaFileBufferResponse> ExecuteGetMediaFileBufferAsync(Models.GetMediaFileBufferRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null) throw new ArgumentNullException(nameof(request));

            EnsureInitialized();

            return Task.Run(() =>
            {
                IntPtr dataPtr = IntPtr.Zero;
                Action freeDataPtr = () =>
                {
                    if (dataPtr != IntPtr.Zero)
                    {
                        if (IsRunOnWindows()) FinanceDllWindowsPInvoker.FreeMediaData(dataPtr);
                        else if (IsRunOnLinux()) FinanceDllLinuxPInvoker.FreeMediaData(dataPtr);
                        else Marshal.FreeHGlobal(dataPtr);

                        dataPtr = IntPtr.Zero;
                    }
                };
                cancellationToken.Register(freeDataPtr);

                dataPtr = /* 申请用于存储媒体文件数据的内存空间 */
                    IsRunOnWindows() ? FinanceDllWindowsPInvoker.NewMediaData() :
                    IsRunOnLinux() ? FinanceDllLinuxPInvoker.NewMediaData() :
                    throw new PlatformNotSupportedException();

                Models.GetMediaFileBufferResponse response = new Models.GetMediaFileBufferResponse();
                try
                {
                    int ret = /* 获取媒体文件数据 */
                        IsRunOnWindows() ? FinanceDllWindowsPInvoker.GetMediaData(_sdkPtr, request.BufferIndex ?? string.Empty, request.FileId, _proxyAddress!, _proxyAuthentication!, (long)(request._InternalTimeout?.TotalMilliseconds ?? _timeout) / 1000, dataPtr) :
                        IsRunOnLinux() ? FinanceDllLinuxPInvoker.GetMediaData(_sdkPtr, request.BufferIndex ?? string.Empty, request.FileId, _proxyAddress!, _proxyAuthentication!, (long)(request._InternalTimeout?.TotalMilliseconds ?? _timeout) / 1000, dataPtr) :
                        throw new PlatformNotSupportedException();
                    if (ret == 0)
                    {
                        int dataSize = /* 获取媒体文件数据内容长度 */
                            IsRunOnWindows() ? FinanceDllWindowsPInvoker.GetDataLen(dataPtr) :
                            IsRunOnLinux() ? FinanceDllLinuxPInvoker.GetDataLen(dataPtr) :
                            throw new PlatformNotSupportedException();
                        IntPtr dataContentPtr = /* 获取媒体文件数据内容 */
                            IsRunOnWindows() ? FinanceDllWindowsPInvoker.GetData(dataPtr) :
                            IsRunOnLinux() ? FinanceDllLinuxPInvoker.GetData(dataPtr) :
                            throw new PlatformNotSupportedException();
                        IntPtr dataNextBufferIndex = /* 获取媒体文件数据内容缓冲标识 */
                            IsRunOnWindows() ? FinanceDllWindowsPInvoker.GetOutIndexBuf(dataPtr) :
                            IsRunOnLinux() ? FinanceDllLinuxPInvoker.GetOutIndexBuf(dataPtr) :
                            throw new PlatformNotSupportedException();
                        int dataIsFinishFlag = /* 获取媒体文件数据内容完结标识 */
                            IsRunOnWindows() ? FinanceDllWindowsPInvoker.IsMediaDataFinish(dataPtr) :
                            IsRunOnLinux() ? FinanceDllLinuxPInvoker.IsMediaDataFinish(dataPtr) :
                            throw new PlatformNotSupportedException();

                        byte[] bytes = new byte[dataSize];
                        Marshal.Copy(dataContentPtr, bytes, 0, bytes.Length);

                        response._InternalRawBytes = bytes;
                        response.NextBufferIndex = MarshalerHelper.PtrToStringAnsi(dataNextBufferIndex);
                        response.IsFinished = dataIsFinishFlag != 0;
                    }

                    response.ReturnCode = ret;
                    return response;
                }
                catch (Exception ex)
                {
                    throw new WechatWorkFinanceException("Failed to get media data. Please see the inner exception for more details.", ex);
                }
                finally
                {
                    freeDataPtr();
                }
            }, cancellationToken);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<Models.GetMediaFileResponse> ExecuteGetMediaFileAsync(Models.GetMediaFileRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null) throw new ArgumentNullException(nameof(request));

            EnsureInitialized();

            const int ATTAMPT_MAX = 3;        // 错误最大重试次数
            const int ATTAMPT_INTERVAL = 500; // 错误等待间隔（单位：毫秒）
            int retryCount = 0;               // 当前已重试次数，获取每个分片前都重置为 0

            string fileId = request.FileId;
            string? nextBufferIndex = null;

            Models.GetMediaFileResponse response = new Models.GetMediaFileResponse();

            using (MemoryStream stream = new MemoryStream())
            {
                while (true)
                {
                    if (retryCount >= ATTAMPT_MAX)
                        break;
                    cancellationToken.ThrowIfCancellationRequested();

                    var reqBuffer = new Models.GetMediaFileBufferRequest()
                    {
                        FileId = fileId,
                        BufferIndex = nextBufferIndex,
                        _InternalTimeout = request._InternalTimeout
                    };
                    var resBuffer = await ExecuteGetMediaFileBufferAsync(reqBuffer, cancellationToken).ConfigureAwait(false);
                    response.ReturnCode = resBuffer.ReturnCode;

                    if (resBuffer.IsSuccessful())
                    {
                        retryCount = 0;
                        nextBufferIndex = resBuffer.NextBufferIndex;
                        await stream.WriteAsync(resBuffer.FileBufferBytes, 0, resBuffer.FileBufferBytes.Length, cancellationToken).ConfigureAwait(false);

                        if (resBuffer.IsFinished)
                            break;
                    }
                    else
                    {
                        if (10001 == resBuffer.ReturnCode ||
                            10002 == resBuffer.ReturnCode ||
                            10003 == resBuffer.ReturnCode)
                        {
                            // 根据官方建议，这三种错误代码需要重试
                            await Task.Delay(ATTAMPT_INTERVAL).ConfigureAwait(false);
                            retryCount++;
                            continue;
                        }

                        break;
                    }
                }

                response._InternalRawBytes = stream.ToArray();
                return response;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                IntPtr sdkPtr = _sdkPtr;
                if (sdkPtr != IntPtr.Zero)
                {
                    _sdkPtr = IntPtr.Zero;

                    if (IsRunOnWindows()) FinanceDllWindowsPInvoker.DestroySdk(sdkPtr);
                    else if (IsRunOnLinux()) FinanceDllLinuxPInvoker.DestroySdk(sdkPtr);
                    else Marshal.FreeHGlobal(sdkPtr);
                }

                _disposed = true;
            }

            base.Dispose(disposing);
        }
    }
}
