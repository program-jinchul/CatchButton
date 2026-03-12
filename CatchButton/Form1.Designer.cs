namespace CatchButton
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
            jcButton = new Button();
            SuspendLayout();
            // 
            // jcButton
            // 
            jcButton.BackColor = SystemColors.ActiveCaption;
            jcButton.Font = new Font("맑은 고딕", 30F, FontStyle.Bold, GraphicsUnit.Point, 129);
            jcButton.ForeColor = Color.Blue;
            jcButton.Location = new Point(353, 219);
            jcButton.Name = "jcButton";
            jcButton.Size = new Size(517, 232);
            jcButton.TabIndex = 0;
            jcButton.Text = "나를 잡아봐";
            jcButton.UseVisualStyleBackColor = false;
            jcButton.Click += button1_Click;
            jcButton.MouseEnter += button1_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 702);
            Controls.Add(jcButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button jcButton;
    }
}
