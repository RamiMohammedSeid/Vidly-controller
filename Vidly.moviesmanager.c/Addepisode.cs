using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB;
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
    public partial class Addepisode : Form
    {
        Action<BsonDocument, UpdateDefinition<BsonDocument>> handler;
        BsonDocument input;
        Action del;
        public Addepisode( BsonDocument input, Action<BsonDocument,UpdateDefinition<BsonDocument>> edtoradd,Action del)
        {
            InitializeComponent();
            this.input = input;
            episode_name.Text = (string)input.GetValue("episode_name","");
            episode_description.Text = (string)input.GetValue("episode_descrition","");
            episode_tile_image.Text = (string)input.GetValue("episode_image","");
            season_number.Value = int.Parse(((double)input.GetValue("season_number",1.0)).ToString());
            episode_number.Value = int.Parse(((double)input.GetValue("episode_number",1.0)).ToString());
            comming_soon.Checked = (bool)input.GetValue("comming_soon",false);
            episode_link.Text =  (string)input.GetValue("episode_link","");
           
            this.del = del;
           

            this.handler = edtoradd;
            delete_button.Visible = (this.input.GetValue("episode_id", "") != "");
        }

       



        private void button2_Click(object sender, EventArgs e)
        {
             BsonDocument output_doc = new BsonDocument{
            {"episode_name",episode_name.Text},
            {"episode_id",(this.input.GetValue("episode_id","")=="")? Guid.NewGuid().ToString():this.input.GetValue("episode_id","")},
            {"episode_descrition",episode_description.Text},
            {"episode_image",episode_tile_image.Text},
            {"episode_number",float.Parse(episode_number.Value.ToString())},
            {"season_number",float.Parse(season_number.Value.ToString())},
            {"comming_soon",comming_soon.Checked},
            {"episode_link",episode_link.Text },
            {"series_id",this.input.GetValue("series_id","")}
           };
             var update = Builders<BsonDocument>.Update;
            var updatedefinition = update.Set("episode_name", episode_name.Text)
                .Set("episode_descrition", episode_description.Text)
             .Set("episode_image", episode_tile_image.Text)
             .Set("episode_number", float.Parse(episode_number.Value.ToString()))
              .Set("season_number", float.Parse(season_number.Value.ToString()))
             .Set("episode_link", episode_link.Text)
             .Set("comming_soon", comming_soon.Checked);
             handler(output_doc, updatedefinition);
            Close();
        }

        private void Addseries_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var msg_result = MessageBox.Show("Are you sure you want to delete this season", "Deleting", MessageBoxButtons.YesNo);
            if (msg_result == DialogResult.Yes)
            {
                del();
                Close();
            }
        }
    }
}
