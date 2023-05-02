namespace WindowsStatusTestAPP
{
    partial class MainWindow
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
            this.runButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pcNameCheckBox = new System.Windows.Forms.CheckBox();
            this.osCheckBox = new System.Windows.Forms.CheckBox();
            this.cpuTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.cpuSpeedCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ramCheckBox = new System.Windows.Forms.CheckBox();
            this.cDriveCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.Location = new System.Drawing.Point(33, 329);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(388, 47);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Run Basic ";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Basic System Information Report";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pcNameCheckBox
            // 
            this.pcNameCheckBox.AutoSize = true;
            this.pcNameCheckBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcNameCheckBox.Location = new System.Drawing.Point(33, 107);
            this.pcNameCheckBox.Name = "pcNameCheckBox";
            this.pcNameCheckBox.Size = new System.Drawing.Size(84, 20);
            this.pcNameCheckBox.TabIndex = 2;
            this.pcNameCheckBox.Text = "PC Name";
            this.pcNameCheckBox.UseVisualStyleBackColor = true;
            this.pcNameCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // osCheckBox
            // 
            this.osCheckBox.AutoSize = true;
            this.osCheckBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osCheckBox.Location = new System.Drawing.Point(33, 142);
            this.osCheckBox.Name = "osCheckBox";
            this.osCheckBox.Size = new System.Drawing.Size(98, 20);
            this.osCheckBox.TabIndex = 3;
            this.osCheckBox.Text = "OS Version";
            this.osCheckBox.UseVisualStyleBackColor = true;
            // 
            // cpuTypeCheckBox
            // 
            this.cpuTypeCheckBox.AutoSize = true;
            this.cpuTypeCheckBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuTypeCheckBox.Location = new System.Drawing.Point(33, 179);
            this.cpuTypeCheckBox.Name = "cpuTypeCheckBox";
            this.cpuTypeCheckBox.Size = new System.Drawing.Size(90, 20);
            this.cpuTypeCheckBox.TabIndex = 4;
            this.cpuTypeCheckBox.Text = "CPU Type";
            this.cpuTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // cpuSpeedCheckBox
            // 
            this.cpuSpeedCheckBox.AutoSize = true;
            this.cpuSpeedCheckBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuSpeedCheckBox.Location = new System.Drawing.Point(33, 215);
            this.cpuSpeedCheckBox.Name = "cpuSpeedCheckBox";
            this.cpuSpeedCheckBox.Size = new System.Drawing.Size(98, 20);
            this.cpuSpeedCheckBox.TabIndex = 5;
            this.cpuSpeedCheckBox.Text = "CPU Speed";
            this.cpuSpeedCheckBox.UseVisualStyleBackColor = true;
            this.cpuSpeedCheckBox.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select The Information you want the Information Report to Display";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ramCheckBox
            // 
            this.ramCheckBox.AutoSize = true;
            this.ramCheckBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramCheckBox.Location = new System.Drawing.Point(33, 253);
            this.ramCheckBox.Name = "ramCheckBox";
            this.ramCheckBox.Size = new System.Drawing.Size(115, 20);
            this.ramCheckBox.TabIndex = 7;
            this.ramCheckBox.Text = "Installed RAM";
            this.ramCheckBox.UseVisualStyleBackColor = true;
            // 
            // cDriveCheckBox
            // 
            this.cDriveCheckBox.AutoSize = true;
            this.cDriveCheckBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cDriveCheckBox.Location = new System.Drawing.Point(33, 289);
            this.cDriveCheckBox.Name = "cDriveCheckBox";
            this.cDriveCheckBox.Size = new System.Drawing.Size(135, 20);
            this.cDriveCheckBox.TabIndex = 8;
            this.cDriveCheckBox.Text = "Size of C:\\ Drive";
            this.cDriveCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cDriveCheckBox);
            this.groupBox1.Controls.Add(this.ramCheckBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cpuSpeedCheckBox);
            this.groupBox1.Controls.Add(this.cpuTypeCheckBox);
            this.groupBox1.Controls.Add(this.osCheckBox);
            this.groupBox1.Controls.Add(this.pcNameCheckBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.runButton);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 398);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 405);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainWindow";
            this.Text = "Windows Status (Alpha)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox pcNameCheckBox;
        private System.Windows.Forms.CheckBox osCheckBox;
        private System.Windows.Forms.CheckBox cpuTypeCheckBox;
        private System.Windows.Forms.CheckBox cpuSpeedCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ramCheckBox;
        private System.Windows.Forms.CheckBox cDriveCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

