namespace PotterBooks
{

	public class HarryPotterBook
	{
		
		private string _title;

		public string Title {
			get
			{
				return _title;
			}
		}
		public HarryPotterBook(string title)
		{
			_title = title;  
		}
	}
}