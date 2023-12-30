using BusinnessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Concrete
{
	public class ToDoListManager : IToDoListService
	{
		IToDoLİstDal _toDoListDal;

		public ToDoListManager(IToDoLİstDal toDoListDal)
		{
			_toDoListDal = toDoListDal;
		}

		public void TAdd(ToDoList t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(ToDoList t)
		{
			throw new NotImplementedException();
		}

		public ToDoList TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<ToDoList> TGetList()
		{
			return _toDoListDal.GetList();
		}

		public List<ToDoList> TGetListbyFilter()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(ToDoList t)
		{
			throw new NotImplementedException();
		}
	}
}
