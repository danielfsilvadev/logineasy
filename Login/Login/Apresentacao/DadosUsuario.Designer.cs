namespace Login.Apresentacao
{
  partial class DadosUsuario
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DadosUsuario));
      this.label1 = new System.Windows.Forms.Label();
      this.txtDLogin = new System.Windows.Forms.TextBox();
      this.btnCadastrarUsuario = new System.Windows.Forms.Button();
      this.txtDSenha = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtDConfirma = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      // 
      // txtDLogin
      // 
      resources.ApplyResources(this.txtDLogin, "txtDLogin");
      this.txtDLogin.Name = "txtDLogin";
      // 
      // btnCadastrarUsuario
      // 
      resources.ApplyResources(this.btnCadastrarUsuario, "btnCadastrarUsuario");
      this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
      this.btnCadastrarUsuario.UseVisualStyleBackColor = true;
      this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
      // 
      // txtDSenha
      // 
      resources.ApplyResources(this.txtDSenha, "txtDSenha");
      this.txtDSenha.Name = "txtDSenha";
      this.txtDSenha.TextChanged += new System.EventHandler(this.txtDSenha_TextChanged);
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // txtDConfirma
      // 
      resources.ApplyResources(this.txtDConfirma, "txtDConfirma");
      this.txtDConfirma.Name = "txtDConfirma";
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.Name = "label3";
      // 
      // DadosUsuario
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.txtDConfirma);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtDSenha);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnCadastrarUsuario);
      this.Controls.Add(this.txtDLogin);
      this.Controls.Add(this.label1);
      this.Name = "DadosUsuario";
      this.Load += new System.EventHandler(this.DadosUsuario_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtDLogin;
    private System.Windows.Forms.Button btnCadastrarUsuario;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    public System.Windows.Forms.TextBox txtDSenha;
    public System.Windows.Forms.TextBox txtDConfirma;
  }
}