## 如何自定义额外的 API 接口？

---

如果有某些接口本库尚未支持，你可按照下面的示例自行扩展：

```csharp
/* 继承 WechatTenpayRequest 实现自定义请求类 */
public class MyFakeRequest : WechatTenpayRequest
{
    [Newtonsoft.Json.JsonProperty("my_fake_props")]
    [System.Text.Json.Serialization.JsonPropertyName("my_fake_props")]
    public string MyFakeProps { get; set; }
}

/* 继承 WechatTenpayResponse 实现自定义响应类 */
public class MyFakeResponse : WechatTenpayResponse
{
    [Newtonsoft.Json.JsonProperty("my_fake_props")]
    [System.Text.Json.Serialization.JsonPropertyName("my_fake_props")]
    public string MyFakeProps { get; set; }
}

/* 扩展 WechatTenpayClient 方法 */
public static class MyFakeClientExtensions
{
    public static async Task<MyFakeResponse> ExecuteMyFakeAsync(this WechatTenpayClient client, MyFakeRequest request, CancellationToken cancellationToken = default)
    {
        if (client is null) throw new ArgumentNullException(nameof(client));
        if (request is null) throw new ArgumentNullException(nameof(request));

        IFlurlRequest flurlReq = client
            .CreateFlurlRequest(request, HttpMethod.Post, "my-fake-url");

        return await client.SendFlurlRequestAsJsonAsync<MyFakeResponse>(flurlReq, request, cancellationToken);
    }
}
```

同样地，你也可自行扩展回调通知事件的敏感数据模型：

```csharp
/* 实现自定义的 JSON 格式的回调通知事件敏感数据 */
public class MyFakeEvent : WechatTenpayEvent.Types.IDecryptedResource
{
    [Newtonsoft.Json.JsonProperty("my_fake_props")]
    [System.Text.Json.Serialization.JsonPropertyName("my_fake_props")]
    public string MyFakeProps { get; set; }
}
```

---

### 敏感信息字段

如果你扩展的自定义请求或响应模型中包含敏感信息字段，并希望可以通过本库提供的 `EncryptRequestSensitiveProperty()` 和 `DecryptResponseSensitiveProperty()` 两个扩展方法来实现自动加、解密，那么你需要在定义模型时额外指定特性：

```csharp
[WechatTenpaySensitive]
public class MyFakeRequest : WechatTenpayRequest
{
    [Newtonsoft.Json.JsonProperty("my_fake_props")]
    [System.Text.Json.Serialization.JsonPropertyName("my_fake_props")]
    [WechatTenpaySensitiveProperty("my_scheme", "my_alg")]
    public string MyFakeProps { get; set; }
}

[WechatTenpaySensitive]
public class MyFakeResponse : WechatTenpayResponse
{
    [Newtonsoft.Json.JsonProperty("my_fake_props")]
    [System.Text.Json.Serialization.JsonPropertyName("my_fake_props")]
    [WechatTenpaySensitiveProperty("my_scheme", "my_alg")]
    public string MyFakeProps { get; set; }
}
```
