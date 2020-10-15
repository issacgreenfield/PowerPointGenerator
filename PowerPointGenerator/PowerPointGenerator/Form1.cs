using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        public string CX = "984691d179c2cd67f"; //TODO: modify this to better suit the needs of the app
        
        // Links to the online images
        public List<string> imgLinkList = new List<string>();

        // PictureBoxes Array 
        public PictureBox[] pictureBoxes;        

          
        public Form1()
        {
            InitializeComponent();
            pictureBoxes = new PictureBox[] { pctb1, pctb2, pctb3, pctb4, pctb5, pctb6, pctb7, pctb8, pctb9, pctb10 };
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
                //Create the query
                string search_query = "image";  //TODO:modify this to take search terms
                foreach (string term in searchWords)
                {
                    search_query = search_query + "+" + term;
                }

                //Read in JSON object from Google Api
                WebClient webClient = new WebClient();
                webClient.Headers.Add("user-agent", "Only a test!");
                var results = webClient.DownloadString(String.Format("https://www.googleapis.com/customsearch/v1?key={0}&cx={1}&q={2}&searchtype=image&alt=json", API_KEY, CX, search_query));
                //Deserialize JSON object
                var results_obj = JsonConvert.DeserializeObject<JObject>(results);
                foreach (JObject item in results_obj["items"])
                {
                    // Check if it is valid
                    if (item["pagemap"] != null)
                    {
                        var newitem = item["pagemap"];
                        if (newitem["cse_thumbnail"] != null)
                        { 
                            //Add image link to list
                            imgLinkList.Add(newitem["cse_thumbnail"][0]["src"].ToString());
                        }
                    }
                }
                foreach (PictureBox picturebox in pictureBoxes)
                {
                    if (imgLinkList.Count > 0)
                    {
                        picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                        picturebox.ImageLocation = imgLinkList[0];
                        imgLinkList.RemoveAt(0);
                    }
                    else
                    {
                        return;
                    }
                }
                this.lblVerifySelection.Text = "Please select an Image and 'Create Slide', or try searching again.";

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
