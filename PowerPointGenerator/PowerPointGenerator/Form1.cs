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
        // Global Input
        public List<string> searchWords = new List<string>();

        // Links to the online images
        public List<string> imgLinkList = new List<string>();

          
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSlide_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Testing resources
            /*ImageList il = new ImageList();
            il.Images.Add("test1", Image.FromFile(@"C:\Users\issac\source\repos\issacgreenfield\PowerPointGenerator\PowerPointGenerator\PowerPointGenerator\images\bg3.jpg"));
            lstvImages.View = View.LargeIcon;
            lstvImages.LargeImageList = il;
            for (int i = 0; i < il.Images.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                lstvImages.Items.Add(lvi);
            }*/

            string titleText = txtTitle.Text.Trim();
            string slideText = txtSlide.Text.Trim();

            // Check for empty text boxes
            if (titleText.Length < 1)
            {
                MessageBox.Show("Please enter a title for your slide");
            }
                        if (slideText.Length < 1)
            {
                MessageBox.Show("Please enter the text for your slide");
            }

            string[] titleWords = titleText.Split(' ');
            for (int i = 0; i < titleWords.Length; i++)
            {
                searchWords.Add(titleWords[i]);
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
