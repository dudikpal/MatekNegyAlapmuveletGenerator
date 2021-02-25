using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Layout;
using iText.Layout.Element;

namespace MatekNegyAlapmuveletGenerator
{
  public partial class Form1 : Form {

    private InputValues inputValues;
    private OperatorsCheckBoxes operatorsCheckBoxes;
    private bool isValidInputs;
    private List expressionsWithResult = new List();
    private List expressionWithoutResult = new List();
    private List<string> withResults = new List<string>();
    private List<string> withEmptyField = new List<string>();
    private int expressionsInList = 0;
    
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      operatorsCheckBoxes = new OperatorsCheckBoxes(
        checkBoxAddition.Checked,
        checkBoxSubtraction.Checked,
        checkBoxMultiplication.Checked,
        checkBoxDivider.Checked);

      inputValues = new InputValues(
        (int) numericUpDownOperandsNumber.Value,
        (int) numericUpDownExpressionsNumber.Value,
        (int) numericUpDownValueFrom.Value,
        (int) numericUpDownValueTo.Value,
        radioButtonAnyField.Checked,
        radioButtonAnyOperator.Checked);

      validateInputs();
      if (isValidInputs) {
        OperatorsGenerator og = new OperatorsGenerator(operatorsCheckBoxes);
        OperandsGenerator operandsGenerator = new OperandsGenerator(inputValues);
        ExpressionsGenerator eg = new ExpressionsGenerator(og.choosedOperatorsFill(), operandsGenerator.operandsGenerator(), inputValues);
        withResults = eg.generatorWithResult();
        if (radioButtonAnyOperator.Checked) {
          
        }
        withEmptyField = eg.generatorWithEmptyField();
        fillListsToPdf();
        expressionsInList += inputValues.ExpressionsNumber; 
        labelMessage.Text = expressionsInList + " db példa vár nyomtatásra";
        
        /*richTextBox1.AppendText(string.Join(", ", withResults)); 
        richTextBox1.AppendText("\n");
        richTextBox1.AppendText(string.Join(", ", withEmptyField));*/ 
        
      }

    }

    private void fillListsToPdf() {
      foreach (var item in withEmptyField) {
        expressionWithoutResult.Add(item);
        expressionWithoutResult.Add("\n");
      }

      foreach (var item in withResults) {
        expressionsWithResult.Add(item);
        expressionsWithResult.Add("\n");
      }
    }

    private void buttonPrintToPdf_Click(object sender, EventArgs e) {
      PdfCreator pdfCreator = new PdfCreator(expressionWithoutResult, expressionsWithResult);
      pdfCreator.createPdfFile();
      labelMessage.Text = "0 db példa vár nyomtatásra";
      expressionsInList = 0;
    }
  }
}
