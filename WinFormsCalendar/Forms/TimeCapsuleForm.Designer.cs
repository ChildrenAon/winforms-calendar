namespace WinFormsCalendar
{
    partial class TimeCapsuleForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Message = new System.Windows.Forms.TextBox();
            this.bt_Add = new System.Windows.Forms.Button();
            this.lv_Capsule = new System.Windows.Forms.ListView();
            this.ch_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_Date
            // 
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(30, 14);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(263, 21);
            this.dtp_Date.TabIndex = 0;
            // 
            // tb_Message
            // 
            this.tb_Message.Location = new System.Drawing.Point(30, 41);
            this.tb_Message.Multiline = true;
            this.tb_Message.Name = "tb_Message";
            this.tb_Message.Size = new System.Drawing.Size(263, 82);
            this.tb_Message.TabIndex = 1;
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(319, 100);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(75, 23);
            this.bt_Add.TabIndex = 2;
            this.bt_Add.Text = "캡슐 묻기";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // lv_Capsule
            // 
            this.lv_Capsule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Date,
            this.ch_State,
            this.ch_Message});
            this.lv_Capsule.FullRowSelect = true;
            this.lv_Capsule.HideSelection = false;
            this.lv_Capsule.Location = new System.Drawing.Point(30, 145);
            this.lv_Capsule.Name = "lv_Capsule";
            this.lv_Capsule.Size = new System.Drawing.Size(364, 114);
            this.lv_Capsule.TabIndex = 3;
            this.lv_Capsule.UseCompatibleStateImageBehavior = false;
            this.lv_Capsule.View = System.Windows.Forms.View.Details;
            this.lv_Capsule.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lv_Capsule_ColumnWidthChanging);
            // 
            // ch_Date
            // 
            this.ch_Date.Text = "날짜";
            this.ch_Date.Width = 90;
            // 
            // ch_State
            // 
            this.ch_State.Text = "상태";
            this.ch_State.Width = 50;
            // 
            // ch_Message
            // 
            this.ch_Message.Text = "메시지";
            this.ch_Message.Width = 220;
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(319, 265);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(75, 23);
            this.bt_Delete.TabIndex = 4;
            this.bt_Delete.Text = "삭제";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // TimeCapsuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 300);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.lv_Capsule);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.tb_Message);
            this.Controls.Add(this.dtp_Date);
            this.Name = "TimeCapsuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "타임캡슐";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox tb_Message;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.ListView lv_Capsule;
        private System.Windows.Forms.ColumnHeader ch_Date;
        private System.Windows.Forms.ColumnHeader ch_State;
        private System.Windows.Forms.ColumnHeader ch_Message;
        private System.Windows.Forms.Button bt_Delete;
    }
}
