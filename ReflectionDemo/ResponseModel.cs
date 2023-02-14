namespace ReflectionDemo
{
    internal class ResponseModel
    {
        public Response? Response { get; set; }

        [BaseAttribute(Name = "Response.Error")]
        internal string? Error
        {
            get => Response?.Error;
        }

        [BaseAttribute(Name = "Response.Exception")]
        internal string? Exception
        {
            get => Response?.Exception;
        }

        [BaseAttribute(Name = "Response.Message")]
        internal string? Message
        {
            get => Response?.Message;
        }
    }
}