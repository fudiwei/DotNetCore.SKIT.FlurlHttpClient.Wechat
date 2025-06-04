namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Services.HttpClients
{
    public interface IWechatTenpayClientFactory
    {
        WechatTenpayClient Create(string merchantId);
    }
}
