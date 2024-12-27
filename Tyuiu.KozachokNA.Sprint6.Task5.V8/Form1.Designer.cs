namespace Tyuiu.KozachokNA.Sprint6.Task5.V8
{
    partial class Form1
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
            myDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)myDataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            myDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            myDataGridView.Location = new Point(12, 12);
            myDataGridView.Name = "dataGridView1";
            myDataGridView.RowHeadersWidth = 62;
            myDataGridView.Size = new Size(210, 389);
            myDataGridView.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(myDataGridView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)myDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView myDataGridView;
    }
}
