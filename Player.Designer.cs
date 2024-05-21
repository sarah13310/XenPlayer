namespace XenPlayer
{
    partial class Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            ListViewItem listViewItem1 = new ListViewItem("Chanson1", 0);
            ListViewItem listViewItem2 = new ListViewItem("Chanson2", 1);
            panelRight = new Panel();
            panelCmd = new Panel();
            btnFilr = new Button();
            btnDel = new Button();
            btnDelete = new Button();
            listView1 = new ListView();
            groupBox1 = new GroupBox();
            volumeCtl1 = new XenLibrary.VolumeCtl();
            lblMediaType = new Label();
            lblDuration = new Label();
            lblTitle = new Label();
            playerCtl1 = new XenLibrary.PlayerCtl();
            panelBar = new Panel();
            panelFront = new Panel();
            panelRight.SuspendLayout();
            panelCmd.SuspendLayout();
            groupBox1.SuspendLayout();
            panelBar.SuspendLayout();
            panelFront.SuspendLayout();
            SuspendLayout();
            // 
            // panelRight
            // 
            panelRight.BackColor = SystemColors.GradientActiveCaption;
            panelRight.Controls.Add(panelCmd);
            panelRight.Controls.Add(listView1);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(936, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(500, 722);
            panelRight.TabIndex = 0;
            // 
            // panelCmd
            // 
            panelCmd.BackColor = SystemColors.GradientInactiveCaption;
            panelCmd.Controls.Add(btnFilr);
            panelCmd.Controls.Add(btnDel);
            panelCmd.Controls.Add(btnDelete);
            panelCmd.Dock = DockStyle.Top;
            panelCmd.Location = new Point(0, 0);
            panelCmd.Name = "panelCmd";
            panelCmd.Size = new Size(500, 175);
            panelCmd.TabIndex = 5;
            // 
            // btnFilr
            // 
            btnFilr.Image = (Image)resources.GetObject("btnFilr.Image");
            btnFilr.Location = new Point(397, 52);
            btnFilr.Name = "btnFilr";
            btnFilr.Size = new Size(49, 40);
            btnFilr.TabIndex = 5;
            btnFilr.UseVisualStyleBackColor = true;
            btnFilr.Click += btnFile_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(54, 108);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(131, 40);
            btnDel.TabIndex = 3;
            btnDel.Text = "Supprimer";
            btnDel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(54, 52);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 40);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Ajouter";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Bottom;
            listView1.GridLines = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(0, 181);
            listView1.Name = "listView1";
            listView1.Size = new Size(500, 541);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(volumeCtl1);
            groupBox1.Controls.Add(lblMediaType);
            groupBox1.Controls.Add(lblDuration);
            groupBox1.Controls.Add(lblTitle);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(936, 666);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informations média";
            // 
            // volumeCtl1
            // 
            volumeCtl1.BorderStyle = BorderStyle.FixedSingle;
            volumeCtl1.Location = new Point(871, 470);
            volumeCtl1.MaximumSize = new Size(65, 195);
            volumeCtl1.MinimumSize = new Size(65, 192);
            volumeCtl1.Name = "volumeCtl1";
            volumeCtl1.Size = new Size(65, 195);
            volumeCtl1.TabIndex = 4;
            volumeCtl1.TrackBarValue = 0;
            volumeCtl1.Visible = false;
            volumeCtl1.MouseLeave += volumeCtl1_MouseLeave;
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
            // playerCtl1
            // 
            playerCtl1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            playerCtl1.BorderStyle = BorderStyle.FixedSingle;
            playerCtl1.Dock = DockStyle.Bottom;
            playerCtl1.DurationText = "00:00 / 00:00";
            playerCtl1.ForcePlay = false;
            playerCtl1.Location = new Point(5, 5);
            playerCtl1.Margin = new Padding(0);
            playerCtl1.MinimumSize = new Size(600, 46);
            playerCtl1.Name = "playerCtl1";
            playerCtl1.Size = new Size(926, 46);
            playerCtl1.TabIndex = 3;
            playerCtl1.TrackBarMaximum = 10;
            playerCtl1.TrackBarValue = 0;
            playerCtl1.VolumeEvent += playerControl1_VolumeEvent;
            // 
            // panelBar
            // 
            panelBar.AutoSize = true;
            panelBar.BackColor = SystemColors.AppWorkspace;
            panelBar.Controls.Add(playerCtl1);
            panelBar.Dock = DockStyle.Bottom;
            panelBar.Location = new Point(0, 666);
            panelBar.Name = "panelBar";
            panelBar.Padding = new Padding(5);
            panelBar.Size = new Size(936, 56);
            panelBar.TabIndex = 1;
            // 
            // panelFront
            // 
            panelFront.BackColor = SystemColors.GradientInactiveCaption;
            panelFront.Controls.Add(groupBox1);
            panelFront.Dock = DockStyle.Fill;
            panelFront.Location = new Point(0, 0);
            panelFront.Name = "panelFront";
            panelFront.Size = new Size(936, 666);
            panelFront.TabIndex = 1;
            // 
            // Player
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 722);
            Controls.Add(panelFront);
            Controls.Add(panelBar);
            Controls.Add(panelRight);
            Name = "Player";
            Text = "XenPlayer";
            panelRight.ResumeLayout(false);
            panelCmd.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelBar.ResumeLayout(false);
            panelFront.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelRight;
        private ListView listView1;
        private GroupBox groupBox1;
        private Label lblTitle;
        private Label lblDuration;
        private Label lblMediaType;
        private XenLibrary.VolumeCtl volumeCtl1;
        private Panel panelBar;
        private Button btnDel;
        private Panel panelFront;
        private Button btnDelete;
        private Panel panelCmd;
        private XenLibrary.PlayerCtl playerCtl1;
        private Button btnFilr;
    }
}
