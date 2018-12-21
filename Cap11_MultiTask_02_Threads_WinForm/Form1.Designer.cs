namespace Cap11_MultiTask_02_Threads_WinForm
{
    partial class Form1
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
            this.buttonDoAsyncStuff = new System.Windows.Forms.Button();
            this.buttonDoSyncStuff = new System.Windows.Forms.Button();
            this.buttonDoAsyncStuffRight = new System.Windows.Forms.Button();
            this.pictureBoxGif = new System.Windows.Forms.PictureBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.labelContador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif)).BeginInit();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDoAsyncStuff
            // 
            this.buttonDoAsyncStuff.Location = new System.Drawing.Point(108, 172);
            this.buttonDoAsyncStuff.Name = "buttonDoAsyncStuff";
            this.buttonDoAsyncStuff.Size = new System.Drawing.Size(204, 116);
            this.buttonDoAsyncStuff.TabIndex = 2;
            this.buttonDoAsyncStuff.Text = "Do Async Stuff";
            this.buttonDoAsyncStuff.UseVisualStyleBackColor = true;
            this.buttonDoAsyncStuff.Click += new System.EventHandler(this.buttonDoAsyncStuff_Click);
            // 
            // buttonDoSyncStuff
            // 
            this.buttonDoSyncStuff.Location = new System.Drawing.Point(108, 50);
            this.buttonDoSyncStuff.Name = "buttonDoSyncStuff";
            this.buttonDoSyncStuff.Size = new System.Drawing.Size(204, 116);
            this.buttonDoSyncStuff.TabIndex = 3;
            this.buttonDoSyncStuff.Text = "Do SyncStuff";
            this.buttonDoSyncStuff.UseVisualStyleBackColor = true;
            this.buttonDoSyncStuff.Click += new System.EventHandler(this.buttonDoSyncStuff_Click);
            // 
            // buttonDoAsyncStuffRight
            // 
            this.buttonDoAsyncStuffRight.Location = new System.Drawing.Point(108, 294);
            this.buttonDoAsyncStuffRight.Name = "buttonDoAsyncStuffRight";
            this.buttonDoAsyncStuffRight.Size = new System.Drawing.Size(204, 116);
            this.buttonDoAsyncStuffRight.TabIndex = 4;
            this.buttonDoAsyncStuffRight.Text = "Do Async Stuff Right";
            this.buttonDoAsyncStuffRight.UseVisualStyleBackColor = true;
            this.buttonDoAsyncStuffRight.Click += new System.EventHandler(this.buttonDoAsyncStuffRight_Click);
            // 
            // pictureBoxGif
            // 
            this.pictureBoxGif.Image = global::Cap11_MultiTask_02_Threads_WinForm.Properties.Resources.Gif;
            this.pictureBoxGif.Location = new System.Drawing.Point(460, 50);
            this.pictureBoxGif.Name = "pictureBoxGif";
            this.pictureBoxGif.Size = new System.Drawing.Size(294, 210);
            this.pictureBoxGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGif.TabIndex = 5;
            this.pictureBoxGif.TabStop = false;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.labelContador);
            this.groupBoxOutput.Location = new System.Drawing.Point(535, 310);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(190, 100);
            this.groupBoxOutput.TabIndex = 6;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "OutPut";
            // 
            // labelContador
            // 
            this.labelContador.AutoSize = true;
            this.labelContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContador.Location = new System.Drawing.Point(17, 26);
            this.labelContador.Name = "labelContador";
            this.labelContador.Size = new System.Drawing.Size(56, 61);
            this.labelContador.TabIndex = 0;
            this.labelContador.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.pictureBoxGif);
            this.Controls.Add(this.buttonDoAsyncStuffRight);
            this.Controls.Add(this.buttonDoSyncStuff);
            this.Controls.Add(this.buttonDoAsyncStuff);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif)).EndInit();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDoAsyncStuff;
        private System.Windows.Forms.Button buttonDoSyncStuff;
        private System.Windows.Forms.Button buttonDoAsyncStuffRight;
        private System.Windows.Forms.PictureBox pictureBoxGif;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Label labelContador;
    }
}

