namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Services.BackgroundJobs
{
    internal class TenpayCertificateRefreshingBackgroundJob
    {
        private readonly HttpClients.IWechatTenpayHttpClientFactory _tenpayHttpClientFactory;

        public TenpayCertificateRefreshingBackgroundJob(
            HttpClients.IWechatTenpayHttpClientFactory tenpayHttpClientFactory)
        {
            _tenpayHttpClientFactory = tenpayHttpClientFactory;
        }

        public async Task ExecuteAsync()
        {
            foreach (var tenpayMerchantOptions in Options.TenpayOptions.Instance.Value.Merchants)
            {
                try
                {
                    var client = _tenpayHttpClientFactory.Create(tenpayMerchantOptions.MerchantId);
                    var request = new QueryCertificatesRequest();
                    var response = await client.ExecuteQueryCertificatesAsync(request);
                    if (response.IsSuccessful())
                    {
                        // NOTICE:
                        //   如果启用了 `AutoDecryptResponseSensitiveProperty` 配置项，则无需再手动执行下面被注释的解密方法：
                        //   response = client.DecryptResponseSensitiveProperty(response);

                        foreach (var certificateModel in response.CertificateList)
                        {
                            client.CertificateManager.AddEntry(new CertificateEntry(certificateModel));
                        }

                        Debug.WriteLine("刷新微信商户平台证书成功。");
                    }
                    else
                    {
                        Debug.WriteLine(
                            "刷新微信商户平台证书失败（状态码：{0}，错误代码：{1}，错误描述：{2}）。",
                            response.RawStatus, response.ErrorCode, response.ErrorMessage
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
