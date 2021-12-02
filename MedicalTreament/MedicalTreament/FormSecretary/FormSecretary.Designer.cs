
namespace MedicalTreament
{
    partial class FormSecretary
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnPatients = new Guna.UI2.WinForms.Guna2Button();
            this.btnReception = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.labelName = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.PanelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.btnLogout);
            this.guna2Panel1.Controls.Add(this.btnPatients);
            this.guna2Panel1.Controls.Add(this.btnReception);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.labelName);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(266, 653);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.Image = global::MedicalTreament.Properties.Resources.baseline_logout_white_24dp;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = global::MedicalTreament.Properties.Resources.outline_logout_black_24dp;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogout.Location = new System.Drawing.Point(23, 331);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(228, 57);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btn_click);
            // 
            // btnPatients
            // 
            this.btnPatients.CheckedState.Parent = this.btnPatients;
            this.btnPatients.CustomImages.Parent = this.btnPatients;
            this.btnPatients.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btnPatients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.ForeColor = System.Drawing.Color.White;
            this.btnPatients.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btnPatients.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnPatients.HoverState.Image = global::MedicalTreament.Properties.Resources.baseline_groups_white_24dp;
            this.btnPatients.HoverState.Parent = this.btnPatients;
            this.btnPatients.Image = global::MedicalTreament.Properties.Resources.baseline_groups_white_24dp;
            this.btnPatients.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPatients.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPatients.Location = new System.Drawing.Point(23, 205);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.ShadowDecoration.Parent = this.btnPatients;
            this.btnPatients.Size = new System.Drawing.Size(228, 57);
            this.btnPatients.TabIndex = 4;
            this.btnPatients.Text = "Patients";
            this.btnPatients.Click += new System.EventHandler(this.btn_click);
            // 
            // btnReception
            // 
            this.btnReception.CheckedState.Parent = this.btnReception;
            this.btnReception.CustomImages.Parent = this.btnReception;
            this.btnReception.FillColor = System.Drawing.Color.White;
            this.btnReception.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReception.ForeColor = System.Drawing.Color.Black;
            this.btnReception.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btnReception.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnReception.HoverState.Image = global::MedicalTreament.Properties.Resources.baseline_receipt_white_24dp;
            this.btnReception.HoverState.Parent = this.btnReception;
            this.btnReception.Image = global::MedicalTreament.Properties.Resources.outline_receipt_black_24dp;
            this.btnReception.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReception.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReception.Location = new System.Drawing.Point(23, 268);
            this.btnReception.Name = "btnReception";
            this.btnReception.ShadowDecoration.Parent = this.btnReception;
            this.btnReception.Size = new System.Drawing.Size(228, 57);
            this.btnReception.TabIndex = 3;
            this.btnReception.Text = "Reception";
            this.btnReception.Click += new System.EventHandler(this.btn_click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(23, 164);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(228, 15);
            this.guna2Separator1.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelName.Location = new System.Drawing.Point(23, 144);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(228, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Secretary";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::MedicalTreament.Properties.Resources.nurse_64;
            this.guna2CirclePictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(63, 28);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(141, 113);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.gunaSeparator1);
            this.guna2Panel2.Controls.Add(this.gunaControlBox3);
            this.guna2Panel2.Controls.Add(this.gunaControlBox2);
            this.guna2Panel2.Controls.Add(this.gunaControlBox1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2Panel2.Location = new System.Drawing.Point(266, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1016, 48);
            this.guna2Panel2.TabIndex = 3;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.gunaSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(0, 38);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(1016, 10);
            this.gunaSeparator1.TabIndex = 0;
            // 
            // gunaControlBox3
            // 
            this.gunaControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox3.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox3.AnimationSpeed = 0.03F;
            this.gunaControlBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.gunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox3.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox3.IconSize = 15F;
            this.gunaControlBox3.Location = new System.Drawing.Point(869, 0);
            this.gunaControlBox3.Name = "gunaControlBox3";
            this.gunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox3.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox3.Size = new System.Drawing.Size(45, 41);
            this.gunaControlBox3.TabIndex = 3;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(920, 0);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 41);
            this.gunaControlBox2.TabIndex = 3;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(971, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 41);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // PanelContainer
            // 
            this.PanelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.PanelContainer.Location = new System.Drawing.Point(266, 47);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.ShadowDecoration.Parent = this.PanelContainer;
            this.PanelContainer.Size = new System.Drawing.Size(1016, 606);
            this.PanelContainer.TabIndex = 4;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2Panel2;
            // 
            // FormSecretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSecretary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSecretary";
            this.Load += new System.EventHandler(this.FormSecretary_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnPatients;
        private Guna.UI2.WinForms.Guna2Button btnReception;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI2.WinForms.Guna2Panel PanelContainer;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}