namespace Task
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonBegin = new Button();
            labelNumber = new Label();
            SuspendLayout();
            // 
            // buttonBegin
            // 
            buttonBegin.Cursor = Cursors.Hand;
            buttonBegin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBegin.Location = new Point(59, 174);
            buttonBegin.Name = "buttonBegin";
            buttonBegin.Size = new Size(109, 70);
            buttonBegin.TabIndex = 0;
            buttonBegin.Text = "Почати";
            buttonBegin.UseVisualStyleBackColor = true;
            buttonBegin.Click += buttonBegin_Click;
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumber.Location = new Point(59, 21);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(109, 128);
            labelNumber.TabIndex = 1;
            labelNumber.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(225, 260);
            Controls.Add(labelNumber);
            Controls.Add(buttonBegin);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лічильник";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBegin;
        private Label labelNumber;
    }
}