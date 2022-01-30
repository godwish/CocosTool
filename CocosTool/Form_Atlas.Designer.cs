
namespace CocosTool
{
    partial class Form_Atlas
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tb_target_folder = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_result = new System.Windows.Forms.ListBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.pb_protage = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_atlas = new System.Windows.Forms.TextBox();
            this.lb_search = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(325, 23);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "검색할 폴더(asset)";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_target_folder
            // 
            this.tb_target_folder.AllowDrop = true;
            this.tb_target_folder.Location = new System.Drawing.Point(12, 41);
            this.tb_target_folder.Name = "tb_target_folder";
            this.tb_target_folder.ReadOnly = true;
            this.tb_target_folder.Size = new System.Drawing.Size(325, 23);
            this.tb_target_folder.TabIndex = 12;
            this.tb_target_folder.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb_target_folder_DragDrop);
            this.tb_target_folder.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb_target_folder_DragEnter);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(343, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(444, 23);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "의존성 있는 파일들";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_result
            // 
            this.lb_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_result.FormattingEnabled = true;
            this.lb_result.ItemHeight = 15;
            this.lb_result.Location = new System.Drawing.Point(343, 41);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(444, 469);
            this.lb_result.TabIndex = 14;
            this.lb_result.DoubleClick += new System.EventHandler(this.lb_result_DoubleClick);
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start.Location = new System.Drawing.Point(12, 551);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(775, 23);
            this.btn_start.TabIndex = 17;
            this.btn_start.Text = "검색 시작";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_reset.Location = new System.Drawing.Point(12, 522);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(159, 23);
            this.btn_reset.TabIndex = 16;
            this.btn_reset.Text = "검색 초기화";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // pb_protage
            // 
            this.pb_protage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_protage.Location = new System.Drawing.Point(177, 522);
            this.pb_protage.Name = "pb_protage";
            this.pb_protage.Size = new System.Drawing.Size(610, 23);
            this.pb_protage.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(325, 23);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "아틀라스";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_atlas
            // 
            this.tb_atlas.AllowDrop = true;
            this.tb_atlas.Location = new System.Drawing.Point(12, 99);
            this.tb_atlas.Name = "tb_atlas";
            this.tb_atlas.ReadOnly = true;
            this.tb_atlas.Size = new System.Drawing.Size(325, 23);
            this.tb_atlas.TabIndex = 19;
            this.tb_atlas.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb_atlas_DragDrop);
            this.tb_atlas.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb_atlas_DragEnter);
            this.tb_atlas.DragLeave += new System.EventHandler(this.tb_atlas_DragLeave);
            // 
            // lb_search
            // 
            this.lb_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_search.FormattingEnabled = true;
            this.lb_search.ItemHeight = 15;
            this.lb_search.Location = new System.Drawing.Point(12, 128);
            this.lb_search.Name = "lb_search";
            this.lb_search.Size = new System.Drawing.Size(325, 379);
            this.lb_search.TabIndex = 20;
            this.lb_search.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb_target_folder_DragDrop);
            // 
            // Form_Atlas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 586);
            this.Controls.Add(this.lb_search);
            this.Controls.Add(this.tb_atlas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.pb_protage);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tb_target_folder);
            this.Controls.Add(this.textBox4);
            this.Name = "Form_Atlas";
            this.ShowIcon = false;
            this.Text = "아틀라스 속 리소스 검색";
            this.Load += new System.EventHandler(this.Form_Atlas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tb_target_folder;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox lb_result;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.ProgressBar pb_protage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_atlas;
        private System.Windows.Forms.ListBox lb_search;
    }
}