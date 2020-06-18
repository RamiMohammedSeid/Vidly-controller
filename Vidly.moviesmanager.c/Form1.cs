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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IMongoCollection<BsonDocument> series, episodes,movies;
        private void Form1_Load(object sender, EventArgs e)
        {


            var client = new MongoClient("mongodb://rami:1234@vidly-cluster-shard-00-00-xhpaw.gcp.mongodb.net:27017,vidly-cluster-shard-00-01-xhpaw.gcp.mongodb.net:27017,vidly-cluster-shard-00-02-xhpaw.gcp.mongodb.net:27017/vidly-db?ssl=true&replicaSet=Vidly-cluster-shard-0&authSource=admin&retryWrites=true&w=majority");
           var database = client.GetDatabase("vidly-db");
            series = database.GetCollection<BsonDocument>("vidly-series");
            episodes = database.GetCollection<BsonDocument>("vidly-episodes");
            movies = database.GetCollection<BsonDocument>("vidly-movies");
            load_data(); 
        }
        void addlist2(BsonDocument movie)
        {
            movie movie_item = null;
            movie_item = new movie(movie, 
                
            () => {
                movies.DeleteOne(movie);
                flowLayoutPanel2.Controls.Remove(movie_item);
            }
            
            , 
            
            () => {
                AddMovies mov = new AddMovies(movie, (output, update) => {
                    var filter = Builders<BsonDocument>.Filter.Eq("movie_id", movie.GetValue("movie_id"));
                    movies.UpdateOne(filter, update);
                    System.Threading.Thread.Sleep(500);
                    movie_item.Update_data(output);
                    movie = output;

                });
                mov.ShowDialog();
            }
            
            );
            flowLayoutPanel2.Controls.Add(movie_item);
        }
        void addlist1(BsonDocument series_movie)
        {

            Series series_item = null;
            series_item = new Series(series_movie,
            () =>
            {
                //Callback for delete
                series.DeleteOne(series_movie);
                flowLayoutPanel1.Controls.Remove(series_item);
            },

            () =>
            {
                //Callback for edit
                Addseries addseries_dialog = new Addseries(series_movie, (output, update) =>
                {
                    var filter = Builders<BsonDocument>.Filter.Eq("series_id", series_movie.GetValue("series_id"));


                    series.UpdateOne(filter, update);
                    System.Threading.Thread.Sleep(500);
                    series_item.Update_data(output);
                    series_movie = output;

                });
                addseries_dialog.ShowDialog();
            },

            () =>
            {
                //Calback for add episode
                Addepisode episode_add_dialog = new Addepisode(new BsonDocument { { "series_id", series_movie.GetValue("series_id") } }, (output, update) =>
                {
                    episodes.InsertOne(output);
                    series_item.add_episode(output);
                }, () =>
                {

                });

                episode_add_dialog.ShowDialog();
            },
            (BsonDocument doc) =>
            {
                Addepisode episode_edit_dialog = new Addepisode(doc, (output, update) =>
                {

                    var filter = Builders<BsonDocument>.Filter.Eq("episode_id", doc.GetValue("episode_id"));


                    episodes.UpdateOne(filter, update);
                    series_item.reload_episodes();


                }, () => { episodes.DeleteOne(doc); });
                episode_edit_dialog.ShowDialog();
            }
             ,
            () =>
            {
                // Retrive episode data
                return episodes.Find(
                    new BsonDocument { { "series_id", series_movie.GetValue("series_id").ToString() } });
            });
            flowLayoutPanel1.Controls.Add(series_item);
        }
        async void load_data()
        {
            loading_indicator.Visible = true;

            var series_list = await series.Find(new BsonDocument { }).ToListAsync();
           loading_indicator.Visible = false;

           flowLayoutPanel1.Controls.Clear();
           series_list.ForEach((series_movie) => {

               addlist1(series_movie);
               
           });

           Loadingindicator2.Visible = true;

           var movie_list = await movies .Find(new BsonDocument { }).ToListAsync();
           Loadingindicator2.Visible = false;

           flowLayoutPanel2.Controls.Clear();
           movie_list.ForEach((movie) =>
           {

               addlist2(movie);

           });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Addseries addseries_dialog = new Addseries(new BsonDocument { }, (output,update) =>
            {
                series.InsertOne(output);
                MessageBox.Show("Successfully configured a new series "+
                    " name : " + output.GetValue("series_name"));
                addlist1(output);
            });
            addseries_dialog.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            load_data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddMovies addseries_dialog = new AddMovies(new BsonDocument { }, (output, update) =>
            {
                movies.InsertOne(output);
                MessageBox.Show("Successfully configured a new series " +
                    " name : " + output.GetValue("movie_name"));
                addlist2(output);
            });
            addseries_dialog.ShowDialog();
        }
    }
}
