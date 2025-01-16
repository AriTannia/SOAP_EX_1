namespace WindowsFormsApp
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
            txtInput = new TextBox();
            button1 = new Button();
            button2 = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(206, 65);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(232, 27);
            txtInput.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(129, 142);
            button1.Name = "button1";
            button1.Size = new Size(157, 29);
            button1.TabIndex = 1;
            button1.Text = "Convert to Celsius";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnToCelsius_Click;
            // 
            // button2
            // 
            button2.Location = new Point(344, 142);
            button2.Name = "button2";
            button2.Size = new Size(182, 29);
            button2.TabIndex = 2;
            button2.Text = "Convert to Fahrenheit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnToFahrenheit_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(277, 222);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(66, 20);
            lblResult.TabIndex = 3;
            lblResult.Text = "lblResult";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button button1;
        private Button button2;
        private Label lblResult;
    }
}
