using System;

namespace FactoryMethodDemo
{
    
    public interface IDocument
    {
        void Open();
    }

    
    public class WordDocument : IDocument
    {
        public void Open() => Console.WriteLine("Opening a Word document...");
    }

    public class PdfDocument : IDocument
    {
        public void Open() => Console.WriteLine("Opening a PDF document...");
    }

    public class ExcelDocument : IDocument
    {
        public void Open() => Console.WriteLine("Opening an Excel document...");
    }
    public abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument();
    }

    public class WordDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument() => new WordDocument();
    }

    public class PdfDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument() => new PdfDocument();
    }

    public class ExcelDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument() => new ExcelDocument();
    }

    internal static class Program
    {
        private static void Main()
        {
            TestFactory(new WordDocumentFactory());
            TestFactory(new PdfDocumentFactory());
            TestFactory(new ExcelDocumentFactory());
        }

        private static void TestFactory(DocumentFactory factory)
        {
            IDocument doc = factory.CreateDocument();
            doc.Open();
        }
    }
}
