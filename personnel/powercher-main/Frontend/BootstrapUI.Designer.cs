using System.ComponentModel;

namespace Frontend;

partial class BootstrapUI
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        btnMotherNature = new Button();
        btnBroadcastAgent = new Button();
        btnPowerWatch = new Button();
        dpdBroker = new ComboBox();
        label1 = new Label();
        btnPowerDeal = new Button();
        SuspendLayout();
        // 
        // btnMotherNature
        // 
        btnMotherNature.BackColor = Color.FromArgb(192, 255, 192);
        btnMotherNature.BackgroundImage = Properties.Resources.motherNature;
        btnMotherNature.BackgroundImageLayout = ImageLayout.Stretch;
        btnMotherNature.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnMotherNature.ForeColor = Color.WhiteSmoke;
        btnMotherNature.Location = new Point(14, 16);
        btnMotherNature.Margin = new Padding(3, 4, 3, 4);
        btnMotherNature.Name = "btnMotherNature";
        btnMotherNature.Size = new Size(110, 110);
        btnMotherNature.TabIndex = 0;
        btnMotherNature.Text = "\r\n\r\nStart Mother Nature";
        btnMotherNature.UseVisualStyleBackColor = false;
        btnMotherNature.Click += btnMotherNature_Click;
        // 
        // btnBroadcastAgent
        // 
        btnBroadcastAgent.BackColor = Color.DarkGray;
        btnBroadcastAgent.BackgroundImage = Properties.Resources.broadcast;
        btnBroadcastAgent.BackgroundImageLayout = ImageLayout.Stretch;
        btnBroadcastAgent.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
        btnBroadcastAgent.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnBroadcastAgent.ForeColor = Color.WhiteSmoke;
        btnBroadcastAgent.Location = new Point(137, 16);
        btnBroadcastAgent.Margin = new Padding(3, 4, 3, 4);
        btnBroadcastAgent.Name = "btnBroadcastAgent";
        btnBroadcastAgent.Size = new Size(110, 110);
        btnBroadcastAgent.TabIndex = 2;
        btnBroadcastAgent.Text = "\r\n\r\n      \r\n  \r\n    Start agent\r\n";
        btnBroadcastAgent.UseVisualStyleBackColor = false;
        btnBroadcastAgent.Click += btnBroadcastAgent_Click;
        // 
        // btnPowerWatch
        // 
        btnPowerWatch.BackColor = Color.FromArgb(192, 255, 192);
        btnPowerWatch.BackgroundImage = Properties.Resources.electric_grid_monitoring_console;
        btnPowerWatch.BackgroundImageLayout = ImageLayout.Stretch;
        btnPowerWatch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnPowerWatch.ForeColor = Color.WhiteSmoke;
        btnPowerWatch.Location = new Point(14, 160);
        btnPowerWatch.Margin = new Padding(3, 4, 3, 4);
        btnPowerWatch.Name = "btnPowerWatch";
        btnPowerWatch.Size = new Size(110, 110);
        btnPowerWatch.TabIndex = 4;
        btnPowerWatch.Text = "\r\n\r\nStart Power Watch";
        btnPowerWatch.UseVisualStyleBackColor = false;
        btnPowerWatch.Click += btnPowerWatch_Click;
        // 
        // dpdBroker
        // 
        dpdBroker.FormattingEnabled = true;
        dpdBroker.Items.AddRange(new object[] { "localhost", "mqtt.blue.section-inf.ch", "INF-A23-P205", "INF-N510-P301.etmlnet.local" });
        dpdBroker.Location = new Point(80, 313);
        dpdBroker.Margin = new Padding(3, 4, 3, 4);
        dpdBroker.Name = "dpdBroker";
        dpdBroker.Size = new Size(138, 28);
        dpdBroker.TabIndex = 5;
        dpdBroker.Text = "localhost";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.ForeColor = SystemColors.Window;
        label1.Location = new Point(30, 317);
        label1.Name = "label1";
        label1.Size = new Size(52, 20);
        label1.TabIndex = 6;
        label1.Text = "Broker";
        // 
        // btnPowerDeal
        // 
        btnPowerDeal.BackColor = Color.FromArgb(192, 255, 192);
        btnPowerDeal.BackgroundImage = Properties.Resources.powercoin;
        btnPowerDeal.BackgroundImageLayout = ImageLayout.Stretch;
        btnPowerDeal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnPowerDeal.ForeColor = Color.WhiteSmoke;
        btnPowerDeal.Location = new Point(137, 160);
        btnPowerDeal.Margin = new Padding(3, 4, 3, 4);
        btnPowerDeal.Name = "btnPowerDeal";
        btnPowerDeal.Size = new Size(110, 110);
        btnPowerDeal.TabIndex = 4;
        btnPowerDeal.Text = "\r\n\r\nStart Power Deal";
        btnPowerDeal.UseVisualStyleBackColor = false;
        btnPowerDeal.Click += btnPowerDeal_Click;
        // 
        // BootstrapUI
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(262, 369);
        Controls.Add(label1);
        Controls.Add(dpdBroker);
        Controls.Add(btnPowerDeal);
        Controls.Add(btnPowerWatch);
        Controls.Add(btnBroadcastAgent);
        Controls.Add(btnMotherNature);
        Margin = new Padding(3, 4, 3, 4);
        Name = "BootstrapUI";
        Text = "Powercher";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnMotherNature;
    private Button btnBroadcastAgent;
    private Button btnPowerWatch;
    private ComboBox dpdBroker;
    private Label label1;
    private Button btnPowerDeal;
}