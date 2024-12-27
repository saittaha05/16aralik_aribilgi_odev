namespace odevuyg
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
            this.btnsprs = new System.Windows.Forms.Button();
            this.btnurun = new System.Windows.Forms.Button();
            this.btnorders = new System.Windows.Forms.Button();
            this.btnchai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsprs
            // 
            this.btnsprs.Location = new System.Drawing.Point(25, 116);
            this.btnsprs.Name = "btnsprs";
            this.btnsprs.Size = new System.Drawing.Size(181, 114);
            this.btnsprs.TabIndex = 0;
            this.btnsprs.Text = "AFKI SİPARİŞLER";
            this.btnsprs.UseVisualStyleBackColor = true;
            this.btnsprs.Click += new System.EventHandler(this.btnsprs_Click);
            // 
            // btnurun
            // 
            this.btnurun.Location = new System.Drawing.Point(212, 116);
            this.btnurun.Name = "btnurun";
            this.btnurun.Size = new System.Drawing.Size(181, 114);
            this.btnurun.TabIndex = 1;
            this.btnurun.Text = "Ürünler tablosunda en yüksek fiyata sahip ürünün id ve isim bilgisini bulalım";
            this.btnurun.UseVisualStyleBackColor = true;
            this.btnurun.Click += new System.EventHandler(this.btnurun_Click);
            // 
            // btnorders
            // 
            this.btnorders.Location = new System.Drawing.Point(399, 116);
            this.btnorders.Name = "btnorders";
            this.btnorders.Size = new System.Drawing.Size(181, 114);
            this.btnorders.TabIndex = 2;
            this.btnorders.Text = "Siparişler tablosunda 20 ile 50.siparişlerin bilgilerini bulalım,";
            this.btnorders.UseVisualStyleBackColor = true;
            this.btnorders.Click += new System.EventHandler(this.btnorders_Click);
            // 
            // btnchai
            // 
            this.btnchai.Location = new System.Drawing.Point(586, 116);
            this.btnchai.Name = "btnchai";
            this.btnchai.Size = new System.Drawing.Size(181, 114);
            this.btnchai.TabIndex = 3;
            this.btnchai.Text = "Chai adlı ürünün tüm sipariş detaylarını listeleyelim";
            this.btnchai.UseVisualStyleBackColor = true;
            this.btnchai.Click += new System.EventHandler(this.btnchai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnchai);
            this.Controls.Add(this.btnorders);
            this.Controls.Add(this.btnurun);
            this.Controls.Add(this.btnsprs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsprs;
        private System.Windows.Forms.Button btnurun;
        private System.Windows.Forms.Button btnorders;
        private System.Windows.Forms.Button btnchai;
    }
}

