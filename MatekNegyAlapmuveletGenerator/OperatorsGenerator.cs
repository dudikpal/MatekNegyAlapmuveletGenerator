using System.Collections.Generic;
using System.Windows.Forms;

namespace MatekNegyAlapmuveletGenerator {
  //public partial class Form1{
  public class OperatorsGenerator {

    private OperatorsCheckBoxes _operatorsCheckBoxes;
    private List<string> choosedOperators = new List<string>();

    public OperatorsGenerator(OperatorsCheckBoxes operatorsCheckBoxes) {
      _operatorsCheckBoxes = operatorsCheckBoxes;
    }

    public List<string> choosedOperatorsFill() {
      if (_operatorsCheckBoxes.Addition) {
        choosedOperators.Add("+");
      }

      if (_operatorsCheckBoxes.Subtraction) {
        choosedOperators.Add("-");
      }

      if (_operatorsCheckBoxes.Multiplier) {
        choosedOperators.Add("*");
      }

      if (_operatorsCheckBoxes.Divider) {
        choosedOperators.Add("/");
      }

      return choosedOperators;
    }
  }
}