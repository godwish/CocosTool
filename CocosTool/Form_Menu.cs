using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CocosTool
{
    public partial class Form_Menu : Form
    {
        public Form_Menu(){ InitializeComponent(); }

        private void btn_search_multy_Click(object sender, EventArgs e){ new Form1().Show(); }

        private void btn_atlas_Click(object sender, EventArgs e) { new Form_Atlas().Show(); }

        private void btn_text_Click(object sender, EventArgs e) { new Form_UUID().Show(); }

        private void btn_test_Click(object sender, EventArgs e) { new Form_Viewer().Show(); }

        private void btn_find_p3d_Click(object sender, EventArgs e) { new Form_Particle3dFinder().Show(); }

        private void btn_switch_atlas_uuid_Click(object sender, EventArgs e) { new Form_SwitchAtlasUUID().Show(); }

        private void btn_switch_uuid_Click(object sender, EventArgs e) { new Form_ChangeAtlasUUID().Show(); }

        private void btn_change_sprite_Click(object sender, EventArgs e)
        {
            //new Form_SwitchAtlasUUID().Show();
        }
    }
}
