namespace Architecture_lab.Common.Model
{
    public interface IResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int AffectRows { get; set; }
    }
}