namespace Car_Accelerate_Brake_App
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
            this.buttonAcc = new System.Windows.Forms.Button();
            this.buttonBrake = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelMPH = new System.Windows.Forms.Label();
            this.labelShowMPH = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelMake = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAcc
            // 
            this.buttonAcc.Location = new System.Drawing.Point(413, 486);
            this.buttonAcc.Name = "buttonAcc";
            this.buttonAcc.Size = new System.Drawing.Size(75, 23);
            this.buttonAcc.TabIndex = 0;
            this.buttonAcc.Text = "Accelerate";
            this.buttonAcc.UseVisualStyleBackColor = true;
            // 
            // buttonBrake
            // 
            this.buttonBrake.Location = new System.Drawing.Point(511, 486);
            this.buttonBrake.Name = "buttonBrake";
            this.buttonBrake.Size = new System.Drawing.Size(75, 23);
            this.buttonBrake.TabIndex = 1;
            this.buttonBrake.Text = "Brake";
            this.buttonBrake.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(711, 486);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelMPH
            // 
            this.labelMPH.AutoSize = true;
            this.labelMPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMPH.Location = new System.Drawing.Point(33, 515);
            this.labelMPH.Name = "labelMPH";
            this.labelMPH.Size = new System.Drawing.Size(45, 16);
            this.labelMPH.TabIndex = 3;
            this.labelMPH.Text = "MPH:";
            // 
            // labelShowMPH
            // 
            this.labelShowMPH.AutoSize = true;
            this.labelShowMPH.Location = new System.Drawing.Point(73, 517);
            this.labelShowMPH.Name = "labelShowMPH";
            this.labelShowMPH.Size = new System.Drawing.Size(35, 13);
            this.labelShowMPH.TabIndex = 4;
            this.labelShowMPH.Text = "label2";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(316, 486);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start Car";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(610, 486);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 6;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 451);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 483);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.Location = new System.Drawing.Point(31, 451);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(71, 13);
            this.labelYear.TabIndex = 9;
            this.labelYear.Text = "Enter Year:";
            // 
            // labelMake
            // 
            this.labelMake.AutoSize = true;
            this.labelMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMake.Location = new System.Drawing.Point(31, 486);
            this.labelMake.Name = "labelMake";
            this.labelMake.Size = new System.Drawing.Size(76, 13);
            this.labelMake.TabIndex = 10;
            this.labelMake.Text = "Enter Make:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Car_Accelerate_Brake_App.Properties.Resources.Muscle_Car_14_500x500;
            this.ClientSize = new System.Drawing.Size(1001, 586);
            this.Controls.Add(this.labelMake);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelShowMPH);
            this.Controls.Add(this.labelMPH);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBrake);
            this.Controls.Add(this.buttonAcc);
            this.Name = "MainForm";
            this.Text = "Car Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAcc;
        private System.Windows.Forms.Button buttonBrake;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelMPH;
        private System.Windows.Forms.Label labelShowMPH;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelMake;
    }
}

