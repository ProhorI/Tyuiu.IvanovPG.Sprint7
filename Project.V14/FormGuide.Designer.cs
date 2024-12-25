namespace Project.V14
{
    partial class FormGuide
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            pictureBoxGuide_IPG = new PictureBox();
            groupBox1 = new GroupBox();
            textBoxGuide_IPG = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGuide_IPG).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxGuide_IPG
            // 
            pictureBoxGuide_IPG.BackgroundImage = (Image)resources.GetObject("pictureBoxGuide_IPG.BackgroundImage");
            pictureBoxGuide_IPG.Location = new Point(27, -1);
            pictureBoxGuide_IPG.Name = "pictureBoxGuide_IPG";
            pictureBoxGuide_IPG.Size = new Size(1093, 684);
            pictureBoxGuide_IPG.TabIndex = 0;
            pictureBoxGuide_IPG.TabStop = false;
            pictureBoxGuide_IPG.Click += pictureBoxGuide_IPG_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxGuide_IPG);
            groupBox1.Location = new Point(12, 689);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1566, 330);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Описание";
            // 
            // textBoxGuide_IPG
            // 
            textBoxGuide_IPG.BorderStyle = BorderStyle.None;
            textBoxGuide_IPG.Location = new Point(15, 38);
            textBoxGuide_IPG.Multiline = true;
            textBoxGuide_IPG.Name = "textBoxGuide_IPG";
            textBoxGuide_IPG.ReadOnly = true;
            textBoxGuide_IPG.Size = new Size(1454, 309);
            textBoxGuide_IPG.TabIndex = 0;
            textBoxGuide_IPG.Text = resources.GetString("textBoxGuide_IPG.Text");
            textBoxGuide_IPG.MouseEnter += textBoxGuide_IPG_Enter;
            // 
            // FormGuide
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1527, 1048);
            Controls.Add(groupBox1);
            Controls.Add(pictureBoxGuide_IPG);
            Name = "FormGuide";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Транспортные маршруты";
            ((System.ComponentModel.ISupportInitialize)pictureBoxGuide_IPG).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxGuide_IPG;
        private GroupBox groupBox1;
        private TextBox textBoxGuide_IPG;
    }
}