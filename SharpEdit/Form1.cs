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
            newPage.MaximumSize = new System.Drawing.Size(10000, 10000);
            newPage.Height = ((newPage.Height - this.Height) * -1)+10;
            newPage.Width = ((newPage.Width-this.Width) * -1)+100;
            newPage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            




        }

        private void getHeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Height.ToString());
            MessageBox.Show(richTextBox1.Height.ToString());
            MessageBox.Show(this.Width.ToString());
            MessageBox.Show(richTextBox1.Width.ToString());


        }

       
    }
}
