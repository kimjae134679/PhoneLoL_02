using System;
using System.IO;

namespace EveEngine
{
	public static class HCLFBGALLOD
	{
		private static object JMMHBADAIMC = new object();

		public static void CMBAJMGENEG(string LOGBKDOCDLI, string GEKKFJHENKA, params object[] DJOOAELBKCC)
		{
			lock (JMMHBADAIMC)
			{
				using (StreamWriter streamWriter = new StreamWriter(LOGBKDOCDLI, true))
				{
					streamWriter.WriteLine("{0:yyyy/MM/dd HH:mm:ss}\t{1}", DateTime.Now, string.Format(GEKKFJHENKA, DJOOAELBKCC));
				}
			}
		}
	}
}
