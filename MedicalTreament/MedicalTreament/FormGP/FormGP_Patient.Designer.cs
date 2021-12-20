
namespace MedicalTreament
{
    partial class FormGP_Patient
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGP_Patient));
            this.gridview_patient = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gppatienttextbox_search = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_patient)).BeginInit();
            this.SuspendLayout();
            // 
            // gridview_patient
            // 
            this.gridview_patient.AllowUserToAddRows = false;
            this.gridview_patient.AllowUserToDeleteRows = false;
            this.gridview_patient.AllowUserToOrderColumns = true;
            this.gridview_patient.AllowUserToResizeColumns = false;
            this.gridview_patient.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridview_patient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridview_patient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridview_patient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview_patient.BackgroundColor = System.Drawing.Color.White;
            this.gridview_patient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview_patient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_patient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview_patient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridview_patient.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_patient.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridview_patient.EnableHeadersVisualStyles = false;
            this.gridview_patient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_patient.Location = new System.Drawing.Point(13, 73);
            this.gridview_patient.Name = "gridview_patient";
            this.gridview_patient.RowHeadersVisible = false;
            this.gridview_patient.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.gridview_patient.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridview_patient.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridview_patient.RowTemplate.Height = 25;
            this.gridview_patient.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_patient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_patient.Size = new System.Drawing.Size(838, 462);
            this.gridview_patient.TabIndex = 5;
            this.gridview_patient.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gridview_patient.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_patient.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridview_patient.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridview_patient.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridview_patient.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridview_patient.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridview_patient.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_patient.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridview_patient.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridview_patient.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridview_patient.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridview_patient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridview_patient.ThemeStyle.HeaderStyle.Height = 30;
            this.gridview_patient.ThemeStyle.ReadOnly = false;
            this.gridview_patient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_patient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_patient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridview_patient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridview_patient.ThemeStyle.RowsStyle.Height = 25;
            this.gridview_patient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_patient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 9;
            this.guna2Elipse1.TargetControl = this.gridview_patient;
            // 
            // gppatienttextbox_search
            // 
            this.gppatienttextbox_search.AutoRoundedCorners = true;
            this.gppatienttextbox_search.BorderColor = System.Drawing.Color.Transparent;
            this.gppatienttextbox_search.BorderRadius = 21;
            this.gppatienttextbox_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gppatienttextbox_search.DefaultText = "";
            this.gppatienttextbox_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gppatienttextbox_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gppatienttextbox_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gppatienttextbox_search.DisabledState.Parent = this.gppatienttextbox_search;
            this.gppatienttextbox_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gppatienttextbox_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gppatienttextbox_search.FocusedState.Parent = this.gppatienttextbox_search;
            this.gppatienttextbox_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gppatienttextbox_search.HoverState.Parent = this.gppatienttextbox_search;
            this.gppatienttextbox_search.IconLeft = ((System.Drawing.Image)(resources.GetObject("gppatienttextbox_search.IconLeft")));
            this.gppatienttextbox_search.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.gppatienttextbox_search.Location = new System.Drawing.Point(13, 13);
            this.gppatienttextbox_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gppatienttextbox_search.Name = "gppatienttextbox_search";
            this.gppatienttextbox_search.PasswordChar = '\0';
            this.gppatienttextbox_search.PlaceholderText = "Search....";
            this.gppatienttextbox_search.SelectedText = "";
            this.gppatienttextbox_search.ShadowDecoration.Parent = this.gppatienttextbox_search;
            this.gppatienttextbox_search.Size = new System.Drawing.Size(283, 44);
            this.gppatienttextbox_search.TabIndex = 4;
            this.gppatienttextbox_search.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // FormGP_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 627);
            this.Controls.Add(this.gridview_patient);
            this.Controls.Add(this.gppatienttextbox_search);
            this.Name = "FormGP_Patient";
            this.Text = "FormGP_Patient";
            this.Load += new System.EventHandler(this.FormGP_Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_patient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView gridview_patient;
        private Guna.UI2.WinForms.Guna2TextBox gppatienttextbox_search;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}