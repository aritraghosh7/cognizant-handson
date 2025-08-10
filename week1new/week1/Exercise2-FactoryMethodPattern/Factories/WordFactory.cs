using FactoryMethodPattern.Documents;

namespace FactoryMethodPattern.Factories
{
    public class WordFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new WordDocument();
        }
    }
}
