using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerPointGenerator
{
    public partial class Form1 : Form
    {
        // Links to the online images
        public List<string> imgLinkList = new List<string>();

            
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Testing resources
            ImageList il = new ImageList();
            il.Images.Add("test1", Image.FromFile(@"C:\Documents\Working\PowerPointExercise\PowerPointGenerator\PowerPointGenerator\images\bg1.jpg"));
            lstvImages.View = View.LargeIcon;
            lstvImages.LargeImageList = il;
            lstvImages.Items.Add("test");
            for (int i = 0; i < il.Images.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                lvi.Text = "tester";
                lstvImages.Items.Add(lvi);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void lstvImages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
