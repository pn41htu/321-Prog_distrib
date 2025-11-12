namespace Frontend
{
    partial class PowerWatchUI
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
            components = new System.ComponentModel.Container();
            btnCleanup = new Button();
            tmrUpdateView = new System.Windows.Forms.Timer(components);
            cmdReset = new Button();
            SuspendLayout();
            // 
            // btnCleanup
            // 
            btnCleanup.Location = new Point(359, 208);
            btnCleanup.Margin = new Padding(3, 4, 3, 4);
            btnCleanup.Name = "btnCleanup";
            btnCleanup.Size = new Size(86, 31);
            btnCleanup.TabIndex = 0;
            btnCleanup.Text = "Cleanup";
            btnCleanup.UseVisualStyleBackColor = true;
            btnCleanup.Click += btnCleanup_Click;
            // 
            // tmrUpdateView
            // 
            tmrUpdateView.Enabled = true;
            tmrUpdateView.Interval = 1000;
            tmrUpdateView.Tick += tmrUpdateView_Tick;
            // 
            // cmdReset
            // 
            cmdReset.Location = new Point(259, 208);
            cmdReset.Name = "cmdReset";
            cmdReset.Size = new Size(94, 29);
            cmdReset.TabIndex = 1;
            cmdReset.Text = "Reset";
            cmdReset.UseVisualStyleBackColor = true;
            cmdReset.Click += cmdReset_Click;
            // 
            // PowerWatchUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.electric_grid_monitoring_console;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(457, 243);
            Controls.Add(cmdReset);
            Controls.Add(btnCleanup);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PowerWatchUI";
            Text = "PowerWatchUI";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCleanup;
        private System.Windows.Forms.Timer tmrUpdateView;
        private Button cmdReset;
    }
}