namespace WinFormsMvvmApp.Views.Forms; 

partial class Form1 {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.buttonIncrement = new Button();
        this.labelCounter = new Label();
        this.SuspendLayout();
        // 
        // buttonIncrement
        // 
        this.buttonIncrement.Location = new Point(94, 100);
        this.buttonIncrement.Margin = new Padding(5, 3, 5, 3);
        this.buttonIncrement.Name = "buttonIncrement";
        this.buttonIncrement.Size = new Size(185, 83);
        this.buttonIncrement.TabIndex = 0;
        this.buttonIncrement.Text = "Increment";
        this.buttonIncrement.UseVisualStyleBackColor = true;
        // 
        // labelCounter
        // 
        this.labelCounter.Location = new Point(129, 36);
        this.labelCounter.Margin = new Padding(5, 0, 5, 0);
        this.labelCounter.Name = "labelCounter";
        this.labelCounter.Size = new Size(121, 25);
        this.labelCounter.TabIndex = 1;
        this.labelCounter.Text = "labelCounter";
        this.labelCounter.TextAlign = ContentAlignment.TopCenter;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new SizeF(11F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(361, 215);
        this.Controls.Add(this.labelCounter);
        this.Controls.Add(this.buttonIncrement);
        this.Margin = new Padding(5, 3, 5, 3);
        this.Name = "Form1";
        this.Text = "Form1";
        this.ResumeLayout(false);
    }

    #endregion

    private Button buttonIncrement;
    private Label labelCounter;
}
