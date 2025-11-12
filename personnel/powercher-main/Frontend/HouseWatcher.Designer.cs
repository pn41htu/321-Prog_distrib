namespace Frontend
{
    partial class HouseWatcher
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
            label11 = new Label();
            lblDisplayName = new Label();
            label5 = new Label();
            lblCash = new Label();
            lblCTime = new Label();
            label3 = new Label();
            lblUPS = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.LightGray;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(14, 12);
            label11.Name = "label11";
            label11.Size = new Size(48, 23);
            label11.TabIndex = 0;
            label11.Text = "Chez";
            // 
            // lblDisplayName
            // 
            lblDisplayName.BackColor = Color.LightGray;
            lblDisplayName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisplayName.Location = new Point(61, 9);
            lblDisplayName.Name = "lblDisplayName";
            lblDisplayName.Size = new Size(160, 31);
            lblDisplayName.TabIndex = 1;
            lblDisplayName.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightGray;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(217, 9);
            label5.Name = "label5";
            label5.Size = new Size(45, 23);
            label5.TabIndex = 2;
            label5.Text = "il est";
            // 
            // lblCash
            // 
            lblCash.BackColor = Color.LightGray;
            lblCash.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCash.Location = new Point(61, 40);
            lblCash.Name = "lblCash";
            lblCash.Size = new Size(142, 31);
            lblCash.TabIndex = 3;
            lblCash.Text = "-";
            // 
            // lblCTime
            // 
            lblCTime.BackColor = Color.LightGray;
            lblCTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCTime.Location = new Point(263, 9);
            lblCTime.Name = "lblCTime";
            lblCTime.Size = new Size(263, 31);
            lblCTime.TabIndex = 5;
            lblCTime.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightGray;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 43);
            label3.Name = "label3";
            label3.Size = new Size(45, 23);
            label3.TabIndex = 4;
            label3.Text = "il y a";
            // 
            // lblUPS
            // 
            lblUPS.BackColor = Color.LightGray;
            lblUPS.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUPS.Location = new Point(252, 35);
            lblUPS.Name = "lblUPS";
            lblUPS.Size = new Size(62, 31);
            lblUPS.TabIndex = 3;
            lblUPS.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(221, 38);
            label2.Name = "label2";
            label2.Size = new Size(25, 23);
            label2.TabIndex = 4;
            label2.Text = "et";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightGray;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(320, 38);
            label4.Name = "label4";
            label4.Size = new Size(139, 23);
            label4.TabIndex = 6;
            label4.Text = "[kWh] dans l'UPS";
            // 
            // HouseWatcher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(533, 80);
            Controls.Add(label4);
            Controls.Add(lblCTime);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblUPS);
            Controls.Add(lblCash);
            Controls.Add(label5);
            Controls.Add(lblDisplayName);
            Controls.Add(label11);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "HouseWatcher";
            Text = "HouseWatch";
            MouseDown += HouseWatcher_MouseDown;
            MouseMove += HouseWatcher_MouseMove;
            MouseUp += HouseWatcher_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Label lblDisplayName;
        private Label label5;
        private Label lblCash;
        private Label lblCTime;
        private Label label3;
        private Label lblUPS;
        private Label label2;
        private Label label4;
    }
}