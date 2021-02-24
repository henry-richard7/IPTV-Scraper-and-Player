
namespace IPTV_Scraper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.label_Title = new System.Windows.Forms.Label();
            this.panelMainUI = new System.Windows.Forms.Panel();
            this.panel_TV_List = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalChannels = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCountryName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChannelNext = new System.Windows.Forms.Button();
            this.buttonChannelPrevious = new System.Windows.Forms.Button();
            this.buttonBackMainMenu = new System.Windows.Forms.Button();
            this.listView_channelList = new System.Windows.Forms.ListView();
            this.pictureCountryFlag = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panelMainUI.SuspendLayout();
            this.panel_TV_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCountryFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.AliceBlue;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(986, 541);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.Black;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(12, 5);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(633, 51);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "Select the country a watch Live TV";
            // 
            // panelMainUI
            // 
            this.panelMainUI.BackColor = System.Drawing.Color.Black;
            this.panelMainUI.Controls.Add(this.progressBar1);
            this.panelMainUI.Controls.Add(this.listView1);
            this.panelMainUI.Controls.Add(this.label_Title);
            this.panelMainUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainUI.Location = new System.Drawing.Point(0, 0);
            this.panelMainUI.Name = "panelMainUI";
            this.panelMainUI.Size = new System.Drawing.Size(1026, 659);
            this.panelMainUI.TabIndex = 2;
            // 
            // panel_TV_List
            // 
            this.panel_TV_List.Controls.Add(this.pictureCountryFlag);
            this.panel_TV_List.Controls.Add(this.label3);
            this.panel_TV_List.Controls.Add(this.labelTotalChannels);
            this.panel_TV_List.Controls.Add(this.label2);
            this.panel_TV_List.Controls.Add(this.labelCountryName);
            this.panel_TV_List.Controls.Add(this.label1);
            this.panel_TV_List.Controls.Add(this.buttonChannelNext);
            this.panel_TV_List.Controls.Add(this.buttonChannelPrevious);
            this.panel_TV_List.Controls.Add(this.buttonBackMainMenu);
            this.panel_TV_List.Controls.Add(this.listView_channelList);
            this.panel_TV_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_TV_List.Location = new System.Drawing.Point(0, 0);
            this.panel_TV_List.Name = "panel_TV_List";
            this.panel_TV_List.Size = new System.Drawing.Size(1026, 659);
            this.panel_TV_List.TabIndex = 2;
            this.panel_TV_List.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(470, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Note: If any channel exits after some time please select auto repeat in vlc!";
            // 
            // labelTotalChannels
            // 
            this.labelTotalChannels.AutoSize = true;
            this.labelTotalChannels.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalChannels.Location = new System.Drawing.Point(680, 25);
            this.labelTotalChannels.Name = "labelTotalChannels";
            this.labelTotalChannels.Size = new System.Drawing.Size(0, 25);
            this.labelTotalChannels.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Channels";
            // 
            // labelCountryName
            // 
            this.labelCountryName.AutoSize = true;
            this.labelCountryName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountryName.Location = new System.Drawing.Point(191, 25);
            this.labelCountryName.Name = "labelCountryName";
            this.labelCountryName.Size = new System.Drawing.Size(0, 25);
            this.labelCountryName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Country";
            // 
            // buttonChannelNext
            // 
            this.buttonChannelNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChannelNext.Location = new System.Drawing.Point(852, 605);
            this.buttonChannelNext.Name = "buttonChannelNext";
            this.buttonChannelNext.Size = new System.Drawing.Size(155, 42);
            this.buttonChannelNext.TabIndex = 3;
            this.buttonChannelNext.Text = "Next";
            this.buttonChannelNext.UseVisualStyleBackColor = true;
            this.buttonChannelNext.Click += new System.EventHandler(this.buttonChannelNext_Click);
            // 
            // buttonChannelPrevious
            // 
            this.buttonChannelPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChannelPrevious.Location = new System.Drawing.Point(21, 605);
            this.buttonChannelPrevious.Name = "buttonChannelPrevious";
            this.buttonChannelPrevious.Size = new System.Drawing.Size(155, 42);
            this.buttonChannelPrevious.TabIndex = 2;
            this.buttonChannelPrevious.Text = "Previous";
            this.buttonChannelPrevious.UseVisualStyleBackColor = true;
            this.buttonChannelPrevious.Click += new System.EventHandler(this.buttonChannelPrevious_Click);
            // 
            // buttonBackMainMenu
            // 
            this.buttonBackMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackMainMenu.Location = new System.Drawing.Point(875, 17);
            this.buttonBackMainMenu.Name = "buttonBackMainMenu";
            this.buttonBackMainMenu.Size = new System.Drawing.Size(132, 47);
            this.buttonBackMainMenu.TabIndex = 1;
            this.buttonBackMainMenu.Text = "Go Back";
            this.buttonBackMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackMainMenu.Click += new System.EventHandler(this.buttonBackMainMenu_Click);
            // 
            // listView_channelList
            // 
            this.listView_channelList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_channelList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_channelList.HideSelection = false;
            this.listView_channelList.Location = new System.Drawing.Point(21, 74);
            this.listView_channelList.Name = "listView_channelList";
            this.listView_channelList.Size = new System.Drawing.Size(986, 515);
            this.listView_channelList.TabIndex = 0;
            this.listView_channelList.UseCompatibleStateImageBehavior = false;
            this.listView_channelList.View = System.Windows.Forms.View.Tile;
            this.listView_channelList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_channelList_MouseClick);
            // 
            // pictureCountryFlag
            // 
            this.pictureCountryFlag.Location = new System.Drawing.Point(21, 17);
            this.pictureCountryFlag.Name = "pictureCountryFlag";
            this.pictureCountryFlag.Size = new System.Drawing.Size(67, 47);
            this.pictureCountryFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureCountryFlag.TabIndex = 9;
            this.pictureCountryFlag.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(21, 623);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(986, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 659);
            this.Controls.Add(this.panelMainUI);
            this.Controls.Add(this.panel_TV_List);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "IPTV Scraper and Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMainUI.ResumeLayout(false);
            this.panelMainUI.PerformLayout();
            this.panel_TV_List.ResumeLayout(false);
            this.panel_TV_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCountryFlag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Panel panelMainUI;
        private System.Windows.Forms.Panel panel_TV_List;
        private System.Windows.Forms.Button buttonChannelNext;
        private System.Windows.Forms.Button buttonChannelPrevious;
        private System.Windows.Forms.Button buttonBackMainMenu;
        private System.Windows.Forms.ListView listView_channelList;
        private System.Windows.Forms.Label labelTotalChannels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCountryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureCountryFlag;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

