namespace Cinema_booking_system
{
    partial class AdminSearch
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.Location = new System.Drawing.Point(130, 22);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(503, 34);
            this.txtSearch.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(277, 128);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 38);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Movie";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.Location = new System.Drawing.Point(277, 276);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(174, 38);
            this.btnBooking.TabIndex = 8;
            this.btnBooking.Text = "Manage Booking";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.BackgroundImage = global::Cinema_booking_system.Properties.Resources.Capture3;
            this.btn_search.ImageIndex = 2;
            this.btn_search.Location = new System.Drawing.Point(89, 22);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(44, 34);
            this.btn_search.TabIndex = 26;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // AdminSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cinema_booking_system.Properties.Resources.gold_carousel_Avengers_1548665108;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Name = "AdminSearch";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btn_search;
    }
}

