namespace TeaBagMaker
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbList = new System.Windows.Forms.ComboBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.lblCountNum = new System.Windows.Forms.Label();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbList
            // 
            this.cbList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbList.FormattingEnabled = true;
            this.cbList.Location = new System.Drawing.Point(13, 13);
            this.cbList.Name = "cbList";
            this.cbList.Size = new System.Drawing.Size(233, 20);
            this.cbList.TabIndex = 0;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(13, 40);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(233, 57);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "담그기!";
            this.btnCount.UseVisualStyleBackColor = true;
            // 
            // lblCountNum
            // 
            this.lblCountNum.AutoSize = true;
            this.lblCountNum.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCountNum.Location = new System.Drawing.Point(13, 104);
            this.lblCountNum.Name = "lblCountNum";
            this.lblCountNum.Size = new System.Drawing.Size(60, 21);
            this.lblCountNum.TabIndex = 2;
            this.lblCountNum.Text = "label1";
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Location = new System.Drawing.Point(15, 147);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(230, 12);
            this.lblCopyRight.TabIndex = 3;
            this.lblCopyRight.Text = "Copyright by 3502 Kim Kaseul, 20190527";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 172);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.lblCountNum);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.cbList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TeaBagMaker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbList;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label lblCountNum;
        private System.Windows.Forms.Label lblCopyRight;
    }
}

