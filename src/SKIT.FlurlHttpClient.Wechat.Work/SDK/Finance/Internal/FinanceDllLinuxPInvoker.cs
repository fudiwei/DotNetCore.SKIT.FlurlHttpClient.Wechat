using System;
using System.Runtime.InteropServices;

namespace SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance
{
    internal static partial class FinanceDllLinuxPInvoker
    {
        private const string DLL_NAME = "libWeWorkFinanceSdk_C.so";

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr NewSdk();

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Init(IntPtr sdk, string corpId, string secret);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetChatData(IntPtr sdk, long seq, long limit, string proxy, string passwd, long timeout, IntPtr chatData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetMediaData(IntPtr sdk, string indexbuf, string sdkField, string proxy, string passwd, long timeout, IntPtr mediaData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int DecryptData(string encryptKey, string encryptMsg, string msg);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DestroySdk(IntPtr sdk);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr NewSlice();

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern void FreeSlice(IntPtr slice);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern string GetContentFromSlice(IntPtr slice);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetSliceLen(IntPtr slice);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr NewMediaData();

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern void FreeMediaData(IntPtr mediaData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern string GetOutIndexBuf(IntPtr mediaData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetData(IntPtr mediaData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetIndexLen(IntPtr mediaData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetDataLen(IntPtr mediaData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int IsMediaDataFinish(IntPtr mediaData);
    }
}
