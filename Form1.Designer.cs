namespace BankProject
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
            this.customerCombo = new System.Windows.Forms.ComboBox();
            this.accountsCombo = new System.Windows.Forms.ComboBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.calculateInterestBtn = new System.Windows.Forms.Button();
            this.balanceBtn = new System.Windows.Forms.Button();
            this.lastTransactionBtn = new System.Windows.Forms.Button();
            this.transactionAmount = new System.Windows.Forms.NumericUpDown();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transactionAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // customerCombo
            // 
            this.customerCombo.FormattingEnabled = true;
            this.customerCombo.Location = new System.Drawing.Point(105, 111);
            this.customerCombo.Name = "customerCombo";
            this.customerCombo.Size = new System.Drawing.Size(204, 24);
            this.customerCombo.TabIndex = 0;
            this.customerCombo.SelectedIndexChanged += new System.EventHandler(this.customerCombo_SelectedIndexChanged);
            // 
            // accountsCombo
            // 
            this.accountsCombo.FormattingEnabled = true;
            this.accountsCombo.Location = new System.Drawing.Point(315, 111);
            this.accountsCombo.Name = "accountsCombo";
            this.accountsCombo.Size = new System.Drawing.Size(155, 24);
            this.accountsCombo.TabIndex = 1;
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(775, 109);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(105, 223);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(887, 360);
            this.outputBox.TabIndex = 5;
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(856, 109);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(136, 23);
            this.withdrawButton.TabIndex = 7;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // calculateInterestBtn
            // 
            this.calculateInterestBtn.Location = new System.Drawing.Point(822, 142);
            this.calculateInterestBtn.Name = "calculateInterestBtn";
            this.calculateInterestBtn.Size = new System.Drawing.Size(170, 23);
            this.calculateInterestBtn.TabIndex = 9;
            this.calculateInterestBtn.Text = "Calculate Interest";
            this.calculateInterestBtn.UseVisualStyleBackColor = true;
            this.calculateInterestBtn.Click += new System.EventHandler(this.calculateInterestBtn_Click);
            // 
            // balanceBtn
            // 
            this.balanceBtn.Location = new System.Drawing.Point(490, 142);
            this.balanceBtn.Name = "balanceBtn";
            this.balanceBtn.Size = new System.Drawing.Size(137, 23);
            this.balanceBtn.TabIndex = 10;
            this.balanceBtn.Text = "Balance";
            this.balanceBtn.UseVisualStyleBackColor = true;
            this.balanceBtn.Click += new System.EventHandler(this.balanceBtn_Click);
            // 
            // lastTransactionBtn
            // 
            this.lastTransactionBtn.Location = new System.Drawing.Point(644, 143);
            this.lastTransactionBtn.Name = "lastTransactionBtn";
            this.lastTransactionBtn.Size = new System.Drawing.Size(161, 23);
            this.lastTransactionBtn.TabIndex = 11;
            this.lastTransactionBtn.Text = "Last Transaction";
            this.lastTransactionBtn.UseVisualStyleBackColor = true;
            this.lastTransactionBtn.Click += new System.EventHandler(this.lastTransactionBtn_Click);
            // 
            // transactionAmount
            // 
            this.transactionAmount.Location = new System.Drawing.Point(490, 110);
            this.transactionAmount.Name = "transactionAmount";
            this.transactionAmount.Size = new System.Drawing.Size(279, 22);
            this.transactionAmount.TabIndex = 12;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(856, 194);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(135, 23);
            this.clearBtn.TabIndex = 13;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 826);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.transactionAmount);
            this.Controls.Add(this.lastTransactionBtn);
            this.Controls.Add(this.balanceBtn);
            this.Controls.Add(this.calculateInterestBtn);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.accountsCombo);
            this.Controls.Add(this.customerCombo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.transactionAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customerCombo;
        private System.Windows.Forms.ComboBox accountsCombo;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button calculateInterestBtn;
        private System.Windows.Forms.Button balanceBtn;
        private System.Windows.Forms.Button lastTransactionBtn;
        private System.Windows.Forms.NumericUpDown transactionAmount;
        private System.Windows.Forms.Button clearBtn;
    }
}

