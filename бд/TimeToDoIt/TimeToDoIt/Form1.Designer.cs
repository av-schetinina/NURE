namespace TimeToDoIt
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.id_train = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_train = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbControllAll = new System.Windows.Forms.TabControl();
            this.tabPageAdditional = new System.Windows.Forms.TabPage();
            this.tbDelete = new System.Windows.Forms.Button();
            this.btnAdditing = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRouteArrive = new System.Windows.Forms.TextBox();
            this.tbRouteDeparture = new System.Windows.Forms.TextBox();
            this.tbRouteName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStaffName = new System.Windows.Forms.TextBox();
            this.tbStaffNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCarriageType = new System.Windows.Forms.TextBox();
            this.tbCarriageNumber = new System.Windows.Forms.TextBox();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.cbCarriage = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbStaff = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbAddDepartureTime = new System.Windows.Forms.TextBox();
            this.tbAddArivalTime = new System.Windows.Forms.TextBox();
            this.cbTrain = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAddCarriage = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnAddRoute = new System.Windows.Forms.Button();
            this.btnAddTrain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.tbControllAll.SuspendLayout();
            this.tabPageAdditional.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_train,
            this.number_train});
            this.dgvMain.Location = new System.Drawing.Point(12, 12);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.Size = new System.Drawing.Size(267, 462);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            // 
            // id_train
            // 
            this.id_train.HeaderText = "Номер поезда в списке";
            this.id_train.Name = "id_train";
            this.id_train.ReadOnly = true;
            // 
            // number_train
            // 
            this.number_train.HeaderText = "Номер поезда";
            this.number_train.Name = "number_train";
            this.number_train.ReadOnly = true;
            // 
            // tbControllAll
            // 
            this.tbControllAll.Controls.Add(this.tabPageAdditional);
            this.tbControllAll.Controls.Add(this.tabPageAdd);
            this.tbControllAll.Location = new System.Drawing.Point(297, 12);
            this.tbControllAll.Name = "tbControllAll";
            this.tbControllAll.SelectedIndex = 0;
            this.tbControllAll.Size = new System.Drawing.Size(487, 462);
            this.tbControllAll.TabIndex = 1;
            // 
            // tabPageAdditional
            // 
            this.tabPageAdditional.Controls.Add(this.tbDelete);
            this.tabPageAdditional.Controls.Add(this.btnAdditing);
            this.tabPageAdditional.Controls.Add(this.label10);
            this.tabPageAdditional.Controls.Add(this.label9);
            this.tabPageAdditional.Controls.Add(this.label8);
            this.tabPageAdditional.Controls.Add(this.tbRouteArrive);
            this.tabPageAdditional.Controls.Add(this.tbRouteDeparture);
            this.tabPageAdditional.Controls.Add(this.tbRouteName);
            this.tabPageAdditional.Controls.Add(this.label7);
            this.tabPageAdditional.Controls.Add(this.label6);
            this.tabPageAdditional.Controls.Add(this.label5);
            this.tabPageAdditional.Controls.Add(this.tbStaffName);
            this.tabPageAdditional.Controls.Add(this.tbStaffNumber);
            this.tabPageAdditional.Controls.Add(this.label4);
            this.tabPageAdditional.Controls.Add(this.label3);
            this.tabPageAdditional.Controls.Add(this.label2);
            this.tabPageAdditional.Controls.Add(this.label1);
            this.tabPageAdditional.Controls.Add(this.tbCarriageType);
            this.tabPageAdditional.Controls.Add(this.tbCarriageNumber);
            this.tabPageAdditional.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdditional.Name = "tabPageAdditional";
            this.tabPageAdditional.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdditional.Size = new System.Drawing.Size(479, 436);
            this.tabPageAdditional.TabIndex = 0;
            this.tabPageAdditional.Text = "Additional Information";
            this.tabPageAdditional.UseVisualStyleBackColor = true;
            // 
            // tbDelete
            // 
            this.tbDelete.Location = new System.Drawing.Point(336, 390);
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(107, 23);
            this.tbDelete.TabIndex = 18;
            this.tbDelete.Text = "Удалить";
            this.tbDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdditing
            // 
            this.btnAdditing.Location = new System.Drawing.Point(37, 390);
            this.btnAdditing.Name = "btnAdditing";
            this.btnAdditing.Size = new System.Drawing.Size(107, 23);
            this.btnAdditing.TabIndex = 17;
            this.btnAdditing.Text = "Править";
            this.btnAdditing.UseVisualStyleBackColor = true;
            this.btnAdditing.Click += new System.EventHandler(this.btnAdditing_Click);
            this.btnAdditing.Enter += new System.EventHandler(this.btnAdditing_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(162, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Время прибытия";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(162, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Время отправления";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Название пути";
            // 
            // tbRouteArrive
            // 
            this.tbRouteArrive.Location = new System.Drawing.Point(162, 319);
            this.tbRouteArrive.Name = "tbRouteArrive";
            this.tbRouteArrive.ReadOnly = true;
            this.tbRouteArrive.Size = new System.Drawing.Size(162, 20);
            this.tbRouteArrive.TabIndex = 13;
            this.tbRouteArrive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRouteArrive_KeyPress);
            // 
            // tbRouteDeparture
            // 
            this.tbRouteDeparture.Location = new System.Drawing.Point(162, 264);
            this.tbRouteDeparture.Name = "tbRouteDeparture";
            this.tbRouteDeparture.ReadOnly = true;
            this.tbRouteDeparture.Size = new System.Drawing.Size(162, 20);
            this.tbRouteDeparture.TabIndex = 12;
            this.tbRouteDeparture.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRouteDeparture_KeyPress);
            // 
            // tbRouteName
            // 
            this.tbRouteName.Location = new System.Drawing.Point(162, 209);
            this.tbRouteName.Name = "tbRouteName";
            this.tbRouteName.ReadOnly = true;
            this.tbRouteName.Size = new System.Drawing.Size(162, 20);
            this.tbRouteName.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "----------НАПРАВЛЕНИЕ----------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "----------ГРУЗ----------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "----------ПЕРСОНАЛ----------";
            // 
            // tbStaffName
            // 
            this.tbStaffName.Location = new System.Drawing.Point(283, 126);
            this.tbStaffName.Name = "tbStaffName";
            this.tbStaffName.ReadOnly = true;
            this.tbStaffName.Size = new System.Drawing.Size(190, 20);
            this.tbStaffName.TabIndex = 7;
            // 
            // tbStaffNumber
            // 
            this.tbStaffNumber.Location = new System.Drawing.Point(6, 126);
            this.tbStaffNumber.Name = "tbStaffNumber";
            this.tbStaffNumber.ReadOnly = true;
            this.tbStaffNumber.Size = new System.Drawing.Size(190, 20);
            this.tbStaffNumber.TabIndex = 6;
            this.tbStaffNumber.Leave += new System.EventHandler(this.tbStaffNumber_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Сотрудник";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Номер сотрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Груз";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер груза";
            // 
            // tbCarriageType
            // 
            this.tbCarriageType.Location = new System.Drawing.Point(283, 57);
            this.tbCarriageType.Name = "tbCarriageType";
            this.tbCarriageType.ReadOnly = true;
            this.tbCarriageType.Size = new System.Drawing.Size(190, 20);
            this.tbCarriageType.TabIndex = 1;
            // 
            // tbCarriageNumber
            // 
            this.tbCarriageNumber.Location = new System.Drawing.Point(6, 57);
            this.tbCarriageNumber.Name = "tbCarriageNumber";
            this.tbCarriageNumber.ReadOnly = true;
            this.tbCarriageNumber.Size = new System.Drawing.Size(190, 20);
            this.tbCarriageNumber.TabIndex = 0;
            this.tbCarriageNumber.Leave += new System.EventHandler(this.tbCarriageNumber_Leave);
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.btnAddTrain);
            this.tabPageAdd.Controls.Add(this.btnAddRoute);
            this.tabPageAdd.Controls.Add(this.btnAddStaff);
            this.tabPageAdd.Controls.Add(this.btnAddCarriage);
            this.tabPageAdd.Controls.Add(this.label15);
            this.tabPageAdd.Controls.Add(this.label14);
            this.tabPageAdd.Controls.Add(this.cbTrain);
            this.tabPageAdd.Controls.Add(this.tbAddArivalTime);
            this.tabPageAdd.Controls.Add(this.tbAddDepartureTime);
            this.tabPageAdd.Controls.Add(this.label13);
            this.tabPageAdd.Controls.Add(this.label12);
            this.tabPageAdd.Controls.Add(this.cbStaff);
            this.tabPageAdd.Controls.Add(this.label11);
            this.tabPageAdd.Controls.Add(this.cbCarriage);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(479, 436);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Add New Train";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // cbCarriage
            // 
            this.cbCarriage.FormattingEnabled = true;
            this.cbCarriage.Location = new System.Drawing.Point(26, 32);
            this.cbCarriage.Name = "cbCarriage";
            this.cbCarriage.Size = new System.Drawing.Size(254, 21);
            this.cbCarriage.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Какой груз будет везти поезд?";
            // 
            // cbStaff
            // 
            this.cbStaff.FormattingEnabled = true;
            this.cbStaff.Location = new System.Drawing.Point(26, 109);
            this.cbStaff.Name = "cbStaff";
            this.cbStaff.Size = new System.Drawing.Size(254, 21);
            this.cbStaff.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Какой сотрудник будет вести состав?";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Каким путем пойдет поезд?";
            // 
            // tbAddDepartureTime
            // 
            this.tbAddDepartureTime.Location = new System.Drawing.Point(26, 244);
            this.tbAddDepartureTime.Name = "tbAddDepartureTime";
            this.tbAddDepartureTime.ReadOnly = true;
            this.tbAddDepartureTime.Size = new System.Drawing.Size(254, 20);
            this.tbAddDepartureTime.TabIndex = 5;
            this.tbAddDepartureTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddDepartureTime_KeyPress);
            // 
            // tbAddArivalTime
            // 
            this.tbAddArivalTime.Location = new System.Drawing.Point(26, 297);
            this.tbAddArivalTime.Name = "tbAddArivalTime";
            this.tbAddArivalTime.ReadOnly = true;
            this.tbAddArivalTime.Size = new System.Drawing.Size(254, 20);
            this.tbAddArivalTime.TabIndex = 6;
            this.tbAddArivalTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddArivalTime_KeyPress);
            // 
            // cbTrain
            // 
            this.cbTrain.FormattingEnabled = true;
            this.cbTrain.Location = new System.Drawing.Point(26, 195);
            this.cbTrain.Name = "cbTrain";
            this.cbTrain.Size = new System.Drawing.Size(254, 21);
            this.cbTrain.TabIndex = 7;
            this.cbTrain.SelectedIndexChanged += new System.EventHandler(this.cbTrain_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(215, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Время отправления на выбраном пункте";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 281);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(192, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Время прибытия по выбраному пути";
            // 
            // btnAddCarriage
            // 
            this.btnAddCarriage.Location = new System.Drawing.Point(318, 30);
            this.btnAddCarriage.Name = "btnAddCarriage";
            this.btnAddCarriage.Size = new System.Drawing.Size(139, 23);
            this.btnAddCarriage.TabIndex = 10;
            this.btnAddCarriage.Text = "Добавить новый";
            this.btnAddCarriage.UseVisualStyleBackColor = true;
            this.btnAddCarriage.Click += new System.EventHandler(this.btnAddCarriage_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(318, 107);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(139, 23);
            this.btnAddStaff.TabIndex = 11;
            this.btnAddStaff.Text = "Добавить нового";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.Location = new System.Drawing.Point(318, 193);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(139, 23);
            this.btnAddRoute.TabIndex = 12;
            this.btnAddRoute.Text = "Добавить новый";
            this.btnAddRoute.UseVisualStyleBackColor = true;
            this.btnAddRoute.Click += new System.EventHandler(this.btnAddRoute_Click);
            // 
            // btnAddTrain
            // 
            this.btnAddTrain.Location = new System.Drawing.Point(201, 381);
            this.btnAddTrain.Name = "btnAddTrain";
            this.btnAddTrain.Size = new System.Drawing.Size(105, 23);
            this.btnAddTrain.TabIndex = 14;
            this.btnAddTrain.Text = "Добавить состав";
            this.btnAddTrain.UseVisualStyleBackColor = true;
            this.btnAddTrain.Click += new System.EventHandler(this.btnAddTrain_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 486);
            this.Controls.Add(this.tbControllAll);
            this.Controls.Add(this.dgvMain);
            this.Name = "MainForm";
            this.Text = "MainFrom";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.tbControllAll.ResumeLayout(false);
            this.tabPageAdditional.ResumeLayout(false);
            this.tabPageAdditional.PerformLayout();
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.TabControl tbControllAll;
        private System.Windows.Forms.TabPage tabPageAdditional;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_train;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_train;
        private System.Windows.Forms.Button tbDelete;
        private System.Windows.Forms.Button btnAdditing;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbRouteArrive;
        private System.Windows.Forms.TextBox tbRouteDeparture;
        private System.Windows.Forms.TextBox tbRouteName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbStaffName;
        private System.Windows.Forms.TextBox tbStaffNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCarriageType;
        private System.Windows.Forms.TextBox tbCarriageNumber;
        private System.Windows.Forms.Button btnAddTrain;
        private System.Windows.Forms.Button btnAddRoute;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnAddCarriage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbTrain;
        private System.Windows.Forms.TextBox tbAddArivalTime;
        private System.Windows.Forms.TextBox tbAddDepartureTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbStaff;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbCarriage;
    }
}

