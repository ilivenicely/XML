namespace MccormickRobert_JSONandAPI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rdoXML = new System.Windows.Forms.RadioButton();
            this.rdoJSON = new System.Windows.Forms.RadioButton();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.btnViewWeatherData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDirection = new System.Windows.Forms.TextBox();
            this.numWindSpeed = new System.Windows.Forms.NumericUpDown();
            this.numRelativeHumidity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numFeelsLikeTemp = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numTemp = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWindSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRelativeHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFeelsLikeTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(271, 38);
            this.loadToolStripMenuItem.Text = "Load   CTRL+L";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(271, 38);
            this.saveToolStripMenuItem.Text = "Save   CTRL+S";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(271, 38);
            this.newToolStripMenuItem.Text = "New   CTRL+N";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(271, 38);
            this.exitToolStripMenuItem.Text = "Exit    CTRL+S";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.rdoXML);
            this.groupBox1.Controls.Add(this.rdoJSON);
            this.groupBox1.Controls.Add(this.cmbState);
            this.groupBox1.Controls.Add(this.btnViewWeatherData);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 380);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get Weather Data";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 25);
            this.label12.TabIndex = 8;
            this.label12.Text = "Choose Format";
            // 
            // rdoXML
            // 
            this.rdoXML.AutoSize = true;
            this.rdoXML.Location = new System.Drawing.Point(476, 223);
            this.rdoXML.Name = "rdoXML";
            this.rdoXML.Size = new System.Drawing.Size(87, 29);
            this.rdoXML.TabIndex = 7;
            this.rdoXML.TabStop = true;
            this.rdoXML.Text = "XML";
            this.rdoXML.UseVisualStyleBackColor = true;
            // 
            // rdoJSON
            // 
            this.rdoJSON.AutoSize = true;
            this.rdoJSON.Location = new System.Drawing.Point(347, 223);
            this.rdoJSON.Name = "rdoJSON";
            this.rdoJSON.Size = new System.Drawing.Size(99, 29);
            this.rdoJSON.TabIndex = 6;
            this.rdoJSON.TabStop = true;
            this.rdoJSON.Text = "JSON";
            this.rdoJSON.UseVisualStyleBackColor = true;
            // 
            // cmbState
            // 
            this.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Lousiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Jersey",
            "New Hampshire",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.cmbState.Location = new System.Drawing.Point(347, 144);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(216, 33);
            this.cmbState.TabIndex = 3;
            // 
            // btnViewWeatherData
            // 
            this.btnViewWeatherData.Location = new System.Drawing.Point(268, 312);
            this.btnViewWeatherData.Name = "btnViewWeatherData";
            this.btnViewWeatherData.Size = new System.Drawing.Size(210, 43);
            this.btnViewWeatherData.TabIndex = 3;
            this.btnViewWeatherData.Text = "Get Data";
            this.btnViewWeatherData.UseVisualStyleBackColor = true;
            this.btnViewWeatherData.Click += new System.EventHandler(this.btnViewWeatherData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select a state";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(347, 78);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(316, 31);
            this.txtCity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter City / Town";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDirection);
            this.groupBox2.Controls.Add(this.numWindSpeed);
            this.groupBox2.Controls.Add(this.numRelativeHumidity);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numFeelsLikeTemp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numTemp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(145, 460);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(514, 304);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(432, 202);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Mph";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 152);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(432, 102);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "*F";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "*F";
            // 
            // txtDirection
            // 
            this.txtDirection.Location = new System.Drawing.Point(288, 250);
            this.txtDirection.Margin = new System.Windows.Forms.Padding(6);
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.Size = new System.Drawing.Size(128, 31);
            this.txtDirection.TabIndex = 9;
            // 
            // numWindSpeed
            // 
            this.numWindSpeed.DecimalPlaces = 1;
            this.numWindSpeed.Location = new System.Drawing.Point(288, 198);
            this.numWindSpeed.Margin = new System.Windows.Forms.Padding(6);
            this.numWindSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numWindSpeed.Name = "numWindSpeed";
            this.numWindSpeed.Size = new System.Drawing.Size(132, 31);
            this.numWindSpeed.TabIndex = 8;
            this.numWindSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numRelativeHumidity
            // 
            this.numRelativeHumidity.DecimalPlaces = 1;
            this.numRelativeHumidity.Location = new System.Drawing.Point(288, 148);
            this.numRelativeHumidity.Margin = new System.Windows.Forms.Padding(6);
            this.numRelativeHumidity.Name = "numRelativeHumidity";
            this.numRelativeHumidity.Size = new System.Drawing.Size(132, 31);
            this.numRelativeHumidity.TabIndex = 7;
            this.numRelativeHumidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Direction";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Wind speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Relative humidity";
            // 
            // numFeelsLikeTemp
            // 
            this.numFeelsLikeTemp.DecimalPlaces = 1;
            this.numFeelsLikeTemp.Location = new System.Drawing.Point(288, 98);
            this.numFeelsLikeTemp.Margin = new System.Windows.Forms.Padding(6);
            this.numFeelsLikeTemp.Name = "numFeelsLikeTemp";
            this.numFeelsLikeTemp.Size = new System.Drawing.Size(132, 31);
            this.numFeelsLikeTemp.TabIndex = 3;
            this.numFeelsLikeTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "\"Feels like\" temperature";
            // 
            // numTemp
            // 
            this.numTemp.DecimalPlaces = 1;
            this.numTemp.Location = new System.Drawing.Point(288, 48);
            this.numTemp.Margin = new System.Windows.Forms.Padding(6);
            this.numTemp.Name = "numTemp";
            this.numTemp.Size = new System.Drawing.Size(132, 31);
            this.numTemp.TabIndex = 1;
            this.numTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Current temperature";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JSON|*.txt|XML|*.xml";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 805);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWindSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRelativeHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFeelsLikeTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewWeatherData;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDirection;
        private System.Windows.Forms.NumericUpDown numWindSpeed;
        private System.Windows.Forms.NumericUpDown numRelativeHumidity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numFeelsLikeTemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton rdoJSON;
        private System.Windows.Forms.RadioButton rdoXML;
        private System.Windows.Forms.Label label12;
    }
}

