
namespace Compiler
{
    partial class formCompiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCompiler));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseSystem = new Guna.UI.WinForms.GunaButton();
            this.txtCodeTextArea = new Guna.UI.WinForms.GunaTextBox();
            this.btnOpenFile = new Guna.UI.WinForms.GunaButton();
            this.btnLexicalAnalysis = new Guna.UI.WinForms.GunaButton();
            this.btnSyntaxAnalysis = new Guna.UI.WinForms.GunaButton();
            this.btnSemanticAnalysis = new Guna.UI.WinForms.GunaButton();
            this.btnClear = new Guna.UI.WinForms.GunaButton();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaPanel1.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(113)))), ((int)(((byte)(150)))));
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Controls.Add(this.btnCloseSystem);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(800, 39);
            this.gunaPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Compiler";
            // 
            // btnCloseSystem
            // 
            this.btnCloseSystem.AnimationHoverSpeed = 0.07F;
            this.btnCloseSystem.AnimationSpeed = 0.03F;
            this.btnCloseSystem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(113)))), ((int)(((byte)(150)))));
            this.btnCloseSystem.BorderColor = System.Drawing.Color.Black;
            this.btnCloseSystem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCloseSystem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseSystem.FocusedColor = System.Drawing.Color.Empty;
            this.btnCloseSystem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCloseSystem.ForeColor = System.Drawing.Color.White;
            this.btnCloseSystem.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseSystem.Image")));
            this.btnCloseSystem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCloseSystem.Location = new System.Drawing.Point(759, 0);
            this.btnCloseSystem.Name = "btnCloseSystem";
            this.btnCloseSystem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(113)))), ((int)(((byte)(150)))));
            this.btnCloseSystem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCloseSystem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCloseSystem.OnHoverImage = null;
            this.btnCloseSystem.OnPressedColor = System.Drawing.Color.Black;
            this.btnCloseSystem.Size = new System.Drawing.Size(41, 39);
            this.btnCloseSystem.TabIndex = 1;
            this.btnCloseSystem.Text = "gunaButton1";
            this.btnCloseSystem.Click += new System.EventHandler(this.btnCloseSystem_Click);
            // 
            // txtCodeTextArea
            // 
            this.txtCodeTextArea.BackColor = System.Drawing.Color.Transparent;
            this.txtCodeTextArea.BaseColor = System.Drawing.Color.White;
            this.txtCodeTextArea.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(113)))), ((int)(((byte)(150)))));
            this.txtCodeTextArea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodeTextArea.Enabled = false;
            this.txtCodeTextArea.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCodeTextArea.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCodeTextArea.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodeTextArea.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodeTextArea.Location = new System.Drawing.Point(272, 60);
            this.txtCodeTextArea.Multiline = true;
            this.txtCodeTextArea.Name = "txtCodeTextArea";
            this.txtCodeTextArea.PasswordChar = '\0';
            this.txtCodeTextArea.Radius = 6;
            this.txtCodeTextArea.SelectedText = "";
            this.txtCodeTextArea.Size = new System.Drawing.Size(505, 319);
            this.txtCodeTextArea.TabIndex = 12;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.AnimationHoverSpeed = 0.07F;
            this.btnOpenFile.AnimationSpeed = 0.03F;
            this.btnOpenFile.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenFile.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(113)))), ((int)(((byte)(150)))));
            this.btnOpenFile.BorderColor = System.Drawing.Color.Black;
            this.btnOpenFile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOpenFile.FocusedColor = System.Drawing.Color.Empty;
            this.btnOpenFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.ForeColor = System.Drawing.Color.White;
            this.btnOpenFile.Image = null;
            this.btnOpenFile.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOpenFile.Location = new System.Drawing.Point(33, 34);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(113)))), ((int)(((byte)(150)))));
            this.btnOpenFile.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOpenFile.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOpenFile.OnHoverImage = null;
            this.btnOpenFile.OnPressedColor = System.Drawing.Color.Black;
            this.btnOpenFile.Radius = 18;
            this.btnOpenFile.Size = new System.Drawing.Size(170, 40);
            this.btnOpenFile.TabIndex = 14;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click_1);
            // 
            // btnLexicalAnalysis
            // 
            this.btnLexicalAnalysis.AnimationHoverSpeed = 0.07F;
            this.btnLexicalAnalysis.AnimationSpeed = 0.03F;
            this.btnLexicalAnalysis.BackColor = System.Drawing.Color.Transparent;
            this.btnLexicalAnalysis.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(113)))), ((int)(((byte)(150)))));
            this.btnLexicalAnalysis.BorderColor = System.Drawing.Color.Black;
            this.btnLexicalAnalysis.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLexicalAnalysis.Enabled = false;
            this.btnLexicalAnalysis.FocusedColor = System.Drawing.Color.Empty;
            this.btnLexicalAnalysis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLexicalAnalysis.ForeColor = System.Drawing.Color.White;
            this.btnLexicalAnalysis.Image = null;
            this.btnLexicalAnalysis.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLexicalAnalysis.Location = new System.Drawing.Point(33, 90);
            this.btnLexicalAnalysis.Name = "btnLexicalAnalysis";
            this.btnLexicalAnalysis.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(113)))), ((int)(((byte)(150)))));
            this.btnLexicalAnalysis.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLexicalAnalysis.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLexicalAnalysis.OnHoverImage = null;
            this.btnLexicalAnalysis.OnPressedColor = System.Drawing.Color.Black;
            this.btnLexicalAnalysis.Radius = 18;
            this.btnLexicalAnalysis.Size = new System.Drawing.Size(170, 40);
            this.btnLexicalAnalysis.TabIndex = 15;
            this.btnLexicalAnalysis.Text = "Lexical Analysis";
            this.btnLexicalAnalysis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLexicalAnalysis.Click += new System.EventHandler(this.btnLexicalAnalysis_Click_1);
            // 
            // btnSyntaxAnalysis
            // 
            this.btnSyntaxAnalysis.AnimationHoverSpeed = 0.07F;
            this.btnSyntaxAnalysis.AnimationSpeed = 0.03F;
            this.btnSyntaxAnalysis.BackColor = System.Drawing.Color.Transparent;
            this.btnSyntaxAnalysis.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(113)))), ((int)(((byte)(150)))));
            this.btnSyntaxAnalysis.BorderColor = System.Drawing.Color.Black;
            this.btnSyntaxAnalysis.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSyntaxAnalysis.Enabled = false;
            this.btnSyntaxAnalysis.FocusedColor = System.Drawing.Color.Empty;
            this.btnSyntaxAnalysis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyntaxAnalysis.ForeColor = System.Drawing.Color.White;
            this.btnSyntaxAnalysis.Image = null;
            this.btnSyntaxAnalysis.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSyntaxAnalysis.Location = new System.Drawing.Point(33, 145);
            this.btnSyntaxAnalysis.Name = "btnSyntaxAnalysis";
            this.btnSyntaxAnalysis.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(113)))), ((int)(((byte)(150)))));
            this.btnSyntaxAnalysis.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSyntaxAnalysis.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSyntaxAnalysis.OnHoverImage = null;
            this.btnSyntaxAnalysis.OnPressedColor = System.Drawing.Color.Black;
            this.btnSyntaxAnalysis.Radius = 18;
            this.btnSyntaxAnalysis.Size = new System.Drawing.Size(170, 40);
            this.btnSyntaxAnalysis.TabIndex = 16;
            this.btnSyntaxAnalysis.Text = "Syntax Analysis";
            this.btnSyntaxAnalysis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSyntaxAnalysis.Click += new System.EventHandler(this.btnSyntaxAnalysis_Click);
            // 
            // btnSemanticAnalysis
            // 
            this.btnSemanticAnalysis.AnimationHoverSpeed = 0.07F;
            this.btnSemanticAnalysis.AnimationSpeed = 0.03F;
            this.btnSemanticAnalysis.BackColor = System.Drawing.Color.Transparent;
            this.btnSemanticAnalysis.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(113)))), ((int)(((byte)(150)))));
            this.btnSemanticAnalysis.BorderColor = System.Drawing.Color.Black;
            this.btnSemanticAnalysis.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSemanticAnalysis.Enabled = false;
            this.btnSemanticAnalysis.FocusedColor = System.Drawing.Color.Empty;
            this.btnSemanticAnalysis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemanticAnalysis.ForeColor = System.Drawing.Color.White;
            this.btnSemanticAnalysis.Image = null;
            this.btnSemanticAnalysis.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSemanticAnalysis.Location = new System.Drawing.Point(33, 198);
            this.btnSemanticAnalysis.Name = "btnSemanticAnalysis";
            this.btnSemanticAnalysis.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(113)))), ((int)(((byte)(150)))));
            this.btnSemanticAnalysis.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSemanticAnalysis.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSemanticAnalysis.OnHoverImage = null;
            this.btnSemanticAnalysis.OnPressedColor = System.Drawing.Color.Black;
            this.btnSemanticAnalysis.Radius = 18;
            this.btnSemanticAnalysis.Size = new System.Drawing.Size(170, 40);
            this.btnSemanticAnalysis.TabIndex = 17;
            this.btnSemanticAnalysis.Text = "Semantic Analysis";
            this.btnSemanticAnalysis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSemanticAnalysis.Click += new System.EventHandler(this.btnSemanticAnalysis_Click);
            // 
            // btnClear
            // 
            this.btnClear.AnimationHoverSpeed = 0.07F;
            this.btnClear.AnimationSpeed = 0.03F;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BaseColor = System.Drawing.Color.Firebrick;
            this.btnClear.BorderColor = System.Drawing.Color.Black;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClear.Enabled = false;
            this.btnClear.FocusedColor = System.Drawing.Color.Empty;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = null;
            this.btnClear.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClear.Location = new System.Drawing.Point(31, 251);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClear.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClear.OnHoverImage = null;
            this.btnClear.OnPressedColor = System.Drawing.Color.Black;
            this.btnClear.Radius = 18;
            this.btnClear.Size = new System.Drawing.Size(170, 40);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.btnSyntaxAnalysis);
            this.gunaShadowPanel1.Controls.Add(this.btnOpenFile);
            this.gunaShadowPanel1.Controls.Add(this.btnClear);
            this.gunaShadowPanel1.Controls.Add(this.btnLexicalAnalysis);
            this.gunaShadowPanel1.Controls.Add(this.btnSemanticAnalysis);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(17, 60);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 6;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowDepth = 50;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(237, 319);
            this.gunaShadowPanel1.TabIndex = 20;
            // 
            // formCompiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.txtCodeTextArea);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCompiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compiler Form";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btnCloseSystem;
        internal Guna.UI.WinForms.GunaTextBox txtCodeTextArea;
        private Guna.UI.WinForms.GunaButton btnOpenFile;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnClear;
        private Guna.UI.WinForms.GunaButton btnSemanticAnalysis;
        private Guna.UI.WinForms.GunaButton btnSyntaxAnalysis;
        private Guna.UI.WinForms.GunaButton btnLexicalAnalysis;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
    }
}

