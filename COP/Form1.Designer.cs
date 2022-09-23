
namespace COP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCleanList = new System.Windows.Forms.Button();
            this.buttonAddElement = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonTextBox = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonGetDropdown = new System.Windows.Forms.Button();
            this.buttonSetDropdown = new System.Windows.Forms.Button();
            this.textBoxForDropdown = new System.Windows.Forms.TextBox();
            this.list1 = new COP.Components.List();
            this.input = new COP.Components.Input();
            this.dropdown = new COP.Components.Dropdown();
            this.buttonGetList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCleanList
            // 
            this.buttonCleanList.Location = new System.Drawing.Point(110, 156);
            this.buttonCleanList.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCleanList.Name = "buttonCleanList";
            this.buttonCleanList.Size = new System.Drawing.Size(74, 39);
            this.buttonCleanList.TabIndex = 4;
            this.buttonCleanList.Text = "Очистить список";
            this.buttonCleanList.UseVisualStyleBackColor = true;
            this.buttonCleanList.Click += new System.EventHandler(this.buttonCleanList_Click);
            // 
            // buttonAddElement
            // 
            this.buttonAddElement.Location = new System.Drawing.Point(32, 156);
            this.buttonAddElement.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddElement.Name = "buttonAddElement";
            this.buttonAddElement.Size = new System.Drawing.Size(74, 40);
            this.buttonAddElement.TabIndex = 3;
            this.buttonAddElement.Text = "Заполнить список";
            this.buttonAddElement.UseVisualStyleBackColor = true;
            this.buttonAddElement.Click += new System.EventHandler(this.buttonAddElement_Click);
            // 
            // buttonTextBox
            // 
            this.buttonTextBox.Location = new System.Drawing.Point(32, 323);
            this.buttonTextBox.Name = "buttonTextBox";
            this.buttonTextBox.Size = new System.Drawing.Size(75, 23);
            this.buttonTextBox.TabIndex = 7;
            this.buttonTextBox.Text = "Получить";
            this.buttonTextBox.UseVisualStyleBackColor = true;
            this.buttonTextBox.Click += new System.EventHandler(this.buttonTextBox_Click);
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(346, 200);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(75, 23);
            this.buttonList.TabIndex = 9;
            this.buttonList.Text = "Заполнить";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonGetDropdown
            // 
            this.buttonGetDropdown.Location = new System.Drawing.Point(32, 120);
            this.buttonGetDropdown.Name = "buttonGetDropdown";
            this.buttonGetDropdown.Size = new System.Drawing.Size(75, 23);
            this.buttonGetDropdown.TabIndex = 10;
            this.buttonGetDropdown.Text = "Получить";
            this.buttonGetDropdown.UseVisualStyleBackColor = true;
            this.buttonGetDropdown.Click += new System.EventHandler(this.buttonGetDropdown_Click);
            // 
            // buttonSetDropdown
            // 
            this.buttonSetDropdown.Location = new System.Drawing.Point(110, 120);
            this.buttonSetDropdown.Name = "buttonSetDropdown";
            this.buttonSetDropdown.Size = new System.Drawing.Size(75, 23);
            this.buttonSetDropdown.TabIndex = 11;
            this.buttonSetDropdown.Text = "Установить";
            this.buttonSetDropdown.UseVisualStyleBackColor = true;
            this.buttonSetDropdown.Click += new System.EventHandler(this.buttonSetDropdown_Click);
            // 
            // textBoxForDropdown
            // 
            this.textBoxForDropdown.Location = new System.Drawing.Point(188, 122);
            this.textBoxForDropdown.Name = "textBoxForDropdown";
            this.textBoxForDropdown.Size = new System.Drawing.Size(100, 20);
            this.textBoxForDropdown.TabIndex = 12;
            // 
            // list1
            // 
            this.list1.Location = new System.Drawing.Point(346, 30);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(389, 150);
            this.list1.TabIndex = 8;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(32, 269);
            this.input.Name = "input";
            this.input.Pattern = null;
            this.input.Size = new System.Drawing.Size(590, 150);
            this.input.TabIndex = 6;
            // 
            // dropdown
            // 
            this.dropdown.Location = new System.Drawing.Point(32, 1);
            this.dropdown.Name = "dropdown";
            this.dropdown.SelectedValue = "";
            this.dropdown.Size = new System.Drawing.Size(150, 150);
            this.dropdown.TabIndex = 5;
            // 
            // buttonGetList
            // 
            this.buttonGetList.Location = new System.Drawing.Point(446, 200);
            this.buttonGetList.Name = "buttonGetList";
            this.buttonGetList.Size = new System.Drawing.Size(75, 23);
            this.buttonGetList.TabIndex = 13;
            this.buttonGetList.Text = "Получить";
            this.buttonGetList.UseVisualStyleBackColor = true;
            this.buttonGetList.Click += new System.EventHandler(this.buttonGetList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGetList);
            this.Controls.Add(this.textBoxForDropdown);
            this.Controls.Add(this.buttonSetDropdown);
            this.Controls.Add(this.buttonGetDropdown);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.list1);
            this.Controls.Add(this.buttonTextBox);
            this.Controls.Add(this.input);
            this.Controls.Add(this.dropdown);
            this.Controls.Add(this.buttonCleanList);
            this.Controls.Add(this.buttonAddElement);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCleanList;
        private System.Windows.Forms.Button buttonAddElement;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Components.Dropdown dropdown;
        private Components.Input input;
        private System.Windows.Forms.Button buttonTextBox;
        private Components.List list1;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonGetDropdown;
        private System.Windows.Forms.Button buttonSetDropdown;
        private System.Windows.Forms.TextBox textBoxForDropdown;
        private System.Windows.Forms.Button buttonGetList;
    }
}

