using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Linq;
using System.Text;
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
        private const string twitchClientId = "t6ma91fizbc7hudx6n5z60u9vb9h42";
        private const string twitchClientSecret = "uuktleakynfo887oxt8a8h6vzfnc1s";
        private const string twitchRedirectUri = "http://localhost:8080/twitch/callback";
        private const string twichScope = "channel_read";
        public Form1()
        {

            InitializeComponent();

        }

        private async void GetFollowers(string ChannelID)
        {
            try
            {
                TwitchLib.Models.API.v5.Channels.ChannelFollowers follower = await TwitchAPI.Channels.v5.GetChannelFollowersAsync(ChannelID,limit:100,offset:800);

                foreach(var chel in follower.Follows)
                {
                    Console.WriteLine(chel.User.Name + " ");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //SetClie

            TwitchAPI.Settings.ClientId = "2jqfxtz3xg3uftjh4did7hr5wlox7e";
            string ChannelID = TwitchAPI.Settings.ClientId;



            GetFollowers("50909703");

            MessageBox.Show("lel");
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



     //Web part


        //End of webpart


    }
}
