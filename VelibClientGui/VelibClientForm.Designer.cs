namespace VelibClientGui
{
    partial class VelibClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VelibClientForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BikesButton = new System.Windows.Forms.Button();
            this.StationsButton = new System.Windows.Forms.Button();
            this.JCDecaux = new System.Windows.Forms.Panel();
            this.ButtonSidePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.TextBox();
            this.ResultsPanel = new System.Windows.Forms.Panel();
            this.FieldsPanel = new System.Windows.Forms.Panel();
            this.SearchValidateButton = new System.Windows.Forms.Button();
            this.StationTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.StationLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.FieldsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BikesButton);
            this.panel1.Controls.Add(this.StationsButton);
            this.panel1.Controls.Add(this.JCDecaux);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 529);
            this.panel1.TabIndex = 0;
            // 
            // BikesButton
            // 
            this.BikesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BikesButton.BackgroundImage")));
            this.BikesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BikesButton.FlatAppearance.BorderSize = 0;
            this.BikesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BikesButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BikesButton.ForeColor = System.Drawing.Color.White;
            this.BikesButton.Location = new System.Drawing.Point(3, 264);
            this.BikesButton.Name = "BikesButton";
            this.BikesButton.Size = new System.Drawing.Size(195, 100);
            this.BikesButton.TabIndex = 2;
            this.BikesButton.Text = "Bikes";
            this.BikesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BikesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BikesButton.UseVisualStyleBackColor = true;
            this.BikesButton.Click += new System.EventHandler(this.Bikes_Click);
            this.BikesButton.MouseHover += new System.EventHandler(this.BikesButton_MouseHover);
            // 
            // StationsButton
            // 
            this.StationsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StationsButton.BackgroundImage")));
            this.StationsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StationsButton.FlatAppearance.BorderSize = 0;
            this.StationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StationsButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StationsButton.ForeColor = System.Drawing.Color.White;
            this.StationsButton.Location = new System.Drawing.Point(3, 158);
            this.StationsButton.Name = "StationsButton";
            this.StationsButton.Size = new System.Drawing.Size(195, 100);
            this.StationsButton.TabIndex = 1;
            this.StationsButton.Text = "Stations";
            this.StationsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StationsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StationsButton.UseVisualStyleBackColor = true;
            this.StationsButton.Click += new System.EventHandler(this.Stations_Click);
            this.StationsButton.MouseHover += new System.EventHandler(this.StationsButton_MouseHover);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.ResultsLabel);
            this.panel2.Controls.Add(this.Results);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(201, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 264);
            this.panel2.TabIndex = 1;
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Location = new System.Drawing.Point(15, 5);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(116, 23);
            this.ResultsLabel.TabIndex = 1;
            this.ResultsLabel.Text = "R e s u l t s:";
            // 
            // Results
            // 
            this.Results.AcceptsReturn = true;
            this.Results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Results.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Results.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Results.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results.ForeColor = System.Drawing.Color.White;
            this.Results.Location = new System.Drawing.Point(15, 35);
            this.Results.MaxLength = 2147483647;
            this.Results.Multiline = true;
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Results.Size = new System.Drawing.Size(775, 224);
            this.Results.TabIndex = 0;
            // 
            // ResultsPanel
            // 
            this.ResultsPanel.BackColor = System.Drawing.Color.White;
            this.ResultsPanel.Location = new System.Drawing.Point(216, 264);
            this.ResultsPanel.Name = "ResultsPanel";
            this.ResultsPanel.Size = new System.Drawing.Size(778, 1);
            this.ResultsPanel.TabIndex = 2;
            // 
            // FieldsPanel
            // 
            this.FieldsPanel.Controls.Add(this.SearchValidateButton);
            this.FieldsPanel.Controls.Add(this.StationTextBox);
            this.FieldsPanel.Controls.Add(this.CityTextBox);
            this.FieldsPanel.Controls.Add(this.StationLabel);
            this.FieldsPanel.Controls.Add(this.CityLabel);
            this.FieldsPanel.Location = new System.Drawing.Point(212, 12);
            this.FieldsPanel.Name = "FieldsPanel";
            this.FieldsPanel.Size = new System.Drawing.Size(782, 246);
            this.FieldsPanel.TabIndex = 4;
            // 
            // SearchValidateButton
            // 
            this.SearchValidateButton.Location = new System.Drawing.Point(8, 166);
            this.SearchValidateButton.Name = "SearchValidateButton";
            this.SearchValidateButton.Size = new System.Drawing.Size(153, 62);
            this.SearchValidateButton.TabIndex = 4;
            this.SearchValidateButton.Text = "SEARCH";
            this.SearchValidateButton.UseVisualStyleBackColor = true;
            this.SearchValidateButton.Click += new System.EventHandler(this.SearchValidateButton_Click);
            // 
            // StationTextBox
            // 
            this.StationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.StationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StationTextBox.ForeColor = System.Drawing.Color.White;
            this.StationTextBox.Location = new System.Drawing.Point(201, 119);
            this.StationTextBox.Name = "StationTextBox";
            this.StationTextBox.Size = new System.Drawing.Size(578, 32);
            this.StationTextBox.TabIndex = 3;
            this.StationTextBox.TextChanged += new System.EventHandler(this.StationTextBox_TextChanged);
            // 
            // CityTextBox
            // 
            this.CityTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.CityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CityTextBox.ForeColor = System.Drawing.Color.White;
            this.CityTextBox.Location = new System.Drawing.Point(201, 43);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(578, 32);
            this.CityTextBox.TabIndex = 2;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // StationLabel
            // 
            this.StationLabel.AutoSize = true;
            this.StationLabel.Location = new System.Drawing.Point(4, 121);
            this.StationLabel.Name = "StationLabel";
            this.StationLabel.Size = new System.Drawing.Size(117, 23);
            this.StationLabel.TabIndex = 1;
            this.StationLabel.Text = "S t a t i o n:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(4, 45);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(70, 23);
            this.CityLabel.TabIndex = 0;
            this.CityLabel.Text = "C i t y:";
            // 
            // VelibClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.FieldsPanel);
            this.Controls.Add(this.ButtonSidePanel);
            this.Controls.Add(this.ResultsPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VelibClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JCDecaux Application";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.FieldsPanel.ResumeLayout(false);
            this.FieldsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel JCDecaux;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button StationsButton;
        private System.Windows.Forms.Button BikesButton;
        private System.Windows.Forms.TextBox Results;
        private System.Windows.Forms.Panel ButtonSidePanel;
        private System.Windows.Forms.Panel ResultsPanel;
        private System.Windows.Forms.Label ResultsLabel;
        private System.Windows.Forms.Panel FieldsPanel;
        private System.Windows.Forms.TextBox StationTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label StationLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Button SearchValidateButton;
    }
}