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
    public partial class ChangeChannel : Form
    {
        Channel channel;
        public ChangeChannel(Channel channel)
        {
            InitializeComponent();
            this.channel = channel;
            NameTextBox.Text = channel.Name;
            UrlTextBox.Text = channel.Url;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            channel.Name = NameTextBox.Text;
            channel.Url = UrlTextBox.Text;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
