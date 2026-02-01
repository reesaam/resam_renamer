namespace ResamRenamer.Resources
{
    public static class AppStrings
    {
        public const string Empty = "";
        public const string Space = " ";
        public const string SeasonInitial = "S";
        public const string EpisodeInitial = "E";

        public const string Destination = "Destination";
        public const string Source = "Source";
        public const string Subtitle = "Subtitle";
        public const string Subtitles = "Subtitles";
        public const string Browse = "Browse";

        public const string Season = "Season";
        public const string Episode = "Episode";

        public const string StatusIdle = "Idle";
        public const string StatusBusy = "Working...";
        public const string StatusProcess = "Processing...";
        public const string StatusExit = "Exiting...";
        public const string StatusSuccessful = "Successfull Performance";
        public const string StatusError = "Error!";
        public const string StatusCheckError = "Checking for Errors!";

        public const string ErrorChooseAction = "Choose an Action!!!";
        public const string ErrorAddressEmpty = "Address field is Empty!";
        public const string ErrorPickFilter = "Pick a Filter!";
        public const string ErrorFillOriginal = "Fill Original Text Field!";
        public const string ErrorFillReplace = "Fill Replace Text Field for Replacement\nOR Check Remove to Remove the Text!";
        public const string ErrorNumberOfFiles = "Number of VideoFiles and SubtitlesFiles are not Even!";
        public const string ErrorChooseNumber = "Choose a Number for Series Folder";
        public const string ErrorFolderNotExistTaskFailed = "Destination Folder is Not Empty or Includes Some Similar Folders!\nTask is Unable to Perform";
        public const string ErrorConnection = "Connection Error!";
        public const string ErrorDownload = "DownloadError!\nCheck your Connection to Internet.";
        public const string ErrorInstaller = "Installer File not Found!";
        public const string ErrorUpdateTitle = "Update Error";
        public const string ErrorUpdateInstallTitle = "Install Update Error";

        public const string MessageMessage = "Message";
        public const string MessageChooseFolderPath = "Choose an Available Folder Path!";
        public const string MessageSelectAndFill = "Select Movie or Series and Fill Fields";
        public const string MessageDestinationNotAvailable = "Choose an Available Folder Path for Destination!";
        public const string MessageDragFolder = "This is a File, Drag a Folder to specifiy a Location.";
        public const string MessageDragFile = "This is a Folder, Drag a Supported Movie or Subtitle File.";
        public const string MessageUpdateAvailable = "There is a Update Available\nDo you wnat to Download and Install?";
        public const string MessageAreYouSure = "Are You Sure?";

        public const string TextOriginalText = "Original Text";
        public const string TextReplaceText = "Replace Text";
        
        public const string ButtonTextExit = "Exit";

        public static string MessageSuccessful(int count) => "Proccess has been Done Successfully.\n" + count.ToString() + " Files has been Created or Modified.";
        public static string MessageAddressEmpty(string target) => target + " Address is Empty!";
        public static string MessageAddressNotExist(string target) => target + " Address does not Exist!";
        public static string MessageFileNotExist(string target) => target + " File does not Exists.";
        public static string MessageFolderNotExist(string target) => target + " Folder does not Exists.";
        public static string MessageFormatNotSupported(string target) => target + " File Format not Supported.";
    }
}
