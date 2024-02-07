## 如何接入会话内容存档 C SDK？

---

> 请先自行阅读：
>
> [《企业微信开发者中心 - 服务端 API - 会话内容存档：使用前帮助》](https://developer.work.weixin.qq.com/document/path/91361)

自 v2.16.0 版本起，本库支持接入会话内容存档 C SDK。

如需使用本功能，请先在企业微信管理后台中开启会话内容存档并设置相关参数。

---

### 接入前必读

企业微信官方仅提供了 C 语言实现的会话内容存档 SDK，且屏蔽了具体实现细节。

本库在此基础之上，对相关功能做了二次封装。

与简单的基于 P/Invoke 的调用方式相比，本库的封装更加符合 C# 项目的编程习惯，使得开发者无需关心非托管对象的内存空间开辟与释放问题，大大减轻了开发者的心智负担。

为了减少本库的打包体积，本库并没有内嵌 C SDK 相关的动态链接库，需要开发者手动下载。

-   对于 Linux 环境，你需要[下载 v1.2 版本的 C SDK for Linux](https://developer.work.weixin.qq.com/document/path/91774)，解压缩并拷贝以下几个文件到你的项目根路径下，或添加至系统环境变量 _/$LD_LIBRARY_PATH/_（通常为 _/lib/_ 或 _/usr/lib/_）中：

    1. `libWeWorkFinanceSdk_C.so`

-   对于 Windows 环境，你需要[下载 v1.1 版本的 C SDK for Windows](https://developer.work.weixin.qq.com/document/path/91774)，解压缩并拷贝以下几个文件到你的项目根路径下，或添加至系统环境变量 _%SYSTEMROOT%\System32\\_（通常为 _C:\Windows\System32\\_）中：

    1. `libcrypto-1_1-x64.dll`
    2. `libcurl-x64.dll`
    3. `libssl-1_1-x64.dll`
    4. `WeWorkFinanceSdk.dll`

请注意，以上几个文件，不能重命名其文件名。

---

### 接入指引

#### 一、初始化

与初始化本库的 HTTP API 客户端的过程类似。

```csharp
using SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.Finance;
using SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.Finance.Models;
using SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.Finance.Settings;

var manager = new InMemoryEncryptionKeyManager();
manager.AddEntry(new EncryptionKeyEntry(1, "-----BEGIN RSA PRIVATE KEY----- 消息加解密私钥 PKCS#1 PEM 内容 -----END RSA PRIVATE KEY-----"));
var options = new WechatWorkFinanceClientOptions()
{
    CorpId = "企业微信 CorpId",
    SecretKey = "会话内容存档 SecretKey",
    EncryptionKeyManager = manager // 密钥管理器的具体用法将在本章节下文详细介绍
};
var client = new WechatWorkFinanceClient(options);
```

#### 二、获取会话记录数据

```csharp
var request = new GetChatRecordsRequest()
{
    LastSequence = 0,
    Limit = 100
};
var response = await client.ExecuteGetChatRecordsAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("聊天记录：" + response.RecordList);
}
else
{
    Console.WriteLine("返回值：" + response.ReturnCode);
    Console.WriteLine("错误代码：" + response.ErrorCode);
    Console.WriteLine("错误描述：" + response.ErrorMessage);
}
```

#### 三、解密会话记录数据

> ⚠️ 【重要说明】使用该接口需要提前在 `EncryptionKeyManager` 中存入全部消息加解密的 RSA 私钥及其对应版本号。

```csharp
var request = new DecryptChatRecordRequest()
{
    PublicKeyVersion = 1,           // 即上一接口返回的 "RecordList[].PublicKeyVersion" 字段
    EncryptedRandomKey = "KEY",     // 即上一接口返回的 "RecordList[].EncryptedRandomKey" 字段
    EncryptedChatMessage = "CIPHER" // 即上一接口返回的 "RecordList[].EncryptedChatMessage" 字段
};
var response = await client.ExecuteDecryptChatRecordAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("聊天记录：" + response.RecordList);
}
else
{
    Console.WriteLine("返回值：" + response.ReturnCode);
}
```

#### 四、下载媒体文件

在 C SDK 中，每次获取媒体文件数据，仅返回最大 512KB 的文件分片。

本库已经实现了自动获取全部分片、并整合到一起的功能，同时也参照官方建议实现了错误重试机制，你无需关心每个分片的具体下载过程，只需要：

```csharp
var request = new GetMediaFileRequest()
{
    FileId = "SDK_FILE_ID"
};
var response = await client.ExecuteGetMediaFileAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("文件的字节数组：" + response.FileBytes);
}
else
{
    Console.WriteLine("返回值：" + response.ReturnCode);
}
```

当然，如果你想手动控制下载分片的过程，你也可以：

```csharp
var request = new GetMediaFileBufferRequest()
{
    FileId = "SDK_FILE_ID",
    BufferIndex = "INDEX_BUF"
};
var response = await client.ExecuteGetMediaFileBufferAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("分片的字节数组：" + response.FileBufferBytes);
    Console.WriteLine("下一次的分片索引：" + response.NextBufferIndex);
    Console.WriteLine("是否已是最后一个分片：" + response.IsFinished);
}
else
{
    Console.WriteLine("返回值：" + response.ReturnCode);
}
```

---

### 常见问题

#### **Q1：是否可以实例化多个 `WechatWorkFinanceClient`？**

不可以，也不需要。

你应该以全局单例模式使用 `WechatWorkFinanceClient`，它是线程安全的。

如果真的有多次实例化的场景，请务必在实例化新的对象之前、对前一个对象手动执行 `client.Dispose()` 方法以销毁，避免出现未知问题。

#### **Q2：密钥管理器 `EncryptionKeyManager` 有什么用？**

在企业微信管理后台中，你需要设置消息加解密 RSA 公钥，并在获取会话记录数据后使用对应的 RSA 私钥来解密聊天记录。

每当你重新设置新的 RSA 公钥时，消息加解密公钥版本号就会 +1。但已经产生过的会话记录数据仍然需要使用旧的 RSA 私钥来解密（这是由于非对称加密算法的原理导致的，具体细节不在此赘述）。

因此，在加解密会话记录数据的过程中，可能需要多对儿 RSA 公私钥共同参与。

> ⚠️ 【重要说明】请尽量避免频繁重置消息加解密密钥。如果真的有需要，请千万不要忘记在重置前备份上一个版本的私钥，否则已经产生的会话记录数据将永远无法解密。

本库提供了 `EncryptionKeyManager` 这一对象，以简化解密流程。你只需在初始化时将各个版本的 RSA 私钥都存入密钥管理器中，后续调用解密会话记录数据时，本库将根据传入的公钥版本号自动选择对应的私钥：

```csharp
manager.AddEntry(new EncryptionKeyEntry(1, "-----BEGIN RSA PRIVATE KEY----- 私钥版本 1 -----END RSA PRIVATE KEY-----"));
manager.AddEntry(new EncryptionKeyEntry(2, "-----BEGIN RSA PRIVATE KEY----- 私钥版本 2 -----END RSA PRIVATE KEY-----"));
manager.AddEntry(new EncryptionKeyEntry(3, "-----BEGIN RSA PRIVATE KEY----- 私钥版本 3 -----END RSA PRIVATE KEY-----"));
```

> 注：`InMemoryEncryptionKeyManager` 是本库内置的基于内存实现的密钥管理器；你也可自行继承并实现一个 `EncryptionKeyManager`，例如利用数据库或 Redis 等方式存取密钥信息。

#### **Q3：官方示例中提供了诸如 `FreeSlice`、`FreeMediaData`、`DestroySdk` 等接口，该如何调用？**

这些方法均是为了释放由 C SDK 开辟的内存空间而提供的，对于 C# 来说，这些都是非托管对象。

本库已经实现了自动释放非托管内存机制，开发者无需关心内存泄露问题。

#### **Q4：内网环境下如何使用？**

在 C SDK 中，已经包含了 SOCK5 代理或 HTTP 代理的相关参数。

在使用本库时，你可以在构造得到 `WechatWorkFinanceClient` 对象时指定代理参数：

```csharp
var options = new WechatWorkFinanceClientOptions()
{
    // 其他配置项略
    ProxyAddress = "socks5://10.0.0.1:8081",
    ProxyAuthentication = "username:password"
};
var client = new WechatWorkFinanceClient(options);
```
