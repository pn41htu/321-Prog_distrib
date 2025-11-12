namespace Frontend;

partial class MotherNatureUI
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
        agent.Stop();
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
        components = new System.ComponentModel.Container();
        label2 = new Label();
        label3 = new Label();
        label6 = new Label();
        label4 = new Label();
        tmrPulse = new System.Windows.Forms.Timer(components);
        datStart = new DateTimePicker();
        nudSiminterval = new NumericUpDown();
        label10 = new Label();
        label12 = new Label();
        label13 = new Label();
        lblSimutime = new Label();
        label15 = new Label();
        grpSimu = new GroupBox();
        cmdStart = new Button();
        nudSimuTick = new NumericUpDown();
        label14 = new Label();
        lblSolarPower = new Label();
        lblCloudCover = new Label();
        lblWindSpeed = new Label();
        lblWindDirection = new Label();
        ((System.ComponentModel.ISupportInitialize)nudSiminterval).BeginInit();
        grpSimu.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudSimuTick).BeginInit();
        SuspendLayout();
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.BackColor = Color.Transparent;
        label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        label2.ForeColor = Color.Black;
        label2.Location = new Point(1, 106);
        label2.Name = "label2";
        label2.Size = new Size(205, 25);
        label2.TabIndex = 3;
        label2.Text = "Couverture nuageuse";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.BackColor = Color.Transparent;
        label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        label3.ForeColor = Color.Black;
        label3.Location = new Point(66, 150);
        label3.Name = "label3";
        label3.Size = new Size(140, 25);
        label3.TabIndex = 5;
        label3.Text = "Ensoleillement";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.BackColor = Color.Transparent;
        label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        label6.ForeColor = Color.Black;
        label6.Location = new Point(72, 194);
        label6.Name = "label6";
        label6.Size = new Size(134, 25);
        label6.TabIndex = 7;
        label6.Text = "Force du vent";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.BackColor = Color.Transparent;
        label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        label4.ForeColor = Color.Black;
        label4.Location = new Point(39, 238);
        label4.Name = "label4";
        label4.Size = new Size(167, 25);
        label4.TabIndex = 11;
        label4.Text = "Direction du vent";
        // 
        // tmrPulse
        // 
        tmrPulse.Interval = 1000;
        tmrPulse.Tick += tmrPulse_Tick;
        // 
        // datStart
        // 
        datStart.CustomFormat = "dd.MM.yyyy HH:mm";
        datStart.Format = DateTimePickerFormat.Custom;
        datStart.Location = new Point(50, 23);
        datStart.Name = "datStart";
        datStart.Size = new Size(126, 23);
        datStart.TabIndex = 25;
        // 
        // nudSiminterval
        // 
        nudSiminterval.Location = new Point(319, 23);
        nudSiminterval.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
        nudSiminterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudSiminterval.Name = "nudSiminterval";
        nudSiminterval.Size = new Size(42, 23);
        nudSiminterval.TabIndex = 26;
        nudSiminterval.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.BackColor = Color.Transparent;
        label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label10.ForeColor = Color.Black;
        label10.Location = new Point(7, 27);
        label10.Name = "label10";
        label10.Size = new Size(42, 15);
        label10.TabIndex = 27;
        label10.Text = "Début";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.BackColor = Color.Transparent;
        label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label12.ForeColor = Color.Black;
        label12.Location = new Point(235, 27);
        label12.Name = "label12";
        label12.Size = new Size(90, 15);
        label12.TabIndex = 28;
        label12.Text = "sec représente";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.BackColor = Color.Transparent;
        label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label13.ForeColor = Color.WhiteSmoke;
        label13.Location = new Point(363, 27);
        label13.Name = "label13";
        label13.Size = new Size(52, 15);
        label13.TabIndex = 29;
        label13.Text = "minutes";
        // 
        // lblSimutime
        // 
        lblSimutime.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblSimutime.Location = new Point(72, 9);
        lblSimutime.Name = "lblSimutime";
        lblSimutime.Size = new Size(196, 25);
        lblSimutime.TabIndex = 30;
        lblSimutime.Text = "-";
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.BackColor = Color.Transparent;
        label15.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        label15.ForeColor = Color.Black;
        label15.Location = new Point(8, 9);
        label15.Name = "label15";
        label15.Size = new Size(53, 25);
        label15.TabIndex = 5;
        label15.Text = "Il est";
        // 
        // grpSimu
        // 
        grpSimu.BackColor = Color.Transparent;
        grpSimu.Controls.Add(cmdStart);
        grpSimu.Controls.Add(nudSimuTick);
        grpSimu.Controls.Add(label13);
        grpSimu.Controls.Add(datStart);
        grpSimu.Controls.Add(nudSiminterval);
        grpSimu.Controls.Add(label12);
        grpSimu.Controls.Add(label10);
        grpSimu.Location = new Point(0, -5);
        grpSimu.Name = "grpSimu";
        grpSimu.Size = new Size(421, 86);
        grpSimu.TabIndex = 31;
        grpSimu.TabStop = false;
        grpSimu.Text = "Simulation du temps";
        // 
        // cmdStart
        // 
        cmdStart.Location = new Point(181, 57);
        cmdStart.Name = "cmdStart";
        cmdStart.Size = new Size(75, 23);
        cmdStart.TabIndex = 33;
        cmdStart.Text = "Start";
        cmdStart.UseVisualStyleBackColor = true;
        cmdStart.Click += cmdStart_Click;
        // 
        // nudSimuTick
        // 
        nudSimuTick.Location = new Point(195, 23);
        nudSimuTick.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudSimuTick.Name = "nudSimuTick";
        nudSimuTick.Size = new Size(34, 23);
        nudSimuTick.TabIndex = 32;
        nudSimuTick.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.BackColor = Color.Transparent;
        label14.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        label14.ForeColor = Color.Black;
        label14.Location = new Point(274, 9);
        label14.Name = "label14";
        label14.Size = new Size(117, 25);
        label14.TabIndex = 5;
        label14.Text = "à PowerCity";
        // 
        // lblSolarPower
        // 
        lblSolarPower.AutoSize = true;
        lblSolarPower.BackColor = Color.Transparent;
        lblSolarPower.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblSolarPower.ForeColor = Color.Black;
        lblSolarPower.Location = new Point(220, 150);
        lblSolarPower.Name = "lblSolarPower";
        lblSolarPower.Size = new Size(20, 25);
        lblSolarPower.TabIndex = 32;
        lblSolarPower.Text = "-";
        // 
        // lblCloudCover
        // 
        lblCloudCover.AutoSize = true;
        lblCloudCover.BackColor = Color.Transparent;
        lblCloudCover.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblCloudCover.ForeColor = Color.Black;
        lblCloudCover.Location = new Point(220, 106);
        lblCloudCover.Name = "lblCloudCover";
        lblCloudCover.Size = new Size(20, 25);
        lblCloudCover.TabIndex = 32;
        lblCloudCover.Text = "-";
        // 
        // lblWindSpeed
        // 
        lblWindSpeed.AutoSize = true;
        lblWindSpeed.BackColor = Color.Transparent;
        lblWindSpeed.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblWindSpeed.ForeColor = Color.Black;
        lblWindSpeed.Location = new Point(220, 194);
        lblWindSpeed.Name = "lblWindSpeed";
        lblWindSpeed.Size = new Size(20, 25);
        lblWindSpeed.TabIndex = 32;
        lblWindSpeed.Text = "-";
        // 
        // lblWindDirection
        // 
        lblWindDirection.AutoSize = true;
        lblWindDirection.BackColor = Color.Transparent;
        lblWindDirection.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblWindDirection.ForeColor = Color.Black;
        lblWindDirection.Location = new Point(220, 238);
        lblWindDirection.Name = "lblWindDirection";
        lblWindDirection.Size = new Size(20, 25);
        lblWindDirection.TabIndex = 32;
        lblWindDirection.Text = "-";
        // 
        // MotherNatureUI
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = Properties.Resources.motherNatureMini;
        BackgroundImageLayout = ImageLayout.None;
        ClientSize = new Size(419, 291);
        Controls.Add(lblCloudCover);
        Controls.Add(lblWindDirection);
        Controls.Add(lblWindSpeed);
        Controls.Add(lblSolarPower);
        Controls.Add(grpSimu);
        Controls.Add(lblSimutime);
        Controls.Add(label14);
        Controls.Add(label15);
        Controls.Add(label4);
        Controls.Add(label6);
        Controls.Add(label3);
        Controls.Add(label2);
        Name = "MotherNatureUI";
        Text = "MotherNature";
        ((System.ComponentModel.ISupportInitialize)nudSiminterval).EndInit();
        grpSimu.ResumeLayout(false);
        grpSimu.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudSimuTick).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label label2;
    private Label label3;
    private Label label6;
    private Label label4;
    private System.Windows.Forms.Timer tmrPulse;
    private DateTimePicker datStart;
    private NumericUpDown nudSiminterval;
    private Label label10;
    private Label label12;
    private Label label13;
    private Label lblSimutime;
    private Label label15;
    private GroupBox grpSimu;
    private Label label14;
    private NumericUpDown nudSimuTick;
    private Button cmdStart;
    private Label lblSolarPower;
    private Label lblCloudCover;
    private Label lblWindSpeed;
    private Label lblWindDirection;
}