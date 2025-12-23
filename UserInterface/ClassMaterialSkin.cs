using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ResamRenamer.Classes.UserInterface
{
    public class ClassMaterialSkin
    {
        static public MaterialSkinManager setMaterialSkinManager(MaterialForm materialform)
        {
            MaterialSkinManager materialskinmanager = MaterialSkinManager.Instance;
            materialskinmanager.AddFormToManage(materialform);
            materialskinmanager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialskinmanager.ColorScheme = new ColorScheme(
                Primary.Grey600, Primary.Grey800,
                Primary.Grey600, Accent.Red400,
                TextShade.WHITE);

            return materialskinmanager;
        }
    }
}
