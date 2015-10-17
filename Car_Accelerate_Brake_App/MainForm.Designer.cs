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
            this.SuspendLayout();
            // 
            // buttonAcc
            // 
            this.buttonAcc.Location = new System.Drawing.Point(33, 450);
            this.buttonAcc.Name = "buttonAcc";
            this.buttonAcc.Size = new System.Drawing.Size(75, 23);
            this.buttonAcc.TabIndex = 0;
            this.buttonAcc.Text = "Accelerate";
            this.buttonAcc.UseVisualStyleBackColor = true;
            // 
            // buttonBrake
            // 
            this.buttonBrake.Location = new System.Drawing.Point(131, 450);
            this.buttonBrake.Name = "buttonBrake";
            this.buttonBrake.Size = new System.Drawing.Size(75, 23);
            this.buttonBrake.TabIndex = 1;
            this.buttonBrake.Text = "Brake";
            this.buttonBrake.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(233, 450);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Car_Accelerate_Brake_App.Properties.Resources.Muscle_Car_14_500x500;
            this.ClientSize = new System.Drawing.Size(495, 592);
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
    }
}

