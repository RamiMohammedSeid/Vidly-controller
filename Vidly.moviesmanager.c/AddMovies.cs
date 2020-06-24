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
    public partial class AddMovies : Form
    {
        Action<BsonDocument, UpdateDefinition<BsonDocument>> handler;
        BsonDocument input;
        public AddMovies(BsonDocument input, Action<BsonDocument, UpdateDefinition<BsonDocument>> edtoradd)
        {
            InitializeComponent();
            this.input = input;
            series_name.Text = (string)input.GetValue("movie_name","");
            series_description.Text = (string)input.GetValue("movie_descrition", "");
            series_image_url.Text = (string)input.GetValue("movie_image", "");
            series_tile_image.Text = (string)input.GetValue("movie_tile_image", "");
            comming_soon.Checked = (bool)input.GetValue("comming_soon",false);
            series_tags.Text = (string)input.GetValue("movie_tags", "");
            trailer_link.Text = (string)input.GetValue("trailer_link", "");
            type.SelectedIndex = (int)input.GetValue("type",0);

            this.handler = edtoradd;
        }

       



        private void button2_Click(object sender, EventArgs e)
        {
             BsonDocument output_doc = new BsonDocument{
            {"movie_name",series_name.Text},
            {"movie_id",(this.input.GetValue("movie_id","")=="")? Guid.NewGuid().ToString():this.input.GetValue("movie_id","")},
            {"movie_descrition",series_description.Text},
            {"movie_image",series_image_url.Text},
            {"movie_tile_image",series_tile_image.Text},
            {"comming_soon",comming_soon.Checked},
            {"movie_tags",series_tags.Text.Replace(" ","")},
            {"trailer_link",trailer_link.Text} ,
            {"type",type.SelectedIndex}
           };
             var update = Builders<BsonDocument>.Update;
             var updatedefinition = update.Set("movie_name", series_name.Text).Set("movie_descrition", series_description.Text)
             .Set("movie_image", series_image_url.Text)
             .Set("movie_tile_image", series_tile_image.Text)
             .Set("movie_tags", series_tags.Text.Replace(" ", ""))
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
