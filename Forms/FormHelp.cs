using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using ResamRenamer.Resources;

namespace ResamRenamer.Forms
{
    public partial class FormHelp : MaterialForm
    {
        List<MaterialButton> MenuButtons = new List<MaterialButton>();
        List<string[]> Contexts = new List<string[]>();

        HelpContent HC = new HelpContent();

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
            MaterialSkinManager materialskinmanager = Classes.UserInterface.ClassMaterialSkin.setMaterialSkinManager(this);

            fillContexts();
            InsertText(null);
        }

        void fillContexts()
        {
            Contexts.Add(HC.FirstContext);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            InsertText((MaterialButton)sender);
        }

        void InsertText(MaterialButton btn)
        {
            int index = 0;
            //Detect Button
            if (btn != null)
            {
                index = MenuButtons.IndexOf(btn);
            }
            lblTitle.Text = Contexts[index][0];
            txtInfo.Text = Contexts[index][1];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
