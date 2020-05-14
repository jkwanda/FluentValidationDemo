namespace DashboardUI
{
  partial class Dashboard
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.accountNumberText = new System.Windows.Forms.TextBox();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.errorListBox = new System.Windows.Forms.ListBox();
            this.errorListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(38, 44);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(204, 39);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Create User";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(78, 177);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(131, 29);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(282, 174);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(214, 35);
            this.firstNameText.TabIndex = 2;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(282, 224);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(214, 35);
            this.lastNameText.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(78, 227);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(128, 29);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            // 
            // accountNumberText
            // 
            this.accountNumberText.Location = new System.Drawing.Point(282, 126);
            this.accountNumberText.Name = "accountNumberText";
            this.accountNumberText.Size = new System.Drawing.Size(214, 35);
            this.accountNumberText.TabIndex = 6;
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Location = new System.Drawing.Point(79, 132);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(191, 29);
            this.accountNumberLabel.TabIndex = 5;
            this.accountNumberLabel.Text = "Account Number";
            this.accountNumberLabel.Click += new System.EventHandler(this.accountBalanceLabel_Click);
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(79, 281);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(144, 29);
            this.dateOfBirthLabel.TabIndex = 7;
            this.dateOfBirthLabel.Text = "Date of Birth";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(185, 333);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(214, 72);
            this.createButton.TabIndex = 9;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthPicker.Location = new System.Drawing.Point(283, 275);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(214, 35);
            this.dateOfBirthPicker.TabIndex = 10;
            // 
            // errorListBox
            // 
            this.errorListBox.FormattingEnabled = true;
            this.errorListBox.ItemHeight = 29;
            this.errorListBox.Location = new System.Drawing.Point(551, 132);
            this.errorListBox.Name = "errorListBox";
            this.errorListBox.Size = new System.Drawing.Size(542, 207);
            this.errorListBox.TabIndex = 11;
            // 
            // errorListLabel
            // 
            this.errorListLabel.AutoSize = true;
            this.errorListLabel.Location = new System.Drawing.Point(545, 96);
            this.errorListLabel.Name = "errorListLabel";
            this.errorListLabel.Size = new System.Drawing.Size(110, 29);
            this.errorListLabel.TabIndex = 1;
            this.errorListLabel.Text = "Error List";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 464);
            this.Controls.Add(this.errorListBox);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.accountNumberText);
            this.Controls.Add(this.accountNumberLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.errorListLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Dashboard";
            this.Text = "Fluent Validation Demo by Tim Corey";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label headerLabel;
    private System.Windows.Forms.Label firstNameLabel;
    private System.Windows.Forms.TextBox firstNameText;
    private System.Windows.Forms.TextBox lastNameText;
    private System.Windows.Forms.Label lastNameLabel;
    private System.Windows.Forms.TextBox accountNumberText;
    private System.Windows.Forms.Label accountNumberLabel;
    private System.Windows.Forms.Label dateOfBirthLabel;
    private System.Windows.Forms.Button createButton;
    private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
    private System.Windows.Forms.ListBox errorListBox;
    private System.Windows.Forms.Label errorListLabel;
  }
}
