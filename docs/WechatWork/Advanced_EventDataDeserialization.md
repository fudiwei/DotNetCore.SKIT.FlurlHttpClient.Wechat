## 如何解析回调通知事件？

---

对于微信推送过来的回调通知事件，本库封装了直接解析成事件模型的扩展方法，下面给出一个示例：

```csharp
/* 如果是 JSON 格式的通知内容，以 add_schedule 事件为例 */
string callbackJson = "{ ... }";
var callbackModel = client.DeserializeEventFromJson<Events.AddScheduleEvent>(callbackJson);

/* 如果是 XML 格式的通知内容，以 text 事件为例 */
string callbackXml = "<xml> ... </xml>";
var callbackModel = client.DeserializeEventFromXml<Events.TextMessageEvent>(callbackXml);
```

完整的回调通知模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Wechat.Work/Events_ 目录。

---

### 安全模式：

在安全模式下，微信公众平台使用了一种特殊的 AES 算法对回调通知事件加密。

开发者可利用本库提供的 `WxBizMsgCryptor` 工具类自行解密相关字段。
