using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MatekNegyAlapmuveletGenerator {
	public class ExpressionsGenerator {
		
		private List<string> _operators;
		private List<string> _operands;
		private InputValues _inputValues;
		private List<string> expressionsWithResult = new List<string>();
		private List<string> expressionsWithEmptyField = new List<string>();
		private List<string> generatedOperators = new List<string>();
		private StringBuilder sb;
		private Random rnd = new Random();
		private List<string> operands;
		private List<string> operators;

		public ExpressionsGenerator(List<string> operators, List<string> operands, InputValues inputValues) {
			_operators = operators;
			_operands = operands;
			_inputValues = inputValues;
		}

		public List<string> generatorWithEmptyField() {
			foreach (string expression in expressionsWithResult) {
				expressionsWithEmptyField.Add(createEmptyField(expression));
			}
			return expressionsWithEmptyField;
		}

		private string createEmptyField(string expression) {
			sb = new StringBuilder();
			string[] parts = expression.Split(' ');
			int fieldIndex;
			string placeholder;
			
			if (_inputValues.IsAnyField) {
				fieldIndex = rnd.Next(0, ((parts.Length + 1) / 2)) * 2;
			} else if (_inputValues.IsAnyOperator) {
				fieldIndex = rnd.Next(0, (_inputValues.OperandsNumber - 1)) * 2 + 1;
			} else {
				fieldIndex = parts.Length - 1;
			}
			placeholder = String.Join("", Enumerable.Repeat("_", parts[fieldIndex].Length));
			parts[fieldIndex] = placeholder;

			for (int i = 0; i < parts.Length; i++) {
				sb.Append(parts[i] + " ");
			}

			return sb.ToString().Trim();
		}

		public List<string> generatorWithResult() {
			sb = new StringBuilder();
			generateOperators();
			for (int i = 0; i < _inputValues.ExpressionsNumber; i++) {
				operands = _operands[i].Split(',').ToList();
				operators = generatedOperators[i].Split(' ').ToList();
				for (int j = 0; j < _inputValues.OperandsNumber - 1; j++) {
					ifSubtraction(operators[0]);
					ifDivide(operators[0]);
					ifMultiplier(operators[0]);
					generateLine();
					operands.Remove(operands.First());
					operators.Remove(operators.First());
					
				}
				sb.Append(operands.Last());
				calculateResult();
				expressionsWithResult.Add(sb.ToString());
				sb.Clear();
			}
			return expressionsWithResult;
		}

		private void ifMultiplier(string actualOperator) {
			if (actualOperator == "*") {
				operands.Sort();
			}
		}

		private void ifDivide(string actualOperator) {
			if (actualOperator == "/") {
				operands.Sort();
				//operands.Reverse();
				operands[0] = (int.Parse(operands[0]) * int.Parse(operands[1])).ToString();
				if (operators.Count > 1 && (operators[1] == "-" || operators[1] == "/")) {
					operators[1] = "+";
				}
			}
		}

		private void ifSubtraction(string actualOperator) {
			if (actualOperator == "-") {
				operands.Sort();
				string temp = operands[0];
				operands[0] = operands.Last();
				operands[operands.Count - 1] = operands[1];
				operands[1] = temp;
			}
		}

		private void generateLine() {
			sb.Append(operands[0]).Append(" ").Append(operators[0]).Append(" ");
		}

		private void generateOperators() {
			for (int i = 0; i < _inputValues.ExpressionsNumber; i++) {
				string line = "";
				for (int j = 0; j < _inputValues.OperandsNumber - 1; j++) {
					line += _operators[rnd.Next(0, _operators.Count)] + " ";
				}
				generatedOperators.Add(line);
			}
		}

		private void calculateResult() {
			sb.Append(" = " + new DataTable().Compute(sb.ToString(), ""));
		}

	}
}