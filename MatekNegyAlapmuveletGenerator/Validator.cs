using System;
using System.Windows.Forms;

namespace MatekNegyAlapmuveletGenerator {
  partial class Form1 {

    public void validateInputs() {
      isValidInputs = true;
      valueMaxToMin();
      expressionsMaxNumbersWithoutRepeat();
      onlyDivideMaxTwoOperandsEnable();
    }

    private void onlyDivideMaxTwoOperandsEnable() {
      if (operatorsCheckBoxes.Divider &&
          !operatorsCheckBoxes.Addition &&
          !operatorsCheckBoxes.Multiplier &&
          !operatorsCheckBoxes.Subtraction &&
          inputValues.OperandsNumber > 2) {
        MessageBox.Show("Csak osztás kiválasztásánál maximum 2 operandus megengedett.");
        numericUpDownOperandsNumber.Text = "2";
        isValidInputs = false;
      }
    }

    private void expressionsMaxNumbersWithoutRepeat() {
      long maxExpressions = (long) Math.Pow(inputValues.MaxValue - inputValues.MinValue + 1, inputValues.OperandsNumber); 
      if ( maxExpressions < inputValues.ExpressionsNumber) {
        MessageBox.Show("Az aktuális paraméterekkel, ismétlés nélküli lehetséges maximális feladatszám: " + maxExpressions);
        numericUpDownExpressionsNumber.Text = maxExpressions.ToString();
        isValidInputs = false;
      }
    }

    private void valueMaxToMin() {
      if (inputValues.MinValue > inputValues.MaxValue) {
        int temp = inputValues.MaxValue;
        inputValues.MaxValue = inputValues.MinValue;
        inputValues.MinValue = temp;
        numericUpDownValueFrom.Text = inputValues.MinValue.ToString();
        numericUpDownValueTo.Text = inputValues.MaxValue.ToString();
      }
    }

  }
}