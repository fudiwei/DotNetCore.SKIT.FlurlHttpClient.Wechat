### 如何使用拦截器？

---

拦截器是一种可以监视或重写请求调用的强大机制。下面给出一个用于记录传出请求和传入响应的拦截器简单示例：

```csharp
public class LoggingInterceptor : WechatHttpCallInterceptor
{
    private readonly ILogger _logger;

    public LoggingInterceptor(ILogger logger)
    {
        _logger = logger;
    }

    public override Task BeforeCallAsync(FlurlCall flurlCall)
    {
        logger.LogInformation($"Sending request to {flurlCall.Request.Url} on {DateTimeOffset.Now}.");
        return Task.CompletedTask;
    }

    public override Task AfterCallAsync(FlurlCall flurlCall)
    {
        logger.LogInformation($"Received response in {flurlCall.Duration.Value.TotalMilliseconds}ms.");
        return Task.CompletedTask;
    }
}
```

示例代码中的 `FlurlCall` 对象，是 `Flurl.Http` 的内置类型，有关该类型的更进一步的说明，请自行阅读相关文档。

你可以在构造得到 `WechatApiClient` 对象后，将拦截器注入到该客户端中：

```csharp
client.Interceptors.Add(new LoggingInterceptor(loggerFactory.CreateLogger()));
```

拦截器的工作方式类似于洋葱模型。对于请求拦截器而言，将按照添加时的顺序依次执行；对于响应拦截器而言，将按照添加时的顺序逆序依次执行。

拦截器在某些场景下非常有用。例如，你可以自行实现一个请求拦截器，自动在请求时注入 `AccessToken`。
