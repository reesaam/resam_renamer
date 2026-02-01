using ResamRenamer.Resources;

namespace ResamRenamer.Resources
{
    public enum AppStatus
    {
        idle,
        busy,
        processing,
        successful,
        error,
        checkError,
    }
}

public static class AppStatusExtensions
{
    public static string GetMessage(this AppStatus value)
    {
        string message = "";
        switch (value)
        {
            case AppStatus.idle: message = AppStrings.StatusIdle; break;
            case AppStatus.busy: message = AppStrings.StatusBusy; break;
            case AppStatus.processing: message = AppStrings.StatusSuccessful; break;
            case AppStatus.successful: message = AppStrings.StatusProcess; break;
            case AppStatus.error: message = AppStrings.StatusError; break;
            case AppStatus.checkError: message = AppStrings.StatusCheckError; break;
        }

        return message;
    }
}

