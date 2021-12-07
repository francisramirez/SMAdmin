namespace UseCases.Core
{
    public interface IBaseGetByIdUseCase<TEntity> where TEntity: class
    {
        public TEntity GetEntityById(int entityId);
    }
}
