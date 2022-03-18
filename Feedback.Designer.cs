namespace Cinema_booking_system
{
    partial class Feedback
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.brnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Lavender;
            this.textBox1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 213);
            this.textBox1.TabIndex = 0;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Black;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinish.Font = new System.Drawing.Font("Franklin Gothic Book", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinish.Location = new System.Drawing.Point(629, 221);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(150, 69);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.button1_Click);
            // 
            // brnBack
            // 
            this.brnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.brnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brnBack.Font = new System.Drawing.Font("Franklin Gothic Book", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.brnBack.Location = new System.Drawing.Point(629, 296);
            this.brnBack.Name = "brnBack";
            this.brnBack.Size = new System.Drawing.Size(150, 69);
            this.brnBack.TabIndex = 2;
            this.brnBack.Text = "Back";
            this.brnBack.UseVisualStyleBackColor = false;
            this.brnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "FEEDBACK";
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Cinema_booking_system.Properties.Resources.pnglot_com_view_icon_png_3664415;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(781, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brnBack);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Name = "Feedback";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button brnBack;
        private System.Windows.Forms.Label label1;
    }
}