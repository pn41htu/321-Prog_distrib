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
            txtConsole = new RichTextBox();
            SuspendLayout();
            // 
            // txtConsole
            // 
            txtConsole.Location = new Point(174, 110);
            txtConsole.Name = "txtConsole";
            txtConsole.Size = new Size(453, 305);
            txtConsole.TabIndex = 0;
            txtConsole.Text = "";
            // 
            // HouseUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtConsole);
            Name = "HouseUI";
            Text = "House";
            Load += HouseUI_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtConsole;
    }
}