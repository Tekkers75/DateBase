namespace DateBase
{
    partial class AddBookForm
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
            this.button_AddBook = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.textBox_Genre = new System.Windows.Forms.TextBox();
            this.textBox_Count = new System.Windows.Forms.TextBox();
            this.textBox_Year = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_AddBook
            // 
            this.button_AddBook.Location = new System.Drawing.Point(62, 208);
            this.button_AddBook.Name = "button_AddBook";
            this.button_AddBook.Size = new System.Drawing.Size(75, 23);
            this.button_AddBook.TabIndex = 0;
            this.button_AddBook.Text = "Добавить";
            this.button_AddBook.UseVisualStyleBackColor = true;
            this.button_AddBook.Click += new System.EventHandler(this.button_AddBook_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(63, 247);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 1;
            this.button_Close.Text = "Закрыть";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // textBox_Author
            // 
            this.textBox_Author.Location = new System.Drawing.Point(62, 41);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(100, 20);
            this.textBox_Author.TabIndex = 2;
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(62, 67);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(100, 20);
            this.textBox_Title.TabIndex = 3;
            // 
            // textBox_Genre
            // 
            this.textBox_Genre.Location = new System.Drawing.Point(62, 93);
            this.textBox_Genre.Name = "textBox_Genre";
            this.textBox_Genre.Size = new System.Drawing.Size(100, 20);
            this.textBox_Genre.TabIndex = 4;
            // 
            // textBox_Count
            // 
            this.textBox_Count.Location = new System.Drawing.Point(62, 145);
            this.textBox_Count.Name = "textBox_Count";
            this.textBox_Count.Size = new System.Drawing.Size(100, 20);
            this.textBox_Count.TabIndex = 5;
            // 
            // textBox_Year
            // 
            this.textBox_Year.Location = new System.Drawing.Point(63, 119);
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.Size = new System.Drawing.Size(100, 20);
            this.textBox_Year.TabIndex = 6;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(63, 171);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(100, 20);
            this.textBox_Price.TabIndex = 7;
            // 
            // FormAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 329);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.textBox_Year);
            this.Controls.Add(this.textBox_Count);
            this.Controls.Add(this.textBox_Genre);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.textBox_Author);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_AddBook);
            this.Name = "FormAddBook";
            this.Text = "Добавить книгу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddBook;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.TextBox textBox_Genre;
        private System.Windows.Forms.TextBox textBox_Count;
        private System.Windows.Forms.TextBox textBox_Year;
        private System.Windows.Forms.TextBox textBox_Price;
    }
}