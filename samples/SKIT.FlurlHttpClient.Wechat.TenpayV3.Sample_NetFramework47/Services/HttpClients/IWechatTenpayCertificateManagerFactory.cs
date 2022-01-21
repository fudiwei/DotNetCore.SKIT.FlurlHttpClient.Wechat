namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Services.HttpClients
{
    public interface IWechatTenpayCertificateManagerFactory
    {
        CertificateManager Create(string merchantId);
    }
}
