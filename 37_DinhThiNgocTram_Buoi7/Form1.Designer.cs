namespace _37_DinhThiNgocTram_Buoi7
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
            this.radioButtonEncrypt = new System.Windows.Forms.RadioButton();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.RadioButton();
            this.entryKey = new System.Windows.Forms.NumericUpDown();
            this.entryResult = new System.Windows.Forms.TextBox();
            this.entryMess = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelAction = new System.Windows.Forms.Label();
            this.labelKey = new System.Windows.Forms.Label();
            this.labelMess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.entryKey)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonEncrypt
            // 
            this.radioButtonEncrypt.AutoSize = true;
            this.radioButtonEncrypt.Location = new System.Drawing.Point(200, 252);
            this.radioButtonEncrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonEncrypt.Name = "radioButtonEncrypt";
            this.radioButtonEncrypt.Size = new System.Drawing.Size(88, 24);
            this.radioButtonEncrypt.TabIndex = 24;
            this.radioButtonEncrypt.TabStop = true;
            this.radioButtonEncrypt.Text = "Encrypt";
            this.radioButtonEncrypt.UseVisualStyleBackColor = true;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(210, 433);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(173, 68);
            this.buttonEncrypt.TabIndex = 23;
            this.buttonEncrypt.Text = "Encrypt Message";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncryptClick);
            // 
            // decrypt
            // 
            this.decrypt.AutoSize = true;
            this.decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decrypt.Location = new System.Drawing.Point(518, 252);
            this.decrypt.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(141, 37);
            this.decrypt.TabIndex = 22;
            this.decrypt.TabStop = true;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            // 
            // entryKey
            // 
            this.entryKey.Location = new System.Drawing.Point(200, 123);
            this.entryKey.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.entryKey.Name = "entryKey";
            this.entryKey.Size = new System.Drawing.Size(147, 26);
            this.entryKey.TabIndex = 21;
            // 
            // entryResult
            // 
            this.entryResult.Location = new System.Drawing.Point(200, 346);
            this.entryResult.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.entryResult.Name = "entryResult";
            this.entryResult.Size = new System.Drawing.Size(489, 26);
            this.entryResult.TabIndex = 20;
            // 
            // entryMess
            // 
            this.entryMess.Location = new System.Drawing.Point(200, 24);
            this.entryMess.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.entryMess.Name = "entryMess";
            this.entryMess.Size = new System.Drawing.Size(489, 26);
            this.entryMess.TabIndex = 19;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(36, 346);
            this.labelResult.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(122, 33);
            this.labelResult.TabIndex = 18;
            this.labelResult.Text = "Result: ";
            this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // labelAction
            // 
            this.labelAction.AutoSize = true;
            this.labelAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAction.Location = new System.Drawing.Point(36, 234);
            this.labelAction.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(111, 33);
            this.labelAction.TabIndex = 17;
            this.labelAction.Text = "Action:";
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKey.Location = new System.Drawing.Point(36, 123);
            this.labelKey.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(86, 33);
            this.labelKey.TabIndex = 16;
            this.labelKey.Text = "Key: ";
            // 
            // labelMess
            // 
            this.labelMess.AutoSize = true;
            this.labelMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMess.Location = new System.Drawing.Point(36, 24);
            this.labelMess.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.labelMess.Name = "labelMess";
            this.labelMess.Size = new System.Drawing.Size(149, 33);
            this.labelMess.TabIndex = 15;
            this.labelMess.Text = "Message:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 522);
            this.Controls.Add(this.radioButtonEncrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.entryKey);
            this.Controls.Add(this.entryResult);
            this.Controls.Add(this.entryMess);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelAction);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.labelMess);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entryKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonEncrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.RadioButton decrypt;
        private System.Windows.Forms.NumericUpDown entryKey;
        private System.Windows.Forms.TextBox entryResult;
        private System.Windows.Forms.TextBox entryMess;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelAction;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelMess;

    }
}

