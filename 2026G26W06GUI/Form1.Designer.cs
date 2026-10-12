namespace _2026G26W06GUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnDeal = new Button();
            Card1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Card1).BeginInit();
            SuspendLayout();
            // 
            // btnDeal
            // 
            btnDeal.Location = new Point(155, 296);
            btnDeal.Name = "btnDeal";
            btnDeal.Size = new Size(94, 29);
            btnDeal.TabIndex = 0;
            btnDeal.Text = "카드분배";
            btnDeal.UseVisualStyleBackColor = true;
            btnDeal.Click += OnDeal;
            // 
            // Card1
            // 
            Card1.Image = Properties.Resources._10_of_diamonds;
            Card1.Location = new Point(108, 2);
            Card1.Name = "Card1";
            Card1.Size = new Size(224, 278);
            Card1.SizeMode = PictureBoxSizeMode.Zoom;
            Card1.TabIndex = 1;
            Card1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 324);
            Controls.Add(Card1);
            Controls.Add(btnDeal);
            Name = "Form1";
            Text = "카드딜러";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Card1).EndInit();
            ResumeLayout(false);
        }

        private Button btnDeal;
        private PictureBox Card1;
    }
}