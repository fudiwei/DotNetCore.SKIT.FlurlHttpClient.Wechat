using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.Api.Utilities
{
    /*
     * @Auhtor: Sheldon_XT
     * @Count: <EMAIL>
     * @Country: China
     * @Date: 2021-08-11
     */

    /// <summary>
    /// 检验工具类
    /// </summary>
    public static class VerifyUtility
    {
        /// <summary>
        /// 校验签名
        /// </summary>
        /// <param name="sToken"></param>
        /// <param name="sTimeStamp"></param>
        /// <param name="sNonce"></param>
        /// <param name="sSigture"></param>
        /// <param name="sMsgEncrypt"></param>
        /// <returns>0 成功 -40003  sha加密生成签名失败 -40001 sha加密生成签名失败</returns>
        private static int VerifySignature(string sToken, string sTimeStamp, string sNonce, string sSigture, string sMsgEncrypt = "")
        {
            string hash = "";
            int ret = GenarateSinature(sToken, sTimeStamp, sNonce, ref hash, sMsgEncrypt);
            if (ret != 0)
                return ret;
            if (hash == sSigture)
                return 0;
            else
            {
                return -40001;
            }
        }
        /// <summary>
        /// 生成签名
        /// </summary>
        /// <param name="sToken"></param>
        /// <param name="sTimeStamp"></param>
        /// <param name="sNonce"></param>
        /// <param name="sMsgSignature"></param>
        /// <param name="sMsgEncrypt"></param>
        /// <returns>-40003 sha加密生成签名失败</returns>
        public static int GenarateSinature(string sToken, string sTimeStamp, string sNonce, ref string sMsgSignature, string sMsgEncrypt = "")
        {
            List<string> list = new List<string>
            {
                sToken,sTimeStamp,sNonce,sMsgEncrypt
            };
            list.Sort();
            string raw = string.Join("", list);
            SHA1 sha;
            ASCIIEncoding enc;
            string hash;
            try
            {
                sha = new SHA1CryptoServiceProvider();
                enc = new ASCIIEncoding();
                byte[] dataToHash = enc.GetBytes(raw);
                byte[] dataHashed = sha.ComputeHash(dataToHash);
                hash = BitConverter.ToString(dataHashed).Replace("-", "");
                hash = hash.ToLower();
            }
            catch (Exception)
            {
                return -40003;
            }
            sMsgSignature = hash;
            return 0;
        }
    }
}
