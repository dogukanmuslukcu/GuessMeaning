namespace GuessMeaning;

public partial class Form1 : Form
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.labelWord = new System.Windows.Forms.Label();
        this.txtMeaning = new System.Windows.Forms.TextBox();
        this.btnCheck = new System.Windows.Forms.Button();
        this.btnNext = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // labelWord
        // 
        this.labelWord.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.labelWord.Location = new System.Drawing.Point(12, 9);
        this.labelWord.Name = "labelWord";
        this.labelWord.Size = new System.Drawing.Size(426, 50);
        this.labelWord.TabIndex = 0;
        this.labelWord.Text = "English Word";
        this.labelWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtMeaning
        // 
        this.txtMeaning.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtMeaning.Location = new System.Drawing.Point(12, 79);
        this.txtMeaning.Name = "txtMeaning";
        this.txtMeaning.Size = new System.Drawing.Size(426, 39);
        this.txtMeaning.TabIndex = 1;
        // 
        // btnCheck
        // 
        this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnCheck.Location = new System.Drawing.Point(12, 132);
        this.btnCheck.Name = "btnCheck";
        this.btnCheck.Size = new System.Drawing.Size(98, 39);
        this.btnCheck.TabIndex = 2;
        this.btnCheck.Text = "Kontrol Et";
        this.btnCheck.UseVisualStyleBackColor = true;
        this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
        // 
        // btnNext
        // 
        this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnNext.Location = new System.Drawing.Point(340, 132);
        this.btnNext.Name = "btnNext";
        this.btnNext.Size = new System.Drawing.Size(98, 39);
        this.btnNext.TabIndex = 3;
        this.btnNext.Text = "Yeni Kelime";
        this.btnNext.UseVisualStyleBackColor = true;
        this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
        // 
        // FormGame
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(450, 191);
        this.Controls.Add(this.btnNext);
        this.Controls.Add(this.btnCheck);
        this.Controls.Add(this.txtMeaning);
        this.Controls.Add(this.labelWord);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FormGame";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Kelime Oyunu";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGame_FormClosing);
        this.Load += new System.EventHandler(this.FormGame_Load);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelWord;
    private System.Windows.Forms.TextBox txtMeaning;
    private System.Windows.Forms.Button btnCheck;
    private System.Windows.Forms.Button btnNext;
}