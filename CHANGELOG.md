# CHANGELOG

### 版本说明

各 SDK 的版本号将遵循语义化版本规则。

在更新日志中会包含以下几种名词：

1.  “**新增**”：
    -   追加了新功能；
    -   一般不会产生破坏性更新。
2.  “**变更**”：
    -   可能重新实现了已有的功能，通常会带来使用方式上的变化；
    -   可能升、降级了第三方依赖库的版本。
    -   一般会产生破坏性更新。
3.  “**修复**”：
    -   修复了已知的一些问题；
    -   一般不会产生破坏性更新。

注意，预发行版（版本号将以 `-alpha`、`-beta`、`-rc` 结尾）不会在更新日志中呈现。如非必要，请不要将预发行版应用于生产项目。

自 v2.0.0 版本起，各 SDK 将与[公共组件](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Common)的主版本号保持对齐关系，即：

-   SDK v2.x.x 将依赖公共组件 v2.x.x；
-   SDK v3.x.x 将依赖公共组件 v3.x.x。
-   依此类推。

---

### 模块 `SKIT.FlurlHttpClient.Wechat.Api` 更新日志

<details>

<summary>[展开查看]</summary>

-   Release 2.33.0

    -   **新增**：新增小程序 ICP 备案审核通知事件。（_via_ [GitHub #108](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pull/108)）

    -   **新增**：新增小程序同城配送相关接口。（_via_ [Gitee #I7WVBO](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I7WVBO)）

    -   **新增**：随官方更新获得模板消息 ID 接口模型。（_via_ [Gitee #8](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pulls/8)）

-   Release 2.32.0

    -   **新增**：新增第三方平台小程序备案相关接口。

-   Release 2.31.0

    -   **新增**：新增小程序虚拟支付相关接口。（_via_ [GitHub #105](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/105)）

    -   **新增**：新增小程序付费管理相关接口。

    -   **变更**：统一小程序直播相关接口的商品 ID 字段类型。（_via_ [Gitee #I7EZYT](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I7EZYT)）

-   Release 2.30.0

    -   **新增**：新增小程序硬件设备组相关接口。（_via_ [GitHub #100](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/100)）

    -   **新增**：新增视频号小店物流公司虚拟号码相关接口。

-   Release 2.29.0

    -   **新增**：新增获取稳定版接口调用凭据接口。（_via_ [GitHub #99](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pull/99)）

-   Release 2.28.0

    -   **新增**：新增小程序短剧媒资管理相关接口。

    -   **修复**：修复微信卡券更新子商户接口缺失问题。（_via_ [Gitee #I78KMU](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I78KMU)）

-   Release 2.27.0

    -   **新增**：新增人脸核身相关接口。

    -   **新增**：新增小程序 B2B 门店助手相关接口。

    -   **新增**：新增小程序发货信息管理服务相关接口。

    -   **变更**：随官方标记发送模板消息相关接口或字段为废弃。

    -   **变更**：移除部分已标记为废弃的接口及模型。

-   Release 2.26.1

    -   **修复**：修复视频号小店订单、售后单 ID 字段类型定义错误。（_via_ [GitHub #90](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/90)）

-   Release 2.26.0

    -   **新增**：新增微信物流服务散单寄件相关接口。

    -   **新增**：新增小程序硬件框架推送消息接口。

    -   **新增**：新增视频号小店团长合作达人、团长数据等相关接口。

    -   **修复**：修复投诉信息回调通知事件模型定义错误。（_via_ [GitHub #88](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pull/88)）

-   Release 2.25.0

    -   **新增**：随官方更新网页授权相关接口模型。

    -   **新增**：新增授权用户信息变更回调通知事件模型。

    -   **新增**：新增用户在小程序“客服会话按钮”进入客服会话时产生的回调通知事件模型。（_via_ [Gitee #I6IU5T](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I6IU5T)）

-   Release 2.24.0

    -   **新增**：新增小游戏虚拟支付 2.0 相关接口。（_via_ [Gitee #I6F3OX](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I6F3OX)）

-   Release 2.23.0

    -   **新增**：新增视频号小店资质图片、商品类目、品牌资质、区域仓库、纠纷、分享员、资金、优选联盟等相关接口。

    -   **新增**：新增视频号助手留资组件相关接口。

    -   **新增**：新增链接消息、小程序卡片消息回调通知事件模型。

    -   **新增**：随官方更新第三方平台提交代码审核接口模型。

-   Release 2.22.0

    -   **新增**：新增第三方平台小程序流量主代运营相关接口。

-   Release 2.21.1

    -   **修复**：修复第三方平台小程序分阶段发布接口模型参数缺失问题。（_via_ [GitHub #73](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pull/74)）

    -   **变更**：升级公共组件至 v2.6.0。

-   Release 2.21.0

    -   **新增**：新增第三方平台申请设置订单页信息、获取订单页信息接口。

    -   **新增**：新增自定义交易组件设置小程序分享模式接口。

    -   **新增**：新增小程序联盟自定义交易组件商家端相关接口。

    -   **新增**：随官方更新第三方平台提交代码审核接口模型。

    -   **新增**：随官方更新部分标准版交易组件接口模型。

    -   **变更**：移除部分已被标记为废弃的接口。

    -   **修复**：修复获取小程序历史版本接口模型定义错误。（_via_ [GitHub #73](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pull/73)）

-   Release 2.20.2

    -   **修复**：修复获取小程序模板库列表不正确的问题。（_via_ [GitHub #71](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pull/71)）

-   Release 2.20.1

    -   **修复**：修复快速注册个人小程序回调通知事件模型字段定义错误。（_via_ [GitHub #67](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pull/67)）

-   Release 2.20.0

    -   **新增**：新增视频号小店相关接口。

    -   **新增**：新增微信云托管服务管理相关接口。

    -   **变更**：随官方标记微信小店相关接口或字段为废弃。

    -   **变更**：调整部分微信商品库相关接口模型的命名方式。

    -   **变更**：调整部分腾讯云服务 TCB 相关接口模型的命名方式。

-   Release 2.19.0

    -   **新增**：新增使用 AppSecret 重置第三方平台 API 调用次数接口。

    -   **新增**：新增若干第三方平台平台代商家注册小程序接口。

    -   **新增**：新增若干第三方平台代商家管理小程序接口。

    -   **新增**：新增若干第三方平台微信云托管接口。

-   Release 2.18.0

    -   **新增**：新增小程序购物订单相关接口。

    -   **修复**：修复上传图片素材时根据文件后缀名识别默认类型的错误。（_via_ [GitHub #57](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pull/57)）

    -   **修复**：修复订阅消息事件通知模型在 JSON 模式下反序列化的错误。（_via_ [GitHub #58](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/58)）

-   Release 2.17.0

    -   **新增**：新增小程序交易保障相关接口。

    -   **新增**：新增获取 NFC 的小程序 scheme 接口。

    -   **新增**：随官方更新获取订阅消息个人模板列表的接口模型。（_via_ [GitHub #56](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/56)）

-   Release 2.16.0

    -   **新增**：新增客服子商户能力相关接口。（_via_ [Gitee #I5F24Z](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I5F24Z)）

    -   **新增**：新增小程序自定义交易组件售后开发测试接口。

    -   **新增**：随官方更新客服管理相关接口模型。

    -   **新增**：随官方更新开放平台应用通过 Code 获取 AccessToken 的接口模型。（_via_ [GitHub #49](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/49)）

    -   **新增**：随官方更新小程序自定义交易组件生成订单的接口模型。（_via_ [Gitee #I5ESTO](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I5ESTO)）

    -   **新增**：随随官方更新小程序自定义交易组件提交支付资质接口模型。

-   Release 2.15.0

    -   **新增**：新增获取公众号的自动回复规则接口。

    -   **新增**：新增小程序联盟相关接口。

    -   **新增**：新增小程序自定义交易组件银行信息相关接口。

    -   **新增**：新增小程序自定义交易组件更新订单售后期接口。

    -   **新增**：新增小程序自定义交易组件拉取小程序信息接口。

    -   **新增**：新增部分小程序支付管理服务回调通知事件模型。

    -   **新增**：随官方更新发布能力相关接口模型。

    -   **新增**：随官方更新小程序自定义交易组件订单相关接口模型。

-   Release 2.14.0

    -   **新增**：新增云开通物流服务相关接口。（_via_ [GitHub #41](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pull/41)）

    -   **新增**：新增城市服务开放互联能力相关接口。

-   Release 2.13.0

    -   **新增**：新增第三方平台复用商户号资质快速转正、查询公众号或小程序是否绑定开放平台帐号、申请开通物流退货组件、半屏小程序管理接口。

    -   **新增**：新增云开发查询是否绑定手机号的接口。

    -   **修复**：修复部分事件通知模型中数组类型字段反序列化错误的问题。

-   Release 2.12.0

    -   **新增**：随官方更新自定义交易组件获取售后详情接口响应模型。（_via_ [GitHub #40](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pull/40)）

    -   **新增**：随官方更新生成小程序码接口请求模型。（_via_ [Gitee #6](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pulls/6)）

    -   **修复**：修复上传素材接口不支持 Unicode 文件名问题。（_via_ [GitHub #40](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/40)）

-   Release 2.11.0

    -   **新增**：新增自定义交易组件订单回调通知事件模型。

    -   **修复**：修复自定义交易组件订单发货接口请求模型定义问题。（_via_ [GitHub #39](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pull/39)）

    -   **修复**：修复自定义交易组件售后列表接口响应模型定义问题。（_via_ [GitHub #39](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pull/39)）

-   Release 2.10.0

    -   **新增**：新增自定义交易组件进件、资金、分享员、售后、纠纷相关接口及回调通知事件模型。

    -   **新增**：随官方更新自定义交易组件商家入驻、商品、订单、推广员、优惠券相关接口模型。

    -   **变更**：调整 `SHA1Utility`、`HMACUtility` 工具类的计算字节数组哈希值方法的返回值类型。

    -   **变更**：升级公共组件至 v2.5.0。

-   Release 2.9.0

    -   **新增**：新增请求响应模型类型推断辅助接口 `IInferable`。（_via_ [GitHub #21](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pull/21)）

    -   **新增**：新增服务平台增值服务相关接口。

    -   **变更**：修改反序列化回调通知事件的相关扩展方法 `DeserializeEventFromXml`、`DeserializeEventFromJson`，废弃其指示是否启用安全模式的参数，改为自动判定。

    -   **变更**：修改序列化回调通知事件的相关扩展方法 `SerializeEventToXml`、`SerializeEventToJson`，调整其指示是否启用安全模式的参数默认值，由 _false_ 变为 _true_。

    -   **变更**：移除原 `WxBizMsgCryptor` 工具类。

    -   **变更**：调整 `SHA1Utility` 工具类的计算字节数组哈希值方法的返回值类型。

-   Release 2.8.2

    -   **变更**：升级公共组件至 v2.3.3。（_via_ [GitHub #34](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/34)）

-   Release 2.8.1

    -   **变更**：升级公共组件至 v2.3.2。

-   Release 2.8.0

    -   **变更**：随官方标记永久图文素材相关接口或字段为废弃。

    -   **变更**：升级公共组件至 v2.3.1。

    -   **修复**：修复小程序交易投诉处理回调通知事件模型的定义错误。

    -   **修复**：修复微信卡券回调通知事件模型的定义错误。

-   Release 2.7.0

    -   **新增**：随官方更新生成自定义交易组件上传图片相关接口模型。（_via_ [Gitee #I4RONZ](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I4RONZ)）

    -   **变更**：升级公共组件至 v2.2.0。

-   Release 2.6.1

    -   **修复**：修复获取小程序订阅消息公共模板标题时出现的 200019 错误。（_via_ [GitHub #28](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/28)）

-   Release 2.6.0

    -   **新增**：随官方更新生成小程序码相关接口模型。（_via_ [GitHub #27](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pull/27)）

    -   **新增**：随官方更新生成 URL Scheme、URL Link 相关接口模型。

-   Release 2.5.0

    -   **新增**：新增换取用户手机号相关接口。

-   Release 2.4.0

    -   **新增**：新增获取小程序插件用户的唯一标识相关接口。

    -   **新增**：随官方更新扫描二维码打开小程序的相关接口模型。

    -   **新增**：随官方更新物流助手相关接口模型。

    -   **新增**：新增生成参数化 URL 的扩展方法。

    -   **变更**：升级公共组件至 v2.1.1。

-   Release 2.3.0

    -   **新增**：新增第三方平台代公众号发起网页授权相关接口。

-   Release 2.2.1

    -   **修复**：修复获取会员卡信息接口模型的字段缺失问题。（_via_ [Gitee #3](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pulls/3)）

-   Release 2.2.0

    -   **新增**：新增小程序硬件设备相关接口。

    -   **新增**：新增小程序用户交易类投诉相关接口。

    -   **新增**：新增自定义交易组件商品系统下架回调通知的事件模型。

    -   **变更**：随官方标记获取用户信息相关接口或字段为废弃。

-   Release 2.1.0

    -   **新增**：新增第三方平台服务器域名相关接口。

    -   **新增**：新增第三方平台小程序用户隐私保护指引相关接口。

-   Release 2.0.1

    -   **修复**：修复部分回调通知事件模型字段缺失的问题。

-   Release 2.0.0

    -   **新增**：适配 .NET 6.0。

    -   **变更**：移除核心库依赖，引入公共组件。

-   Release 1.12.0

    -   **新增**：新增网络检测相关接口。

    -   **新增**：新增 OpenAPI 管理相关接口。

-   Release 1.11.0

    -   **新增**：新增草稿箱相关接口。

    -   **新增**：新增发布能力相关接口。

    -   **新增**：随官方更新客服消息相关接口模型。

    -   **新增**：随官方更新自定义菜单相关接口模型。

-   Release 1.10.1

    -   **修复**：修复 XmlSerializer 潜在的内存泄漏问题。（_via_ [GitHub #11](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/11)）

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

    -   **新增**：新增小程序发送统一消息的接口。（_via_ [GitHub #6](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/6)）

    -   **新增**：新增 AES 解密工具类。

-   Release 1.6.0

    -   **新增**：新增小程序发送订阅消息的接口。（_via_ [Gitee #I47D5T](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I47D5T)）

    -   **变更**：调整 `IXmlSerializable`、`IJsonSerializable` 接口定义。

-   Release 1.5.0

    -   **变更**：升级核心库。

    -   **修复**：修复潜在的 XXE 漏洞风险。

-   Release 1.4.1

    -   **修复**：修复部分场景下生成微信回调通知事件签名错误的问题。（_via_ [GitHub #4](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/4)）

-   Release 1.4.0

    -   **新增**：新增第三方平台代云开发相关接口。

    -   **新增**：随官方更新内容安全相关字段。

-   Release 1.3.5

    -   **修复**：修复获取图文素材接口模型的字段缺失问题。（_via_ [Gitee #I43QPI](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I43QPI)）

-   Release 1.3.4

    -   **修复**：修复安全模式下反序列化微信回调通知事件的问题。

-   Release 1.3.3

    -   **新增**：新增验证微信回调通知事件签名的扩展方法。

-   Release 1.3.2

    -   **新增**：反序列化微信回调通知事件模型时支持 `WechatApiEvent` 基类，以便业务逻辑判断。

-   Release 1.3.1

    -   **修复**：修复自定义交易组件获取快递公司列表接口的模型定义错误。（_via_ [Gitee #I43AM2](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I43AM2)）

-   Release 1.3.0

    -   **新增**：新增序列化回调通知事件实体类的扩展方法。

    -   **新增**：反序列化微信回调通知事件模型时支持安全模式。

    -   **修复**：修复部分微信回调通知事件模型反序列化的问题。

-   Release 1.2.1

    -   **修复**：修复生成小程序码接口的模型定义错误。（_via_ [Gitee #I42XC0](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I42XC0)）

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

### 模块 `SKIT.FlurlHttpClient.Wechat.TenpayV2` 更新日志

<details>

<summary>[展开查看]</summary>

-   Release 2.3.1

    -   **新增**：修复 Windows 环境下潜在的证书加载失败问题。（_via_ [GitHub #93](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/93)）

-   Release 2.3.0

    -   **新增**：新增反序列化微信支付回调通知事件模型的扩展方法。

    -   **新增**：新增拉取订单评价数据接口。

    -   **新增**：新增单品优惠退款相关接口。

    -   **新增**：新增小微商户相关接口。

    -   **新增**：新增车主平台相关接口。

    -   **新增**：随官方更新清关报关订单附加信息重推接口模型。

-   Release 2.2.3

    -   **修复**：修复部分场景下付款码支付接口响应模型反序列化错误的问题。

-   Release 2.2.2

    -   **修复**：修复酒店押金查询退款接口响应反序列化不正确的问题。（_via_ [GitHub #82](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/82)）

-   Release 2.2.1

    -   **变更**：升级公共组件至 v2.6.0。

-   Release 2.2.0

    -   **新增**：支持新版仿真测试系统沙箱。

    -   **变更**：重命名查询退款接口响应模型中的部分字段。（_via_ [GitHub #66](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/66)）

-   Release 2.1.0

    -   **新增**：新增企业微信企业支付相关接口。

    -   **新增**：付款码支付撤掉订单接口支持微信订单号字段。（_via_ [GitHub #64](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/64)）

-   Release 2.0.2

    -   **修复**：修复付款码支付接口响应模型参数缺失问题。（_via_ [GitHub #61](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/61)）

-   Release 2.0.1

    -   **修复**：修复生成客户端调起支付二次签名时的参数排序错误。

-   Release 2.0.0

    -   首次发布。

</details>

---

### 模块 `SKIT.FlurlHttpClient.Wechat.TenpayV3` 更新日志

<details>

<summary>[展开查看]</summary>

-   Release 2.20.0

    -   **新增**：新增查询营销补差付款单列表接口。

    -   **新增**：新增电子小票相关接口。

    -   **新增**：新增连锁品牌门店相关接口。

    -   **新增**：新增品牌小店营销相关接口。

    -   **新增**：新增银行批量转账相关接口。

    -   **新增**：随官方更新特约商户进件相关接口模型。

    -   **新增**：随官方更新平台收付通（原电商收付通）申请资金出境相关接口模型。

    -   **新增**：随官方更新电子发票相关接口模型。

-   Release 2.19.0

    -   **新增**：新增电商收付通注销申请相关接口。

-   Release 2.18.0

    -   **新增**：新增电商收付通合单代扣相关接口。

    -   **新增**：新增境外商户付款码付款、委托代扣等相关接口。

    -   **新增**：新增刷脸支付智能设备列表接口。

-   Release 2.17.0

    -   **新增**：随官方更新商户进件结算账号相关接口模型。

    -   **新增**：新增电商收付通注销后提现相关接口。

    -   **新增**：新增服务商优惠费率活动相关接口。

    -   **新增**：新增从业机构微信支付分、从业机构特约商户结算规则 ID 管理等相关接口。

    -   **新增**：新增银行提现免费券、银行周周惠等相关接口。

    -   **新增**：新增区块链电子发票、出租车电子发票等相关接口。

    -   **新增**：新增 ETC 扣费相关接口。

    -   **新增**：新增租用充电宝隔夜归还相关接口。

    -   **新增**：新增微信点餐订单、微信寄快递等相关接口。

-   Release 2.16.0

    -   **新增**：随官方更新特约商户进件、二级商户进件申请接口模型。

    -   **新增**：随官方更新消费者投诉单相关接口模型。

    -   **变更**：升级依赖 `BouncyCastle.Cryptography` 至 v2.1.1。

-   Release 2.15.2

    -   **修复**：修复部分包含敏感信息字段的接口模型不能正确触发自动加解密的问题。（_via_ [GitHub #76](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/76)）

-   Release 2.15.1

    -   **变更**：升级依赖 `BouncyCastle.Cryptography`（即原 `Portable.BouncyCastle`）至 v2.0.0。

    -   **变更**：升级公共组件至 v2.6.0。

-   Release 2.15.0

    -   **新增**：随官方更新商家转账到零钱相关接口模型。

-   Release 2.14.0

    -   **新增**：支持国密算法接入。

    -   **新增**：新增微工卡相关接口。

    -   **变更**：重命名 RSA 工具类中与导出证书相关的部分方法名。

    -   **变更**：重命名部分扩展方法的参数名。

    -   **变更**：调整 `CertificateEntry` 的构造函数，增加指示证书算法类型参数，以适配国密算法。

    -   **变更**：移除部分已被标记为废弃的配置项参数。

-   Release 2.13.1

    -   **修复**：修复电商收付通二级商户进件申请接口请求模型定义错误。（_via_ [Gitee #I5QM1P](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I5QM1P)）

-   Release 2.13.0

    -   **新增**：随官方更新退款相关接口模型。

    -   **新增**：随官方更新 JSAPI 下单接口模型。

    -   **修复**：修复根据过滤条件查询用户券接口查询参数定义错误。（_via_ [Gitee #I5QFB3](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I5QFB3)）

-   Release 2.12.0

    -   **新增**：新增智慧商圈会员待积分状态查询、会员停车状态同步接口。

    -   **新增**：随官方更新智慧商圈相关回调通知事件模型。

-   Release 2.11.0

    -   **新增**：新增出行券切卡组件预下单接口。

    -   **修复**：修复特约商户进件接口模型定义问题。（_via_ [Gitee #I5FCR5](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I5FCR5)）

-   Release 2.10.0

    -   **新增**：新增电商收付通跨境付款相关接口。

    -   **新增**：随官方更新消费者投诉单相关接口模型。

-   Release 2.9.1

    -   **修复**：修复查询分账回退结果接口 URL 错误。（_via_ [GitHub #46](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/46)）

-   Release 2.9.0

    -   **新增**：随官方更新特约商户进件、电商收付通二级商户进件相关接口模型。

-   Release 2.8.0

    -   **新增**：随官方更新合单支付相关接口模型。

    -   **新增**：随官方更新消费者投诉相关接口模型。

    -   **变更**：升级公共组件至 v2.5.0。

-   Release 2.7.0

    -   **新增**：新增小微商户进件相关接口。

    -   **新增**：随官方更新二级商户进件、电商收付通商户进件相关接口模型。

-   Release 2.6.0

    -   **新增**：支持境外支付 For HK 的相关接口。

-   Release 2.5.2

    -   **变更**：升级公共组件至 v2.3.3。（_via_ [GitHub #34](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/34)）

-   Release 2.5.1

    -   **新增**：调整 RSA 工具类使之支持多种填充方式。

    -   **变更**：升级公共组件至 v2.3.2。

-   Release 2.5.0

    -   **新增**：随官方更新根据过滤条件查询用户券相关接口模型。

    -   **新增**：随官方更新查询支付分订单相关接口模型。

    -   **新增**：随官方更新联行号查询相关接口模型。

    -   **变更**：升级公共组件至 v2.3.1。

    -   **修复**：修复电商收付通二级商户进件接口的请求模型定义错误。

-   Release 2.4.0

    -   **变更**：升级公共组件至 v2.2.0。

    -   **变更**：重命名部分与证书有关的参数名，涉及到变化的类有 `WechatTenpayClientOptions`、`WechatTenpayClient`、`WechatTenpayRequest`、`WechatTenpayResponse`。

-   Release 2.3.1

    -   **新增**：随官方更新发起批量转账相关接口模型。

    -   **修复**：修复无法自动为请求设置平台证书序列号的问题。

-   Release 2.3.0

    -   **新增**：新增银行组件相关接口。

    -   **变更**：升级公共组件至 v2.1.1。

-   Release 2.2.2

    -   **修复**：修复二级商户进件提交申请单接口因 URL 结尾反斜杠问题而无法正常请求的问题。（_via_ [GitHub #19](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/19)）

-   Release 2.2.1

    -   **修复**：修复空响应时无法正确反序列化的问题。

-   Release 2.2.0

    -   **新增**：新增会员卡相关接口。

-   Release 2.1.3

    -   **修复**：修复部分响应模型解密敏感数据字段时抛出异常的问题。（_via_ [GitHub #17](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/17)）

-   Release 2.1.2

    -   **修复**：修复部分嵌套类型中属性的敏感数据不能自动加密的问题。（_via_ [Gitee #I4K40Y](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I4K40Y)）

    -   **修复**：修复 `CertificateEntry` 不支持 JSON 反序列化的问题。（_via_ [Gitee #I4KP8H](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I4KP8H)）

-   Release 2.1.1

    -   **修复**：修复部分请求模型加密敏感数据字段时抛出异常的问题。（_via_ [Gitee #I4JIZC](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I4JIZC)）

-   Release 2.1.0

    -   **新增**：新增商户平台处置通知相关接口。

    -   **新增**：随官方更新消费者投诉相关接口模型。

    -   **新增**：新增基于反射和特性的自动加密请求中敏感信息字段的功能。

    -   **新增**：新增基于反射和特性的自动解密响应中敏感信息字段的功能。

    -   **变更**：移除原有的解密响应中敏感信息字段的扩展方法。

-   Release 2.0.3

    -   **修复**：修复创建代金券批次相关接口的请求模型定义错误。（_via_ [Gitee #I4ITW6](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I4ITW6)）

-   Release 2.0.2

    -   **修复**：修复发放代金券批次相关接口的请求模型定义错误。（_via_ [Gitee #I4IJDR](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I4IJDR)）

-   Release 2.0.1

    -   **变更**：升级依赖 `Portable.BouncyCastle` 至 v1.9.0。

    -   **修复**：修复查询代金券相关接口的响应模型定义错误。（_via_ [Gitee #I4HRYL](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I4HRYL)）

-   Release 2.0.0

    -   **新增**：随官方更新商家券相关接口模型。

    -   **新增**：适配 .NET 6.0。

    -   **变更**：移除核心库依赖，引入公共组件。

-   Release 1.8.2

    -   **新增**：新增商户申请获取微信支付分对账单相关接口。

    -   **修复**：修复部分请求模型中可空字段的初值问题。（_via_ [Gitee #I4BF0K](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I4BF0K)）

-   Release 1.8.1

    -   **修复**：修复查询分账结果接口的调用时参数缺失问题。（_via_ [Gitee #I4BITZ](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I4BITZ)）

-   Release 1.8.0

    -   **新增**：新增消费者投诉下载图片相关接口。

    -   **新增**：随官方更新消费者投诉接口相关字段。

-   Release 1.7.0

    -   **变更**：升级核心库。

-   Release 1.6.0

    -   **新增**：新增银行定向促活相关接口。

-   Release 1.5.4

    -   **修复**：修复特约商户进件提交申请单接口请求模型定义错误的问题。（_via_ [Gitee #I45RRM](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I45RRM)）

-   Release 1.5.2

    -   **修复**：修复特约商户进件提交申请单接口因 URL 结尾反斜杠问题而无法正常请求的问题。（_via_ [Gitee #I45QFY](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I45QFY)）

-   Release 1.5.1

    -   **修复**：修复部分接口模型因继承问题在使用 System.Text.Json 时序列化有误的问题。（_via_ [Gitee #I45C27](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I45C27)）

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

    -   **变更**：移除 `ICertificateStorer` 接口类，新增 `CertificateManager` 抽象类。

    -   **修复**：修复部分场景下生成请求签名的错误。（_via_ [GitHub #2](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/2)）

-   Release 1.3.1

    -   **新增**：新增批量转账到零钱相关接口。

    -   **新增**：新增服务商批量转账到零钱相关接口。

    -   **新增**：新增 `ICertificateStorer` 接口，并基于此重新实现验签的扩展方法。（_via_ [GitHub #1](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/1)）

-   Release 1.2.1

    -   **新增**：新增 `WechatTenpayV3Client.CreateRequest()` 方法。

-   Release 1.2.0

    -   **变更**：调整包含需加解密字段的接口模型，去除 _EncryptedData_ 的字段名结尾。

-   Release 1.1.0

    -   **新增**：新增分账相关接口。

-   Release 1.0.1

    -   **新增**：随官方更新服务商提现、服务商结算账户接口相关字段。

    -   **修复**：修复调起支付所需参数签名生成错误。（_via_ [Gitee #I3YY2C](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I3YY2C)）

-   Release 1.0.0

    -   首次发布。

</details>

---

### 模块 `SKIT.FlurlHttpClient.Wechat.Work` 更新日志

<details>

<summary>[展开查看]</summary>

-   Release 2.21.0

    -   **新增**：随官方更新获客助手、日程、文档收集表等相关接口模型。

    -   **新增**：新增人事助手花名册相关接口。

-   Release 2.20.1

    -   **修复**：修复部分 POST 接口丢失请求正文的问题。

-   Release 2.20.0

    -   **新增**：新增会议高级布局管理相关接口。

    -   **新增**：随官方更新创建预约会议接口响应模型。

-   Release 2.19.0

    -   **新增**：新增会议高级管理、会中控制管理、网络研讨会管理、电话入会管理、Rooms 会议室管理、会议室连接器管理、会议布局和背景管理、会议录制管理等相关接口。

    -   **变更**：升级依赖 `BouncyCastle.Cryptography` 至 v2.2.1。

-   Release 2.18.0

    -   **新增**：新增获客助手相关接口。

    -   **新增**：新增对外收款账户相关接口。

    -   **新增**：新增第三方应用开发多企业新购订单相关接口。

    -   **新增**：随官方更新普通邮件、日历、会议室等相关接口模型。

-   Release 2.17.1

    -   **修复**：修复会话内容存档下载媒体文件时 Windows 环境下存在的 IntPtr Double Free 问题。（_via_ [GitHub #95](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/95)）

-   Release 2.17.0

    -   **新增**：新增外部用户临时 ID 转换接口。

    -   **新增**：新增通过日程或会议预定会议室接口。

    -   **新增**：新增管理打卡规则相关接口。

    -   **新增**：随官方更新获取对外收款记录接口模型。

    -   **新增**：新增生成第三方单点登录扫码授权 URL 的扩展方法。

-   Release 2.16.0

    -   **新增**：实现会话内容存档导出聊天记录相关功能。

-   Release 2.15.0

    -   **新增**：新增文档表格相关接口。

    -   **新增**：新增查询文件保密模式操作记录接口。

    -   **新增**：随官方更新会议相关接口模型。

    -   **新增**：随官方更新文档收集表相关接口模型。

    -   **新增**：随官方更新上下游通讯录管理相关接口模型。

    -   **新增**：随官方更新微信客服消息相关接口模型。

    -   **新增**：新增若干回调通知事件模型。

-   Release 2.14.2

    -   **变更**：升级公共组件至 v2.6.0。

    -   **修复**：修复发送应用消息接口模型参数缺失问题。（_via_ [Gitee #I64NYJ](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I64NYJ)）

-   Release 2.14.1

    -   **修复**：修复更新模版卡片消息接口模型参数缺失问题。（_via_ [Gitee #I64O6T](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I64O6T)）

-   Release 2.14.0

    -   **新增**：新增停止发表企业朋友圈、提醒成员群发、停止企业群发接口。

    -   **新增**：新增邮件相关接口。

    -   **新增**：新增文档相关接口。

    -   **新增**：新增部分微盘相关接口。

    -   **新增**：新增部分微盘相关回调通知事件模型。

    -   **新增**：新增第三方代开发账号 ID 转换相关接口。

    -   **新增**：新增第三方应用开放收银台订单相关接口。

    -   **新增**：新增获取接口大批量调用凭据。

    -   **新增**：新增硬件云端接入相关接口。

    -   **新增**：随官方更新创建企业群发接口模型。

    -   **新增**：随官方更新上下游通讯录管理相关接口模型。

    -   **新增**：随官方更新微信客服相关接口模型。

    -   **新增**：随官方更新日历、日程、微盘相关接口模型。

    -   **新增**：随官方更新获取企业永久授权码接口模型。

    -   **修复**：修复微盘相关接口模型的拼写错误。

-   Release 2.13.0

    -   **新增**：新增接口调用许可相关接口。

    -   **新增**：新增自建应用代开发相关接口。

    -   **新增**：新增获取访问用户身份或敏感信息接口。

-   Release 2.12.0

    -   **新增**：新增 OA 导出汇报文档接口。

    -   **新增**：随官方更新 OA 汇报相关接口模型。

-   Release 2.11.0

    -   **新增**：新增素材管理上传临时素材接口相关接口。

    -   **新增**：新增通讯录搜索相关接口。

    -   **新增**：新增智慧硬件相关接口。

    -   **新增**：随官方更新日历相关接口模型。

    -   **新增**：随官方更新日程相关接口模型。

    -   **新增**：随官方更新通讯录 UserId 排序接口请求模型。

    -   **新增**：随官方更新发送应用消息接口响应模型。

-   Release 2.10.0

    -   **新增**：新增获取收款项目的商户单号相关接口。

    -   **新增**：新增为打卡人员补卡相关接口。

    -   **新增**：新增微信客服知识库相关接口。

    -   **新增**：随官方更新获取企业上下游通讯录下的企业信息的接口模型。

    -   **新增**：随官方更新获取企业假期管理配置、获取成员假期余额的接口模型。

    -   **新增**：随官方更新读取微信客服消息的接口模型。

    -   **变更**：随官方标记通讯录同步相关接口或字段为废弃。

-   Release 2.9.0

    -   **新增**：新增分配在职成员的客户群接口。

    -   **新增**：新增批量导入上下游联系人、获取企业上下游通讯录下的企业信息等接口。

    -   **新增**：新增获取家校访问用户身份、获取观看/未观看直播统计 V2 版等接口。

    -   **新增**：随官方更新设置工作台自定义展示相关接口模型。

    -   **新增**：随官方更新获取上下游通讯录分组接口模型。

    -   **新增**：新增上下游相关回调通知事件模型。

    -   **修复**：修复部分接口模型命名拼写错误。

-   Release 2.8.0

    -   **新增**：新增上下游规则相关接口。

    -   **新增**：随官方更新获取客户详情、微信客服接待人员管理相关接口模型。

-   Release 2.7.2

    -   **修复**：修复上传素材接口不支持 Unicode 文件名问题。（_via_ [GitHub #40](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/40)）

-   Release 2.7.1

    -   **修复**：修复部分事件通知模型中数组类型字段反序列化错误的问题。（_via_ [Gitee #I52P9I](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I52P9I)）

-   Release 2.7.0

    -   **新增**：新增企业邮箱相关接口。

    -   **新增**：新增防疫场所码相关接口。

    -   **新增**：随官方更新外部联系人相关接口模型。

    -   **新增**：随官方更新会议室、日程相关接口模型。

    -   **新增**：随官方更新健康上报相关接口模型。

    -   **新增**：随官方更新微信客服相关接口模型。

    -   **变更**：升级公共组件至 v2.5.0。

    -   **变更**：调整 `SHA1Utility` 工具类的计算字节数组哈希值方法的返回值类型。

-   Release 2.6.3

    -   **修复**：修复部分场景下无法反序列化空字符串字段为数值类型的问题。

-   Release 2.6.2

    -   **变更**：升级公共组件至 v2.3.3。（_via_ [GitHub #34](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/34)）

-   Release 2.6.1

    -   **变更**：升级公共组件至 v2.3.2。（_via_ [GitHub #34](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/34)）

-   Release 2.6.0

    -   **变更**：升级公共组件至 v2.3.1。

    -   **修复**：修复自建应用审批回调通知事件模型的定义错误。

-   Release 2.5.1

    -   **修复**：修复部门 ID 可能溢出的问题。（_via_ [Gitee #5](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pulls/5)）

-   Release 2.5.0

    -   **变更**：升级公共组件至 v2.2.0。

-   Release 2.4.0

    -   **新增**：新增获取单个部门和子部门 ID 列表的相关接口。

    -   **新增**：新增上下游相关接口。

    -   **新增**：新增客户群加入群聊管理相关接口。

    -   **新增**：新增获取带参授权链接相关接口。

    -   **新增**：随官方调整获取指定的应用详情相关接口模型。

    -   **新增**：新增获取带参的应用二维码相关接口。

    -   **新增**：新增日程参与者相关接口。

    -   **新增**：随官方更新成员相关接口模型。

-   Release 2.3.0

    -   **新增**：新增生成参数化 URL 的扩展方法。

    -   **变更**：升级公共组件至 v2.1.1。

    -   **变更**：重命名生成 JS-SDK 客户端签名参数的扩展方法。

-   Release 2.2.1

    -   **修复**：修复部门次序值可能溢出的问题。

-   Release 2.2.0

    -   **新增**：新增会议室预定的回调通知事件模型。

    -   **新增**：新增根据会议 ID 查询会议室预订详情的相关接口。

-   Release 2.1.0

    -   **新增**：随官方更新企业通讯录成员相关接口模型。

    -   **新增**：新增代开发应用 ExternalUserId 转换接口。

    -   **新增**：适配企业微信帐号 ID 安全性全面升级。

    -   **修复**：修复部分回调通知事件模型字段缺失的问题。

-   Release 2.0.0

    -   **新增**：适配 .NET 6.0。

    -   **变更**：移除核心库依赖，引入公共组件。

-   Release 1.4.0

    -   **新增**：新增微信客服相关接口。

    -   **新增**：随官方更新发送应用消息相关接口模型。

    -   **新增**：新增获取设备打卡数据相关接口。

    -   **新增**：新增管理员变更相关的回调通知事件模型。

-   Release 1.3.4

    -   **修复**：修复应用消息相关接口的调用时参数缺失问题。（_via_ [GitHub #10](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/10)）

-   Release 1.3.3

    -   **修复**：修复批量获取客户详情时的请求模型定义错误。（_via_ [GitHub #9](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pull/9)）

-   Release 1.3.2

    -   **修复**：修复创建或获取通讯录成员时的请求模型定义错误。（_via_ [GitHub #8](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/8)）

-   Release 1.3.1

    -   **修复**：修复获取服务商凭证接口请求模型定义错误。（_via_ [GitHub #5](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pull/5)）

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

    -   **修复**：修复部分场景下生成微信回调通知事件签名错误的问题。（_via_ [GitHub #4](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/4)）

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

---

### 模块 `SKIT.FlurlHttpClient.Wechat.Ads` 更新日志

<details>

<summary>[展开查看]</summary>

-   Release 2.0.0

    -   首次发布。

</details>

---

### 模块 `SKIT.FlurlHttpClient.Wechat.OpenAI` 更新日志

<details>

<summary>[展开查看]</summary>

-   Release 2.0.1

    -   **变更**：升级公共组件至 v2.6.0。

-   Release 2.0.0

    -   首次发布。

</details>

---

### 模块 `SKIT.FlurlHttpClient.Wechat.TenpayBusiness` 更新日志

<details>

<summary>[展开查看]</summary>

-   Release 2.2.0

    -   **新增**：新增分账、提现等相关接口。

-   Release 2.1.0

    -   **新增**：新增二维码支付预下单、小程序支付预下单、App 支付预下单、企业微信支付预下单等接口。

    -   **新增**：新增退款相关接口。

    -   **新增**：支持新版域名。

    -   **新增**：支持企业商户软签名。

    -   **变更**：重命名部分接口模型，去除公共部分 "MSEPay"。

    -   **变更**：重命名接口模型中关于敏感字段加解密相关的字段，去除公共部分 "TBEP"。

-   Release 2.0.1

    -   **变更**：升级依赖 `BouncyCastle.Cryptography` 至 v2.1.1。

-   Release 2.0.0

    -   首次发布。

</details>
