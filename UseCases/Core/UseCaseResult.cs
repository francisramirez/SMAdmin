namespace UseCases.Core
{
    public class UseCaseResult
    {
        public UseCaseResult() => this.Success = true;
        public string Message { get; set; }
        public bool Success { get; set; } = true;
        public dynamic Data { get; set; }
       

    }
}
