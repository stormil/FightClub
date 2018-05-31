namespace Fight_Club
{
    partial class FormFightClub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFightClub));
            this.progressBarPlayer1 = new System.Windows.Forms.ProgressBar();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.progressBarPlayer2 = new System.Windows.Forms.ProgressBar();
            this.labelHpPlayer1 = new System.Windows.Forms.Label();
            this.labelHpPlayer2 = new System.Windows.Forms.Label();
            this.buttonLegs = new System.Windows.Forms.Button();
            this.buttonTorso = new System.Windows.Forms.Button();
            this.buttonHead = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarPlayer1
            // 
            this.progressBarPlayer1.Location = new System.Drawing.Point(12, 51);
            this.progressBarPlayer1.Name = "progressBarPlayer1";
            this.progressBarPlayer1.Size = new System.Drawing.Size(405, 43);
            this.progressBarPlayer1.TabIndex = 2;
            this.progressBarPlayer1.Value = 100;
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1.Location = new System.Drawing.Point(12, 5);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(405, 43);
            this.labelPlayer1.TabIndex = 4;
            this.labelPlayer1.Text = "Tyler Durden";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.Font = new System.Drawing.Font("Showcard Gothic", 19.8F);
            this.labelPlayer2.Location = new System.Drawing.Point(568, 5);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(401, 43);
            this.labelPlayer2.TabIndex = 5;
            this.labelPlayer2.Text = "The Narrator";
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.BackColor = System.Drawing.Color.White;
            this.richTextBoxLog.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLog.Location = new System.Drawing.Point(9, 504);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(960, 141);
            this.richTextBoxLog.TabIndex = 6;
            this.richTextBoxLog.Text = "";
            this.richTextBoxLog.TextChanged += new System.EventHandler(this.richTextBoxLog_TextChanged);
            // 
            // progressBarPlayer2
            // 
            this.progressBarPlayer2.Location = new System.Drawing.Point(567, 51);
            this.progressBarPlayer2.Name = "progressBarPlayer2";
            this.progressBarPlayer2.Size = new System.Drawing.Size(405, 43);
            this.progressBarPlayer2.TabIndex = 13;
            this.progressBarPlayer2.Value = 100;
            // 
            // labelHpPlayer1
            // 
            this.labelHpPlayer1.AutoSize = true;
            this.labelHpPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.labelHpPlayer1.Font = new System.Drawing.Font("Showcard Gothic", 10.8F);
            this.labelHpPlayer1.Location = new System.Drawing.Point(12, 97);
            this.labelHpPlayer1.Name = "labelHpPlayer1";
            this.labelHpPlayer1.Size = new System.Drawing.Size(78, 23);
            this.labelHpPlayer1.TabIndex = 14;
            this.labelHpPlayer1.Text = "HP: 100";
            // 
            // labelHpPlayer2
            // 
            this.labelHpPlayer2.AutoSize = true;
            this.labelHpPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.labelHpPlayer2.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHpPlayer2.Location = new System.Drawing.Point(564, 97);
            this.labelHpPlayer2.Name = "labelHpPlayer2";
            this.labelHpPlayer2.Size = new System.Drawing.Size(78, 23);
            this.labelHpPlayer2.TabIndex = 15;
            this.labelHpPlayer2.Text = "HP: 100";
            // 
            // buttonLegs
            // 
            this.buttonLegs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLegs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLegs.Font = new System.Drawing.Font("Impact", 16.2F);
            this.buttonLegs.Location = new System.Drawing.Point(438, 367);
            this.buttonLegs.Name = "buttonLegs";
            this.buttonLegs.Size = new System.Drawing.Size(100, 100);
            this.buttonLegs.TabIndex = 15;
            this.buttonLegs.Text = "Legs";
            this.buttonLegs.UseVisualStyleBackColor = false;
            this.buttonLegs.Click += new System.EventHandler(this.buttonBody_Click);
            // 
            // buttonTorso
            // 
            this.buttonTorso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTorso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTorso.Font = new System.Drawing.Font("Impact", 16.2F);
            this.buttonTorso.Location = new System.Drawing.Point(438, 248);
            this.buttonTorso.Name = "buttonTorso";
            this.buttonTorso.Size = new System.Drawing.Size(100, 100);
            this.buttonTorso.TabIndex = 14;
            this.buttonTorso.Text = "Torso";
            this.buttonTorso.UseVisualStyleBackColor = false;
            this.buttonTorso.Click += new System.EventHandler(this.buttonBody_Click);
            // 
            // buttonHead
            // 
            this.buttonHead.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonHead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHead.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHead.Location = new System.Drawing.Point(438, 133);
            this.buttonHead.Name = "buttonHead";
            this.buttonHead.Size = new System.Drawing.Size(100, 100);
            this.buttonHead.TabIndex = 13;
            this.buttonHead.Text = "Head";
            this.buttonHead.UseVisualStyleBackColor = false;
            this.buttonHead.Click += new System.EventHandler(this.buttonBody_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(50, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 320);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(660, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(272, 334);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // FormFightClub
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 648);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLegs);
            this.Controls.Add(this.buttonTorso);
            this.Controls.Add(this.buttonHead);
            this.Controls.Add(this.labelHpPlayer2);
            this.Controls.Add(this.labelHpPlayer1);
            this.Controls.Add(this.progressBarPlayer2);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.progressBarPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormFightClub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fight Club";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFightClub_FormClosing);
            this.Load += new System.EventHandler(this.FormFightClub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBarPlayer1;
        private System.Windows.Forms.ProgressBar progressBarPlayer2;
        private System.Windows.Forms.Label labelHpPlayer1;
        private System.Windows.Forms.Label labelHpPlayer2;
        private System.Windows.Forms.Button buttonLegs;
        private System.Windows.Forms.Button buttonTorso;
        private System.Windows.Forms.Button buttonHead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label labelPlayer1;
        public System.Windows.Forms.Label labelPlayer2;
        public System.Windows.Forms.RichTextBox richTextBoxLog;
    }
}

