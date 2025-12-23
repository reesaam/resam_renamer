using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResamRenamer.Resources
{
    public class AppStrings
    {
        public const string empty = "";
        public const string space = " ";
        public const string seasonInitial = "S";
        public const string episodeInitial = "E";

        public const string destination = "Destination";
        public const string source = "Source";
        public const string subtitle = "Subtitle";
        public const string subtitles = "Subtitles";
        public const string browse = "Browse";

        public const string season = "Season";
        public const string episode = "Episode";

        public const string statusIdle = "Idle";
        public const string statusBusy = "Working...";
        public const string statusProcess = "Processing...";
        public const string statusSuccessfull = "Successfull Performance";
        public const string statusError = "Error!";
        public const string statusCheckError = "Checking for Errors!";

        public const string errorChooseAction = "Choose an Action!!!";
        public const string errorAddressEmpty = "Address field is Empty!";
        public const string errorPickFilter = "Pick a Filter!";
        public const string errorFillOriginal = "Fill Original Text Field!";
        public const string errorFillReplace = "Fill Replace Text Field for Replacement\nOR Check Remove to Remove the Text!";
        public const string errorNumberOfFiles = "Number of VideoFiles and SubtitlesFiles are not Even!";
        public const string errorChooseNumber = "Choose a Number for Series Folder";
        public const string errorFolderNotExistTaskFailed = "Destination Folder is Not Empty or Includes Some Similar Folders!\nTask is Unable to Perform";

        public const string messageChooseFolderPath = "Choose an Available Folder Path!";
        public const string messageSelectAndFill = "Select Movie or Series and Fill Fields";
        public const string messageDestinationNotAvailable = "Choose an Available Folder Path for Destination!";
        public const string messageDragFolder = "This is a File, Drag a Folder to specifiy a Location.";
        public const string messageDragFile = "This is a Folder, Drag a Supported Movie or Subtitle File.";

        public const string textOriginalText = "Original Text";
        public const string textReplaceText = "Replace Text";

        static public string MessageSuccessfull(int count) => "Proccess has been Done Successfully.\n" + count.ToString() + " Files has been Created or Modified.";
        static public string MessageAddressEmpty(string target) => target + " Address is Empty!";
        static public string MessageAddressNotExist(string target) => target + " Address does not Exist!";
        static public string MessageFileNotExist(string target) => target + " File does not Exists.";
        static public string MessageFolderNotExist(string target) => target + " Folder does not Exists.";
        static public string MessageFormatNotSupported(string target) => target + " File Format not Supported.";
    }
}
