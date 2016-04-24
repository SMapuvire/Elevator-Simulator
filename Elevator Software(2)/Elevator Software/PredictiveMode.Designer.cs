namespace Elevator_Software
{
    partial class PredictiveMode
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Trips_E1 = new System.Windows.Forms.TextBox();
            this.textBox_People_E1 = new System.Windows.Forms.TextBox();
            this.textBox_Items_E2 = new System.Windows.Forms.TextBox();
            this.textBox_Trips_E2 = new System.Windows.Forms.TextBox();
            this.textBox_People_E2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = " Run";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elevator 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elevator 2";
            // 
            // textBox_Trips_E1
            // 
            this.textBox_Trips_E1.Location = new System.Drawing.Point(64, 89);
            this.textBox_Trips_E1.Name = "textBox_Trips_E1";
            this.textBox_Trips_E1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Trips_E1.TabIndex = 4;
            // 
            // textBox_People_E1
            // 
            this.textBox_People_E1.Location = new System.Drawing.Point(64, 63);
            this.textBox_People_E1.Name = "textBox_People_E1";
            this.textBox_People_E1.Size = new System.Drawing.Size(100, 20);
            this.textBox_People_E1.TabIndex = 5;
            // 
            // textBox_Items_E2
            // 
            this.textBox_Items_E2.Location = new System.Drawing.Point(213, 115);
            this.textBox_Items_E2.Name = "textBox_Items_E2";
            this.textBox_Items_E2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Items_E2.TabIndex = 6;
            // 
            // textBox_Trips_E2
            // 
            this.textBox_Trips_E2.Location = new System.Drawing.Point(213, 89);
            this.textBox_Trips_E2.Name = "textBox_Trips_E2";
            this.textBox_Trips_E2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Trips_E2.TabIndex = 7;
            // 
            // textBox_People_E2
            // 
            this.textBox_People_E2.Location = new System.Drawing.Point(213, 63);
            this.textBox_People_E2.Name = "textBox_People_E2";
            this.textBox_People_E2.Size = new System.Drawing.Size(100, 20);
            this.textBox_People_E2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "People:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Trips:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Items:";
            // 
            // PredictiveMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 273);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_People_E2);
            this.Controls.Add(this.textBox_Trips_E2);
            this.Controls.Add(this.textBox_Items_E2);
            this.Controls.Add(this.textBox_People_E1);
            this.Controls.Add(this.textBox_Trips_E1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "PredictiveMode";
            this.Text = "Predictive Mode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Trips_E1;
        private System.Windows.Forms.TextBox textBox_People_E1;
        private System.Windows.Forms.TextBox textBox_Items_E2;
        private System.Windows.Forms.TextBox textBox_Trips_E2;
        private System.Windows.Forms.TextBox textBox_People_E2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}