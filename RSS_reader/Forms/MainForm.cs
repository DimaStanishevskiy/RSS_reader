using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Net;

namespace RSS_reader
{
    public partial class MainForm : Form
    {

        ImageOfChanel imageChanel = new ImageOfChanel();

        Items[] articles;

        ChannelClass channel = new ChannelClass();
 
        public MainForm()
        {
            InitializeComponent();
        }

        //блокировка главного окна модальным окном регистрации/авторизации
        private void MainForm_Load(object sender, EventArgs e)
        {
            AuthenticationForm form = new AuthenticationForm();
            form.ShowDialog();
        }

        bool getNewMessage(string url)
        {
            try
            {
                WebRequest wr = WebRequest.Create(url);

                wr.Proxy.Credentials = CredentialCache.DefaultCredentials;

                XmlTextReader xtr = new XmlTextReader(wr.GetResponse().GetResponseStream());

                XmlDocument doc = new XmlDocument();
                doc.Load(xtr);

                XmlNode root = doc.DocumentElement;

                articles = new Items[root.SelectNodes("/rss/channel/item").Count];

                XmlNodeList nodeList;
                nodeList = root.ChildNodes;

                int count = 0;

                foreach (XmlNode chanel in nodeList)
                {
                    foreach (XmlNode chanel_item in chanel)
                    {
                        if (chanel_item.Name == "title")
                        {
                            channel.title = chanel_item.InnerText;
                        }
                        if (chanel_item.Name == "description")
                        {
                            channel.description = chanel_item.InnerText;
                        }
                        if (chanel_item.Name == "copyright")
                        {
                            channel.copyright = chanel_item.InnerText;
                        }
                        if (chanel_item.Name == "link")
                        {
                            channel.link = chanel_item.InnerText;
                        }
                        if (chanel_item.Name == "img")
                        {
                            XmlNodeList imgList = chanel_item.ChildNodes;
                            foreach (XmlNode img_item in imgList)
                            {
                                if (img_item.Name == "url")
                                {
                                    imageChanel.imgURL = img_item.InnerText;
                                }
                                if (img_item.Name == "link")
                                {
                                    imageChanel.imgLink = img_item.InnerText;
                                }
                                if (img_item.Name == "title")
                                {
                                    imageChanel.imgTitle = img_item.InnerText;
                                }
                            }
                        }
                        if (chanel_item.Name == "item")
                        {
                            XmlNodeList itemsList = chanel_item.ChildNodes;
                            articles[count] = new Items();

                            foreach (XmlNode item in itemsList)
                            {
                                if (item.Name == "title")
                                {
                                    articles[count].title = item.InnerText;
                                }
                                if (item.Name == "link")
                                {
                                    articles[count].link = item.InnerText;
                                }
                                if (item.Name == "description")
                                {
                                    articles[count].description = item.InnerText;
                                }
                                if (item.Name == "pubDate")
                                {
                                    articles[count].pubDate = item.InnerText;
                                }
                            }
                            count += 1;
                        }
                    }
                }
                return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка получения данных : " + exc.Message);
                return false;
            }
        }

        bool generateHtml()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Message.html"))
                {
                    writer.WriteLine("");
                    writer.WriteLine("");
                    writer.WriteLine("<meta charset= \"utf-8\">");
                    //writer.WriteLine("<meta http-equiv=\" content-type\"=\" content=\"\" text=\"\" html;=\"\" charset=\"utf - 8\">");                   
                    writer.WriteLine("<title>");
                    writer.WriteLine(channel.title);
                    writer.WriteLine("</title>");

                    writer.WriteLine("<style type=\"text / css\">");
                    writer.WriteLine("A{color:#483D8B; text-decoration:none; font:Verdana;}");
                    writer.WriteLine("pre{font-family:courier;color:#000000;");
                    writer.WriteLine("background-color:#dfe2e5;padding-top:5pt;padding-left:5pt;");
                    writer.WriteLine("padding-bottom:5pt;border-top:1pt solid #87A5C3;");
                    writer.WriteLine("border-bottom:1pt solid #87A5C3;border-left:1pt solid #87A5C3;");
                    writer.WriteLine("border-right : 1pt solid #87A5C3; text-align : left;}");
                    writer.WriteLine("</style>");
                    writer.WriteLine("");
                    writer.WriteLine("");

                    writer.WriteLine("<font size=\" 2\" face=\" verdana\">");
                    writer.WriteLine("<a href=" + imageChanel.imgLink + ">");
                    writer.WriteLine("<img src=" + imageChanel.imgURL + "></a>  ");

                    writer.WriteLine("<a href = " + channel.link +">" +
                                     "<h2 align=\" center\">" + channel.title + "</h2></a>");

                    writer.WriteLine("<h3 align=\" center\">" + channel.description + "</h3>");

                    writer.WriteLine("");
                    int count_element = 0;
                    listBox1.Items.Clear();
                    foreach (Items article in articles)
                    {
                        writer.WriteLine("");
                        writer.WriteLine("");
                        writer.WriteLine("");                
                        listBox1.Items.Add(count_element + ". " + article.title + " (" + article.pubDate + ")");              
                        count_element++;
                        writer.WriteLine("<table width=\" 80% \"=\" align=\" center\"=\" border=\"1\"><tbody><tr><td>");

                        writer.WriteLine("<a href = " + article.link + "><b>" + count_element + ". " + article.title + "</b></a>");

                        writer.WriteLine("& (" + article.pubDate + ")");

                    writer.WriteLine(@"");
                        writer.WriteLine("<table width=\" 95%\"=\" align=\" center\"=\" border=\"0\"><tbody><tr><td>");

                        writer.WriteLine(article.description);

                        writer.WriteLine("</td></tr></tbody></table>");

                        writer.WriteLine("<a href = " + article.link + ">");

                        writer.WriteLine(@"<font size="" 2""="" right""="">Читать дальше >>> </font></a>");

                        writer.WriteLine("</td></tr></tbody></table>");

                        writer.WriteLine(@"<p align="" center""="">");
                        writer.WriteLine("<a href = " +  channel.link + ">"
                             + channel.copyright + "</a></p>");
                        writer.WriteLine("</font>");
                        writer.WriteLine("");
                        writer.WriteLine("");

                    }
         
                   

                    label2.Text = "Всего сообщений: " + count_element.ToString();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (getNewMessage(textBox1.Text) == true && generateHtml() == true)
            {
                webBrowser1.Navigate(Environment.CurrentDirectory + "\\Message.html");
            }
        }

    }
}
