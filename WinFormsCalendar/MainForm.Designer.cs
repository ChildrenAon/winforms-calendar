namespace WinFormsCalendar
{
    partial class MainForm
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
            this.bt_Prev = new System.Windows.Forms.Button();
            this.lb_Month = new System.Windows.Forms.Label();
            this.bt_Next = new System.Windows.Forms.Button();
            this.bt_Today = new System.Windows.Forms.Button();
            this.lb_SelectedDate = new System.Windows.Forms.Label();
            this.lv_Schedule = new System.Windows.Forms.ListView();
            this.ch_Time = new System.Windows.Forms.ColumnHeader();
            this.ch_Title = new System.Windows.Forms.ColumnHeader();
            this.ch_Category = new System.Windows.Forms.ColumnHeader();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.lb_Dday = new System.Windows.Forms.Label();
            this.ls_Dday = new System.Windows.Forms.ListBox();
            this.bt_Search = new System.Windows.Forms.Button();
            this.bt_Capsule = new System.Windows.Forms.Button();
            this.bt_Grass = new System.Windows.Forms.Button();
            this.bt_Mini = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // bt_Prev
            //
            this.bt_Prev.Location = new System.Drawing.Point(20, 14);
            this.bt_Prev.Name = "bt_Prev";
            this.bt_Prev.Size = new System.Drawing.Size(40, 30);
            this.bt_Prev.TabIndex = 0;
            this.bt_Prev.Text = "<";
            this.bt_Prev.UseVisualStyleBackColor = true;
            this.bt_Prev.Click += new System.EventHandler(this.bt_Prev_Click);
            //
            // lb_Month
            //
            this.lb_Month.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.lb_Month.Location = new System.Drawing.Point(64, 14);
            this.lb_Month.Name = "lb_Month";
            this.lb_Month.Size = new System.Drawing.Size(142, 30);
            this.lb_Month.TabIndex = 1;
            this.lb_Month.Text = "2026년 11월";
            this.lb_Month.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // bt_Next
            //
            this.bt_Next.Location = new System.Drawing.Point(210, 14);
            this.bt_Next.Name = "bt_Next";
            this.bt_Next.Size = new System.Drawing.Size(40, 30);
            this.bt_Next.TabIndex = 2;
            this.bt_Next.Text = ">";
            this.bt_Next.UseVisualStyleBackColor = true;
            this.bt_Next.Click += new System.EventHandler(this.bt_Next_Click);
            //
            // bt_Today
            //
            this.bt_Today.Location = new System.Drawing.Point(262, 14);
            this.bt_Today.Name = "bt_Today";
            this.bt_Today.Size = new System.Drawing.Size(60, 30);
            this.bt_Today.TabIndex = 3;
            this.bt_Today.Text = "오늘";
            this.bt_Today.UseVisualStyleBackColor = true;
            this.bt_Today.Click += new System.EventHandler(this.bt_Today_Click);
            //
            // lb_SelectedDate
            //
            this.lb_SelectedDate.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.lb_SelectedDate.Location = new System.Drawing.Point(710, 14);
            this.lb_SelectedDate.Name = "lb_SelectedDate";
            this.lb_SelectedDate.Size = new System.Drawing.Size(270, 30);
            this.lb_SelectedDate.TabIndex = 4;
            this.lb_SelectedDate.Text = "2026-11-02 (월)";
            this.lb_SelectedDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lv_Schedule
            //
            this.lv_Schedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Time,
            this.ch_Title,
            this.ch_Category});
            this.lv_Schedule.FullRowSelect = true;
            this.lv_Schedule.HideSelection = false;
            this.lv_Schedule.Location = new System.Drawing.Point(710, 52);
            this.lv_Schedule.MultiSelect = false;
            this.lv_Schedule.Name = "lv_Schedule";
            this.lv_Schedule.Size = new System.Drawing.Size(270, 250);
            this.lv_Schedule.TabIndex = 5;
            this.lv_Schedule.UseCompatibleStateImageBehavior = false;
            this.lv_Schedule.View = System.Windows.Forms.View.Details;
            this.lv_Schedule.DoubleClick += new System.EventHandler(this.lv_Schedule_DoubleClick);
            //
            // ch_Time
            //
            this.ch_Time.Text = "시간";
            this.ch_Time.Width = 56;
            //
            // ch_Title
            //
            this.ch_Title.Text = "제목";
            this.ch_Title.Width = 130;
            //
            // ch_Category
            //
            this.ch_Category.Text = "분류";
            this.ch_Category.Width = 64;
            //
            // bt_Add
            //
            this.bt_Add.Location = new System.Drawing.Point(710, 310);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(86, 30);
            this.bt_Add.TabIndex = 6;
            this.bt_Add.Text = "추가";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            //
            // bt_Edit
            //
            this.bt_Edit.Location = new System.Drawing.Point(802, 310);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(86, 30);
            this.bt_Edit.TabIndex = 7;
            this.bt_Edit.Text = "수정";
            this.bt_Edit.UseVisualStyleBackColor = true;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            //
            // bt_Delete
            //
            this.bt_Delete.Location = new System.Drawing.Point(894, 310);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(86, 30);
            this.bt_Delete.TabIndex = 8;
            this.bt_Delete.Text = "삭제";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            //
            // lb_Dday
            //
            this.lb_Dday.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lb_Dday.Location = new System.Drawing.Point(710, 356);
            this.lb_Dday.Name = "lb_Dday";
            this.lb_Dday.Size = new System.Drawing.Size(270, 22);
            this.lb_Dday.TabIndex = 9;
            this.lb_Dday.Text = "D-day";
            this.lb_Dday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // ls_Dday
            //
            this.ls_Dday.FormattingEnabled = true;
            this.ls_Dday.IntegralHeight = false;
            this.ls_Dday.ItemHeight = 15;
            this.ls_Dday.Location = new System.Drawing.Point(710, 380);
            this.ls_Dday.Name = "ls_Dday";
            this.ls_Dday.Size = new System.Drawing.Size(270, 180);
            this.ls_Dday.TabIndex = 10;
            //
            // bt_Search
            //
            this.bt_Search.Location = new System.Drawing.Point(20, 584);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(110, 34);
            this.bt_Search.TabIndex = 11;
            this.bt_Search.Text = "검색";
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            //
            // bt_Capsule
            //
            this.bt_Capsule.Location = new System.Drawing.Point(140, 584);
            this.bt_Capsule.Name = "bt_Capsule";
            this.bt_Capsule.Size = new System.Drawing.Size(110, 34);
            this.bt_Capsule.TabIndex = 12;
            this.bt_Capsule.Text = "타임캡슐";
            this.bt_Capsule.UseVisualStyleBackColor = true;
            this.bt_Capsule.Click += new System.EventHandler(this.bt_Capsule_Click);
            //
            // bt_Grass
            //
            this.bt_Grass.Location = new System.Drawing.Point(260, 584);
            this.bt_Grass.Name = "bt_Grass";
            this.bt_Grass.Size = new System.Drawing.Size(110, 34);
            this.bt_Grass.TabIndex = 13;
            this.bt_Grass.Text = "잔디 기록";
            this.bt_Grass.UseVisualStyleBackColor = true;
            this.bt_Grass.Click += new System.EventHandler(this.bt_Grass_Click);
            // 
            // bt_Mini
            // 
            this.bt_Mini.Location = new System.Drawing.Point(380, 584);
            this.bt_Mini.Name = "bt_Mini";
            this.bt_Mini.Size = new System.Drawing.Size(110, 34);
            this.bt_Mini.TabIndex = 14;
            this.bt_Mini.Text = "미니 모드";
            this.bt_Mini.UseVisualStyleBackColor = true;
            this.bt_Mini.Click += new System.EventHandler(this.bt_Mini_Click);
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.bt_Mini);
            this.Controls.Add(this.bt_Grass);
            this.Controls.Add(this.bt_Capsule);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.ls_Dday);
            this.Controls.Add(this.lb_Dday);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.lv_Schedule);
            this.Controls.Add(this.lb_SelectedDate);
            this.Controls.Add(this.bt_Today);
            this.Controls.Add(this.bt_Next);
            this.Controls.Add(this.lb_Month);
            this.Controls.Add(this.bt_Prev);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "캘린더";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Prev;
        private System.Windows.Forms.Label lb_Month;
        private System.Windows.Forms.Button bt_Next;
        private System.Windows.Forms.Button bt_Today;
        private System.Windows.Forms.Label lb_SelectedDate;
        private System.Windows.Forms.ListView lv_Schedule;
        private System.Windows.Forms.ColumnHeader ch_Time;
        private System.Windows.Forms.ColumnHeader ch_Title;
        private System.Windows.Forms.ColumnHeader ch_Category;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Label lb_Dday;
        private System.Windows.Forms.ListBox ls_Dday;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Button bt_Capsule;
        private System.Windows.Forms.Button bt_Grass;
        private System.Windows.Forms.Button bt_Mini;
    }
}
