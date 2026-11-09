namespace WinFormsCalendar
{
    partial class ScheduleForm
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
            this.lb_Date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nu_Hour = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nu_Minute = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.bt_CategoryColor = new System.Windows.Forms.Button();
            this.pn_CategoryColor = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Memo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_Attach = new System.Windows.Forms.Label();
            this.bt_Attach = new System.Windows.Forms.Button();
            this.bt_AttachClear = new System.Windows.Forms.Button();
            this.ck_Dday = new System.Windows.Forms.CheckBox();
            this.bt_OK = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nu_Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_Minute)).BeginInit();
            this.SuspendLayout();
            //
            // lb_Date
            //
            this.lb_Date.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lb_Date.Location = new System.Drawing.Point(20, 16);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(380, 22);
            this.lb_Date.TabIndex = 0;
            this.lb_Date.Text = "2026-11-02 (월)";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "제목";
            //
            // tb_Title
            //
            this.tb_Title.Location = new System.Drawing.Point(80, 52);
            this.tb_Title.Name = "tb_Title";
            this.tb_Title.Size = new System.Drawing.Size(320, 23);
            this.tb_Title.TabIndex = 2;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "시간";
            //
            // nu_Hour
            //
            this.nu_Hour.Location = new System.Drawing.Point(80, 88);
            this.nu_Hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nu_Hour.Name = "nu_Hour";
            this.nu_Hour.Size = new System.Drawing.Size(56, 23);
            this.nu_Hour.TabIndex = 4;
            this.nu_Hour.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "시";
            //
            // nu_Minute
            //
            this.nu_Minute.Location = new System.Drawing.Point(168, 88);
            this.nu_Minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nu_Minute.Name = "nu_Minute";
            this.nu_Minute.Size = new System.Drawing.Size(56, 23);
            this.nu_Minute.TabIndex = 6;
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "분";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "분류";
            //
            // cb_Category
            //
            this.cb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(80, 124);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(150, 23);
            this.cb_Category.TabIndex = 9;
            this.cb_Category.SelectedIndexChanged += new System.EventHandler(this.cb_Category_SelectedIndexChanged);
            //
            // bt_CategoryColor
            //
            this.bt_CategoryColor.Location = new System.Drawing.Point(240, 123);
            this.bt_CategoryColor.Name = "bt_CategoryColor";
            this.bt_CategoryColor.Size = new System.Drawing.Size(90, 25);
            this.bt_CategoryColor.TabIndex = 10;
            this.bt_CategoryColor.Text = "색 지정";
            this.bt_CategoryColor.UseVisualStyleBackColor = true;
            this.bt_CategoryColor.Click += new System.EventHandler(this.bt_CategoryColor_Click);
            //
            // pn_CategoryColor
            //
            this.pn_CategoryColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_CategoryColor.Location = new System.Drawing.Point(338, 124);
            this.pn_CategoryColor.Name = "pn_CategoryColor";
            this.pn_CategoryColor.Size = new System.Drawing.Size(62, 23);
            this.pn_CategoryColor.TabIndex = 11;
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "메모";
            //
            // tb_Memo
            //
            this.tb_Memo.AcceptsReturn = true;
            this.tb_Memo.Location = new System.Drawing.Point(80, 160);
            this.tb_Memo.Multiline = true;
            this.tb_Memo.Name = "tb_Memo";
            this.tb_Memo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Memo.Size = new System.Drawing.Size(320, 90);
            this.tb_Memo.TabIndex = 13;
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "첨부";
            //
            // lb_Attach
            //
            this.lb_Attach.AutoEllipsis = true;
            this.lb_Attach.Location = new System.Drawing.Point(80, 270);
            this.lb_Attach.Name = "lb_Attach";
            this.lb_Attach.Size = new System.Drawing.Size(226, 20);
            this.lb_Attach.TabIndex = 15;
            this.lb_Attach.Text = "첨부 파일 없음";
            //
            // bt_Attach
            //
            this.bt_Attach.Location = new System.Drawing.Point(312, 265);
            this.bt_Attach.Name = "bt_Attach";
            this.bt_Attach.Size = new System.Drawing.Size(88, 25);
            this.bt_Attach.TabIndex = 16;
            this.bt_Attach.Text = "파일 선택";
            this.bt_Attach.UseVisualStyleBackColor = true;
            this.bt_Attach.Click += new System.EventHandler(this.bt_Attach_Click);
            //
            // bt_AttachClear
            //
            this.bt_AttachClear.Location = new System.Drawing.Point(312, 294);
            this.bt_AttachClear.Name = "bt_AttachClear";
            this.bt_AttachClear.Size = new System.Drawing.Size(88, 25);
            this.bt_AttachClear.TabIndex = 17;
            this.bt_AttachClear.Text = "첨부 해제";
            this.bt_AttachClear.UseVisualStyleBackColor = true;
            this.bt_AttachClear.Click += new System.EventHandler(this.bt_AttachClear_Click);
            //
            // ck_Dday
            //
            this.ck_Dday.AutoSize = true;
            this.ck_Dday.Location = new System.Drawing.Point(80, 340);
            this.ck_Dday.Name = "ck_Dday";
            this.ck_Dday.Size = new System.Drawing.Size(120, 19);
            this.ck_Dday.TabIndex = 18;
            this.ck_Dday.Text = "D-day로 표시";
            this.ck_Dday.UseVisualStyleBackColor = true;
            //
            // bt_OK
            //
            this.bt_OK.Location = new System.Drawing.Point(230, 396);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(80, 32);
            this.bt_OK.TabIndex = 19;
            this.bt_OK.Text = "확인";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            //
            // bt_Cancel
            //
            this.bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancel.Location = new System.Drawing.Point(320, 396);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(80, 32);
            this.bt_Cancel.TabIndex = 20;
            this.bt_Cancel.Text = "취소";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            //
            // ScheduleForm
            //
            this.AcceptButton = this.bt_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_Cancel;
            this.ClientSize = new System.Drawing.Size(420, 444);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.ck_Dday);
            this.Controls.Add(this.bt_AttachClear);
            this.Controls.Add(this.bt_Attach);
            this.Controls.Add(this.lb_Attach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_Memo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pn_CategoryColor);
            this.Controls.Add(this.bt_CategoryColor);
            this.Controls.Add(this.cb_Category);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nu_Minute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nu_Hour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Date);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScheduleForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "일정 등록·수정";
            ((System.ComponentModel.ISupportInitialize)(this.nu_Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_Minute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nu_Hour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nu_Minute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.Button bt_CategoryColor;
        private System.Windows.Forms.Panel pn_CategoryColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Memo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_Attach;
        private System.Windows.Forms.Button bt_Attach;
        private System.Windows.Forms.Button bt_AttachClear;
        private System.Windows.Forms.CheckBox ck_Dday;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
