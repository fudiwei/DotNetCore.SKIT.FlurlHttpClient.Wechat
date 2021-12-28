namespace SKIT.FlurlHttpClient.Wechat.Api.Sample.Models
{
    public class WechatAccessTokenEntity
    {
        public string AppId { get; set; } = string.Empty;

        public string AccessToken { get; set; } = string.Empty;

        public long ExpireTimestamp { get; set; }

        public long UpdateTimestamp { get; set; }

        public long CreateTimestamp { get; set; }
    }
}
