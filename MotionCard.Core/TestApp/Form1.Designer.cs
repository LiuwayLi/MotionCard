
namespace TestApp
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.axisUctrl1 = new MotionUctrls.AxisUctrl();
            this.cylinderUctrl2 = new MotionUctrls.CylinderUctrl();
            this.diUctrl1 = new MotionUctrls.DIUctrl();
            this.doUctrl1 = new MotionUctrls.DOUctrl();
            this.cylinderUctrl1 = new MotionUctrls.CylinderUctrl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "加载";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 74);
            this.button2.TabIndex = 1;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // axisUctrl1
            // 
            this.axisUctrl1.AxisName = "Turn tab";
            this.axisUctrl1.BackColor = System.Drawing.Color.White;
            this.axisUctrl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.axisUctrl1.DisplayName = "";
            this.axisUctrl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.axisUctrl1.Location = new System.Drawing.Point(35, 324);
            this.axisUctrl1.Margin = new System.Windows.Forms.Padding(10);
            this.axisUctrl1.Name = "axisUctrl1";
            this.axisUctrl1.Size = new System.Drawing.Size(618, 235);
            this.axisUctrl1.TabIndex = 6;
            // 
            // cylinderUctrl2
            // 
            this.cylinderUctrl2.BackColor = System.Drawing.Color.White;
            this.cylinderUctrl2.CylinderName = null;
            this.cylinderUctrl2.Location = new System.Drawing.Point(590, 44);
            this.cylinderUctrl2.Name = "cylinderUctrl2";
            this.cylinderUctrl2.Size = new System.Drawing.Size(272, 107);
            this.cylinderUctrl2.TabIndex = 5;
            // 
            // diUctrl1
            // 
            this.diUctrl1.BackColor = System.Drawing.Color.White;
            this.diUctrl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diUctrl1.DIName = null;
            this.diUctrl1.DisplayName = null;
            this.diUctrl1.Location = new System.Drawing.Point(631, 157);
            this.diUctrl1.MaximumSize = new System.Drawing.Size(220, 57);
            this.diUctrl1.MinimumSize = new System.Drawing.Size(220, 57);
            this.diUctrl1.Name = "diUctrl1";
            this.diUctrl1.Size = new System.Drawing.Size(220, 57);
            this.diUctrl1.TabIndex = 4;
            // 
            // doUctrl1
            // 
            this.doUctrl1.BackColor = System.Drawing.Color.White;
            this.doUctrl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doUctrl1.DIsplayName = null;
            this.doUctrl1.DOName = null;
            this.doUctrl1.Location = new System.Drawing.Point(540, 78);
            this.doUctrl1.MaximumSize = new System.Drawing.Size(220, 57);
            this.doUctrl1.MinimumSize = new System.Drawing.Size(220, 57);
            this.doUctrl1.Name = "doUctrl1";
            this.doUctrl1.Size = new System.Drawing.Size(220, 57);
            this.doUctrl1.TabIndex = 3;
            // 
            // cylinderUctrl1
            // 
            this.cylinderUctrl1.BackColor = System.Drawing.Color.White;
            this.cylinderUctrl1.CylinderName = "123";
            this.cylinderUctrl1.Location = new System.Drawing.Point(58, 157);
            this.cylinderUctrl1.Name = "cylinderUctrl1";
            this.cylinderUctrl1.Size = new System.Drawing.Size(272, 107);
            this.cylinderUctrl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 815);
            this.Controls.Add(this.axisUctrl1);
            this.Controls.Add(this.cylinderUctrl2);
            this.Controls.Add(this.diUctrl1);
            this.Controls.Add(this.doUctrl1);
            this.Controls.Add(this.cylinderUctrl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private MotionUctrls.CylinderUctrl cylinderUctrl1;
        private MotionUctrls.DOUctrl doUctrl1;
        private MotionUctrls.DIUctrl diUctrl1;
        private MotionUctrls.CylinderUctrl cylinderUctrl2;
        private MotionUctrls.AxisUctrl axisUctrl1;
    }
}

