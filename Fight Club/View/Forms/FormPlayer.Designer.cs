namespace Fight_Club
{
    partial class FormPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlayer));
            this.buttonLegs = new System.Windows.Forms.Button();
            this.buttonTorso = new System.Windows.Forms.Button();
            this.buttonHead = new System.Windows.Forms.Button();
            this.labelHpPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.progressBarPlayer1 = new System.Windows.Forms.ProgressBar();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.labelInstruction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLegs
            // 
            this.buttonLegs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLegs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLegs.Font = new System.Drawing.Font("Impact", 16.2F);
            this.buttonLegs.Location = new System.Drawing.Point(370, 428);
            this.buttonLegs.Name = "buttonLegs";
            this.buttonLegs.Size = new System.Drawing.Size(100, 100);
            this.buttonLegs.TabIndex = 21;
            this.buttonLegs.Text = "Legs";
            this.buttonLegs.UseVisualStyleBackColor = false;
            this.buttonLegs.Click += new System.EventHandler(this.ButtonBody_Click);
            // 
            // buttonTorso
            // 
            this.buttonTorso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTorso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTorso.Font = new System.Drawing.Font("Impact", 16.2F);
            this.buttonTorso.Location = new System.Drawing.Point(370, 309);
            this.buttonTorso.Name = "buttonTorso";
            this.buttonTorso.Size = new System.Drawing.Size(100, 100);
            this.buttonTorso.TabIndex = 19;
            this.buttonTorso.Text = "Torso";
            this.buttonTorso.UseVisualStyleBackColor = false;
            this.buttonTorso.Click += new System.EventHandler(this.ButtonBody_Click);
            // 
            // buttonHead
            // 
            this.buttonHead.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonHead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHead.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHead.Location = new System.Drawing.Point(370, 187);
            this.buttonHead.Name = "buttonHead";
            this.buttonHead.Size = new System.Drawing.Size(100, 100);
            this.buttonHead.TabIndex = 18;
            this.buttonHead.Text = "Head";
            this.buttonHead.UseVisualStyleBackColor = false;
            this.buttonHead.Click += new System.EventHandler(this.ButtonBody_Click);
            // 
            // labelHpPlayer1
            // 
            this.labelHpPlayer1.AutoSize = true;
            this.labelHpPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.labelHpPlayer1.Font = new System.Drawing.Font("Showcard Gothic", 10.8F);
            this.labelHpPlayer1.Location = new System.Drawing.Point(12, 101);
            this.labelHpPlayer1.Name = "labelHpPlayer1";
            this.labelHpPlayer1.Size = new System.Drawing.Size(78, 23);
            this.labelHpPlayer1.TabIndex = 20;
            this.labelHpPlayer1.Text = "HP: 100";
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1.Location = new System.Drawing.Point(12, 9);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(405, 43);
            this.labelPlayer1.TabIndex = 17;
            this.labelPlayer1.Text = "Player 1";
            // 
            // progressBarPlayer1
            // 
            this.progressBarPlayer1.Location = new System.Drawing.Point(12, 55);
            this.progressBarPlayer1.Name = "progressBarPlayer1";
            this.progressBarPlayer1.Size = new System.Drawing.Size(458, 43);
            this.progressBarPlayer1.TabIndex = 16;
            this.progressBarPlayer1.Value = 100;
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlayer.BackgroundImage")));
            this.pictureBoxPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPlayer.Location = new System.Drawing.Point(19, 146);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(336, 382);
            this.pictureBoxPlayer.TabIndex = 22;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstruction.Location = new System.Drawing.Point(353, 146);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(64, 25);
            this.labelInstruction.TabIndex = 23;
            this.labelInstruction.Text = "label1";
            // 
            // FormPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.buttonLegs);
            this.Controls.Add(this.buttonTorso);
            this.Controls.Add(this.buttonHead);
            this.Controls.Add(this.labelHpPlayer1);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.progressBarPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPlayer";
            this.Text = "FormPlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPlayer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLegs;
        private System.Windows.Forms.Button buttonTorso;
        private System.Windows.Forms.Button buttonHead;
        private System.Windows.Forms.Label labelHpPlayer1;
        public System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.ProgressBar progressBarPlayer1;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.Label labelInstruction;
    }
}