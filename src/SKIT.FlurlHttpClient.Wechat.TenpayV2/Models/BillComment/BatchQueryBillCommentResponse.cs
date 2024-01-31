using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /billcommentsp/batchquerycomment 接口的响应。</para>
    /// </summary>
    public class BatchQueryBillCommentResponse : WechatTenpayResponse
    {
        /// <summary>
        /// <i>（冗余字段，请忽略）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <i>（冗余字段，请忽略）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && GetRawBytes().Any();
        }
    }
}
