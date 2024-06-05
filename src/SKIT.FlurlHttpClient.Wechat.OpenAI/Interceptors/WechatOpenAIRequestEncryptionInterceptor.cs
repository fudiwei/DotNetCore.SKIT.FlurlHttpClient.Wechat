using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Interceptors
{
    using SKIT.FlurlHttpClient.Internal;

    internal class WechatOpenAIRequestEncryptionInterceptor : HttpInterceptor
    {
        /**
         * REF:
         *   https://developers.weixin.qq.com/doc/aispeech/confapi/dialog/token.html
         */
        private static readonly ISet<string> ENCRYPT_REQUIRED_URLS = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "/v2/bot/query"
        };

        private readonly string _baseUrl;
        private readonly string _encodingAESKey;
        private readonly Func<string, bool>? _customEncryptedRequestPathMatcher;

        public WechatOpenAIRequestEncryptionInterceptor(string baseUrl, string encodingAESKey, Func<string, bool>? customEncryptedRequestPathMatcher)
        {
            _baseUrl = baseUrl;
            _encodingAESKey = encodingAESKey;
            _customEncryptedRequestPathMatcher = customEncryptedRequestPathMatcher;
        }

        public override async Task BeforeCallAsync(HttpInterceptorContext context, CancellationToken cancellationToken = default)
        {
            if (context is null) throw new ArgumentNullException(nameof(context));
            if (context.FlurlCall.Completed) throw new WechatOpenAIException("Failed to encrypt request. This interceptor must be called before request completed.");

            if (context.FlurlCall.HttpRequestMessage.RequestUri is null || !IsRequestUrlPathMatched(context.FlurlCall.HttpRequestMessage.RequestUri))
                return;

            byte[] reqBytes = Array.Empty<byte>();
            if (context.FlurlCall.HttpRequestMessage?.Content is not null)
            {
                if (context.FlurlCall.HttpRequestMessage.Content is not MultipartFormDataContent)
                {
                    reqBytes = await
#if NET5_0_OR_GREATER
                        context.FlurlCall.HttpRequestMessage.Content.ReadAsByteArrayAsync(cancellationToken).ConfigureAwait(false);
#else
                        _AsyncEx.RunTaskWithCancellationTokenAsync(context.FlurlCall.HttpRequestMessage.Content.ReadAsByteArrayAsync(), cancellationToken).ConfigureAwait(false);
#endif
                }
            }

            byte[] reqBytesEncrypted = Array.Empty<byte>();
            try
            {
                const int AES_BLOCK_SIZE = 16;
                byte[] keyBytes = Convert.FromBase64String(_encodingAESKey);
                byte[] ivBytes = new byte[AES_BLOCK_SIZE]; // iv 是 key 的前 16 个字节
                Buffer.BlockCopy(keyBytes, 0, ivBytes, 0, ivBytes.Length);

                reqBytesEncrypted = Utilities.AESUtility.EncryptWithCBC(
                    keyBytes: keyBytes,
                    ivBytes: ivBytes,
                    plainBytes: reqBytes
                )!;
            }
            catch (Exception ex)
            {
                throw new WechatOpenAIException("Failed to encrypt request. Please see the inner exception for more details.", ex);
            }

            context.FlurlCall.HttpRequestMessage!.Content?.Dispose();
            context.FlurlCall.HttpRequestMessage!.Content = new StringContent(Convert.ToBase64String(reqBytesEncrypted));
            context.FlurlCall.Request.WithHeader(HttpHeaders.ContentType, MimeTypes.Text);
        }

        public override async Task AfterCallAsync(HttpInterceptorContext context, CancellationToken cancellationToken = default)
        {
            if (context is null) throw new ArgumentNullException(nameof(context));
            if (!context.FlurlCall.Completed) throw new WechatOpenAIException("Failed to decrypt response. This interceptor must be called after request completed.");

            if (context.FlurlCall.HttpRequestMessage.RequestUri is null || !IsRequestUrlPathMatched(context.FlurlCall.HttpRequestMessage.RequestUri))
                return;
            if (context.FlurlCall.HttpResponseMessage is null)
                return;
            if (context.FlurlCall.HttpResponseMessage.StatusCode != HttpStatusCode.OK)
                return;

            byte[] respBytes = Array.Empty<byte>();
            if (context.FlurlCall.HttpResponseMessage.Content is not null)
            {
                HttpContent httpContent = context.FlurlCall.HttpResponseMessage.Content;
                respBytes = await
#if NET5_0_OR_GREATER
                    httpContent.ReadAsByteArrayAsync(cancellationToken).ConfigureAwait(false);
#else
                    _AsyncEx.RunTaskWithCancellationTokenAsync(httpContent.ReadAsByteArrayAsync(), cancellationToken).ConfigureAwait(false);
#endif
            }

            byte[] respBytesDecrypted;
            try
            {
                const int AES_BLOCK_SIZE = 16;
                byte[] keyBytes = Convert.FromBase64String(_encodingAESKey);
                byte[] ivBytes = new byte[AES_BLOCK_SIZE]; // iv 是 key 的前 16 个字节
                Buffer.BlockCopy(keyBytes, 0, ivBytes, 0, ivBytes.Length);

                respBytesDecrypted = Utilities.AESUtility.DecryptWithCBC(
                    keyBytes: keyBytes,
                    ivBytes: ivBytes,
                    cipherBytes: respBytes
                )!;
            }
            catch (Exception ex)
            {
                throw new WechatOpenAIException("Failed to decrypt response. Please see the inner exception for more details.", ex);
            }

            context.FlurlCall.HttpResponseMessage!.Content?.Dispose();
            context.FlurlCall.HttpResponseMessage!.Content = new ByteArrayContent(respBytesDecrypted);
        }

        private string GetRequestUrlPath(Uri uri)
        {
            return uri.AbsoluteUri.Substring(0, uri.AbsoluteUri.Length - uri.Query.Length);
        }

        private bool IsRequestUrlPathMatched(Uri uri)
        {
            string absoluteUrl = GetRequestUrlPath(uri);
            if (!absoluteUrl.StartsWith(_baseUrl))
                return false;

            string relativeUrl = absoluteUrl.Substring(_baseUrl.TrimEnd('/').Length);
            if (!ENCRYPT_REQUIRED_URLS.Contains(relativeUrl))
            { 
                if (_customEncryptedRequestPathMatcher is not null)
                    return _customEncryptedRequestPathMatcher(relativeUrl);
                return false;
            }

            return false;
        }
    }
}
