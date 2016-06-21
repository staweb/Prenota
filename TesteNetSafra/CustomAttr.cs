namespace TesteNetSafra
{

	[System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct, AllowMultiple = true) ]
	public class CustomAttr : System.Attribute
	{
		private string _autor;
		public string _versao;

		public CustomAttr(string nome)
		{
			this._autor = nome;
			_versao = "1.0";
		}

		public override string ToString()
		{
			return "[Autor: " + _autor + " - Versão: " + _versao + "]";
		}
	}
}