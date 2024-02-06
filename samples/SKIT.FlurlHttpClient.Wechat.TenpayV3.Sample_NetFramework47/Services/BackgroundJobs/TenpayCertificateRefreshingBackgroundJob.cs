namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Services.BackgroundJobs
{
    internal class TenpayCertificateRefreshingBackgroundJob
    {
        private readonly HttpClients.IWechatTenpayClientFactory _wechatTenpayClientFactory;

        public TenpayCertificateRefreshingBackgroundJob(
            HttpClients.IWechatTenpayClientFactory wechatTenpayClientFactory)
        {
            _wechatTenpayClientFactory = wechatTenpayClientFactory;
        }

        public async Task ExecuteAsync()
        {
            foreach (var tenpayMerchantOptions in Options.TenpayOptions.Instance.Value.Merchants)
            {
                try
                {
                    const string ALGORITHM_TYPE = "RSA";
                    using var client = _wechatTenpayClientFactory.Create(tenpayMerchantOptions.MerchantId);
                    var request = new QueryCertificatesRequest() { AlgorithmType = ALGORITHM_TYPE };
                    var response = await client.ExecuteQueryCertificatesAsync(request);
                    if (response.IsSuccessful())
                    {
                        // NOTICE:
                        //   如果构造 Client 时启用了 `AutoDecryptResponseSensitiveProperty` 配置项，则无需再执行下面一行的手动解密方法：
                        response = client.DecryptResponseSensitiveProperty(response);

                        foreach (var certificate in response.CertificateList)
                        {
                            client.CertificateManager.AddEntry(CertificateEntry.Parse(ALGORITHM_TYPE, certificate));
                        }

                        Debug.WriteLine("刷新微信商户平台证书成功。");
                    }
                    else
                    {
                        Debug.WriteLine(
                            "刷新微信商户平台证书失败（状态码：{0}，错误代码：{1}，错误描述：{2}）。",
                            response.GetRawStatus(), response.ErrorCode, response.ErrorMessage
                        );
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("刷新微信商户平台证书遇到异常。\r\n{0}", ex);
                }
            }
        }
    }
}
