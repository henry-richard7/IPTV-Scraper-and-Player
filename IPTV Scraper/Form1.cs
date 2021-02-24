using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace IPTV_Scraper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        public String flagImageUrl;

        public HtmlNodeCollection countriesImages;
        public HtmlNodeCollection countriesList;
        public HtmlNodeCollection m3u8List;

        public String selectedCountry;
        public int pageNumber = 1;

        public void countries()
        {
            ImageList images = new ImageList();
            images.ImageSize = new Size(64, 64);
            images.ColorDepth = ColorDepth.Depth32Bit;

            HtmlWeb web = new HtmlWeb();
            web.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";
            HtmlAgilityPack.HtmlDocument document = web.Load("https://iptvcat.com/home_5");

            countriesImages = document.DocumentNode.SelectNodes("//td[@style='padding-left:45px;']//td[@class='no-padding-right pl-5 flag']//img");
            countriesList = document.DocumentNode.SelectNodes("//td[@style='padding-left:45px;']//td[@class='pl-5']");

            progressBar1.Maximum = countriesList.Count-1;

            for (int i = 0; i < countriesList.Count; i++)
            {
                WebClient w = new WebClient();
                web.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";
                String countryCode = countriesImages[i].Attributes["src"].Value.Replace("assets/images/flags/", "").Replace(".png", "");

                
                byte[] imageBytes = w.DownloadData("https://www.countryflags.io/" + countryCode.ToString() + "/flat/64.png");
                MemoryStream memoryStream = new MemoryStream(imageBytes, 0, imageBytes.Length);
                memoryStream.Write(imageBytes, 0, imageBytes.Length);
                Image imgs = Image.FromStream(memoryStream, true);
                images.Images.Add(imgs);

                listView1.Items.Add(countriesList[i].InnerText, i);
                progressBar1.Value = i;
            }

            listView1.LargeImageList = images;
            progressBar1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Thread thread = new Thread(countries);
            thread.Start();
            
        }

        public void getChannels(String countryID)
        {
            String url = "https://iptvcat.com/" + countryID;
            
            HtmlWeb web = new HtmlWeb();
            web.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";
            HtmlAgilityPack.HtmlDocument document = web.Load(url);

            HtmlNodeCollection channelNames = document.DocumentNode.SelectNodes("//span[@class='channel_name']");
            m3u8List = document.DocumentNode.SelectNodes("//span[@class='label label-flat border-info text-info-600 get_vlc y']");
            String totalChannels = document.DocumentNode.SelectNodes("//tr[@class='border-solid']//td")[0].InnerText;

            labelTotalChannels.Text = totalChannels;

            if(channelNames != null)
            {
                foreach (var channelName in channelNames)
                {
                    listView_channelList.Items.Add(channelName.InnerText);
                }
            }

            else
            {
                MessageBox.Show("Please Go back reached last page");
            }

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            String countryCode = countriesImages[listView1.FocusedItem.Index].Attributes["src"].Value.Replace("assets/images/flags/", "").Replace(".png", "");
            pictureCountryFlag.Load("https://www.countryflags.io/" + countryCode.ToString() + "/flat/64.png");
            panelMainUI.Visible = false;
            panel_TV_List.Visible = true;
            selectedCountry = countriesList[listView1.FocusedItem.Index].InnerText;
            labelCountryName.Text = selectedCountry;
            getChannels(countriesList[listView1.FocusedItem.Index].InnerText);
            
        }

        private void listView_channelList_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = @"C:\\Program Files\\VideoLAN\\VLC\\vlc.exe ";
                startInfo.Arguments = m3u8List[listView_channelList.FocusedItem.Index].Attributes["data-clipboard-text"].Value;
                process.StartInfo = startInfo;
                process.Start();
            }
            catch
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Environment.CurrentDirectory + @"\\Default Player\\mpv.exe";
                startInfo.Arguments = m3u8List[listView_channelList.FocusedItem.Index].Attributes["data-clipboard-text"].Value;
                process.StartInfo = startInfo;
                process.Start();
            }
            
        }

        private void buttonBackMainMenu_Click(object sender, EventArgs e)
        {
            listView_channelList.Items.Clear();
            panel_TV_List.Visible = false;
            panelMainUI.Visible = true;
        }

        private void buttonChannelPrevious_Click(object sender, EventArgs e)
        {
            if(pageNumber != 1)
            {
                listView_channelList.Items.Clear();
                pageNumber -= 1;
                getChannels(selectedCountry.ToLower() + "/" + pageNumber.ToString());
            }
            else
            {
                MessageBox.Show("Already at first page!");
            }
        }

        private void buttonChannelNext_Click(object sender, EventArgs e)
        {
            listView_channelList.Items.Clear();
            pageNumber += 1;
            getChannels(selectedCountry.ToLower()+ "/"+pageNumber.ToString());
        }
    }
}
