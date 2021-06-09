
namespace MotionUctrls
{
    partial class AxisUctrl
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
            this.btnHome = new HZH_Controls.Controls.UCBtnExt();
            this.lampORG = new HZH_Controls.Controls.UCSignalLamp();
            this.label1 = new System.Windows.Forms.Label();
            this.lampELP = new HZH_Controls.Controls.UCSignalLamp();
            this.label2 = new System.Windows.Forms.Label();
            this.lampELN = new HZH_Controls.Controls.UCSignalLamp();
            this.label3 = new System.Windows.Forms.Label();
            this.lampMoving = new HZH_Controls.Controls.UCSignalLamp();
            this.label4 = new System.Windows.Forms.Label();
            this.lampALM = new HZH_Controls.Controls.UCSignalLamp();
            this.label5 = new System.Windows.Forms.Label();
            this.lampHomed = new HZH_Controls.Controls.UCSignalLamp();
            this.label6 = new System.Windows.Forms.Label();
            this.switchEnable = new HZH_Controls.Controls.UCSwitch();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.btnClrAlm = new HZH_Controls.Controls.UCBtnExt();
            this.btnStop = new HZH_Controls.Controls.UCBtnExt();
            this.btnRel = new HZH_Controls.Controls.UCBtnExt();
            this.btnAbs = new HZH_Controls.Controls.UCBtnExt();
            this.udTargetDistance = new System.Windows.Forms.NumericUpDown();
            this.barVel = new HZH_Controls.Controls.UCTrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCurrentPosition = new System.Windows.Forms.TextBox();
            this.cbxCalibPos = new HZH_Controls.Controls.UCCombox();
            this.btnMoveto = new HZH_Controls.Controls.UCBtnExt();
            this.btnSaveCurrPosToCalibPos = new HZH_Controls.Controls.UCBtnExt();
            ((System.ComponentModel.ISupportInitialize)(this.udTargetDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.BtnBackColor = System.Drawing.Color.White;
            this.btnHome.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHome.BtnForeColor = System.Drawing.Color.White;
            this.btnHome.BtnText = "回原";
            this.btnHome.ConerRadius = 5;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.EnabledMouseEffect = false;
            this.btnHome.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnHome.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnHome.IsRadius = true;
            this.btnHome.IsShowRect = true;
            this.btnHome.IsShowTips = false;
            this.btnHome.Location = new System.Drawing.Point(10, 40);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.RectColor = System.Drawing.Color.Silver;
            this.btnHome.RectWidth = 1;
            this.btnHome.Size = new System.Drawing.Size(88, 33);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.TipsColor = System.Drawing.SystemColors.Highlight;
            this.btnHome.TipsText = "";
            this.btnHome.BtnClick += new System.EventHandler(this.btnHome_BtnClick);
            // 
            // lampORG
            // 
            this.lampORG.BackColor = System.Drawing.Color.White;
            this.lampORG.IsHighlight = false;
            this.lampORG.IsShowBorder = false;
            this.lampORG.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.Lime};
            this.lampORG.Location = new System.Drawing.Point(291, 35);
            this.lampORG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lampORG.Name = "lampORG";
            this.lampORG.Size = new System.Drawing.Size(24, 24);
            this.lampORG.TabIndex = 1;
            this.lampORG.TwinkleSpeed = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(285, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ORG";
            // 
            // lampELP
            // 
            this.lampELP.BackColor = System.Drawing.Color.White;
            this.lampELP.IsHighlight = false;
            this.lampELP.IsShowBorder = false;
            this.lampELP.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            this.lampELP.Location = new System.Drawing.Point(347, 35);
            this.lampELP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lampELP.Name = "lampELP";
            this.lampELP.Size = new System.Drawing.Size(24, 24);
            this.lampELP.TabIndex = 1;
            this.lampELP.TwinkleSpeed = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(346, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "EL+";
            // 
            // lampELN
            // 
            this.lampELN.BackColor = System.Drawing.Color.White;
            this.lampELN.IsHighlight = false;
            this.lampELN.IsShowBorder = false;
            this.lampELN.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            this.lampELN.Location = new System.Drawing.Point(403, 35);
            this.lampELN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lampELN.Name = "lampELN";
            this.lampELN.Size = new System.Drawing.Size(24, 24);
            this.lampELN.TabIndex = 1;
            this.lampELN.TwinkleSpeed = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(403, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "EL-";
            // 
            // lampMoving
            // 
            this.lampMoving.BackColor = System.Drawing.Color.White;
            this.lampMoving.IsHighlight = false;
            this.lampMoving.IsShowBorder = false;
            this.lampMoving.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.Lime};
            this.lampMoving.Location = new System.Drawing.Point(515, 35);
            this.lampMoving.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lampMoving.Name = "lampMoving";
            this.lampMoving.Size = new System.Drawing.Size(24, 24);
            this.lampMoving.TabIndex = 1;
            this.lampMoving.TwinkleSpeed = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(504, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Moving";
            // 
            // lampALM
            // 
            this.lampALM.BackColor = System.Drawing.Color.White;
            this.lampALM.IsHighlight = false;
            this.lampALM.IsShowBorder = false;
            this.lampALM.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            this.lampALM.Location = new System.Drawing.Point(459, 35);
            this.lampALM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lampALM.Name = "lampALM";
            this.lampALM.Size = new System.Drawing.Size(24, 24);
            this.lampALM.TabIndex = 1;
            this.lampALM.TwinkleSpeed = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(456, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "ALM";
            // 
            // lampHomed
            // 
            this.lampHomed.BackColor = System.Drawing.Color.White;
            this.lampHomed.IsHighlight = false;
            this.lampHomed.IsShowBorder = false;
            this.lampHomed.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.Lime};
            this.lampHomed.Location = new System.Drawing.Point(571, 35);
            this.lampHomed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lampHomed.Name = "lampHomed";
            this.lampHomed.Size = new System.Drawing.Size(24, 24);
            this.lampHomed.TabIndex = 1;
            this.lampHomed.TwinkleSpeed = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(562, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Homed";
            // 
            // switchEnable
            // 
            this.switchEnable.BackColor = System.Drawing.Color.Transparent;
            this.switchEnable.Checked = false;
            this.switchEnable.FalseColor = System.Drawing.Color.Black;
            this.switchEnable.FalseTextColr = System.Drawing.Color.White;
            this.switchEnable.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switchEnable.Location = new System.Drawing.Point(147, 39);
            this.switchEnable.Margin = new System.Windows.Forms.Padding(2);
            this.switchEnable.Name = "switchEnable";
            this.switchEnable.Size = new System.Drawing.Size(86, 33);
            this.switchEnable.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.switchEnable.TabIndex = 4;
            this.switchEnable.Texts = new string[] {
        "ON",
        "OFF"};
            this.switchEnable.TrueColor = System.Drawing.Color.Lime;
            this.switchEnable.TrueTextColr = System.Drawing.Color.White;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtDisplayName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDisplayName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDisplayName.Location = new System.Drawing.Point(-1, -1);
            this.txtDisplayName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.ReadOnly = true;
            this.txtDisplayName.Size = new System.Drawing.Size(620, 29);
            this.txtDisplayName.TabIndex = 8;
            this.txtDisplayName.Text = "AxisName";
            this.txtDisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClrAlm
            // 
            this.btnClrAlm.BackColor = System.Drawing.Color.White;
            this.btnClrAlm.BtnBackColor = System.Drawing.Color.White;
            this.btnClrAlm.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClrAlm.BtnForeColor = System.Drawing.Color.White;
            this.btnClrAlm.BtnText = "清除报警";
            this.btnClrAlm.ConerRadius = 5;
            this.btnClrAlm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClrAlm.EnabledMouseEffect = false;
            this.btnClrAlm.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnClrAlm.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnClrAlm.IsRadius = true;
            this.btnClrAlm.IsShowRect = true;
            this.btnClrAlm.IsShowTips = false;
            this.btnClrAlm.Location = new System.Drawing.Point(486, 195);
            this.btnClrAlm.Margin = new System.Windows.Forms.Padding(0);
            this.btnClrAlm.Name = "btnClrAlm";
            this.btnClrAlm.RectColor = System.Drawing.SystemColors.Highlight;
            this.btnClrAlm.RectWidth = 1;
            this.btnClrAlm.Size = new System.Drawing.Size(112, 36);
            this.btnClrAlm.TabIndex = 9;
            this.btnClrAlm.TabStop = false;
            this.btnClrAlm.TipsColor = System.Drawing.SystemColors.Highlight;
            this.btnClrAlm.TipsText = "";
            this.btnClrAlm.BtnClick += new System.EventHandler(this.btnClrAlm_BtnClick);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.BtnBackColor = System.Drawing.Color.White;
            this.btnStop.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.BtnForeColor = System.Drawing.Color.White;
            this.btnStop.BtnText = "停止";
            this.btnStop.ConerRadius = 5;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.EnabledMouseEffect = false;
            this.btnStop.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnStop.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnStop.IsRadius = true;
            this.btnStop.IsShowRect = true;
            this.btnStop.IsShowTips = false;
            this.btnStop.Location = new System.Drawing.Point(486, 96);
            this.btnStop.Margin = new System.Windows.Forms.Padding(0);
            this.btnStop.Name = "btnStop";
            this.btnStop.RectColor = System.Drawing.SystemColors.Highlight;
            this.btnStop.RectWidth = 1;
            this.btnStop.Size = new System.Drawing.Size(114, 33);
            this.btnStop.TabIndex = 10;
            this.btnStop.TabStop = false;
            this.btnStop.TipsColor = System.Drawing.SystemColors.Highlight;
            this.btnStop.TipsText = "";
            // 
            // btnRel
            // 
            this.btnRel.BackColor = System.Drawing.Color.White;
            this.btnRel.BtnBackColor = System.Drawing.Color.White;
            this.btnRel.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRel.BtnForeColor = System.Drawing.Color.White;
            this.btnRel.BtnText = "相对运动";
            this.btnRel.ConerRadius = 5;
            this.btnRel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRel.EnabledMouseEffect = false;
            this.btnRel.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnRel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRel.IsRadius = true;
            this.btnRel.IsShowRect = true;
            this.btnRel.IsShowTips = false;
            this.btnRel.Location = new System.Drawing.Point(231, 96);
            this.btnRel.Margin = new System.Windows.Forms.Padding(0);
            this.btnRel.Name = "btnRel";
            this.btnRel.RectColor = System.Drawing.SystemColors.Highlight;
            this.btnRel.RectWidth = 1;
            this.btnRel.Size = new System.Drawing.Size(112, 33);
            this.btnRel.TabIndex = 11;
            this.btnRel.TabStop = false;
            this.btnRel.TipsColor = System.Drawing.SystemColors.Highlight;
            this.btnRel.TipsText = "";
            this.btnRel.BtnClick += new System.EventHandler(this.btnRel_BtnClick);
            // 
            // btnAbs
            // 
            this.btnAbs.BackColor = System.Drawing.Color.White;
            this.btnAbs.BtnBackColor = System.Drawing.Color.White;
            this.btnAbs.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAbs.BtnForeColor = System.Drawing.Color.White;
            this.btnAbs.BtnText = "绝对运动";
            this.btnAbs.ConerRadius = 5;
            this.btnAbs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbs.EnabledMouseEffect = false;
            this.btnAbs.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnAbs.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAbs.IsRadius = true;
            this.btnAbs.IsShowRect = true;
            this.btnAbs.IsShowTips = false;
            this.btnAbs.Location = new System.Drawing.Point(360, 96);
            this.btnAbs.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.RectColor = System.Drawing.SystemColors.Highlight;
            this.btnAbs.RectWidth = 1;
            this.btnAbs.Size = new System.Drawing.Size(110, 33);
            this.btnAbs.TabIndex = 12;
            this.btnAbs.TabStop = false;
            this.btnAbs.TipsColor = System.Drawing.SystemColors.Highlight;
            this.btnAbs.TipsText = "";
            this.btnAbs.BtnClick += new System.EventHandler(this.btnAbs_BtnClick);
            // 
            // udTargetDistance
            // 
            this.udTargetDistance.BackColor = System.Drawing.SystemColors.Highlight;
            this.udTargetDistance.DecimalPlaces = 3;
            this.udTargetDistance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.udTargetDistance.Location = new System.Drawing.Point(120, 100);
            this.udTargetDistance.Margin = new System.Windows.Forms.Padding(2);
            this.udTargetDistance.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.udTargetDistance.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.udTargetDistance.Name = "udTargetDistance";
            this.udTargetDistance.Size = new System.Drawing.Size(98, 29);
            this.udTargetDistance.TabIndex = 13;
            // 
            // barVel
            // 
            this.barVel.DcimalDigits = 0;
            this.barVel.IsShowTips = true;
            this.barVel.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.barVel.LineWidth = 10F;
            this.barVel.Location = new System.Drawing.Point(98, 199);
            this.barVel.MaxValue = 100F;
            this.barVel.MinValue = 0F;
            this.barVel.Name = "barVel";
            this.barVel.Size = new System.Drawing.Size(369, 30);
            this.barVel.TabIndex = 14;
            this.barVel.Text = "ucTrackBar1";
            this.barVel.TipsFormat = null;
            this.barVel.Value = 0F;
            this.barVel.ValueColor = System.Drawing.SystemColors.Highlight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(6, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "调试速度：";
            // 
            // txtCurrentPosition
            // 
            this.txtCurrentPosition.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtCurrentPosition.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCurrentPosition.Location = new System.Drawing.Point(5, 101);
            this.txtCurrentPosition.Name = "txtCurrentPosition";
            this.txtCurrentPosition.ReadOnly = true;
            this.txtCurrentPosition.Size = new System.Drawing.Size(100, 27);
            this.txtCurrentPosition.TabIndex = 16;
            // 
            // cbxCalibPos
            // 
            this.cbxCalibPos.BackColor = System.Drawing.Color.Transparent;
            this.cbxCalibPos.BackColorExt = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbxCalibPos.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxCalibPos.ConerRadius = 5;
            this.cbxCalibPos.DropPanelHeight = -1;
            this.cbxCalibPos.FillColor = System.Drawing.Color.White;
            this.cbxCalibPos.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cbxCalibPos.IsRadius = true;
            this.cbxCalibPos.IsShowRect = true;
            this.cbxCalibPos.ItemWidth = 70;
            this.cbxCalibPos.Location = new System.Drawing.Point(127, 149);
            this.cbxCalibPos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxCalibPos.Name = "cbxCalibPos";
            this.cbxCalibPos.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.cbxCalibPos.RectWidth = 1;
            this.cbxCalibPos.SelectedIndex = -1;
            this.cbxCalibPos.SelectedValue = "";
            this.cbxCalibPos.Size = new System.Drawing.Size(346, 34);
            this.cbxCalibPos.Source = null;
            this.cbxCalibPos.TabIndex = 17;
            this.cbxCalibPos.TextValue = null;
            this.cbxCalibPos.TriangleColor = System.Drawing.SystemColors.Highlight;
            // 
            // btnMoveto
            // 
            this.btnMoveto.BackColor = System.Drawing.Color.White;
            this.btnMoveto.BtnBackColor = System.Drawing.Color.White;
            this.btnMoveto.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMoveto.BtnForeColor = System.Drawing.Color.White;
            this.btnMoveto.BtnText = "移动至";
            this.btnMoveto.ConerRadius = 5;
            this.btnMoveto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveto.EnabledMouseEffect = false;
            this.btnMoveto.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnMoveto.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnMoveto.IsRadius = true;
            this.btnMoveto.IsShowRect = true;
            this.btnMoveto.IsShowTips = false;
            this.btnMoveto.Location = new System.Drawing.Point(8, 149);
            this.btnMoveto.Margin = new System.Windows.Forms.Padding(0);
            this.btnMoveto.Name = "btnMoveto";
            this.btnMoveto.RectColor = System.Drawing.SystemColors.Highlight;
            this.btnMoveto.RectWidth = 1;
            this.btnMoveto.Size = new System.Drawing.Size(112, 33);
            this.btnMoveto.TabIndex = 18;
            this.btnMoveto.TabStop = false;
            this.btnMoveto.TipsColor = System.Drawing.SystemColors.Highlight;
            this.btnMoveto.TipsText = "";
            // 
            // btnSaveCurrPosToCalibPos
            // 
            this.btnSaveCurrPosToCalibPos.BackColor = System.Drawing.Color.White;
            this.btnSaveCurrPosToCalibPos.BtnBackColor = System.Drawing.Color.White;
            this.btnSaveCurrPosToCalibPos.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveCurrPosToCalibPos.BtnForeColor = System.Drawing.Color.White;
            this.btnSaveCurrPosToCalibPos.BtnText = "更新标定点位";
            this.btnSaveCurrPosToCalibPos.ConerRadius = 5;
            this.btnSaveCurrPosToCalibPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCurrPosToCalibPos.EnabledMouseEffect = false;
            this.btnSaveCurrPosToCalibPos.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveCurrPosToCalibPos.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSaveCurrPosToCalibPos.IsRadius = true;
            this.btnSaveCurrPosToCalibPos.IsShowRect = true;
            this.btnSaveCurrPosToCalibPos.IsShowTips = false;
            this.btnSaveCurrPosToCalibPos.Location = new System.Drawing.Point(486, 149);
            this.btnSaveCurrPosToCalibPos.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveCurrPosToCalibPos.Name = "btnSaveCurrPosToCalibPos";
            this.btnSaveCurrPosToCalibPos.RectColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveCurrPosToCalibPos.RectWidth = 1;
            this.btnSaveCurrPosToCalibPos.Size = new System.Drawing.Size(112, 38);
            this.btnSaveCurrPosToCalibPos.TabIndex = 19;
            this.btnSaveCurrPosToCalibPos.TabStop = false;
            this.btnSaveCurrPosToCalibPos.TipsColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveCurrPosToCalibPos.TipsText = "";
            // 
            // AxisUctrl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnSaveCurrPosToCalibPos);
            this.Controls.Add(this.btnMoveto);
            this.Controls.Add(this.cbxCalibPos);
            this.Controls.Add(this.txtCurrentPosition);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.barVel);
            this.Controls.Add(this.udTargetDistance);
            this.Controls.Add(this.btnAbs);
            this.Controls.Add(this.btnRel);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnClrAlm);
            this.Controls.Add(this.txtDisplayName);
            this.Controls.Add(this.switchEnable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lampHomed);
            this.Controls.Add(this.lampALM);
            this.Controls.Add(this.lampMoving);
            this.Controls.Add(this.lampELN);
            this.Controls.Add(this.lampELP);
            this.Controls.Add(this.lampORG);
            this.Controls.Add(this.btnHome);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "AxisUctrl";
            this.Size = new System.Drawing.Size(618, 235);
            this.Load += new System.EventHandler(this.AxisUctrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udTargetDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HZH_Controls.Controls.UCBtnExt btnHome;
        private HZH_Controls.Controls.UCSignalLamp lampORG;
        private System.Windows.Forms.Label label1;
        private HZH_Controls.Controls.UCSignalLamp lampELP;
        private System.Windows.Forms.Label label2;
        private HZH_Controls.Controls.UCSignalLamp lampELN;
        private System.Windows.Forms.Label label3;
        private HZH_Controls.Controls.UCSignalLamp lampMoving;
        private System.Windows.Forms.Label label4;
        private HZH_Controls.Controls.UCSignalLamp lampALM;
        private System.Windows.Forms.Label label5;
        private HZH_Controls.Controls.UCSignalLamp lampHomed;
        private System.Windows.Forms.Label label6;
        private HZH_Controls.Controls.UCSwitch switchEnable;
        private System.Windows.Forms.TextBox txtDisplayName;
        private HZH_Controls.Controls.UCBtnExt btnClrAlm;
        private HZH_Controls.Controls.UCBtnExt btnStop;
        private HZH_Controls.Controls.UCBtnExt btnRel;
        private HZH_Controls.Controls.UCBtnExt btnAbs;
        private System.Windows.Forms.NumericUpDown udTargetDistance;
        private HZH_Controls.Controls.UCTrackBar barVel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCurrentPosition;
        private HZH_Controls.Controls.UCCombox cbxCalibPos;
        private HZH_Controls.Controls.UCBtnExt btnMoveto;
        private HZH_Controls.Controls.UCBtnExt btnSaveCurrPosToCalibPos;
    }
}
