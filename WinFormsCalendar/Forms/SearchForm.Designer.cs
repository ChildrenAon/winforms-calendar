namespace WinFormsCalendar
{
    partial class SearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Keyword = new System.Windows.Forms.TextBox();
            this.bt_Search = new System.Windows.Forms.Button();
            this.lv_Result = new System.Windows.Forms.ListView();
            this.lb_Count = new System.Windows.Forms.Label();
            this.ch_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "키워드";
            // 
            // tb_Keyword
            // 
            this.tb_Keyword.Location = new System.Drawing.Point(73, 21);
            this.tb_Keyword.Name = "tb_Keyword";
            this.tb_Keyword.Size = new System.Drawing.Size(222, 23);
            this.tb_Keyword.TabIndex = 1;
            // 
            // bt_Search
            // 
            this.bt_Search.Location = new System.Drawing.Point(311, 21);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(75, 23);
            this.bt_Search.TabIndex = 2;
            this.bt_Search.Text = "검색";
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // lv_Result
            // 
            this.lv_Result.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Date,
            this.ch_Time,
            this.ch_Title});
            this.lv_Result.FullRowSelect = true;
            this.lv_Result.HideSelection = false;
            this.lv_Result.Location = new System.Drawing.Point(15, 90);
            this.lv_Result.MultiSelect = false;
            this.lv_Result.Name = "lv_Result";
            this.lv_Result.Size = new System.Drawing.Size(371, 168);
            this.lv_Result.TabIndex = 3;
            this.lv_Result.UseCompatibleStateImageBehavior = false;
            this.lv_Result.View = System.Windows.Forms.View.Details;
            this.lv_Result.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lv_Result_ColumnWidthChanging);
            this.lv_Result.DoubleClick += new System.EventHandler(this.lv_Result_DoubleClick);
            // 
            // lb_Count
            // 
            this.lb_Count.AutoSize = true;
            this.lb_Count.Location = new System.Drawing.Point(12, 66);
            this.lb_Count.Name = "lb_Count";
            this.lb_Count.Size = new System.Drawing.Size(59, 15);
            this.lb_Count.TabIndex = 4;
            this.lb_Count.Text = "검색 결과";
            // 
            // ch_Date
            // 
            this.ch_Date.Text = "날짜";
            this.ch_Date.Width = 90;
            // 
            // ch_Time
            // 
            this.ch_Time.Text = "시간";
            // 
            // ch_Title
            // 
            this.ch_Title.Text = "제목";
            this.ch_Title.Width = 220;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "결과를 두 번 누르면 그 날짜로 이동해요";
            // 
            // bt_Close
            // 
            this.bt_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Close.Location = new System.Drawing.Point(311, 273);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(75, 30);
            this.bt_Close.TabIndex = 6;
            this.bt_Close.Text = "닫기";
            this.bt_Close.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AcceptButton = this.bt_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_Close;
            this.ClientSize = new System.Drawing.Size(398, 312);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Count);
            this.Controls.Add(this.lv_Result);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.tb_Keyword);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "일정 검색";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Keyword;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.ListView lv_Result;
        private System.Windows.Forms.ColumnHeader ch_Date;
        private System.Windows.Forms.ColumnHeader ch_Time;
        private System.Windows.Forms.ColumnHeader ch_Title;
        private System.Windows.Forms.Label lb_Count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Close;
    }
}
