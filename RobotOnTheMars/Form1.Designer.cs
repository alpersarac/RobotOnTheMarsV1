
namespace RobotOnTheMars
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_frwd = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.X_Lbl = new System.Windows.Forms.Label();
            this.y_Lbl = new System.Windows.Forms.Label();
            this.lbl_coor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 737);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_frwd
            // 
            this.btn_frwd.Location = new System.Drawing.Point(866, 424);
            this.btn_frwd.Name = "btn_frwd";
            this.btn_frwd.Size = new System.Drawing.Size(62, 59);
            this.btn_frwd.TabIndex = 2;
            this.btn_frwd.Text = "Forward";
            this.btn_frwd.UseVisualStyleBackColor = true;
            this.btn_frwd.Click += new System.EventHandler(this.btn_frwd_Click);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(822, 347);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(62, 59);
            this.btn_left.TabIndex = 3;
            this.btn_left.Text = "Left";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(912, 347);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(62, 59);
            this.btn_right.TabIndex = 4;
            this.btn_right.Text = "Right";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RobotOnTheMars.Properties.Resources.compass_PNG25581;
            this.pictureBox1.Location = new System.Drawing.Point(802, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // X_Lbl
            // 
            this.X_Lbl.AutoSize = true;
            this.X_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X_Lbl.Location = new System.Drawing.Point(851, 531);
            this.X_Lbl.Name = "X_Lbl";
            this.X_Lbl.Size = new System.Drawing.Size(46, 17);
            this.X_Lbl.TabIndex = 6;
            this.X_Lbl.Text = "label1";
            // 
            // y_Lbl
            // 
            this.y_Lbl.AutoSize = true;
            this.y_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y_Lbl.Location = new System.Drawing.Point(914, 531);
            this.y_Lbl.Name = "y_Lbl";
            this.y_Lbl.Size = new System.Drawing.Size(46, 17);
            this.y_Lbl.TabIndex = 7;
            this.y_Lbl.Text = "label2";
            // 
            // lbl_coor
            // 
            this.lbl_coor.AutoSize = true;
            this.lbl_coor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coor.Location = new System.Drawing.Point(863, 578);
            this.lbl_coor.Name = "lbl_coor";
            this.lbl_coor.Size = new System.Drawing.Size(84, 17);
            this.lbl_coor.TabIndex = 8;
            this.lbl_coor.Text = "Coordinates";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 761);
            this.Controls.Add(this.lbl_coor);
            this.Controls.Add(this.y_Lbl);
            this.Controls.Add(this.X_Lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_frwd);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_frwd;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label X_Lbl;
        private System.Windows.Forms.Label y_Lbl;
        private System.Windows.Forms.Label lbl_coor;
    }
}

