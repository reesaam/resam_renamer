using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            case AppStatus.idle: message = AppStrings.statusIdle; break;
            case AppStatus.busy: message = AppStrings.statusBusy; break;
            case AppStatus.processing: message = AppStrings.statusSuccessfull; break;
            case AppStatus.successful: message = AppStrings.statusProcess; break;
            case AppStatus.error: message = AppStrings.statusError; break;
            case AppStatus.checkError: message = AppStrings.statusCheckError; break;
        }

        return message;
    }
}

