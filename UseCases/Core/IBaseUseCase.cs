namespace UseCases.Core
{
    public interface IBaseUseCase<TEntity> where TEntity : class
    {
        public UseCaseResult Execute(TEntity entity);
    }
}
