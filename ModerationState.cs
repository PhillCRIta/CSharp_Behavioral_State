namespace Behavioral_State
{
	internal class ModerationState : IState
	{
		DocumentContext _document;

		public ModerationState(DocumentContext document)
		{
			_document = document;
		}

		public void Publish()
		{
			if (_document.CurrentUserRole == UserRoles.Amministratore)
			{
				_document.State = new PublishedState(_document);
			}
			else
				Console.WriteLine("Only administrator can publish the document");
		}

		public override string ToString()
		{
			return this.GetType().Name;
		}
	}
}