namespace ReflectionDemo
{
    internal class LogSearch : ResponseModel
    {
        [BaseAttribute(Name = "TraceId")]
        public Guid? TraceId { get; set; }
        [BaseAttribute(Name = "PreviousId")]
        public Guid? PreviousId { get; set; }
        [BaseAttribute(Name = "StatusCode")]
        public int? StatusCode { get; set; }
        [BaseAttribute(Name = "Request")]
        public string? Request { get; set; }
        [BaseAttribute(Name = "Duration")]
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
