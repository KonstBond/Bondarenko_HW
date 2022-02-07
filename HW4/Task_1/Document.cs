
namespace Classes
{
    class Document
    {
        PartOfDoc title;
        PartOfDoc body;
        PartOfDoc footer;

        private void SetDocument(string title, string body, string footer)
        {
            this.title = new Title() { Content = title };
            this.body = new Body() { Content = body };
            this.footer = new Footer() { Content = footer };
        }
        
        public Document(string title, string body, string footer)
        {
            SetDocument(title,body,footer);
        }

        public void ReTitle(string newTitle)
        {
            title.Content = newTitle;
        }

        public void ReBody(string newBody)
        {
            body.Content = newBody;
        }

        public void ReFooter(string newFooter)
        {
            footer.Content = newFooter;
        }

        public void Show()
        {
            this.title.Show();
            this.body.Show();
            this.footer.Show();
        }
    }
}
