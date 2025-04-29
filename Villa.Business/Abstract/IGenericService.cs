using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Business.Abstract
{
	public interface IGenericService<T> where T : class
	{
		Task TCreateAsync(T entity);
		Task TUpdateAsync(T entity);
		Task TDeleteAsync(int id);
		Task<List<T>> TGetListAsync();
		Task<T> TGetByIdAsync(int id);
		Task<int> TCountAsync();
		Task<List<T>> TGetFilteredListAsync(Expression<Func<T, bool>> expression);
	}
}
