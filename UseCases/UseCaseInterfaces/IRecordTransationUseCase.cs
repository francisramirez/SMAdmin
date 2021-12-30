using UseCases.Core;
using UseCases.Models;

namespace UseCases.UseCaseInterfaces
{
    public interface IRecordTransationUseCase
    {
        public UseCaseResult Execute(RecordTransactionModel transactionModel);
    }
}
