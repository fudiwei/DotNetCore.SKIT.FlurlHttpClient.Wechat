namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Services.HttpClients
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings;

    public interface IWechatTenpayCertificateManagerFactory
    {
        CertificateManager Create(string merchantId);
    }
}
