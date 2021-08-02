## 如何解析回调通知事件？

---

对于企业微信推送过来的回调通知事件，本库封装了直接解析成事件模型的扩展方法，下面给出一个示例：

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

### 事件类型：

由于企业微信会将全部事件推送到同一个回调通知地址上，开发者需要根据事件类型才能决定如何反序列化。

这里给出一种解决方案：

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

与微信公众号不同的是，企业微信默认启用了安全模式，且不支持切换至明文模式。

开发者可利用本库提供的 `WxBizMsgCryptor` 工具类自行解密相关字段。

上文提到的扩展方法，已自动做解密处理。

---

### 被动回复：

当用户发送消息给企业微信应用、或某些特定的用户操作引发的事件推送时，开发者可以在响应中返回特定 XML 结构，来对该消息进行响应。

本库还封装了直接序列化被动回复事件的扩展方法，下面给出一个示例：

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

完整的被动回复模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Wechat.Work/Events/Reply_ 目录。
