namespace Vidly.moviesmanager.c
{
    partial class Addepisode
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
            this.episode_name = new System.Windows.Forms.TextBox();
            this.episode_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.season_number = new System.Windows.Forms.NumericUpDown();
            this.season_number_label = new System.Windows.Forms.Label();
            this.episode_tile_image = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comming_soon = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.episode_number = new System.Windows.Forms.NumericUpDown();
            this.episode_link = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.season_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.episode_number)).BeginInit();
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
            // episode_name
            // 
            this.episode_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.episode_name.Location = new System.Drawing.Point(10, 35);
            this.episode_name.Name = "episode_name";
            this.episode_name.Size = new System.Drawing.Size(235, 20);
            this.episode_name.TabIndex = 1;
            // 
            // episode_description
            // 
            this.episode_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.episode_description.Location = new System.Drawing.Point(10, 167);
            this.episode_description.Multiline = true;
            this.episode_description.Name = "episode_description";
            this.episode_description.Size = new System.Drawing.Size(235, 94);
            this.episode_description.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "episode description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // season_number
            // 
            this.season_number.Location = new System.Drawing.Point(10, 283);
            this.season_number.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.season_number.Name = "season_number";
            this.season_number.Size = new System.Drawing.Size(61, 20);
            this.season_number.TabIndex = 8;
            this.season_number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // season_number_label
            // 
            this.season_number_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.season_number_label.AutoSize = true;
            this.season_number_label.Location = new System.Drawing.Point(7, 267);
            this.season_number_label.Name = "season_number_label";
            this.season_number_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.season_number_label.Size = new System.Drawing.Size(79, 13);
            this.season_number_label.TabIndex = 9;
            this.season_number_label.Text = "season number";
            // 
            // episode_tile_image
            // 
            this.episode_tile_image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.episode_tile_image.Location = new System.Drawing.Point(10, 76);
            this.episode_tile_image.Name = "episode_tile_image";
            this.episode_tile_image.Size = new System.Drawing.Size(235, 20);
            this.episode_tile_image.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "tile image url";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "configure";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comming_soon
            // 
            this.comming_soon.AutoSize = true;
            this.comming_soon.Location = new System.Drawing.Point(10, 362);
            this.comming_soon.Name = "comming_soon";
            this.comming_soon.Size = new System.Drawing.Size(190, 17);
            this.comming_soon.TabIndex = 13;
            this.comming_soon.Text = "Check for making \"comming soon\"";
            this.comming_soon.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 310);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "episode number";
            // 
            // episode_number
            // 
            this.episode_number.Location = new System.Drawing.Point(12, 326);
            this.episode_number.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.episode_number.Name = "episode_number";
            this.episode_number.Size = new System.Drawing.Size(61, 20);
            this.episode_number.TabIndex = 16;
            this.episode_number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // episode_link
            // 
            this.episode_link.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.episode_link.Location = new System.Drawing.Point(10, 119);
            this.episode_link.Name = "episode_link";
            this.episode_link.Size = new System.Drawing.Size(235, 20);
            this.episode_link.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "episode streaming link";
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Red;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_button.Location = new System.Drawing.Point(7, 385);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(81, 32);
            this.delete_button.TabIndex = 20;
            this.delete_button.Text = "delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // Addepisode
            // 
            this.ClientSize = new System.Drawing.Size(257, 425);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.episode_link);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.episode_number);
            this.Controls.Add(this.comming_soon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.episode_tile_image);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.season_number_label);
            this.Controls.Add(this.season_number);
            this.Controls.Add(this.episode_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.episode_name);
            this.Controls.Add(this.label1);
            this.Name = "Addepisode";
            this.Load += new System.EventHandler(this.Addseries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.season_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.episode_number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox episode_name;
        private System.Windows.Forms.TextBox episode_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown season_number;
        private System.Windows.Forms.Label season_number_label;
        private System.Windows.Forms.TextBox episode_tile_image;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox comming_soon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown episode_number;
        private System.Windows.Forms.TextBox episode_link;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button delete_button;
    }
}