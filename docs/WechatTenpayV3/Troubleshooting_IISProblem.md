## 故障排查：本地开发时正常，发布到 IIS 后请求抛出异常？

---

如果你遇到的异常信息如下：

```
Message:
  Failed to sign request. Please see the inner exception for more details.

StackTrace:
  at SKIT.FlurlHttpClient.Wechat.TenpayV3.Interceptors.WechatTenpayRequestSigningInterceptor.BeforeCallAsync(HttpInterceptorContext context,   CancellationToken cancellationToken)
  at SKIT.FlurlHttpClient.CommonClientBase.<>c__DisplayClass12_0.<<-ctor>b__1>d.MoveNext()
  at Flurl.Http.FlurlClient.RaiseEventAsync(FlurlEventType eventType, FlurlCall call)
  at Flurl.Http.FlurlClient.SendAsync(IFlurlRequest request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
  at SKIT.FlurlHttpClient.CommonClientBase.SendFlurlRequestAsync(IFlurlRequest flurlRequest, HttpContent httpContent, CancellationToken   cancellationToken)
  at SKIT.FlurlHttpClient.CommonClientBase.SendFlurlRequestAsJsonAsync(IFlurlRequest flurlRequest, Object data, CancellationToken cancellationToken)
  at SKIT.FlurlHttpClient.Wechat.TenpayV3.WechatTenpayClient.SendFlurlRequestAsJsonAsync[T](IFlurlRequest flurlRequest, Object data, CancellationToken cancellationToken)

InnerException:
  System.Security.Cryptography.CryptographicException: 系统找不到指定的文件。
  Internal.Cryptography.CryptoThrowHelper+WindowsCryptographicException: 系统找不到指定的文件。
  at System.Security.Cryptography.CngKeyLite.ImportKeyBlob(String blobType, ReadOnlySpan1 keyBlob, Boolean encrypted, ReadOnlySpan1 password)
  at System.Security.Cryptography.CngPkcs8.ImportPkcs8(ReadOnlySpan1 keyBlob) at System.Security.Cryptography.CngPkcs8.ImportPkcs8PrivateKey  (ReadOnlySpan1 source, Int32& bytesRead)
  at System.Security.Cryptography.RSAImplementation.RSACng.ImportPkcs8PrivateKey(ReadOnlySpan`1 source, Int32& bytesRead)
  at SKIT.FlurlHttpClient.Wechat.TenpayV3.Utilities.RSAUtility.SignWithSHA256(Byte[] privateKeyBytes, Byte[] messageBytes)
  at SKIT.FlurlHttpClient.Wechat.TenpayV3.Utilities.RSAUtility.SignWithSHA256(String privateKeyPem, String messageData)
  at SKIT.FlurlHttpClient.Wechat.TenpayV3.Interceptors.WechatTenpayRequestSigningInterceptor.BeforeCallAsync(HttpInterceptorContext context, CancellationToken cancellationToken)
```

请检查你的 IIS 应用程序池设置中是否开启了「用户加载配置文件」选项。如果没有，请尝试勾选后重启服务。

---

> 参考链接：
>
> https://stackoverflow.com/questions/17840825
