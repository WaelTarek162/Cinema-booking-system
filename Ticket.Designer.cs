namespace Cinema_booking_system
{
    partial class Ticket1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label movieNameLabel;
            System.Windows.Forms.Label nomOfSeatLabel;
            System.Windows.Forms.Label movieDateLabel;
            System.Windows.Forms.Label movieTimeLabel;
           // this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.movieNameTextBox = new System.Windows.Forms.TextBox();
            this.nomOfSeatTextBox = new System.Windows.Forms.TextBox();
            this.movieDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.movieTimeTextBox = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            userNameLabel = new System.Windows.Forms.Label();
            movieNameLabel = new System.Windows.Forms.Label();
            nomOfSeatLabel = new System.Windows.Forms.Label();
            movieDateLabel = new System.Windows.Forms.Label();
            movieTimeLabel = new System.Windows.Forms.Label();
            //((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Cursor = System.Windows.Forms.Cursors.AppStarting;
            userNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            userNameLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Italic);
            userNameLabel.ForeColor = System.Drawing.Color.Black;
            userNameLabel.Location = new System.Drawing.Point(26, 38);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(89, 22);
            userNameLabel.TabIndex = 11;
            userNameLabel.Text = "User Name:";
            userNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // movieNameLabel
            // 
            movieNameLabel.AutoSize = true;
            movieNameLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Italic);
            movieNameLabel.ForeColor = System.Drawing.Color.Black;
            movieNameLabel.Location = new System.Drawing.Point(27, 86);
            movieNameLabel.Name = "movieNameLabel";
            movieNameLabel.Size = new System.Drawing.Size(99, 22);
            movieNameLabel.TabIndex = 12;
            movieNameLabel.Text = "Movie Name:";
            // 
            // nomOfSeatLabel
            // 
            nomOfSeatLabel.AutoSize = true;
            nomOfSeatLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Italic);
            nomOfSeatLabel.ForeColor = System.Drawing.Color.Black;
            nomOfSeatLabel.Location = new System.Drawing.Point(26, 139);
            nomOfSeatLabel.Name = "nomOfSeatLabel";
            nomOfSeatLabel.Size = new System.Drawing.Size(87, 22);
            nomOfSeatLabel.TabIndex = 13;
            nomOfSeatLabel.Text = "No Of Seat:";
            // 
            // movieDateLabel
            // 
            movieDateLabel.AutoSize = true;
            movieDateLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Italic);
            movieDateLabel.ForeColor = System.Drawing.Color.Black;
            movieDateLabel.Location = new System.Drawing.Point(25, 194);
            movieDateLabel.Name = "movieDateLabel";
            movieDateLabel.Size = new System.Drawing.Size(92, 22);
            movieDateLabel.TabIndex = 15;
            movieDateLabel.Text = "Movie Date:";
            // 
            // movieTimeLabel
            // 
            movieTimeLabel.AutoSize = true;
            movieTimeLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Italic);
            movieTimeLabel.ForeColor = System.Drawing.Color.Black;
            movieTimeLabel.Location = new System.Drawing.Point(27, 250);
            movieTimeLabel.Name = "movieTimeLabel";
            movieTimeLabel.Size = new System.Drawing.Size(94, 22);
            movieTimeLabel.TabIndex = 19;
            movieTimeLabel.Text = "Movie Time:";
            // 
            // ticketBindingSource
            // 
         //   this.ticketBindingSource.DataMember = "Ticket";
            // 
            // userNameTextBox
            // 
           // this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "UserName", true));
            this.userNameTextBox.Enabled = false;
            this.userNameTextBox.Location = new System.Drawing.Point(143, 38);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(197, 20);
            this.userNameTextBox.TabIndex = 12;
            // 
            // movieNameTextBox
            // 
           // this.movieNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "MovieName", true));
            this.movieNameTextBox.Enabled = false;
            this.movieNameTextBox.Location = new System.Drawing.Point(143, 89);
            this.movieNameTextBox.Name = "movieNameTextBox";
            this.movieNameTextBox.Size = new System.Drawing.Size(197, 20);
            this.movieNameTextBox.TabIndex = 13;
            // 
            // nomOfSeatTextBox
            // 
           // this.nomOfSeatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "NomOfSeat", true));
            this.nomOfSeatTextBox.Enabled = false;
            this.nomOfSeatTextBox.Location = new System.Drawing.Point(143, 139);
            this.nomOfSeatTextBox.Name = "nomOfSeatTextBox";
            this.nomOfSeatTextBox.Size = new System.Drawing.Size(197, 20);
            this.nomOfSeatTextBox.TabIndex = 14;
            // 
            // movieDateDateTimePicker
            // 
           // this.movieDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ticketBindingSource, "MovieDate", true));
            this.movieDateDateTimePicker.Enabled = false;
            this.movieDateDateTimePicker.Location = new System.Drawing.Point(144, 197);
            this.movieDateDateTimePicker.Name = "movieDateDateTimePicker";
            this.movieDateDateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.movieDateDateTimePicker.TabIndex = 16;
            // 
            // movieTimeTextBox
            // 
          //  this.movieTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "MovieTime", true));
            this.movieTimeTextBox.Enabled = false;
            this.movieTimeTextBox.Location = new System.Drawing.Point(144, 253);
            this.movieTimeTextBox.Name = "movieTimeTextBox";
            this.movieTimeTextBox.Size = new System.Drawing.Size(197, 20);
            this.movieTimeTextBox.TabIndex = 20;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOk.Font = new System.Drawing.Font("Franklin Gothic Book", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOk.Location = new System.Drawing.Point(669, 377);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(130, 70);
            this.btnOk.TabIndex = 22;
            this.btnOk.Text = "Done";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Movie Place";
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(143, 308);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(197, 20);
            this.txtPlace.TabIndex = 24;
            // 
            // Ticket1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::Cinema_booking_system.Properties.Resources.pnglot_com_admit_one_png_115657;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(movieTimeLabel);
            this.Controls.Add(this.movieTimeTextBox);
            this.Controls.Add(movieDateLabel);
            this.Controls.Add(this.movieDateDateTimePicker);
            this.Controls.Add(nomOfSeatLabel);
            this.Controls.Add(this.nomOfSeatTextBox);
            this.Controls.Add(movieNameLabel);
            this.Controls.Add(this.movieNameTextBox);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.DoubleBuffered = true;
            this.Name = "Ticket1";
            this.Text = "Ticket";
          //  ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private My_projectDataSet my_projectDataSet;
    //    private System.Windows.Forms.BindingSource ticketBindingSource;
        //private My_projectDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
      //  private My_projectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox movieNameTextBox;
        private System.Windows.Forms.TextBox nomOfSeatTextBox;
        private System.Windows.Forms.DateTimePicker movieDateDateTimePicker;
        private System.Windows.Forms.TextBox movieTimeTextBox;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlace;
    }
}

