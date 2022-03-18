namespace Cinema_booking_system
{
    partial class AddMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMovie));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.dTPSdate = new System.Windows.Forms.DateTimePicker();
            this.dTPEdate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Date";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 35);
            this.txtName.Margin = new System.Windows.Forms.Padding(6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(172, 33);
            this.txtName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descreption";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "End Date";
            // 
            // btn_submit
            // 
            this.btn_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_submit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.Black;
            this.btn_submit.Location = new System.Drawing.Point(663, 380);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(134, 71);
            this.btn_submit.TabIndex = 20;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(149, 238);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(172, 33);
            this.txtDesc.TabIndex = 21;
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
            this.imageList1.Images.SetKeyName(8, "pnglot.com-upload-icon-png-4936545.png");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Place";
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(149, 306);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(168, 33);
            this.txtPlace.TabIndex = 25;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(149, 89);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(167, 33);
            this.txtTime.TabIndex = 26;
            // 
            // dTPSdate
            // 
            this.dTPSdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPSdate.Location = new System.Drawing.Point(149, 146);
            this.dTPSdate.Name = "dTPSdate";
            this.dTPSdate.Size = new System.Drawing.Size(220, 23);
            this.dTPSdate.TabIndex = 27;
            // 
            // dTPEdate
            // 
            this.dTPEdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPEdate.Location = new System.Drawing.Point(149, 200);
            this.dTPEdate.Name = "dTPEdate";
            this.dTPEdate.Size = new System.Drawing.Size(220, 23);
            this.dTPEdate.TabIndex = 28;
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dTPEdate);
            this.Controls.Add(this.dTPSdate);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddMovie";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_submit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.DateTimePicker dTPSdate;
        private System.Windows.Forms.DateTimePicker dTPEdate;
    }
}