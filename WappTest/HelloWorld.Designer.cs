namespace WappTest
{
    partial class HelloWorld
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pic_showMe = new System.Windows.Forms.PictureBox();
            this.btn_showMe = new System.Windows.Forms.Button();
            this.openFileDialog_showMe = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pic_showMe)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Press me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 1;
            // 
            // pic_showMe
            // 
            this.pic_showMe.Location = new System.Drawing.Point(13, 82);
            this.pic_showMe.Name = "pic_showMe";
            this.pic_showMe.Size = new System.Drawing.Size(259, 167);
            this.pic_showMe.TabIndex = 2;
            this.pic_showMe.TabStop = false;
            // 
            // btn_showMe
            // 
            this.btn_showMe.Location = new System.Drawing.Point(13, 42);
            this.btn_showMe.Name = "btn_showMe";
            this.btn_showMe.Size = new System.Drawing.Size(75, 23);
            this.btn_showMe.TabIndex = 3;
            this.btn_showMe.Text = "Show Me";
            this.btn_showMe.UseVisualStyleBackColor = true;
            this.btn_showMe.Click += new System.EventHandler(this.btn_showMe_Click);
            // 
            // HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_showMe);
            this.Controls.Add(this.pic_showMe);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "HelloWorld";
            this.Text = "MyWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pic_showMe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pic_showMe;
        private System.Windows.Forms.Button btn_showMe;
        private System.Windows.Forms.OpenFileDialog openFileDialog_showMe;
    }
}

