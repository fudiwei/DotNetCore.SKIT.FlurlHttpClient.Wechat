## 如何解析回调通知事件？

---

你可根据官方文档的规则利用本库提供的 `WxBizMsgCryptor` 工具类自行解密回调通知事件的敏感信息。

对于解密后得到的原始数据，本库封装了直接解析成事件模型的扩展方法，下面给出一个示例：

```csharp
/* 如果是 JSON 格式的通知内容 */
string callbackJson = "{ ... }";
var callbackModel = client.DeserializeEventFromJson<Events.AddScheduleEvent>(callbackJson);

/* 如果是 XML 格式的通知内容 */
string callbackXml = "<xml> ... </xml>";
var callbackModel = client.DeserializeEventFromXml<Events.TextMessageEvent>(callbackXml);
```

完整的回调通知模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Wechat.Work/Events_ 目录。
