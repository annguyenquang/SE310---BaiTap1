namespace ToDo
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
			this.giveBirthBtn = new System.Windows.Forms.Button();
			this.goatInput = new System.Windows.Forms.TextBox();
			this.sheepInput = new System.Windows.Forms.TextBox();
			this.cowInput = new System.Windows.Forms.TextBox();
			this.makeSound = new System.Windows.Forms.Button();
			this.analyzeBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// giveBirthBtn
			// 
			this.giveBirthBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.giveBirthBtn.Location = new System.Drawing.Point(37, 241);
			this.giveBirthBtn.Name = "giveBirthBtn";
			this.giveBirthBtn.Size = new System.Drawing.Size(117, 35);
			this.giveBirthBtn.TabIndex = 1;
			this.giveBirthBtn.Text = "Đẻ";
			this.giveBirthBtn.UseVisualStyleBackColor = true;
			this.giveBirthBtn.Click += new System.EventHandler(this.giveBirthBtn_Click);
			// 
			// goatInput
			// 
			this.goatInput.Location = new System.Drawing.Point(86, 153);
			this.goatInput.Name = "goatInput";
			this.goatInput.Size = new System.Drawing.Size(117, 20);
			this.goatInput.TabIndex = 2;
			// 
			// sheepInput
			// 
			this.sheepInput.Location = new System.Drawing.Point(86, 111);
			this.sheepInput.Name = "sheepInput";
			this.sheepInput.Size = new System.Drawing.Size(117, 20);
			this.sheepInput.TabIndex = 3;
			// 
			// cowInput
			// 
			this.cowInput.Location = new System.Drawing.Point(86, 75);
			this.cowInput.Name = "cowInput";
			this.cowInput.Size = new System.Drawing.Size(117, 20);
			this.cowInput.TabIndex = 4;
			// 
			// makeSound
			// 
			this.makeSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.makeSound.Location = new System.Drawing.Point(200, 241);
			this.makeSound.Name = "makeSound";
			this.makeSound.Size = new System.Drawing.Size(117, 36);
			this.makeSound.TabIndex = 5;
			this.makeSound.Text = "Kêu";
			this.makeSound.UseVisualStyleBackColor = true;
			// 
			// analyzeBtn
			// 
			this.analyzeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.analyzeBtn.Location = new System.Drawing.Point(360, 241);
			this.analyzeBtn.Name = "analyzeBtn";
			this.analyzeBtn.Size = new System.Drawing.Size(117, 36);
			this.analyzeBtn.TabIndex = 6;
			this.analyzeBtn.Text = "Phân tích";
			this.analyzeBtn.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Info;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(30, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(346, 39);
			this.label1.TabIndex = 7;
			this.label1.Text = "Nhập số lượng tại đây";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Info;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(34, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(22, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Bò";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Info;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(34, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Dê";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.Info;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(34, 156);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Cừu";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.button2.Font = new System.Drawing.Font("MS Gothic", 20F, ((System.Drawing.FontStyle)((((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
			this.button2.Location = new System.Drawing.Point(302, 75);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(134, 97);
			this.button2.TabIndex = 12;
			this.button2.Text = "Chốt !";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.BackgroundImage = global::ToDo.Properties.Resources.liveStock;
			this.ClientSize = new System.Drawing.Size(1365, 549);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.analyzeBtn);
			this.Controls.Add(this.makeSound);
			this.Controls.Add(this.cowInput);
			this.Controls.Add(this.sheepInput);
			this.Controls.Add(this.goatInput);
			this.Controls.Add(this.giveBirthBtn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button giveBirthBtn;
		private System.Windows.Forms.TextBox goatInput;
		private System.Windows.Forms.TextBox sheepInput;
		private System.Windows.Forms.TextBox cowInput;
		private System.Windows.Forms.Button makeSound;
		private System.Windows.Forms.Button analyzeBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
	}
}

