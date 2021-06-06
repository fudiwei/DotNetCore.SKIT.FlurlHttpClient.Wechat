using System;
using System.Collections.Generic;
using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供响应敏感数据解密的扩展方法。
    /// </summary>
    public static class WechatTenpayClientResponseDecryptionExtensions
    {
        /// <summary>
        /// <para>解密响应中返回的敏感数据。该方法会改变传入的响应信息。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay4_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static Models.GetEcommerceApplymentByOutRequestNumberResponse DecryptResponseEncryptedData(this WechatTenpayClient client, Models.GetEcommerceApplymentByOutRequestNumberResponse response)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));

            if (string.IsNullOrEmpty(client.MerchantCertPrivateKey))
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of there is no merchant private key.");

            if (!response.IsSuccessful())
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of the response is not successful.");

            if (response.AccountValidation != null)
            {
                IList<Exception> exceptions = new List<Exception>();

                var accountValidationModel = response.AccountValidation;

                if (!string.IsNullOrEmpty(accountValidationModel.AccountNameEncryptedData))
                {
                    try
                    {
                        accountValidationModel.AccountNameEncryptedData = Utilities.RSAUtility.DecryptWithECB(
                            client.MerchantCertPrivateKey, 
                            accountValidationModel.AccountNameEncryptedData
                        );
                    }
                    catch (Exception ex)
                    {
                        exceptions.Add(ex);
                    }
                }

                if (!string.IsNullOrEmpty(accountValidationModel.AccountNumberEncryptedData))
                {
                    try
                    {
                        accountValidationModel.AccountNumberEncryptedData = Utilities.RSAUtility.DecryptWithECB(
                            client.MerchantCertPrivateKey,
                            accountValidationModel.AccountNumberEncryptedData!
                        );
                    }
                    catch (Exception ex)
                    {
                        exceptions.Add(ex);
                    }
                }

                if (exceptions.Any())
                    throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed.", new AggregateException(exceptions));
            }

            return response;
        }

        /// <summary>
        /// <para>解密响应中返回的敏感数据。该方法会改变传入的响应信息。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay4_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static Models.GetEcommerceBillFundflowBillResponse DecryptResponseEncryptedData(this WechatTenpayClient client, Models.GetEcommerceBillFundflowBillResponse response)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));

            if (string.IsNullOrEmpty(client.MerchantCertPrivateKey))
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of there is no merchant private key.");

            if (!response.IsSuccessful())
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of the response is not successful.");

            if (response.DownloadBillList != null)
            {
                IList<Exception> exceptions = new List<Exception>();

                foreach (var downloadBillModel in response.DownloadBillList)
                {
                    if (!string.IsNullOrEmpty(downloadBillModel.EncryptKeyEncryptedData))
                    {
                        try
                        {
                            downloadBillModel.EncryptKeyEncryptedData = Utilities.RSAUtility.DecryptWithECB(
                                client.MerchantCertPrivateKey,
                                downloadBillModel.EncryptKeyEncryptedData
                            );
                        }
                        catch (Exception ex)
                        {
                            exceptions.Add(ex);
                        }
                    }
                }

                if (exceptions.Any())
                    throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed.", new AggregateException(exceptions));
            }

            return response;
        }

        /// <summary>
        /// <para>解密响应中返回的敏感数据。该方法会改变传入的响应信息。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay4_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static Models.GetMerchantServiceComplaintByComplaintIdResponse DecryptResponseEncryptedData(this WechatTenpayClient client, Models.GetMerchantServiceComplaintByComplaintIdResponse response)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));

            if (string.IsNullOrEmpty(client.MerchantCertPrivateKey))
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of there is no merchant private key.");

            if (!response.IsSuccessful())
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of the response is not successful.");

            if (response.ComplaintDetail != null)
            {
                if (!string.IsNullOrEmpty(response.PayerPhoneEncryptedData))
                {
                    try
                    {
                        response.PayerPhoneEncryptedData = Utilities.RSAUtility.DecryptWithECB(
                            client.MerchantCertPrivateKey,
                            response.PayerPhoneEncryptedData!
                        );
                    }
                    catch (Exception ex)
                    {
                        throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed.", ex);
                    }
                }
            }

            return response;
        }

        /// <summary>
        /// <para>解密响应中返回的敏感数据。该方法会改变传入的响应信息。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay4_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static Models.QueryCertificatesResponse DecryptResponseEncryptedData(this WechatTenpayClient client, Models.QueryCertificatesResponse response)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));

            if (string.IsNullOrEmpty(client.MerchantV3Secret))
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of there is no merchant secret.");

            if (!response.IsSuccessful())
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of the response is not successful.");

            if (response.CertificateList != null)
            {
                IList<Exception> exceptions = new List<Exception>();

                foreach (var certificateModel in response.CertificateList)
                {
                    if (Constants.EncryptionAlgorithms.AEAD_AES_256_GCM.Equals(certificateModel.EncryptCertificate?.Algorithm))
                    {
                        try
                        {
                            certificateModel.EncryptCertificate.CipherText = Utilities.AESUtility.DecryptWithGCM(
                                key: client.MerchantV3Secret,
                                iv: certificateModel.EncryptCertificate.Nonce,
                                aad: certificateModel.EncryptCertificate.AssociatedData,
                                cipherText: certificateModel.EncryptCertificate.CipherText
                            );
                        }
                        catch (Exception ex)
                        {
                            exceptions.Add(ex);
                        }
                    }
                    else
                    {
                        exceptions.Add(new Exception("Unknown encrypt algorithm of the certificate."));
                    }
                }

                if (exceptions.Any())
                    throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed.", new AggregateException(exceptions));
            }

            return response;
        }

        /// <summary>
        /// <para>解密响应中返回的敏感数据。该方法会改变传入的响应信息。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay4_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static Models.QueryMerchantServiceComplaintsResponse DecryptResponseEncryptedData(this WechatTenpayClient client, Models.QueryMerchantServiceComplaintsResponse response)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));

            if (string.IsNullOrEmpty(client.MerchantCertPrivateKey))
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of there is no merchant private key.");

            if (!response.IsSuccessful())
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of the response is not successful.");

            if (response.ComplaintList != null)
            {
                IList<Exception> exceptions = new List<Exception>();

                foreach (var complaintModel in response.ComplaintList)
                {
                    if (!string.IsNullOrEmpty(complaintModel.PayerPhoneEncryptedData))
                    {
                        try
                        {
                            complaintModel.PayerPhoneEncryptedData = Utilities.RSAUtility.DecryptWithECB(
                                client.MerchantCertPrivateKey,
                                complaintModel.PayerPhoneEncryptedData!
                            );
                        }
                        catch (Exception ex)
                        {
                            exceptions.Add(ex);
                        }
                    }
                }

                if (exceptions.Any())
                    throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed.", new AggregateException(exceptions));
            }

            return response;
        }

        /// <summary>
        /// <para>解密响应中返回的敏感数据。该方法会改变传入的响应信息。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay4_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static Models.QuerySmartGuidesResponse DecryptResponseEncryptedData(this WechatTenpayClient client, Models.QuerySmartGuidesResponse response)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));

            if (string.IsNullOrEmpty(client.MerchantCertPrivateKey))
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of there is no merchant private key.");

            if (!response.IsSuccessful())
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of the response is not successful.");

            if (response.GuideList != null)
            {
                IList<Exception> exceptions = new List<Exception>();

                foreach (var guideModel in response.GuideList)
                {
                    if (!string.IsNullOrEmpty(guideModel.UserNameEncryptedData))
                    {
                        try
                        {
                            guideModel.UserNameEncryptedData = Utilities.RSAUtility.DecryptWithECB(
                                client.MerchantCertPrivateKey,
                                guideModel.UserNameEncryptedData
                            );
                        }
                        catch (Exception ex)
                        {
                            exceptions.Add(ex);
                        }
                    }

                    if (!string.IsNullOrEmpty(guideModel.UserMobileEncryptedData))
                    {
                        try
                        {
                            guideModel.UserMobileEncryptedData = Utilities.RSAUtility.DecryptWithECB(
                                client.MerchantCertPrivateKey,
                                guideModel.UserMobileEncryptedData
                            );
                        }
                        catch (Exception ex)
                        {
                            exceptions.Add(ex);
                        }
                    }
                }

                if (exceptions.Any())
                    throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed.", new AggregateException(exceptions));
            }

            return response;
        }
    }
}
