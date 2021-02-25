namespace MatekNegyAlapmuveletGenerator {
	public class InputValues {
		
		private int operandsNumber;
		private int expressionsNumber;
		private int minValue;
		private int maxValue;
		private bool isAnyField;
		private bool isAnyOperator;

		public InputValues(int operandsNumber, int expressionsNumber, int minValue, int maxValue, bool isAnyField, bool isAnyOperator) {
			this.operandsNumber = operandsNumber;
			this.expressionsNumber = expressionsNumber;
			this.minValue = minValue;
			this.maxValue = maxValue;
			this.isAnyField = isAnyField;
			this.isAnyOperator = isAnyOperator;
		}

		public int OperandsNumber => operandsNumber;

		public bool IsAnyField => isAnyField;

		public bool IsAnyOperator => isAnyOperator;

		public int ExpressionsNumber {
			get => expressionsNumber;
			set => expressionsNumber = value;
		}

		public int MinValue {
			get => minValue;
			set => minValue = value;
		}

		public int MaxValue {
			get => maxValue;
			set => maxValue = value;
		}
		
		
	}
}