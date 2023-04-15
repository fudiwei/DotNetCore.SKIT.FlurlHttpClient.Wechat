## 如何快速找到需要调用的 API 模型类名 / 方法名？

---

本库提供的请求模型、响应模型和接口方法，三者均保持同名。

例如，申请产品开通的请求是 `CreateProductApplicationRequest`，响应是 `CreateProductApplicationResponse`，接口是 `ExecuteCreateProductApplicationAsync()`。知道其中一个，其余两个就可以快速地推断出了。

再有，每个对象的命名与官方文档的接口地址大体保持一致。例如刚刚提到的申请产品开通，它的接口地址是 `[POST] /mse-pay/product-applications`，将其中的反斜杠去掉、并以大驼峰命名法的方式调整它，就可以得到前文提到的几个对象了。

另外，以 `Query` 开头的一般表示列表查询；以 `Get` 开头的一般表示获取详情；以 `Create` 开头的一般表示发起或新建操作。

完整的模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Wechat.TenpayBusiness/Models_ 目录。

---

### 找不到所需要的接口或字段？

本库会定期随微信官方更新接口或模型，但也会偶有疏漏。如果你在使用中遇到了因接口或模型定义而产生的问题，欢迎提出 Issue。

在 Issue 被处理之前，你也可以选择自行扩展 API。

---

### 【附】微企付商户 API 模型命名速查表：

注：树形结构与[微企付开发文档](https://businesspay.qq.com/p/doc/mse/api/server.html)目录结构保持一致。

<details>

<summary>[展开查看]</summary>

-   商户入驻

    -   文件上传：`UploadFile`

    -   申请入驻：`CreateProductApplication`

    -   创建入驻跳转链接：`CreateProductApplicationLink`

    -   查询入驻结果（内单号）：`GetProductApplicationByRequestNumber`

    -   查询入驻结果（外单号）：`GetProductApplicationByOutRequestNumber`

-   二维码支付

    -   二维码支付预下单：`CreatePaymentQrcodePay`

    -   获取跳转对象信息：`CreatePaymentRedirectLink`

    -   查询订单明细（内单号）：`GetPaymentByPaymentId`

    -   查询订单明细（外单号）：`GetPaymentByOutPaymentId`

    -   支付关单：`ClosePayment`

-   小程序支付

    -   小程序支付预下单：`CreatePaymentMiniProgramPay`

    -   获取跳转对象信息：`CreatePaymentRedirectLink`

    -   查询订单明细（内单号）：`GetPaymentByPaymentId`

    -   查询订单明细（外单号）：`GetPaymentByOutPaymentId`

    -   支付关单：`ClosePayment`

-   H5 支付

    -   H5 支付预下单：`CreatePaymentH5Pay`

    -   获取跳转对象信息：`CreatePaymentRedirectLink`

    -   查询订单明细（内单号）：`GetPaymentByPaymentId`

    -   查询订单明细（外单号）：`GetPaymentByOutPaymentId`

    -   支付关单：`ClosePayment`

-   App 支付

    -   App 支付预下单：`CreatePaymentAppPay`

    -   获取跳转对象信息：`CreatePaymentRedirectLink`

    -   查询订单明细（内单号）：`GetPaymentByPaymentId`

    -   查询订单明细（外单号）：`GetPaymentByOutPaymentId`

    -   支付关单：`ClosePayment`

-   企业微信支付

    -   开通并支付预下单：`CreatePaymentAppRegisteringPay`

    -   支付预下单：`CreatePaymentAppPay`

    -   获取跳转对象信息：`CreatePaymentRedirectLink`

    -   查询订单明细（内单号）：`GetPaymentByPaymentId`

    -   查询订单明细（外单号）：`GetPaymentByOutPaymentId`

    -   支付关单：`ClosePayment`

-   智能分账：

    -   分账接收方账户查询：`QueryProfitAllocationReceiverAccounts`

    -   添加分账接收方账户申请：`CreateProfitAllocationReceiverAccountApplication`

    -   查询添加分账接收方账户申请结果（内单号）：`GetProfitAllocationReceiverAccountApplicationByApplicationId`

    -   查询添加分账接收方账户申请结果（外单号）：`GetProfitAllocationReceiverAccountApplicationByOutApplicationId`

    -   分账申请：`CreateProfitAllocation`

    -   解冻剩余资金：`SetProfitAllocationFinished`

    -   分账查询（内单号）：`GetProfitAllocationAmountByPaymentId`

    -   分账查询（外单号）：`GetProfitAllocationAmountByOutPaymentId`

    -   查询订单剩余待分金额：`GetProfitAllocationByOutAllocationId`

-   账单下载：

    -   获取资金账单下载链接：`GetBill`

    -   资金账单下载：`DownloadBillFile`

    -   获取交易账单下载链接：`GetBillTransaction`

    -   交易账单下载：`DownloadBillFile`

-   退款：

    -   退款申请：`CreateRefund`

    -   退款查询（内单号）：`GetRefundByRefundId`

    -   退款查询（外单号）：`GetRefundByOutRefundId`

</details>
