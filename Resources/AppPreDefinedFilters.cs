using System.Linq;

namespace ResamRenamer.Resources
{
    public enum AppPreDefinedFilters
    {
        ZarFilm,
        iMovie,
        p30Download,
        soft98,
        softGozar,
    }

    public static class AppPreDefinedFiltersExtensions
    {
        public static List<AppPreDefinedFilters> GetValues() => Enum.GetValues<AppPreDefinedFilters>().ToList();
        public static string GetName(this AppPreDefinedFilters value) => GetValues().Where(p => p.ToString() == value.ToString()).FirstOrDefault().ToString();
        public static List<string> GetNames() => GetValues().Select(p => p.GetName()).ToList();

        public static List<string> GetStringList(this AppPreDefinedFilters value)
        {
            List<string> list = new List<string> { };
            switch (value)
            {
                case AppPreDefinedFilters.ZarFilm:
                    list = new List<string>
                    {
                        ".ZarFilm",
                        ".Zarfilm",
                        "-ZarFilm",
                        "-Zarfilm",
                        "_ZarFilm",
                        "_Zarfilm",
                    }; break;
                case AppPreDefinedFilters.iMovie:
                    list = new List<string>
                    {
                        "_iMovie-DL-Exclusive",
                        "_iMovie-DL",
                        "-iMovie-DL",
                    }; break;
                case AppPreDefinedFilters.p30Download:
                    list = new List<string>
                    {
                        "_www.p30download.com",
                        "www.p30download.com",
                        "_p30download.com",
                        "p30download.com",
                    }; break;
                case AppPreDefinedFilters.soft98:
                    list = new List<string>
                    {
                        "_www.soft98.ir",
                        "www.soft98.ir",
                        "_soft98.ir",
                        "soft98.ir",
                    }; break;
                case AppPreDefinedFilters.softGozar:
                    list = new List<string>
                    {
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