using System;
using System.Collections.Generic;
using System.Linq;

namespace MatekNegyAlapmuveletGenerator {
	public class OperandsGenerator {

		private InputValues _inputValues;
		private Random rnd = new Random();

		public OperandsGenerator(InputValues inputValues) {
			_inputValues = inputValues;
		}

		public List<string> operandsGenerator() {
			HashSet<string> operands = new HashSet<string>();
			for (int i = 0; i < _inputValues.ExpressionsNumber; i++) {
				while (operands.Count != i + 1) {
					operands.Add(operandsOfOneExpression());
				}
			}
			return operands.ToList();
		}

		private string operandsOfOneExpression() {
			string result = "";
			for (int i = 0; i < _inputValues.OperandsNumber; i++) {
				result += rnd.Next(_inputValues.MinValue, _inputValues.MaxValue) + ",";
			}
			return result.Substring(0, result.Length - 1);
		}
	}
}