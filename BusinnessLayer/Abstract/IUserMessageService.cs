using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Abstract
{
	public interface IUserMessageService : IGenericService<UserMessage>
	{
		List<UserMessage> GetUserMessageWithUserService();
	}
}
