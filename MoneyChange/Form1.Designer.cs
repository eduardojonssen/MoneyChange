namespace MoneyChange {
	partial class MoneyChange {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.UxLblPaidAmount = new System.Windows.Forms.Label();
			this.UxTxtPaidAmount = new System.Windows.Forms.TextBox();
			this.UxLblProductAmount = new System.Windows.Forms.Label();
			this.UxTxtProductAmount = new System.Windows.Forms.TextBox();
			this.UxLblChange = new System.Windows.Forms.Label();
			this.UxLblChangeAmount = new System.Windows.Forms.Label();
			this.UxBtnCalculate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// UxLblPaidAmount
			// 
			this.UxLblPaidAmount.AutoSize = true;
			this.UxLblPaidAmount.Location = new System.Drawing.Point(12, 53);
			this.UxLblPaidAmount.Name = "UxLblPaidAmount";
			this.UxLblPaidAmount.Size = new System.Drawing.Size(90, 20);
			this.UxLblPaidAmount.TabIndex = 0;
			this.UxLblPaidAmount.Text = "Valor pago:";

			// 
			// UxTxtPaidAmount
			// 
			this.UxTxtPaidAmount.Location = new System.Drawing.Point(168, 50);
			this.UxTxtPaidAmount.Name = "UxTxtPaidAmount";
			this.UxTxtPaidAmount.Size = new System.Drawing.Size(206, 26);
			this.UxTxtPaidAmount.TabIndex = 2;
			// 
			// UxLblProductAmount
			// 
			this.UxLblProductAmount.AutoSize = true;
			this.UxLblProductAmount.Location = new System.Drawing.Point(12, 17);
			this.UxLblProductAmount.Name = "UxLblProductAmount";
			this.UxLblProductAmount.Size = new System.Drawing.Size(131, 20);
			this.UxLblProductAmount.TabIndex = 2;
			this.UxLblProductAmount.Text = "Valor do produto:";
			// 
			// UxTxtProductAmount
			// 
			this.UxTxtProductAmount.Location = new System.Drawing.Point(168, 14);
			this.UxTxtProductAmount.Name = "UxTxtProductAmount";
			this.UxTxtProductAmount.Size = new System.Drawing.Size(206, 26);
			this.UxTxtProductAmount.TabIndex = 1;

			// 
			// UxLblChange
			// 
			this.UxLblChange.AutoSize = true;
			this.UxLblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UxLblChange.Location = new System.Drawing.Point(12, 104);
			this.UxLblChange.Name = "UxLblChange";
			this.UxLblChange.Size = new System.Drawing.Size(175, 46);
			this.UxLblChange.TabIndex = 4;
			this.UxLblChange.Text = "TROCO:";
			// 
			// UxLblChangeAmount
			// 
			this.UxLblChangeAmount.AutoSize = true;
			this.UxLblChangeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UxLblChangeAmount.Location = new System.Drawing.Point(193, 104);
			this.UxLblChangeAmount.Name = "UxLblChangeAmount";
			this.UxLblChangeAmount.Size = new System.Drawing.Size(0, 25);
			this.UxLblChangeAmount.TabIndex = 5;

			// 
			// UxBtnCalculate
			// 
			this.UxBtnCalculate.Location = new System.Drawing.Point(392, 17);
			this.UxBtnCalculate.Name = "UxBtnCalculate";
			this.UxBtnCalculate.Size = new System.Drawing.Size(143, 46);
			this.UxBtnCalculate.TabIndex = 3;
			this.UxBtnCalculate.Text = "Calcular";
			this.UxBtnCalculate.UseVisualStyleBackColor = true;
			this.UxBtnCalculate.Click += new System.EventHandler(this.UxBtnCalculate_Click);
			// 
			// MoneyChange
			// 
			this.AcceptButton = this.UxBtnCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(921, 479);
			this.Controls.Add(this.UxBtnCalculate);
			this.Controls.Add(this.UxLblChangeAmount);
			this.Controls.Add(this.UxLblChange);
			this.Controls.Add(this.UxTxtProductAmount);
			this.Controls.Add(this.UxLblProductAmount);
			this.Controls.Add(this.UxTxtPaidAmount);
			this.Controls.Add(this.UxLblPaidAmount);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MoneyChange";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MoneyChange";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label UxLblPaidAmount;
		private System.Windows.Forms.TextBox UxTxtPaidAmount;
		private System.Windows.Forms.Label UxLblProductAmount;
		private System.Windows.Forms.TextBox UxTxtProductAmount;
		private System.Windows.Forms.Label UxLblChange;
		private System.Windows.Forms.Label UxLblChangeAmount;
		private System.Windows.Forms.Button UxBtnCalculate;
	}
}

