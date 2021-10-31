namespace Architecture_lab.Common.Model
{
    public class Result : IResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int AffectRows { get; set; }
    }
}