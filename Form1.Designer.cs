namespace XenPlayer
{
    partial class Form1
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
            ListViewItem listViewItem1 = new ListViewItem("Chanson1", 0);
            ListViewItem listViewItem2 = new ListViewItem("Chanson2", 1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelRight = new Panel();
            listView1 = new ListView();
            imageList1 = new ImageList(components);
            groupBox1 = new GroupBox();
            button1 = new Button();
            lblMediaType = new Label();
            lblDuration = new Label();
            lblTitle = new Label();
            volumeCtl1 = new XenLibrary.VolumeCtl();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            panel2 = new Panel();
            playerControl1 = new XenLibrary.PlayerControl();
            timer1 = new System.Windows.Forms.Timer(components);
            panelFront = new Panel();
            button2 = new Button();
            panel1 = new Panel();
            panelRight.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            panel2.SuspendLayout();
            panelFront.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelRight
            // 
            panelRight.BackColor = SystemColors.GradientActiveCaption;
            panelRight.Controls.Add(panel1);
            panelRight.Controls.Add(listView1);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(936, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(500, 722);
            panelRight.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Bottom;
            listView1.GridLines = true;
            listView1.GroupImageList = imageList1;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(0, 181);
            listView1.Name = "listView1";
            listView1.Size = new Size(500, 541);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "wav.png");
            imageList1.Images.SetKeyName(1, "mp3.png");
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(lblMediaType);
            groupBox1.Controls.Add(lblDuration);
            groupBox1.Controls.Add(lblTitle);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(936, 630);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informations média";
            // 
            // button1
            // 
            button1.Location = new Point(54, 108);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 3;
            button1.Text = "Supprimer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // volumeCtl1
            // 
            volumeCtl1.Location = new Point(207, 465);
            volumeCtl1.MaximumSize = new Size(65, 195);
            volumeCtl1.MinimumSize = new Size(65, 192);
            volumeCtl1.Name = "volumeCtl1";
            volumeCtl1.Size = new Size(65, 195);
            volumeCtl1.TabIndex = 4;
            volumeCtl1.TrackBarValue = 0;
            volumeCtl1.Visible = false;
            volumeCtl1.EventVolume += volumeCtl1_EventVolume;
            volumeCtl1.MouseLeave += volumeCtl1_MouseLeave;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(274, 168);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(264, 23);
            axWindowsMediaPlayer1.TabIndex = 2;
            axWindowsMediaPlayer1.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(playerControl1);
            panel2.Controls.Add(axWindowsMediaPlayer1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 630);
            panel2.Name = "panel2";
            panel2.Size = new Size(936, 92);
            panel2.TabIndex = 1;
            // 
            // playerControl1
            // 
            playerControl1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            playerControl1.BorderStyle = BorderStyle.FixedSingle;
            playerControl1.Dock = DockStyle.Fill;
            playerControl1.DurationText = "00:00 / 00:00";
            playerControl1.Location = new Point(0, 0);
            playerControl1.Margin = new Padding(8);
            playerControl1.MinimumSize = new Size(600, 92);
            playerControl1.Name = "playerControl1";
            playerControl1.Padding = new Padding(10, 12, 10, 12);
            playerControl1.Size = new Size(936, 92);
            playerControl1.TabIndex = 3;
            playerControl1.TrackBarMaximum = 10;
            playerControl1.TrackBarValue = 0;
            playerControl1.FileSelected += playerControl1_FileSelected;
            playerControl1.PlayEvent += playerControl1_PlayEvent;
            playerControl1.PauseEvent += playerControl1_PauseEvent;
            playerControl1.StopEvent += playerControl1_StopEvent;
            playerControl1.VolumeEvent += playerControl1_VolumeEvent;
            // 
            // panelFront
            // 
            panelFront.BackColor = SystemColors.GradientInactiveCaption;
            panelFront.Controls.Add(groupBox1);
            panelFront.Dock = DockStyle.Fill;
            panelFront.Location = new Point(0, 0);
            panelFront.Name = "panelFront";
            panelFront.Size = new Size(936, 630);
            panelFront.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(54, 52);
            button2.Name = "button2";
            button2.Size = new Size(131, 40);
            button2.TabIndex = 4;
            button2.Text = "Ajouter";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 175);
            panel1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 722);
            Controls.Add(panelFront);
            Controls.Add(volumeCtl1);
            Controls.Add(panel2);
            Controls.Add(panelRight);
            Name = "Form1";
            Text = "XenPlayer";
            panelRight.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            panel2.ResumeLayout(false);
            panelFront.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRight;
        private ListView listView1;
        private GroupBox groupBox1;
        private Label lblTitle;
        private Label lblDuration;
        private Label lblMediaType;
        private XenLibrary.VolumeCtl volumeCtl1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Panel panel2;
        private XenLibrary.PlayerControl playerControl1;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Panel panelFront;
        private ImageList imageList1;
        private Button button2;
        private Panel panel1;
    }
}
