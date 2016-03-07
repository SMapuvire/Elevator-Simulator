namespace Elevator_Software
{
    partial class ModeSelect
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
            this.button_TestingMode = new System.Windows.Forms.Button();
            this.button_SimulationMode = new System.Windows.Forms.Button();
            this.button3_PredicitveMode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_TestingMode
            // 
            this.button_TestingMode.Location = new System.Drawing.Point(74, 102);
            this.button_TestingMode.Name = "button_TestingMode";
            this.button_TestingMode.Size = new System.Drawing.Size(181, 23);
            this.button_TestingMode.TabIndex = 0;
            this.button_TestingMode.Text = "Testing Mode";
            this.button_TestingMode.UseVisualStyleBackColor = true;
            this.button_TestingMode.Click += new System.EventHandler(this.button_TestingMode_Click);
            // 
            // button_SimulationMode
            // 
            this.button_SimulationMode.Location = new System.Drawing.Point(74, 131);
            this.button_SimulationMode.Name = "button_SimulationMode";
            this.button_SimulationMode.Size = new System.Drawing.Size(181, 23);
            this.button_SimulationMode.TabIndex = 1;
            this.button_SimulationMode.Text = "Simulation Mode";
            this.button_SimulationMode.UseVisualStyleBackColor = true;
            this.button_SimulationMode.Click += new System.EventHandler(this.button_SimulationMode_Click);
            // 
            // button3_PredicitveMode
            // 
            this.button3_PredicitveMode.Location = new System.Drawing.Point(74, 160);
            this.button3_PredicitveMode.Name = "button3_PredicitveMode";
            this.button3_PredicitveMode.Size = new System.Drawing.Size(181, 23);
            this.button3_PredicitveMode.TabIndex = 2;
            this.button3_PredicitveMode.Text = "Predictive Mode";
            this.button3_PredicitveMode.UseVisualStyleBackColor = true;
            this.button3_PredicitveMode.Click += new System.EventHandler(this.button3_PredicitveMode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select a mode below";
            // 
            // ModeSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3_PredicitveMode);
            this.Controls.Add(this.button_SimulationMode);
            this.Controls.Add(this.button_TestingMode);
            this.Name = "ModeSelect";
            this.Text = "Mode Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_TestingMode;
        private System.Windows.Forms.Button button_SimulationMode;
        private System.Windows.Forms.Button button3_PredicitveMode;
        private System.Windows.Forms.Label label1;
    }
}