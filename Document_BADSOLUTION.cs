using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_State
{
	internal class Document_BADSOLUTION
	{
		public DocumentStates State {  get; set; }
		public UserRoles CurrentUserRole { get; set; }

		//a document can have multiple method, with the same o similar branching
		//Publish method is only one example
		//you can add user role, or document state
		public void Publish()
		{
			/* this branching violate the OPEN_CLOSE principle,
			 * for modification this class, you need change the class, the OC principle says: "for modification you can extend the class, not modify itself"
			 */ 
			if (State == DocumentStates.Bozza)
			{
				State = DocumentStates.Revisione;
			}
			else if (State == DocumentStates.Revisione)
			{
				if (CurrentUserRole == UserRoles.Amministratore)
				{
					State = DocumentStates.Pubblicazione;
				}
			}
			else if (State == DocumentStates.Pubblicazione)
			{
				//do nothing
			}
		}
	}
}
