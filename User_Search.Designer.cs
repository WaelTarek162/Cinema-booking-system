namespace Cinema_booking_system
{
    partial class UserSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSearch));
            this.search_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // 
            // search_box
            // 
            this.search_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_box.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.Location = new System.Drawing.Point(225, 118);
            this.search_box.Multiline = true;
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(285, 28);
            this.search_box.TabIndex = 23;
            this.search_box.Text = "   Search for Movie here!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(308, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 97);
            this.button1.TabIndex = 24;
            this.button1.Text = "View My Booking";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.ImageIndex = 2;
            this.btn_search.ImageList = this.imageList1;
            this.btn_search.Location = new System.Drawing.Point(477, 118);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(33, 27);
            this.btn_search.TabIndex = 25;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pnglot.com-hamburger-icon-png-44017.png");
            this.imageList1.Images.SetKeyName(1, "pnglot.com-hamburger-menu-icon-png-3969440.png");
            this.imageList1.Images.SetKeyName(2, "pnglot.com-magnifying-glass-vector-png-3526579.png");
            this.imageList1.Images.SetKeyName(3, "pnglot.com-reset-icon-png-3690275.png");
            this.imageList1.Images.SetKeyName(4, "pnglot.com-time-icon-png-4951761.png");
            this.imageList1.Images.SetKeyName(5, "pnglot.com-upload-icon-png-4936545.png");
            this.imageList1.Images.SetKeyName(6, "pnglot.com-view-icon-png-3664415.png");
            this.imageList1.Images.SetKeyName(7, "pnglot.com-white-dot-png-1502800.png");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 23);
            this.toolStripMenuItem2.Text = "Time";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(98, 23);
            this.toolStripMenuItem1.Text = "Movie Name";
            // 
            // UserSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search_box);
            this.DoubleBuffered = true;
            this.Name = "UserSearch";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ToolStripTextBox toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ImageList imageList1;

    }
}

