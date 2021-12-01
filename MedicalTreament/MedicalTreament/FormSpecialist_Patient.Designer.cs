
namespace MedicalTreament
{
    partial class FormSpecialist_Patient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_sp_pass = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label_sp_patient_exam = new Guna.UI.WinForms.GunaLabel();
            this.label_sp_patient_gender = new Guna.UI.WinForms.GunaLabel();
            this.label_sp_patient_age = new Guna.UI.WinForms.GunaLabel();
            this.label_sp_patient_name = new Guna.UI.WinForms.GunaLabel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.gridview_sp_patient = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_sp_patient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.btn_sp_pass);
            this.panel1.Controls.Add(this.label_sp_patient_exam);
            this.panel1.Controls.Add(this.label_sp_patient_gender);
            this.panel1.Controls.Add(this.label_sp_patient_age);
            this.panel1.Controls.Add(this.label_sp_patient_name);
            this.panel1.Controls.Add(this.guna2CircleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.ShadowDecoration.Parent = this.panel1;
            this.panel1.Size = new System.Drawing.Size(863, 176);
            this.panel1.TabIndex = 1;
            // 
            // btn_sp_pass
            // 
            this.btn_sp_pass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sp_pass.CheckedState.Parent = this.btn_sp_pass;
            this.btn_sp_pass.CustomImages.Parent = this.btn_sp_pass;
            this.btn_sp_pass.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_sp_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_sp_pass.ForeColor = System.Drawing.Color.White;
            this.btn_sp_pass.HoverState.Parent = this.btn_sp_pass;
            this.btn_sp_pass.Image = global::MedicalTreament.Properties.Resources.double_right_48;
            this.btn_sp_pass.ImageOffset = new System.Drawing.Point(1, 0);
            this.btn_sp_pass.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_sp_pass.Location = new System.Drawing.Point(754, 45);
            this.btn_sp_pass.Name = "btn_sp_pass";
            this.btn_sp_pass.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_sp_pass.ShadowDecoration.Parent = this.btn_sp_pass;
            this.btn_sp_pass.Size = new System.Drawing.Size(80, 80);
            this.btn_sp_pass.TabIndex = 5;
            this.btn_sp_pass.Click += new System.EventHandler(this.btn_sp_pass_Click);
            // 
            // label_sp_patient_exam
            // 
            this.label_sp_patient_exam.AutoSize = true;
            this.label_sp_patient_exam.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sp_patient_exam.Location = new System.Drawing.Point(166, 111);
            this.label_sp_patient_exam.Name = "label_sp_patient_exam";
            this.label_sp_patient_exam.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label_sp_patient_exam.Size = new System.Drawing.Size(232, 33);
            this.label_sp_patient_exam.TabIndex = 4;
            this.label_sp_patient_exam.Text = "Examinate: Ultrasound scan";
            this.label_sp_patient_exam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_sp_patient_gender
            // 
            this.label_sp_patient_gender.AutoSize = true;
            this.label_sp_patient_gender.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sp_patient_gender.Location = new System.Drawing.Point(166, 78);
            this.label_sp_patient_gender.Name = "label_sp_patient_gender";
            this.label_sp_patient_gender.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label_sp_patient_gender.Size = new System.Drawing.Size(124, 33);
            this.label_sp_patient_gender.TabIndex = 3;
            this.label_sp_patient_gender.Text = "Gender: Male";
            this.label_sp_patient_gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_sp_patient_age
            // 
            this.label_sp_patient_age.AutoSize = true;
            this.label_sp_patient_age.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sp_patient_age.Location = new System.Drawing.Point(166, 45);
            this.label_sp_patient_age.Name = "label_sp_patient_age";
            this.label_sp_patient_age.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label_sp_patient_age.Size = new System.Drawing.Size(75, 33);
            this.label_sp_patient_age.TabIndex = 2;
            this.label_sp_patient_age.Text = "Age: 18";
            this.label_sp_patient_age.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_sp_patient_name
            // 
            this.label_sp_patient_name.AutoSize = true;
            this.label_sp_patient_name.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sp_patient_name.Location = new System.Drawing.Point(166, 12);
            this.label_sp_patient_name.Name = "label_sp_patient_name";
            this.label_sp_patient_name.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label_sp_patient_name.Size = new System.Drawing.Size(145, 33);
            this.label_sp_patient_name.TabIndex = 1;
            this.label_sp_patient_name.Text = "Patient: Alababa";
            this.label_sp_patient_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Khaki;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Image = global::MedicalTreament.Properties.Resources.patient;
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(80, 80);
            this.guna2CircleButton1.Location = new System.Drawing.Point(12, 12);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(148, 148);
            this.guna2CircleButton1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.panel2);
            this.guna2Panel2.Controls.Add(this.guna2Button1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 176);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(863, 451);
            this.guna2Panel2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.gridview_sp_patient);
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.ShadowDecoration.Parent = this.panel2;
            this.panel2.Size = new System.Drawing.Size(863, 394);
            this.panel2.TabIndex = 2;
            // 
            // gridview_sp_patient
            // 
            this.gridview_sp_patient.AllowUserToAddRows = false;
            this.gridview_sp_patient.AllowUserToDeleteRows = false;
            this.gridview_sp_patient.AllowUserToOrderColumns = true;
            this.gridview_sp_patient.AllowUserToResizeColumns = false;
            this.gridview_sp_patient.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridview_sp_patient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridview_sp_patient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview_sp_patient.BackgroundColor = System.Drawing.Color.White;
            this.gridview_sp_patient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview_sp_patient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_sp_patient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview_sp_patient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridview_sp_patient.ColumnHeadersHeight = 27;
            this.gridview_sp_patient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_sp_patient.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridview_sp_patient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridview_sp_patient.EnableHeadersVisualStyles = false;
            this.gridview_sp_patient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_sp_patient.Location = new System.Drawing.Point(0, 0);
            this.gridview_sp_patient.Name = "gridview_sp_patient";
            this.gridview_sp_patient.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview_sp_patient.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridview_sp_patient.RowHeadersVisible = false;
            this.gridview_sp_patient.RowHeadersWidth = 51;
            this.gridview_sp_patient.RowTemplate.Height = 24;
            this.gridview_sp_patient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_sp_patient.Size = new System.Drawing.Size(863, 394);
            this.gridview_sp_patient.TabIndex = 0;
            this.gridview_sp_patient.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gridview_sp_patient.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_sp_patient.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridview_sp_patient.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridview_sp_patient.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridview_sp_patient.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridview_sp_patient.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridview_sp_patient.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_sp_patient.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridview_sp_patient.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridview_sp_patient.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridview_sp_patient.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridview_sp_patient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridview_sp_patient.ThemeStyle.HeaderStyle.Height = 27;
            this.gridview_sp_patient.ThemeStyle.ReadOnly = true;
            this.gridview_sp_patient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_sp_patient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_sp_patient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridview_sp_patient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridview_sp_patient.ThemeStyle.RowsStyle.Height = 24;
            this.gridview_sp_patient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_sp_patient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.FillWeight = 40F;
            this.Column1.HeaderText = "Number";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 160F;
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.PowderBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(12, 6);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(236, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Examination List";
            // 
            // FormSpecialist_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(863, 627);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormSpecialist_Patient";
            this.Text = "FormSpecialist_Patient";
            this.Load += new System.EventHandler(this.FormSpecialist_Patient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_sp_patient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2Panel panel1;
        private Guna.UI.WinForms.GunaLabel label_sp_patient_exam;
        private Guna.UI.WinForms.GunaLabel label_sp_patient_gender;
        private Guna.UI.WinForms.GunaLabel label_sp_patient_age;
        private Guna.UI.WinForms.GunaLabel label_sp_patient_name;
        private Guna.UI2.WinForms.Guna2CircleButton btn_sp_pass;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView gridview_sp_patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}