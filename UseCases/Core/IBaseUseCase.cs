namespace UseCases.Core
{
    public interface IBaseUseCase<TEntity> where TEntity : class
    {
        public void Execute(TEntity entity);
    }
}
