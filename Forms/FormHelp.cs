
using System.Runtime.InteropServices;
using MaterialSkin;
using MaterialSkin.Controls;
using ResamRenamer.Resources;

namespace ResamRenamer.Forms
{
    public partial class FormHelp : MaterialForm
    {
        private List<MaterialButton> MenuButtons = new List<MaterialButton>();
        private List<string[]> Contexts = new List<string[]>();

        private HelpContent HelpContent = new HelpContent();

        public FormHelp()
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

            //MaterialSkinmanager Variable
            MaterialSkinManager materialskinmanager = Classes.UserInterface.ClassMaterialSkin.SetMaterialSkinManager(this);

            FillContexts();
            InsertText(null);
        }

        private void FillContexts()
        {
            Contexts.Add(HelpContent.FirstContext);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            InsertText((MaterialButton)sender);
        }

        void InsertText(MaterialButton btn)
        {
            int index = 0;
            index = MenuButtons.IndexOf(btn);
            lblTitle.Text = Contexts[index][0];
            txtInfo.Text = Contexts[index][1];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
