## 如何快速找到需要调用的 API 模型类名 / 方法名？

---

本库提供的请求模型、响应模型和接口方法，三者均保持同名。

例如，申请产品开通的请求是 `CreateMSEPayProductApplicationRequest`，响应是 `CreateMSEPayProductApplicationResponse`，接口是 `ExecuteCreateMSEPayProductApplicationAsync()`。知道其中一个，其余两个就可以快速地推断出了。

再有，每个对象的命名与官方文档的接口地址大体保持一致。例如刚刚提到的申请产品开通，它的接口地址是 `[POST] /mse-pay/product-applications`，将其中的反斜杠去掉、并以大驼峰命名法的方式调整它，就可以得到前文提到的几个对象了。

另外，以 `Query` 开头的一般表示列表查询；以 `Get` 开头的一般表示获取详情；以 `Create` 开头的一般表示发起或新建操作。

完整的模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Wechat.TenpayBusiness/Models_ 目录。

---

### 找不到所需要的接口或字段？

本库会定期随微信官方更新接口或模型，但也会偶有疏漏。如果你在使用中遇到了因接口或模型定义而产生的问题，欢迎提出 Issue。

如果你的项目来不及等待 Issue 被处理，你可以自行扩展相关 API。

---

### 【附】微企付商户 API 模型命名速查表：

<details>

<summary>[展开查看]</summary>

-   商户入驻

    -   申请产品开通：`CreateMSEPayProductApplication`

    -   查询产品开通：`GetMSEPayProductApplicationByOutRequestNumber` / `GetMSEPayProductApplicationByRequestNumber`

    -   创建开通跳转链接：`CreateMSEPayProductApplicationLink`

    -   图片上传接口：`UploadFile`

-   H5 支付

    -   H5 支付预下单：`CreateMSEPayPaymentH5Pay`

    -   根据交易订单查询付款结果：`GetMSEPayPaymentByOutPaymentId` / `GetMSEPayPaymentByPaymentId`

    -   主动关单：`CloseMSEPayPayment`

    -   主动关单：`CloseMSEPayPayment`

-   公共资源 Redirect：

    -   获取跳转对象：`CreateMSEPayRedirectLink`

-   文件获取：

    -   获取账单文件下载地址：`GetMSEPayAccountBill`

    -   文件获取：`DownloadMSEPayAccountBill`

</details>
