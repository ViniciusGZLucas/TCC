namespace Domain.Entry
{
    public class ArticleDocument : BaseEntry
    {
        public ArticleDocument() { }

        public ArticleDocument(long articleId, string fileName, string base64File)
        {
            ArticleId = articleId;
            FileName = fileName;
            Base64File = base64File;
        }

        public long ArticleId { get; set; }
        public string FileName { get; set; }
        public string Base64File { get; set; }

        #region VirtualProperties
        #region Internal
        public virtual Article Article { get; set; }
        #endregion
        #endregion
    }
}
