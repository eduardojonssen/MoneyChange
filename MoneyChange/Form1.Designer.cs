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
			this.UxBtnCalculate = new System.Windows.Forms.Button();
			this.UxTxtResult = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// UxLblPaidAmount
			// 
			this.UxLblPaidAmount.AutoSize = true;
			this.UxLblPaidAmount.Location = new System.Drawing.Point(15, 64);
			this.UxLblPaidAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.UxLblPaidAmount.Name = "UxLblPaidAmount";
			this.UxLblPaidAmount.Size = new System.Drawing.Size(113, 25);
			this.UxLblPaidAmount.TabIndex = 0;
			this.UxLblPaidAmount.Text = "Valor pago:";
			// 
			// UxTxtPaidAmount
			// 
			this.UxTxtPaidAmount.Location = new System.Drawing.Point(205, 60);
			this.UxTxtPaidAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.UxTxtPaidAmount.Name = "UxTxtPaidAmount";
			this.UxTxtPaidAmount.Size = new System.Drawing.Size(251, 29);
			this.UxTxtPaidAmount.TabIndex = 2;
			// 
			// UxLblProductAmount
			// 
			this.UxLblProductAmount.AutoSize = true;
			this.UxLblProductAmount.Location = new System.Drawing.Point(15, 20);
			this.UxLblProductAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.UxLblProductAmount.Name = "UxLblProductAmount";
			this.UxLblProductAmount.Size = new System.Drawing.Size(162, 25);
			this.UxLblProductAmount.TabIndex = 2;
			this.UxLblProductAmount.Text = "Valor do produto:";
			// 
			// UxTxtProductAmount
			// 
			this.UxTxtProductAmount.Location = new System.Drawing.Point(205, 17);
			this.UxTxtProductAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.UxTxtProductAmount.Name = "UxTxtProductAmount";
			this.UxTxtProductAmount.Size = new System.Drawing.Size(251, 29);
			this.UxTxtProductAmount.TabIndex = 1;
			// 
			// UxLblChange
			// 
			this.UxLblChange.AutoSize = true;
			this.UxLblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UxLblChange.Location = new System.Drawing.Point(15, 125);
			this.UxLblChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.UxLblChange.Name = "UxLblChange";
			this.UxLblChange.Size = new System.Drawing.Size(207, 54);
			this.UxLblChange.TabIndex = 4;
			this.UxLblChange.Text = "TROCO:";
			// 
			// UxBtnCalculate
			// 
			this.UxBtnCalculate.Location = new System.Drawing.Point(479, 20);
			this.UxBtnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.UxBtnCalculate.Name = "UxBtnCalculate";
			this.UxBtnCalculate.Size = new System.Drawing.Size(175, 55);
			this.UxBtnCalculate.TabIndex = 3;
			this.UxBtnCalculate.Text = "Calcular";
			this.UxBtnCalculate.UseVisualStyleBackColor = true;
			this.UxBtnCalculate.Click += new System.EventHandler(this.UxBtnCalculate_Click);
			// 
			// UxTxtResult
			// 
			this.UxTxtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UxTxtResult.Location = new System.Drawing.Point(12, 182);
			this.UxTxtResult.Multiline = true;
			this.UxTxtResult.Name = "UxTxtResult";
			this.UxTxtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.UxTxtResult.Size = new System.Drawing.Size(642, 381);
			this.UxTxtResult.TabIndex = 5;
			// 
			// MoneyChange
			// 
			this.AcceptButton = this.UxBtnCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(679, 575);
			this.Controls.Add(this.UxTxtResult);
			this.Controls.Add(this.UxBtnCalculate);
			this.Controls.Add(this.UxLblChange);
			this.Controls.Add(this.UxTxtProductAmount);
			this.Controls.Add(this.UxLblProductAmount);
			this.Controls.Add(this.UxTxtPaidAmount);
			this.Controls.Add(this.UxLblPaidAmount);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
		private System.Windows.Forms.Button UxBtnCalculate;
		private System.Windows.Forms.TextBox UxTxtResult;
	}
}

