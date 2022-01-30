
namespace CocosTool
{
    partial class Form_Menu
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
            this.btn_search_multy = new System.Windows.Forms.Button();
            this.btn_atlas = new System.Windows.Forms.Button();
            this.btn_text = new System.Windows.Forms.Button();
            this.btn_find_p3d = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_switch_atlas_uuid = new System.Windows.Forms.Button();
            this.btn_change_sprites = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_change_sprite = new System.Windows.Forms.Button();
            this.btn_change_sprite_prefab = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_search_multy
            // 
            this.btn_search_multy.Location = new System.Drawing.Point(6, 22);
            this.btn_search_multy.Name = "btn_search_multy";
            this.btn_search_multy.Size = new System.Drawing.Size(180, 23);
            this.btn_search_multy.TabIndex = 0;
            this.btn_search_multy.Text = "여러파일 검색";
            this.btn_search_multy.UseVisualStyleBackColor = true;
            this.btn_search_multy.Click += new System.EventHandler(this.btn_search_multy_Click);
            // 
            // btn_atlas
            // 
            this.btn_atlas.Location = new System.Drawing.Point(6, 51);
            this.btn_atlas.Name = "btn_atlas";
            this.btn_atlas.Size = new System.Drawing.Size(180, 23);
            this.btn_atlas.TabIndex = 1;
            this.btn_atlas.Text = "아틀라스 검색";
            this.btn_atlas.UseVisualStyleBackColor = true;
            this.btn_atlas.Click += new System.EventHandler(this.btn_atlas_Click);
            // 
            // btn_text
            // 
            this.btn_text.Location = new System.Drawing.Point(6, 80);
            this.btn_text.Name = "btn_text";
            this.btn_text.Size = new System.Drawing.Size(180, 23);
            this.btn_text.TabIndex = 2;
            this.btn_text.Text = "문자열 검색";
            this.btn_text.UseVisualStyleBackColor = true;
            this.btn_text.Click += new System.EventHandler(this.btn_text_Click);
            // 
            // btn_find_p3d
            // 
            this.btn_find_p3d.Location = new System.Drawing.Point(6, 22);
            this.btn_find_p3d.Name = "btn_find_p3d";
            this.btn_find_p3d.Size = new System.Drawing.Size(180, 23);
            this.btn_find_p3d.TabIndex = 4;
            this.btn_find_p3d.Text = "파티클3D 찾기";
            this.btn_find_p3d.UseVisualStyleBackColor = true;
            this.btn_find_p3d.Click += new System.EventHandler(this.btn_find_p3d_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_atlas);
            this.groupBox1.Controls.Add(this.btn_search_multy);
            this.groupBox1.Controls.Add(this.btn_text);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 173);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UUID 검색";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_find_p3d);
            this.groupBox2.Location = new System.Drawing.Point(213, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 173);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "문제 해결";
            // 
            // btn_switch_atlas_uuid
            // 
            this.btn_switch_atlas_uuid.Location = new System.Drawing.Point(6, 22);
            this.btn_switch_atlas_uuid.Name = "btn_switch_atlas_uuid";
            this.btn_switch_atlas_uuid.Size = new System.Drawing.Size(180, 23);
            this.btn_switch_atlas_uuid.TabIndex = 5;
            this.btn_switch_atlas_uuid.Text = "아틀라스간 UUID 교체";
            this.btn_switch_atlas_uuid.UseVisualStyleBackColor = true;
            this.btn_switch_atlas_uuid.Click += new System.EventHandler(this.btn_switch_atlas_uuid_Click);
            // 
            // btn_change_sprites
            // 
            this.btn_change_sprites.Location = new System.Drawing.Point(6, 51);
            this.btn_change_sprites.Name = "btn_change_sprites";
            this.btn_change_sprites.Size = new System.Drawing.Size(180, 23);
            this.btn_change_sprites.TabIndex = 6;
            this.btn_change_sprites.Text = "스프라이트 선택 변경(전체)";
            this.btn_change_sprites.UseVisualStyleBackColor = true;
            this.btn_change_sprites.Click += new System.EventHandler(this.btn_switch_uuid_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_change_sprite_prefab);
            this.groupBox3.Controls.Add(this.btn_change_sprite);
            this.groupBox3.Controls.Add(this.btn_change_sprites);
            this.groupBox3.Controls.Add(this.btn_switch_atlas_uuid);
            this.groupBox3.Location = new System.Drawing.Point(414, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 173);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "아틀라스 문제해결";
            // 
            // btn_change_sprite
            // 
            this.btn_change_sprite.Location = new System.Drawing.Point(6, 109);
            this.btn_change_sprite.Name = "btn_change_sprite";
            this.btn_change_sprite.Size = new System.Drawing.Size(180, 23);
            this.btn_change_sprite.TabIndex = 7;
            this.btn_change_sprite.Text = "[X]특정 스프라이트 변경(전체)";
            this.btn_change_sprite.UseVisualStyleBackColor = true;
            this.btn_change_sprite.Click += new System.EventHandler(this.btn_change_sprite_Click);
            // 
            // btn_change_sprite_prefab
            // 
            this.btn_change_sprite_prefab.Location = new System.Drawing.Point(6, 80);
            this.btn_change_sprite_prefab.Name = "btn_change_sprite_prefab";
            this.btn_change_sprite_prefab.Size = new System.Drawing.Size(180, 23);
            this.btn_change_sprite_prefab.TabIndex = 8;
            this.btn_change_sprite_prefab.Text = "스프라이트 선택 변경(프리팹)";
            this.btn_change_sprite_prefab.UseVisualStyleBackColor = true;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 197);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Menu";
            this.ShowIcon = false;
            this.Text = "CocosCreator Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_search_multy;
        private System.Windows.Forms.Button btn_atlas;
        private System.Windows.Forms.Button btn_text;
        private System.Windows.Forms.Button btn_find_p3d;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_change_sprites;
        private System.Windows.Forms.Button btn_switch_atlas_uuid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_change_sprite;
        private System.Windows.Forms.Button btn_change_sprite_prefab;
    }
}