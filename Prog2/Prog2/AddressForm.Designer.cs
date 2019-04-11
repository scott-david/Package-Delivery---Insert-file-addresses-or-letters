namespace Prog2
{
    partial class AddressForm
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
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.addressLine2TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(53, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(53, 42);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(64, 17);
            this.addressLabel.TabIndex = 9;
            this.addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(53, 101);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(35, 17);
            this.cityLabel.TabIndex = 10;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(53, 129);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(45, 17);
            this.stateLabel.TabIndex = 11;
            this.stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(56, 159);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(32, 17);
            this.zipLabel.TabIndex = 12;
            this.zipLabel.Text = "Zip:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(121, 39);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(121, 22);
            this.addressTextBox.TabIndex = 1;
            this.addressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.addressTextBox_Validating);
            this.addressTextBox.Validated += new System.EventHandler(this.addressTextBox_Validated);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(121, 9);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 22);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            this.nameTextBox.Validated += new System.EventHandler(this.nameTextBox_Validated);
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(121, 156);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(121, 22);
            this.zipTextBox.TabIndex = 5;
            this.zipTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.zipTextBox_Validating);
            this.zipTextBox.Validated += new System.EventHandler(this.zipTextBox_Validated);
            // 
            // addressLine2TextBox
            // 
            this.addressLine2TextBox.Location = new System.Drawing.Point(121, 67);
            this.addressLine2TextBox.Name = "addressLine2TextBox";
            this.addressLine2TextBox.Size = new System.Drawing.Size(121, 22);
            this.addressLine2TextBox.TabIndex = 2;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(121, 98);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(121, 22);
            this.cityTextBox.TabIndex = 3;
            this.cityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cityTextBox_Validating);
            this.cityTextBox.Validated += new System.EventHandler(this.cityTextBox_Validated);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(29, 184);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(105, 39);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(167, 184);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 39);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "KY",
            "NY",
            "CA",
            "CO"});
            this.stateComboBox.Location = new System.Drawing.Point(121, 126);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(121, 24);
            this.stateComboBox.TabIndex = 4;
            this.stateComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.stateComboBox_Validating);
            this.stateComboBox.Validated += new System.EventHandler(this.stateComboBox_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 241);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.addressLine2TextBox);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            this.Validated += new System.EventHandler(this.okButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox addressLine2TextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}