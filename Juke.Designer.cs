namespace XenPlayer
{
    partial class Juke
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
            playerCtl1 = new XenLibrary.PlayerCtl();
            panel1 = new Panel();
            button2 = new Button();
            button3 = new Button();
            volumeCtl = new XenLibrary.VolumeCtl();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            lblMediaType = new Label();
            lblDuration = new Label();
            lblTitle = new Label();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // playerCtl1
            // 
            playerCtl1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            playerCtl1.BorderStyle = BorderStyle.FixedSingle;
            playerCtl1.Dock = DockStyle.Bottom;
            playerCtl1.DurationText = "00:00 / 00:00";
            playerCtl1.ForcePlay = false;
            playerCtl1.Location = new Point(0, 348);
            playerCtl1.Margin = new Padding(0);
            playerCtl1.MinimumSize = new Size(600, 46);
            playerCtl1.Name = "playerCtl1";
            playerCtl1.Padding = new Padding(8, 6, 8, 8);
            playerCtl1.Size = new Size(1342, 59);
            playerCtl1.TabIndex = 0;
            playerCtl1.TrackBarMaximum = 10;
            playerCtl1.TrackBarValue = 0;
            playerCtl1.FileSelected += on_FileSelected;
            playerCtl1.VolumeEvent += onShowVolume;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(volumeCtl);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(listBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 8, 8, 8);
            panel1.Size = new Size(1342, 348);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(616, 71);
            button2.Name = "button2";
            button2.Size = new Size(55, 40);
            button2.TabIndex = 6;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(615, 12);
            button3.Name = "button3";
            button3.Size = new Size(55, 40);
            button3.TabIndex = 7;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnOpen_Click;
            // 
            // volumeCtl
            // 
            volumeCtl.Location = new Point(1277, 153);
            volumeCtl.MaximumSize = new Size(65, 195);
            volumeCtl.MinimumSize = new Size(65, 192);
            volumeCtl.Name = "volumeCtl";
            volumeCtl.Size = new Size(65, 195);
            volumeCtl.TabIndex = 2;
            volumeCtl.TrackBarValue = 0;
            volumeCtl.Visible = false;
            volumeCtl.EventVolume += OnVolume;
            volumeCtl.MouseLeave += volumeCtl_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(594, 332);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(lblMediaType);
            groupBox1.Controls.Add(lblDuration);
            groupBox1.Controls.Add(lblTitle);
            groupBox1.Location = new Point(8, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(569, 321);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informations média";
            // 
            // lblMediaType
            // 
            lblMediaType.AutoSize = true;
            lblMediaType.Location = new Point(23, 133);
            lblMediaType.Name = "lblMediaType";
            lblMediaType.Size = new Size(67, 30);
            lblMediaType.TabIndex = 2;
            lblMediaType.Text = "Type :";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(23, 93);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(69, 30);
            lblDuration.TabIndex = 1;
            lblDuration.Text = "Durée";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(23, 52);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(54, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Titre";
            // 
            // listBox1
            // 
            listBox1.AllowDrop = true;
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Location = new Point(692, 8);
            listBox1.Margin = new Padding(8);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(642, 330);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += on_MusicChanged;
            listBox1.DragDrop += listBox1_DragDrop;
            listBox1.DragEnter += listBox1_DragEnter;
            // 
            // Juke
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 407);
            Controls.Add(panel1);
            Controls.Add(playerCtl1);
            Name = "Juke";
            Text = "Juke Box";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private XenLibrary.PlayerCtl playerCtl1;
        private Panel panel1;
        private Panel panel2;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private XenLibrary.VolumeCtl volumeCtl1;
        private Label lblMediaType;
        private Label lblDuration;
        private Label lblTitle;
        private XenLibrary.VolumeCtl volumeCtl;
        private Button button2;
        private Button button3;
    }
}