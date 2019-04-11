namespace Prog2
{
    partial class LetterForm
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
            this.originAddressLabel = new System.Windows.Forms.Label();
            this.destAddLabel = new System.Windows.Forms.Label();
            this.originAddressComboBox = new System.Windows.Forms.ComboBox();
            this.destAddressComboBox = new System.Windows.Forms.ComboBox();
            this.fixedCostTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.fixedCostLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // originAddressLabel
            // 
            this.originAddressLabel.AutoSize = true;
            this.originAddressLabel.Location = new System.Drawing.Point(73, 9);
            this.originAddressLabel.Name = "originAddressLabel";
            this.originAddressLabel.Size = new System.Drawing.Size(106, 17);
            this.originAddressLabel.TabIndex = 0;
            this.originAddressLabel.Text = "Origin Address:";
            // 
            // destAddLabel
            // 
            this.destAddLabel.AutoSize = true;
            this.destAddLabel.Location = new System.Drawing.Point(40, 46);
            this.destAddLabel.Name = "destAddLabel";
            this.destAddLabel.Size = new System.Drawing.Size(139, 17);
            this.destAddLabel.TabIndex = 1;
            this.destAddLabel.Text = "Destination Address:";
            // 
            // originAddressComboBox
            // 
            this.originAddressComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originAddressComboBox.FormattingEnabled = true;
            this.originAddressComboBox.Location = new System.Drawing.Point(199, 6);
            this.originAddressComboBox.Name = "originAddressComboBox";
            this.originAddressComboBox.Size = new System.Drawing.Size(121, 24);
            this.originAddressComboBox.TabIndex = 2;
            this.originAddressComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.originAddressComboBox_Validating);
            this.originAddressComboBox.Validated += new System.EventHandler(this.originAddressComboBox_Validated);
            // 
            // destAddressComboBox
            // 
            this.destAddressComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destAddressComboBox.FormattingEnabled = true;
            this.destAddressComboBox.Location = new System.Drawing.Point(199, 43);
            this.destAddressComboBox.Name = "destAddressComboBox";
            this.destAddressComboBox.Size = new System.Drawing.Size(121, 24);
            this.destAddressComboBox.TabIndex = 3;
            this.destAddressComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.destAddressComboBox_Validating);
            this.destAddressComboBox.Validated += new System.EventHandler(this.destAddressComboBox_Validated);
            // 
            // fixedCostTextBox
            // 
            this.fixedCostTextBox.Location = new System.Drawing.Point(199, 85);
            this.fixedCostTextBox.Name = "fixedCostTextBox";
            this.fixedCostTextBox.Size = new System.Drawing.Size(121, 22);
            this.fixedCostTextBox.TabIndex = 4;
            this.fixedCostTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.fixedCostTextBox_Validating);
            this.fixedCostTextBox.Validated += new System.EventHandler(this.fixedCostTextBox_Validated);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(76, 133);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(85, 32);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(199, 131);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(85, 34);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // fixedCostLabel
            // 
            this.fixedCostLabel.AutoSize = true;
            this.fixedCostLabel.Location = new System.Drawing.Point(106, 88);
            this.fixedCostLabel.Name = "fixedCostLabel";
            this.fixedCostLabel.Size = new System.Drawing.Size(73, 17);
            this.fixedCostLabel.TabIndex = 7;
            this.fixedCostLabel.Text = "Fixed Cost";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 190);
            this.Controls.Add(this.fixedCostLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.fixedCostTextBox);
            this.Controls.Add(this.destAddressComboBox);
            this.Controls.Add(this.originAddressComboBox);
            this.Controls.Add(this.destAddLabel);
            this.Controls.Add(this.originAddressLabel);
            this.Name = "LetterForm";
            this.Text = "LetterForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originAddressLabel;
        private System.Windows.Forms.Label destAddLabel;
        private System.Windows.Forms.ComboBox originAddressComboBox;
        private System.Windows.Forms.ComboBox destAddressComboBox;
        private System.Windows.Forms.TextBox fixedCostTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label fixedCostLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}