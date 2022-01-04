
namespace MedicalTreament
{
    partial class FormGP_Diagnosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGP_Diagnosis));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtDirection = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.comboBoxSEname = new System.Windows.Forms.ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReason = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxPatientName = new System.Windows.Forms.ComboBox();
            this.gppatienttextbox_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_reason = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridview_requestlist = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_requestlist)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDirection
            // 
            this.txtDirection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirection.BorderColor = System.Drawing.Color.DimGray;
            this.txtDirection.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDirection.DefaultText = "";
            this.txtDirection.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDirection.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDirection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDirection.DisabledState.Parent = this.txtDirection;
            this.txtDirection.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDirection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDirection.FocusedState.Parent = this.txtDirection;
            this.txtDirection.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtDirection.ForeColor = System.Drawing.Color.Black;
            this.txtDirection.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDirection.HoverState.Parent = this.txtDirection;
            this.txtDirection.Location = new System.Drawing.Point(185, 726);
            this.txtDirection.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirection.Multiline = true;
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.PasswordChar = '\0';
            this.txtDirection.PlaceholderText = "";
            this.txtDirection.SelectedText = "";
            this.txtDirection.ShadowDecoration.Parent = this.txtDirection;
            this.txtDirection.Size = new System.Drawing.Size(648, 142);
            this.txtDirection.TabIndex = 6;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.gunaLabel2.Location = new System.Drawing.Point(37, 726);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(68, 20);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "Dặn dò:";
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CircleButton2.CheckedState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.CustomImages.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.FillColor = System.Drawing.Color.Aquamarine;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.HoverState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Image = global::MedicalTreament.Properties.Resources.double_right_48;
            this.guna2CircleButton2.ImageOffset = new System.Drawing.Point(1, 0);
            this.guna2CircleButton2.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2CircleButton2.Location = new System.Drawing.Point(747, 888);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.ShadowDecoration.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Size = new System.Drawing.Size(86, 81);
            this.guna2CircleButton2.TabIndex = 6;
            this.guna2CircleButton2.Click += new System.EventHandler(this.guna2CircleButton2_Click);
            // 
            // comboBoxSEname
            // 
            this.comboBoxSEname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSEname.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comboBoxSEname.ForeColor = System.Drawing.Color.Black;
            this.comboBoxSEname.FormattingEnabled = true;
            this.comboBoxSEname.Location = new System.Drawing.Point(185, 311);
            this.comboBoxSEname.Name = "comboBoxSEname";
            this.comboBoxSEname.Size = new System.Drawing.Size(312, 31);
            this.comboBoxSEname.TabIndex = 4;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(540, 296);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 40;
            this.guna2Button1.Text = "Request";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 311);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label4.Size = new System.Drawing.Size(92, 30);
            this.label4.TabIndex = 39;
            this.label4.Text = "Examinate:";
            // 
            // txtReason
            // 
            this.txtReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReason.BorderColor = System.Drawing.Color.DimGray;
            this.txtReason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReason.DefaultText = "";
            this.txtReason.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReason.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReason.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReason.DisabledState.Parent = this.txtReason;
            this.txtReason.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReason.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReason.FocusedState.Parent = this.txtReason;
            this.txtReason.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtReason.ForeColor = System.Drawing.Color.Black;
            this.txtReason.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReason.HoverState.Parent = this.txtReason;
            this.txtReason.Location = new System.Drawing.Point(185, 197);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.PasswordChar = '\0';
            this.txtReason.PlaceholderText = "";
            this.txtReason.SelectedText = "";
            this.txtReason.ShadowDecoration.Parent = this.txtReason;
            this.txtReason.Size = new System.Drawing.Size(648, 81);
            this.txtReason.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 144);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(138, 33);
            this.label1.TabIndex = 37;
            this.label1.Text = "Phone:";
            // 
            // ComboBoxPatientName
            // 
            this.ComboBoxPatientName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxPatientName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxPatientName.FormattingEnabled = true;
            this.ComboBoxPatientName.Location = new System.Drawing.Point(185, 107);
            this.ComboBoxPatientName.Name = "ComboBoxPatientName";
            this.ComboBoxPatientName.Size = new System.Drawing.Size(311, 31);
            this.ComboBoxPatientName.TabIndex = 1;
            this.ComboBoxPatientName.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPatientName_SelectedIndexChanged);
            // 
            // gppatienttextbox_search
            // 
            this.gppatienttextbox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.gppatienttextbox_search.Location = new System.Drawing.Point(550, 38);
            this.gppatienttextbox_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gppatienttextbox_search.Name = "gppatienttextbox_search";
            this.gppatienttextbox_search.PasswordChar = '\0';
            this.gppatienttextbox_search.PlaceholderText = "Search....";
            this.gppatienttextbox_search.SelectedText = "";
            this.gppatienttextbox_search.ShadowDecoration.Parent = this.gppatienttextbox_search;
            this.gppatienttextbox_search.Size = new System.Drawing.Size(322, 44);
            this.gppatienttextbox_search.TabIndex = 34;
            this.gppatienttextbox_search.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label_reason
            // 
            this.label_reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reason.Location = new System.Drawing.Point(37, 185);
            this.label_reason.Name = "label_reason";
            this.label_reason.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label_reason.Size = new System.Drawing.Size(138, 33);
            this.label_reason.TabIndex = 33;
            this.label_reason.Text = "Reason to come:";
            // 
            // label_date
            // 
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(36, 68);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(150, 29);
            this.label_date.TabIndex = 32;
            this.label_date.Text = "Date: 1/12/2021";
            // 
            // label_name
            // 
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(37, 105);
            this.label_name.Name = "label_name";
            this.label_name.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label_name.Size = new System.Drawing.Size(138, 33);
            this.label_name.TabIndex = 31;
            this.label_name.Text = "Name:";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtPhone.BorderColor = System.Drawing.Color.DimGray;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.Parent = this.txtPhone;
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.FocusedState.Parent = this.txtPhone;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.HoverState.Parent = this.txtPhone;
            this.txtPhone.Location = new System.Drawing.Point(185, 145);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.ShadowDecoration.Parent = this.txtPhone;
            this.txtPhone.Size = new System.Drawing.Size(312, 33);
            this.txtPhone.TabIndex = 2;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.gunaLabel3.Location = new System.Drawing.Point(37, 578);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(132, 20);
            this.gunaLabel3.TabIndex = 44;
            this.gunaLabel3.Text = "Diagnose result:\r\n";
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox2.BorderColor = System.Drawing.Color.DimGray;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(185, 578);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox2.Multiline = true;
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(648, 99);
            this.guna2TextBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 362);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 46;
            this.label2.Text = "Request List:";
            // 
            // gridview_requestlist
            // 
            this.gridview_requestlist.AllowUserToAddRows = false;
            this.gridview_requestlist.AllowUserToDeleteRows = false;
            this.gridview_requestlist.AllowUserToOrderColumns = true;
            this.gridview_requestlist.AllowUserToResizeColumns = false;
            this.gridview_requestlist.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridview_requestlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridview_requestlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridview_requestlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview_requestlist.BackgroundColor = System.Drawing.Color.White;
            this.gridview_requestlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview_requestlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_requestlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview_requestlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridview_requestlist.ColumnHeadersHeight = 30;
            this.gridview_requestlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_requestlist.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridview_requestlist.EnableHeadersVisualStyles = false;
            this.gridview_requestlist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_requestlist.Location = new System.Drawing.Point(185, 362);
            this.gridview_requestlist.MultiSelect = false;
            this.gridview_requestlist.Name = "gridview_requestlist";
            this.gridview_requestlist.ReadOnly = true;
            this.gridview_requestlist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridview_requestlist.RowHeadersVisible = false;
            this.gridview_requestlist.RowHeadersWidth = 51;
            this.gridview_requestlist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridview_requestlist.RowTemplate.Height = 24;
            this.gridview_requestlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_requestlist.Size = new System.Drawing.Size(648, 172);
            this.gridview_requestlist.TabIndex = 5;
            this.gridview_requestlist.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gridview_requestlist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_requestlist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridview_requestlist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridview_requestlist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridview_requestlist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridview_requestlist.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridview_requestlist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_requestlist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridview_requestlist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridview_requestlist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridview_requestlist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridview_requestlist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridview_requestlist.ThemeStyle.HeaderStyle.Height = 30;
            this.gridview_requestlist.ThemeStyle.ReadOnly = true;
            this.gridview_requestlist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_requestlist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_requestlist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridview_requestlist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridview_requestlist.ThemeStyle.RowsStyle.Height = 24;
            this.gridview_requestlist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_requestlist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // FormGP_Diagnosis
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(886, 1055);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridview_requestlist);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.comboBoxSEname);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxPatientName);
            this.Controls.Add(this.gppatienttextbox_search);
            this.Controls.Add(this.label_reason);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.guna2CircleButton2);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txtDirection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGP_Diagnosis";
            this.Text = "FormGP_Diagnosis";
            this.Load += new System.EventHandler(this.FormGP_Diagnosis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_requestlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtDirection;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private System.Windows.Forms.ComboBox comboBoxSEname;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtReason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxPatientName;
        private Guna.UI2.WinForms.Guna2TextBox gppatienttextbox_search;
        private System.Windows.Forms.Label label_reason;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_name;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView gridview_requestlist;
    }
}