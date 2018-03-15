namespace VelibServerGui
{
    partial class VelibServerForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VelibServerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MonitoringButton = new System.Windows.Forms.Button();
            this.CacheButton = new System.Windows.Forms.Button();
            this.JCDecaux = new System.Windows.Forms.Panel();
            this.ButtonSidePanel = new System.Windows.Forms.Panel();
            this.CachePanel = new System.Windows.Forms.Panel();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.Info = new System.Windows.Forms.Label();
            this.SlidingExpirationTimeComboBox = new System.Windows.Forms.ComboBox();
            this.SlidingExpirationTime = new System.Windows.Forms.Label();
            this.ApplyChangesButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AbsoluteExpirationTimeComboBox = new System.Windows.Forms.ComboBox();
            this.AbsoluteExpirationTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.CachePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MonitoringButton);
            this.panel1.Controls.Add(this.CacheButton);
            this.panel1.Controls.Add(this.JCDecaux);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 529);
            this.panel1.TabIndex = 0;
            // 
            // MonitoringButton
            // 
            this.MonitoringButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MonitoringButton.BackgroundImage")));
            this.MonitoringButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MonitoringButton.FlatAppearance.BorderSize = 0;
            this.MonitoringButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonitoringButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonitoringButton.ForeColor = System.Drawing.Color.White;
            this.MonitoringButton.Location = new System.Drawing.Point(3, 264);
            this.MonitoringButton.Name = "MonitoringButton";
            this.MonitoringButton.Size = new System.Drawing.Size(195, 100);
            this.MonitoringButton.TabIndex = 2;
            this.MonitoringButton.Text = "Monitoring";
            this.MonitoringButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MonitoringButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MonitoringButton.UseVisualStyleBackColor = true;
            this.MonitoringButton.Click += new System.EventHandler(this.Monitoring_Click);
            this.MonitoringButton.MouseHover += new System.EventHandler(this.MonitoringButton_MouseHover);
            // 
            // CacheButton
            // 
            this.CacheButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CacheButton.BackgroundImage")));
            this.CacheButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CacheButton.FlatAppearance.BorderSize = 0;
            this.CacheButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CacheButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CacheButton.ForeColor = System.Drawing.Color.White;
            this.CacheButton.Location = new System.Drawing.Point(3, 158);
            this.CacheButton.Name = "CacheButton";
            this.CacheButton.Size = new System.Drawing.Size(195, 100);
            this.CacheButton.TabIndex = 1;
            this.CacheButton.Text = "Cache";
            this.CacheButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CacheButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CacheButton.UseVisualStyleBackColor = true;
            this.CacheButton.Click += new System.EventHandler(this.Cache_Click);
            this.CacheButton.MouseHover += new System.EventHandler(this.CacheButton_MouseHover);
            // 
            // JCDecaux
            // 
            this.JCDecaux.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.JCDecaux.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("JCDecaux.BackgroundImage")));
            this.JCDecaux.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.JCDecaux.Dock = System.Windows.Forms.DockStyle.Top;
            this.JCDecaux.Location = new System.Drawing.Point(0, 0);
            this.JCDecaux.Name = "JCDecaux";
            this.JCDecaux.Size = new System.Drawing.Size(201, 100);
            this.JCDecaux.TabIndex = 0;
            this.JCDecaux.Click += new System.EventHandler(this.JCDecaux_Click);
            // 
            // ButtonSidePanel
            // 
            this.ButtonSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonSidePanel.Location = new System.Drawing.Point(201, 158);
            this.ButtonSidePanel.Name = "ButtonSidePanel";
            this.ButtonSidePanel.Size = new System.Drawing.Size(5, 100);
            this.ButtonSidePanel.TabIndex = 3;
            // 
            // CachePanel
            // 
            this.CachePanel.Controls.Add(this.InfoTextBox);
            this.CachePanel.Controls.Add(this.Info);
            this.CachePanel.Controls.Add(this.SlidingExpirationTimeComboBox);
            this.CachePanel.Controls.Add(this.SlidingExpirationTime);
            this.CachePanel.Controls.Add(this.ApplyChangesButton);
            this.CachePanel.Controls.Add(this.ClearButton);
            this.CachePanel.Controls.Add(this.AbsoluteExpirationTimeComboBox);
            this.CachePanel.Controls.Add(this.AbsoluteExpirationTime);
            this.CachePanel.Location = new System.Drawing.Point(208, 13);
            this.CachePanel.Name = "CachePanel";
            this.CachePanel.Size = new System.Drawing.Size(786, 504);
            this.CachePanel.TabIndex = 4;
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.InfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoTextBox.ForeColor = System.Drawing.Color.White;
            this.InfoTextBox.Location = new System.Drawing.Point(87, 320);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.ReadOnly = true;
            this.InfoTextBox.Size = new System.Drawing.Size(684, 72);
            this.InfoTextBox.TabIndex = 7;
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(24, 320);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(57, 23);
            this.Info.TabIndex = 6;
            this.Info.Text = "Info: ";
            // 
            // SlidingExpirationTimeComboBox
            // 
            this.SlidingExpirationTimeComboBox.BackColor = System.Drawing.Color.White;
            this.SlidingExpirationTimeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SlidingExpirationTimeComboBox.FormattingEnabled = true;
            this.SlidingExpirationTimeComboBox.Location = new System.Drawing.Point(349, 102);
            this.SlidingExpirationTimeComboBox.Name = "SlidingExpirationTimeComboBox";
            this.SlidingExpirationTimeComboBox.Size = new System.Drawing.Size(423, 31);
            this.SlidingExpirationTimeComboBox.TabIndex = 5;
            // 
            // SlidingExpirationTime
            // 
            this.SlidingExpirationTime.AutoSize = true;
            this.SlidingExpirationTime.Location = new System.Drawing.Point(20, 105);
            this.SlidingExpirationTime.Name = "SlidingExpirationTime";
            this.SlidingExpirationTime.Size = new System.Drawing.Size(323, 23);
            this.SlidingExpirationTime.TabIndex = 4;
            this.SlidingExpirationTime.Text = "Sliding Expiration Time (minutes) :";
            // 
            // ApplyChangesButton
            // 
            this.ApplyChangesButton.Location = new System.Drawing.Point(572, 416);
            this.ApplyChangesButton.Name = "ApplyChangesButton";
            this.ApplyChangesButton.Size = new System.Drawing.Size(200, 67);
            this.ApplyChangesButton.TabIndex = 3;
            this.ApplyChangesButton.Text = "Apply Changes";
            this.ApplyChangesButton.UseVisualStyleBackColor = true;
            this.ApplyChangesButton.Click += new System.EventHandler(this.ApplyChangesButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(24, 416);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(145, 67);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear Cache";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AbsoluteExpirationTimeComboBox
            // 
            this.AbsoluteExpirationTimeComboBox.BackColor = System.Drawing.Color.White;
            this.AbsoluteExpirationTimeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AbsoluteExpirationTimeComboBox.FormattingEnabled = true;
            this.AbsoluteExpirationTimeComboBox.Location = new System.Drawing.Point(369, 17);
            this.AbsoluteExpirationTimeComboBox.Name = "AbsoluteExpirationTimeComboBox";
            this.AbsoluteExpirationTimeComboBox.Size = new System.Drawing.Size(403, 31);
            this.AbsoluteExpirationTimeComboBox.TabIndex = 1;
            // 
            // AbsoluteExpirationTime
            // 
            this.AbsoluteExpirationTime.AutoSize = true;
            this.AbsoluteExpirationTime.Location = new System.Drawing.Point(20, 20);
            this.AbsoluteExpirationTime.Name = "AbsoluteExpirationTime";
            this.AbsoluteExpirationTime.Size = new System.Drawing.Size(343, 23);
            this.AbsoluteExpirationTime.TabIndex = 0;
            this.AbsoluteExpirationTime.Text = "Absolute Expiration time (minutes):";
            // 
            // VelibServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.CachePanel);
            this.Controls.Add(this.ButtonSidePanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VelibServerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JCDecaux Application";
            this.panel1.ResumeLayout(false);
            this.CachePanel.ResumeLayout(false);
            this.CachePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel JCDecaux;
        private System.Windows.Forms.Button CacheButton;
        private System.Windows.Forms.Button MonitoringButton;
        private System.Windows.Forms.Panel ButtonSidePanel;
        private System.Windows.Forms.Panel CachePanel;
        private System.Windows.Forms.ComboBox AbsoluteExpirationTimeComboBox;
        private System.Windows.Forms.Label AbsoluteExpirationTime;
        private System.Windows.Forms.Label SlidingExpirationTime;
        private System.Windows.Forms.Button ApplyChangesButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ComboBox SlidingExpirationTimeComboBox;
        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.Label Info;
    }
}