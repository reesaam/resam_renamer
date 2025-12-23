using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResamRenamer.Resources;

namespace ResamRenamer.Resources
{
    public enum AppPreDefinedFilters
    {
        iMovie,
        p30Download,
        soft98,
        softGozar,
    }

    public static class AppPreDefinedFiltersExtensions
    {

        public static List<AppPreDefinedFilters> Values(this AppPreDefinedFilters type) => new List<AppPreDefinedFilters> {
            AppPreDefinedFilters.iMovie,
            AppPreDefinedFilters.p30Download,
            AppPreDefinedFilters.soft98,
            AppPreDefinedFilters.softGozar,

        };

        public static string GetName(this AppPreDefinedFilters value)
        {
            string message = AppStrings.empty;
            switch (value)
            {
                case AppPreDefinedFilters.iMovie: message = "iMovie"; break;
                case AppPreDefinedFilters.p30Download: message = "P30download"; break;
                case AppPreDefinedFilters.soft98: message = "Soft98"; break;
                case AppPreDefinedFilters.softGozar: message = "SoftGozar"; break;
            }

            return message;
        }

        public static List<string> GetStringList(this AppPreDefinedFilters value)
        {
            List<string> list = new List<string> { };
            switch (value)
            {
                case AppPreDefinedFilters.iMovie:
                    list = new List<string> {
                "_iMovie-DL-Exclusive",
                "_iMovie-DL",
                "-iMovie-DL",
                }; break;
                case AppPreDefinedFilters.p30Download:
                    list = new List<string> {
                "_www.p30download.com",
                "www.p30download.com",
                "_p30download.com",
                "p30download.com",
                }; break;
                case AppPreDefinedFilters.soft98:
                    list = new List<string> {
                "_www.soft98.ir",
                "www.soft98.ir",
                "_soft98.ir",
                "soft98.ir",
                }; break;
                case AppPreDefinedFilters.softGozar:
                    list = new List<string> {
                "_www.softgozar.com",
                "www.softgozar.com",
                "_softgozar.com",
                "softgozar.com",
                }; break;

            }

            return list;
        }
    }
}



