namespace SKIT.FlurlHttpClient.Wechat.Api.Sample.Services.HttpClients
{
    public interface IWechatApiHttpClientFactory
    {
        WechatApiClient Create(string appId);
    }
}
