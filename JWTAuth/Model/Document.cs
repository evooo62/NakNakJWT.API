namespace JWTAuth.Model
{
    public class Document
    {
        public int DocumentId { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public long? FileSize { get; set; }
    }
}
