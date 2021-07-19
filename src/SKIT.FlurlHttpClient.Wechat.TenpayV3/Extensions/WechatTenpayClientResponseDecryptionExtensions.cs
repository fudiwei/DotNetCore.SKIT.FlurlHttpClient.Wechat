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
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static Models.GetEcommerceApplymentByOutRequestNumberResponse DecryptResponseEncryptedData(this WechatTenpayClient client, ref Models.GetEcommerceApplymentByOutRequestNumberResponse response)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));

            if (string.IsNullOrEmpty(client.WechatMerchantCertPrivateKey))
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of there is no merchant private key.");

            if (!response.IsSuccessful())
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of the response is not successful.");

            if (response.AccountValidation != null)
            {
                IList<Exception> exceptions = new List<Exception>();

                var accountValidationModel = response.AccountValidation;

                if (!string.IsNullOrEmpty(accountValidationModel.AccountName))
                {
                    try
                    {
                        accountValidationModel.AccountName = Utilities.RSAUtility.DecryptWithECB(
                            client.WechatMerchantCertPrivateKey, 
                            accountValidationModel.AccountName
                        );
                    }
                    catch (Exception ex)
                    {
                        exceptions.Add(ex);
                    }
                }

                if (!string.IsNullOrEmpty(accountValidationModel.AccountNumber))
                {
                    try
                    {
                        accountValidationModel.AccountNumber = Utilities.RSAUtility.DecryptWithECB(
                            client.WechatMerchantCertPrivateKey,
                            accountValidationModel.AccountNumber!
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
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static Models.GetEcommerceBillFundflowBillResponse DecryptResponseEncryptedData(this WechatTenpayClient client, ref Models.GetEcommerceBillFundflowBillResponse response)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));

            if (string.IsNullOrEmpty(client.WechatMerchantCertPrivateKey))
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of there is no merchant private key.");

            if (!response.IsSuccessful())
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of the response is not successful.");

            if (response.DownloadBillList != null)
            {
                IList<Exception> exceptions = new List<Exception>();

                foreach (var downloadBillModel in response.DownloadBillList)
                {
                    if (!string.IsNullOrEmpty(downloadBillModel.EncryptKey))
                    {
                        try
                        {
                            downloadBillModel.EncryptKey = Utilities.RSAUtility.DecryptWithECB(
                                client.WechatMerchantCertPrivateKey,
                                downloadBillModel.EncryptKey
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
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static Models.GetMerchantServiceComplaintByComplaintIdResponse DecryptResponseEncryptedData(this WechatTenpayClient client, ref Models.GetMerchantServiceComplaintByComplaintIdResponse response)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));

            if (string.IsNullOrEmpty(client.WechatMerchantCertPrivateKey))
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of there is no merchant private key.");

            if (!response.IsSuccessful())
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of the response is not successful.");

            if (response.ComplaintDetail != null)
            {
                if (!string.IsNullOrEmpty(response.PayerPhone))
                {
                    try
                    {
                        response.PayerPhone = Utilities.RSAUtility.DecryptWithECB(
                            client.WechatMerchantCertPrivateKey,
                            response.PayerPhone!
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
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static Models.QueryCertificatesResponse DecryptResponseEncryptedData(this WechatTenpayClient client, ref Models.QueryCertificatesResponse response)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));

            if (string.IsNullOrEmpty(client.WechatMerchantV3Secret))
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
                                key: client.WechatMerchantV3Secret,
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
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static Models.QueryMerchantServiceComplaintsResponse DecryptResponseEncryptedData(this WechatTenpayClient client, ref Models.QueryMerchantServiceComplaintsResponse response)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));

            if (string.IsNullOrEmpty(client.WechatMerchantCertPrivateKey))
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of there is no merchant private key.");

            if (!response.IsSuccessful())
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of the response is not successful.");

            if (response.ComplaintList != null)
            {
                IList<Exception> exceptions = new List<Exception>();

                foreach (var complaintModel in response.ComplaintList)
                {
                    if (!string.IsNullOrEmpty(complaintModel.PayerPhone))
                    {
                        try
                        {
                            complaintModel.PayerPhone = Utilities.RSAUtility.DecryptWithECB(
                                client.WechatMerchantCertPrivateKey,
                                complaintModel.PayerPhone!
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
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static Models.QuerySmartGuidesResponse DecryptResponseEncryptedData(this WechatTenpayClient client, ref Models.QuerySmartGuidesResponse response)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));

            if (string.IsNullOrEmpty(client.WechatMerchantCertPrivateKey))
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of there is no merchant private key.");

            if (!response.IsSuccessful())
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of the response is not successful.");

            if (response.GuideList != null)
            {
                IList<Exception> exceptions = new List<Exception>();

                foreach (var guideModel in response.GuideList)
                {
                    if (!string.IsNullOrEmpty(guideModel.UserName))
                    {
                        try
                        {
                            guideModel.UserName = Utilities.RSAUtility.DecryptWithECB(
                                client.WechatMerchantCertPrivateKey,
                                guideModel.UserName
                            );
                        }
                        catch (Exception ex)
                        {
                            exceptions.Add(ex);
                        }
                    }

                    if (!string.IsNullOrEmpty(guideModel.UserMobile))
                    {
                        try
                        {
                            guideModel.UserMobile = Utilities.RSAUtility.DecryptWithECB(
                                client.WechatMerchantCertPrivateKey,
                                guideModel.UserMobile
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
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static Models.GetTransferBatchDetailByOutDetailNumberResponse DecryptResponseEncryptedData(this WechatTenpayClient client, ref Models.GetTransferBatchDetailByOutDetailNumberResponse response)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));

            if (string.IsNullOrEmpty(client.WechatMerchantCertPrivateKey))
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of there is no merchant private key.");

            if (!response.IsSuccessful())
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of the response is not successful.");

            if (!string.IsNullOrEmpty(response.UserName))
            {
                try
                {
                    response.UserName = Utilities.RSAUtility.DecryptWithECB(
                        client.WechatMerchantCertPrivateKey,
                        response.UserName
                    );
                }
                catch (Exception ex)
                {
                    throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed.", ex);
                }
            }

            return response;
        }

        /// <summary>
        /// <para>解密响应中返回的敏感数据。该方法会改变传入的响应信息。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static Models.GetTransferBatchDetailByDetailIdResponse DecryptResponseEncryptedData(this WechatTenpayClient client, ref Models.GetTransferBatchDetailByDetailIdResponse response)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));

            if (string.IsNullOrEmpty(client.WechatMerchantCertPrivateKey))
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of there is no merchant private key.");

            if (!response.IsSuccessful())
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of the response is not successful.");

            if (!string.IsNullOrEmpty(response.UserName))
            {
                try
                {
                    response.UserName = Utilities.RSAUtility.DecryptWithECB(
                        client.WechatMerchantCertPrivateKey,
                        response.UserName
                    );
                }
                catch (Exception ex)
                {
                    throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed.", ex);
                }
            }

            return response;
        }
    }
}
