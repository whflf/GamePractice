namespace GameUI
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            Control = new Panel();
            Character = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            RightButton = new Button();
            UpButton = new Button();
            LeftButton = new Button();
            DownButton = new Button();
            Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Character).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // Control
            // 
            Control.BackColor = SystemColors.ActiveCaption;
            Control.Controls.Add(Character);
            Control.Dock = DockStyle.Fill;
            Control.Location = new Point(3, 3);
            Control.Name = "Control";
            Control.Size = new Size(794, 310);
            Control.TabIndex = 0;
            Control.Paint += ControlPaint;
            Control.Resize += ControlResize;
            // 
            // Character
            // 
            Character.Image = (Image)resources.GetObject("Character.Image");
            Character.Location = new Point(42, 42);
            Character.Name = "Character";
            Character.Size = new Size(83, 73);
            Character.SizeMode = PictureBoxSizeMode.Zoom;
            Character.TabIndex = 0;
            Character.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Control, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70.22222F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 29.7777786F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 319);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 128);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(RightButton, 1, 0);
            tableLayoutPanel2.Controls.Add(UpButton, 1, 1);
            tableLayoutPanel2.Controls.Add(LeftButton, 0, 0);
            tableLayoutPanel2.Controls.Add(DownButton, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(794, 128);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // RightButton
            // 
            RightButton.BackColor = SystemColors.Info;
            RightButton.Dock = DockStyle.Fill;
            RightButton.Location = new Point(400, 3);
            RightButton.Name = "RightButton";
            RightButton.Size = new Size(391, 58);
            RightButton.TabIndex = 0;
            RightButton.Text = "Right";
            RightButton.UseVisualStyleBackColor = false;
            RightButton.Click += RightButton_Click;
            RightButton.KeyDown += Game_KeyDown;
            RightButton.PreviewKeyDown += RightButton_PreviewKeyDown;
            // 
            // UpButton
            // 
            UpButton.BackColor = SystemColors.Info;
            UpButton.Dock = DockStyle.Fill;
            UpButton.Location = new Point(400, 67);
            UpButton.Name = "UpButton";
            UpButton.Size = new Size(391, 58);
            UpButton.TabIndex = 1;
            UpButton.Text = "Up";
            UpButton.UseVisualStyleBackColor = false;
            UpButton.Click += UpButton_Click;
            UpButton.PreviewKeyDown += UpButton_PreviewKeyDown;
            // 
            // LeftButton
            // 
            LeftButton.BackColor = SystemColors.Info;
            LeftButton.Dock = DockStyle.Fill;
            LeftButton.Location = new Point(3, 3);
            LeftButton.Name = "LeftButton";
            LeftButton.Size = new Size(391, 58);
            LeftButton.TabIndex = 2;
            LeftButton.Text = "Left";
            LeftButton.UseVisualStyleBackColor = false;
            LeftButton.Click += LeftButton_Click;
            LeftButton.PreviewKeyDown += LeftButton_PreviewKeyDown;
            // 
            // DownButton
            // 
            DownButton.BackColor = SystemColors.Info;
            DownButton.Dock = DockStyle.Fill;
            DownButton.Location = new Point(3, 67);
            DownButton.Name = "DownButton";
            DownButton.Size = new Size(391, 58);
            DownButton.TabIndex = 3;
            DownButton.Text = "Down";
            DownButton.UseVisualStyleBackColor = false;
            DownButton.Click += DownButton_Click;
            DownButton.PreviewKeyDown += DownButton_PreviewKeyDown;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Game";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Game_KeyDown;
            Control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Character).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Control;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button RightButton;
        private Button UpButton;
        private Button LeftButton;
        private Button DownButton;
        private PictureBox Character;
    }
}
