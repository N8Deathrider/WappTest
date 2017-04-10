using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WappTest
{
    public partial class HelloWorld : Form
    {
        public HelloWorld()
        {
            InitializeComponent();
            this.Text = "Nathan";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Yaeh";
        }

        private void btn_showMe_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog_showMe.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = openFileDialog_showMe.FileName;
                Image myImage = Image.FromFile(file);
                pic_showMe.Image = myImage;
                pic_showMe.Height = myImage.Height;
                pic_showMe.Width = myImage.Width;

                int newWidth = (HelloWorld.ActiveForm.Width - pic_showMe.Width) + myImage.Width;
                int newHeight = (HelloWorld.ActiveForm.Height - pic_showMe.Height) + myImage.Height;

                this.Size = new Size(newWidth, newHeight);
            }
        }
    }
}
