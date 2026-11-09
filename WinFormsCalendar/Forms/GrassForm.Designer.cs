namespace WinFormsCalendar
{
    partial class GrassForm
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
            this.tb_Activity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nu_Minutes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lv_Record = new System.Windows.Forms.ListView();
            this.ch_Activity = new System.Windows.Forms.ColumnHeader();
            this.ch_Minutes = new System.Windows.Forms.ColumnHeader();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.lb_Total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pn_Legend1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pn_Legend2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pn_Legend3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pn_Legend4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nu_Minutes)).BeginInit();
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
            this.label1.Text = "활동";
            //
            // tb_Activity
            //
            this.tb_Activity.Location = new System.Drawing.Point(80, 52);
            this.tb_Activity.Name = "tb_Activity";
            this.tb_Activity.Size = new System.Drawing.Size(320, 23);
            this.tb_Activity.TabIndex = 2;
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
            // nu_Minutes
            //
            this.nu_Minutes.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nu_Minutes.Location = new System.Drawing.Point(80, 88);
            this.nu_Minutes.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.nu_Minutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nu_Minutes.Name = "nu_Minutes";
            this.nu_Minutes.Size = new System.Drawing.Size(70, 23);
            this.nu_Minutes.TabIndex = 4;
            this.nu_Minutes.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "분";
            //
            // bt_Add
            //
            this.bt_Add.Location = new System.Drawing.Point(300, 86);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(100, 28);
            this.bt_Add.TabIndex = 6;
            this.bt_Add.Text = "기록 추가";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(20, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "이 날의 기록";
            //
            // lv_Record
            //
            this.lv_Record.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Activity,
            this.ch_Minutes});
            this.lv_Record.FullRowSelect = true;
            this.lv_Record.HideSelection = false;
            this.lv_Record.Location = new System.Drawing.Point(20, 154);
            this.lv_Record.MultiSelect = false;
            this.lv_Record.Name = "lv_Record";
            this.lv_Record.Size = new System.Drawing.Size(380, 170);
            this.lv_Record.TabIndex = 8;
            this.lv_Record.UseCompatibleStateImageBehavior = false;
            this.lv_Record.View = System.Windows.Forms.View.Details;
            //
            // ch_Activity
            //
            this.ch_Activity.Text = "활동";
            this.ch_Activity.Width = 250;
            //
            // ch_Minutes
            //
            this.ch_Minutes.Text = "시간(분)";
            this.ch_Minutes.Width = 100;
            //
            // bt_Delete
            //
            this.bt_Delete.Location = new System.Drawing.Point(20, 332);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(100, 28);
            this.bt_Delete.TabIndex = 9;
            this.bt_Delete.Text = "선택 삭제";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            //
            // lb_Total
            //
            this.lb_Total.Location = new System.Drawing.Point(130, 336);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(270, 22);
            this.lb_Total.TabIndex = 10;
            this.lb_Total.Text = "합계 0분";
            this.lb_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "색 단계";
            //
            // pn_Legend1
            //
            this.pn_Legend1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_Legend1.Location = new System.Drawing.Point(70, 385);
            this.pn_Legend1.Name = "pn_Legend1";
            this.pn_Legend1.Size = new System.Drawing.Size(14, 14);
            this.pn_Legend1.TabIndex = 12;
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "1시간 미만";
            //
            // pn_Legend2
            //
            this.pn_Legend2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_Legend2.Location = new System.Drawing.Point(158, 385);
            this.pn_Legend2.Name = "pn_Legend2";
            this.pn_Legend2.Size = new System.Drawing.Size(14, 14);
            this.pn_Legend2.TabIndex = 14;
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "2시간 미만";
            //
            // pn_Legend3
            //
            this.pn_Legend3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_Legend3.Location = new System.Drawing.Point(246, 385);
            this.pn_Legend3.Name = "pn_Legend3";
            this.pn_Legend3.Size = new System.Drawing.Size(14, 14);
            this.pn_Legend3.TabIndex = 16;
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "4시간 미만";
            //
            // pn_Legend4
            //
            this.pn_Legend4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_Legend4.Location = new System.Drawing.Point(334, 385);
            this.pn_Legend4.Name = "pn_Legend4";
            this.pn_Legend4.Size = new System.Drawing.Size(14, 14);
            this.pn_Legend4.TabIndex = 18;
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "4시간 이상";
            //
            // bt_Close
            //
            this.bt_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Close.Location = new System.Drawing.Point(300, 416);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(100, 32);
            this.bt_Close.TabIndex = 20;
            this.bt_Close.Text = "닫기";
            this.bt_Close.UseVisualStyleBackColor = true;
            //
            // GrassForm
            //
            this.AcceptButton = this.bt_Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_Close;
            this.ClientSize = new System.Drawing.Size(420, 464);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pn_Legend4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pn_Legend3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pn_Legend2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pn_Legend1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.lv_Record);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nu_Minutes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Activity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Date);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GrassForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "잔디 기록";
            ((System.ComponentModel.ISupportInitialize)(this.nu_Minutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Activity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nu_Minutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lv_Record;
        private System.Windows.Forms.ColumnHeader ch_Activity;
        private System.Windows.Forms.ColumnHeader ch_Minutes;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pn_Legend1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pn_Legend2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pn_Legend3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pn_Legend4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_Close;
    }
}
