namespace Comp4920_SAS.Common
{
    public class Result<T>
    {
        public string UserMessage { get; set; }
        public bool IsSuccessed { get; set; }
        public T ProcessResult { get; set; }
    }
}