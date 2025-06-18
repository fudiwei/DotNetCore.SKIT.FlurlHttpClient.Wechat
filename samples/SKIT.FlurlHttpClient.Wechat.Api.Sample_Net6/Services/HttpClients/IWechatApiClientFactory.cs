namespace SKIT.FlurlHttpClient.Wechat.Api.Sample.Services.HttpClients
{
    public interface IWechatApiClientFactory
    {
        WechatApiClient Create(string appId);
    }
}
