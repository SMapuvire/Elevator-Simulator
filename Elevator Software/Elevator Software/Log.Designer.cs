namespace Elevator_Software
{
    partial class Log
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Trips_Count_E1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.People_Count_E1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight_Count_E1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Trips_Count_E2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.People_Count_E2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight_Count_E2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Count_E2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Trips_Count_E1,
            this.People_Count_E1,
            this.Weight_Count_E1});
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(426, 388);
            this.dataGridView1.TabIndex = 2;
            // 
            // Trips_Count_E1
            // 
            this.Trips_Count_E1.HeaderText = "Trips";
            this.Trips_Count_E1.Name = "Trips_Count_E1";
            this.Trips_Count_E1.ReadOnly = true;
            // 
            // People_Count_E1
            // 
            this.People_Count_E1.HeaderText = "People";
            this.People_Count_E1.Name = "People_Count_E1";
            this.People_Count_E1.ReadOnly = true;
            // 
            // Weight_Count_E1
            // 
            this.Weight_Count_E1.HeaderText = "Weight";
            this.Weight_Count_E1.Name = "Weight_Count_E1";
            this.Weight_Count_E1.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Trips_Count_E2,
            this.People_Count_E2,
            this.Weight_Count_E2,
            this.Item_Count_E2});
            this.dataGridView2.Location = new System.Drawing.Point(444, 44);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(520, 388);
            this.dataGridView2.TabIndex = 3;
            // 
            // Trips_Count_E2
            // 
            this.Trips_Count_E2.HeaderText = "Trips";
            this.Trips_Count_E2.Name = "Trips_Count_E2";
            this.Trips_Count_E2.ReadOnly = true;
            // 
            // People_Count_E2
            // 
            this.People_Count_E2.HeaderText = "People";
            this.People_Count_E2.Name = "People_Count_E2";
            this.People_Count_E2.ReadOnly = true;
            // 
            // Weight_Count_E2
            // 
            this.Weight_Count_E2.HeaderText = "Weight ";
            this.Weight_Count_E2.Name = "Weight_Count_E2";
            this.Weight_Count_E2.ReadOnly = true;
            // 
            // Item_Count_E2
            // 
            this.Item_Count_E2.HeaderText = "Items";
            this.Item_Count_E2.Name = "Item_Count_E2";
            this.Item_Count_E2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Elevator 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Elevator 2";
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 444);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Log";
            this.Text = "Elevator Log";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trips_Count_E1;
        private System.Windows.Forms.DataGridViewTextBoxColumn People_Count_E1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight_Count_E1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trips_Count_E2;
        private System.Windows.Forms.DataGridViewTextBoxColumn People_Count_E2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight_Count_E2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Count_E2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;


    }
}