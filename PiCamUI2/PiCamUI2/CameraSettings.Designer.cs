namespace PiCamUI2
{
    partial class CameraSettings
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
            this.fileLengthlbl = new System.Windows.Forms.Label();
            this.hourschkbx = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSizechkbx = new System.Windows.Forms.CheckBox();
            this.fileSizelbl = new System.Windows.Forms.Label();
            this.syncCamerabtn = new System.Windows.Forms.Button();
            this.liveFeedbtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileLengthlbl
            // 
            this.fileLengthlbl.AutoSize = true;
            this.fileLengthlbl.Location = new System.Drawing.Point(33, 13);
            this.fileLengthlbl.Name = "fileLengthlbl";
            this.fileLengthlbl.Size = new System.Drawing.Size(117, 13);
            this.fileLengthlbl.TabIndex = 0;
            this.fileLengthlbl.Text = "File Length (In Hours) : ";
            // 
            // hourschkbx
            // 
            this.hourschkbx.AutoSize = true;
            this.hourschkbx.Location = new System.Drawing.Point(12, 12);
            this.hourschkbx.Name = "hourschkbx";
            this.hourschkbx.Size = new System.Drawing.Size(15, 14);
            this.hourschkbx.TabIndex = 1;
            this.hourschkbx.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(473, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // fileSizechkbx
            // 
            this.fileSizechkbx.AutoSize = true;
            this.fileSizechkbx.Location = new System.Drawing.Point(12, 42);
            this.fileSizechkbx.Name = "fileSizechkbx";
            this.fileSizechkbx.Size = new System.Drawing.Size(15, 14);
            this.fileSizechkbx.TabIndex = 3;
            this.fileSizechkbx.UseVisualStyleBackColor = true;
            // 
            // fileSizelbl
            // 
            this.fileSizelbl.AutoSize = true;
            this.fileSizelbl.Location = new System.Drawing.Point(33, 42);
            this.fileSizelbl.Name = "fileSizelbl";
            this.fileSizelbl.Size = new System.Drawing.Size(91, 13);
            this.fileSizelbl.TabIndex = 4;
            this.fileSizelbl.Text = "File Size (In GB) : ";
            // 
            // syncCamerabtn
            // 
            this.syncCamerabtn.Location = new System.Drawing.Point(143, 407);
            this.syncCamerabtn.Name = "syncCamerabtn";
            this.syncCamerabtn.Size = new System.Drawing.Size(114, 43);
            this.syncCamerabtn.TabIndex = 5;
            this.syncCamerabtn.Text = "Sync Camera";
            this.syncCamerabtn.UseVisualStyleBackColor = true;
            // 
            // liveFeedbtn
            // 
            this.liveFeedbtn.Location = new System.Drawing.Point(12, 407);
            this.liveFeedbtn.Name = "liveFeedbtn";
            this.liveFeedbtn.Size = new System.Drawing.Size(114, 43);
            this.liveFeedbtn.TabIndex = 6;
            this.liveFeedbtn.Text = "View Live Feed";
            this.liveFeedbtn.UseVisualStyleBackColor = true;
            // 
            // CameraSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 462);
            this.Controls.Add(this.liveFeedbtn);
            this.Controls.Add(this.syncCamerabtn);
            this.Controls.Add(this.fileSizelbl);
            this.Controls.Add(this.fileSizechkbx);
            this.Controls.Add(this.hourschkbx);
            this.Controls.Add(this.fileLengthlbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CameraSettings";
            this.Text = "Camera Settings";
            this.Load += new System.EventHandler(this.CameraSettings_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileLengthlbl;
        private System.Windows.Forms.CheckBox hourschkbx;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.CheckBox fileSizechkbx;
        private System.Windows.Forms.Label fileSizelbl;
        private System.Windows.Forms.Button syncCamerabtn;
        private System.Windows.Forms.Button liveFeedbtn;
    }
}