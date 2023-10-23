namespace Calculator
{
    partial class calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            TxtBox = new TextBox();
            SevenBtn = new Button();
            FourBtn = new Button();
            OneBtn = new Button();
            ZeroBtn = new Button();
            DotBtn = new Button();
            TwoBtn = new Button();
            FiveBtn = new Button();
            EightBtn = new Button();
            EqualBtn = new Button();
            ThreeBtn = new Button();
            SixBtn = new Button();
            NineBtn = new Button();
            MinusPlusBtn = new Button();
            DivideBtn = new Button();
            MinusBtn = new Button();
            ModuleBtn = new Button();
            MultiplyBtn = new Button();
            AddBtn = new Button();
            ClearBtn = new Button();
            SuspendLayout();
            // 
            // TxtBox
            // 
            TxtBox.BackColor = SystemColors.HighlightText;
            TxtBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBox.ForeColor = SystemColors.WindowText;
            TxtBox.Location = new Point(13, 12);
            TxtBox.Name = "TxtBox";
            TxtBox.Size = new Size(536, 52);
            TxtBox.TabIndex = 0;
            TxtBox.Text = "0";
            TxtBox.TextAlign = HorizontalAlignment.Right;
            // 
            // SevenBtn
            // 
            SevenBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SevenBtn.Location = new Point(13, 66);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(94, 95);
            SevenBtn.TabIndex = 1;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = true;
            SevenBtn.Click += SevenBtn_Click;
            // 
            // FourBtn
            // 
            FourBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FourBtn.Location = new Point(13, 167);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(94, 101);
            FourBtn.TabIndex = 2;
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = true;
            FourBtn.Click += FourBtn_Click;
            // 
            // OneBtn
            // 
            OneBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OneBtn.Location = new Point(13, 274);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(94, 105);
            OneBtn.TabIndex = 3;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = true;
            OneBtn.Click += OneBtn_Click;
            // 
            // ZeroBtn
            // 
            ZeroBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ZeroBtn.Location = new Point(13, 382);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(94, 98);
            ZeroBtn.TabIndex = 4;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = true;
            ZeroBtn.Click += ZeroBtn_Click_1;
            // 
            // DotBtn
            // 
            DotBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DotBtn.Location = new Point(113, 382);
            DotBtn.Name = "DotBtn";
            DotBtn.Size = new Size(94, 98);
            DotBtn.TabIndex = 8;
            DotBtn.Text = ".";
            DotBtn.UseVisualStyleBackColor = true;
            DotBtn.Click += DotBtn_Click;
            // 
            // TwoBtn
            // 
            TwoBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TwoBtn.Location = new Point(113, 274);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(94, 105);
            TwoBtn.TabIndex = 7;
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = true;
            TwoBtn.Click += TwoBtn_Click;
            // 
            // FiveBtn
            // 
            FiveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FiveBtn.Location = new Point(113, 167);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(94, 101);
            FiveBtn.TabIndex = 6;
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = true;
            FiveBtn.Click += FiveBtn_Click;
            // 
            // EightBtn
            // 
            EightBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EightBtn.Location = new Point(113, 70);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(94, 95);
            EightBtn.TabIndex = 5;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = true;
            EightBtn.Click += EightBtn_Click;
            // 
            // EqualBtn
            // 
            EqualBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EqualBtn.Location = new Point(213, 382);
            EqualBtn.Name = "EqualBtn";
            EqualBtn.Size = new Size(94, 98);
            EqualBtn.TabIndex = 12;
            EqualBtn.Text = "=";
            EqualBtn.UseVisualStyleBackColor = true;
            EqualBtn.Click += EqualBtn_Click;
            // 
            // ThreeBtn
            // 
            ThreeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ThreeBtn.Location = new Point(213, 274);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(94, 105);
            ThreeBtn.TabIndex = 11;
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = true;
            ThreeBtn.Click += ThreeBtn_Click;
            // 
            // SixBtn
            // 
            SixBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SixBtn.Location = new Point(213, 167);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(94, 101);
            SixBtn.TabIndex = 10;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = true;
            SixBtn.Click += SixBtn_Click;
            // 
            // NineBtn
            // 
            NineBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NineBtn.Location = new Point(213, 70);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(94, 95);
            NineBtn.TabIndex = 9;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = true;
            NineBtn.Click += NineBtn_Click;
            // 
            // MinusPlusBtn
            // 
            MinusPlusBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MinusPlusBtn.Location = new Point(355, 382);
            MinusPlusBtn.Name = "MinusPlusBtn";
            MinusPlusBtn.Size = new Size(94, 98);
            MinusPlusBtn.TabIndex = 16;
            MinusPlusBtn.Text = "-/+";
            MinusPlusBtn.UseVisualStyleBackColor = true;
            MinusPlusBtn.Click += MinusPlusBtn_Click;
            // 
            // DivideBtn
            // 
            DivideBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DivideBtn.Location = new Point(355, 274);
            DivideBtn.Name = "DivideBtn";
            DivideBtn.Size = new Size(94, 105);
            DivideBtn.TabIndex = 15;
            DivideBtn.Text = "/";
            DivideBtn.UseVisualStyleBackColor = true;
            DivideBtn.Click += DivideBtn_Click;
            // 
            // MinusBtn
            // 
            MinusBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MinusBtn.Location = new Point(355, 167);
            MinusBtn.Name = "MinusBtn";
            MinusBtn.Size = new Size(94, 101);
            MinusBtn.TabIndex = 14;
            MinusBtn.Text = "-";
            MinusBtn.UseVisualStyleBackColor = true;
            MinusBtn.Click += MinusBtn_Click;
            // 
            // ModuleBtn
            // 
            ModuleBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModuleBtn.Location = new Point(455, 382);
            ModuleBtn.Name = "ModuleBtn";
            ModuleBtn.Size = new Size(94, 98);
            ModuleBtn.TabIndex = 20;
            ModuleBtn.Text = "%";
            ModuleBtn.UseVisualStyleBackColor = true;
            ModuleBtn.Click += ModuleBtn_Click;
            // 
            // MultiplyBtn
            // 
            MultiplyBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MultiplyBtn.Location = new Point(455, 274);
            MultiplyBtn.Name = "MultiplyBtn";
            MultiplyBtn.Size = new Size(94, 105);
            MultiplyBtn.TabIndex = 19;
            MultiplyBtn.Text = "x";
            MultiplyBtn.UseVisualStyleBackColor = true;
            MultiplyBtn.Click += MultiplyBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.Location = new Point(455, 167);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(94, 101);
            AddBtn.TabIndex = 18;
            AddBtn.Text = "+";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClearBtn.Location = new Point(355, 70);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(194, 95);
            ClearBtn.TabIndex = 17;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // calculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 504);
            Controls.Add(ModuleBtn);
            Controls.Add(MultiplyBtn);
            Controls.Add(AddBtn);
            Controls.Add(ClearBtn);
            Controls.Add(MinusPlusBtn);
            Controls.Add(DivideBtn);
            Controls.Add(MinusBtn);
            Controls.Add(EqualBtn);
            Controls.Add(ThreeBtn);
            Controls.Add(SixBtn);
            Controls.Add(NineBtn);
            Controls.Add(DotBtn);
            Controls.Add(TwoBtn);
            Controls.Add(FiveBtn);
            Controls.Add(EightBtn);
            Controls.Add(ZeroBtn);
            Controls.Add(OneBtn);
            Controls.Add(FourBtn);
            Controls.Add(SevenBtn);
            Controls.Add(TxtBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox;
        private Button SevenBtn;
        private Button FourBtn;
        private Button OneBtn;
        private Button ZeroBtn;
        private Button DotBtn;
        private Button TwoBtn;
        private Button FiveBtn;
        private Button EightBtn;
        private Button EqualBtn;
        private Button ThreeBtn;
        private Button SixBtn;
        private Button NineBtn;
        private Button MinusPlusBtn;
        private Button DivideBtn;
        private Button MinusBtn;
        private Button ModuleBtn;
        private Button MultiplyBtn;
        private Button AddBtn;
        private Button ClearBtn;
    }
}