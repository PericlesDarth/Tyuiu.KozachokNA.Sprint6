namespace Tyuiu.KozachokNA.Sprint6.Task6.V17
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
            InputBox = new TextBox();
            OutputBox = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // OpenFile
            // 
            OpenFile.Location = new Point(30, 12);
            OpenFile.Name = "OpenFile";
            OpenFile.Size = new Size(112, 34);
            OpenFile.TabIndex = 0;
            OpenFile.Text = "Open file";
            OpenFile.UseVisualStyleBackColor = true;
            OpenFile.Click += OpenFile_Click;
            // 
            // InputBox
            // 
            InputBox.Location = new Point(30, 91);
            InputBox.Multiline = true;
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(636, 515);
            InputBox.TabIndex = 1;
            InputBox.Text = "Input will be shown here";
            // 
            // OutputBox
            // 
            OutputBox.Location = new Point(686, 91);
            OutputBox.Multiline = true;
            OutputBox.Name = "OutputBox";
            OutputBox.Size = new Size(665, 515);
            OutputBox.TabIndex = 2;
            OutputBox.Text = "Output wil be here";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 699);
            Controls.Add(OutputBox);
            Controls.Add(InputBox);
            Controls.Add(OpenFile);
            Name = "Form1";
            Text = "OpenFile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenFile;
        private TextBox InputBox;
        private TextBox OutputBox;
        private OpenFileDialog openFileDialog1;
    }
}
