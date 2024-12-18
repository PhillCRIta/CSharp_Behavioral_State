namespace Behavioral_State
{
	internal class PublishedState : IState
	{
		DocumentContext _document;

		public PublishedState(DocumentContext document)
		{
			_document = document;
		}

		public void Publish()
		{
			//do nothing
			return;
		}

		public override string ToString()
		{
			return this.GetType().Name;
		}
	}
}