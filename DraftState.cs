namespace Behavioral_State
{
	internal class DraftState : IState
	{
		private DocumentContext _document;

		public DraftState(DocumentContext document)
		{
			_document = document;
		}

		public void Publish()
		{
			_document.State = new ModerationState(_document);
		}

		public override string ToString()
		{
			return this.GetType().Name;
		}
	}
}