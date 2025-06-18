namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/giftcard/page/update 接口的请求。</para>
    /// </summary>
    public class CardGiftCardPageUpdateRequest : WechatApiRequest, IInferable<CardGiftCardPageUpdateRequest, CardGiftCardPageUpdateResponse>
    {
        public static class Types
        {
            public class Page : CardGiftCardPageAddRequest.Types.Page
            {
                /// <summary>
                /// 获取或设置货架 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_id")]
                [System.Text.Json.Serialization.JsonPropertyName("page_id")]
                public string PageId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置货架信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public Types.Page Page { get; set; } = new Types.Page();
    }
}
