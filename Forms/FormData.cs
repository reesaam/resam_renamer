using System.Runtime.InteropServices;
using MaterialSkin;
using MaterialSkin.Controls;
using ResamRenamer.Resources;

namespace ResamRenamer.Forms
{
    public partial class FormData : MaterialForm
    {
        List<DirectoryInfo> directories = new List<DirectoryInfo>();
        List<FileInfo> files = new List<FileInfo>();
        public FormData(string dirAddress, bool subDirectories, bool isSeriesList, bool isMovieList)
        {
            InitializeComponent();

            //RoundedRectangleForm
            [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            static extern IntPtr CreateRoundRectRgn(
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            //MaterialSkin Manager Variable
            MaterialSkinManager materialSkinManager = Classes.UserInterface.ClassMaterialSkin.SetMaterialSkinManager(this);
            FormInitialization(dirAddress , subDirectories, isSeriesList, isMovieList);
        }
        private void FormInitialization(string dirAddress,  bool subDirectories, bool isSeriesList, bool isMovieList)
        {
            // TEMP
            btnExport.Enabled = false;
            //
            DirectoryInfo dirInfo = new DirectoryInfo(dirAddress);
            var result = GetFilesAndDirectories(dirInfo, subDirectories);
            directories = result.directories;
            files = result.files;
            lblDataDirCount.Text = directories.Count.ToString();
            lblDataFileCount.Text = files.Count.ToString();
            if (isSeriesList || isMovieList) SetDataList(dirAddress, isSeriesList, isMovieList);
        }

        (List<DirectoryInfo> directories, List<FileInfo> files) GetFilesAndDirectories(DirectoryInfo directory,  bool subDirectories)
        {
            List<DirectoryInfo> innerDirectories = new List<DirectoryInfo>();
            List<FileInfo> innerFiles = new List<FileInfo>();
            var tempDirs = directory.GetDirectories().ToList();
            innerDirectories.AddRange(tempDirs);
            innerFiles.AddRange(directory.GetFiles().ToList());
            if (subDirectories)
            {
                if (tempDirs.Any())
                {
                    foreach (DirectoryInfo dir in tempDirs)
                    {
                        var result = GetFilesAndDirectories(dir,  subDirectories);
                        innerDirectories.AddRange(result.directories);
                        innerFiles.AddRange(result.files);
                    }
                }
            }

            return (innerDirectories, innerFiles);
        }

        void SetDataList(string dirAddress, bool isSeriesList, bool isMovieList)
        {
            const string seasonText = "Season";
            const string episodeText = "Episode";
            
            string data = "Directory Path:\r\n  " +  dirAddress + "\r\n\r\n";
            txtDataList.Enabled = txtDataList.Visible = true;
            
            DirectoryInfo listDirInfo = new DirectoryInfo(dirAddress);
            List<DirectoryInfo> listDirectories = listDirInfo.GetDirectories().ToList();
            foreach (DirectoryInfo dir in listDirectories)
            {
                data += dir.Name;
                if (isSeriesList)
                {
                    int seasons = dir.GetDirectories().ToList().FindAll(d => d.Name.Contains(seasonText)).Count;
                    Addtext((seasons.ToString() + AppStrings.Space + (seasons < 2 ? seasonText : (seasonText + "s"))));
                }

                var fs = GetFilesAndDirectories(dir, true);
                int episodes = fs.files.FindAll(info => AppConstants.SupportedFormatsVideo.Contains(info.Extension)).Count;
                Addtext((episodes.ToString() + AppStrings.Space + (episodes < 2 ? episodeText : (episodeText + "s"))));
                
                bool includeSubtitle = fs.files.Exists(info => AppConstants.SupportedFormatsSubtitle.Contains(info.Extension));
                if (includeSubtitle) Addtext(("Includes Subtitles"));
                data += "\r\n";
            }

            txtDataList.Text = data;

            void Addtext(string text)
            {
                data += "  " + "(" + text + ")";
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string text = txtDataList.Text;
            if (text != AppStrings.Empty)
            {
                Clipboard.SetText(text);
                MessageBox.Show(AppStrings.MessageCopyClipboard);
            }
            else
            {
                MessageBox.Show(AppStrings.MessageCopyClipboardEmpty);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DISABLED");
        }
    }
}
