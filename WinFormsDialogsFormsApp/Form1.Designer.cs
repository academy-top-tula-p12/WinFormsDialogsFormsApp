namespace WinFormsDialogsFormsApp
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
            btnShow = new Button();
            lblResult = new Label();
            pictBoxLoad = new PictureBox();
            btnLoadImage = new Button();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictBoxLoad).BeginInit();
            SuspendLayout();
            // 
            // btnShow
            // 
            btnShow.Font = new Font("Segoe UI", 16F);
            btnShow.Location = new Point(25, 92);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(189, 88);
            btnShow.TabIndex = 0;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 20F);
            lblResult.Location = new Point(25, 35);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(90, 37);
            lblResult.TabIndex = 1;
            lblResult.Text = "label1";
            // 
            // pictBoxLoad
            // 
            pictBoxLoad.Location = new Point(595, 12);
            pictBoxLoad.Name = "pictBoxLoad";
            pictBoxLoad.Size = new Size(193, 219);
            pictBoxLoad.TabIndex = 2;
            pictBoxLoad.TabStop = false;
            // 
            // btnLoadImage
            // 
            btnLoadImage.Font = new Font("Segoe UI", 16F);
            btnLoadImage.Location = new Point(595, 249);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(193, 55);
            btnLoadImage.TabIndex = 3;
            btnLoadImage.Text = "load image";
            btnLoadImage.UseVisualStyleBackColor = true;
            btnLoadImage.Click += btnLoadImage_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoadImage);
            Controls.Add(pictBoxLoad);
            Controls.Add(lblResult);
            Controls.Add(btnShow);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictBoxLoad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShow;
        private Label lblResult;
        private PictureBox pictBoxLoad;
        private Button btnLoadImage;
        private OpenFileDialog openFileDialog;
    }
}
