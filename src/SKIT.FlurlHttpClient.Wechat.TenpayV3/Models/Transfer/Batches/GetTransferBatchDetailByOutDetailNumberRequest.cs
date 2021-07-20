using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /transfer/batches/out-batch-no/{out_batch_no}/details/out-detail-no/{out_detail_no} 接口的请求。</para>
    /// </summary>
    public class GetTransferBatchDetailByOutDetailNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商户批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutBatchNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户明细单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutDetailNumber { get; set; } = string.Empty;
    }
}
