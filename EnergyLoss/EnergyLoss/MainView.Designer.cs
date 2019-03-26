namespace EnergyLoss
{
    partial class MainView
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelTemperatureMin = new System.Windows.Forms.Label();
            this.textBoxAvgTemp = new System.Windows.Forms.TextBox();
            this.labelTemeperatureAvg = new System.Windows.Forms.Label();
            this.textBoxMinTemp = new System.Windows.Forms.TextBox();
            this.labelCountryType = new System.Windows.Forms.Label();
            this.labelBuildingType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonArea = new System.Windows.Forms.Button();
            this.buttonCount = new System.Windows.Forms.Button();
            this.textBoxHeatingLenght = new System.Windows.Forms.TextBox();
            this.countryNormal = new System.Windows.Forms.RadioButton();
            this.countryWindy = new System.Windows.Forms.RadioButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.buildingProtected = new System.Windows.Forms.RadioButton();
            this.buildingUnprotected = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buildingUnfavorable = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(23, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(384, 14);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(218, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelTemperatureMin
            // 
            this.labelTemperatureMin.AutoSize = true;
            this.labelTemperatureMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTemperatureMin.Location = new System.Drawing.Point(23, 46);
            this.labelTemperatureMin.Name = "labelTemperatureMin";
            this.labelTemperatureMin.Size = new System.Drawing.Size(246, 20);
            this.labelTemperatureMin.TabIndex = 2;
            this.labelTemperatureMin.Text = "Minimal outside temeperature";
            // 
            // textBoxAvgTemp
            // 
            this.textBoxAvgTemp.Location = new System.Drawing.Point(384, 82);
            this.textBoxAvgTemp.Name = "textBoxAvgTemp";
            this.textBoxAvgTemp.Size = new System.Drawing.Size(218, 20);
            this.textBoxAvgTemp.TabIndex = 3;
            this.textBoxAvgTemp.Text = "0";
            // 
            // labelTemeperatureAvg
            // 
            this.labelTemeperatureAvg.AutoSize = true;
            this.labelTemeperatureAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTemeperatureAvg.Location = new System.Drawing.Point(23, 80);
            this.labelTemeperatureAvg.Name = "labelTemeperatureAvg";
            this.labelTemeperatureAvg.Size = new System.Drawing.Size(253, 20);
            this.labelTemeperatureAvg.TabIndex = 4;
            this.labelTemeperatureAvg.Text = "Average heating temeperature";
            this.labelTemeperatureAvg.Click += new System.EventHandler(this.labelTemeperatureAvg_Click);
            // 
            // textBoxMinTemp
            // 
            this.textBoxMinTemp.Location = new System.Drawing.Point(384, 48);
            this.textBoxMinTemp.Name = "textBoxMinTemp";
            this.textBoxMinTemp.Size = new System.Drawing.Size(218, 20);
            this.textBoxMinTemp.TabIndex = 5;
            this.textBoxMinTemp.Text = "0";
            // 
            // labelCountryType
            // 
            this.labelCountryType.AutoSize = true;
            this.labelCountryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCountryType.Location = new System.Drawing.Point(25, 164);
            this.labelCountryType.Name = "labelCountryType";
            this.labelCountryType.Size = new System.Drawing.Size(135, 20);
            this.labelCountryType.TabIndex = 6;
            this.labelCountryType.Text = "Type of Country";
            // 
            // labelBuildingType
            // 
            this.labelBuildingType.AutoSize = true;
            this.labelBuildingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBuildingType.Location = new System.Drawing.Point(25, 243);
            this.labelBuildingType.Name = "labelBuildingType";
            this.labelBuildingType.Size = new System.Drawing.Size(137, 20);
            this.labelBuildingType.TabIndex = 7;
            this.labelBuildingType.Text = "Type of Building";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Length of the heating period";
            // 
            // buttonArea
            // 
            this.buttonArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonArea.Location = new System.Drawing.Point(27, 352);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(163, 86);
            this.buttonArea.TabIndex = 9;
            this.buttonArea.Text = "Enter Area";
            this.buttonArea.UseMnemonic = false;
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.buttonArea_Click);
            // 
            // buttonCount
            // 
            this.buttonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCount.Location = new System.Drawing.Point(439, 352);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(163, 86);
            this.buttonCount.TabIndex = 10;
            this.buttonCount.Text = "Count";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // textBoxHeatingLenght
            // 
            this.textBoxHeatingLenght.Location = new System.Drawing.Point(384, 117);
            this.textBoxHeatingLenght.Name = "textBoxHeatingLenght";
            this.textBoxHeatingLenght.Size = new System.Drawing.Size(218, 20);
            this.textBoxHeatingLenght.TabIndex = 11;
            this.textBoxHeatingLenght.Text = "1";
            // 
            // countryNormal
            // 
            this.countryNormal.AutoSize = true;
            this.countryNormal.Checked = true;
            this.countryNormal.Location = new System.Drawing.Point(44, 11);
            this.countryNormal.Name = "countryNormal";
            this.countryNormal.Size = new System.Drawing.Size(58, 17);
            this.countryNormal.TabIndex = 12;
            this.countryNormal.TabStop = true;
            this.countryNormal.Text = "Normal";
            this.countryNormal.UseVisualStyleBackColor = true;
            // 
            // countryWindy
            // 
            this.countryWindy.AutoSize = true;
            this.countryWindy.Location = new System.Drawing.Point(178, 11);
            this.countryWindy.Name = "countryWindy";
            this.countryWindy.Size = new System.Drawing.Size(55, 17);
            this.countryWindy.TabIndex = 13;
            this.countryWindy.Text = "Windy";
            this.countryWindy.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // buildingProtected
            // 
            this.buildingProtected.AutoSize = true;
            this.buildingProtected.Checked = true;
            this.buildingProtected.Location = new System.Drawing.Point(36, 19);
            this.buildingProtected.Name = "buildingProtected";
            this.buildingProtected.Size = new System.Drawing.Size(71, 17);
            this.buildingProtected.TabIndex = 16;
            this.buildingProtected.TabStop = true;
            this.buildingProtected.Text = "Protected";
            this.buildingProtected.UseVisualStyleBackColor = true;
            // 
            // buildingUnprotected
            // 
            this.buildingUnprotected.AutoSize = true;
            this.buildingUnprotected.Location = new System.Drawing.Point(170, 19);
            this.buildingUnprotected.Name = "buildingUnprotected";
            this.buildingUnprotected.Size = new System.Drawing.Size(84, 17);
            this.buildingUnprotected.TabIndex = 17;
            this.buildingUnprotected.Text = "Unprotected";
            this.buildingUnprotected.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.countryWindy);
            this.groupBox1.Controls.Add(this.countryNormal);
            this.groupBox1.Location = new System.Drawing.Point(29, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 34);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buildingUnfavorable);
            this.groupBox2.Controls.Add(this.buildingUnprotected);
            this.groupBox2.Controls.Add(this.buildingProtected);
            this.groupBox2.Location = new System.Drawing.Point(37, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 54);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // buildingUnfavorable
            // 
            this.buildingUnfavorable.AutoSize = true;
            this.buildingUnfavorable.Location = new System.Drawing.Point(318, 19);
            this.buildingUnfavorable.Name = "buildingUnfavorable";
            this.buildingUnfavorable.Size = new System.Drawing.Size(134, 17);
            this.buildingUnfavorable.TabIndex = 18;
            this.buildingUnfavorable.Text = "Unfavorable conditions";
            this.buildingUnfavorable.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.textBoxHeatingLenght);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBuildingType);
            this.Controls.Add(this.labelCountryType);
            this.Controls.Add(this.textBoxMinTemp);
            this.Controls.Add(this.labelTemeperatureAvg);
            this.Controls.Add(this.textBoxAvgTemp);
            this.Controls.Add(this.labelTemperatureMin);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "MainView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelTemperatureMin;
        private System.Windows.Forms.TextBox textBoxAvgTemp;
        private System.Windows.Forms.Label labelTemeperatureAvg;
        private System.Windows.Forms.TextBox textBoxMinTemp;
        private System.Windows.Forms.Label labelCountryType;
        private System.Windows.Forms.Label labelBuildingType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonArea;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.TextBox textBoxHeatingLenght;
        private System.Windows.Forms.RadioButton countryNormal;
        private System.Windows.Forms.RadioButton countryWindy;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.RadioButton buildingProtected;
        private System.Windows.Forms.RadioButton buildingUnprotected;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton buildingUnfavorable;
    }
}

