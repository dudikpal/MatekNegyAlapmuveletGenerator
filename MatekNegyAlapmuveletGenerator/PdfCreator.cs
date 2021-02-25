
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace MatekNegyAlapmuveletGenerator {
	public class PdfCreator {
		
		private List _expressionWithoutResult;
		private List _expressionsWithResult;

		public PdfCreator(List expressionWithoutResult, List expressionsWithResult) {
			_expressionWithoutResult = expressionWithoutResult;
			_expressionsWithResult = expressionsWithResult;
		}

		public void createPdfFile() {
			string file = "peldak.pdf";
			PdfWriter writer = new PdfWriter(file);
			PdfDocument pdfDoc = new PdfDocument(writer);
			Document document = new Document(pdfDoc);
			_expressionsWithResult.SetListSymbol("");
			_expressionWithoutResult.SetListSymbol("");
			// 2 hasábos megjelenítés
			/*Rectangle[] columns = new Rectangle[] {
			  new Rectangle(30, 30, 200, 750), // coordinates of first column
			  new Rectangle(300, 30, 200, 750) // coordinates of second column
			};*/
			// 3 hasábos megjelenítés
			Rectangle[] columns = new Rectangle[] {
				new Rectangle(20, 30, 190, 750), // coordinates of first column
				new Rectangle(200, 30, 190, 750), // coordinates of second column
				new Rectangle(400, 30, 190, 750) // coordinates of third column
			};
			document.SetRenderer(new ColumnDocumentRenderer(document, columns));
			document.Add(_expressionWithoutResult);
			document.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));
			document.Add(_expressionsWithResult);
			document.Close();
		}
		
	}
}