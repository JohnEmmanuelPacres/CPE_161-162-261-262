namespace AddRowsColumns_List___Pacres
{
    partial class DataManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            aDDROWSToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            ImportDataToolStripMenuItem1 = new ToolStripMenuItem();
            aDDCOLUMNSToolStripMenuItem = new ToolStripMenuItem();
            aDDCOLUMNToolStripMenuItem = new ToolStripMenuItem();
            aDDROWToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(912, 444);
            dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aDDROWSToolStripMenuItem, aDDCOLUMNSToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(936, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // aDDROWSToolStripMenuItem
            // 
            aDDROWSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SaveToolStripMenuItem, ImportDataToolStripMenuItem1 });
            aDDROWSToolStripMenuItem.Name = "aDDROWSToolStripMenuItem";
            aDDROWSToolStripMenuItem.Size = new Size(49, 24);
            aDDROWSToolStripMenuItem.Text = "FILE";
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(224, 26);
            SaveToolStripMenuItem.Text = "SAVE";
            // 
            // ImportDataToolStripMenuItem1
            // 
            ImportDataToolStripMenuItem1.Name = "ImportDataToolStripMenuItem1";
            ImportDataToolStripMenuItem1.Size = new Size(224, 26);
            ImportDataToolStripMenuItem1.Text = "IMPORT DATA";
            // 
            // aDDCOLUMNSToolStripMenuItem
            // 
            aDDCOLUMNSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aDDCOLUMNToolStripMenuItem, aDDROWToolStripMenuItem });
            aDDCOLUMNSToolStripMenuItem.Name = "aDDCOLUMNSToolStripMenuItem";
            aDDCOLUMNSToolStripMenuItem.Size = new Size(54, 24);
            aDDCOLUMNSToolStripMenuItem.Text = "EDIT";
            // 
            // aDDCOLUMNToolStripMenuItem
            // 
            aDDCOLUMNToolStripMenuItem.Name = "aDDCOLUMNToolStripMenuItem";
            aDDCOLUMNToolStripMenuItem.Size = new Size(189, 26);
            aDDCOLUMNToolStripMenuItem.Text = "ADD COLUMN";
            // 
            // aDDROWToolStripMenuItem
            // 
            aDDROWToolStripMenuItem.Name = "aDDROWToolStripMenuItem";
            aDDROWToolStripMenuItem.Size = new Size(189, 26);
            aDDROWToolStripMenuItem.Text = "ADD ROW";
            // 
            // DataManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 506);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "DataManager";
            Text = "Data Manager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aDDROWSToolStripMenuItem;
        private ToolStripMenuItem aDDCOLUMNSToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem ImportDataToolStripMenuItem1;
        private ToolStripMenuItem aDDCOLUMNToolStripMenuItem;
        private ToolStripMenuItem aDDROWToolStripMenuItem;
    }
}
