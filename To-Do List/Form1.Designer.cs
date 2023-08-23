namespace To_Do_List
{
    partial class ToDoList
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
            if(disposing && (components != null))
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
            label1 = new Label();
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            clearButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            toDoListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)toDoListView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(776, 63);
            label1.TabIndex = 0;
            label1.Text = "To Do List";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(12, 85);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(776, 23);
            titleTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(12, 137);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(776, 23);
            descriptionTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(776, 23);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.Location = new Point(12, 59);
            label3.Name = "label3";
            label3.Size = new Size(776, 23);
            label3.TabIndex = 4;
            label3.Text = "Title:";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(12, 170);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(191, 23);
            clearButton.TabIndex = 5;
            clearButton.Text = "Clear fields";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(207, 170);
            editButton.Name = "editButton";
            editButton.Size = new Size(191, 23);
            editButton.TabIndex = 6;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(402, 170);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(191, 23);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(597, 170);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(191, 23);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save task";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // toDoListView
            // 
            toDoListView.AllowUserToAddRows = false;
            toDoListView.AllowUserToDeleteRows = false;
            toDoListView.AllowUserToResizeColumns = false;
            toDoListView.AllowUserToResizeRows = false;
            toDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            toDoListView.BackgroundColor = Color.White;
            toDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toDoListView.Location = new Point(12, 199);
            toDoListView.Name = "toDoListView";
            toDoListView.RowTemplate.Height = 25;
            toDoListView.Size = new Size(776, 239);
            toDoListView.TabIndex = 9;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(toDoListView);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(clearButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(label1);
            Name = "ToDoList";
            Text = "To Do List";
            Load += toDoList_Load;
            ((System.ComponentModel.ISupportInitialize)toDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private Label label2;
        private Label label3;
        private Button clearButton;
        private Button editButton;
        private Button deleteButton;
        private Button saveButton;
        private DataGridView toDoListView;
    }
}