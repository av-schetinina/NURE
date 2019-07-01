namespace TimeToDoIt
{
    partial class AddNewRoute
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
            this.tbRouteName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDepatureTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbArrivalTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddRoute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbRouteName
            // 
            this.tbRouteName.Location = new System.Drawing.Point(12, 53);
            this.tbRouteName.Name = "tbRouteName";
            this.tbRouteName.Size = new System.Drawing.Size(255, 20);
            this.tbRouteName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя пути";
            // 
            // tbDepatureTime
            // 
            this.tbDepatureTime.Location = new System.Drawing.Point(12, 108);
            this.tbDepatureTime.Name = "tbDepatureTime";
            this.tbDepatureTime.Size = new System.Drawing.Size(255, 20);
            this.tbDepatureTime.TabIndex = 2;
            this.tbDepatureTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDepatureTime_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Время отправления";
            // 
            // tbArrivalTime
            // 
            this.tbArrivalTime.Location = new System.Drawing.Point(12, 164);
            this.tbArrivalTime.Name = "tbArrivalTime";
            this.tbArrivalTime.Size = new System.Drawing.Size(255, 20);
            this.tbArrivalTime.TabIndex = 4;
            this.tbArrivalTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbArrivalTime_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Время прибытия";
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.Location = new System.Drawing.Point(98, 215);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(75, 23);
            this.btnAddRoute.TabIndex = 6;
            this.btnAddRoute.Text = "Добавить";
            this.btnAddRoute.UseVisualStyleBackColor = true;
            this.btnAddRoute.Click += new System.EventHandler(this.btnAddRoute_Click);
            // 
            // AddNewRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 250);
            this.Controls.Add(this.btnAddRoute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbArrivalTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDepatureTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRouteName);
            this.Name = "AddNewRoute";
            this.Text = "AddNewRoute";
            this.Load += new System.EventHandler(this.AddNewRoute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRouteName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDepatureTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbArrivalTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddRoute;
    }
}