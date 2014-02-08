﻿// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==

#if !NET45

namespace Microsoft.Win32.SafeHandles
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    // Class of safe handle which uses 0 or -1 as an invalid handle.
    [System.Security.SecurityCritical]  // auto-generated_required
    internal abstract class SafeHandleZeroOrMinusOneIsInvalid : SafeHandle
    {
        protected SafeHandleZeroOrMinusOneIsInvalid(bool ownsHandle)
            : base(IntPtr.Zero, ownsHandle)
        {
        }

        public override bool IsInvalid
        {
            [System.Security.SecurityCritical]
            get { return handle == new IntPtr(0) || handle == new IntPtr(-1); }
        }
    }
}
#endif