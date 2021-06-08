
namespace MotionUctrls
{
    partial class DIUctrl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDI = new HZH_Controls.Controls.UCSignalLamp();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDI
            // 
            this.btnDI.IsHighlight = false;
            this.btnDI.IsShowBorder = false;
            this.btnDI.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))))};
            this.btnDI.Location = new System.Drawing.Point(165, 8);
            this.btnDI.MaximumSize = new System.Drawing.Size(40, 40);
            this.btnDI.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnDI.Name = "btnDI";
            this.btnDI.Size = new System.Drawing.Size(40, 40);
            this.btnDI.TabIndex = 0;
            this.btnDI.TwinkleSpeed = 0;
            // 
            // lblDIName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDisplayName.Location = new System.Drawing.Point(18, 18);
            this.lblDisplayName.Name = "lblDIName";
            this.lblDisplayName.Size = new System.Drawing.Size(87, 25);
            this.lblDisplayName.TabIndex = 1;
            this.lblDisplayName.Text = "DIName";
            // 
            // DIUctrl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.btnDI);
            this.MaximumSize = new System.Drawing.Size(220, 57);
            this.MinimumSize = new System.Drawing.Size(220, 57);
            this.Name = "DIUctrl";
            this.Size = new System.Drawing.Size(218, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HZH_Controls.Controls.UCSignalLamp btnDI;
        private System.Windows.Forms.Label lblDisplayName;
    }
}
