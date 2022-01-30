
namespace CocosTool
{
    partial class Form_ChangeAtlasUUID
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
            this.btn_change = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_atlas_2 = new System.Windows.Forms.TextBox();
            this.tb_atlas_1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tb_target = new System.Windows.Forms.TextBox();
            this.clb_list = new System.Windows.Forms.CheckedListBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btn_change
            // 
            this.btn_change.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_change.Location = new System.Drawing.Point(12, 485);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(576, 23);
            this.btn_change.TabIndex = 12;
            this.btn_change.Text = "아틀라스1의 UUID로 설정된 스프라이트들을 아틀라스2의 UUID로 변경";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "아틀라스 2";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "아틀라스 1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_atlas_2
            // 
            this.tb_atlas_2.AllowDrop = true;
            this.tb_atlas_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_atlas_2.Location = new System.Drawing.Point(118, 41);
            this.tb_atlas_2.Name = "tb_atlas_2";
            this.tb_atlas_2.ReadOnly = true;
            this.tb_atlas_2.Size = new System.Drawing.Size(470, 23);
            this.tb_atlas_2.TabIndex = 9;
            this.tb_atlas_2.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb_atlas_2_DragDrop);
            this.tb_atlas_2.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb_atlas_2_DragEnter);
            // 
            // tb_atlas_1
            // 
            this.tb_atlas_1.AllowDrop = true;
            this.tb_atlas_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_atlas_1.Location = new System.Drawing.Point(118, 12);
            this.tb_atlas_1.Name = "tb_atlas_1";
            this.tb_atlas_1.ReadOnly = true;
            this.tb_atlas_1.Size = new System.Drawing.Size(470, 23);
            this.tb_atlas_1.TabIndex = 8;
            this.tb_atlas_1.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb_atlas_1_DragDrop);
            this.tb_atlas_1.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb_atlas_1_DragEnter);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "대상폴더";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_target
            // 
            this.tb_target.AllowDrop = true;
            this.tb_target.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_target.Location = new System.Drawing.Point(118, 70);
            this.tb_target.Name = "tb_target";
            this.tb_target.ReadOnly = true;
            this.tb_target.Size = new System.Drawing.Size(470, 23);
            this.tb_target.TabIndex = 13;
            this.tb_target.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb_target_DragDrop);
            this.tb_target.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb_target_DragEnter);
            // 
            // clb_list
            // 
            this.clb_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clb_list.CheckOnClick = true;
            this.clb_list.FormattingEnabled = true;
            this.clb_list.Location = new System.Drawing.Point(12, 157);
            this.clb_list.Name = "clb_list";
            this.clb_list.Size = new System.Drawing.Size(576, 292);
            this.clb_list.TabIndex = 15;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Location = new System.Drawing.Point(12, 99);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(576, 23);
            this.btn_search.TabIndex = 16;
            this.btn_search.Text = "두 아틀라스의 같은 이름 검색의 스프라이트 검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(12, 128);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(200, 23);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "전체 헤제";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(218, 128);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(200, 23);
            this.btn_check.TabIndex = 18;
            this.btn_check.Text = "전체 체크";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 456);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(576, 23);
            this.progressBar1.TabIndex = 19;
            // 
            // Form_ChangeAtlasUUID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.clb_list);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tb_target);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb_atlas_2);
            this.Controls.Add(this.tb_atlas_1);
            this.Name = "Form_ChangeAtlasUUID";
            this.ShowIcon = false;
            this.Text = "스프라이트 선택 변경(전체)";
            this.Load += new System.EventHandler(this.Form_ChangeAtlasUUID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_atlas_2;
        private System.Windows.Forms.TextBox tb_atlas_1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tb_target;
        private System.Windows.Forms.CheckedListBox clb_list;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}