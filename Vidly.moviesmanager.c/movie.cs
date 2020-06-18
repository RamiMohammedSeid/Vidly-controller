using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
namespace Vidly.moviesmanager.c
{
    public partial class movie : UserControl
    {
       Action edc, delc;
        Action<BsonDocument> eec;

        public movie(BsonDocument series_data, Action delete_callback, Action edit_callback)
        {
            InitializeComponent();
            edc = edit_callback;
            delc = delete_callback;


            label1.Text = (string)series_data.GetValue("movie_name");

            Label.CheckForIllegalCrossThreadCalls = false;
            Button.CheckForIllegalCrossThreadCalls = false;
           
            
        }
        public void Update_data(  BsonDocument def)
        {
            label1.Text = (string)def.GetValue("movie_name");
        }
        private void movie_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var msg_result = MessageBox.Show("Are you sure you want to delete this season", "Deleting", MessageBoxButtons.YesNo);
            if (msg_result == DialogResult.Yes)
            {
                delc();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edc();
        }
    }
}
