using System;
using System.Windows.Forms;
using VelibLibrary;

namespace VelibClientGui
{
    class Popup : Form
    {
        private TextBox StationData;

        public Popup(Station data)
        {
            InitializeComponent();
            this.Text = "Station " + data.name + " information";
            StationData.Text = data.ToString().Replace("\n", Environment.NewLine); ;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popup));
            this.StationData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StationData
            // 
            this.StationData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.StationData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StationData.Cursor = System.Windows.Forms.Cursors.Default;
            this.StationData.ForeColor = System.Drawing.Color.White;
            this.StationData.Location = new System.Drawing.Point(20, 20);
            this.StationData.Multiline = true;
            this.StationData.Name = "StationData";
            this.StationData.ReadOnly = true;
            this.StationData.Size = new System.Drawing.Size(440, 300);
            this.StationData.TabIndex = 0;
            this.StationData.TabStop = false;
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.StationData);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Popup";
            this.Text = "Station Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
