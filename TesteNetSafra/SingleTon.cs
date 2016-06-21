namespace TesteNetSafra
{
	[CustomAttr("Usuário 01", _versao = "1.0.0")]
	[CustomAttr("Usuário 02", _versao = "1.0.1")]
	public class Singleton
	{
		private static Singleton _object; // Ou instance

		public int Id { get; set; }
		private Singleton()
		{
			Id = Id + 1;
		}

		public static Singleton CreateObject()
		{
			return _object ?? (_object = new Singleton());
		}
	}
}
