namespace Frontend
{
    sealed partial class HouseUI
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
            _agent.Stop();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HouseUI));
            txtConsole = new RichTextBox();
            pictureBox1 = new PictureBox();
            owner = new Label();
            time = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtConsole
            // 
            txtConsole.Location = new Point(28, 307);
            txtConsole.Name = "txtConsole";
            txtConsole.Size = new Size(803, 315);
            txtConsole.TabIndex = 0;
            txtConsole.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 289);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // owner
            // 
            owner.AutoSize = true;
            owner.Location = new Point(677, 31);
            owner.Name = "owner";
            owner.Size = new Size(68, 15);
            owner.TabIndex = 4;
            owner.Tag = "owner";
            owner.Text = "Propriétaire";
            owner.UseWaitCursor = true;
            // 
            // time
            // 
            time.AutoSize = true;
            time.Location = new Point(477, 31);
            time.Name = "time";
            time.Size = new Size(31, 15);
            time.TabIndex = 5;
            time.Text = "time";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(49, 65);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(240, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // HouseUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 634);
            Controls.Add(pictureBox2);
            Controls.Add(time);
            Controls.Add(owner);
            Controls.Add(pictureBox1);
            Controls.Add(txtConsole);
            Name = "HouseUI";
            Text = "House";
            Load += HouseUI_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtConsole;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Label label1;
        private Label owner;
        private Label time;
        private PictureBox pictureBox2;
    }
}