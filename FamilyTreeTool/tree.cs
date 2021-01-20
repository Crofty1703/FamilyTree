using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneGenie.Gedcom;
using GeneGenie.Gedcom.Data;
using GeneGenie.Gedcom.Parser;
using GeneGenie.Gedcom.Helpers;
using GeneGenie.Gedcom.Enums;
using Nevron.Nov.Diagram;

namespace FamilyTreeTool
{
    public partial class tree : Form
    {
        static GedcomDatabase tree1;
        public static void ctree(string file)
        {
            var gedcomReader = GedcomRecordReader.CreateReader(file);
            tree1 = gedcomReader.Database;
        }
        public tree(string file)
        {
            InitializeComponent();

            ctree(file);
        }

        private void tree_Load(object sender, EventArgs e)
        {

        }
    }
}
