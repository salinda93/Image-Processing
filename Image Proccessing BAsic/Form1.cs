using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Proccessing_BAsic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog Opfile = new OpenFileDialog();
            Opfile.Filter = "Image File (*.bmp,*.png)| *.bmp;*.png";
            if(DialogResult.OK==Opfile.ShowDialog())
            {
                this.picOriginal.Image = new Bitmap(Opfile.FileName);
            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            Bitmap coppy = new Bitmap((Bitmap)this.picOriginal.Image);

            Method.ConvertToGray(coppy);
            this.picResult.Image = coppy;
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            Bitmap coppy = new Bitmap((Bitmap)this.picOriginal.Image);

            Method.ConvertToNegative(coppy);
            this.picResult.Image = coppy;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG files(*.jpeg)|*.jpeg";// Saving files in JPEG Format
            if (DialogResult.OK == sfd.ShowDialog())
            {

                this.picResult.Image.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }
    }
}
