namespace Elevator_Software
{
    partial class ParentMDI
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
            this.modeTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testingModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predictiveOdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predictiveModeLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeTypesToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modeTypesToolStripMenuItem
            // 
            this.modeTypesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testingModeToolStripMenuItem,
            this.simulationModeToolStripMenuItem,
            this.predictiveOdeToolStripMenuItem});
            this.modeTypesToolStripMenuItem.Name = "modeTypesToolStripMenuItem";
            this.modeTypesToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.modeTypesToolStripMenuItem.Text = "Mode Types";
            // 
            // testingModeToolStripMenuItem
            // 
            this.testingModeToolStripMenuItem.Name = "testingModeToolStripMenuItem";
            this.testingModeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.testingModeToolStripMenuItem.Text = "Testing Mode";
            this.testingModeToolStripMenuItem.Click += new System.EventHandler(this.testingModeToolStripMenuItem_Click);
            // 
            // simulationModeToolStripMenuItem
            // 
            this.simulationModeToolStripMenuItem.Name = "simulationModeToolStripMenuItem";
            this.simulationModeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.simulationModeToolStripMenuItem.Text = "Simulation Mode";
            this.simulationModeToolStripMenuItem.Click += new System.EventHandler(this.simulationModeToolStripMenuItem_Click);
            // 
            // predictiveOdeToolStripMenuItem
            // 
            this.predictiveOdeToolStripMenuItem.Name = "predictiveOdeToolStripMenuItem";
            this.predictiveOdeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.predictiveOdeToolStripMenuItem.Text = "Predictive Mode";
            this.predictiveOdeToolStripMenuItem.Click += new System.EventHandler(this.predictiveOdeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulationLogToolStripMenuItem,
            this.predictiveModeLogToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.helpToolStripMenuItem.Text = "Log";
            // 
            // simulationLogToolStripMenuItem
            // 
            this.simulationLogToolStripMenuItem.Name = "simulationLogToolStripMenuItem";
            this.simulationLogToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.simulationLogToolStripMenuItem.Text = "Simulation Mode Log";
            this.simulationLogToolStripMenuItem.Click += new System.EventHandler(this.simulationLogToolStripMenuItem_Click);
            // 
            // predictiveModeLogToolStripMenuItem
            // 
            this.predictiveModeLogToolStripMenuItem.Name = "predictiveModeLogToolStripMenuItem";
            this.predictiveModeLogToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.predictiveModeLogToolStripMenuItem.Text = "Predictive Mode Log";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // ParentMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Elevator_Software.Properties.Resources.IMG_20160412_WA0032;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 330);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ParentMDI";
            this.Text = "Elevator System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modeTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testingModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulationModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predictiveOdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulationLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predictiveModeLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}