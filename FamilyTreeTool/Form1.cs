using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GeneGenie.Gedcom;
using GeneGenie.Gedcom.Data;
using GeneGenie.Gedcom.Parser;
using GeneGenie.Gedcom.Helpers;
using GeneGenie.Gedcom.Enums;

namespace FamilyTreeTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            textBox1.Text = browse();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            Form tree = new tree(textBox1.Text, textBox2.Text);
            this.Hide();
            tree.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = browse();
        }

        public string browse()
        {
            OpenFileDialog openFileDialog1;
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "ged files (*.ged)|*.ged|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog1.FileName;
            }
            else
            {
                return "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

