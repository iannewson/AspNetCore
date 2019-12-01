// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.HttpSys.Internal
{
    internal static partial class Constants
    {
        internal const string Chunked = "chunked";
        internal const string Close = "close";
        internal const string DefaultServerAddress = "http://localhost:5000";
        internal const string HttpScheme = "http";
        internal const string HttpsScheme = "https";
        internal const string SchemeDelimiter = "://";
        internal static System.Version V1_0;
        internal static System.Version V1_1;
        internal static System.Version V2;
        internal const string Zero = "0";
    }
    internal enum HttpSysRequestHeader
    {
        CacheControl = 0,
        Connection = 1,
        Date = 2,
        KeepAlive = 3,
        Pragma = 4,
        Trailer = 5,
        TransferEncoding = 6,
        Upgrade = 7,
        Via = 8,
        Warning = 9,
        Allow = 10,
        ContentLength = 11,
        ContentType = 12,
        ContentEncoding = 13,
        ContentLanguage = 14,
        ContentLocation = 15,
        ContentMd5 = 16,
        ContentRange = 17,
        Expires = 18,
        LastModified = 19,
        Accept = 20,
        AcceptCharset = 21,
        AcceptEncoding = 22,
        AcceptLanguage = 23,
        Authorization = 24,
        Cookie = 25,
        Expect = 26,
        From = 27,
        Host = 28,
        IfMatch = 29,
        IfModifiedSince = 30,
        IfNoneMatch = 31,
        IfRange = 32,
        IfUnmodifiedSince = 33,
        MaxForwards = 34,
        ProxyAuthorization = 35,
        Referer = 36,
        Range = 37,
        Te = 38,
        Translate = 39,
        UserAgent = 40,
    }
    internal partial class SocketAddress
    {
        internal const int IPv4AddressSize = 16;
        internal const int IPv6AddressSize = 28;
        public SocketAddress(System.Net.Sockets.AddressFamily family, int size) { }
        internal byte[] Buffer { get { throw null; } }
        internal System.Net.Sockets.AddressFamily Family { get { throw null; } }
        internal int Size { get { throw null; } }
        public override bool Equals(object comparand) { throw null; }
        public override int GetHashCode() { throw null; }
        internal System.Net.IPAddress GetIPAddress() { throw null; }
        internal string GetIPAddressString() { throw null; }
        internal int GetPort() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    internal readonly partial struct CookedUrl
    {
        internal CookedUrl(Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_COOKED_URL nativeCookedUrl) { throw null; }
        internal string GetAbsPath() { throw null; }
        internal string GetFullUrl() { throw null; }
        internal string GetHost() { throw null; }
        internal string GetQueryString() { throw null; }
    }
    internal enum SslStatus : byte
    {
        Insecure = (byte)0,
        NoClientCert = (byte)1,
        ClientCert = (byte)2,
    }
    internal partial class SafeNativeOverlapped : System.Runtime.InteropServices.SafeHandle
    {
        internal static readonly Microsoft.AspNetCore.HttpSys.Internal.SafeNativeOverlapped Zero;
        internal SafeNativeOverlapped() : base (default(System.IntPtr), default(bool)) { }
        internal unsafe SafeNativeOverlapped(System.Threading.ThreadPoolBoundHandle boundHandle, System.Threading.NativeOverlapped* handle) : base (default(System.IntPtr), default(bool)) { }
        public override bool IsInvalid { get { throw null; } }
        public void ReinitializeNativeOverlapped() { }
        protected override bool ReleaseHandle() { throw null; }
    }
    internal static partial class HttpApiTypes
    {
        internal static readonly string[] HttpVerbs;
        internal const int MaxTimeout = 6;
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct FromFileHandle
        {
            private int _dummyPrimitive;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct FromMemory
        {
            private int _dummyPrimitive;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTPAPI_VERSION
        {
            private int _dummyPrimitive;
        }
        internal enum HTTP_API_VERSION
        {
            Invalid = 0,
            Version10 = 1,
            Version20 = 2,
        }
        internal enum HTTP_AUTH_STATUS
        {
            HttpAuthStatusSuccess = 0,
            HttpAuthStatusNotAuthenticated = 1,
            HttpAuthStatusFailure = 2,
        }
        [System.FlagsAttribute]
        internal enum HTTP_AUTH_TYPES : uint
        {
            NONE = (uint)0,
            HTTP_AUTH_ENABLE_BASIC = (uint)1,
            HTTP_AUTH_ENABLE_DIGEST = (uint)2,
            HTTP_AUTH_ENABLE_NTLM = (uint)4,
            HTTP_AUTH_ENABLE_NEGOTIATE = (uint)8,
            HTTP_AUTH_ENABLE_KERBEROS = (uint)16,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_BINDING_INFO
        {
            private int _dummyPrimitive;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_CACHE_POLICY
        {
            private int _dummyPrimitive;
        }
        internal enum HTTP_CACHE_POLICY_TYPE
        {
            HttpCachePolicyNocache = 0,
            HttpCachePolicyUserInvalidates = 1,
            HttpCachePolicyTimeToLive = 2,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_CONNECTION_LIMIT_INFO
        {
            private int _dummyPrimitive;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_COOKED_URL
        {
            private int _dummyPrimitive;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        internal partial struct HTTP_DATA_CHUNK
        {
            private int _dummyPrimitive;
        }
        internal enum HTTP_DATA_CHUNK_TYPE
        {
            HttpDataChunkFromMemory = 0,
            HttpDataChunkFromFileHandle = 1,
            HttpDataChunkFromFragmentCache = 2,
            HttpDataChunkMaximum = 3,
        }
        [System.FlagsAttribute]
        internal enum HTTP_FLAGS : uint
        {
            NONE = (uint)0,
            HTTP_INITIALIZE_SERVER = (uint)1,
            HTTP_PROPERTY_FLAG_PRESENT = (uint)1,
            HTTP_RECEIVE_REQUEST_FLAG_COPY_BODY = (uint)1,
            HTTP_RECEIVE_SECURE_CHANNEL_TOKEN = (uint)1,
            HTTP_SEND_REQUEST_FLAG_MORE_DATA = (uint)1,
            HTTP_SEND_RESPONSE_FLAG_DISCONNECT = (uint)1,
            HTTP_SEND_RESPONSE_FLAG_MORE_DATA = (uint)2,
            HTTP_INITIALIZE_CBT = (uint)4,
            HTTP_SEND_RESPONSE_FLAG_BUFFER_DATA = (uint)4,
            HTTP_SEND_RESPONSE_FLAG_RAW_HEADER = (uint)4,
            HTTP_SEND_RESPONSE_FLAG_OPAQUE = (uint)64,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_KNOWN_HEADER
        {
            private int _dummyPrimitive;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_MULTIPLE_KNOWN_HEADERS
        {
            private int _dummyPrimitive;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_QOS_SETTING_INFO
        {
            private int _dummyPrimitive;
        }
        internal enum HTTP_QOS_SETTING_TYPE
        {
            HttpQosSettingTypeBandwidth = 0,
            HttpQosSettingTypeConnectionLimit = 1,
            HttpQosSettingTypeFlowRate = 2,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_REQUEST
        {
            private int _dummyPrimitive;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_REQUEST_AUTH_INFO
        {
            private int _dummyPrimitive;
        }
        internal enum HTTP_REQUEST_AUTH_TYPE
        {
            HttpRequestAuthTypeNone = 0,
            HttpRequestAuthTypeBasic = 1,
            HttpRequestAuthTypeDigest = 2,
            HttpRequestAuthTypeNTLM = 3,
            HttpRequestAuthTypeNegotiate = 4,
            HttpRequestAuthTypeKerberos = 5,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_REQUEST_CHANNEL_BIND_STATUS
        {
            private int _dummyPrimitive;
        }
        [System.FlagsAttribute]
        internal enum HTTP_REQUEST_FLAGS
        {
            None = 0,
            MoreEntityBodyExists = 1,
            IPRouted = 2,
            Http2 = 4,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_REQUEST_HEADERS
        {
            private int _dummyPrimitive;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_REQUEST_INFO
        {
            private int _dummyPrimitive;
        }
        internal enum HTTP_REQUEST_INFO_TYPE
        {
            HttpRequestInfoTypeAuth = 0,
            HttpRequestInfoTypeChannelBind = 1,
            HttpRequestInfoTypeSslProtocol = 2,
            HttpRequestInfoTypeSslTokenBinding = 3,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_REQUEST_TOKEN_BINDING_INFO
        {
            private int _dummyPrimitive;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_REQUEST_V2
        {
            private int _dummyPrimitive;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_RESPONSE
        {
            private int _dummyPrimitive;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_RESPONSE_HEADERS
        {
            private int _dummyPrimitive;
        }
        internal static partial class HTTP_RESPONSE_HEADER_ID
        {
            internal static int IndexOfKnownHeader(string HeaderName) { throw null; }
            internal enum Enum
            {
                HttpHeaderCacheControl = 0,
                HttpHeaderConnection = 1,
                HttpHeaderDate = 2,
                HttpHeaderKeepAlive = 3,
                HttpHeaderPragma = 4,
                HttpHeaderTrailer = 5,
                HttpHeaderTransferEncoding = 6,
                HttpHeaderUpgrade = 7,
                HttpHeaderVia = 8,
                HttpHeaderWarning = 9,
                HttpHeaderAllow = 10,
                HttpHeaderContentLength = 11,
                HttpHeaderContentType = 12,
                HttpHeaderContentEncoding = 13,
                HttpHeaderContentLanguage = 14,
                HttpHeaderContentLocation = 15,
                HttpHeaderContentMd5 = 16,
                HttpHeaderContentRange = 17,
                HttpHeaderExpires = 18,
                HttpHeaderLastModified = 19,
                HttpHeaderAcceptRanges = 20,
                HttpHeaderAge = 21,
                HttpHeaderEtag = 22,
                HttpHeaderLocation = 23,
                HttpHeaderProxyAuthenticate = 24,
                HttpHeaderRetryAfter = 25,
                HttpHeaderServer = 26,
                HttpHeaderSetCookie = 27,
                HttpHeaderVary = 28,
                HttpHeaderWwwAuthenticate = 29,
                HttpHeaderResponseMaximum = 30,
                HttpHeaderMaximum = 41,
            }
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_RESPONSE_INFO
        {
            private int _dummyPrimitive;
        }
        internal enum HTTP_RESPONSE_INFO_FLAGS : uint
        {
            None = (uint)0,
            PreserveOrder = (uint)1,
        }
        internal enum HTTP_RESPONSE_INFO_TYPE
        {
            HttpResponseInfoTypeMultipleKnownHeaders = 0,
            HttpResponseInfoTypeAuthenticationProperty = 1,
            HttpResponseInfoTypeQosProperty = 2,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_RESPONSE_V2
        {
            private int _dummyPrimitive;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_SERVER_AUTHENTICATION_BASIC_PARAMS
        {
            private int _dummyPrimitive;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_SERVER_AUTHENTICATION_DIGEST_PARAMS
        {
            private int _dummyPrimitive;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_SERVER_AUTHENTICATION_INFO
        {
            private int _dummyPrimitive;
        }
        internal enum HTTP_SERVER_PROPERTY
        {
            HttpServerAuthenticationProperty = 0,
            HttpServerLoggingProperty = 1,
            HttpServerQosProperty = 2,
            HttpServerTimeoutsProperty = 3,
            HttpServerQueueLengthProperty = 4,
            HttpServerStateProperty = 5,
            HttpServer503VerbosityProperty = 6,
            HttpServerBindingProperty = 7,
            HttpServerExtendedAuthenticationProperty = 8,
            HttpServerListenEndpointProperty = 9,
            HttpServerChannelBindProperty = 10,
            HttpServerProtectionLevelProperty = 11,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_SERVICE_BINDING_BASE
        {
            private int _dummyPrimitive;
        }
        internal enum HTTP_SERVICE_BINDING_TYPE : uint
        {
            HttpServiceBindingTypeNone = (uint)0,
            HttpServiceBindingTypeW = (uint)1,
            HttpServiceBindingTypeA = (uint)2,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_SSL_CLIENT_CERT_INFO
        {
            private int _dummyPrimitive;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_SSL_INFO
        {
            private int _dummyPrimitive;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_SSL_PROTOCOL_INFO
        {
            private int _dummyPrimitive;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_TIMEOUT_LIMIT_INFO
        {
            private int _dummyPrimitive;
        }
        internal enum HTTP_TIMEOUT_TYPE
        {
            EntityBody = 0,
            DrainEntityBody = 1,
            RequestQueue = 2,
            IdleConnection = 3,
            HeaderWait = 4,
            MinSendRate = 5,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_TRANSPORT_ADDRESS
        {
            private int _dummyPrimitive;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_UNKNOWN_HEADER
        {
            private int _dummyPrimitive;
        }
        internal enum HTTP_VERB
        {
            HttpVerbUnparsed = 0,
            HttpVerbUnknown = 1,
            HttpVerbInvalid = 2,
            HttpVerbOPTIONS = 3,
            HttpVerbGET = 4,
            HttpVerbHEAD = 5,
            HttpVerbPOST = 6,
            HttpVerbPUT = 7,
            HttpVerbDELETE = 8,
            HttpVerbTRACE = 9,
            HttpVerbCONNECT = 10,
            HttpVerbTRACK = 11,
            HttpVerbMOVE = 12,
            HttpVerbCOPY = 13,
            HttpVerbPROPFIND = 14,
            HttpVerbPROPPATCH = 15,
            HttpVerbMKCOL = 16,
            HttpVerbLOCK = 17,
            HttpVerbUNLOCK = 18,
            HttpVerbSEARCH = 19,
            HttpVerbMaximum = 20,
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct HTTP_VERSION
        {
            private int _dummyPrimitive;
        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        internal partial struct SOCKADDR
        {
            private int _dummyPrimitive;
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TextTemplatingFileGenerator", "")]
    internal partial class RequestHeaders : Microsoft.AspNetCore.Http.IHeaderDictionary, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>>, System.Collections.Generic.IDictionary<string, Microsoft.Extensions.Primitives.StringValues>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>>, System.Collections.IEnumerable
    {
        internal RequestHeaders(Microsoft.AspNetCore.HttpSys.Internal.NativeRequestContext requestMemoryBlob) { }
        internal Microsoft.Extensions.Primitives.StringValues Accept { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues AcceptCharset { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues AcceptEncoding { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues AcceptLanguage { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Allow { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Authorization { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues CacheControl { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Connection { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues ContentEncoding { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues ContentLanguage { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues ContentLength { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues ContentLocation { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues ContentMd5 { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues ContentRange { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues ContentType { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Cookie { get { throw null; } set { } }
        public int Count { get { throw null; } }
        internal Microsoft.Extensions.Primitives.StringValues Date { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Expect { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Expires { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues From { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Host { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues IfMatch { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues IfModifiedSince { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues IfNoneMatch { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues IfRange { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues IfUnmodifiedSince { get { throw null; } set { } }
        public bool IsReadOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]internal set { } }
        public Microsoft.Extensions.Primitives.StringValues this[string key] { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues KeepAlive { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        internal Microsoft.Extensions.Primitives.StringValues LastModified { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues MaxForwards { get { throw null; } set { } }
        long? Microsoft.AspNetCore.Http.IHeaderDictionary.ContentLength { get { throw null; } set { } }
        Microsoft.Extensions.Primitives.StringValues Microsoft.AspNetCore.Http.IHeaderDictionary.this[string key] { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Pragma { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues ProxyAuthorization { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Range { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Referer { get { throw null; } set { } }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Microsoft.Extensions.Primitives.StringValues>>.IsReadOnly { get { throw null; } }
        Microsoft.Extensions.Primitives.StringValues System.Collections.Generic.IDictionary<System.String,Microsoft.Extensions.Primitives.StringValues>.this[string key] { get { throw null; } set { } }
        System.Collections.Generic.ICollection<Microsoft.Extensions.Primitives.StringValues> System.Collections.Generic.IDictionary<System.String,Microsoft.Extensions.Primitives.StringValues>.Values { get { throw null; } }
        internal Microsoft.Extensions.Primitives.StringValues Te { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Trailer { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues TransferEncoding { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Translate { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Upgrade { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues UserAgent { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Via { get { throw null; } set { } }
        internal Microsoft.Extensions.Primitives.StringValues Warning { get { throw null; } set { } }
        public bool ContainsKey(string key) { throw null; }
        public System.Collections.Generic.IEnumerable<string> GetValues(string key) { throw null; }
        public bool Remove(string key) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Microsoft.Extensions.Primitives.StringValues>>.Add(System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues> item) { }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Microsoft.Extensions.Primitives.StringValues>>.Clear() { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Microsoft.Extensions.Primitives.StringValues>>.Contains(System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues> item) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Microsoft.Extensions.Primitives.StringValues>>.CopyTo(System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>[] array, int arrayIndex) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Microsoft.Extensions.Primitives.StringValues>>.Remove(System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues> item) { throw null; }
        void System.Collections.Generic.IDictionary<System.String,Microsoft.Extensions.Primitives.StringValues>.Add(string key, Microsoft.Extensions.Primitives.StringValues value) { }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,Microsoft.Extensions.Primitives.StringValues>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(string key, out Microsoft.Extensions.Primitives.StringValues value) { throw null; }
    }
    internal partial class NativeRequestContext : System.IDisposable
    {
        internal unsafe NativeRequestContext(Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_REQUEST* request) { }
        internal unsafe NativeRequestContext(Microsoft.AspNetCore.HttpSys.Internal.SafeNativeOverlapped nativeOverlapped, int bufferAlignment, Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_REQUEST* nativeRequest, byte[] backingBuffer, ulong requestId) { }
        internal ulong ConnectionId { get { throw null; } }
        internal bool IsHttp2 { get { throw null; } }
        internal Microsoft.AspNetCore.HttpSys.Internal.SafeNativeOverlapped NativeOverlapped { get { throw null; } }
        internal unsafe Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_REQUEST* NativeRequest { get { throw null; } }
        internal unsafe Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_REQUEST_V2* NativeRequestV2 { get { throw null; } }
        internal ulong RequestId { get { throw null; } set { } }
        internal uint Size { get { throw null; } }
        internal Microsoft.AspNetCore.HttpSys.Internal.SslStatus SslStatus { get { throw null; } }
        internal ushort UnknownHeaderCount { get { throw null; } }
        internal ulong UrlContext { get { throw null; } }
        internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_VERB VerbId { get { throw null; } }
        internal bool CheckAuthenticated() { throw null; }
        public virtual void Dispose() { }
        internal uint GetChunks(ref int dataChunkIndex, ref uint dataChunkOffset, byte[] buffer, int offset, int size) { throw null; }
        internal Microsoft.AspNetCore.HttpSys.Internal.CookedUrl GetCookedUrl() { throw null; }
        internal string GetKnownHeader(Microsoft.AspNetCore.HttpSys.Internal.HttpSysRequestHeader header) { throw null; }
        internal Microsoft.AspNetCore.HttpSys.Internal.SocketAddress GetLocalEndPoint() { throw null; }
        internal string GetRawUrl() { throw null; }
        internal System.Span<byte> GetRawUrlInBytes() { throw null; }
        internal Microsoft.AspNetCore.HttpSys.Internal.SocketAddress GetRemoteEndPoint() { throw null; }
        internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_SSL_PROTOCOL_INFO GetTlsHandshake() { throw null; }
        internal void GetUnknownHeaders(System.Collections.Generic.IDictionary<string, Microsoft.Extensions.Primitives.StringValues> unknownHeaders) { }
        internal System.Security.Principal.WindowsPrincipal GetUser() { throw null; }
        internal string GetVerb() { throw null; }
        internal System.Version GetVersion() { throw null; }
        internal void ReleasePins() { }
    }
    internal partial class HeaderCollection : Microsoft.AspNetCore.Http.IHeaderDictionary, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>>, System.Collections.Generic.IDictionary<string, Microsoft.Extensions.Primitives.StringValues>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>>, System.Collections.IEnumerable
    {
        public HeaderCollection() { }
        public HeaderCollection(System.Collections.Generic.IDictionary<string, Microsoft.Extensions.Primitives.StringValues> store) { }
        public long? ContentLength { get { throw null; } set { } }
        public int Count { get { throw null; } }
        public bool IsReadOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]internal set { } }
        public Microsoft.Extensions.Primitives.StringValues this[string key] { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        Microsoft.Extensions.Primitives.StringValues System.Collections.Generic.IDictionary<System.String,Microsoft.Extensions.Primitives.StringValues>.this[string key] { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<Microsoft.Extensions.Primitives.StringValues> Values { get { throw null; } }
        public void Add(System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues> item) { }
        public void Add(string key, Microsoft.Extensions.Primitives.StringValues value) { }
        public void Append(string key, string value) { }
        public void Clear() { }
        public bool Contains(System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues> item) { throw null; }
        public bool ContainsKey(string key) { throw null; }
        public void CopyTo(System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>> GetEnumerator() { throw null; }
        public System.Collections.Generic.IEnumerable<string> GetValues(string key) { throw null; }
        public bool Remove(System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues> item) { throw null; }
        public bool Remove(string key) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(string key, out Microsoft.Extensions.Primitives.StringValues value) { throw null; }
        public static void ValidateHeaderCharacters(Microsoft.Extensions.Primitives.StringValues headerValues) { }
        public static void ValidateHeaderCharacters(string headerCharacters) { }
    }
}
namespace Microsoft.AspNetCore.Server.HttpSys
{
    internal partial class ResponseBody : System.IO.Stream
    {
        internal ResponseBody(Microsoft.AspNetCore.Server.HttpSys.RequestContext requestContext) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        internal bool IsDisposed { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        internal Microsoft.AspNetCore.Server.HttpSys.RequestContext RequestContext { get { throw null; } }
        internal bool ThrowWriteExceptions { get { throw null; } }
        internal void Abort(bool dispose = true) { }
        public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        internal void CancelLastWrite() { }
        protected override void Dispose(bool disposing) { }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        internal System.Threading.Tasks.Task SendFileAsyncCore(string fileName, long offset, long? count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override void SetLength(long value) { }
        internal void SwitchToOpaqueMode() { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    internal partial class ResponseStreamAsyncResult : System.IAsyncResult, System.IDisposable
    {
        internal ResponseStreamAsyncResult(Microsoft.AspNetCore.Server.HttpSys.ResponseBody responseStream, System.ArraySegment<byte> data, bool chunked, System.Threading.CancellationToken cancellationToken) { }
        internal ResponseStreamAsyncResult(Microsoft.AspNetCore.Server.HttpSys.ResponseBody responseStream, System.IO.FileStream fileStream, long offset, long count, bool chunked, System.Threading.CancellationToken cancellationToken) { }
        internal ResponseStreamAsyncResult(Microsoft.AspNetCore.Server.HttpSys.ResponseBody responseStream, System.Threading.CancellationToken cancellationToken) { }
        public object AsyncState { get { throw null; } }
        public System.Threading.WaitHandle AsyncWaitHandle { get { throw null; } }
        internal uint BytesSent { get { throw null; } set { } }
        public bool CompletedSynchronously { get { throw null; } }
        internal ushort DataChunkCount { get { throw null; } }
        internal unsafe Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_DATA_CHUNK* DataChunks { get { throw null; } }
        internal bool EndCalled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsCompleted { get { throw null; } }
        internal Microsoft.AspNetCore.HttpSys.Internal.SafeNativeOverlapped NativeOverlapped { get { throw null; } }
        internal System.Threading.Tasks.Task Task { get { throw null; } }
        internal void Cancel(bool dispose) { }
        internal void Complete() { }
        public void Dispose() { }
        internal void Fail(System.Exception ex) { }
        internal void FailSilently() { }
        internal void IOCompleted(uint errorCode) { }
        internal void IOCompleted(uint errorCode, uint numBytes) { }
    }
    internal sealed partial class HttpServerSessionHandle : Microsoft.Win32.SafeHandles.CriticalHandleZeroOrMinusOneIsInvalid
    {
        internal HttpServerSessionHandle(ulong id) { }
        internal ulong DangerousGetServerSessionId() { throw null; }
        protected override bool ReleaseHandle() { throw null; }
    }
    internal partial class ServerSession : System.IDisposable
    {
        internal ServerSession() { }
        public Microsoft.AspNetCore.Server.HttpSys.HttpServerSessionHandle Id { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public void Dispose() { }
    }
    internal partial class UrlGroup : System.IDisposable
    {
        internal UrlGroup(Microsoft.AspNetCore.Server.HttpSys.ServerSession serverSession, Microsoft.Extensions.Logging.ILogger logger) { }
        internal ulong Id { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public void Dispose() { }
        internal void RegisterPrefix(string uriPrefix, int contextId) { }
        internal void SetMaxConnections(long maxConnections) { }
        internal void SetProperty(Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_SERVER_PROPERTY property, System.IntPtr info, uint infosize, bool throwOnError = true) { }
        internal bool UnregisterPrefix(string uriPrefix) { throw null; }
    }
    internal partial class RequestQueue
    {
        internal RequestQueue(Microsoft.AspNetCore.Server.HttpSys.UrlGroup urlGroup, Microsoft.Extensions.Logging.ILogger logger) { }
        internal System.Threading.ThreadPoolBoundHandle BoundHandle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        internal System.Runtime.InteropServices.SafeHandle Handle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        internal void AttachToUrlGroup() { }
        internal void DetachFromUrlGroup() { }
        public void Dispose() { }
        internal void SetLengthLimit(long length) { }
        internal void SetRejectionVerbosity(Microsoft.AspNetCore.Server.HttpSys.Http503VerbosityLevel verbosity) { }
    }
    internal enum BoundaryType
    {
        None = 0,
        Chunked = 1,
        ContentLength = 2,
        Close = 3,
        PassThrough = 4,
        Invalid = 5,
    }
    internal sealed partial class Request
    {
        internal Request(Microsoft.AspNetCore.Server.HttpSys.RequestContext requestContext, Microsoft.AspNetCore.HttpSys.Internal.NativeRequestContext nativeRequestContext) { }
        public System.IO.Stream Body { get { throw null; } }
        public System.Security.Authentication.CipherAlgorithmType CipherAlgorithm { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int CipherStrength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public long ConnectionId { get { throw null; } }
        public long? ContentLength { get { throw null; } }
        public bool HasEntityBody { get { throw null; } }
        public System.Security.Authentication.HashAlgorithmType HashAlgorithm { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int HashStrength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool HasRequestBodyStarted { get { throw null; } }
        public Microsoft.AspNetCore.HttpSys.Internal.RequestHeaders Headers { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        internal bool IsHeadMethod { get { throw null; } }
        public bool IsHttps { get { throw null; } }
        internal bool IsUpgradable { get { throw null; } }
        public System.Security.Authentication.ExchangeAlgorithmType KeyExchangeAlgorithm { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int KeyExchangeStrength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_VERB KnownMethod { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Net.IPAddress LocalIpAddress { get { throw null; } }
        public int LocalPort { get { throw null; } }
        public long? MaxRequestBodySize { get { throw null; } set { } }
        public string Method { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Path { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string PathBase { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Security.Authentication.SslProtocols Protocol { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Version ProtocolVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string QueryString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string RawUrl { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Net.IPAddress RemoteIpAddress { get { throw null; } }
        public int RemotePort { get { throw null; } }
        internal ulong RequestId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Scheme { get { throw null; } }
        internal ulong UConnectionId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        internal System.Security.Principal.WindowsPrincipal User { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        internal void Dispose() { }
        internal uint GetChunks(ref int dataChunkIndex, ref uint dataChunkOffset, byte[] buffer, int offset, int size) { throw null; }
        internal void SwitchToOpaqueMode() { }
    }
    internal sealed partial class Response
    {
        internal Response(Microsoft.AspNetCore.Server.HttpSys.RequestContext requestContext) { }
        public Microsoft.AspNetCore.Server.HttpSys.AuthenticationSchemes AuthenticationChallenges { get { throw null; } set { } }
        public System.IO.Stream Body { get { throw null; } }
        internal bool BodyIsFinished { get { throw null; } }
        internal Microsoft.AspNetCore.Server.HttpSys.BoundaryType BoundaryType { get { throw null; } }
        public System.TimeSpan? CacheTtl { get { throw null; } set { } }
        public long? ContentLength { get { throw null; } set { } }
        internal long ExpectedBodyLength { get { throw null; } }
        internal bool HasComputedHeaders { get { throw null; } }
        public bool HasStarted { get { throw null; } }
        public Microsoft.AspNetCore.HttpSys.Internal.HeaderCollection Headers { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string ReasonPhrase { get { throw null; } set { } }
        public int StatusCode { get { throw null; } set { } }
        internal void Abort() { }
        internal void CancelLastWrite() { }
        internal Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_FLAGS ComputeHeaders(long writeCount, bool endOfRequest = false) { throw null; }
        internal void Dispose() { }
        public System.Threading.Tasks.Task SendFileAsync(string path, long offset, long? count, System.Threading.CancellationToken cancel) { throw null; }
        internal uint SendHeaders(Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_DATA_CHUNK[] dataChunks, Microsoft.AspNetCore.Server.HttpSys.ResponseStreamAsyncResult asyncResult, Microsoft.AspNetCore.HttpSys.Internal.HttpApiTypes.HTTP_FLAGS flags, bool isOpaqueUpgrade) { throw null; }
        internal void SendOpaqueUpgrade() { }
        internal void SwitchToOpaqueMode() { }
    }
    internal partial class DisconnectListener
    {
        internal DisconnectListener(Microsoft.AspNetCore.Server.HttpSys.RequestQueue requestQueue, Microsoft.Extensions.Logging.ILogger logger) { }
        internal System.Threading.CancellationToken GetTokenForConnection(ulong connectionId) { throw null; }
    }
    internal partial class HttpSysListener : System.IDisposable
    {
        internal static readonly bool SkipIOCPCallbackOnSuccess;
        public HttpSysListener(Microsoft.AspNetCore.Server.HttpSys.HttpSysOptions options, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        internal Microsoft.AspNetCore.Server.HttpSys.DisconnectListener DisconnectListener { get { throw null; } }
        public bool IsListening { get { throw null; } }
        internal Microsoft.Extensions.Logging.ILogger Logger { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.AspNetCore.Server.HttpSys.HttpSysOptions Options { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        internal Microsoft.AspNetCore.Server.HttpSys.RequestQueue RequestQueue { get { throw null; } }
        internal Microsoft.AspNetCore.Server.HttpSys.UrlGroup UrlGroup { get { throw null; } }
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Server.HttpSys.RequestContext> AcceptAsync() { throw null; }
        internal void SendError(ulong requestId, int httpStatusCode, System.Collections.Generic.IList<string> authChallenges = null) { }
        public void Start() { }
        public void Dispose() { }
        internal bool ValidateAuth(Microsoft.AspNetCore.HttpSys.Internal.NativeRequestContext requestMemory) { throw null; }
        internal bool ValidateRequest(Microsoft.AspNetCore.HttpSys.Internal.NativeRequestContext requestMemory) { throw null; }
        internal enum State
        {
            Stopped = 0,
            Started = 1,
            Disposed = 2,
        }
    }
    internal sealed partial class RequestContext : System.IDisposable
    {
        internal RequestContext(Microsoft.AspNetCore.Server.HttpSys.HttpSysListener server, Microsoft.AspNetCore.HttpSys.Internal.NativeRequestContext memoryBlob) { }
        internal bool AllowSynchronousIO { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Threading.CancellationToken DisconnectToken { get { throw null; } }
        public bool IsUpgradableRequest { get { throw null; } }
        internal Microsoft.Extensions.Logging.ILogger Logger { get { throw null; } }
        public Microsoft.AspNetCore.Server.HttpSys.Request Request { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.AspNetCore.Server.HttpSys.Response Response { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        internal Microsoft.AspNetCore.Server.HttpSys.HttpSysListener Server { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Guid TraceIdentifier { get { throw null; } }
        public System.Security.Principal.WindowsPrincipal User { get { throw null; } }
        public void Abort() { }
        public void Dispose() { }
        internal void ForceCancelRequest() { }
        internal System.Threading.CancellationTokenRegistration RegisterForCancellation(System.Threading.CancellationToken cancellationToken) { throw null; }
        internal bool TryGetChannelBinding(ref System.Security.Authentication.ExtendedProtection.ChannelBinding value) { throw null; }
        public System.Threading.Tasks.Task<System.IO.Stream> UpgradeAsync() { throw null; }
    }
    internal partial class MessagePump : Microsoft.AspNetCore.Hosting.Server.IServer, System.IDisposable
    {
        public MessagePump(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Server.HttpSys.HttpSysOptions> options, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.Authentication.IAuthenticationSchemeProvider authentication) { }
        public Microsoft.AspNetCore.Http.Features.IFeatureCollection Features { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        internal Microsoft.AspNetCore.Server.HttpSys.HttpSysListener Listener { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public void Dispose() { }
        public System.Threading.Tasks.Task StartAsync<TContext>(Microsoft.AspNetCore.Hosting.Server.IHttpApplication<TContext> application, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task StopAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
    }
}