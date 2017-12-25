namespace SecretOfGrindeaDemo
{
    partial class Ui
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ui));
            this.UnlimitedHealthCheckBox = new System.Windows.Forms.CheckBox();
            this.UnlimitedEnergyCheckBox = new System.Windows.Forms.CheckBox();
            this.UnlimitedArrowsCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GetAdressButton = new System.Windows.Forms.Button();
            this.HealthInitzialied = new System.Windows.Forms.Label();
            this.EnergyInitialized = new System.Windows.Forms.Label();
            this.ArrowsInitizialied = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UnlimitedHealthCheckBox
            // 
            this.UnlimitedHealthCheckBox.AutoSize = true;
            this.UnlimitedHealthCheckBox.Location = new System.Drawing.Point(261, 12);
            this.UnlimitedHealthCheckBox.Name = "UnlimitedHealthCheckBox";
            this.UnlimitedHealthCheckBox.Size = new System.Drawing.Size(103, 17);
            this.UnlimitedHealthCheckBox.TabIndex = 0;
            this.UnlimitedHealthCheckBox.Text = "Unlimited Health";
            this.UnlimitedHealthCheckBox.UseVisualStyleBackColor = true;
            this.UnlimitedHealthCheckBox.CheckedChanged += new System.EventHandler(this.UnlimitedHealthCheckBox_CheckedChanged);
            // 
            // UnlimitedEnergyCheckBox
            // 
            this.UnlimitedEnergyCheckBox.AutoSize = true;
            this.UnlimitedEnergyCheckBox.Location = new System.Drawing.Point(261, 48);
            this.UnlimitedEnergyCheckBox.Name = "UnlimitedEnergyCheckBox";
            this.UnlimitedEnergyCheckBox.Size = new System.Drawing.Size(105, 17);
            this.UnlimitedEnergyCheckBox.TabIndex = 1;
            this.UnlimitedEnergyCheckBox.Text = "Unlimited Energy";
            this.UnlimitedEnergyCheckBox.UseVisualStyleBackColor = true;
            this.UnlimitedEnergyCheckBox.CheckedChanged += new System.EventHandler(this.UnlimitedEnergyCheckBox_CheckedChanged);
            // 
            // UnlimitedArrowsCheckBox
            // 
            this.UnlimitedArrowsCheckBox.AutoSize = true;
            this.UnlimitedArrowsCheckBox.Location = new System.Drawing.Point(261, 84);
            this.UnlimitedArrowsCheckBox.Name = "UnlimitedArrowsCheckBox";
            this.UnlimitedArrowsCheckBox.Size = new System.Drawing.Size(104, 17);
            this.UnlimitedArrowsCheckBox.TabIndex = 2;
            this.UnlimitedArrowsCheckBox.Text = "Unlimited Arrows";
            this.UnlimitedArrowsCheckBox.UseVisualStyleBackColor = true;
            this.UnlimitedArrowsCheckBox.CheckedChanged += new System.EventHandler(this.UnlimitedArrowsCheckBox_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 280);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // GetAdressButton
            // 
            this.GetAdressButton.Location = new System.Drawing.Point(261, 120);
            this.GetAdressButton.Name = "GetAdressButton";
            this.GetAdressButton.Size = new System.Drawing.Size(103, 36);
            this.GetAdressButton.TabIndex = 4;
            this.GetAdressButton.Text = "Get Adresses";
            this.GetAdressButton.UseVisualStyleBackColor = true;
            this.GetAdressButton.Click += new System.EventHandler(this.GetAdressButton_Click);
            // 
            // HealthInitzialied
            // 
            this.HealthInitzialied.AutoSize = true;
            this.HealthInitzialied.ForeColor = System.Drawing.Color.Red;
            this.HealthInitzialied.Location = new System.Drawing.Point(258, 32);
            this.HealthInitzialied.Name = "HealthInitzialied";
            this.HealthInitzialied.Size = new System.Drawing.Size(75, 13);
            this.HealthInitzialied.TabIndex = 5;
            this.HealthInitzialied.Text = "Not Initzialized";
            // 
            // EnergyInitialized
            // 
            this.EnergyInitialized.AutoSize = true;
            this.EnergyInitialized.ForeColor = System.Drawing.Color.Red;
            this.EnergyInitialized.Location = new System.Drawing.Point(258, 68);
            this.EnergyInitialized.Name = "EnergyInitialized";
            this.EnergyInitialized.Size = new System.Drawing.Size(75, 13);
            this.EnergyInitialized.TabIndex = 6;
            this.EnergyInitialized.Text = "Not Initzialized";
            // 
            // ArrowsInitizialied
            // 
            this.ArrowsInitizialied.AutoSize = true;
            this.ArrowsInitizialied.ForeColor = System.Drawing.Color.Red;
            this.ArrowsInitizialied.Location = new System.Drawing.Point(258, 104);
            this.ArrowsInitizialied.Name = "ArrowsInitizialied";
            this.ArrowsInitizialied.Size = new System.Drawing.Size(75, 13);
            this.ArrowsInitizialied.TabIndex = 7;
            this.ArrowsInitizialied.Text = "Not Initzialized";
            // 
            // Ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 300);
            this.Controls.Add(this.ArrowsInitizialied);
            this.Controls.Add(this.EnergyInitialized);
            this.Controls.Add(this.HealthInitzialied);
            this.Controls.Add(this.GetAdressButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UnlimitedArrowsCheckBox);
            this.Controls.Add(this.UnlimitedEnergyCheckBox);
            this.Controls.Add(this.UnlimitedHealthCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ui";
            this.Text = "Secret Of GrindCancer Demo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox UnlimitedHealthCheckBox;
        private System.Windows.Forms.CheckBox UnlimitedEnergyCheckBox;
        private System.Windows.Forms.CheckBox UnlimitedArrowsCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button GetAdressButton;
        private System.Windows.Forms.Label HealthInitzialied;
        private System.Windows.Forms.Label EnergyInitialized;
        private System.Windows.Forms.Label ArrowsInitizialied;
    }
}

