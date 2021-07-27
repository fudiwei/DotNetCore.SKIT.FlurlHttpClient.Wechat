## 如何指定 JSON 序列化器？

---

> 请先自行阅读：
>
> [《Microsoft Docs - .NET 中的 JSON 序列化和反序列化（封送和拆收）》](https://docs.microsoft.com/zh-cn/dotnet/standard/serialization/system-text-json-overview)

默认情况下，本库使用 `System.Text.Json` 作为 JSON 序列化器。

如果你更习惯于 `Newtonsoft.Json`，那么你可以在构造得到 `WechatApiClient` 对象后：

```csharp
client.Configure(settings =>
{
    settings.JsonSerializer = new FlurlNewtonsoftJsonSerializer();
});
```

此外，如果你希望调整一些序列化器的配置项，那么可以：

```csharp
using System.Text.Json;
using SKIT.FlurlHttpClient.Wechat;

client.Configure(settings =>
{
    var jsonOptions = FlurlSystemTextJsonSerializer.GetDefaultSerializerOptions();
    jsonOptions.WriteIndented = true;
    settings.JsonSerializer = new FlurlSystemTextJsonSerializer(jsonOptions);
});
```

使用 `Newtonsoft.Json` 时也是同样的：

```csharp
using Newtonsoft.Json;
using SKIT.FlurlHttpClient.Wechat;

client.Configure(settings =>
{
    var jsonSettings = FlurlNewtonsoftJsonSerializer.GetDefaultSerializerSettings();
    jsonSettings.Formatting = Formatting.Indented;
    settings.JsonSerializer = new FlurlNewtonsoftJsonSerializer(jsonSettings);
});
```
