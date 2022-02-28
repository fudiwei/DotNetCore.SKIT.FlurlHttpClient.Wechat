## 如何解析回调通知事件？

---

对于微信推送过来的回调通知事件，本库封装了直接解析成事件模型的扩展方法，下面给出一个示例代码：

```csharp
/* 如果是 JSON 格式的通知内容，以 wxa_media_check 事件为例 */
string callbackJson = "{ ... }";
var callbackModel = client.DeserializeEventFromJson<Events.WxaMediaCheckEvent>(callbackJson);

/* 如果是 XML 格式的通知内容，以 text 事件为例 */
string callbackXml = "<xml> ... </xml>";
var callbackModel = client.DeserializeEventFromXml<Events.TextMessageEvent>(callbackXml);
```

完整的回调通知模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Wechat.Api/Events_ 目录。

---

### 事件类型：

由于微信会将全部事件推送到同一个回调通知地址上，开发者需要根据事件类型才能决定如何反序列化。

这里给出两种解决方案。

一种是利用 `System.Xml.Linq`：

```csharp
XDocument xDoc = XDocument.Parse(callbackXml);
string msgType = xDoc.Root?.Element("MsgType")?.Value?.ToUpper();
```

另一种是利用本库的扩展方法：

```csharp
WechatApiEvent eventModel = client.DeserializeEventFromXml(callbackXml);
string msgType = eventModel.MessageType?.ToUpper();

switch (msgType)
{
    case "TEXT":
        {
            var callbackModel = client.DeserializeEventFromXml<Events.TextMessageEvent>(callbackXml);
        }
        break;
    // 省略其他情况
}
```

---

### 安全模式：

在安全模式下，微信公众平台使用了一种特殊的 AES 算法对回调通知事件加密。

上述提供的扩展方法，会自动判定是否处于安全模式下，无需开发者手动干预。

---

### 被动回复：

当用户发送消息给公众号、或某些特定的用户操作引发的事件推送时，开发者可以在响应中返回特定 XML 结构，来对该消息进行响应。

本库还封装了直接序列化被动回复事件的扩展方法，下面给出一个示例代码：

```csharp
/* 以被动回复文本消息为例 */
var replyModel = new Events.TextMessageReply()
{
    ToUserName = "接收方 OpenId",
    FromUserName = "开发者 GhId",
    MessageType = "text",
    Content = "被动回复的文本内容",
    CreateTimestamp = 1234567890
};
string replyXml = client.SerializeEventToXml(replyModel);
```

需要注意的是，默认会序列化为安全模式；如果需要明文模式下的数据，那么可以：

```csharp
string replyXml = client.SerializeEventToXml(replyModel, safety: false);
```

完整的被动回复模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Wechat.Api/Events/MpReply_ 目录。
