namespace OPP_MIDTERM_ASSIGNMENT2
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
            label1 = new Label();
            titleTextBox = new TextBox();
            descriptionTextbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            newButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            toDoListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)toDoListView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 1);
            label1.Name = "label1";
            label1.Size = new Size(716, 58);
            label1.TabIndex = 0;
            label1.Text = "To Do List";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(12, 54);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(698, 23);
            titleTextBox.TabIndex = 1;
            // 
            // descriptionTextbox
            // 
            descriptionTextbox.Location = new Point(12, 102);
            descriptionTextbox.Name = "descriptionTextbox";
            descriptionTextbox.Size = new Size(698, 23);
            descriptionTextbox.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(698, 23);
            label2.TabIndex = 3;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 34);
            label3.Name = "label3";
            label3.Size = new Size(698, 19);
            label3.TabIndex = 4;
            label3.Text = "Title:";
            // 
            // newButton
            // 
            newButton.Location = new Point(12, 132);
            newButton.Name = "newButton";
            newButton.Size = new Size(170, 23);
            newButton.TabIndex = 5;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(188, 132);
            editButton.Name = "editButton";
            editButton.Size = new Size(170, 23);
            editButton.TabIndex = 6;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(364, 132);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(170, 23);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(540, 132);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(170, 23);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // toDoListView
            // 
            toDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            toDoListView.BackgroundColor = SystemColors.ControlLight;
            toDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toDoListView.Location = new Point(12, 161);
            toDoListView.Name = "toDoListView";
            toDoListView.Size = new Size(698, 261);
            toDoListView.TabIndex = 9;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(722, 425);
            Controls.Add(toDoListView);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(newButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(descriptionTextbox);
            Controls.Add(titleTextBox);
            Controls.Add(label1);
            Name = "ToDoList";
            Text = "To Do List";
            Load += ToDoList_Load;
            ((System.ComponentModel.ISupportInitialize)toDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox titleTextBox;
        private TextBox descriptionTextbox;
        private Label label2;
        private Label label3;
        private Button newButton;
        private Button editButton;
        private Button deleteButton;
        private Button saveButton;
        private DataGridView toDoListView;
    }
}
