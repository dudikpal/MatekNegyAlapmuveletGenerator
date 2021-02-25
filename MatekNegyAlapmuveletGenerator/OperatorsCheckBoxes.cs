namespace MatekNegyAlapmuveletGenerator {
	public class OperatorsCheckBoxes {
		private bool addition;
		private bool subtraction;
		private bool multiplier;
		private bool divider;

		public OperatorsCheckBoxes(bool addition, bool subtraction, bool multiplier, bool divider) {
			this.addition = addition;
			this.subtraction = subtraction;
			this.multiplier = multiplier;
			this.divider = divider;
		}

		public bool Addition => addition;

		public bool Subtraction => subtraction;

		public bool Multiplier => multiplier;

		public bool Divider => divider;
	}
}