namespace rock_paper_scissors
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rockbtn = new System.Windows.Forms.Button();
            this.paperbtn = new System.Windows.Forms.Button();
            this.scibtn = new System.Windows.Forms.Button();
            this.compbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.youbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // rockbtn
            // 
            this.rockbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rockbtn.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rockbtn.Location = new System.Drawing.Point(22, 30);
            this.rockbtn.Name = "rockbtn";
            this.rockbtn.Size = new System.Drawing.Size(422, 184);
            this.rockbtn.TabIndex = 0;
            this.rockbtn.Text = "ROCK";
            this.rockbtn.UseVisualStyleBackColor = false;
            this.rockbtn.Click += new System.EventHandler(this.rockbtn_Click);
            // 
            // paperbtn
            // 
            this.paperbtn.BackColor = System.Drawing.Color.Coral;
            this.paperbtn.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paperbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paperbtn.Location = new System.Drawing.Point(22, 220);
            this.paperbtn.Name = "paperbtn";
            this.paperbtn.Size = new System.Drawing.Size(422, 184);
            this.paperbtn.TabIndex = 1;
            this.paperbtn.Text = "PAPER";
            this.paperbtn.UseVisualStyleBackColor = false;
            this.paperbtn.Click += new System.EventHandler(this.paperbtn_Click);
            // 
            // scibtn
            // 
            this.scibtn.BackColor = System.Drawing.Color.Aqua;
            this.scibtn.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scibtn.Location = new System.Drawing.Point(22, 410);
            this.scibtn.Name = "scibtn";
            this.scibtn.Size = new System.Drawing.Size(422, 184);
            this.scibtn.TabIndex = 2;
            this.scibtn.Text = "SCISSORS";
            this.scibtn.UseVisualStyleBackColor = false;
            this.scibtn.Click += new System.EventHandler(this.scibtn_Click);
            // 
            // compbox
            // 
            this.compbox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.compbox.Location = new System.Drawing.Point(785, 278);
            this.compbox.Name = "compbox";
            this.compbox.Size = new System.Drawing.Size(212, 50);
            this.compbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(785, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "COMPUTER:";
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.output.Location = new System.Drawing.Point(785, 371);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(212, 29);
            this.output.TabIndex = 5;
            this.output.Text = "OUTPUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(785, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "OUTPUT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(785, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "YOU:";
            // 
            // youbox
            // 
            this.youbox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.youbox.Location = new System.Drawing.Point(785, 186);
            this.youbox.Name = "youbox";
            this.youbox.Size = new System.Drawing.Size(212, 50);
            this.youbox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::rock_paper_scissors.Properties.Resources._3bdb2575_9a92_42f8_8472_bb78c7bd118a_720x4051;
            this.pictureBox1.Location = new System.Drawing.Point(450, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(450, 220);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(283, 184);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(450, 410);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(283, 184);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1353, 654);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.youbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compbox);
            this.Controls.Add(this.scibtn);
            this.Controls.Add(this.paperbtn);
            this.Controls.Add(this.rockbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button rockbtn;
        private Button paperbtn;
        private Button scibtn;
        private TextBox compbox;
        private Label label1;
        private TextBox output;
        private Label label2;
        private Label label3;
        private TextBox youbox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}