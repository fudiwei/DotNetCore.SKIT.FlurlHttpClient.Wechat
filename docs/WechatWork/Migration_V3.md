﻿## v3.x 迁移指南

v3.x 版本是一个主要版本，其中包括了一些破坏性的变化。从 v2.x 升级到 v3.x 之前，请仔细阅读本文档。

---

### 目标框架和框架的变更

微软官方已与 2022 年 4 月 26 日宣布中止对 .NET Framework 4.6.1 的支持。因此，本项目的最低运行时要求调整为 .NET Framework 4.6.2。

与此同时，相关的 .NET 基础库（即通常在 `System.*` 或 `Microsoft.*` 命名空间下的内置类型）版本对齐至 .NET 8.0。

### `Flurl.Http` 的变更

本库所依赖的 `Flurl.Http` 版本已升级至 v4.0.0，并由此带来一些底层的破坏性变化。

通常情况下，开发者不需要关注这些变化，除非你正在自定义额外的 API 接口。

### 新的构造器模式

随着 `Flurl.Http` 的升级，原有的与 `IHttpClientFactory` 集成的方式发生了根本性的改变。

为了应对这种变化（请参阅本文档[《如何与 `IHttpClientFactory` 集成？》](./Advanced_IHttpClientFactory.md)），也为了日后能更加灵活地配置客户端，我们在新版本中提供了构造器模式来构造客户端：

```csharp
var options = new WechatWorkClientOptions() { /* 具体配置项略 */ };
var client = WechatWorkClientBuilder.Create(options).Build();
```

当然，原有的实例化方式仍然可用：

```csharp
var options = new WechatWorkClientOptions() { /* 具体配置项略 */ };
var client = new WechatWorkClient(options);
```

### 基础类型：`SKIT.FlurlHttpClient.Primitives.EncodedeString`

在进行加解密或哈希等操作时，参与运算的数据和最终得到的结果通常是字节数组（即 `byte[]`）形式。而在实际应用中，我们常常需要将这些字节序列转换成文本格式。我们发现即便是同一种加解密或哈希算法，在不同平台上所需要的编码方式也可能不同。比如同为 SHA256，在某些接口中需要转换为十六进制（HEX）编码传参，而在另一些接口中却需要转换为 Base64 编码传参。

在过往的版本中，我们在不同的模块中针对不同平台的要求提供了单独的封装方法，这使得代码更加分散且不易维护。

为了统一处理并简化这些差异，我们在公共组件中引入了 `EncodedString` 这一类型。`EncodedString` 类型是一个封装结构，它提供了统一的接口来处理不同编码方式的字符串。通过该类型，开发者可以不必关心底层使用的是哪种编码方式，从而使代码更加简洁和清晰。

幸运的是，为了简化升级的难度，`EncodedString` 仍可以与 `String` 类型互相转换：

```csharp
// string → EncodedString
string str = "U0tJVC5GbHVybEh0dHBDbGllbnQgaXMgQVdFU09NRSE=";
EncodedString estr = (EncodedString)str;

// EncodedString → string
EncodedString estr = new EncodedString("U0tJVC5GbHVybEh0dHBDbGllbnQgaXMgQVdFU09NRSE=", EncodingKinds.Base64);
string str = (string)estr;
```

涉及到变化的包括 `AESUtility`、`RSAUtility`、`SHA1Utility` 等工具类。

### 基础类型：`SKIT.FlurlHttpClient.Primitives.ErroredResult`

在进行数据验签等操作时，由于传入了错误的参数导致抛出异常，通常需要被视为验签失败。

在过往的版本中，我们在相应的方法内部 `try-catch` 捕获所有异常，并直接返回 `false`。然而，这种做法虽然简化了返回值的处理，但却严重限制了开发者错误调试的能力，因为它无法提供关于异常的详细信息。虽然有部分方法提供了带有 `(..., out Exception error)` 引用参数的重载，但却不能在异步方法中所使用。

为了解决这一问题，我们在公共组件中引入了 `ErroredResult` 这一类型。`ErroredResult` 类型是一个封装结构，它不仅可以在逻辑上表示操作的成功与否，而且能够携带发生的异常信息，极大地便利了异常处理和调试过程。

幸运的是，为了简化升级的难度，`ErroredResult` 仍可以与 `Boolean` 类型互相转换：

```csharp
// Boolean → ErroredResult
bool ret = true;
ErroredResult eret = (ErroredResult)ret;

// ErroredResult → Boolean
ErroredResult eret = new ErroredResult(true);
bool ret = (bool)eret;
```

涉及到变化的包括 `VerifyEventSignatureForEcho()`、`VerifyEventSignatureFromJson()`、`VerifyEventSignatureFromXml()` 等扩展方法。

### 企业会话存档 SDK

原企业会话存档 SDK 客户端的命名空间发生了变化，由 `SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance` 移动至 `SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.Finance`。

同时，我们提供了新的 `IEncryptionKeyManagerAsync` 接口，开发者可以基于此自定义异步的密钥管理器实现。
