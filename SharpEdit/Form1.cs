using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage NewPage = new TabPage("Page");
            tabControl1.TabPages.Add(NewPage);
            //Need to Add rich text box and have it fill page
            RichTextBox newPage = new RichTextBox();
            NewPage.Controls.Add(newPage);

        }
    }
}
