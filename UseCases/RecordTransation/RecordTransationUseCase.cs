using Microsoft.Extensions.Logging;
using System;
using UseCases.Contracts;
using UseCases.Core;
using UseCases.Models;
using UseCases.UseCaseInterfaces;

namespace UseCases.RecordTransation
{
    public class RecordTransationUseCase : IRecordTransationUseCase
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly ILogger<RecordTransationUseCase> _logger;

        public RecordTransationUseCase(ITransactionRepository transactionRepository, 
                                       ILogger<RecordTransationUseCase> logger)
        {
            _transactionRepository = transactionRepository;
            _logger = logger;
        }
        public UseCaseResult Execute(RecordTransactionModel transactionModel)
        {
            UseCaseResult caseResult = new UseCaseResult();

            try
            {
                _transactionRepository.Save(transactionModel.CashierName,
                                            transactionModel.ProductId,
                                            transactionModel.Price,
                                            transactionModel.Quantity);

            }
            catch (Exception ex)
            {
                caseResult.Message = "Error procesing the transaction.";
                caseResult.Success = false;
                _logger.LogInformation(caseResult.Message, ex);

            }
            return caseResult;
        }
    }
}
