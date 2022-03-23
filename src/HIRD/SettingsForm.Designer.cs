namespace HIRD.ServerUI
{
    partial class SettingsForm
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
            this.autoStart = new System.Windows.Forms.CheckBox();
            this.minToTray = new System.Windows.Forms.CheckBox();
            this.startMin = new System.Windows.Forms.CheckBox();
            this.startAtWindowsStart = new System.Windows.Forms.CheckBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.startSettingsGroup = new System.Windows.Forms.GroupBox();
            this.generalSettingsGroup = new System.Windows.Forms.GroupBox();
            this.startSettingsGroup.SuspendLayout();
            this.generalSettingsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoStart
            // 
            this.autoStart.AutoSize = true;
            this.autoStart.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autoStart.Location = new System.Drawing.Point(18, 52);
            this.autoStart.Name = "autoStart";
            this.autoStart.Size = new System.Drawing.Size(112, 17);
            this.autoStart.TabIndex = 14;
            this.autoStart.Text = "Auto Start Server";
            this.autoStart.UseVisualStyleBackColor = true;
            this.autoStart.CheckedChanged += new System.EventHandler(this.autoStart_CheckedChanged);
            // 
            // minToTray
            // 
            this.minToTray.AutoSize = true;
            this.minToTray.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minToTray.Location = new System.Drawing.Point(18, 28);
            this.minToTray.Name = "minToTray";
            this.minToTray.Size = new System.Drawing.Size(110, 17);
            this.minToTray.TabIndex = 12;
            this.minToTray.Text = "Minimize to Tray";
            this.minToTray.UseVisualStyleBackColor = true;
            this.minToTray.CheckedChanged += new System.EventHandler(this.minToTray_CheckedChanged);
            // 
            // startMin
            // 
            this.startMin.AutoSize = true;
            this.startMin.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startMin.Location = new System.Drawing.Point(18, 75);
            this.startMin.Name = "startMin";
            this.startMin.Size = new System.Drawing.Size(106, 17);
            this.startMin.TabIndex = 13;
            this.startMin.Text = "Start Minimized";
            this.startMin.UseVisualStyleBackColor = true;
            this.startMin.CheckedChanged += new System.EventHandler(this.startMin_CheckedChanged);
            // 
            // startAtWindowsStart
            // 
            this.startAtWindowsStart.AutoSize = true;
            this.startAtWindowsStart.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startAtWindowsStart.Location = new System.Drawing.Point(18, 30);
            this.startAtWindowsStart.Name = "startAtWindowsStart";
            this.startAtWindowsStart.Size = new System.Drawing.Size(124, 17);
            this.startAtWindowsStart.TabIndex = 11;
            this.startAtWindowsStart.Text = "Start with Windows";
            this.startAtWindowsStart.UseVisualStyleBackColor = true;
            this.startAtWindowsStart.CheckedChanged += new System.EventHandler(this.startAtWindowsStart_CheckedChanged);
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Location = new System.Drawing.Point(107, 202);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 15;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // startSettingsGroup
            // 
            this.startSettingsGroup.Controls.Add(this.autoStart);
            this.startSettingsGroup.Controls.Add(this.startAtWindowsStart);
            this.startSettingsGroup.Controls.Add(this.startMin);
            this.startSettingsGroup.Location = new System.Drawing.Point(12, 12);
            this.startSettingsGroup.Name = "startSettingsGroup";
            this.startSettingsGroup.Size = new System.Drawing.Size(170, 111);
            this.startSettingsGroup.TabIndex = 16;
            this.startSettingsGroup.TabStop = false;
            this.startSettingsGroup.Text = "Startup";
            // 
            // generalSettingsGroup
            // 
            this.generalSettingsGroup.Controls.Add(this.minToTray);
            this.generalSettingsGroup.Location = new System.Drawing.Point(12, 129);
            this.generalSettingsGroup.Name = "generalSettingsGroup";
            this.generalSettingsGroup.Size = new System.Drawing.Size(170, 64);
            this.generalSettingsGroup.TabIndex = 17;
            this.generalSettingsGroup.TabStop = false;
            this.generalSettingsGroup.Text = "General";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(197, 239);
            this.Controls.Add(this.generalSettingsGroup);
            this.Controls.Add(this.startSettingsGroup);
            this.Controls.Add(this.closeButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(213, 278);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(213, 278);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "HIRD Settings";
            this.startSettingsGroup.ResumeLayout(false);
            this.startSettingsGroup.PerformLayout();
            this.generalSettingsGroup.ResumeLayout(false);
            this.generalSettingsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        

        private CheckBox autoStart;
        private CheckBox minToTray;
        private CheckBox startMin;
        private CheckBox startAtWindowsStart;
        private Button closeButton;
        private GroupBox startSettingsGroup;
        private GroupBox generalSettingsGroup;
    }
}