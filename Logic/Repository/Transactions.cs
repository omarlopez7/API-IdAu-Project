using API_IdAu1.Database;
using Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace API_IdAu1.Logic.Repository
{
    public class Transactions : ITransactions
    {
        private readonly AppDBContext _context;
        private readonly Dictionary<Type, object> _repositories;
        private TransactionScope _transaction;

        public Transactions(AppDBContext context)
        {
            _context = context;
            _repositories = new Dictionary<Type, object>();
        }

        public ITransactionRepositoryBase<T> GetRepository<T>() where T : class
        {
            if (_repositories.ContainsKey(typeof(T)))
            {
                return (RepositoryBase<T>)_repositories[typeof(T)];
            }

            var repository = new RepositoryBase<T>(_context);
            _repositories.Add(typeof(T), repository);
            return repository;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void BeginTransaction()
        {
            _transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
        }

        public void CommitTransaction()
        {
            try
            {
                _transaction.Complete();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                _transaction.Dispose();
                throw;
            }
            finally
            {
                _transaction.Dispose();
            }
        }

        public void RollbackTransaction()
        {
            _transaction.Dispose();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
