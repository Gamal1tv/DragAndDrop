using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pbMain.AllowDrop = true; //set allow drop property to true
            openFileDialog1.Filter = "Image Files| *.jpg; *.jpeg; *.png"; //sets the file filter in the open dialog box
            openFileDialog1.InitialDirectory = "H:\\Students_Folder\\Grant Malone\\Coding Assets\\Visual Studio Assets\\SnackShack\\SnackStoreImages"; //opens SnackStoreImages folder when openfiledialog opens
        }

        //Code when mouse is clicked on picture box
        private void pb_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = sender as PictureBox;

            pb.DoDragDrop(pb.Image, DragDropEffects.Copy); //begins drag drop by copying image in picture box
        }

        //when mouse is dragged into pbMain
        private void pbMain_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Bitmap)) //check to see if data correct type (bitmap) if so execute:
                e.Effect = DragDropEffects.Copy; //drop effect is set to a copy of the bitmap
            else //if not execute:
                e.Effect = DragDropEffects.None; //drop effect set to nothing
        }

        //when mouse click is let go in pbMain
        private void pbMain_DragDrop(object sender, DragEventArgs e)
        {
            pbMain.Image = (Image)e.Data.GetData(DataFormats.Bitmap); //set pbMain image to copied image
        }

        //select button click event
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (cboxPbChange.Text == "Picture Box 1" || cboxPbChange.Text == "Picture Box 2" || cboxPbChange.Text == "Picture Box 3" || cboxPbChange.Text == "Picture Box 4" || cboxPbChange.Text == "Picture Box 5" || cboxPbChange.Text == "Picture Box 6") //cboc text is set to one of the given drop downs
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK) //show to open filedialog box and if the user clicks "ok" execute:
                {
                    switch (cboxPbChange.Text) //if cboxPbChange.Text says...
                    {
                        case "Picture Box 1": //"Picture Box 1"
                            pb1.Image = Image.FromFile(openFileDialog1.FileName); //set image to image selected
                            break;
                        case "Picture Box 2": //"Picture Box 2"
                            pb2.Image = Image.FromFile(openFileDialog1.FileName); //set image to image selected
                            break;
                        case "Picture Box 3": //"Picture Box 3"
                            pb3.Image = Image.FromFile(openFileDialog1.FileName); //set image to image selected
                            break;
                        case "Picture Box 4": //"Picture Box 4"
                            pb4.Image = Image.FromFile(openFileDialog1.FileName); //set image to image selected
                            break;
                        case "Picture Box 5": //"Picture Box 5"
                            pb5.Image = Image.FromFile(openFileDialog1.FileName); //set image to image selected
                            break;
                        case "Picture Box 6": //"Picture Box 6"
                            pb6.Image = Image.FromFile(openFileDialog1.FileName); //set image to image selected
                            break;
                    }
                }
            }
        }
    }
}
