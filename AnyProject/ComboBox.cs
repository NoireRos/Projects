using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyProject
{
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
            comboBox1.Items.Add("Apple");
            comboBox1.Items.Add("Mango");
            comboBox1.Items.Add("Apple");
        }

        private void getItemButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0 || comboBox1.SelectedIndex == 0)
            {
                string gettext = comboBox1.SelectedItem.ToString();
                MessageBox.Show(gettext);
            }
            else
            {
                MessageBox.Show("Please select an Item");
            }
        }
    }
}
