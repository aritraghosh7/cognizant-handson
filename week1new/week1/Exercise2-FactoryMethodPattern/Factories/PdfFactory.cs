using FactoryMethodPattern.Documents;

namespace FactoryMethodPattern.Factories
{
    public class PdfFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new PdfDocument();
        }
    }
}
