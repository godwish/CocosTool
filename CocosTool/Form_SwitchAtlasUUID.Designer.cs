
namespace CocosTool
{
    partial class Form_SwitchAtlasUUID
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
            this.tb_atlas_1 = new System.Windows.Forms.TextBox();
            this.tb_atlas_2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_switch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_atlas_1
            // 
            this.tb_atlas_1.AllowDrop = true;
            this.tb_atlas_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_atlas_1.Location = new System.Drawing.Point(118, 12);
            this.tb_atlas_1.Name = "tb_atlas_1";
            this.tb_atlas_1.ReadOnly = true;
            this.tb_atlas_1.Size = new System.Drawing.Size(454, 23);
            this.tb_atlas_1.TabIndex = 0;
            this.tb_atlas_1.TextChanged += new System.EventHandler(this.tb_atlas_1_TextChanged);
            this.tb_atlas_1.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb_atlas_1_DragDrop);
            this.tb_atlas_1.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb_atlas_1_DragEnter);
            // 
            // tb_atlas_2
            // 
            this.tb_atlas_2.AllowDrop = true;
            this.tb_atlas_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_atlas_2.Location = new System.Drawing.Point(118, 41);
            this.tb_atlas_2.Name = "tb_atlas_2";
            this.tb_atlas_2.ReadOnly = true;
            this.tb_atlas_2.Size = new System.Drawing.Size(454, 23);
            this.tb_atlas_2.TabIndex = 1;
            this.tb_atlas_2.TextChanged += new System.EventHandler(this.tb_atlas_2_TextChanged);
            this.tb_atlas_2.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb_atlas_2_DragDrop);
            this.tb_atlas_2.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb_atlas_2_DragEnter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "아틀라스 1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "아틀라스 2";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_switch
            // 
            this.btn_switch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_switch.Location = new System.Drawing.Point(12, 70);
            this.btn_switch.Name = "btn_switch";
            this.btn_switch.Size = new System.Drawing.Size(560, 23);
            this.btn_switch.TabIndex = 7;
            this.btn_switch.Text = "아틀라스간 UUID 스위치";
            this.btn_switch.UseVisualStyleBackColor = true;
            this.btn_switch.Click += new System.EventHandler(this.btn_switch_Click);
            // 
            // Form_SwitchAtlasUUID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 101);
            this.Controls.Add(this.btn_switch);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb_atlas_2);
            this.Controls.Add(this.tb_atlas_1);
            this.Name = "Form_SwitchAtlasUUID";
            this.ShowIcon = false;
            this.Text = "아틀라스간 UUID 교체";
            this.Load += new System.EventHandler(this.Form_SwitchAtlasUUID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_atlas_1;
        private System.Windows.Forms.TextBox tb_atlas_2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_switch;
    }
}