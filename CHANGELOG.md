# CHANGELOG

---

<details>

<summary>SKIT.FlurlHttpClient.Wechat 更新日志</summary>

-   Release 1.0.3

    -   **修复**：显式依赖 `System.Text.Encodings.Web`，修复部分场景下程序集加载问题。

-   Release 1.0.2

    -   **新增**：新增 `IWechatClient.JsonSerializer` 属性。

-   Release 1.0.1

    -   **变更**：移除 `IWechatClient.CreateRequest()` 方法。

-   Release 1.0.0

    -   首次发布。

</details>

---

<details>

<summary>SKIT.FlurlHttpClient.Wechat.Api 更新日志</summary>

-   Release 1.3.2

    -   **新增**：新增验证微信回调通知事件签名的扩展方法。

    -   **新增**：反序列化微信回调通知事件模型时支持 `WechatApiEvent` 基类，以便业务逻辑判断。

-   Release 1.3.1

    -   **修复**：修复自定义交易组件获取快递公司列表接口的模型定义错误。

-   Release 1.3.0

    -   **新增**：新增序列化回调通知事件实体类的扩展方法。

    -   **新增**：反序列化微信回调通知事件模型时支持安全模式。

    -   **修复**：修复部分微信回调通知事件模型反序列化的问题。

-   Release 1.2.1

    -   **修复**：修复生成小程序码接口的模型定义错误。

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

<summary>SKIT.FlurlHttpClient.Wechat.TenpayV3 更新日志</summary>

-   Release 1.4.0

    -   **新增**：新增获取分账账单相关接口。

    -   **新增**：随官方更新分账、服务商分账接口相关字段。

    -   **新增**：新增 `WechatTenpayV3Client.Credentials` 属性。

    -   **变更**：移除 `WechatTenpayV3Client.FlurlJsonSerializer` 属性。

    -   **变更**：移除 `ICertificateStorer` 接口，新增 `CertificateManager` 抽象类。

-   Release 1.3.1

    -   **新增**：新增批量转账到零钱相关接口。

    -   **新增**：新增服务商批量转账到零钱相关接口。

    -   **新增**：新增 `ICertificateStorer` 接口，并基于此重新实现验签的扩展方法。

-   Release 1.2.1

    -   **新增**：新增 `WechatTenpayV3Client.CreateRequest()` 方法。

-   Release 1.2.0

    -   **变更**：调整包含需加解密字段的接口模型，去除 _EncryptedData_ 的字段名结尾。

-   Release 1.1.0

    -   **新增**：新增分账相关接口。

-   Release 1.0.1

    -   **新增**：随官方更新服务商提现、服务商结算账户接口相关字段。

    -   **修复**：修复调起支付所需参数签名生成错误。

-   Release 1.0.0

    -   首次发布。

</details>

---

<details>

<summary>SKIT.FlurlHttpClient.Wechat.Work 更新日志</summary>

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
