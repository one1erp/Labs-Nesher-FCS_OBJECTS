namespace FCS_OBJECTS
{
    public class ResponseServise
    {

        public string str { get; set; }
        public string Error { get; set; }
        public string ErrDesc { get; set; }
        public string FCS_MSG_ID { get; set; }

        public bool Success
        { get; set; }


        public ResponseServise() { }

        public ResponseServise(bool success, string str, string err, string errDesc)
        {
            this.Success = success;
            this.str = str;
            this.Error = err;
            this.ErrDesc = errDesc;
        }
    }
}
