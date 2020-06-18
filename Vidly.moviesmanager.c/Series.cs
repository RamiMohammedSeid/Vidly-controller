using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidly.moviesmanager.c
{
    public partial class Series : UserControl
    {
        Action edc, adc, delc;
        Action<BsonDocument> eec;
        Func<MongoDB.Driver.IFindFluent <BsonDocument,BsonDocument>> retrv;
        public Series(BsonDocument series_data, Action delete_callback, Action edit_callback, Action add_episode_callback,  Action<BsonDocument> edit_episode_callback, Func<MongoDB.Driver.IFindFluent<BsonDocument, BsonDocument>> retrive_data)
        {
            InitializeComponent();
            edc = edit_callback;
            delc = delete_callback;
            adc = add_episode_callback;
            retrv = retrive_data;
            eec = edit_episode_callback;
            label1.Text = (string)series_data.GetValue("series_name");

            Label.CheckForIllegalCrossThreadCalls = false;
            Button.CheckForIllegalCrossThreadCalls = false;
            load_data();
            
        }
        public void Update_data(BsonDocument definition)
        {

            label1.Text = (string)definition.GetValue("series_name");
        }
        public void reload_episodes()
        {
            load_data();
        }
        void deleteseason()
        {
           var msg_result = MessageBox.Show("Are you sure you want to delete this season","Deleting",MessageBoxButtons.YesNo);
           if(msg_result == DialogResult.Yes){
             delc();
           }
        }
        public void add_episode(BsonDocument episode)
        {
            LinkLabel bt = new LinkLabel();
            bt.Margin = new Padding(3);
            bt.Click += (c, j) =>
            {
                eec(episode);
                load_data();
            };
            bt.AutoSize = true;
            bt.ActiveLinkColor = Color.Black;
            bt.LinkColor = Color.Black;
            bt.Text = "S" + episode.GetValue("season_number", "") + "-E" + episode.GetValue("episode_number") + "  " + episode.GetValue("episode_name");
            flowLayoutPanel1.Controls.Add(bt);
        }
        public async void load_data()
        {
            flowLayoutPanel1.Controls.Clear();
            loading_indicator.Visible = true;
            
            var data = await this.retrv().ToListAsync();
            loading_indicator.Visible = false;
            data.ForEach((episode) =>
            {
                LinkLabel bt = new LinkLabel();
                bt.Margin = new Padding(3);
                bt.Click += (c, j) =>
                {
                    eec(episode);
                    load_data();
                };
                bt.AutoSize = true;
                bt.ActiveLinkColor = Color.Black;
                bt.LinkColor = Color.Black;
                bt.Text = "S" + episode.GetValue("season_number", "") + "-E" + episode.GetValue("episode_number") + "  " + episode.GetValue("episode_name");
                flowLayoutPanel1.Controls.Add(bt);
            });
           

          
            
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            deleteseason();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adc();
            load_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edc();
        }

        private void Series_Load(object sender, EventArgs e)
        {

        }
    }
}
