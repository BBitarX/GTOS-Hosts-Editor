namespace GTOS_Hosts_Editor
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabHosts = new System.Windows.Forms.TabPage();
            this.txtHosts = new DrakeUI.Framework.DrakeUIRichTextBox();
            this.drakeUIGroupBox1 = new DrakeUI.Framework.DrakeUIGroupBox();
            this.btnJoin = new MaterialSkin.Controls.MaterialButton();
            this.btnRefresh = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnWhatsapp = new DrakeUI.Framework.DrakeUIImageButton();
            this.btnDiscord = new DrakeUI.Framework.DrakeUIImageButton();
            this.btnGithub = new DrakeUI.Framework.DrakeUIImageButton();
            this.drakeUIGroupBox2 = new DrakeUI.Framework.DrakeUIGroupBox();
            this.txtInfo = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.tabControl.SuspendLayout();
            this.tabHosts.SuspendLayout();
            this.drakeUIGroupBox1.SuspendLayout();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnWhatsapp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDiscord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGithub)).BeginInit();
            this.drakeUIGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHosts);
            this.tabControl.Controls.Add(this.tabInfo);
            this.tabControl.Depth = 0;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tabControl.ImageList = this.imageList1;
            this.tabControl.Location = new System.Drawing.Point(3, 64);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(637, 343);
            this.tabControl.TabIndex = 0;
            // 
            // tabHosts
            // 
            this.tabHosts.Controls.Add(this.txtHosts);
            this.tabHosts.Controls.Add(this.drakeUIGroupBox1);
            this.tabHosts.ImageKey = "hosts.png";
            this.tabHosts.Location = new System.Drawing.Point(4, 39);
            this.tabHosts.Name = "tabHosts";
            this.tabHosts.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabHosts.Size = new System.Drawing.Size(629, 300);
            this.tabHosts.TabIndex = 0;
            this.tabHosts.Text = "Hosts";
            this.tabHosts.UseVisualStyleBackColor = true;
            // 
            // txtHosts
            // 
            this.txtHosts.AutoWordSelection = true;
            this.txtHosts.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHosts.FillColor = System.Drawing.Color.White;
            this.txtHosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHosts.Location = new System.Drawing.Point(3, 3);
            this.txtHosts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHosts.Name = "txtHosts";
            this.txtHosts.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHosts.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.txtHosts.Size = new System.Drawing.Size(623, 195);
            this.txtHosts.Style = DrakeUI.Framework.UIStyle.Custom;
            this.txtHosts.StyleCustomMode = true;
            this.txtHosts.TabIndex = 1;
            // 
            // drakeUIGroupBox1
            // 
            this.drakeUIGroupBox1.Controls.Add(this.btnJoin);
            this.drakeUIGroupBox1.Controls.Add(this.btnRefresh);
            this.drakeUIGroupBox1.Controls.Add(this.btnSave);
            this.drakeUIGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.drakeUIGroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.drakeUIGroupBox1.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.drakeUIGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUIGroupBox1.Location = new System.Drawing.Point(3, 195);
            this.drakeUIGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drakeUIGroupBox1.Name = "drakeUIGroupBox1";
            this.drakeUIGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.drakeUIGroupBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.drakeUIGroupBox1.Size = new System.Drawing.Size(623, 102);
            this.drakeUIGroupBox1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIGroupBox1.TabIndex = 0;
            this.drakeUIGroupBox1.Text = "Actions";
            // 
            // btnJoin
            // 
            this.btnJoin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnJoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJoin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnJoin.Depth = 0;
            this.btnJoin.HighEmphasis = true;
            this.btnJoin.Icon = null;
            this.btnJoin.Location = new System.Drawing.Point(403, 43);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnJoin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnJoin.Size = new System.Drawing.Size(153, 36);
            this.btnJoin.TabIndex = 2;
            this.btnJoin.Text = "JOIN GTOS SERVER";
            this.btnJoin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnJoin.UseAccentColor = false;
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRefresh.Depth = 0;
            this.btnRefresh.HighEmphasis = true;
            this.btnRefresh.Icon = null;
            this.btnRefresh.Location = new System.Drawing.Point(155, 43);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRefresh.Size = new System.Drawing.Size(117, 36);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "REFRESH FILE";
            this.btnRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRefresh.UseAccentColor = false;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(17, 43);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(114, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "    SAVE HOST    ";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.txtInfo);
            this.tabInfo.Controls.Add(this.drakeUIGroupBox2);
            this.tabInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tabInfo.ImageKey = "info.png";
            this.tabInfo.Location = new System.Drawing.Point(4, 39);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabInfo.Size = new System.Drawing.Size(629, 300);
            this.tabInfo.TabIndex = 1;
            this.tabInfo.Text = "Info";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "info.png");
            this.imageList1.Images.SetKeyName(1, "hosts.png");
            // 
            // btnWhatsapp
            // 
            this.btnWhatsapp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWhatsapp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhatsapp.Image = global::GTOS_Hosts_Editor.Properties.Resources.whatsapp;
            this.btnWhatsapp.Location = new System.Drawing.Point(34, 163);
            this.btnWhatsapp.Name = "btnWhatsapp";
            this.btnWhatsapp.Size = new System.Drawing.Size(157, 38);
            this.btnWhatsapp.TabIndex = 2;
            this.btnWhatsapp.TabStop = false;
            this.btnWhatsapp.Text = "  WhatsApp";
            this.btnWhatsapp.Click += new System.EventHandler(this.btnWhatsapp_Click);
            // 
            // btnDiscord
            // 
            this.btnDiscord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscord.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscord.Image = global::GTOS_Hosts_Editor.Properties.Resources.discord;
            this.btnDiscord.Location = new System.Drawing.Point(34, 107);
            this.btnDiscord.Name = "btnDiscord";
            this.btnDiscord.Size = new System.Drawing.Size(157, 38);
            this.btnDiscord.TabIndex = 1;
            this.btnDiscord.TabStop = false;
            this.btnDiscord.Text = "Discord";
            this.btnDiscord.Click += new System.EventHandler(this.btnDiscord_Click);
            // 
            // btnGithub
            // 
            this.btnGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGithub.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGithub.Image = global::GTOS_Hosts_Editor.Properties.Resources.github;
            this.btnGithub.Location = new System.Drawing.Point(34, 51);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(157, 38);
            this.btnGithub.TabIndex = 0;
            this.btnGithub.TabStop = false;
            this.btnGithub.Text = "Github";
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // drakeUIGroupBox2
            // 
            this.drakeUIGroupBox2.Controls.Add(this.btnWhatsapp);
            this.drakeUIGroupBox2.Controls.Add(this.btnGithub);
            this.drakeUIGroupBox2.Controls.Add(this.btnDiscord);
            this.drakeUIGroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.drakeUIGroupBox2.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.drakeUIGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUIGroupBox2.Location = new System.Drawing.Point(302, 21);
            this.drakeUIGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drakeUIGroupBox2.Name = "drakeUIGroupBox2";
            this.drakeUIGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.drakeUIGroupBox2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.drakeUIGroupBox2.Size = new System.Drawing.Size(221, 245);
            this.drakeUIGroupBox2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIGroupBox2.TabIndex = 3;
            this.drakeUIGroupBox2.Text = "Socials";
            // 
            // txtInfo
            // 
            this.txtInfo.AnimateReadOnly = false;
            this.txtInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtInfo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInfo.Depth = 0;
            this.txtInfo.HideSelection = true;
            this.txtInfo.Location = new System.Drawing.Point(24, 21);
            this.txtInfo.MaxLength = 32767;
            this.txtInfo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.PasswordChar = '\0';
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo.SelectedText = "";
            this.txtInfo.SelectionLength = 0;
            this.txtInfo.SelectionStart = 0;
            this.txtInfo.ShortcutsEnabled = true;
            this.txtInfo.Size = new System.Drawing.Size(254, 245);
            this.txtInfo.TabIndex = 5;
            this.txtInfo.TabStop = false;
            this.txtInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtInfo.UseSystemPasswordChar = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 410);
            this.Controls.Add(this.tabControl);
            this.DrawerAutoShow = true;
            this.DrawerBackgroundWithAccent = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabControl;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "GTOS Hosts Editor";
            this.tabControl.ResumeLayout(false);
            this.tabHosts.ResumeLayout(false);
            this.drakeUIGroupBox1.ResumeLayout(false);
            this.drakeUIGroupBox1.PerformLayout();
            this.tabInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnWhatsapp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDiscord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGithub)).EndInit();
            this.drakeUIGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tabHosts;
        private System.Windows.Forms.TabPage tabInfo;
        private DrakeUI.Framework.DrakeUIGroupBox drakeUIGroupBox1;
        private DrakeUI.Framework.DrakeUIRichTextBox txtHosts;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnJoin;
        private MaterialSkin.Controls.MaterialButton btnRefresh;
        public System.Windows.Forms.ImageList imageList1;
        private DrakeUI.Framework.DrakeUIImageButton btnGithub;
        private DrakeUI.Framework.DrakeUIImageButton btnDiscord;
        private DrakeUI.Framework.DrakeUIImageButton btnWhatsapp;
        private DrakeUI.Framework.DrakeUIGroupBox drakeUIGroupBox2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtInfo;
    }
}

