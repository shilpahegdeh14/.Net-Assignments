using System;
using System.Windows.Forms;

namespace Assignment4_Shilpa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "My Hobby(ies) is/are: ";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s =checkedListBox1.SelectedItem.ToString();
            label1.Text=label1.Text + " " + s;
        }
    }
}
