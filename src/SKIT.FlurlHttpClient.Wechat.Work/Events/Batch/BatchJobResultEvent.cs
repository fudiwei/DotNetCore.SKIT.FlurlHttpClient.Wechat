﻿namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.batch_job_result 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90973 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90240 </para>
    /// <para>REF; https://developer.work.weixin.qq.com/document/path/94946 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/91135 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90376 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/91167 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90858 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/95797 </para>
    /// </summary>
    public class BatchJobResultEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class BatchJob
            {
                /// <summary>
                /// 获取或设置任务 ID。
                /// </summary>
                [System.Xml.Serialization.XmlElement("JobId")]
                public string JobId { get; set; } = default!;

                /// <summary>
                /// 获取或设置任务类型。
                /// </summary>
                [System.Xml.Serialization.XmlElement("JobType")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [System.Xml.Serialization.XmlElement("ErrCode")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误信息。
                /// </summary>
                [System.Xml.Serialization.XmlElement("ErrMsg", IsNullable = true)]
                public string? ErrorMessage { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置异步任务信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("BatchJob")]
        public Types.BatchJob BatchJob { get; set; } = default!;
    }
}
