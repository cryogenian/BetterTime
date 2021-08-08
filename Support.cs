﻿namespace BetterTime
{
    public static class Support
    {
        public static void SetSpeeds(bool isFastForward, bool isExtraFastForward)
        {
            IsSpeedFastForward = isFastForward;
            IsSpeedExtraFastForward = isExtraFastForward;
        }
        public static void SetSpeeds(bool isCtrlSpace) => IsSpeedCtrlSpace = isCtrlSpace;
        public static bool IsSpeedFastForward { get; set; }
        public static bool IsSpeedExtraFastForward { get; set; }
        public static bool IsSpeedCtrlSpace { get; set; }
    }
}
