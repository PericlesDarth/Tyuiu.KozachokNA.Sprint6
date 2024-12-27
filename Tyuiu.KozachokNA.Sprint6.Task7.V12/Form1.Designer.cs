namespace Tyuiu.KozachokNA.Sprint6.Task7.V12
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
            OpenFile = new Button();
            SaveFile = new Button();
            dataGridViewIn = new DataGridView();
            dataGridViewOut = new DataGridView();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // OpenFile
            // 
            OpenFile.Location = new Point(12, 12);
            OpenFile.Name = "OpenFile";
            OpenFile.Size = new Size(112, 34);
            OpenFile.TabIndex = 0;
            OpenFile.Text = "Open file";
            OpenFile.UseVisualStyleBackColor = true;
            OpenFile.Click += OpenFile_Click;
            // 
            // SaveFile
            // 
            SaveFile.Location = new Point(130, 12);
            SaveFile.Name = "SaveFile";
            SaveFile.Size = new Size(112, 34);
            SaveFile.TabIndex = 1;
            SaveFile.Text = "Save file";
            SaveFile.UseVisualStyleBackColor = true;
            //SaveFile.Click += SaveFile_Click;
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Location = new Point(12, 105);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.RowHeadersWidth = 62;
            dataGridViewIn.Size = new Size(620, 485);
            dataGridViewIn.TabIndex = 2;
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Location = new Point(638, 105);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.RowHeadersWidth = 62;
            dataGridViewOut.Size = new Size(603, 485);
            dataGridViewOut.TabIndex = 3;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 639);
            Controls.Add(dataGridViewOut);
            Controls.Add(dataGridViewIn);
            Controls.Add(SaveFile);
            Controls.Add(OpenFile);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button OpenFile;
        private Button SaveFile;
        private DataGridView dataGridViewIn;
        private DataGridView dataGridViewOut;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}
