namespace CleverGirl {
    using XRL;
    using static XRL.UI.Options;

    [HasOptionFlagUpdate(Prefix = "OptionCleverGirl")]
    public static partial class Static {

        [OptionFlag(ID = "Debug")]
        public static bool OptionDebug { get; private set; }
        private static bool OptionDebugBefore = false;

        [OptionFlagUpdate]
        public static void UpdateFlags() {
            if (OptionDebug != OptionDebugBefore) {
                MetricsManager.LogInfo("Changed Clever Girl debug logging to : " + OptionDebug);
            }
            OptionDebugBefore = OptionDebug;
        }
    }
}
