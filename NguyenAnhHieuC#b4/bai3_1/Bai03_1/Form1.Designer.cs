using System;

namespace Bai03_1
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
            this.lblsoa = new System.Windows.Forms.Label();
            this.lblsob = new System.Windows.Forms.Label();
            this.txtsoA = new System.Windows.Forms.TextBox();
            this.txtsoB = new System.Windows.Forms.TextBox();
            this.lblketqua = new System.Windows.Forms.Label();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.btncong = new System.Windows.Forms.Button();
            this.btntru = new System.Windows.Forms.Button();
            this.btnnhan = new System.Windows.Forms.Button();
            this.btnchia = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(296, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH TÍNH TOÁN 2 SỐ";
            // 
            // lblsoa
            // 
            this.lblsoa.AutoSize = true;
            this.lblsoa.Location = new System.Drawing.Point(35, 67);
            this.lblsoa.Name = "lblsoa";
            this.lblsoa.Size = new System.Drawing.Size(32, 13);
            this.lblsoa.TabIndex = 1;
            this.lblsoa.Text = "SỐ A";
            // 
            // lblsob
            // 
            this.lblsob.AutoSize = true;
            this.lblsob.Location = new System.Drawing.Point(35, 102);
            this.lblsob.Name = "lblsob";
            this.lblsob.Size = new System.Drawing.Size(32, 13);
            this.lblsob.TabIndex = 2;
            this.lblsob.Text = "SỐ B";
            // 
            // txtsoA
            // 
            this.txtsoA.Location = new System.Drawing.Point(92, 60);
            this.txtsoA.Name = "txtsoA";
            this.txtsoA.Size = new System.Drawing.Size(188, 20);
            this.txtsoA.TabIndex = 3;
            // 
            // txtsoB
            // 
            this.txtsoB.Location = new System.Drawing.Point(92, 99);
            this.txtsoB.Name = "txtsoB";
            this.txtsoB.Size = new System.Drawing.Size(188, 20);
            this.txtsoB.TabIndex = 4;
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Location = new System.Drawing.Point(35, 308);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(54, 13);
            this.lblketqua.TabIndex = 5;
            this.lblketqua.Text = "KẾT QUẢ";
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(92, 301);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(188, 20);
            this.txtketqua.TabIndex = 6;
            this.txtketqua.TextChanged += new System.EventHandler(this.txtketqua_TextChanged);
            // 
            // btncong
            // 
            this.btncong.Location = new System.Drawing.Point(92, 183);
            this.btncong.Name = "btncong";
            this.btncong.Size = new System.Drawing.Size(66, 33);
            this.btncong.TabIndex = 7;
            this.btncong.Text = "CỘNG";
            this.btncong.UseVisualStyleBackColor = true;
            this.btncong.Click += new System.EventHandler(this.btncong_Click);
            // 
            // btntru
            // 
            this.btntru.Location = new System.Drawing.Point(214, 183);
            this.btntru.Name = "btntru";
            this.btntru.Size = new System.Drawing.Size(66, 33);
            this.btntru.TabIndex = 8;
            this.btntru.Text = "TRỪ";
            this.btntru.UseVisualStyleBackColor = true;
            this.btntru.Click += new System.EventHandler(this.btntru_Click);
            // 
            // btnnhan
            // 
            this.btnnhan.Location = new System.Drawing.Point(332, 183);
            this.btnnhan.Name = "btnnhan";
            this.btnnhan.Size = new System.Drawing.Size(66, 33);
            this.btnnhan.TabIndex = 9;
            this.btnnhan.Text = "NHÂN";
            this.btnnhan.UseVisualStyleBackColor = true;
            this.btnnhan.Click += new System.EventHandler(this.btnchia_Click);
            // 
            // btnchia
            // 
            this.btnchia.Location = new System.Drawing.Point(454, 183);
            this.btnchia.Name = "btnchia";
            this.btnchia.Size = new System.Drawing.Size(66, 33);
            this.btnchia.TabIndex = 10;
            this.btnchia.Text = "CHIA";
            this.btnchia.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(584, 183);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(66, 33);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "THOÁT";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnchia);
            this.Controls.Add(this.btnnhan);
            this.Controls.Add(this.btntru);
            this.Controls.Add(this.btncong);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.txtsoB);
            this.Controls.Add(this.txtsoA);
            this.Controls.Add(this.lblsob);
            this.Controls.Add(this.lblsoa);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsoa;
        private System.Windows.Forms.Label lblsob;
        private System.Windows.Forms.TextBox txtsoA;
        private System.Windows.Forms.TextBox txtsoB;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Button btncong;
        private System.Windows.Forms.Button btntru;
        private System.Windows.Forms.Button btnnhan;
        private System.Windows.Forms.Button btnchia;
        private System.Windows.Forms.Button btnthoat;
        private EventHandler label1_Click;
    }
}

