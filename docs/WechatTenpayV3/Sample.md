## 示例项目

---

示例项目基于 .NET Framework 4.8 和 .NET 6.0 实现，分别位于 _samples/SKIT.FlurlHttpClient.Wechat.Sample_NetFramework48_ 和 _samples/SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample_Net6_。

示例项目依赖以下第三方库：

-   [`Autofac`](https://github.com/autofac/Autofac)：依赖注入容器。

-   [`Hangfire`](https://github.com/HangfireIO/Hangfire)：后台作业调度框架。

示例项目实现了以下功能：

-   多租户商户号；

-   微信商户平台证书自动更新；

-   验证并接收微信服务器推送数据；

-   一个 JSAPI 下单和退款的 WebAPI。

---

### 【重要】使用前须知：

示例项目仅作为业务上的参考，不代表可直接用于生产。

开发者应提前知晓：

#### 1. 容错性：

示例项目中未特殊处理可能产生的异常（如：空指针等），开发者可根据业务需要自行实现。

#### 2. 安全性：

示例项目中不包含授权认证等相关的业务逻辑，开发者可根据业务需要自行实现。
