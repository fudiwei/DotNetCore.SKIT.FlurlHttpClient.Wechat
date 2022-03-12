## 如何加密请求中的敏感数据？

---

> 请先自行阅读：
>
> [《微信支付开发者文档 - 平台证书：获取平台证书列表》](https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay5_1.shtml)
>
> [《微信支付开发者文档 - 开发指南：敏感信息加解密》](https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml)

---

### 重要须知

请在开发过程中注意区分**商户证书**和**平台证书**：

-   **商户证书**与请求中的敏感数据加密无关；
-   **平台证书**用于加密请求中的敏感信息字段，需要在程序运行时实时通过接口动态获取（即 `QueryCertificatesAsync` 方法，注意证书内容需先经 AES-GCM 解密一次）。

如果你在开发过程中出现请求加密失败、服务器响应私钥解密失败的情况，请先检查是否混淆了这两个证书。

关于证书的更多注意事项，请参阅[《微信支付开发者文档 - 常见问题：证书相关》](https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay7_0.shtml)

---

### 证书文件格式说明及加密示例：

需要注意的是，`QueryCertificatesAsync` 方法返回的是 CER 格式的证书文件（需先经 AES-GCM 解密一次），需区分文件格式之间的不同：

-   以 `-----BEGIN PRIVATE KEY-----` 开头、 `-----END PRIVATE KEY-----` 结尾的是 **PKCS#8 私钥**文件。

-   以 `-----BEGIN PUBLIC KEY-----` 开头、 `-----END PUBLIC KEY-----` 结尾的是 **PKCS#8 公钥**文件。

-   以 `-----BEGIN CERTIFICATE--- --` 开头、 `-----END CERTIFICATE-----` 结尾的是 **CRT/CER 证书**文件，可从中导出 PKCS#8 公钥和证书序列号。

谨记，`QueryCertificatesAsync()` 方法返回的结果是 CRT/CER 证书，需要先通过 `RSAUtility` 工具类导出 PKCS#8 公钥，再进行数据加密；当然，`RSAUtility` 也封装了直接通过 CRT/CER 证书加密的方法。

---

### 加密流程

对于部分接口请求传递的敏感信息，微信商户平台可能会需要使用以下方式进行加密：

-   使用平台公钥/证书基于 RSA 算法加密。

开发者利用本库提供的 `RSAUtility` 工具类自行加密相关字段。下面给出一个使用 `RSAUtility` 工具类加密数据的示例代码：

```csharp
string plainText = "待加密的数据";
string certificate = "CRT/CER 证书内容";
/* 通过证书加密数据 */
string cipherText = RSAUtility.EncryptWithECBByCertificate(certificate, plainText);
/* 通过公钥加密数据 */
string publicKey = RSAUtility.ExportPublicKey(certificate);
string cipherText = RSAUtility.EncryptWithECB(publicKey, plainText);
```

此外，本库还封装了直接加密请求中敏感信息字段的扩展方法。下面给出一个手动调用的示例：

```csharp
var request = new Models.AddProfitSharingReceiverRequest()
{
    AppId = "AppId",
    Type = "PERSONAL_OPENID",
    Account = "OpenId",
    Name = "姓名明文",
    RelationType = "PARTNER"
};

string temp = request.Name; // 此时仍是明文
client.EncryptRequestSensitiveProperty(request);
string temp = request.Name; // 此时已是密文

var response = await client.ExecuteAddProfitSharingReceiverAsync(request);
```

如果你希望本库在请求前能自动完成这项操作，你可以在构造得到 `WechatApiClient` 对象时指定自动化参数：

```csharp
var options = new WechatTenpayClientOptions() 
{ 
    // 其他配置项略
    AutoEncryptRequestSensitiveProperty = true 
};
var client = new WechatTenpayClient(options);
```

这样，本库会在实际发出请求前自动为你调用 `EncryptRequestSensitiveProperty()` 方法。

需要注意的是，使用该扩展方法前需先下载好平台证书，并存入全局的 `CertificateManager`。有关 `CertificateManager` 的更多介绍，请参阅下一小节。

此外，该扩展方法使用反射、并依赖 `WechatTenpaySensitiveAttribute`、`WechatTenpaySensitivePropertyAttribute` 特性，相比较手动加密，可能会存在一定的性能开销。

---

### 通过 `CertificateManager` 管理平台证书信息：

微信商户平台证书需要通过 API 的方式获取、且可能同时存在多个有效证书，本库提供了一个 `CertificateManager` 类型可用于管理证书信息。

你可以在构造得到 `WechatApiClient` 对象时指定证书管理器：

```csharp
var manager = new InMemoryCertificateManager(); // 为便于后续使用，该对象可使用同一商户号下全局单例的方式声明
var options = new WechatTenpayClientOptions() 
{ 
    // 其他配置项略
    PlatformCertificateManager = manager 
};
var client = new WechatTenpayClient(options);
```

> 注：`InMemoryCertificateManager` 是本库内置的基于内存实现的证书管理器；你也可自行继承并实现一个 `CertificateManager`，例如利用数据库或 Redis 等方式存取证书信息。

