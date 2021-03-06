
namespace MedicalTreament
{
    partial class FormRegister
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
            this.textbox_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_signup = new Guna.UI2.WinForms.Guna2Button();
            this.label_username = new Guna.UI.WinForms.GunaLabel();
            this.label_password = new Guna.UI.WinForms.GunaLabel();
            this.textbox_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_confirmedpassword = new Guna.UI.WinForms.GunaLabel();
            this.textbox_confirmedpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_role = new Guna.UI.WinForms.GunaLabel();
            this.combobox_role = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_title = new Guna.UI.WinForms.GunaLabel();
            this.controlbox_exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.controlbox_minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // textbox_username
            // 
            this.textbox_username.BorderColor = System.Drawing.Color.OrangeRed;
            this.textbox_username.BorderRadius = 8;
            this.textbox_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_username.DefaultText = "";
            this.textbox_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_username.DisabledState.Parent = this.textbox_username;
            this.textbox_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_username.FillColor = System.Drawing.Color.LightGray;
            this.textbox_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_username.FocusedState.Parent = this.textbox_username;
            this.textbox_username.ForeColor = System.Drawing.Color.Black;
            this.textbox_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_username.HoverState.Parent = this.textbox_username;
            this.textbox_username.Location = new System.Drawing.Point(130, 123);
            this.textbox_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_username.Name = "textbox_username";
            this.textbox_username.PasswordChar = '\0';
            this.textbox_username.PlaceholderForeColor = System.Drawing.Color.White;
            this.textbox_username.PlaceholderText = "";
            this.textbox_username.SelectedText = "";
            this.textbox_username.ShadowDecoration.Parent = this.textbox_username;
            this.textbox_username.Size = new System.Drawing.Size(267, 44);
            this.textbox_username.TabIndex = 1;
            // 
            // btn_signup
            // 
            this.btn_signup.CheckedState.Parent = this.btn_signup;
            this.btn_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_signup.CustomImages.Parent = this.btn_signup;
            this.btn_signup.FillColor = System.Drawing.Color.OrangeRed;
            this.btn_signup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.Color.Black;
            this.btn_signup.HoverState.Parent = this.btn_signup;
            this.btn_signup.Location = new System.Drawing.Point(189, 492);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.ShadowDecoration.Parent = this.btn_signup;
            this.btn_signup.Size = new System.Drawing.Size(149, 45);
            this.btn_signup.TabIndex = 4;
            this.btn_signup.Text = "Sign Up";
            // 
            // label_username
            // 
            this.label_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_username.AutoSize = true;
            this.label_username.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_username.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_username.Location = new System.Drawing.Point(126, 99);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(75, 20);
            this.label_username.TabIndex = 2;
            this.label_username.Text = "Username";
            // 
            // label_password
            // 
            this.label_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_password.AutoSize = true;
            this.label_password.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_password.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_password.Location = new System.Drawing.Point(126, 180);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(70, 20);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Password";
            // 
            // textbox_password
            // 
            this.textbox_password.BorderColor = System.Drawing.Color.OrangeRed;
            this.textbox_password.BorderRadius = 8;
            this.textbox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_password.DefaultText = "";
            this.textbox_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_password.DisabledState.Parent = this.textbox_password;
            this.textbox_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_password.FillColor = System.Drawing.Color.LightGray;
            this.textbox_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_password.FocusedState.Parent = this.textbox_password;
            this.textbox_password.ForeColor = System.Drawing.Color.Black;
            this.textbox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_password.HoverState.Parent = this.textbox_password;
            this.textbox_password.Location = new System.Drawing.Point(130, 204);
            this.textbox_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '\0';
            this.textbox_password.PlaceholderText = "";
            this.textbox_password.SelectedText = "";
            this.textbox_password.ShadowDecoration.Parent = this.textbox_password;
            this.textbox_password.Size = new System.Drawing.Size(267, 44);
            this.textbox_password.TabIndex = 2;
            // 
            // label_confirmedpassword
            // 
            this.label_confirmedpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_confirmedpassword.AutoSize = true;
            this.label_confirmedpassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_confirmedpassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_confirmedpassword.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_confirmedpassword.Location = new System.Drawing.Point(126, 264);
            this.label_confirmedpassword.Name = "label_confirmedpassword";
            this.label_confirmedpassword.Size = new System.Drawing.Size(144, 20);
            this.label_confirmedpassword.TabIndex = 6;
            this.label_confirmedpassword.Text = "Confirmed Password";
            // 
            // textbox_confirmedpassword
            // 
            this.textbox_confirmedpassword.BorderColor = System.Drawing.Color.OrangeRed;
            this.textbox_confirmedpassword.BorderRadius = 8;
            this.textbox_confirmedpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_confirmedpassword.DefaultText = "";
            this.textbox_confirmedpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_confirmedpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_confirmedpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_confirmedpassword.DisabledState.Parent = this.textbox_confirmedpassword;
            this.textbox_confirmedpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_confirmedpassword.FillColor = System.Drawing.Color.LightGray;
            this.textbox_confirmedpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_confirmedpassword.FocusedState.Parent = this.textbox_confirmedpassword;
            this.textbox_confirmedpassword.ForeColor = System.Drawing.Color.Black;
            this.textbox_confirmedpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_confirmedpassword.HoverState.Parent = this.textbox_confirmedpassword;
            this.textbox_confirmedpassword.Location = new System.Drawing.Point(130, 288);
            this.textbox_confirmedpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_confirmedpassword.Name = "textbox_confirmedpassword";
            this.textbox_confirmedpassword.PasswordChar = '\0';
            this.textbox_confirmedpassword.PlaceholderText = "";
            this.textbox_confirmedpassword.SelectedText = "";
            this.textbox_confirmedpassword.ShadowDecoration.Parent = this.textbox_confirmedpassword;
            this.textbox_confirmedpassword.Size = new System.Drawing.Size(267, 44);
            this.textbox_confirmedpassword.TabIndex = 3;
            // 
            // label_role
            // 
            this.label_role.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_role.AutoSize = true;
            this.label_role.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_role.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_role.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_role.Location = new System.Drawing.Point(126, 354);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(39, 20);
            this.label_role.TabIndex = 7;
            this.label_role.Text = "Role";
            // 
            // combobox_role
            // 
            this.combobox_role.BackColor = System.Drawing.Color.OrangeRed;
            this.combobox_role.BorderColor = System.Drawing.Color.OrangeRed;
            this.combobox_role.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combobox_role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.combobox_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_role.FillColor = System.Drawing.Color.LightGray;
            this.combobox_role.FocusedColor = System.Drawing.Color.Empty;
            this.combobox_role.FocusedState.Parent = this.combobox_role;
            this.combobox_role.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combobox_role.ForeColor = System.Drawing.Color.Black;
            this.combobox_role.FormattingEnabled = true;
            this.combobox_role.HoverState.Parent = this.combobox_role;
            this.combobox_role.ItemHeight = 30;
            this.combobox_role.Items.AddRange(new object[] {
            "General Practitional",
            "Specialist",
            "Secretary",
            "Pharmacist"});
            this.combobox_role.ItemsAppearance.Parent = this.combobox_role;
            this.combobox_role.Location = new System.Drawing.Point(130, 387);
            this.combobox_role.Name = "combobox_role";
            this.combobox_role.ShadowDecoration.Parent = this.combobox_role;
            this.combobox_role.Size = new System.Drawing.Size(267, 36);
            this.combobox_role.TabIndex = 8;
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title.AutoSize = true;
            this.label_title.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_title.Location = new System.Drawing.Point(182, 28);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(191, 41);
            this.label_title.TabIndex = 9;
            this.label_title.Text = "Registration";
            // 
            // controlbox_exit
            // 
            this.controlbox_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlbox_exit.FillColor = System.Drawing.Color.Gainsboro;
            this.controlbox_exit.HoverState.Parent = this.controlbox_exit;
            this.controlbox_exit.IconColor = System.Drawing.Color.OrangeRed;
            this.controlbox_exit.Location = new System.Drawing.Point(474, 0);
            this.controlbox_exit.Name = "controlbox_exit";
            this.controlbox_exit.ShadowDecoration.Parent = this.controlbox_exit;
            this.controlbox_exit.Size = new System.Drawing.Size(45, 29);
            this.controlbox_exit.TabIndex = 10;
            // 
            // controlbox_minimize
            // 
            this.controlbox_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlbox_minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.controlbox_minimize.FillColor = System.Drawing.Color.Gainsboro;
            this.controlbox_minimize.HoverState.Parent = this.controlbox_minimize;
            this.controlbox_minimize.IconColor = System.Drawing.Color.OrangeRed;
            this.controlbox_minimize.Location = new System.Drawing.Point(423, 0);
            this.controlbox_minimize.Name = "controlbox_minimize";
            this.controlbox_minimize.ShadowDecoration.Parent = this.controlbox_minimize;
            this.controlbox_minimize.Size = new System.Drawing.Size(45, 29);
            this.controlbox_minimize.TabIndex = 11;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 582);
            this.Controls.Add(this.controlbox_minimize);
            this.Controls.Add(this.controlbox_exit);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.combobox_role);
            this.Controls.Add(this.label_role);
            this.Controls.Add(this.label_confirmedpassword);
            this.Controls.Add(this.textbox_confirmedpassword);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.textbox_username);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textbox_username;
        private Guna.UI2.WinForms.Guna2Button btn_signup;
        private Guna.UI.WinForms.GunaLabel label_username;
        private Guna.UI.WinForms.GunaLabel label_password;
        private Guna.UI2.WinForms.Guna2TextBox textbox_password;
        private Guna.UI.WinForms.GunaLabel label_confirmedpassword;
        private Guna.UI2.WinForms.Guna2TextBox textbox_confirmedpassword;
        private Guna.UI.WinForms.GunaLabel label_role;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_role;
        private Guna.UI.WinForms.GunaLabel label_title;
        private Guna.UI2.WinForms.Guna2ControlBox controlbox_exit;
        private Guna.UI2.WinForms.Guna2ControlBox controlbox_minimize;
    }
}