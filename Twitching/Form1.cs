using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using TwitchLib;
using TwitchLib.Models;
using System.Diagnostics;
using WebPart;

namespace Twitching
{
    public partial class Form1 : Form
    {

        //private const string ChannelID = "50909703"; my id
        private const string ChannelID ="95229735";
        private const string twichScope = "channel_read";
        private const string  CurrentDB = "CurrentDB.txt";
        private const string NowFollowers = "NowFollowers.txt";

        List<string> CurrentFollowers = new List<string>();

        Stopwatch check = new Stopwatch();
        public Form1()
        {

            InitializeComponent();
            TwitchAPI.Settings.ClientId = "2jqfxtz3xg3uftjh4did7hr5wlox7e";
            string ChannelID = TwitchAPI.Settings.ClientId;
            if (!File.Exists(CurrentDB))
            {
                LastModifiedFile.Text += "Нет базы, обнови";
            }
            else
            {
                LastModifiedFile.Text += System.IO.File.GetLastWriteTime(CurrentDB);
                //GetFollowers("50909703", CurrentFollowers);
                CurrentFollowers = ReadFromFile(CurrentDB);
                Compare.Enabled = true;
            }

        }

        private void WriteToFile(string FileName, List<string> CurrentFollowers)
        {
            if (File.Exists(FileName))
            {
                File.Delete(FileName);
            }
            File.WriteAllLines(FileName, CurrentFollowers);

        }

        private List<string> ReadFromFile(string FileName)
        {
            List<string> TempList = File.ReadAllLines(FileName).ToList();

            return TempList;
        }

        private async void GetFollowers(string ChannelID, List<string> CurrentFollowers)
        {
            try
            {
                CurrentFollowers.Clear();
                TwitchLib.Models.API.v5.Channels.ChannelFollowers t = await TwitchAPI.Channels.v5.GetChannelFollowersAsync(ChannelID, limit: 1);

                for (int i = 0;i<t.Total;i+=100)
                {
                    TwitchLib.Models.API.v5.Channels.ChannelFollowers follower = await TwitchAPI.Channels.v5.GetChannelFollowersAsync(ChannelID, limit: 100, offset: i);
                    foreach (var chel in follower.Follows)
                    {
                        CurrentFollowers.Add(chel.User.Name);
                        //Console.WriteLine(chel.User.Name + " ");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check.Start();

            if (File.Exists(CurrentDB))
            {
                // MessageBox.Show("Est file");

                GetFollowers(ChannelID, CurrentFollowers);
                WriteToFile(CurrentDB, CurrentFollowers);
                Compare.Enabled = true;
                
            }
            else
            {
                GetFollowers(ChannelID, CurrentFollowers);
                // MessageBox.Show("Net file, pishu v nego");
                WriteToFile(CurrentDB, CurrentFollowers);
                Compare.Enabled = true;

            }
           
            check.Stop();
            // MessageBox.Show(string.Format("База обновлена {0}", check.ElapsedMilliseconds));
            LastModifiedFile.Text = " Последнее обновление базы:" + System.IO.File.GetLastWriteTime(CurrentDB);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ChannelName;
            try
            {
                ChannelName = ChannelNameBox.Text;
                if (ChannelName.Length == 0)
                    MessageBox.Show("Ты не написал своё имя");
                else
                    System.Diagnostics.Process.Start("https://www.twitch.tv/" + ChannelName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Compare_Click(object sender, EventArgs e)
        {
            List<string> FollowersNow = new List<string>();

            GetFollowers(ChannelID,FollowersNow);
            BoardOfHaters.Clear();
            var result = FollowersNow.Except(CurrentFollowers).Union(CurrentFollowers.Except(FollowersNow));

            if (!result.Any())
                MessageBox.Show("Никто не дал анфоллоу, шок");
            else
            foreach (var item in result)
            {
               BoardOfHaters.Text += item.ToString() + Environment.NewLine;
            }     
        }
    }
}
