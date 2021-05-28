### 如何解析回调通知事件？

---

本库封装了直接解析事件的扩展方法，下面给出一个示例：

```csharp
/* 如果是 JSON 格式的通知内容 */
string callbackJson = "...";
var callbackModel = client.DeserializeEventFromJson<Events.WxaMediaCheckEvent>(callbackJson);

/* 如果是 XML 格式的通知内容 */
string callbackXml = "...";
var callbackModel = client.DeserializeEventFromXml<Events.TextMessageEvent>(callbackXml);
```

完整的回调通知模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Wechat.Api/Events_ 目录。
