namespace AutoClicker.WinForm
{
    partial class MainForm
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAutoClickerOn = new Button();
            buttonClickTester = new Button();
            textBoxClickTester = new TextBox();
            buttonAutoClickerOff = new Button();
            trackBarClickSpeed = new TrackBar();
            labelClickSpeed = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarClickSpeed).BeginInit();
            SuspendLayout();
            // 
            // buttonAutoClickerOn
            // 
            buttonAutoClickerOn.Location = new Point(59, 86);
            buttonAutoClickerOn.Name = "buttonAutoClickerOn";
            buttonAutoClickerOn.Size = new Size(154, 47);
            buttonAutoClickerOn.TabIndex = 0;
            buttonAutoClickerOn.Text = "AutoClicker ON (F1)";
            buttonAutoClickerOn.UseVisualStyleBackColor = true;
            buttonAutoClickerOn.Click += buttonAutoClickerOn_Click;
            // 
            // buttonClickTester
            // 
            buttonClickTester.Location = new Point(59, 251);
            buttonClickTester.Name = "buttonClickTester";
            buttonClickTester.Size = new Size(154, 47);
            buttonClickTester.TabIndex = 1;
            buttonClickTester.Text = "Click Here!";
            buttonClickTester.UseVisualStyleBackColor = true;
            buttonClickTester.Click += buttonClickTester_Click;
            // 
            // textBoxClickTester
            // 
            textBoxClickTester.Location = new Point(59, 304);
            textBoxClickTester.Name = "textBoxClickTester";
            textBoxClickTester.Size = new Size(154, 27);
            textBoxClickTester.TabIndex = 2;
            textBoxClickTester.Text = "Number of clicks";
            // 
            // buttonAutoClickerOff
            // 
            buttonAutoClickerOff.Location = new Point(59, 139);
            buttonAutoClickerOff.Name = "buttonAutoClickerOff";
            buttonAutoClickerOff.Size = new Size(154, 47);
            buttonAutoClickerOff.TabIndex = 3;
            buttonAutoClickerOff.Text = "AutoClicker OFF (F2)";
            buttonAutoClickerOff.UseVisualStyleBackColor = true;
            buttonAutoClickerOff.Click += buttonAutoClickerOff_Click;
            // 
            // trackBarClickSpeed
            // 
            trackBarClickSpeed.Location = new Point(361, 188);
            trackBarClickSpeed.Maximum = 100;
            trackBarClickSpeed.Minimum = 1;
            trackBarClickSpeed.Name = "trackBarClickSpeed";
            trackBarClickSpeed.Size = new Size(345, 56);
            trackBarClickSpeed.TabIndex = 4;
            trackBarClickSpeed.TickFrequency = 5;
            trackBarClickSpeed.Value = 1;
            // 
            // labelClickSpeed
            // 
            labelClickSpeed.AutoSize = true;
            labelClickSpeed.Location = new Point(492, 165);
            labelClickSpeed.Name = "labelClickSpeed";
            labelClickSpeed.Size = new Size(84, 20);
            labelClickSpeed.TabIndex = 5;
            labelClickSpeed.Text = "Click speed";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelClickSpeed);
            Controls.Add(trackBarClickSpeed);
            Controls.Add(buttonAutoClickerOff);
            Controls.Add(textBoxClickTester);
            Controls.Add(buttonClickTester);
            Controls.Add(buttonAutoClickerOn);
            Name = "MainForm";
            Text = "AutoClicker by Jakob Kvejborg";
            ((System.ComponentModel.ISupportInitialize)trackBarClickSpeed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAutoClickerOn;
        private Button buttonClickTester;
        private TextBox textBoxClickTester;
        private Button buttonAutoClickerOff;
        private TrackBar trackBarClickSpeed;
        private Label labelClickSpeed;
    }
}
