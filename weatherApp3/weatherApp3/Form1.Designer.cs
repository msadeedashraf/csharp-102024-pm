namespace weatherApp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.lbl_conditions = new System.Windows.Forms.Label();
            this.lbl_details = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_wind_speed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_pressure = new System.Windows.Forms.Label();
            this.lbl_sunset = new System.Windows.Forms.Label();
            this.lbl_sunrise = new System.Windows.Forms.Label();
            this.pic_temp = new System.Windows.Forms.PictureBox();
            this.lbl_temp = new System.Windows.Forms.Label();
            this.lbl_o = new System.Windows.Forms.Label();
            this.lbl_c = new System.Windows.Forms.Label();
            this.lbl_err = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_temp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "City: ";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(1509, 143);
            this.btn_search.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(301, 79);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_city
            // 
            this.txt_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_city.Location = new System.Drawing.Point(371, 148);
            this.txt_city.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_city.Multiline = true;
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(1087, 68);
            this.txt_city.TabIndex = 2;
            // 
            // lbl_conditions
            // 
            this.lbl_conditions.AutoSize = true;
            this.lbl_conditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conditions.Location = new System.Drawing.Point(107, 649);
            this.lbl_conditions.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_conditions.Name = "lbl_conditions";
            this.lbl_conditions.Size = new System.Drawing.Size(284, 63);
            this.lbl_conditions.TabIndex = 3;
            this.lbl_conditions.Text = "Conditions";
            // 
            // lbl_details
            // 
            this.lbl_details.AutoSize = true;
            this.lbl_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_details.Location = new System.Drawing.Point(107, 787);
            this.lbl_details.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_details.Name = "lbl_details";
            this.lbl_details.Size = new System.Drawing.Size(194, 63);
            this.lbl_details.TabIndex = 4;
            this.lbl_details.Text = "Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(608, 787);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 63);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pressure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 649);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 63);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wind Speed";
            // 
            // lbl_wind_speed
            // 
            this.lbl_wind_speed.AutoSize = true;
            this.lbl_wind_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wind_speed.Location = new System.Drawing.Point(1008, 649);
            this.lbl_wind_speed.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_wind_speed.Name = "lbl_wind_speed";
            this.lbl_wind_speed.Size = new System.Drawing.Size(117, 63);
            this.lbl_wind_speed.TabIndex = 7;
            this.lbl_wind_speed.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1368, 787);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 63);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sunset";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1368, 649);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 63);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sunrise";
            // 
            // lbl_pressure
            // 
            this.lbl_pressure.AutoSize = true;
            this.lbl_pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pressure.Location = new System.Drawing.Point(1008, 787);
            this.lbl_pressure.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_pressure.Name = "lbl_pressure";
            this.lbl_pressure.Size = new System.Drawing.Size(117, 63);
            this.lbl_pressure.TabIndex = 13;
            this.lbl_pressure.Text = "N/A";
            // 
            // lbl_sunset
            // 
            this.lbl_sunset.AutoSize = true;
            this.lbl_sunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sunset.Location = new System.Drawing.Point(1672, 787);
            this.lbl_sunset.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_sunset.Name = "lbl_sunset";
            this.lbl_sunset.Size = new System.Drawing.Size(117, 63);
            this.lbl_sunset.TabIndex = 15;
            this.lbl_sunset.Text = "N/A";
            // 
            // lbl_sunrise
            // 
            this.lbl_sunrise.AutoSize = true;
            this.lbl_sunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sunrise.Location = new System.Drawing.Point(1672, 649);
            this.lbl_sunrise.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_sunrise.Name = "lbl_sunrise";
            this.lbl_sunrise.Size = new System.Drawing.Size(117, 63);
            this.lbl_sunrise.TabIndex = 14;
            this.lbl_sunrise.Text = "N/A";
            // 
            // pic_temp
            // 
            this.pic_temp.Location = new System.Drawing.Point(619, 318);
            this.pic_temp.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pic_temp.Name = "pic_temp";
            this.pic_temp.Size = new System.Drawing.Size(194, 158);
            this.pic_temp.TabIndex = 16;
            this.pic_temp.TabStop = false;
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp.Location = new System.Drawing.Point(875, 341);
            this.lbl_temp.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(124, 135);
            this.lbl_temp.TabIndex = 17;
            this.lbl_temp.Text = "0";
            // 
            // lbl_o
            // 
            this.lbl_o.AutoSize = true;
            this.lbl_o.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_o.Location = new System.Drawing.Point(1132, 353);
            this.lbl_o.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_o.Name = "lbl_o";
            this.lbl_o.Size = new System.Drawing.Size(33, 36);
            this.lbl_o.TabIndex = 18;
            this.lbl_o.Text = "o";
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_c.Location = new System.Drawing.Point(1156, 389);
            this.lbl_c.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(81, 76);
            this.lbl_c.TabIndex = 19;
            this.lbl_c.Text = "C";
            // 
            // lbl_err
            // 
            this.lbl_err.AutoSize = true;
            this.lbl_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_err.ForeColor = System.Drawing.Color.Red;
            this.lbl_err.Location = new System.Drawing.Point(776, 954);
            this.lbl_err.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_err.Name = "lbl_err";
            this.lbl_err.Size = new System.Drawing.Size(374, 63);
            this.lbl_err.TabIndex = 20;
            this.lbl_err.Text = "error message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.Controls.Add(this.lbl_err);
            this.Controls.Add(this.lbl_c);
            this.Controls.Add(this.lbl_o);
            this.Controls.Add(this.lbl_temp);
            this.Controls.Add(this.pic_temp);
            this.Controls.Add(this.lbl_sunset);
            this.Controls.Add(this.lbl_sunrise);
            this.Controls.Add(this.lbl_pressure);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_wind_speed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_details);
            this.Controls.Add(this.lbl_conditions);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_temp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label lbl_conditions;
        private System.Windows.Forms.Label lbl_details;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_wind_speed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_pressure;
        private System.Windows.Forms.Label lbl_sunset;
        private System.Windows.Forms.Label lbl_sunrise;
        private System.Windows.Forms.PictureBox pic_temp;
        private System.Windows.Forms.Label lbl_temp;
        private System.Windows.Forms.Label lbl_o;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.Label lbl_err;
    }
}

