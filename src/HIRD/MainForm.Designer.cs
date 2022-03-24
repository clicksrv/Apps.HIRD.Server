using HIRD.Service;

namespace HIRD.ServerUI
{
    partial class MainForm
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
                _loggerFactory.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.startStopServerButton = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.compNameText = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.ipText = new System.Windows.Forms.Label();
            this.connectedClientsList = new System.Windows.Forms.ListBox();
            this.connectedClientsLabel = new System.Windows.Forms.Label();
            this.statusIndicator = new System.Windows.Forms.PictureBox();
            this.statusGroup = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItem_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem_startServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_stopServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Error = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.serverInfoGroup = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.statusIndicator)).BeginInit();
            this.statusGroup.SuspendLayout();
            this.trayContextMenu.SuspendLayout();
            this.serverInfoGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startStopServerButton
            // 
            this.startStopServerButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.startStopServerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startStopServerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startStopServerButton.Location = new System.Drawing.Point(154, 0);
            this.startStopServerButton.Name = "startStopServerButton";
            this.startStopServerButton.Size = new System.Drawing.Size(108, 31);
            this.startStopServerButton.TabIndex = 1;
            this.startStopServerButton.Text = "Start Server";
            this.startStopServerButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startStopServerButton.UseVisualStyleBackColor = true;
            this.startStopServerButton.CheckedChanged += new System.EventHandler(this.StartStopServerButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(11, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Computer Name";
            // 
            // compNameText
            // 
            this.compNameText.AutoSize = true;
            this.compNameText.CausesValidation = false;
            this.compNameText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.compNameText.Location = new System.Drawing.Point(11, 40);
            this.compNameText.Name = "compNameText";
            this.compNameText.Size = new System.Drawing.Size(49, 19);
            this.compNameText.TabIndex = 5;
            this.compNameText.Text = "Name";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ipLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ipLabel.Location = new System.Drawing.Point(11, 68);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(77, 12);
            this.ipLabel.TabIndex = 2;
            this.ipLabel.Text = "Local IP Address";
            // 
            // ipText
            // 
            this.ipText.AutoSize = true;
            this.ipText.CausesValidation = false;
            this.ipText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ipText.Location = new System.Drawing.Point(10, 80);
            this.ipText.Name = "ipText";
            this.ipText.Size = new System.Drawing.Size(85, 19);
            this.ipText.TabIndex = 3;
            this.ipText.Text = "192.168.0.x";
            // 
            // connectedClientsList
            // 
            this.connectedClientsList.BackColor = System.Drawing.SystemColors.Window;
            this.connectedClientsList.Enabled = false;
            this.connectedClientsList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connectedClientsList.FormattingEnabled = true;
            this.connectedClientsList.HorizontalScrollbar = true;
            this.connectedClientsList.IntegralHeight = false;
            this.connectedClientsList.Location = new System.Drawing.Point(11, 62);
            this.connectedClientsList.Name = "connectedClientsList";
            this.connectedClientsList.Size = new System.Drawing.Size(251, 93);
            this.connectedClientsList.TabIndex = 7;
            this.connectedClientsList.Visible = false;
            // 
            // connectedClientsLabel
            // 
            this.connectedClientsLabel.AutoSize = true;
            this.connectedClientsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connectedClientsLabel.Location = new System.Drawing.Point(11, 45);
            this.connectedClientsLabel.Name = "connectedClientsLabel";
            this.connectedClientsLabel.Size = new System.Drawing.Size(104, 15);
            this.connectedClientsLabel.TabIndex = 8;
            this.connectedClientsLabel.Text = "Connected Clients";
            this.connectedClientsLabel.Visible = false;
            // 
            // statusIndicator
            // 
            this.statusIndicator.BackgroundImage = global::HIRD.Properties.Resources.bullet_red;
            this.statusIndicator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.statusIndicator.InitialImage = global::HIRD.Properties.Resources.bullet_red;
            this.statusIndicator.Location = new System.Drawing.Point(134, 14);
            this.statusIndicator.Name = "statusIndicator";
            this.statusIndicator.Size = new System.Drawing.Size(16, 16);
            this.statusIndicator.TabIndex = 9;
            this.statusIndicator.TabStop = false;
            // 
            // statusGroup
            // 
            this.statusGroup.Controls.Add(this.startStopServerButton);
            this.statusGroup.Controls.Add(this.connectedClientsLabel);
            this.statusGroup.Controls.Add(this.statusIndicator);
            this.statusGroup.Controls.Add(this.connectedClientsList);
            this.statusGroup.Controls.Add(this.statusLabel);
            this.statusGroup.Controls.Add(this.errorLabel);
            this.statusGroup.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.statusGroup.Location = new System.Drawing.Point(12, 31);
            this.statusGroup.Name = "statusGroup";
            this.statusGroup.Size = new System.Drawing.Size(274, 168);
            this.statusGroup.TabIndex = 10;
            this.statusGroup.TabStop = false;
            this.statusGroup.Text = "Status";
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.ForeColor = System.Drawing.Color.Black;
            this.statusLabel.Location = new System.Drawing.Point(11, 21);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(117, 18);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "status";
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.errorLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.errorLabel.Location = new System.Drawing.Point(11, 46);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(251, 33);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.Visible = false;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "HIRD";
            this.notifyIcon.BalloonTipTitle = "status";
            this.notifyIcon.ContextMenuStrip = this.trayContextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "HIRD";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Show,
            this.menuItem_Settings,
            this.toolStripSeparator2,
            this.menuItem_startServer,
            this.menuItem_stopServer,
            this.menuItem_Error,
            this.toolStripSeparator1,
            this.menuItem_Exit,
            this.toolStripSeparator3});
            this.trayContextMenu.Name = "trayContextMenu";
            this.trayContextMenu.Size = new System.Drawing.Size(181, 176);
            // 
            // menuItem_Show
            // 
            this.menuItem_Show.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuItem_Show.Name = "menuItem_Show";
            this.menuItem_Show.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Show.Text = "Show";
            this.menuItem_Show.Click += new System.EventHandler(this.menuItem_Show_Click);
            // 
            // menuItem_Settings
            // 
            this.menuItem_Settings.Name = "menuItem_Settings";
            this.menuItem_Settings.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Settings.Text = "Settings";
            this.menuItem_Settings.Click += new System.EventHandler(this.menuItem_Settings_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // menuItem_startServer
            // 
            this.menuItem_startServer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuItem_startServer.Name = "menuItem_startServer";
            this.menuItem_startServer.Size = new System.Drawing.Size(180, 22);
            this.menuItem_startServer.Text = "Start Server";
            this.menuItem_startServer.Click += new System.EventHandler(this.menuItem_startServer_Click);
            // 
            // menuItem_stopServer
            // 
            this.menuItem_stopServer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuItem_stopServer.Name = "menuItem_stopServer";
            this.menuItem_stopServer.Size = new System.Drawing.Size(180, 22);
            this.menuItem_stopServer.Text = "Stop Server";
            this.menuItem_stopServer.Click += new System.EventHandler(this.menuItem_stopServer_Click);
            // 
            // menuItem_Error
            // 
            this.menuItem_Error.ForeColor = System.Drawing.Color.Crimson;
            this.menuItem_Error.Name = "menuItem_Error";
            this.menuItem_Error.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Error.Text = "Error";
            this.menuItem_Error.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuItem_Exit
            // 
            this.menuItem_Exit.Name = "menuItem_Exit";
            this.menuItem_Exit.Size = new System.Drawing.Size(180, 22);
            this.menuItem_Exit.Text = "Exit";
            this.menuItem_Exit.Click += new System.EventHandler(this.menuItem_Exit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // serverInfoGroup
            // 
            this.serverInfoGroup.Controls.Add(this.compNameText);
            this.serverInfoGroup.Controls.Add(this.label2);
            this.serverInfoGroup.Controls.Add(this.ipLabel);
            this.serverInfoGroup.Controls.Add(this.ipText);
            this.serverInfoGroup.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.serverInfoGroup.Location = new System.Drawing.Point(12, 205);
            this.serverInfoGroup.Name = "serverInfoGroup";
            this.serverInfoGroup.Size = new System.Drawing.Size(274, 145);
            this.serverInfoGroup.TabIndex = 15;
            this.serverInfoGroup.TabStop = false;
            this.serverInfoGroup.Text = "Server Info";
            this.serverInfoGroup.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(298, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 362);
            this.Controls.Add(this.serverInfoGroup);
            this.Controls.Add(this.statusGroup);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(314, 401);
            this.MinimumSize = new System.Drawing.Size(314, 401);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "HIRD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.statusIndicator)).EndInit();
            this.statusGroup.ResumeLayout(false);
            this.statusGroup.PerformLayout();
            this.trayContextMenu.ResumeLayout(false);
            this.serverInfoGroup.ResumeLayout(false);
            this.serverInfoGroup.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckBox startStopServerButton;
        private Label label2;
        private Label compNameText;
        private Label ipLabel;
        private Label ipText;
        private ListBox connectedClientsList;
        private Label connectedClientsLabel;
        private PictureBox statusIndicator;
        private GroupBox statusGroup;
        private Label statusLabel;
        private NotifyIcon notifyIcon;
        private GroupBox serverInfoGroup;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Label errorLabel;
        private ContextMenuStrip trayContextMenu;
        private ToolStripMenuItem menuItem_Show;
        private ToolStripMenuItem menuItem_Settings;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem menuItem_startServer;
        private ToolStripMenuItem menuItem_stopServer;
        private ToolStripMenuItem menuItem_Error;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuItem_Exit;
        private ToolStripSeparator toolStripSeparator3;
    }
}