﻿// Copyright (c) The Avalonia Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;

namespace Avalonia.Animation.Animators
{
    /// <summary>
    /// Animator that handles <see cref="UInt16"/> properties.
    /// </summary>
    public class UInt16Animator : Animator<UInt16>
    {
        static double maxVal = (double)UInt16.MaxValue;

        /// <inheritdocs/>
        public override UInt16 Interpolate(double progress, UInt16 oldValue, UInt16 newValue)
        {
            var normOV = oldValue / maxVal;
            var normNV = newValue / maxVal;
            var deltaV = normNV - normOV;
            return (UInt16)Math.Round(maxVal * ((deltaV * progress) + normOV));
        }
    }
}