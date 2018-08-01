namespace AddRes
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.obl = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.rn = new System.Windows.Forms.Label();
            this.nas = new System.Windows.Forms.Label();
            this.yl = new System.Windows.Forms.Label();
            this.dom = new System.Windows.Forms.Label();
            this.kv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(776, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextUpdate += new System.EventHandler(this.comboBox1_TextUpdate);
            // 
            // obl
            // 
            this.obl.AutoSize = true;
            this.obl.Location = new System.Drawing.Point(12, 58);
            this.obl.Name = "obl";
            this.obl.Size = new System.Drawing.Size(35, 13);
            this.obl.TabIndex = 1;
            this.obl.Text = "label1";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(746, 405);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(52, 43);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // rn
            // 
            this.rn.AutoSize = true;
            this.rn.Location = new System.Drawing.Point(12, 96);
            this.rn.Name = "rn";
            this.rn.Size = new System.Drawing.Size(35, 13);
            this.rn.TabIndex = 3;
            this.rn.Text = "label2";
            // 
            // nas
            // 
            this.nas.AutoSize = true;
            this.nas.Location = new System.Drawing.Point(12, 127);
            this.nas.Name = "nas";
            this.nas.Size = new System.Drawing.Size(35, 13);
            this.nas.TabIndex = 4;
            this.nas.Text = "label3";
            // 
            // yl
            // 
            this.yl.AutoSize = true;
            this.yl.Location = new System.Drawing.Point(12, 155);
            this.yl.Name = "yl";
            this.yl.Size = new System.Drawing.Size(35, 13);
            this.yl.TabIndex = 5;
            this.yl.Text = "label4";
            // 
            // dom
            // 
            this.dom.AutoSize = true;
            this.dom.Location = new System.Drawing.Point(9, 180);
            this.dom.Name = "dom";
            this.dom.Size = new System.Drawing.Size(35, 13);
            this.dom.TabIndex = 6;
            this.dom.Text = "label5";
            // 
            // kv
            // 
            this.kv.AutoSize = true;
            this.kv.Location = new System.Drawing.Point(9, 206);
            this.kv.Name = "kv";
            this.kv.Size = new System.Drawing.Size(35, 13);
            this.kv.TabIndex = 7;
            this.kv.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kv);
            this.Controls.Add(this.dom);
            this.Controls.Add(this.yl);
            this.Controls.Add(this.nas);
            this.Controls.Add(this.rn);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.obl);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label obl;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label rn;
        private System.Windows.Forms.Label nas;
        private System.Windows.Forms.Label yl;
        private System.Windows.Forms.Label dom;
        private System.Windows.Forms.Label kv;
    }
}

