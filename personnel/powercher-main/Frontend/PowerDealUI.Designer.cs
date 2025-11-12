namespace Frontend
{
    partial class PowerDealUI
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
            tmrSpendcash = new System.Windows.Forms.Timer(components);
            nudKwhPrice = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudKwhPrice).BeginInit();
            SuspendLayout();
            // 
            // tmrSpendcash
            // 
            tmrSpendcash.Enabled = true;
            tmrSpendcash.Interval = 1000;
            tmrSpendcash.Tick += tmrSpendCash_Tick;
            // 
            // nudKwhPrice
            // 
            nudKwhPrice.BackColor = Color.Gold;
            nudKwhPrice.DecimalPlaces = 2;
            nudKwhPrice.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            nudKwhPrice.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudKwhPrice.Location = new Point(256, 26);
            nudKwhPrice.Margin = new Padding(3, 7, 3, 7);
            nudKwhPrice.Name = "nudKwhPrice";
            nudKwhPrice.Size = new Size(76, 39);
            nudKwhPrice.TabIndex = 34;
            nudKwhPrice.Value = new decimal(new int[] { 2, 0, 0, 65536 });
            nudKwhPrice.ValueChanged += nudKwhPrice_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(101, 28);
            label2.Name = "label2";
            label2.Size = new Size(149, 32);
            label2.TabIndex = 33;
            label2.Text = "Prix du kwh";
            // 
            // PowerDealUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.powercoin;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(421, 420);
            Controls.Add(nudKwhPrice);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PowerDealUI";
            Text = "PowerDealUI";
            ((System.ComponentModel.ISupportInitialize)nudKwhPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer tmrSpendcash;
        private NumericUpDown nudKwhPrice;
        private Label label2;
    }
}