namespace WinFormsMvvmApp.Views.Forms; 

partial class MainForm {
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
    private void InitializeComponent()
    {
        buttonIncrement = new Button();
        labelCounter = new Label();
        SuspendLayout();
        // 
        // buttonIncrement
        // 
        buttonIncrement.Location = new Point(65, 98);
        buttonIncrement.Margin = new Padding(5, 4, 5, 4);
        buttonIncrement.Name = "buttonIncrement";
        buttonIncrement.Size = new Size(202, 61);
        buttonIncrement.TabIndex = 0;
        buttonIncrement.Text = "Increment";
        buttonIncrement.UseVisualStyleBackColor = true;
        // 
        // labelCounter
        // 
        labelCounter.Location = new Point(65, 35);
        labelCounter.Margin = new Padding(5, 0, 5, 0);
        labelCounter.Name = "labelCounter";
        labelCounter.Size = new Size(202, 30);
        labelCounter.TabIndex = 1;
        labelCounter.Text = "labelCounter";
        labelCounter.TextAlign = ContentAlignment.TopCenter;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(12F, 30F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(324, 198);
        Controls.Add(labelCounter);
        Controls.Add(buttonIncrement);
        Margin = new Padding(5, 4, 5, 4);
        Name = "MainForm";
        Text = "Mvvm Windows Form App";
        ResumeLayout(false);
    }

    #endregion

    private Button buttonIncrement;
    private Label labelCounter;
}
