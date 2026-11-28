namespace WinFormsCalendar
{
    partial class MiniWidgetForm
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
            this.lb_Today = new System.Windows.Forms.Label();
            this.ls_Today = new System.Windows.Forms.ListBox();
            this.lb_Dday = new System.Windows.Forms.Label();
            this.lb_Grass = new System.Windows.Forms.Label();
            this.pn_Grass = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lb_Today
            // 
            this.lb_Today.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Today.Location = new System.Drawing.Point(12, 9);
            this.lb_Today.Name = "lb_Today";
            this.lb_Today.Size = new System.Drawing.Size(216, 22);
            this.lb_Today.TabIndex = 0;
            this.lb_Today.Text = "label1";
            // 
            // ls_Today
            // 
            this.ls_Today.FormattingEnabled = true;
            this.ls_Today.ItemHeight = 15;
            this.ls_Today.Location = new System.Drawing.Point(12, 38);
            this.ls_Today.Name = "ls_Today";
            this.ls_Today.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ls_Today.Size = new System.Drawing.Size(216, 139);
            this.ls_Today.TabIndex = 1;
            // 
            // lb_Dday
            // 
            this.lb_Dday.Location = new System.Drawing.Point(12, 189);
            this.lb_Dday.Name = "lb_Dday";
            this.lb_Dday.Size = new System.Drawing.Size(216, 20);
            this.lb_Dday.TabIndex = 2;
            this.lb_Dday.Text = "label1";
            // 
            // lb_Grass
            // 
            this.lb_Grass.Location = new System.Drawing.Point(12, 219);
            this.lb_Grass.Name = "lb_Grass";
            this.lb_Grass.Size = new System.Drawing.Size(196, 20);
            this.lb_Grass.TabIndex = 3;
            this.lb_Grass.Text = "label1";
            // 
            // pn_Grass
            // 
            this.pn_Grass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_Grass.Location = new System.Drawing.Point(214, 221);
            this.pn_Grass.Name = "pn_Grass";
            this.pn_Grass.Size = new System.Drawing.Size(14, 14);
            this.pn_Grass.TabIndex = 17;
            // 
            // MiniWidgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 248);
            this.Controls.Add(this.pn_Grass);
            this.Controls.Add(this.lb_Grass);
            this.Controls.Add(this.lb_Dday);
            this.Controls.Add(this.ls_Today);
            this.Controls.Add(this.lb_Today);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiniWidgetForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "오늘의 일정";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MiniWidgetForm_FormClosed);
            this.Load += new System.EventHandler(this.MiniWidgetForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MiniWidgetForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Today;
        private System.Windows.Forms.ListBox ls_Today;
        private System.Windows.Forms.Label lb_Dday;
        private System.Windows.Forms.Label lb_Grass;
        private System.Windows.Forms.Panel pn_Grass;
    }
}
