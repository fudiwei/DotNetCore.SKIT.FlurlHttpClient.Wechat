﻿## 如何快速找到需要调用的 API 模型类名 / 方法名？

---

本库提供的请求模型、响应模型和接口方法，三者均保持同名。

例如，查看用户的客服接入状态的请求是 `KefuStateGetRequest`，响应是 `KefuStateGetResponse`，接口是 `ExecuteKefuStateGetAsync()`。知道其中一个，其余两个就可以快速地推断出了。

再有，每个对象的命名与官方文档的接口地址大体保持一致。例如刚刚提到的查看用户的客服接入状态，它的接口地址是 `[POST] kefustate/get`，将其中的反斜杠去掉、并以大驼峰命名法的方式调整它，就可以得到前文提到的几个对象了。

完整的模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Wechat.OpenAI/Models_ 目录。

---

### 找不到所需要的接口或字段？

本库会定期随微信官方更新接口或模型，但也会偶有疏漏。如果你在使用中遇到了因接口或模型定义而产生的问题，欢迎提出 Issue。

在 Issue 被处理之前，你也可以选择自行扩展 API。

---

### 微信对话开放平台 API 支持情况：

<details>

<summary>[展开查看]</summary>

|     |        微信 API         |    所属客户端    | 备注 |
| :-: | :---------------------: | :--------------: | :--: |
|  √  |    获取 AccessToken     |      OpenAI      |      |
|  √  |       机器人配置        | OpenAI & Chatbot |      |
|  √  |   机器人对话/智能对话   | OpenAI & Chatbot |      |
|  √  |     第三方客服接入      |     Chatbot      |      |
|  √  | 公众号、小程序、H5 绑定 |     Chatbot      |      |

</details>
