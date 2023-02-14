namespace ReflectionDemo
{
    internal class LogSearch : ResponseModel
    {
        [SearchAttribute(Name = "TraceId")]
        public Guid? TraceId { get; set; }
        [SearchAttribute(Name = "PreviousId")]
        public Guid? PreviousId { get; set; }
        [SearchAttribute(Name = "StatusCode")]
        public int? StatusCode { get; set; }
        [SearchAttribute(Name = "Request")]
        public string? Request { get; set; }
        [SearchAttribute(Name = "Duration")]
        public TimeSpan? Duration { get; set; }

        public static LogSearch GetDummyLogSearch()
        {
            return new LogSearch()
            {
                TraceId= Guid.NewGuid(),
                PreviousId= Guid.NewGuid(), 
                StatusCode= 0,
                Request= null,
                Duration= TimeSpan.Zero,
                Response= new Response
                {
                    Error= "null reference exception",
                },
            };
        }

    }
}
