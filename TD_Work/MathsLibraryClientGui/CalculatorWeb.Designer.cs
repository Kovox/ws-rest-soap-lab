namespace MathsLibraryClientGui
{
    partial class CalculatorWeb
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
            this.MinusButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ANumber = new System.Windows.Forms.TextBox();
            this.MultButton = new System.Windows.Forms.Button();
            this.DivButton = new System.Windows.Forms.Button();
            this.BNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MinusButton
            // 
            this.MinusButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusButton.Location = new System.Drawing.Point(105, 80);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(32, 32);
            this.MinusButton.TabIndex = 0;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusButton.Location = new System.Drawing.Point(105, 42);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(32, 32);
            this.PlusButton.TabIndex = 1;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Result.Location = new System.Drawing.Point(17, 186);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(253, 58);
            this.Result.TabIndex = 2;
            this.Result.Text = "No Result";
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(107, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 74);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ANumber
            // 
            this.ANumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.ANumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANumber.ForeColor = System.Drawing.Color.White;
            this.ANumber.Location = new System.Drawing.Point(12, 42);
            this.ANumber.Multiline = true;
            this.ANumber.Name = "ANumber";
            this.ANumber.Size = new System.Drawing.Size(70, 70);
            this.ANumber.TabIndex = 4;
            this.ANumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ANumber.TextChanged += new System.EventHandler(this.ANumber_TextChanged);
            this.ANumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ANumber_KeyPress);
            // 
            // MultButton
            // 
            this.MultButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultButton.Location = new System.Drawing.Point(146, 42);
            this.MultButton.Name = "MultButton";
            this.MultButton.Size = new System.Drawing.Size(32, 32);
            this.MultButton.TabIndex = 5;
            this.MultButton.Text = "*";
            this.MultButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MultButton.UseVisualStyleBackColor = true;
            this.MultButton.Click += new System.EventHandler(this.MultButton_Click);
            // 
            // DivButton
            // 
            this.DivButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DivButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivButton.Location = new System.Drawing.Point(146, 80);
            this.DivButton.Name = "DivButton";
            this.DivButton.Size = new System.Drawing.Size(32, 32);
            this.DivButton.TabIndex = 6;
            this.DivButton.Text = "/";
            this.DivButton.UseVisualStyleBackColor = true;
            this.DivButton.Click += new System.EventHandler(this.DivButton_Click);
            // 
            // BNumber
            // 
            this.BNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.BNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNumber.ForeColor = System.Drawing.Color.White;
            this.BNumber.Location = new System.Drawing.Point(200, 42);
            this.BNumber.Multiline = true;
            this.BNumber.Name = "BNumber";
            this.BNumber.Size = new System.Drawing.Size(70, 70);
            this.BNumber.TabIndex = 7;
            this.BNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BNumber.TextChanged += new System.EventHandler(this.BNumber_TextChanged);
            this.BNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BNumber_KeyPress);
            // 
            // CalculatorWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.BNumber);
            this.Controls.Add(this.DivButton);
            this.Controls.Add(this.MultButton);
            this.Controls.Add(this.ANumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.MinusButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CalculatorWeb";
            this.Text = "Calculator Web";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ANumber;
        private System.Windows.Forms.Button MultButton;
        private System.Windows.Forms.Button DivButton;
        private System.Windows.Forms.TextBox BNumber;
    }
}

