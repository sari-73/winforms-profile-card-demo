using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_city.Text = "Select Your City:";
            cb_city.Items.AddRange(new string[] {
                "Sanaa",
                "Aden",
                "Ibb",
                "Taiz",
            });

            list_hobbies.ValueMember = "value";
            list_hobbies.DisplayMember = "key";
            list_hobbies.DataSource = new List<KeyValuePair<string, int>>()
            {
                new KeyValuePair<string, int>("Motorrcycling", 1),
                new KeyValuePair<string, int>("Swimming", 2),
                new KeyValuePair<string, int>("Chess", 3),
                new KeyValuePair<string, int>("Peotry", 4),
                new KeyValuePair<string, int>("Writing", 5),
                new KeyValuePair<string, int>("Cooking", 6),
            };
        }


        private string yourPicPath = "";

        private void btn_browse_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //meassageBox.show.getExtenstion(openFileDialog1.FileName);
                System.IO.File.Copy(openFileDialog1.FileName, "" + openFileDialog1.SafeFileName, true);
                yourPicPath = "" + openFileDialog1.SafeFileName;
                pb_submitedPic.Image = new Bitmap(yourPicPath);

            }
            else
            {
                MessageBox.Show("Please choose a pic!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            lbl_fisrtname.Text = txt_firstName.Text;
            lbl_lastname.Text = txt_lastName.Text;
            lbl_mobileNo.Text = txt_mobileNo.Text;
            lbl_city.Text = (cb_city.SelectedIndex > -1) ? cb_city.SelectedItem.ToString() : "";
            string hobbies = "";
            for (int i = 0; i < list_hobbies.SelectedItems.Count; i++)
            {
                hobbies += ((KeyValuePair<string, int>)list_hobbies.SelectedItems[i]).Key + ", ";
            }
            lbl_hobbies.Text = hobbies;
            lbl_gender.Text = (rb_male.Checked) ? "Male" : "Female";
            string subjects = "";
            if (cb_english.Checked) subjects += "English, ";
            if (cb_math.Checked) subjects += "Math, ";
            if (cb_programming.Checked) subjects += "Programming, ";
            if (cb_design.Checked) subjects += "Design, ";
            lbl_subject.Text = subjects;
            pb_printedPic.Image = (!string.IsNullOrEmpty(yourPicPath)) ? new Bitmap(yourPicPath) : null;
            
        }
        private Bitmap memoryImage;








        private void btn_print_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(150, 0, this.Size.Width, this.Size.Height);
            memoryImage = new Bitmap(this.Size.Width + 150, this.Size.Height);
            this.DrawToBitmap(memoryImage, rect);
            this.printDialog1.Document = this.printDocument1;
            if (this.printDialog1.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }



    }

    }


