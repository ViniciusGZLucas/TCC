namespace CrossCutting.DataSession
{
    public class DataSession
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PrivateEmail { get; set; }
        public bool IsAdmin { get; set; }
        public List<string> Roles { get; set; }
    }
}
