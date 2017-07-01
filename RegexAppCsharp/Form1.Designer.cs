namespace RegexAppCsharp
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
            this.txt_input = new System.Windows.Forms.RichTextBox();
            this.txt_Output = new System.Windows.Forms.RichTextBox();
            this.rd_Search = new System.Windows.Forms.RadioButton();
            this.rd_Replace = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Pattern = new System.Windows.Forms.TextBox();
            this.txt_From = new System.Windows.Forms.TextBox();
            this.txt_To = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_input
            // 
            this.txt_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_input.Location = new System.Drawing.Point(3, 3);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(300, 349);
            this.txt_input.TabIndex = 0;
            this.txt_input.Text = "";
            // 
            // txt_Output
            // 
            this.txt_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Output.Location = new System.Drawing.Point(2, 3);
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.Size = new System.Drawing.Size(658, 591);
            this.txt_Output.TabIndex = 1;
            this.txt_Output.Text = "";
            this.txt_Output.TextChanged += new System.EventHandler(this.txt_Output_TextChanged);
            // 
            // rd_Search
            // 
            this.rd_Search.AutoSize = true;
            this.rd_Search.Location = new System.Drawing.Point(44, 46);
            this.rd_Search.Name = "rd_Search";
            this.rd_Search.Size = new System.Drawing.Size(59, 17);
            this.rd_Search.TabIndex = 2;
            this.rd_Search.TabStop = true;
            this.rd_Search.Text = "Search";
            this.rd_Search.UseVisualStyleBackColor = true;
            // 
            // rd_Replace
            // 
            this.rd_Replace.AutoSize = true;
            this.rd_Replace.Location = new System.Drawing.Point(44, 86);
            this.rd_Replace.Name = "rd_Replace";
            this.rd_Replace.Size = new System.Drawing.Size(65, 17);
            this.rd_Replace.TabIndex = 3;
            this.rd_Replace.TabStop = true;
            this.rd_Replace.Text = "Replace";
            this.rd_Replace.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 75);
            this.button1.TabIndex = 4;
            this.button1.Text = "DoRegex";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Pattern
            // 
            this.txt_Pattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txt_Pattern.Location = new System.Drawing.Point(175, 46);
            this.txt_Pattern.Name = "txt_Pattern";
            this.txt_Pattern.Size = new System.Drawing.Size(199, 32);
            this.txt_Pattern.TabIndex = 5;
            // 
            // txt_From
            // 
            this.txt_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txt_From.Location = new System.Drawing.Point(175, 86);
            this.txt_From.Name = "txt_From";
            this.txt_From.Size = new System.Drawing.Size(100, 32);
            this.txt_From.TabIndex = 6;
            // 
            // txt_To
            // 
            this.txt_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txt_To.Location = new System.Drawing.Point(331, 86);
            this.txt_To.Name = "txt_To";
            this.txt_To.Size = new System.Drawing.Size(100, 32);
            this.txt_To.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(307, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "RegexApp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "by";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Input Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "OutPutText";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_Search);
            this.groupBox1.Controls.Add(this.rd_Replace);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 121);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 143);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txt_input);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txt_Output);
            this.splitContainer1.Size = new System.Drawing.Size(687, 355);
            this.splitContainer1.SplitterDistance = 229;
            this.splitContainer1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 494);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_To);
            this.Controls.Add(this.txt_From);
            this.Controls.Add(this.txt_Pattern);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TifaLAB Regex App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_input;
        private System.Windows.Forms.RichTextBox txt_Output;
        private System.Windows.Forms.RadioButton rd_Search;
        private System.Windows.Forms.RadioButton rd_Replace;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Pattern;
        private System.Windows.Forms.TextBox txt_From;
        private System.Windows.Forms.TextBox txt_To;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

