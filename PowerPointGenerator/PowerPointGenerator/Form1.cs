using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace PowerPointGenerator
{
    public partial class Form1 : Form
    {
        // Global Input
        public List<string> searchWords = new List<string>();

        // Google Api Key and search engine
        public string API_KEY = "AIzaSyCvkBd_V0rtryLBdl2PhCiZlzsNryX_0hw";
        public string CX = "015675127486788194367:dg6ulavfzom";
        public const int MAX_RESULTS = 500; // Keep the search down to what is necesary
        private const int RESULTS_PER_QUERY = 20;


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
            // If the Bold checkbox is checked, any new words are bolded
            if (cbBold.Checked)
            {
                txtSlide.Font = new Font(txtSlide.Font, FontStyle.Bold);
            }
            else
            {
                txtSlide.Font = new Font(txtSlide.Font, FontStyle.Regular);
            }
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

            // Clear the previous search first thing
            searchWords.Clear();

            // Grab the text
            string titleText = txtTitle.Text.Trim();
            string slideText = txtSlide.Text.Trim();

            // Check for empty text boxes

            if (titleText.Length < 1)
            {
                MessageBox.Show("Please enter a title for your slide");
                return;
            }
            else if (slideText.Length < 1)
            {
                MessageBox.Show("Please enter the text for your slide");
                return;
            }
            else
            {
                // Parse out the search terms and add them to the list
                string[] titleWords = titleText.Split(' ');
                for (int i = 0; i < titleWords.Length; i++)
                {
                    searchWords.Add(titleWords[i]);
                }
                string[] slideWords = slideText.Split(' '); //TODO: pull bold words out
                for (int i = 0; i < slideWords.Length; i++)
                {
                    searchWords.Add(slideWords[i]);
                }







            }

            var request = WebRequest.Create("http://www.gravatar.com/avatar/6810d91caff032b202c50701dd3af745?d=identicon&r=PG");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pctb1.Image = Bitmap.FromStream(stream);
            }
            pctb2.ImageLocation = "http://www.gravatar.com/avatar/6810d91caff032b202c50701dd3af745?d=identicon&r=PG";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void lstvImages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
