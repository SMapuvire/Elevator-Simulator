namespace Elevator_Software
{
    partial class TestingMode
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Passengers_E1 = new System.Windows.Forms.TextBox();
            this.textBox_Trips_E1 = new System.Windows.Forms.TextBox();
            this.button_Run_Test = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Items_Sim_E2 = new System.Windows.Forms.TextBox();
            this.textBox_Trips_E2 = new System.Windows.Forms.TextBox();
            this.textBox_Passengers_E2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trips:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passengers:";
            // 
            // textBox_Passengers_E1
            // 
            this.textBox_Passengers_E1.Location = new System.Drawing.Point(93, 52);
            this.textBox_Passengers_E1.Name = "textBox_Passengers_E1";
            this.textBox_Passengers_E1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Passengers_E1.TabIndex = 2;
            // 
            // textBox_Trips_E1
            // 
            this.textBox_Trips_E1.Location = new System.Drawing.Point(93, 84);
            this.textBox_Trips_E1.Name = "textBox_Trips_E1";
            this.textBox_Trips_E1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Trips_E1.TabIndex = 3;
            // 
            // button_Run_Test
            // 
            this.button_Run_Test.Location = new System.Drawing.Point(93, 194);
            this.button_Run_Test.Name = "button_Run_Test";
            this.button_Run_Test.Size = new System.Drawing.Size(244, 23);
            this.button_Run_Test.TabIndex = 4;
            this.button_Run_Test.Text = "Run";
            this.button_Run_Test.UseVisualStyleBackColor = true;
            this.button_Run_Test.Click += new System.EventHandler(this.button_Run_Test_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Items:";
            // 
            // textBox_Items_Sim_E2
            // 
            this.textBox_Items_Sim_E2.Location = new System.Drawing.Point(237, 119);
            this.textBox_Items_Sim_E2.Name = "textBox_Items_Sim_E2";
            this.textBox_Items_Sim_E2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Items_Sim_E2.TabIndex = 6;
            // 
            // textBox_Trips_E2
            // 
            this.textBox_Trips_E2.Location = new System.Drawing.Point(237, 84);
            this.textBox_Trips_E2.Name = "textBox_Trips_E2";
            this.textBox_Trips_E2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Trips_E2.TabIndex = 7;
            // 
            // textBox_Passengers_E2
            // 
            this.textBox_Passengers_E2.Location = new System.Drawing.Point(237, 52);
            this.textBox_Passengers_E2.Name = "textBox_Passengers_E2";
            this.textBox_Passengers_E2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Passengers_E2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Elevator 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Elevator 2";
            // 
            // TestingMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 324);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Passengers_E2);
            this.Controls.Add(this.textBox_Trips_E2);
            this.Controls.Add(this.textBox_Items_Sim_E2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Run_Test);
            this.Controls.Add(this.textBox_Trips_E1);
            this.Controls.Add(this.textBox_Passengers_E1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TestingMode";
            this.Text = "TestingMode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Passengers_E1;
        private System.Windows.Forms.TextBox textBox_Trips_E1;
        private System.Windows.Forms.Button button_Run_Test;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Items_Sim_E2;
        private System.Windows.Forms.TextBox textBox_Trips_E2;
        private System.Windows.Forms.TextBox textBox_Passengers_E2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}