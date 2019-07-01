namespace TimeToDoIt
{
    partial class AddNewCarriage
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCarriageNumber = new System.Windows.Forms.TextBox();
            this.tbTypeName = new System.Windows.Forms.TextBox();
            this.tbSitsCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(112, 275);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Подтвердить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название груза";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип груза";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Объем (количество мест)";
            // 
            // tbCarriageNumber
            // 
            this.tbCarriageNumber.Location = new System.Drawing.Point(64, 55);
            this.tbCarriageNumber.Name = "tbCarriageNumber";
            this.tbCarriageNumber.Size = new System.Drawing.Size(269, 20);
            this.tbCarriageNumber.TabIndex = 5;
            // 
            // tbTypeName
            // 
            this.tbTypeName.Location = new System.Drawing.Point(64, 138);
            this.tbTypeName.Name = "tbTypeName";
            this.tbTypeName.Size = new System.Drawing.Size(269, 20);
            this.tbTypeName.TabIndex = 6;
            // 
            // tbSitsCount
            // 
            this.tbSitsCount.Location = new System.Drawing.Point(64, 225);
            this.tbSitsCount.Name = "tbSitsCount";
            this.tbSitsCount.Size = new System.Drawing.Size(269, 20);
            this.tbSitsCount.TabIndex = 7;
            // 
            // AddNewCarriage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 313);
            this.Controls.Add(this.tbSitsCount);
            this.Controls.Add(this.tbTypeName);
            this.Controls.Add(this.tbCarriageNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddNewCarriage";
            this.Text = "AddNewCarriage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewCarriage_FormClosing);
            this.Load += new System.EventHandler(this.AddNewCarriage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCarriageNumber;
        private System.Windows.Forms.TextBox tbTypeName;
        private System.Windows.Forms.TextBox tbSitsCount;
    }
}