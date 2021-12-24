namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample_Net5.Services.HttpClients
{
    public interface IWechatTenpayHttpClientFactory
    {
        WechatTenpayClient Create(string merchantId);
    }
}
