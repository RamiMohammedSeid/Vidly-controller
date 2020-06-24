namespace Vidly.moviesmanager.c
{
    partial class Addseries
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.series_name = new System.Windows.Forms.TextBox();
            this.series_image_url = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.series_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.series_tags = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.series_seasons_length = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.series_tile_image = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comming_soon = new System.Windows.Forms.CheckBox();
            this.trailer_link = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.series_seasons_length)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // series_name
            // 
            this.series_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.series_name.Location = new System.Drawing.Point(10, 35);
            this.series_name.Name = "series_name";
            this.series_name.Size = new System.Drawing.Size(235, 20);
            this.series_name.TabIndex = 1;
            // 
            // series_image_url
            // 
            this.series_image_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.series_image_url.Location = new System.Drawing.Point(10, 77);
            this.series_image_url.Name = "series_image_url";
            this.series_image_url.Size = new System.Drawing.Size(235, 20);
            this.series_image_url.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "image url";
            // 
            // series_description
            // 
            this.series_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.series_description.Location = new System.Drawing.Point(10, 201);
            this.series_description.Multiline = true;
            this.series_description.Name = "series_description";
            this.series_description.Size = new System.Drawing.Size(235, 94);
            this.series_description.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "series description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // series_tags
            // 
            this.series_tags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.series_tags.Location = new System.Drawing.Point(10, 315);
            this.series_tags.Name = "series_tags";
            this.series_tags.Size = new System.Drawing.Size(235, 20);
            this.series_tags.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "series tags, separated by ;";
            // 
            // series_seasons_length
            // 
            this.series_seasons_length.Location = new System.Drawing.Point(10, 356);
            this.series_seasons_length.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.series_seasons_length.Name = "series_seasons_length";
            this.series_seasons_length.Size = new System.Drawing.Size(61, 20);
            this.series_seasons_length.TabIndex = 8;
            this.series_seasons_length.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "series seasons length";
            // 
            // series_tile_image
            // 
            this.series_tile_image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.series_tile_image.Location = new System.Drawing.Point(10, 119);
            this.series_tile_image.Name = "series_tile_image";
            this.series_tile_image.Size = new System.Drawing.Size(235, 20);
            this.series_tile_image.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "tile image url";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "configure";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comming_soon
            // 
            this.comming_soon.AutoSize = true;
            this.comming_soon.Location = new System.Drawing.Point(10, 382);
            this.comming_soon.Name = "comming_soon";
            this.comming_soon.Size = new System.Drawing.Size(190, 17);
            this.comming_soon.TabIndex = 13;
            this.comming_soon.Text = "Check for making \"comming soon\"";
            this.comming_soon.UseVisualStyleBackColor = true;
            // 
            // trailer_link
            // 
            this.trailer_link.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trailer_link.Location = new System.Drawing.Point(10, 160);
            this.trailer_link.Name = "trailer_link";
            this.trailer_link.Size = new System.Drawing.Size(235, 20);
            this.trailer_link.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "trailer streaming link";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Type";
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Most rated",
            "Most liked",
            "Newest"});
            this.type.Location = new System.Drawing.Point(10, 417);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(235, 21);
            this.type.TabIndex = 18;
            // 
            // Addseries
            // 
            this.ClientSize = new System.Drawing.Size(257, 479);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.type);
            this.Controls.Add(this.trailer_link);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comming_soon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.series_tile_image);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.series_seasons_length);
            this.Controls.Add(this.series_tags);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.series_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.series_image_url);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.series_name);
            this.Controls.Add(this.label1);
            this.Name = "Addseries";
            this.Load += new System.EventHandler(this.Addseries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.series_seasons_length)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox series_name;
        private System.Windows.Forms.TextBox series_image_url;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox series_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox series_tags;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown series_seasons_length;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox series_tile_image;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox comming_soon;
        private System.Windows.Forms.TextBox trailer_link;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox type;
    }
}