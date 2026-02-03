namespace ResamRenamer.Resources
{
    public static class AppConstants
    {
        public const int DefaultTimeOut = 2000;
        public const int DefaultAppUpdateDelay = 2000;
        public static readonly List<string> SupportedFormatsVideo = [".mkv", ".avi", ".mp4"];
        public static readonly List<string> VideoQualities = ["2560", "1080", "720", "480", "360"];
        public static readonly List<string> SupportedFormatsSubtitle = [".srt"];
        public static readonly List<string> ListPredefinedFilters = ["iMovie", "P30download", "Soft98", "SoftGozar"];
        public static readonly Environment.SpecialFolder DefaultInitialDirectory = Environment.SpecialFolder.Desktop;
    }
}
