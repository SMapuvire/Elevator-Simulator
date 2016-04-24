namespace Elevator_Software
{
    partial class SimulationMode
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1_Run_Sim = new System.Windows.Forms.Button();
            this.textBox_Days_Sim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Duration (Days):";
            // 
            // button1_Run_Sim
            // 
            this.button1_Run_Sim.Location = new System.Drawing.Point(12, 78);
            this.button1_Run_Sim.Name = "button1_Run_Sim";
            this.button1_Run_Sim.Size = new System.Drawing.Size(183, 23);
            this.button1_Run_Sim.TabIndex = 1;
            this.button1_Run_Sim.Text = "Run";
            this.button1_Run_Sim.UseVisualStyleBackColor = true;
            this.button1_Run_Sim.Click += new System.EventHandler(this.button1_Run_Sim_Click);
            // 
            // textBox_Days_Sim
            // 
            this.textBox_Days_Sim.Location = new System.Drawing.Point(95, 39);
            this.textBox_Days_Sim.Name = "textBox_Days_Sim";
            this.textBox_Days_Sim.Size = new System.Drawing.Size(100, 20);
            this.textBox_Days_Sim.TabIndex = 2;
            // 
            // SimulationMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 148);
            this.Controls.Add(this.textBox_Days_Sim);
            this.Controls.Add(this.button1_Run_Sim);
            this.Controls.Add(this.label1);
            this.Name = "SimulationMode";
            this.Text = "SimulationMode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_Run_Sim;
        private System.Windows.Forms.TextBox textBox_Days_Sim;
    }
}