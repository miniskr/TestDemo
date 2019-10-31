using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    public class DocumentManager
    {
        private readonly object _syncQueue = new object();
        private readonly Queue<Document> _documents = new Queue<Document>();

        public void AddDocument(Document doc)
        {
            lock (this._syncQueue)
            {
                this._documents.Enqueue(doc);
            }
        }

        public Document GetDocument()
        {
            Document document = null;
            lock (this._syncQueue)
            {
                document = this._documents.Dequeue();
            }
            return document;
        }

        public bool IsDocumentAvailable => this._documents.Count > 0;
    }

    public class ProcessDocuments
    {
        public static Task Start(DocumentManager dm) =>
            Task.Run(new ProcessDocuments(dm).Run);

        protected ProcessDocuments(DocumentManager dm) =>
            this._documentManager = dm ?? throw new ArgumentNullException(nameof(dm));

        private DocumentManager _documentManager;

        protected async Task Run()
        {
            while (true)
            {
                if (this._documentManager.IsDocumentAvailable)
                {
                    var doc = this._documentManager.GetDocument();
                    Console.WriteLine("Processing document {0}", doc.Title);
                }
                await Task.Delay(new Random().Next(20));
            }
        }
    }
}
