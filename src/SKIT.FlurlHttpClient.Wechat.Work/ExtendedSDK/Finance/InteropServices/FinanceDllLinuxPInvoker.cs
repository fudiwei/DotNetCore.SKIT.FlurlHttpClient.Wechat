using System;
using System.Runtime.InteropServices;

namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.Finance.InteropServices
{
    internal static partial class FinanceDllLinuxPInvoker
    {
        private const string DLL_NAME = "libWeWorkFinanceSdk_C.so";

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr NewSdk();

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Init([In] IntPtr sdk, [In] string corpId, [In] string secret);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetChatData([In] IntPtr sdk, [In] ulong seq, [In] long limit, [In] string proxy, [In] string passwd, [In] long timeout, [Out] IntPtr chatData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetMediaData([In] IntPtr sdk, [In] string indexBuf, [In] string fileId, [In] string proxy, [In] string passwd, [In] long timeout, [Out] IntPtr mediaData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int DecryptData([In] string encryptKey, [In] string encryptMsg, [Out] IntPtr msgData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DestroySdk([In] IntPtr sdk);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr NewSlice();

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern void FreeSlice([In] IntPtr slice);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetContentFromSlice([In] IntPtr slice);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetSliceLen([In] IntPtr slice);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr NewMediaData();

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern void FreeMediaData([In] IntPtr mediaData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetOutIndexBuf([In] IntPtr mediaData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetData([In] IntPtr mediaData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetIndexLen([In] IntPtr mediaData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetDataLen([In] IntPtr mediaData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int IsMediaDataFinish([In] IntPtr mediaData);
    }
}
