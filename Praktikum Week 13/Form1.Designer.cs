namespace Praktikum_Week_13
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
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnprev = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_team = new System.Windows.Forms.Label();
            this.lbl_nationality = new System.Windows.Forms.Label();
            this.lbl_birthdate = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.dtp_birthdate = new System.Windows.Forms.DateTimePicker();
            this.tbx_id = new System.Windows.Forms.TextBox();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.lb_hasil = new System.Windows.Forms.Label();
            this.nud_number = new System.Windows.Forms.NumericUpDown();
            this.cmbox_nationality = new System.Windows.Forms.ComboBox();
            this.cmbox_team = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_number)).BeginInit();
            this.SuspendLayout();
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(59, 27);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(82, 31);
            this.btnfirst.TabIndex = 0;
            this.btnfirst.Text = "<<";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btn_left1_Click);
            // 
            // btnprev
            // 
            this.btnprev.Location = new System.Drawing.Point(171, 27);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(82, 31);
            this.btnprev.TabIndex = 1;
            this.btnprev.Text = "<";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(281, 27);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(82, 31);
            this.btnnext.TabIndex = 2;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(394, 27);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(82, 31);
            this.btnlast.TabIndex = 3;
            this.btnlast.Text = ">>";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(68, 87);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(73, 20);
            this.lbl_id.TabIndex = 4;
            this.lbl_id.Text = "Player ID";
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Location = new System.Drawing.Point(68, 268);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(109, 20);
            this.lbl_number.TabIndex = 5;
            this.lbl_number.Text = "Team Number";
            // 
            // lbl_team
            // 
            this.lbl_team.AutoSize = true;
            this.lbl_team.Location = new System.Drawing.Point(68, 233);
            this.lbl_team.Name = "lbl_team";
            this.lbl_team.Size = new System.Drawing.Size(49, 20);
            this.lbl_team.TabIndex = 6;
            this.lbl_team.Text = "Team";
            this.lbl_team.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_nationality
            // 
            this.lbl_nationality.AutoSize = true;
            this.lbl_nationality.Location = new System.Drawing.Point(68, 197);
            this.lbl_nationality.Name = "lbl_nationality";
            this.lbl_nationality.Size = new System.Drawing.Size(82, 20);
            this.lbl_nationality.TabIndex = 7;
            this.lbl_nationality.Text = "Nationality";
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Location = new System.Drawing.Point(68, 161);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.Size = new System.Drawing.Size(81, 20);
            this.lbl_birthdate.TabIndex = 8;
            this.lbl_birthdate.Text = "Birth Date";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(68, 125);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(98, 20);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "Player Name";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(72, 348);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(181, 34);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(331, 348);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(145, 34);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dtp_birthdate
            // 
            this.dtp_birthdate.Location = new System.Drawing.Point(183, 161);
            this.dtp_birthdate.Name = "dtp_birthdate";
            this.dtp_birthdate.Size = new System.Drawing.Size(293, 26);
            this.dtp_birthdate.TabIndex = 12;
            // 
            // tbx_id
            // 
            this.tbx_id.Location = new System.Drawing.Point(183, 84);
            this.tbx_id.Name = "tbx_id";
            this.tbx_id.Size = new System.Drawing.Size(190, 26);
            this.tbx_id.TabIndex = 13;
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(184, 119);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(190, 26);
            this.tbx_name.TabIndex = 17;
            // 
            // lb_hasil
            // 
            this.lb_hasil.AutoSize = true;
            this.lb_hasil.Location = new System.Drawing.Point(462, 271);
            this.lb_hasil.Name = "lb_hasil";
            this.lb_hasil.Size = new System.Drawing.Size(51, 20);
            this.lb_hasil.TabIndex = 18;
            this.lb_hasil.Text = "label7";
            // 
            // nud_number
            // 
            this.nud_number.Location = new System.Drawing.Point(183, 269);
            this.nud_number.Name = "nud_number";
            this.nud_number.Size = new System.Drawing.Size(191, 26);
            this.nud_number.TabIndex = 20;
            // 
            // cmbox_nationality
            // 
            this.cmbox_nationality.FormattingEnabled = true;
            this.cmbox_nationality.Location = new System.Drawing.Point(184, 197);
            this.cmbox_nationality.Name = "cmbox_nationality";
            this.cmbox_nationality.Size = new System.Drawing.Size(190, 28);
            this.cmbox_nationality.TabIndex = 21;
            // 
            // cmbox_team
            // 
            this.cmbox_team.FormattingEnabled = true;
            this.cmbox_team.Location = new System.Drawing.Point(184, 231);
            this.cmbox_team.Name = "cmbox_team";
            this.cmbox_team.Size = new System.Drawing.Size(190, 28);
            this.cmbox_team.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbox_team);
            this.Controls.Add(this.cmbox_nationality);
            this.Controls.Add(this.nud_number);
            this.Controls.Add(this.lb_hasil);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.tbx_id);
            this.Controls.Add(this.dtp_birthdate);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_birthdate);
            this.Controls.Add(this.lbl_nationality);
            this.Controls.Add(this.lbl_team);
            this.Controls.Add(this.lbl_number);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.btnfirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label lbl_team;
        private System.Windows.Forms.Label lbl_nationality;
        private System.Windows.Forms.Label lbl_birthdate;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DateTimePicker dtp_birthdate;
        private System.Windows.Forms.TextBox tbx_id;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Label lb_hasil;
        private System.Windows.Forms.NumericUpDown nud_number;
        private System.Windows.Forms.ComboBox cmbox_nationality;
        private System.Windows.Forms.ComboBox cmbox_team;
    }
}

