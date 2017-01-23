namespace LAB4_V5
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
            this.components = new System.ComponentModel.Container();
            this.ListAllDevice = new System.Windows.Forms.ListBox();
            this.deviceManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListAllComputer = new System.Windows.Forms.ListBox();
            this.InstallingDriver = new System.Windows.Forms.Button();
            this.ButtonInstullDriver = new System.Windows.Forms.Button();
            this.ButtonDeleteDriver = new System.Windows.Forms.Button();
            this.buttonAddDeviceToComp = new System.Windows.Forms.Button();
            this.buttonRemoveDeviceToComp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deviceManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ListAllDevice
            // 
            this.ListAllDevice.DataSource = this.deviceManagerBindingSource;
            this.ListAllDevice.DisplayMember = "AllDeivce";
            this.ListAllDevice.FormattingEnabled = true;
            this.ListAllDevice.Location = new System.Drawing.Point(51, 22);
            this.ListAllDevice.Name = "ListAllDevice";
            this.ListAllDevice.Size = new System.Drawing.Size(207, 303);
            this.ListAllDevice.TabIndex = 0;
            this.ListAllDevice.ValueMember = "AllDeivce";
            // 
            // deviceManagerBindingSource
            // 
            this.deviceManagerBindingSource.DataSource = typeof(LAB4_V5.DeviceManager);
            // 
            // ListAllComputer
            // 
            this.ListAllComputer.DataSource = this.deviceManagerBindingSource;
            this.ListAllComputer.DisplayMember = "AllComputers";
            this.ListAllComputer.FormattingEnabled = true;
            this.ListAllComputer.Location = new System.Drawing.Point(363, 22);
            this.ListAllComputer.Name = "ListAllComputer";
            this.ListAllComputer.Size = new System.Drawing.Size(204, 303);
            this.ListAllComputer.TabIndex = 1;
            this.ListAllComputer.ValueMember = "AllComputers";
            // 
            // InstallingDriver
            // 
            this.InstallingDriver.Location = new System.Drawing.Point(51, 331);
            this.InstallingDriver.Name = "InstallingDriver";
            this.InstallingDriver.Size = new System.Drawing.Size(207, 36);
            this.InstallingDriver.TabIndex = 2;
            this.InstallingDriver.Text = "УСТАНОВКА ДРАЙВЕРОВ";
            this.InstallingDriver.UseVisualStyleBackColor = true;
            // 
            // ButtonInstullDriver
            // 
            this.ButtonInstullDriver.Location = new System.Drawing.Point(51, 373);
            this.ButtonInstullDriver.Name = "ButtonInstullDriver";
            this.ButtonInstullDriver.Size = new System.Drawing.Size(102, 38);
            this.ButtonInstullDriver.TabIndex = 3;
            this.ButtonInstullDriver.Text = "ДОБАВИТЬ";
            this.ButtonInstullDriver.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteDriver
            // 
            this.ButtonDeleteDriver.Location = new System.Drawing.Point(159, 373);
            this.ButtonDeleteDriver.Name = "ButtonDeleteDriver";
            this.ButtonDeleteDriver.Size = new System.Drawing.Size(99, 38);
            this.ButtonDeleteDriver.TabIndex = 4;
            this.ButtonDeleteDriver.Text = "УДАЛИТЬ";
            this.ButtonDeleteDriver.UseVisualStyleBackColor = true;
            // 
            // buttonAddDeviceToComp
            // 
            this.buttonAddDeviceToComp.Location = new System.Drawing.Point(282, 105);
            this.buttonAddDeviceToComp.Name = "buttonAddDeviceToComp";
            this.buttonAddDeviceToComp.Size = new System.Drawing.Size(57, 33);
            this.buttonAddDeviceToComp.TabIndex = 5;
            this.buttonAddDeviceToComp.Text = ">";
            this.buttonAddDeviceToComp.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveDeviceToComp
            // 
            this.buttonRemoveDeviceToComp.Location = new System.Drawing.Point(282, 167);
            this.buttonRemoveDeviceToComp.Name = "buttonRemoveDeviceToComp";
            this.buttonRemoveDeviceToComp.Size = new System.Drawing.Size(57, 33);
            this.buttonRemoveDeviceToComp.TabIndex = 6;
            this.buttonRemoveDeviceToComp.Text = "<";
            this.buttonRemoveDeviceToComp.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 437);
            this.Controls.Add(this.buttonRemoveDeviceToComp);
            this.Controls.Add(this.buttonAddDeviceToComp);
            this.Controls.Add(this.ButtonDeleteDriver);
            this.Controls.Add(this.ButtonInstullDriver);
            this.Controls.Add(this.InstallingDriver);
            this.Controls.Add(this.ListAllComputer);
            this.Controls.Add(this.ListAllDevice);
            this.Name = "MainForm";
            this.Text = "DeviceManager";
            ((System.ComponentModel.ISupportInitialize)(this.deviceManagerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListAllDevice;
        private System.Windows.Forms.BindingSource deviceManagerBindingSource;
        private System.Windows.Forms.ListBox ListAllComputer;
        private System.Windows.Forms.Button InstallingDriver;
        private System.Windows.Forms.Button ButtonInstullDriver;
        private System.Windows.Forms.Button ButtonDeleteDriver;
        private System.Windows.Forms.Button buttonAddDeviceToComp;
        private System.Windows.Forms.Button buttonRemoveDeviceToComp;
    }
}

