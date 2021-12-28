namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Services.HttpClients
{
    public interface IWechatTenpayHttpClientFactory
    {
        WechatTenpayClient Create(string merchantId);
    }
}
