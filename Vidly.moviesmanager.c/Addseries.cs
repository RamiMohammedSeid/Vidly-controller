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
    public partial class Addseries : Form
    {
        Action<BsonDocument, UpdateDefinition<BsonDocument>> handler;
        BsonDocument input;
        public Addseries( BsonDocument input, Action<BsonDocument,UpdateDefinition<BsonDocument>> edtoradd)
        {
            InitializeComponent();
            this.input = input;
            series_name.Text = (string)input.GetValue("series_name","");
            series_description.Text = (string)input.GetValue("series_descrition","");
            series_image_url.Text = (string)input.GetValue("series_image","");
            series_tile_image.Text = (string)input.GetValue("series_tile_image","");
            series_seasons_length.Value = int.Parse(((double)input.GetValue("seasons_length",1.0)).ToString());
            comming_soon.Checked = (bool)input.GetValue("comming_soon",false);
            series_tags.Text = (string)input.GetValue("series_tags","");
            trailer_link.Text = (string)input.GetValue("trailer_link", "");
            type.SelectedIndex = (int)input.GetValue("type", 0);


            this.handler = edtoradd;
        }

       



        private void button2_Click(object sender, EventArgs e)
        {
             BsonDocument output_doc = new BsonDocument{
            {"series_name",series_name.Text},
            {"series_id",(this.input.GetValue("series_id","")=="")? Guid.NewGuid().ToString():this.input.GetValue("series_id","")},
            {"series_descrition",series_description.Text},
            {"series_image",series_image_url.Text},
            {"series_tile_image",series_tile_image.Text},
            {"seasons_length",float.Parse(series_seasons_length.Value.ToString())},
            {"comming_soon",comming_soon.Checked},
            {"series_tags",series_tags.Text.Replace(" ","")},
            {"trailer_link",trailer_link.Text} ,
            {"type",type.SelectedIndex}
           };
             var update = Builders<BsonDocument>.Update;
            var updatedefinition = update.Set("series_name", series_name.Text).Set("series_descrition", series_description.Text)
             .Set("series_image", series_image_url.Text)
             .Set("series_tile_image", series_tile_image.Text)
             .Set("seasons_length", float.Parse(series_seasons_length.Value.ToString()))
             .Set("series_tags", series_tags.Text.Replace(" ", ""))
             .Set("comming_soon", comming_soon.Checked)
             .Set("trailer_link", trailer_link.Text)
             .Set("type", type.SelectedIndex);
             handler(output_doc, updatedefinition);
            Close();
        }

        private void Addseries_Load(object sender, EventArgs e)
        {

        }
    }
}
