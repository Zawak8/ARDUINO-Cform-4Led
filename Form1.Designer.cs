namespace Arduino_LedTest1
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
            this.btn_red = new System.Windows.Forms.Button();
            this.btn_blue = new System.Windows.Forms.Button();
            this.btn_green = new System.Windows.Forms.Button();
            this.btn_yellow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_red
            // 
            this.btn_red.BackColor = System.Drawing.Color.Red;
            this.btn_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_red.Location = new System.Drawing.Point(12, 12);
            this.btn_red.Name = "btn_red";
            this.btn_red.Size = new System.Drawing.Size(222, 100);
            this.btn_red.TabIndex = 0;
            this.btn_red.Text = "RED";
            this.btn_red.UseVisualStyleBackColor = false;
            this.btn_red.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // btn_blue
            // 
            this.btn_blue.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_blue.Location = new System.Drawing.Point(240, 12);
            this.btn_blue.Name = "btn_blue";
            this.btn_blue.Size = new System.Drawing.Size(214, 100);
            this.btn_blue.TabIndex = 1;
            this.btn_blue.Text = "BLUE";
            this.btn_blue.UseVisualStyleBackColor = false;
            this.btn_blue.Click += new System.EventHandler(this.btn_blue_Click);
            // 
            // btn_green
            // 
            this.btn_green.BackColor = System.Drawing.Color.Lime;
            this.btn_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_green.Location = new System.Drawing.Point(240, 118);
            this.btn_green.Name = "btn_green";
            this.btn_green.Size = new System.Drawing.Size(214, 100);
            this.btn_green.TabIndex = 3;
            this.btn_green.Text = "GREEN";
            this.btn_green.UseVisualStyleBackColor = false;
            this.btn_green.Click += new System.EventHandler(this.btn_green_Click);
            // 
            // btn_yellow
            // 
            this.btn_yellow.BackColor = System.Drawing.Color.Yellow;
            this.btn_yellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_yellow.Location = new System.Drawing.Point(12, 118);
            this.btn_yellow.Name = "btn_yellow";
            this.btn_yellow.Size = new System.Drawing.Size(222, 100);
            this.btn_yellow.TabIndex = 2;
            this.btn_yellow.Text = "YELLOW";
            this.btn_yellow.UseVisualStyleBackColor = false;
            this.btn_yellow.Click += new System.EventHandler(this.btn_yellow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 232);
            this.Controls.Add(this.btn_green);
            this.Controls.Add(this.btn_yellow);
            this.Controls.Add(this.btn_blue);
            this.Controls.Add(this.btn_red);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_red;
        private System.Windows.Forms.Button btn_blue;
        private System.Windows.Forms.Button btn_green;
        private System.Windows.Forms.Button btn_yellow;
    }
}

