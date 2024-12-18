using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_State
{
	internal class DocumentContext
	{
		public IState State { get; set; }
		public UserRoles CurrentUserRole { get; set; }
		public DocumentContext(UserRoles currentUserRole)
		{
			State = new DraftState(this);
			CurrentUserRole = currentUserRole;
		}
		public void Publish()
		{
			State.Publish();
		}
	}
}
