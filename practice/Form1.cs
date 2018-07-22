using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using System.Configuration;

namespace practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected_item = listBox1.SelectedItem.ToString();
            pictureBox1.Image = Image.FromFile(selected_item);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "이미지 파일 (*.png, *.jpg) | *.png; *.jpg";
            openFileDialog1.Multiselect = true;

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                foreach (string filename in openFileDialog1.FileNames)
                {
                    listBox1.Items.Add(filename);
                }
                //String[] filenames = openFileDialog1.FileNames;
                //String filename = openFileDialog1.FileName;
                //for (int i = 0; i < filenames.Length; i++)
                //{
                //    listBox1.Items.Add(filenames);
                //}

            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

            //folderBrowserDialog1 = new FolderBrowserDialog(); //to implement a new folder browser

            //DialogResult result = folderBrowserDialog1.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    String[] allFiles = System.IO.Directory.GetFiles(folderBrowserDialog1.SelectedPath);  //store the files in the string array

            //    //String[] allFiles = System.IO.Directory.GetFiles(folderBrowserDialog1.);

            //    for (int i = 0; i < allFiles.Length; i++)
            //    {
            //        //if (allFiles.Contains(".png"))

            //        listBox1.Items.Add(allFiles[i]);         // use the for loop to continously add the file addresses to the listbox


            //    }
            //}
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
