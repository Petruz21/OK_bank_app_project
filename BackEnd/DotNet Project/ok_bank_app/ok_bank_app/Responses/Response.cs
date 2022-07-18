namespace ok_bank_app.Response
{
    public class Response<T>
    {

        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = null;

    }
}
