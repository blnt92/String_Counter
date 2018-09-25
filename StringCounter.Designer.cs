namespace StringCounter
{
    partial class StringCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StringCounter));
            this.LongStringBox = new System.Windows.Forms.RichTextBox();
            this.SearchKeywordBox = new System.Windows.Forms.RichTextBox();
            this.CounterBox = new System.Windows.Forms.RichTextBox();
            this.Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LongStringBox
            // 
            this.LongStringBox.Location = new System.Drawing.Point(46, 55);
            this.LongStringBox.Name = "LongStringBox";
            this.LongStringBox.Size = new System.Drawing.Size(222, 380);
            this.LongStringBox.TabIndex = 0;
            this.LongStringBox.Text = resources.GetString("LongStringBox.Text");
            this.LongStringBox.TextChanged += new System.EventHandler(this.LongStringBox_TextChanged);
            // 
            // SearchKeywordBox
            // 
            this.SearchKeywordBox.Location = new System.Drawing.Point(394, 13);
            this.SearchKeywordBox.Name = "SearchKeywordBox";
            this.SearchKeywordBox.Size = new System.Drawing.Size(120, 25);
            this.SearchKeywordBox.TabIndex = 1;
            this.SearchKeywordBox.Text = "";
            this.SearchKeywordBox.TextChanged += new System.EventHandler(this.SearchKeywordBox_TextChanged);
            // 
            // CounterBox
            // 
            this.CounterBox.Location = new System.Drawing.Point(647, 12);
            this.CounterBox.Name = "CounterBox";
            this.CounterBox.Size = new System.Drawing.Size(40, 25);
            this.CounterBox.TabIndex = 2;
            this.CounterBox.Text = "";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Search.Location = new System.Drawing.Point(286, 69);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(102, 42);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(282, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Keyword:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(559, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(42, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Searching Area:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(286, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Next Pos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpenButton.Location = new System.Drawing.Point(286, 137);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(102, 41);
            this.OpenButton.TabIndex = 8;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClearButton.Location = new System.Drawing.Point(286, 209);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(102, 41);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.Clear_Click);
            // 
            // StringCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.CounterBox);
            this.Controls.Add(this.SearchKeywordBox);
            this.Controls.Add(this.LongStringBox);
            this.Name = "StringCounter";
            this.Text = "StringCounter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox LongStringBox;
        private System.Windows.Forms.RichTextBox SearchKeywordBox;
        private System.Windows.Forms.RichTextBox CounterBox;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

