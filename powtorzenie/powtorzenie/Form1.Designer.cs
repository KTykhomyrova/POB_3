namespace powtorzenie
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
            checkedListBox = new CheckedListBox();
            button = new Button();
            richTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // checkedListBox
            // 
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Items.AddRange(new object[] { "Wymiana oleju", "Zmiana opon", "Wymiana klocków hamulcowych", "Sprawdzenie klimatyzacji", "Diagnostyka komputerowa" });
            checkedListBox.Location = new Point(35, 31);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(214, 94);
            checkedListBox.TabIndex = 0;
            // 
            // button
            // 
            button.Location = new Point(38, 140);
            button.Name = "button";
            button.Size = new Size(75, 23);
            button.TabIndex = 1;
            button.Text = "Oblicz";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(40, 182);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(165, 106);
            richTextBox.TabIndex = 2;
            richTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox);
            Controls.Add(button);
            Controls.Add(checkedListBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox checkedListBox;
        private Button button;
        private RichTextBox richTextBox;
    }
}
