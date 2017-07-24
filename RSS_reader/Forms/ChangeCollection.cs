using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSS_reader.Models;

namespace RSS_reader.Forms
{
    public partial class ChangeCollection : Form
    {
        private Collection collection;
        public ChangeCollection(Collection collection)
        {
            InitializeComponent();
            this.collection = collection;
            NameTextBox.Text = collection.Name;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.collection.Name = NameTextBox.Text;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
