// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.AspNetCore.Blazor.Services;
using Microsoft.JSInterop;

namespace Microsoft.AspNetCore.Blazor
{
    /// <summary>
    /// Contains methods called by interop. Intended for framework use only, not supported for use in application
    /// code.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class JSInteropMethods
    {
        /// <summary>
        /// For framework use only.
        /// </summary>
        [JSInvokable(nameof(NotifyLocationChanged))]
        public static void NotifyLocationChanged(string uri, bool isInterceptedLink)
        {
            WebAssemblyNavigationManager.Instance.SetLocation(uri, isInterceptedLink);
        }

        /// <summary>
        /// For framework use only.
        /// </summary>
        [JSInvokable(nameof(InvokeEntrypointAsync))]
        public static Task InvokeEntrypointAsync(int entrypointMethodHandleValue, string[] args)
        {
            return EntrypointInvoker.InvokeEntrypointAsync(new IntPtr(entrypointMethodHandleValue), args);
        }
    }
}
