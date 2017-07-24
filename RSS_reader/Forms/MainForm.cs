using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Net;
using RSS_reader.Classes;
using RSS_reader.Models;
using RSS_reader.Forms;
using System.Collections.Generic;

namespace RSS_reader
{
    public partial class MainForm : Form
    {

        private List<Collection> collections;
        private List<Channel> channels;

        public MainForm()
        {
            InitializeComponent();
            Authentication();
        }

        //блокировка главного окна модальным окном регистрации/авторизации

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = InterplayForServer.Logout();
            
            Authentication();
        }

        private void Authentication()
        {
            AuthenticationForm form = new AuthenticationForm();
            form.ShowDialog();
            FindCollections();
        }

        private void AddCollectionButton_Click(object sender, EventArgs e)
        {
            Collection collection = new Collection();
            ChangeCollection form = new ChangeCollection(collection);
            form.ShowDialog();
            InterplayForServer.CreateCollection(collection.Name);
            FindCollections();
        }

        private void DeleteCollectionButton_Click(object sender, EventArgs e)
        {
            InterplayForServer.DeleteCollection(collections[CollectionsListBox.SelectedIndex]);
            FindCollections();
        }

        private void RenameCollectionButton_Click(object sender, EventArgs e)
        {
            Collection collection = collections[CollectionsListBox.SelectedIndex];
            ChangeCollection form = new ChangeCollection(collection);
            form.ShowDialog();
            InterplayForServer.UpdateCollection(collection);
            FindCollections();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FindCollections();
        }

        private void FindCollections()
        {
            collections = InterplayForServer.FindCollections();
            CollectionsListBox.DataSource = collections;
        }

        private void FindChanels()
        {
            channels = InterplayForServer.FindChannels(collections[CollectionsListBox.SelectedIndex]);
            ChannelListBox.DataSource = channels;
        }

        private void CollectionsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            FindChanels();
        }

        private void AddChannelBox_Click(object sender, EventArgs e)
        {
            Channel item = new Channel();
            ChangeChannel form = new ChangeChannel(item);
            form.ShowDialog();
            InterplayForServer.CreateChannel(item.Name, item.Url, collections[CollectionsListBox.SelectedIndex]);
            FindChanels();
        }

        private void DeleteChannelButton_Click(object sender, EventArgs e)
        {
            InterplayForServer.DeleteChannel(channels[ChannelListBox.SelectedIndex]);
            FindCollections();
        }

        private void RenameChannelButton_Click(object sender, EventArgs e)
        {
            Channel item = channels[ChannelListBox.SelectedIndex];
            ChangeChannel form = new ChangeChannel(item);
            form.ShowDialog();
            InterplayForServer.UpdateChannel(item);
            FindChanels();
        }

        private void ChannelListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Channel news = InterplayForServer.Loadnews(channels[ChannelListBox.SelectedIndex]);
            DisplayHtml(CreateHTML(news));
        }

        private string CreateHTML(Channel channel)
        {
            string result = "<html><body>";
            if (channel.News != null)
            {
                foreach (News item in channel.News)
                {
                    result += "<h2>" + item.Title + "</h2>";
                    result += "<a href=\"" + item.Link + "\">Read more... </a>";
                    result += "<p>" + item.Content + "</p>";
                    result += "<hr/>";
                }
            }
            else
            {
                result += "<h2>Sorry, there was an error</h2>";
            }
            result += "</html></body>";
            return result;
        }
        private void DisplayHtml(string html)
        {
            webBrowser.Navigate("about:blank");
            if (webBrowser.Document != null)
            {
                webBrowser.Document.Write(string.Empty);
            }
            webBrowser.DocumentText = html;
        }
    }
}
