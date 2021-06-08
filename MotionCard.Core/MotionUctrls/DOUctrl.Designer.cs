
namespace MotionUctrls
{
    partial class DOUctrl
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
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lampDO = new HZH_Controls.Controls.UCSignalLamp();
            this.SuspendLayout();
            // 
            // lblDO
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDisplayName.Location = new System.Drawing.Point(5, 16);
            this.lblDisplayName.Name = "lblDO";
            this.lblDisplayName.Size = new System.Drawing.Size(0, 20);
            this.lblDisplayName.TabIndex = 0;
            // 
            // lampDO
            // 
            this.lampDO.IsHighlight = true;
            this.lampDO.IsShowBorder = true;
            this.lampDO.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))))};
            this.lampDO.Location = new System.Drawing.Point(164, 7);
            this.lampDO.Name = "lampDO";
            this.lampDO.Size = new System.Drawing.Size(40, 40);
            this.lampDO.TabIndex = 1;
            this.lampDO.TwinkleSpeed = 0;
            this.lampDO.Click += new System.EventHandler(this.lampDO_Click);
            // 
            // DOUctrl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lampDO);
            this.Controls.Add(this.lblDisplayName);
            this.MaximumSize = new System.Drawing.Size(220, 57);
            this.MinimumSize = new System.Drawing.Size(220, 57);
            this.Name = "DOUctrl";
            this.Size = new System.Drawing.Size(218, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplayName;
        private HZH_Controls.Controls.UCSignalLamp lampDO;
    }
}
