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
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static TResponse DecryptResponseEncryptedData<TResponse>(this WechatTenpayClient client, TResponse response)
            where TResponse : WechatTenpayResponse
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));

            if (string.IsNullOrEmpty(client.MerchantCertPrivateKey))
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of there is no merchant private key.");

            if (!response.IsSuccessful())
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because of the response is not successful.");

            if (response is Models.GetEcommerceApplymentByOutRequestNumberResponse resGetEcommerceApplymentByOutRequestNumber)
            {
                DecryptResponse(resGetEcommerceApplymentByOutRequestNumber, client.MerchantCertPrivateKey);
                return (resGetEcommerceApplymentByOutRequestNumber as TResponse)!;
            }
            else if (response is Models.GetEcommerceBillFundflowBillResponse resGetEcommerceBillFundflowBill)
            {
                DecryptResponse(resGetEcommerceBillFundflowBill, client.MerchantCertPrivateKey);
                return (resGetEcommerceBillFundflowBill as TResponse)!;
            }
            else if (response is Models.GetMerchantServiceComplaintByComplaintIdResponse resGetMerchantServiceComplaintByComplaintId)
            {
                DecryptResponse(resGetMerchantServiceComplaintByComplaintId, client.MerchantCertPrivateKey);
                return (resGetMerchantServiceComplaintByComplaintId as TResponse)!;
            }
            else if (response is Models.QueryCertificatesResponse resQueryCertificates)
            {
                DecryptResponse(resQueryCertificates, client.MerchantV3Secret);
                return (resQueryCertificates as TResponse)!;
            }
            else if (response is Models.QueryMerchantServiceComplaintsResponse resQueryMerchantServiceComplaints)
            {
                DecryptResponse(resQueryMerchantServiceComplaints, client.MerchantCertPrivateKey);
                return (resQueryMerchantServiceComplaints as TResponse)!;
            }
            else if (response is Models.QuerySmartGuidesResponse resQuerySmartGuides)
            {
                DecryptResponse(resQuerySmartGuides, client.MerchantCertPrivateKey);
                return (resQuerySmartGuides as TResponse)!;
            }

            return response;
        }

        private static void DecryptResponse(Models.GetEcommerceApplymentByOutRequestNumberResponse response, string privateKey)
        {
            if (response.AccountValidation != null)
            {
                IList<Exception> exceptions = new List<Exception>();

                var accountValidationModel = response.AccountValidation;

                if (!string.IsNullOrEmpty(accountValidationModel.AccountNameEncryptedData))
                {
                    try
                    {
                        accountValidationModel.AccountNameEncryptedData = Utilities.RsaUtil.DecryptWithECB(
                            privateKey, 
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
                        accountValidationModel.AccountNumberEncryptedData = Utilities.RsaUtil.DecryptWithECB(
                            privateKey,
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
        }

        private static void DecryptResponse(Models.GetEcommerceBillFundflowBillResponse response, string privateKey)
        {
            if (response.DownloadBillList != null)
            {
                IList<Exception> exceptions = new List<Exception>();

                foreach (var downloadBillModel in response.DownloadBillList)
                {
                    if (!string.IsNullOrEmpty(downloadBillModel.EncryptKeyEncryptedData))
                    {
                        try
                        {
                            downloadBillModel.EncryptKeyEncryptedData = Utilities.RsaUtil.DecryptWithECB(
                                privateKey,
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
        }

        private static void DecryptResponse(Models.GetMerchantServiceComplaintByComplaintIdResponse response, string privateKey)
        {
            if (response.ComplaintDetail != null)
            {
                if (!string.IsNullOrEmpty(response.PayerPhoneEncryptedData))
                {
                    try
                    {
                        response.PayerPhoneEncryptedData = Utilities.RsaUtil.DecryptWithECB(
                            privateKey,
                            response.PayerPhoneEncryptedData!
                        );
                    }
                    catch (Exception ex)
                    {
                        throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed.", ex);
                    }
                }
            }
        }

        private static void DecryptResponse(Models.QueryCertificatesResponse response, string aesKey)
        {
            if (response.CertificateList != null)
            {
                IList<Exception> exceptions = new List<Exception>();

                foreach (var certificateModel in response.CertificateList)
                {
                    if (Constants.EncryptionAlgorithms.AEAD_AES_256_GCM.Equals(certificateModel.EncryptCertificate?.Algorithm))
                    {
                        try
                        {
                            certificateModel.EncryptCertificate.CipherText = Utilities.AesUtil.DecryptWithGCM(
                                aesKey: aesKey,
                                nonce: certificateModel.EncryptCertificate.Nonce,
                                associatedData: certificateModel.EncryptCertificate.AssociatedData,
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
        }

        private static void DecryptResponse(Models.QueryMerchantServiceComplaintsResponse response, string privateKey)
        {
            if (response.ComplaintList != null)
            {
                IList<Exception> exceptions = new List<Exception>();

                foreach (var complaintModel in response.ComplaintList)
                {
                    if (!string.IsNullOrEmpty(complaintModel.PayerPhoneEncryptedData))
                    {
                        try
                        {
                            complaintModel.PayerPhoneEncryptedData = Utilities.RsaUtil.DecryptWithECB(
                                privateKey,
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
        }

        private static void DecryptResponse(Models.QuerySmartGuidesResponse response, string privateKey)
        {
            if (response.GuideList != null)
            {
                IList<Exception> exceptions = new List<Exception>();

                foreach (var guideModel in response.GuideList)
                {
                    if (!string.IsNullOrEmpty(guideModel.UserNameEncryptedData))
                    {
                        try
                        {
                            guideModel.UserNameEncryptedData = Utilities.RsaUtil.DecryptWithECB(
                                privateKey,
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
                            guideModel.UserMobileEncryptedData = Utilities.RsaUtil.DecryptWithECB(
                                privateKey,
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
        }
    }
}