你应在后台周期性地调用 `QueryCertificatesAsync()` 方法，并在解密得到证书内容后，记录到证书管理器中：

```csharp
/* 注意：QueryCertificatesAsync() 接口返回值需解密后再存入     */
/* 　　　存入的证书格式请参考上一小节给出的 CRT/CER 证书文件示例 */
/* 　　　示例项目中也包含一段关于此的演示程序                   */
manager.SetEntry(new CertificateEntry("CRT/CER 证书序列号", "CRT/CER 证书内容", "证书生效时间", "证书过期时间"));
```

当然，现在的平台证书离过期还有很久，你也可以选择“偷懒”：提前下载好平台证书，在程序启动时记录一次即可。

每个请求模型对象会包含一个名为 `WechatpayCertificateSerialNumber` 的公共字段，本库会根据该字段的值自动尝试在证书管理器中读取证书内容，并完成请求中敏感信息字段加密：

```csharp
request.WechatpayCertificateSerialNumber = "平台证书序列号";
client.EncryptRequestSensitiveProperty(request);
```

对于存在待加密敏感信息字段的请求模型对象而言，如果你不指定 `WechatpayCertificateSerialNumber` 字段的值，本库会自动从 `CertificateManager` 挑选一个离过期时间最远的证书。

---

### 自定义 `CertificateManager` 实现

上一小节提到，你可自行继承并实现一个 `CertificateManager`，例如利用数据库或 Redis 等方式存取证书信息。

下面给出一个利用 Redis 的 HASH 数据结构存储的示例代码：

```csharp
using StackExchange.Redis;

public class RedisCertificateManager : CertificateManager
{
    private const string REDIS_KEY_PREFIX = "wxpaypc-";

    private readonly ConnectionMultiplexer Connection { get; }

    public RedisCertificateManager(string connectionString)
    {
        Connection = ConnectionMultiplexer.Connect(connectionString);
    }

    private string GenerateRedisKey(string serialNumber)
    {
        return $"{REDIS_KEY_PREFIX}{serialNumber}";
    }

    private CertificateEntry ConvertHashEntriesToCertificateEntry(HashEntry[] values)
    {
        if (values == null) throw new ArgumentNullException(nameof(values));

        IDictionary<string, string> map = values.ToDictionary(k => k.Name.ToString(), v => v.Value.ToString());
        return new CertificateEntry(
            serialNumber: map[nameof(CertificateEntry.SerialNumber)],
            certificate: map[nameof(CertificateEntry.Certificate)],
            effectiveTime: DateTimeOffset.Parse(map[nameof(CertificateEntry.EffectiveTime)]),
            expireTime: DateTimeOffset.Parse(map[nameof(CertificateEntry.ExpireTime)])
        );
    }

    private HashEntry[] ConvertCertificateEntryToHashEntries(CertificateEntry entry)
    {
        return new HashEntry[]
        {
            new HashEntry(nameof(CertificateEntry.SerialNumber), entry.SerialNumber),
            new HashEntry(nameof(CertificateEntry.Certificate), entry.Certificate),
            new HashEntry(nameof(CertificateEntry.EffectiveTime), entry.EffectiveTime.ToString()),
            new HashEntry(nameof(CertificateEntry.ExpireTime), entry.ExpireTime.ToString())
        };
    }

    public override IEnumerable<CertificateEntry> AllEntries()
    {
        // 生产环境中不应该使用 Redis KEYS 命令，这里代码仅作参考
        // 你可以使用 SCAN + CURSOR 来实现类似功能
        RedisKey[] keys = Connection.GetServer().Keys($"{REDIS_KEY_PREFIX}*");
        if (keys.Any())
        {
            Task[] pipelineTasks = keys.Select(key => Connection.GetDatabase().HashGetAllAsync(key)).ToArray();
            Connection.WaitAll(pipelineTasks);

            return pipelineTasks
                .Where(t => t.IsCompletedSuccessfully && t.Result.Any())
                .Select(t => ConvertHashEntriesToCertificateEntry(t.Result))
                .ToArray();
        }

        return Array.Empty<CertificateEntry>();
    }

    public override void AddEntry(CertificateEntry entry)
    {
        string key = GenerateRedisKey(serialNumber);
        HashEntry[] values = ConvertCertificateEntryToHashEntries(entry);
        Connection.GetDatabase().HashSet(key, values);
        Connection.GetDatabase().KeyExpire(key, entry.ExpireTime - DateTimeOffset.Now);
    }

    public override CertificateEntry? GetEntry(string serialNumber)
    {
        string key = GenerateRedisKey(serialNumber);
        HashEntry[] values = Connection.GetDatabase().HashGetAll(key);
        if (values.Any())
        {
            return ConvertHashEntriesToCertificateEntry(values);
        }

        return null;
    }

    public override bool RemoveEntry(string serialNumber)
    {
        string key = GenerateRedisKey(serialNumber);
        return Connection.GetDatabase().KeyDelete(key);
    }
}
```