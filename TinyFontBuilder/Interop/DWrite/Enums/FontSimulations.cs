﻿namespace Win32
{
    using System;

    partial class DWrite
    {
        /// <summary>
        /// Specifies algorithmic style simulations to be applied to the font face.
        /// Bold and oblique simulations can be combined via bitwise OR operation.
        /// </summary>
        [Flags]
        internal enum FontSimulations
        {
            /// <summary>
            /// No simulations are performed.
            /// </summary>
            None = 0x0000,

            /// <summary>
            /// Algorithmic emboldening is performed.
            /// </summary>
            Bold = 0x0001,

            /// <summary>
            /// Algorithmic italicization is performed.
            /// </summary>
            Oblique = 0x0002
        }
    }
}