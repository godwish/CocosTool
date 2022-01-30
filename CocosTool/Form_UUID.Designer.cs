
namespace CocosTool
{
    partial class Form_UUID
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.ListBox();
            this.tb_target_folder = new System.Windows.Forms.TextBox();
            this.pb_protage = new System.Windows.Forms.ProgressBar();
            this.tb_uuid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 70);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(325, 23);
            this.textBox5.TabIndex = 21;
            this.textBox5.Text = "UUID 직접입력";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(325, 23);
            this.textBox4.TabIndex = 20;
            this.textBox4.Text = "검색할 폴더(asset)";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(343, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(318, 23);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "의존성 있는 파일들";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start.Location = new System.Drawing.Point(12, 527);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(649, 23);
            this.btn_start.TabIndex = 18;
            this.btn_start.Text = "검색 시작";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_reset.Location = new System.Drawing.Point(12, 498);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(159, 23);
            this.btn_reset.TabIndex = 17;
            this.btn_reset.Text = "검색 초기화";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
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
            this.lb_result.Size = new System.Drawing.Size(318, 439);
            this.lb_result.TabIndex = 16;
            this.lb_result.DoubleClick += new System.EventHandler(this.lb_result_DoubleClick);
            // 
            // tb_target_folder
            // 
            this.tb_target_folder.AllowDrop = true;
            this.tb_target_folder.Location = new System.Drawing.Point(12, 41);
            this.tb_target_folder.Name = "tb_target_folder";
            this.tb_target_folder.ReadOnly = true;
            this.tb_target_folder.Size = new System.Drawing.Size(325, 23);
            this.tb_target_folder.TabIndex = 14;
            this.tb_target_folder.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb_target_folder_DragDrop);
            this.tb_target_folder.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb_target_folder_DragEnter);
            // 
            // pb_protage
            // 
            this.pb_protage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_protage.Location = new System.Drawing.Point(177, 498);
            this.pb_protage.Name = "pb_protage";
            this.pb_protage.Size = new System.Drawing.Size(484, 23);
            this.pb_protage.TabIndex = 13;
            // 
            // tb_uuid
            // 
            this.tb_uuid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_uuid.Location = new System.Drawing.Point(12, 99);
            this.tb_uuid.Multiline = true;
            this.tb_uuid.Name = "tb_uuid";
            this.tb_uuid.Size = new System.Drawing.Size(324, 381);
            this.tb_uuid.TabIndex = 23;
            // 
            // Form_UUID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 562);
            this.Controls.Add(this.tb_uuid);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.tb_target_folder);
            this.Controls.Add(this.pb_protage);
            this.Name = "Form_UUID";
            this.ShowIcon = false;
            this.Text = "UUID로 검색";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.ListBox lb_result;
        private System.Windows.Forms.TextBox tb_target_folder;
        private System.Windows.Forms.ProgressBar pb_protage;
        private System.Windows.Forms.TextBox tb_uuid;
    }
}