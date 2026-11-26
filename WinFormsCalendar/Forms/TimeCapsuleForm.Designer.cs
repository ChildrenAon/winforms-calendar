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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtp_Date
            // 
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(74, 18);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(239, 23);
            this.dtp_Date.TabIndex = 0;
            // 
            // tb_Message
            // 
            this.tb_Message.Location = new System.Drawing.Point(74, 51);
            this.tb_Message.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Message.Multiline = true;
            this.tb_Message.Name = "tb_Message";
            this.tb_Message.Size = new System.Drawing.Size(239, 102);
            this.tb_Message.TabIndex = 1;
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(319, 124);
            this.bt_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(75, 29);
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
            this.lv_Capsule.Location = new System.Drawing.Point(30, 226);
            this.lv_Capsule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_Capsule.Name = "lv_Capsule";
            this.lv_Capsule.Size = new System.Drawing.Size(364, 142);
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
            this.ch_Message.Width = 1000;
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(319, 376);
            this.bt_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(75, 29);
            this.bt_Delete.TabIndex = 4;
            this.bt_Delete.Text = "삭제";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "날짜";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "내용";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "묻어 둔 캡슐";
            // 
            // TimeCapsuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 418);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.lv_Capsule);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.tb_Message);
            this.Controls.Add(this.dtp_Date);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
