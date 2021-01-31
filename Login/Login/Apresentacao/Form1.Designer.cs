namespace Login
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.btnEntrar = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.campoUsuario = new System.Windows.Forms.TextBox();
      this.campoSenha = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.btnAcesso = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnEntrar
      // 
      resources.ApplyResources(this.btnEntrar, "btnEntrar");
      this.btnEntrar.Name = "btnEntrar";
      this.btnEntrar.UseVisualStyleBackColor = false;
      this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label1.Name = "label1";
      // 
      // campoUsuario
      // 
      resources.ApplyResources(this.campoUsuario, "campoUsuario");
      this.campoUsuario.Name = "campoUsuario";
      this.campoUsuario.TextChanged += new System.EventHandler(this.campoUsuario_TextChanged);
      // 
      // campoSenha
      // 
      resources.ApplyResources(this.campoSenha, "campoSenha");
      this.campoSenha.Name = "campoSenha";
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label2.Name = "label2";
      // 
      // btnCancelar
      // 
      resources.ApplyResources(this.btnCancelar, "btnCancelar");
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.UseVisualStyleBackColor = false;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.BackColor = System.Drawing.Color.Transparent;
      this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
      this.label3.Name = "label3";
      this.label3.UseWaitCursor = true;
      // 
      // btnAcesso
      // 
      resources.ApplyResources(this.btnAcesso, "btnAcesso");
      this.btnAcesso.BackColor = System.Drawing.Color.Transparent;
      this.btnAcesso.ForeColor = System.Drawing.SystemColors.ActiveCaption;
      this.btnAcesso.Name = "btnAcesso";
      this.btnAcesso.Click += new System.EventHandler(this.btnAcesso_Click);
      // 
      // label4
      // 
      resources.ApplyResources(this.label4, "label4");
      this.label4.Name = "label4";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label4);
      resources.ApplyResources(this.groupBox1, "groupBox1");
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.TabStop = false;
      // 
      // Form1
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnAcesso);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.campoSenha);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.campoUsuario);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnEntrar);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnEntrar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox campoUsuario;
    private System.Windows.Forms.TextBox campoSenha;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label btnAcesso;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.GroupBox groupBox1;
  }
}

