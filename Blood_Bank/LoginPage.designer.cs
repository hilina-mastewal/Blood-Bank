
namespace Blood_Bank
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panLtask = new Guna.UI.WinForms.GunaPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnLexit = new Guna.UI.WinForms.GunaImageButton();
            this.btnLmax = new Guna.UI.WinForms.GunaImageButton();
            this.btnLmin = new Guna.UI.WinForms.GunaImageButton();
            this.panLlogin = new Guna.UI2.WinForms.Guna2Panel();
            this.panLlog = new Guna.UI2.WinForms.Guna2Panel();
            this.chLshowpwd = new Guna.UI2.WinForms.Guna2CheckBox();
            this.llbLcreate = new System.Windows.Forms.LinkLabel();
            this.btnLSignIn = new Guna.UI.WinForms.GunaButton();
            this.txtLpwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.panLtask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panLlogin.SuspendLayout();
            this.panLlog.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panLtask;
            // 
            // panLtask
            // 
            this.panLtask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panLtask.BackColor = System.Drawing.Color.Firebrick;
            this.panLtask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panLtask.Controls.Add(this.guna2HtmlLabel1);
            this.panLtask.Controls.Add(this.guna2PictureBox1);
            this.panLtask.Controls.Add(this.btnLexit);
            this.panLtask.Controls.Add(this.btnLmax);
            this.panLtask.Controls.Add(this.btnLmin);
            this.panLtask.Location = new System.Drawing.Point(0, 0);
            this.panLtask.Name = "panLtask";
            this.panLtask.Size = new System.Drawing.Size(886, 26);
            this.panLtask.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(346, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(214, 17);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "Blood Bank Management System";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Firebrick;
            this.guna2PictureBox1.BackgroundImage = global::Blood_Bank.Properties.Resources.iconmonstr_drop_13_24;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 1);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(29, 22);
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnLexit
            // 
            this.btnLexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLexit.BackColor = System.Drawing.Color.Firebrick;
            this.btnLexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLexit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLexit.Image = ((System.Drawing.Image)(resources.GetObject("btnLexit.Image")));
            this.btnLexit.ImageSize = new System.Drawing.Size(10, 10);
            this.btnLexit.Location = new System.Drawing.Point(852, 6);
            this.btnLexit.Name = "btnLexit";
            this.btnLexit.OnHoverImage = null;
            this.btnLexit.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnLexit.Size = new System.Drawing.Size(22, 17);
            this.btnLexit.TabIndex = 7;
            this.btnLexit.Click += new System.EventHandler(this.btnLexit_Click);
            this.btnLexit.MouseEnter += new System.EventHandler(this.btnMexit_MouseEnter);
            this.btnLexit.MouseLeave += new System.EventHandler(this.btnMexit_MouseLeave);
            // 
            // btnLmax
            // 
            this.btnLmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLmax.BackColor = System.Drawing.Color.Firebrick;
            this.btnLmax.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLmax.Image = global::Blood_Bank.Properties.Resources.iconmonstr_fullscreen_thin_24;
            this.btnLmax.ImageSize = new System.Drawing.Size(16, 16);
            this.btnLmax.Location = new System.Drawing.Point(822, 6);
            this.btnLmax.Name = "btnLmax";
            this.btnLmax.OnHoverImage = null;
            this.btnLmax.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnLmax.Size = new System.Drawing.Size(24, 17);
            this.btnLmax.TabIndex = 6;
            this.btnLmax.Click += new System.EventHandler(this.btnLmax_Click);
            this.btnLmax.MouseEnter += new System.EventHandler(this.gunaImageButton2_MouseEnter);
            this.btnLmax.MouseLeave += new System.EventHandler(this.gunaImageButton2_MouseLeave);
            // 
            // btnLmin
            // 
            this.btnLmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLmin.BackColor = System.Drawing.Color.Firebrick;
            this.btnLmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLmin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLmin.Image = ((System.Drawing.Image)(resources.GetObject("btnLmin.Image")));
            this.btnLmin.ImageSize = new System.Drawing.Size(16, 16);
            this.btnLmin.Location = new System.Drawing.Point(794, 6);
            this.btnLmin.Name = "btnLmin";
            this.btnLmin.OnHoverImage = null;
            this.btnLmin.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnLmin.Size = new System.Drawing.Size(22, 17);
            this.btnLmin.TabIndex = 5;
            this.btnLmin.Click += new System.EventHandler(this.btnLmin_Click);
            this.btnLmin.MouseEnter += new System.EventHandler(this.btnLmin_MouseEnter);
            this.btnLmin.MouseLeave += new System.EventHandler(this.gunaImageButton1_MouseLeave);
            // 
            // panLlogin
            // 
            this.panLlogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panLlogin.BackColor = System.Drawing.Color.Firebrick;
            this.panLlogin.BackgroundImage = global::Blood_Bank.Properties.Resources.i01_bloodwall2;
            this.panLlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panLlogin.BorderColor = System.Drawing.Color.Firebrick;
            this.panLlogin.BorderThickness = 2;
            this.panLlogin.Controls.Add(this.panLtask);
            this.panLlogin.Controls.Add(this.panLlog);
            this.panLlogin.Location = new System.Drawing.Point(0, 0);
            this.panLlogin.Margin = new System.Windows.Forms.Padding(2);
            this.panLlogin.Name = "panLlogin";
            this.panLlogin.ShadowDecoration.BorderRadius = 10;
            this.panLlogin.ShadowDecoration.Depth = 50;
            this.panLlogin.ShadowDecoration.Enabled = true;
            this.panLlogin.ShadowDecoration.Parent = this.panLlogin;
            this.panLlogin.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.panLlogin.Size = new System.Drawing.Size(886, 548);
            this.panLlogin.TabIndex = 0;
            // 
            // panLlog
            // 
            this.panLlog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panLlog.BackColor = System.Drawing.SystemColors.Control;
            this.panLlog.Controls.Add(this.chLshowpwd);
            this.panLlog.Controls.Add(this.llbLcreate);
            this.panLlog.Controls.Add(this.btnLSignIn);
            this.panLlog.Controls.Add(this.txtLpwd);
            this.panLlog.Controls.Add(this.txtLusername);
            this.panLlog.Location = new System.Drawing.Point(292, 243);
            this.panLlog.Margin = new System.Windows.Forms.Padding(2);
            this.panLlog.Name = "panLlog";
            this.panLlog.ShadowDecoration.Parent = this.panLlog;
            this.panLlog.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.panLlog.Size = new System.Drawing.Size(325, 251);
            this.panLlog.TabIndex = 0;
            // 
            // chLshowpwd
            // 
            this.chLshowpwd.AutoSize = true;
            this.chLshowpwd.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chLshowpwd.CheckedState.BorderRadius = 0;
            this.chLshowpwd.CheckedState.BorderThickness = 0;
            this.chLshowpwd.CheckedState.FillColor = System.Drawing.Color.Firebrick;
            this.chLshowpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chLshowpwd.Location = new System.Drawing.Point(42, 132);
            this.chLshowpwd.Name = "chLshowpwd";
            this.chLshowpwd.Size = new System.Drawing.Size(102, 17);
            this.chLshowpwd.TabIndex = 6;
            this.chLshowpwd.Text = "Show Password";
            this.chLshowpwd.UncheckedState.BorderColor = System.Drawing.Color.Firebrick;
            this.chLshowpwd.UncheckedState.BorderRadius = 1;
            this.chLshowpwd.UncheckedState.BorderThickness = 1;
            this.chLshowpwd.UncheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.chLshowpwd.CheckedChanged += new System.EventHandler(this.chLshowpwd_CheckedChanged);
            // 
            // llbLcreate
            // 
            this.llbLcreate.AutoSize = true;
            this.llbLcreate.LinkColor = System.Drawing.Color.Firebrick;
            this.llbLcreate.Location = new System.Drawing.Point(123, 214);
            this.llbLcreate.Name = "llbLcreate";
            this.llbLcreate.Size = new System.Drawing.Size(81, 13);
            this.llbLcreate.TabIndex = 5;
            this.llbLcreate.TabStop = true;
            this.llbLcreate.Text = "Create Account";
            this.llbLcreate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnLSignIn
            // 
            this.btnLSignIn.AnimationHoverSpeed = 0.07F;
            this.btnLSignIn.AnimationSpeed = 0.03F;
            this.btnLSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLSignIn.BaseColor = System.Drawing.Color.Firebrick;
            this.btnLSignIn.BorderColor = System.Drawing.Color.Black;
            this.btnLSignIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLSignIn.FocusedColor = System.Drawing.Color.Empty;
            this.btnLSignIn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLSignIn.ForeColor = System.Drawing.Color.White;
            this.btnLSignIn.Image = null;
            this.btnLSignIn.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLSignIn.Location = new System.Drawing.Point(42, 165);
            this.btnLSignIn.Name = "btnLSignIn";
            this.btnLSignIn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLSignIn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLSignIn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLSignIn.OnHoverImage = null;
            this.btnLSignIn.OnPressedColor = System.Drawing.Color.Black;
            this.btnLSignIn.Radius = 4;
            this.btnLSignIn.Size = new System.Drawing.Size(245, 35);
            this.btnLSignIn.TabIndex = 4;
            this.btnLSignIn.Text = "Sign In";
            this.btnLSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtLpwd
            // 
            this.txtLpwd.BorderColor = System.Drawing.Color.White;
            this.txtLpwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLpwd.DefaultText = "";
            this.txtLpwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLpwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLpwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLpwd.DisabledState.Parent = this.txtLpwd;
            this.txtLpwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLpwd.FillColor = System.Drawing.Color.Gainsboro;
            this.txtLpwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLpwd.FocusedState.Parent = this.txtLpwd;
            this.txtLpwd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLpwd.ForeColor = System.Drawing.Color.Black;
            this.txtLpwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLpwd.HoverState.Parent = this.txtLpwd;
            this.txtLpwd.Location = new System.Drawing.Point(42, 91);
            this.txtLpwd.Margin = new System.Windows.Forms.Padding(2);
            this.txtLpwd.Name = "txtLpwd";
            this.txtLpwd.PasswordChar = '\0';
            this.txtLpwd.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtLpwd.PlaceholderText = "password";
            this.txtLpwd.SelectedText = "";
            this.txtLpwd.ShadowDecoration.Parent = this.txtLpwd;
            this.txtLpwd.Size = new System.Drawing.Size(245, 36);
            this.txtLpwd.TabIndex = 1;
            this.txtLpwd.UseSystemPasswordChar = true;
            // 
            // txtLusername
            // 
            this.txtLusername.BackColor = System.Drawing.Color.Transparent;
            this.txtLusername.BorderColor = System.Drawing.Color.Snow;
            this.txtLusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLusername.DefaultText = "";
            this.txtLusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLusername.DisabledState.Parent = this.txtLusername;
            this.txtLusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLusername.FillColor = System.Drawing.Color.Gainsboro;
            this.txtLusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLusername.FocusedState.Parent = this.txtLusername;
            this.txtLusername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLusername.ForeColor = System.Drawing.Color.Black;
            this.txtLusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLusername.HoverState.Parent = this.txtLusername;
            this.txtLusername.Location = new System.Drawing.Point(42, 27);
            this.txtLusername.Margin = new System.Windows.Forms.Padding(2);
            this.txtLusername.Name = "txtLusername";
            this.txtLusername.PasswordChar = '\0';
            this.txtLusername.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtLusername.PlaceholderText = "username";
            this.txtLusername.SelectedText = "";
            this.txtLusername.ShadowDecoration.Parent = this.txtLusername;
            this.txtLusername.Size = new System.Drawing.Size(245, 36);
            this.txtLusername.TabIndex = 0;
            this.txtLusername.Click += new System.EventHandler(this.txtLusername_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 548);
            this.Controls.Add(this.panLlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(200, 50);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1366, 738);
            this.Name = "LoginPage";
            this.Text = "Form1";
            this.panLtask.ResumeLayout(false);
            this.panLtask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panLlogin.ResumeLayout(false);
            this.panLlog.ResumeLayout(false);
            this.panLlog.PerformLayout();
            this.ResumeLayout(false);

        }

        private void CreatePage()
        {

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panLlogin;
        private Guna.UI2.WinForms.Guna2Panel panLlog;
        private Guna.UI2.WinForms.Guna2TextBox txtLpwd;
        private Guna.UI2.WinForms.Guna2TextBox txtLusername;
        private Guna.UI.WinForms.GunaButton btnLSignIn;
        private System.Windows.Forms.LinkLabel llbLcreate;
        private Guna.UI.WinForms.GunaPanel panLtask;
        private Guna.UI.WinForms.GunaImageButton btnLexit;
        private Guna.UI.WinForms.GunaImageButton btnLmax;
        private Guna.UI.WinForms.GunaImageButton btnLmin;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CheckBox chLshowpwd;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}

