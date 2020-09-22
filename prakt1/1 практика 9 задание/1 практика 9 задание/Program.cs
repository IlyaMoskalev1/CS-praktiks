using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_практика_9_задание
{
    public partial class Form1 : Form


    {


        public Form1()


        {


            InitializeComponent();


        }





        private void browseButton_Click(object sender, EventArgs e)


        {


            OpenFileDialog ofd = new OpenFileDialog();


            ofd.ShowDialog();


            locationTextBox.Text = ofd.FileName;


        }





        private void showButton_Click(object sender, EventArgs e)


        {


            TextReader tr = new StreamReader(locationTextBox.Text);


            displayTextBox.Text = tr.ReadToEnd();


        }


    }


}