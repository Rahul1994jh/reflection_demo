namespace ReflectionDemo
{
    internal class ResponseModel
    {
        public Response? Response { get; set; }

        [SearchAttribute(Name = "Response.Error")]
        internal string? Error
        {
            get => Response?.Error;
        }

        [SearchAttribute(Name = "Response.Exception")]
        internal string? Exception
        {
            get => Response?.Exception;
        }

        [SearchAttribute(Name = "Response.Message")]
        internal string? Message
        {
            get => Response?.Message;
        }
    }
}