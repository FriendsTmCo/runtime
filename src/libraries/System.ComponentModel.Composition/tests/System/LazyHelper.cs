// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Threading;

namespace System
{
    internal static class LazyHelper
    {
        public static Lazy<T> AsLazy<T>(this T t)
            where T : class
        {
            return new Lazy<T>(() => t, LazyThreadSafetyMode.PublicationOnly);
        }
    }
}
