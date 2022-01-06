
namespace MedicalTreament
{
    partial class FormGP_Prescription
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGP_Prescription));
            this.gridview_pill = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gridview_prescription = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_date = new Guna.UI.WinForms.GunaLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_CreatePrescription = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_remove = new Guna.UI2.WinForms.Guna2CircleButton();
            this.gppatienttextbox_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_edit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtInstruction = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_pill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_prescription)).BeginInit();
            this.SuspendLayout();
            // 
            // gridview_pill
            // 
            this.gridview_pill.AllowUserToAddRows = false;
            this.gridview_pill.AllowUserToDeleteRows = false;
            this.gridview_pill.AllowUserToOrderColumns = true;
            this.gridview_pill.AllowUserToResizeColumns = false;
            this.gridview_pill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridview_pill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridview_pill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridview_pill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview_pill.BackgroundColor = System.Drawing.Color.White;
            this.gridview_pill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview_pill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_pill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview_pill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridview_pill.ColumnHeadersHeight = 30;
            this.gridview_pill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_pill.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridview_pill.EnableHeadersVisualStyles = false;
            this.gridview_pill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_pill.Location = new System.Drawing.Point(13, 74);
            this.gridview_pill.MultiSelect = false;
            this.gridview_pill.Name = "gridview_pill";
            this.gridview_pill.ReadOnly = true;
            this.gridview_pill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridview_pill.RowHeadersVisible = false;
            this.gridview_pill.RowHeadersWidth = 51;
            this.gridview_pill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridview_pill.RowTemplate.Height = 25;
            this.gridview_pill.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_pill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_pill.Size = new System.Drawing.Size(310, 508);
            this.gridview_pill.TabIndex = 1;
            this.gridview_pill.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gridview_pill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_pill.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridview_pill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridview_pill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridview_pill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridview_pill.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridview_pill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_pill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridview_pill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridview_pill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridview_pill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridview_pill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridview_pill.ThemeStyle.HeaderStyle.Height = 30;
            this.gridview_pill.ThemeStyle.ReadOnly = true;
            this.gridview_pill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_pill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_pill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridview_pill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridview_pill.ThemeStyle.RowsStyle.Height = 25;
            this.gridview_pill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_pill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gridview_prescription
            // 
            this.gridview_prescription.AllowUserToAddRows = false;
            this.gridview_prescription.AllowUserToDeleteRows = false;
            this.gridview_prescription.AllowUserToOrderColumns = true;
            this.gridview_prescription.AllowUserToResizeColumns = false;
            this.gridview_prescription.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gridview_prescription.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridview_prescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridview_prescription.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview_prescription.BackgroundColor = System.Drawing.Color.White;
            this.gridview_prescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview_prescription.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_prescription.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview_prescription.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridview_prescription.ColumnHeadersHeight = 30;
            this.gridview_prescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridview_prescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_prescription.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridview_prescription.EnableHeadersVisualStyles = false;
            this.gridview_prescription.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_prescription.Location = new System.Drawing.Point(343, 74);
            this.gridview_prescription.MultiSelect = false;
            this.gridview_prescription.Name = "gridview_prescription";
            this.gridview_prescription.ReadOnly = true;
            this.gridview_prescription.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridview_prescription.RowHeadersVisible = false;
            this.gridview_prescription.RowHeadersWidth = 51;
            this.gridview_prescription.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridview_prescription.RowTemplate.Height = 25;
            this.gridview_prescription.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_prescription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_prescription.Size = new System.Drawing.Size(507, 508);
            this.gridview_prescription.TabIndex = 7;
            this.gridview_prescription.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gridview_prescription.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_prescription.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridview_prescription.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridview_prescription.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridview_prescription.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridview_prescription.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridview_prescription.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_prescription.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridview_prescription.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridview_prescription.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridview_prescription.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridview_prescription.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridview_prescription.ThemeStyle.HeaderStyle.Height = 30;
            this.gridview_prescription.ThemeStyle.ReadOnly = true;
            this.gridview_prescription.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_prescription.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_prescription.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridview_prescription.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridview_prescription.ThemeStyle.RowsStyle.Height = 25;
            this.gridview_prescription.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_prescription.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column3
            // 
            this.Column3.FillWeight = 165F;
            this.Column3.HeaderText = "Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 55F;
            this.Column4.HeaderText = "Amount";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label_date
            // 
            this.label_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(338, 543);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(0, 25);
            this.label_date.TabIndex = 10;
            this.label_date.Visible = false;
            // 
            // btn_CreatePrescription
            // 
            this.btn_CreatePrescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CreatePrescription.BorderRadius = 20;
            this.btn_CreatePrescription.CheckedState.Parent = this.btn_CreatePrescription;
            this.btn_CreatePrescription.CustomImages.Parent = this.btn_CreatePrescription;
            this.btn_CreatePrescription.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_CreatePrescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreatePrescription.ForeColor = System.Drawing.Color.White;
            this.btn_CreatePrescription.HoverState.Parent = this.btn_CreatePrescription;
            this.btn_CreatePrescription.Location = new System.Drawing.Point(671, 699);
            this.btn_CreatePrescription.Name = "btn_CreatePrescription";
            this.btn_CreatePrescription.ShadowDecoration.Parent = this.btn_CreatePrescription;
            this.btn_CreatePrescription.Size = new System.Drawing.Size(180, 45);
            this.btn_CreatePrescription.TabIndex = 11;
            this.btn_CreatePrescription.Text = "OK";
            this.btn_CreatePrescription.Click += new System.EventHandler(this.btn_CreatePrescription_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.CheckedState.Parent = this.btn_add;
            this.btn_add.CustomImages.Parent = this.btn_add;
            this.btn_add.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.HoverState.Parent = this.btn_add;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageOffset = new System.Drawing.Point(1, 1);
            this.btn_add.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_add.Location = new System.Drawing.Point(704, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_add.ShadowDecoration.Parent = this.btn_add;
            this.btn_add.Size = new System.Drawing.Size(45, 45);
            this.btn_add.TabIndex = 9;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remove.CheckedState.Parent = this.btn_remove;
            this.btn_remove.CustomImages.Parent = this.btn_remove;
            this.btn_remove.FillColor = System.Drawing.Color.Salmon;
            this.btn_remove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.HoverState.Parent = this.btn_remove;
            this.btn_remove.Image = ((System.Drawing.Image)(resources.GetObject("btn_remove.Image")));
            this.btn_remove.ImageOffset = new System.Drawing.Point(1, 1);
            this.btn_remove.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_remove.Location = new System.Drawing.Point(755, 12);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_remove.ShadowDecoration.Parent = this.btn_remove;
            this.btn_remove.Size = new System.Drawing.Size(45, 45);
            this.btn_remove.TabIndex = 8;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
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
            this.gppatienttextbox_search.Size = new System.Drawing.Size(684, 44);
            this.gppatienttextbox_search.TabIndex = 5;
            this.gppatienttextbox_search.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.CheckedState.Parent = this.btn_edit;
            this.btn_edit.CustomImages.Parent = this.btn_edit;
            this.btn_edit.FillColor = System.Drawing.Color.Gold;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.HoverState.Parent = this.btn_edit;
            this.btn_edit.Image = global::MedicalTreament.Properties.Resources.edit;
            this.btn_edit.ImageOffset = new System.Drawing.Point(1, 1);
            this.btn_edit.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_edit.Location = new System.Drawing.Point(806, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_edit.ShadowDecoration.Parent = this.btn_edit;
            this.btn_edit.Size = new System.Drawing.Size(45, 45);
            this.btn_edit.TabIndex = 13;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txtInstruction
            // 
            this.txtInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInstruction.BorderColor = System.Drawing.Color.DimGray;
            this.txtInstruction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInstruction.DefaultText = "";
            this.txtInstruction.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInstruction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInstruction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInstruction.DisabledState.Parent = this.txtInstruction;
            this.txtInstruction.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInstruction.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstruction.FocusedState.Parent = this.txtInstruction;
            this.txtInstruction.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtInstruction.ForeColor = System.Drawing.Color.Black;
            this.txtInstruction.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstruction.HoverState.Parent = this.txtInstruction;
            this.txtInstruction.Location = new System.Drawing.Point(13, 589);
            this.txtInstruction.Margin = new System.Windows.Forms.Padding(4);
            this.txtInstruction.Multiline = true;
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.PasswordChar = '\0';
            this.txtInstruction.PlaceholderText = "Pill Instruction Here....";
            this.txtInstruction.SelectedText = "";
            this.txtInstruction.ShadowDecoration.Parent = this.txtInstruction;
            this.txtInstruction.Size = new System.Drawing.Size(837, 93);
            this.txtInstruction.TabIndex = 14;
            // 
            // FormGP_Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 767);
            this.Controls.Add(this.txtInstruction);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_CreatePrescription);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.gridview_prescription);
            this.Controls.Add(this.gridview_pill);
            this.Controls.Add(this.gppatienttextbox_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGP_Prescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGP_Prescription";
            this.Load += new System.EventHandler(this.FormGP_Prescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_pill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_prescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox gppatienttextbox_search;
        private Guna.UI2.WinForms.Guna2DataGridView gridview_pill;
        private Guna.UI2.WinForms.Guna2DataGridView gridview_prescription;
        private Guna.UI2.WinForms.Guna2CircleButton btn_add;
        private Guna.UI2.WinForms.Guna2CircleButton btn_remove;
        private Guna.UI.WinForms.GunaLabel label_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Button btn_CreatePrescription;
        private Guna.UI2.WinForms.Guna2CircleButton btn_edit;
        private Guna.UI2.WinForms.Guna2TextBox txtInstruction;
    }
}