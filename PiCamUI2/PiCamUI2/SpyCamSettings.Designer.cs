namespace PiCamUI2
{
    partial class SpyCamSettingsMenu
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
            this.connectedCameraslist = new System.Windows.Forms.ListBox();
            this.cameraListlbl = new System.Windows.Forms.Label();
            this.liveViewbtn = new System.Windows.Forms.Button();
            this.cameraSettingsbtn = new System.Windows.Forms.Button();
            this.addCamerabtn = new System.Windows.Forms.Button();
            this.disconnectCamerabtn = new System.Windows.Forms.Button();
            this.syncCamerabtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectedCameraslist
            // 
            this.connectedCameraslist.FormattingEnabled = true;
            this.connectedCameraslist.Items.AddRange(new object[] {
            "Camera 1"});
            this.connectedCameraslist.Location = new System.Drawing.Point(15, 25);
            this.connectedCameraslist.Name = "connectedCameraslist";
            this.connectedCameraslist.Size = new System.Drawing.Size(239, 212);
            this.connectedCameraslist.TabIndex = 0;
            // 
            // cameraListlbl
            // 
            this.cameraListlbl.AutoSize = true;
            this.cameraListlbl.Location = new System.Drawing.Point(12, 9);
            this.cameraListlbl.Name = "cameraListlbl";
            this.cameraListlbl.Size = new System.Drawing.Size(103, 13);
            this.cameraListlbl.TabIndex = 1;
            this.cameraListlbl.Text = "Connected Cameras";
            // 
            // liveViewbtn
            // 
            this.liveViewbtn.Location = new System.Drawing.Point(260, 34);
            this.liveViewbtn.Name = "liveViewbtn";
            this.liveViewbtn.Size = new System.Drawing.Size(99, 34);
            this.liveViewbtn.TabIndex = 2;
            this.liveViewbtn.Text = "Show Live Feed";
            this.liveViewbtn.UseVisualStyleBackColor = true;
            // 
            // cameraSettingsbtn
            // 
            this.cameraSettingsbtn.Location = new System.Drawing.Point(260, 74);
            this.cameraSettingsbtn.Name = "cameraSettingsbtn";
            this.cameraSettingsbtn.Size = new System.Drawing.Size(99, 34);
            this.cameraSettingsbtn.TabIndex = 3;
            this.cameraSettingsbtn.Text = "Camera Settings";
            this.cameraSettingsbtn.UseVisualStyleBackColor = true;
            // 
            // addCamerabtn
            // 
            this.addCamerabtn.Location = new System.Drawing.Point(260, 154);
            this.addCamerabtn.Name = "addCamerabtn";
            this.addCamerabtn.Size = new System.Drawing.Size(99, 34);
            this.addCamerabtn.TabIndex = 4;
            this.addCamerabtn.Text = "Add Camera";
            this.addCamerabtn.UseVisualStyleBackColor = true;
            // 
            // disconnectCamerabtn
            // 
            this.disconnectCamerabtn.Location = new System.Drawing.Point(260, 194);
            this.disconnectCamerabtn.Name = "disconnectCamerabtn";
            this.disconnectCamerabtn.Size = new System.Drawing.Size(99, 34);
            this.disconnectCamerabtn.TabIndex = 5;
            this.disconnectCamerabtn.Text = "Disconnect Camera";
            this.disconnectCamerabtn.UseVisualStyleBackColor = true;
            // 
            // syncCamerabtn
            // 
            this.syncCamerabtn.Location = new System.Drawing.Point(260, 114);
            this.syncCamerabtn.Name = "syncCamerabtn";
            this.syncCamerabtn.Size = new System.Drawing.Size(99, 34);
            this.syncCamerabtn.TabIndex = 6;
            this.syncCamerabtn.Text = "Sync Camera";
            this.syncCamerabtn.UseVisualStyleBackColor = true;
            // 
            // SpyCamSettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 259);
            this.Controls.Add(this.syncCamerabtn);
            this.Controls.Add(this.disconnectCamerabtn);
            this.Controls.Add(this.addCamerabtn);
            this.Controls.Add(this.cameraSettingsbtn);
            this.Controls.Add(this.liveViewbtn);
            this.Controls.Add(this.cameraListlbl);
            this.Controls.Add(this.connectedCameraslist);
            this.Name = "SpyCamSettingsMenu";
            this.Text = "SpyCam Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox connectedCameraslist;
        private System.Windows.Forms.Label cameraListlbl;
        private System.Windows.Forms.Button liveViewbtn;
        private System.Windows.Forms.Button cameraSettingsbtn;
        private System.Windows.Forms.Button addCamerabtn;
        private System.Windows.Forms.Button disconnectCamerabtn;
        private System.Windows.Forms.Button syncCamerabtn;
    }
}

