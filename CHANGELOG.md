# CHANGELOG

---

<details>

<summary>[展开查看] SKIT.FlurlHttpClient.Wechat.Api 模块更新日志</summary>

-   Release 2.0.1

    -   **修复**：修复部分回调通知事件模型字段缺失的问题。

-   Release 2.0.0

    -   **新增**：适配 .NET 6.0。

    -   **变更**：升级核心库。

-   Release 1.12.0

    -   **新增**：新增网络检测相关接口。

    -   **新增**：新增 OpenAPI 管理相关接口。

-   Release 1.11.0

    -   **新增**：新增草稿箱相关接口。

    -   **新增**：新增发布能力相关接口。

    -   **新增**：随官方更新客服消息相关接口模型。

    -   **新增**：随官方更新自定义菜单相关接口模型。

-   Release 1.10.1

    -   **修复**：修复 XmlSerializer 潜在的内存泄漏问题。（[GitHub Issue #11](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/11)）

-   Release 1.10.0

    -   **新增**：新增第三方平台申请开通直播相关接口。

    -   **新增**：新增小程序联盟定向计划推广相关接口。

    -   **新增**：新增小程序联盟自定义用户参数管理相关接口。

    -   **新增**：随官方更新小程序联盟推客端相关接口模型。

    -   **修复**：修复 AES 解密结果结尾有冗余的空白字符问题。

-   Release 1.9.0

    -   **新增**：新增标准版交易组件售后相关接口。

    -   **新增**：新增标准版交易组件验证二维码相关接口。

    -   **新增**：新增自定义交易组件推广员相关接口。

    -   **新增**：随官方更新个性化菜单相关接口模型。

    -   **新增**：随官方更新用户信息相关接口模型。

    -   **变更**：重命名生成 JS-SDK 客户端签名参数的扩展方法。

-   Release 1.8.0

    -   **新增**：新增交易组件修改订单价格相关接口。

    -   **新增**：新增交易组件修改订单备注相关接口。

    -   **新增**：新增交易组件资金管理相关接口。

    -   **新增**：新增自定义交易组件完成接入任务相关接口。

    -   **新增**：新增自定义交易组件免审核更新商品字段相关接口。

    -   **新增**：新增自定义交易组件按推广员或分享者获取订单相关接口。

    -   **新增**：随官方更新自定义交易组件售后相关接口模型。

    -   **新增**：新增场景审核、分享员变更、用户领券相关的回调通知事件模型。

    -   **新增**：新增自定义交易组件优惠券相关接口。

    -   **新增**：新增微信物流服务消息组件相关接口。

-   Release 1.7.0

    -   **新增**：新增小程序检查加密信息是否由微信生成的接口。

    -   **新增**：新增小程序发送统一消息的接口。（[GitHub Issue #6](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/6)）

    -   **新增**：新增 AES 解密工具类。

-   Release 1.6.0

    -   **新增**：新增小程序发送订阅消息的接口。（[Gitee Issue #I47D5T](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I47D5T)）

    -   **变更**：调整 `IXmlSerializable`、`IJsonSerializable` 接口定义。

-   Release 1.5.0

    -   **变更**：升级核心库。

    -   **修复**：修复潜在的 XXE 漏洞风险。

-   Release 1.4.1

    -   **修复**：修复部分场景下生成微信回调通知事件签名错误的问题。（[GitHub Issue #4](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/4)）

-   Release 1.4.0

    -   **新增**：新增第三方平台代云开发相关接口。

    -   **新增**：随官方更新内容安全相关字段。

-   Release 1.3.5

    -   **修复**：修复获取图文素材接口模型的字段缺失问题。（[Gitee Issue #I43QPI](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I43QPI)）

-   Release 1.3.4

    -   **修复**：修复安全模式下反序列化微信回调通知事件的问题。

-   Release 1.3.3

    -   **新增**：新增验证微信回调通知事件签名的扩展方法。

-   Release 1.3.2

    -   **新增**：反序列化微信回调通知事件模型时支持 `WechatApiEvent` 基类，以便业务逻辑判断。

-   Release 1.3.1

    -   **修复**：修复自定义交易组件获取快递公司列表接口的模型定义错误。（[Gitee Issue #I43AM2](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I43AM2)）

-   Release 1.3.0

    -   **新增**：新增序列化回调通知事件实体类的扩展方法。

    -   **新增**：反序列化微信回调通知事件模型时支持安全模式。

    -   **修复**：修复部分微信回调通知事件模型反序列化的问题。

-   Release 1.2.1

    -   **修复**：修复生成小程序码接口的模型定义错误。（[Gitee Issue #I42XC0](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I42XC0)）

-   Release 1.2.0

    -   **新增**：新增 `WechatApiClient.Credentials` 属性。

    -   **变更**：移除 `WechatApiClient.FlurlJsonSerializer` 属性。

-   Release 1.1.0

    -   **新增**：新增小程序获取用户加密 Key 相关接口。

    -   **新增**：新增小程序生成 ShortLink 相关接口。

-   Release 1.0.1

    -   **新增**：新增 `WechatApiClient.CreateRequest()` 方法。

-   Release 1.0.0

    -   首次发布。

</details>

---

<details>

<summary>[展开查看] SKIT.FlurlHttpClient.Wechat.TenpayV3 模块更新日志</summary>

-   Release 2.0.1

    -   **变更**：升级外部依赖库 `Portable.BouncyCastle`。

    -   **修复**：修复查询代金券相关接口的响应模型定义错误。（[Gitee Issue #I4HRYL](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I4HRYL)）

-   Release 2.0.0

    -   **新增**：随官方更新商家券相关接口模型。

    -   **新增**：适配 .NET 6.0。

    -   **变更**：升级核心库。

-   Release 1.8.2

    -   **新增**：新增商户申请获取微信支付分对账单相关接口。

    -   **修复**：修复部分请求模型中可空字段的初值问题。（[Gitee Issue #I4BF0K](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I4BF0K)）

-   Release 1.8.1

    -   **修复**：修复查询分账结果接口的调用时参数缺失问题。（[Gitee Issue #I4BITZ](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I4BITZ)）

-   Release 1.8.0

    -   **新增**：新增消费者投诉下载图片相关接口。

    -   **新增**：随官方更新消费者投诉接口相关字段。

-   Release 1.7.0

    -   **变更**：升级核心库。

-   Release 1.6.0

    -   **新增**：新增银行定向促活相关接口。

-   Release 1.5.4

    -   **修复**：修复特约商户进件提交申请单接口请求模型定义错误的问题。（[Gitee Issue #I45RRM](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I45RRM)）

-   Release 1.5.2

    -   **修复**：修复特约商户进件提交申请单接口因 URL 结尾反斜杠问题而无法正常请求的问题。（[Gitee Issue #I45QFY](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I45QFY)）

-   Release 1.5.1

    -   **修复**：修复部分接口模型因继承问题在使用 System.Text.Json 时序列化有误的问题。（[Gitee Issue #I45C27](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I45C27)）

-   Release 1.5.0

    -   **新增**：新增微信支付分停车服务相关接口。

    -   **新增**：随官方更新电商分账、连锁品牌分账接口相关字段。

-   Release 1.4.2

    -   **变更**：验证响应或回调通知签名时不再抛出异常。

-   Release 1.4.0

    -   **新增**：新增获取分账账单相关接口。

    -   **新增**：随官方更新分账、服务商分账接口相关字段。

    -   **新增**：新增 `WechatTenpayV3Client.Credentials` 属性。

    -   **变更**：移除 `WechatTenpayV3Client.FlurlJsonSerializer` 属性。

    -   **变更**：移除 `ICertificateStorer` 接口，新增 `CertificateManager` 抽象类。

    -   **修复**：修复部分场景下生成请求签名的错误。（[GitHub Issue #2](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/2)）

-   Release 1.3.1

    -   **新增**：新增批量转账到零钱相关接口。

    -   **新增**：新增服务商批量转账到零钱相关接口。

    -   **新增**：新增 `ICertificateStorer` 接口，并基于此重新实现验签的扩展方法。（[GitHub Issue #1](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/1)）

-   Release 1.2.1

    -   **新增**：新增 `WechatTenpayV3Client.CreateRequest()` 方法。

-   Release 1.2.0

    -   **变更**：调整包含需加解密字段的接口模型，去除 _EncryptedData_ 的字段名结尾。

-   Release 1.1.0

    -   **新增**：新增分账相关接口。

-   Release 1.0.1

    -   **新增**：随官方更新服务商提现、服务商结算账户接口相关字段。

    -   **修复**：修复调起支付所需参数签名生成错误。（[Gitee Issue #I3YY2C](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I3YY2C)）

-   Release 1.0.0

    -   首次发布。

</details>

---

<details>

<summary>[展开查看] SKIT.FlurlHttpClient.Wechat.Work 模块更新日志</summary>

-   Release 2.0.0

    -   **新增**：适配 .NET 6.0。

    -   **变更**：升级核心库。

-   Release 1.4.0

    -   **新增**：新增微信客服相关接口。

    -   **新增**：随官方更新发送应用消息相关接口模型。

    -   **新增**：新增获取设备打卡数据相关接口。

    -   **新增**：新增管理员变更相关的回调通知事件模型。

-   Release 1.3.4

    -   **修复**：修复应用消息相关接口的调用时参数缺失问题。（[GitHub Issue #10](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/10)）

-   Release 1.3.3

    -   **修复**：修复批量获取客户详情时的请求模型定义错误。（[GitHub Issue #9](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pull/9)）

-   Release 1.3.2

    -   **修复**：修复创建或获取通讯录成员时的请求模型定义错误。（[GitHub Issue #8](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/8)）

-   Release 1.3.1

    -   **修复**：修复获取服务商凭证接口请求模型定义错误。（[GitHub Issue #5](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pull/5)）

-   Release 1.3.0

    -   **新增**：新增通讯录异步导出相关接口。

    -   **新增**：新增获取选人 Ticket 对应的用户相关接口。

    -   **新增**：新增客户联系规则组相关接口。

    -   **新增**：新增客户朋友圈规则组相关接口。

    -   **新增**：新增获取学校应用可使用的家长范围相关接口。

    -   **新增**：随官方更新获取群聊数据统计数据接口相关字段。

    -   **新增**：随官方更新企业通讯录接口相关字段。

    -   **新增**：随官方更新客户标签回调通知事件回调模型。

    -   **新增**：随官方更新企业客户回调通知事件回调模型。

    -   **变更**：升级核心库。

    -   **修复**：修复潜在的 XXE 漏洞风险。

-   Release 1.2.3

    -   **修复**：修复部分场景下生成微信回调通知事件签名错误的问题。（[GitHub Issue #4](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/4)）

-   Release 1.2.2

    -   **新增**：新增序列化回调通知事件实体类的扩展方法。

    -   **新增**：反序列化企业微信回调通知事件模型时支持安全模式。

    -   **修复**：修复部分企业微信回调通知事件模型反序列化的问题。

-   Release 1.2.0

    -   **新增**：新增 `WechatWorkClient.Credentials` 属性。

    -   **变更**：移除 `WechatWorkClient.FlurlJsonSerializer` 属性。

-   Release 1.1.0

    -   **新增**：随官方更新客户联系接口相关字段。

    -   **新增**：新增班级收款相关接口。

-   Release 1.0.1

    -   **新增**：新增 `WechatWorkClient.CreateRequest()` 方法。

    -   **新增**：新增企业微信小程序相关接口。

-   Release 1.0.0

    -   首次发布。

</details>
