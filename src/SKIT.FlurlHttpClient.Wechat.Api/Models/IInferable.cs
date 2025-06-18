namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    public interface IInferable<TRequest, TResponse>
        where TRequest : WechatApiRequest
        where TResponse : WechatApiResponse
    {
    }
}
