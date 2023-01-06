namespace TestCNN
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
            this.btn_proccess = new System.Windows.Forms.Button();
            this.ptbox_image = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rtbox_text = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_proccess
            // 
            this.btn_proccess.Location = new System.Drawing.Point(348, 374);
            this.btn_proccess.Name = "btn_proccess";
            this.btn_proccess.Size = new System.Drawing.Size(75, 23);
            this.btn_proccess.TabIndex = 0;
            this.btn_proccess.Text = "Proccess";
            this.btn_proccess.UseVisualStyleBackColor = true;
            this.btn_proccess.Click += new System.EventHandler(this.btn_proccess_Click);
            // 
            // ptbox_image
            // 
            this.ptbox_image.Location = new System.Drawing.Point(39, 82);
            this.ptbox_image.Name = "ptbox_image";
            this.ptbox_image.Size = new System.Drawing.Size(309, 262);
            this.ptbox_image.TabIndex = 1;
            this.ptbox_image.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rtbox_text
            // 
            this.rtbox_text.Location = new System.Drawing.Point(422, 82);
            this.rtbox_text.Name = "rtbox_text";
            this.rtbox_text.Size = new System.Drawing.Size(341, 262);
            this.rtbox_text.TabIndex = 2;
            this.rtbox_text.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbox_text);
            this.Controls.Add(this.ptbox_image);
            this.Controls.Add(this.btn_proccess);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbox_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_proccess;
        private PictureBox ptbox_image;
        private OpenFileDialog openFileDialog1;
        private RichTextBox rtbox_text;
    }
}