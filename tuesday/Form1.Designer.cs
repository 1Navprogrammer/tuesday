namespace tuesday
{
    partial class Form1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtInput.Location = new System.Drawing.Point(629, 100);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 26);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button.Location = new System.Drawing.Point(69, 84);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(117, 58);
            this.button.TabIndex = 1;
            this.button.Text = "Click";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // lbxOutput
            // 
            this.lbxOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.ItemHeight = 20;
            this.lbxOutput.Location = new System.Drawing.Point(233, 255);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(302, 164);
            this.lbxOutput.TabIndex = 2;
            this.lbxOutput.SelectedIndexChanged += new System.EventHandler(this.output_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxOutput);
            this.Controls.Add(this.button);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ListBox lbxOutput;
    }
}

