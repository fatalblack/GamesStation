namespace GamesStation.SuperExampleGame.Domain.Results
{
    public class GenericResult<T>
    {
        public bool IsSucceeded { get; set; }
        public string Message { get; set; }

        public T Value { get; set; }

        public GenericResult(bool isSucceeded, string message, T value)
        {
            this.IsSucceeded = isSucceeded;
            this.Message = message;
            this.Value = value;
        }

        public static GenericResult<T> SetOk(T value)
        {
            return new GenericResult<T>(true, null, value);
        }

        public static GenericResult<T> SetFail(string message)
        {
            return new GenericResult<T>(false, message, (T)default);
        }
    }
}