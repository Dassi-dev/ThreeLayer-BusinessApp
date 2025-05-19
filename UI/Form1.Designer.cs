namespace UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            managementButton = new Button();
            cashierButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(507, 168);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(515, 65);
            label1.TabIndex = 0;
            label1.Text = "Welcome to our store";
            // 
            // managementButton
            // 
            managementButton.BackColor = Color.SeaShell;
            managementButton.Font = new Font("Segoe UI", 11.25F);
            managementButton.Location = new Point(564, 331);
            managementButton.Margin = new Padding(6, 6, 6, 6);
            managementButton.Name = "managementButton";
            managementButton.Size = new Size(422, 118);
            managementButton.TabIndex = 1;
            managementButton.Text = "management";
            managementButton.UseVisualStyleBackColor = false;
            managementButton.Click += managementButton_Click;
            // 
            // cashierButton
            // 
            cashierButton.BackColor = Color.SeaShell;
            cashierButton.Font = new Font("Segoe UI", 11.25F);
            cashierButton.Location = new Point(564, 542);
            cashierButton.Margin = new Padding(6, 6, 6, 6);
            cashierButton.Name = "cashierButton";
            cashierButton.Size = new Size(414, 118);
            cashierButton.TabIndex = 2;
            cashierButton.Text = "cashier";
            cashierButton.UseVisualStyleBackColor = false;
            cashierButton.Click += cashierButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1485, 960);
            Controls.Add(cashierButton);
            Controls.Add(managementButton);
            Controls.Add(label1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button managementButton;
        private Button cashierButton;
    }
}
