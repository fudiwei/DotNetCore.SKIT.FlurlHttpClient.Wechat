using System;
using System.Runtime.InteropServices;
using System.Security;

namespace SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance.InteropServices
{
    internal static partial class FinanceDllWindowsPInvoker
    {
        private const string DLL_NAME = "WeWorkFinanceSdk.dll";

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        [SuppressUnmanagedCodeSecurity]
        public static extern IntPtr NewSdk();

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int Init(IntPtr sdk, string corpId, string secret);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int GetChatData(IntPtr sdk, long seq, long limit, string proxy, string passwd, long timeout, IntPtr chatData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int GetMediaData(IntPtr sdk, string indexBuf, string fileId, string proxy, string passwd, long timeout, IntPtr mediaData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int DecryptData(string encryptKey, string encryptMsg, IntPtr msgData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void DestroySdk(IntPtr sdk);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        [SuppressUnmanagedCodeSecurity]
        public static extern IntPtr NewSlice();

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void FreeSlice(IntPtr slice);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        [SuppressUnmanagedCodeSecurity]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
        public static extern string GetContentFromSlice(IntPtr slice);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int GetSliceLen(IntPtr slice);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        [SuppressUnmanagedCodeSecurity]
        public static extern IntPtr NewMediaData();

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void FreeMediaData(IntPtr mediaData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        [SuppressUnmanagedCodeSecurity]
        public static extern string GetOutIndexBuf(IntPtr mediaData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        [SuppressUnmanagedCodeSecurity]
        public static extern IntPtr GetData(IntPtr mediaData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int GetIndexLen(IntPtr mediaData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int GetDataLen(IntPtr mediaData);

        [DllImport(DLL_NAME, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int IsMediaDataFinish(IntPtr mediaData);
    }
}
