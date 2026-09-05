// Build: 1c96ab739c400fa8576cbcbca7d01033
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
