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
            textBox1 = new TextBox();
            owner = new Label();
            time = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // textBox1
            // 
            textBox1.Location = new Point(152, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Quelle heure est-il ?";
            // 
            // owner
            // 
            owner.AutoSize = true;
            owner.Location = new Point(507, 47);
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
            time.Location = new Point(286, 55);
            time.Name = "time";
            time.Size = new Size(31, 15);
            time.TabIndex = 5;
            time.Text = "time";
            // 
            // HouseUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 634);
            Controls.Add(time);
            Controls.Add(owner);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(txtConsole);
            Name = "HouseUI";
            Text = "House";
            Load += HouseUI_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtConsole;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label owner;
        private Label time;
    }
}