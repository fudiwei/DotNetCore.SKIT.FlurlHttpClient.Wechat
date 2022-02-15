﻿namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /transfer/batches/batch-id/{batch_id}/details/detail-id/{detail_id} 接口的请求。</para>
    /// </summary>
    public class GetTransferBatchDetailByDetailIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BatchId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信明细单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string DetailId { get; set; } = string.Empty;
    }
}
