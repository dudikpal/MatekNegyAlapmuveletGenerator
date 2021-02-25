namespace MatekNegyAlapmuveletGenerator
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
      if (disposing && (components != null)) {
        components.Dispose();
      }

      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.checkBoxDivider = new System.Windows.Forms.CheckBox();
      this.checkBoxMultiplication = new System.Windows.Forms.CheckBox();
      this.checkBoxSubtraction = new System.Windows.Forms.CheckBox();
      this.checkBoxAddition = new System.Windows.Forms.CheckBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.numericUpDownOperandsNumber = new System.Windows.Forms.NumericUpDown();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.radioButtonAnyOperator = new System.Windows.Forms.RadioButton();
      this.radioButtonAnyField = new System.Windows.Forms.RadioButton();
      this.radioButtonResultField = new System.Windows.Forms.RadioButton();
      this.buttonExpressionsGenerate = new System.Windows.Forms.Button();
      this.labelMessage = new System.Windows.Forms.Label();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.numericUpDownExpressionsNumber = new System.Windows.Forms.NumericUpDown();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.numericUpDownValueTo = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownValueFrom = new System.Windows.Forms.NumericUpDown();
      this.groupBox6 = new System.Windows.Forms.GroupBox();
      this.buttonPrintToPdf = new System.Windows.Forms.Button();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize) (this.numericUpDownOperandsNumber)).BeginInit();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize) (this.numericUpDownExpressionsNumber)).BeginInit();
      this.groupBox5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize) (this.numericUpDownValueTo)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.numericUpDownValueFrom)).BeginInit();
      this.groupBox6.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.checkBoxDivider);
      this.groupBox1.Controls.Add(this.checkBoxMultiplication);
      this.groupBox1.Controls.Add(this.checkBoxSubtraction);
      this.groupBox1.Controls.Add(this.checkBoxAddition);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
      this.groupBox1.Location = new System.Drawing.Point(26, 30);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(105, 141);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Operátorok";
      // 
      // checkBoxDivider
      // 
      this.checkBoxDivider.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
      this.checkBoxDivider.Location = new System.Drawing.Point(35, 109);
      this.checkBoxDivider.Name = "checkBoxDivider";
      this.checkBoxDivider.Size = new System.Drawing.Size(64, 24);
      this.checkBoxDivider.TabIndex = 3;
      this.checkBoxDivider.Text = " ÷";
      this.checkBoxDivider.UseVisualStyleBackColor = true;
      // 
      // checkBoxMultiplication
      // 
      this.checkBoxMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
      this.checkBoxMultiplication.Location = new System.Drawing.Point(35, 79);
      this.checkBoxMultiplication.Name = "checkBoxMultiplication";
      this.checkBoxMultiplication.Size = new System.Drawing.Size(64, 24);
      this.checkBoxMultiplication.TabIndex = 2;
      this.checkBoxMultiplication.Text = " ×";
      this.checkBoxMultiplication.UseVisualStyleBackColor = true;
      // 
      // checkBoxSubtraction
      // 
      this.checkBoxSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
      this.checkBoxSubtraction.Location = new System.Drawing.Point(35, 49);
      this.checkBoxSubtraction.Name = "checkBoxSubtraction";
      this.checkBoxSubtraction.Size = new System.Drawing.Size(64, 24);
      this.checkBoxSubtraction.TabIndex = 1;
      this.checkBoxSubtraction.Text = " -";
      this.checkBoxSubtraction.UseVisualStyleBackColor = true;
      // 
      // checkBoxAddition
      // 
      this.checkBoxAddition.Checked = true;
      this.checkBoxAddition.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
      this.checkBoxAddition.Location = new System.Drawing.Point(35, 19);
      this.checkBoxAddition.Name = "checkBoxAddition";
      this.checkBoxAddition.Size = new System.Drawing.Size(64, 24);
      this.checkBoxAddition.TabIndex = 0;
      this.checkBoxAddition.Text = " +";
      this.checkBoxAddition.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.numericUpDownOperandsNumber);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
      this.groupBox2.Location = new System.Drawing.Point(47, 28);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(155, 75);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Száma";
      // 
      // numericUpDownOperandsNumber
      // 
      this.numericUpDownOperandsNumber.Location = new System.Drawing.Point(53, 37);
      this.numericUpDownOperandsNumber.Maximum = new decimal(new int[] {4, 0, 0, 0});
      this.numericUpDownOperandsNumber.Minimum = new decimal(new int[] {2, 0, 0, 0});
      this.numericUpDownOperandsNumber.Name = "numericUpDownOperandsNumber";
      this.numericUpDownOperandsNumber.Size = new System.Drawing.Size(47, 24);
      this.numericUpDownOperandsNumber.TabIndex = 1;
      this.toolTip.SetToolTip(this.numericUpDownOperandsNumber, "Minimum 2, maximum 4 db operandus adható meg.");
      this.numericUpDownOperandsNumber.Value = new decimal(new int[] {2, 0, 0, 0});
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.radioButtonAnyOperator);
      this.groupBox3.Controls.Add(this.radioButtonAnyField);
      this.groupBox3.Controls.Add(this.radioButtonResultField);
      this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
      this.groupBox3.Location = new System.Drawing.Point(415, 30);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(186, 111);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Mi legyen ismeretlen?";
      this.toolTip.SetToolTip(this.groupBox3, "A \"Bármely mező\" kiválasztásában az \"Eredmény mező\" is benne lesz.");
      // 
      // radioButtonAnyOperator
      // 
      this.radioButtonAnyOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
      this.radioButtonAnyOperator.Location = new System.Drawing.Point(27, 73);
      this.radioButtonAnyOperator.Name = "radioButtonAnyOperator";
      this.radioButtonAnyOperator.Size = new System.Drawing.Size(143, 24);
      this.radioButtonAnyOperator.TabIndex = 2;
      this.radioButtonAnyOperator.Text = "Bármely operátor";
      this.toolTip.SetToolTip(this.radioButtonAnyOperator, "Az egyik operátor lesz elrejtve");
      this.radioButtonAnyOperator.UseVisualStyleBackColor = true;
      // 
      // radioButtonAnyField
      // 
      this.radioButtonAnyField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
      this.radioButtonAnyField.Location = new System.Drawing.Point(27, 46);
      this.radioButtonAnyField.Name = "radioButtonAnyField";
      this.radioButtonAnyField.Size = new System.Drawing.Size(143, 24);
      this.radioButtonAnyField.TabIndex = 1;
      this.radioButtonAnyField.Text = "Bármely érték";
      this.toolTip.SetToolTip(this.radioButtonAnyField, "Az operandusok és a végeredmény közül lesz valamelyik elrejtve");
      this.radioButtonAnyField.UseVisualStyleBackColor = true;
      // 
      // radioButtonResultField
      // 
      this.radioButtonResultField.Checked = true;
      this.radioButtonResultField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
      this.radioButtonResultField.Location = new System.Drawing.Point(27, 21);
      this.radioButtonResultField.Name = "radioButtonResultField";
      this.radioButtonResultField.Size = new System.Drawing.Size(143, 24);
      this.radioButtonResultField.TabIndex = 0;
      this.radioButtonResultField.TabStop = true;
      this.radioButtonResultField.Text = "Eredmény érték";
      this.toolTip.SetToolTip(this.radioButtonResultField, "A végeredmény lesz elrejtve");
      this.radioButtonResultField.UseVisualStyleBackColor = true;
      // 
      // buttonExpressionsGenerate
      // 
      this.buttonExpressionsGenerate.BackColor = System.Drawing.Color.DarkSeaGreen;
      this.buttonExpressionsGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
      this.buttonExpressionsGenerate.Location = new System.Drawing.Point(26, 177);
      this.buttonExpressionsGenerate.Name = "buttonExpressionsGenerate";
      this.buttonExpressionsGenerate.Size = new System.Drawing.Size(105, 40);
      this.buttonExpressionsGenerate.TabIndex = 3;
      this.buttonExpressionsGenerate.Text = "Generálás";
      this.toolTip.SetToolTip(this.buttonExpressionsGenerate, "Hozzáfűzi egy listához a feladatokat, nem felülírja az előző generálást.");
      this.buttonExpressionsGenerate.UseVisualStyleBackColor = false;
      this.buttonExpressionsGenerate.Click += new System.EventHandler(this.button1_Click);
      // 
      // labelMessage
      // 
      this.labelMessage.Location = new System.Drawing.Point(48, 293);
      this.labelMessage.Name = "labelMessage";
      this.labelMessage.Size = new System.Drawing.Size(541, 23);
      this.labelMessage.TabIndex = 4;
      this.labelMessage.Text = "0 db példa vár nyomtatásra";
      // 
      // richTextBox1
      // 
      this.richTextBox1.Location = new System.Drawing.Point(303, 319);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(286, 96);
      this.richTextBox1.TabIndex = 5;
      this.richTextBox1.Text = "";
      this.richTextBox1.Visible = false;
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.numericUpDownExpressionsNumber);
      this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
      this.groupBox4.Location = new System.Drawing.Point(415, 190);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(186, 83);
      this.groupBox4.TabIndex = 6;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Feladatok száma";
      // 
      // numericUpDownExpressionsNumber
      // 
      this.numericUpDownExpressionsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
      this.numericUpDownExpressionsNumber.Location = new System.Drawing.Point(63, 36);
      this.numericUpDownExpressionsNumber.Minimum = new decimal(new int[] {1, 0, 0, 0});
      this.numericUpDownExpressionsNumber.Name = "numericUpDownExpressionsNumber";
      this.numericUpDownExpressionsNumber.Size = new System.Drawing.Size(54, 24);
      this.numericUpDownExpressionsNumber.TabIndex = 0;
      this.toolTip.SetToolTip(this.numericUpDownExpressionsNumber, "Minimum 1, maximum 100 adható meg.");
      this.numericUpDownExpressionsNumber.Value = new decimal(new int[] {10, 0, 0, 0});
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.label2);
      this.groupBox5.Controls.Add(this.label1);
      this.groupBox5.Controls.Add(this.numericUpDownValueTo);
      this.groupBox5.Controls.Add(this.numericUpDownValueFrom);
      this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
      this.groupBox5.Location = new System.Drawing.Point(47, 112);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(176, 100);
      this.groupBox5.TabIndex = 7;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Értéke";
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(110, 62);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(45, 23);
      this.label2.TabIndex = 3;
      this.label2.Text = "-ig";
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(110, 29);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(45, 23);
      this.label1.TabIndex = 2;
      this.label1.Text = "-tól";
      // 
      // numericUpDownValueTo
      // 
      this.numericUpDownValueTo.Location = new System.Drawing.Point(13, 65);
      this.numericUpDownValueTo.Maximum = new decimal(new int[] {1000, 0, 0, 0});
      this.numericUpDownValueTo.Minimum = new decimal(new int[] {1, 0, 0, 0});
      this.numericUpDownValueTo.Name = "numericUpDownValueTo";
      this.numericUpDownValueTo.Size = new System.Drawing.Size(75, 24);
      this.numericUpDownValueTo.TabIndex = 1;
      this.toolTip.SetToolTip(this.numericUpDownValueTo, "Minimum 1, maximum 10000 adható meg.");
      this.numericUpDownValueTo.Value = new decimal(new int[] {10, 0, 0, 0});
      // 
      // numericUpDownValueFrom
      // 
      this.numericUpDownValueFrom.Location = new System.Drawing.Point(13, 29);
      this.numericUpDownValueFrom.Maximum = new decimal(new int[] {999, 0, 0, 0});
      this.numericUpDownValueFrom.Name = "numericUpDownValueFrom";
      this.numericUpDownValueFrom.Size = new System.Drawing.Size(75, 24);
      this.numericUpDownValueFrom.TabIndex = 0;
      this.toolTip.SetToolTip(this.numericUpDownValueFrom, "Minimum 0, maximum 9999 adható meg.");
      this.numericUpDownValueFrom.Value = new decimal(new int[] {1, 0, 0, 0});
      // 
      // groupBox6
      // 
      this.groupBox6.Controls.Add(this.groupBox2);
      this.groupBox6.Controls.Add(this.groupBox5);
      this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
      this.groupBox6.Location = new System.Drawing.Point(137, 30);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new System.Drawing.Size(269, 243);
      this.groupBox6.TabIndex = 8;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Operandusok";
      // 
      // buttonPrintToPdf
      // 
      this.buttonPrintToPdf.BackColor = System.Drawing.Color.Salmon;
      this.buttonPrintToPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
      this.buttonPrintToPdf.Location = new System.Drawing.Point(26, 233);
      this.buttonPrintToPdf.Name = "buttonPrintToPdf";
      this.buttonPrintToPdf.Size = new System.Drawing.Size(105, 40);
      this.buttonPrintToPdf.TabIndex = 9;
      this.buttonPrintToPdf.Text = "PDF-be írás";
      this.toolTip.SetToolTip(this.buttonPrintToPdf, "Az eddig generált feladatokat a program mappájába helyezi a feladatok.pdf fájlba." + "\r\nÚjbóli megnyomása előtt érdemes kinyomtatni a feladatokat, mert mindig felülír" + "ja a feladatok.pdf-et!");
      this.buttonPrintToPdf.UseVisualStyleBackColor = false;
      this.buttonPrintToPdf.Click += new System.EventHandler(this.buttonPrintToPdf_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(625, 329);
      this.Controls.Add(this.buttonPrintToPdf);
      this.Controls.Add(this.groupBox6);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.labelMessage);
      this.Controls.Add(this.buttonExpressionsGenerate);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox1);
      this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "dudikpal@gmail.com";
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize) (this.numericUpDownOperandsNumber)).EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize) (this.numericUpDownExpressionsNumber)).EndInit();
      this.groupBox5.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize) (this.numericUpDownValueTo)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.numericUpDownValueFrom)).EndInit();
      this.groupBox6.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.RadioButton radioButtonAnyOperator;

    private System.Windows.Forms.ToolTip toolTip;

    private System.Windows.Forms.Button buttonPrintToPdf;

    private System.Windows.Forms.NumericUpDown numericUpDownExpressionsNumber;

    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numericUpDownValueFrom;
    private System.Windows.Forms.NumericUpDown numericUpDownValueTo;

    private System.Windows.Forms.GroupBox groupBox5;

    private System.Windows.Forms.NumericUpDown numericUpDownOperandsNumber;

    private System.Windows.Forms.GroupBox groupBox4;

    private System.Windows.Forms.RichTextBox richTextBox1;

    private System.Windows.Forms.Button buttonExpressionsGenerate;
    private System.Windows.Forms.Label labelMessage;

    private System.Windows.Forms.RadioButton radioButtonAnyField;

    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.RadioButton radioButtonResultField;

    private System.Windows.Forms.CheckBox checkBoxSubtraction;
    private System.Windows.Forms.CheckBox checkBoxMultiplication;
    private System.Windows.Forms.CheckBox checkBoxDivider;

    private System.Windows.Forms.CheckBox checkBoxAddition;
    private System.Windows.Forms.GroupBox groupBox1;

    #endregion
  }
}