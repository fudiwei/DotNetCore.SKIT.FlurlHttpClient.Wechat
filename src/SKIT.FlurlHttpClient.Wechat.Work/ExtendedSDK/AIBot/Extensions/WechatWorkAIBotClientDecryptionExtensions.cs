namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot
{
    public static class WechatWorkAIBotClientDecryptionExtensions
    {
        /// <summary>
        /// <para>解密文件。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="fileBytes"></param>
        /// <returns></returns>
        public static byte[] DecryptFile(this WechatWorkAIBotClient client, byte[] fileBytes)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (fileBytes is null) throw new ArgumentNullException(nameof(fileBytes));

            try
            {
                if (string.IsNullOrEmpty(client.Credentials.PushEncodingAESKey))
                    throw new WechatWorkAIBotException("Failed to decrypt file data, because the push encoding AES key is empty.");

                string key = client.Credentials.PushEncodingAESKey!;
                key = key.PadRight(key.Length + (4 - key.Length % 4), '=');

                byte[] keyBytes = Convert.FromBase64String(key);
                byte[] ivBytes = new byte[16];
                Array.Copy(keyBytes, ivBytes, 16);

                return Utilities.AESUtility.DecryptWithCBC(keyBytes, ivBytes, fileBytes);
            }
            catch (WechatWorkAIBotException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new WechatWorkAIBotException("Failed to decrypt file data.", ex);
            }
        }
    }
}
