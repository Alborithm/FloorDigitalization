using System;

namespace FloorDigitalization.Helpers;

public static class Shift
{
    public static int GetCurrentShift() => DateTime.Now.Hour >= 7 && DateTime.Now.Hour < 15 ? 1 : DateTime.Now.Hour >= 15 && DateTime.Now.Hour < 22 ? 2 : 3;
}