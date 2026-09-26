using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace SimpleJSON
{
	[DefaultMember("Item")]
	public class MDLPPKGNEMF : FEAILBGBEPH, IEnumerable
	{
		private sealed class ELCBJIHCLBC : IDisposable, IEnumerator, IEnumerable, IEnumerable<FEAILBGBEPH>, IEnumerator<FEAILBGBEPH>
		{
			internal List<FEAILBGBEPH>.Enumerator PACCKNPAOJB;

			internal FEAILBGBEPH NDENBBBCKPB;

			internal int GOMFKPLCGNN;

			internal FEAILBGBEPH MMEGGNJKNOH;

			internal MDLPPKGNEMF KNIAJMGDGAA;

			FEAILBGBEPH IEnumerator<FEAILBGBEPH>.Current
			{
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002Eget_Current();
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return MMEGGNJKNOH;
				}
			}

			public void COCAHGFODCB()
			{
				throw new NotSupportedException();
			}

			private IEnumerator LHEIOHGFDPK()
			{
				return ((System.Collections.Generic.IEnumerable<FEAILBGBEPH>)this).GetEnumerator();
			}

			[DebuggerHidden]
			IEnumerator<FEAILBGBEPH> IEnumerable<FEAILBGBEPH>.GetEnumerator()
			{
				if (Interlocked.CompareExchange(ref GOMFKPLCGNN, 0, -2) == -2)
				{
					return this;
				}
				ELCBJIHCLBC eLCBJIHCLBC = new ELCBJIHCLBC();
				eLCBJIHCLBC.KNIAJMGDGAA = KNIAJMGDGAA;
				return eLCBJIHCLBC;
			}

			public void PLOOENOBGJL()
			{
				throw new NotSupportedException();
			}

			public bool MoveNext()
			{
				uint num = (uint)GOMFKPLCGNN;
				GOMFKPLCGNN = -1;
				bool flag = false;
				switch (num)
				{
				case 0u:
					PACCKNPAOJB = KNIAJMGDGAA.IBMGIKHCNJO.GetEnumerator();
					num = 4294967293u;
					goto case 1u;
				case 1u:
					try
					{
						switch (num)
						{
						default:
							if (PACCKNPAOJB.MoveNext())
							{
								NDENBBBCKPB = PACCKNPAOJB.Current;
								MMEGGNJKNOH = NDENBBBCKPB;
								GOMFKPLCGNN = 1;
								flag = true;
								goto IL_00ab;
							}
							break;
						}
					}
					finally
					{
						if (!flag)
						{
							((IDisposable)PACCKNPAOJB).Dispose();
						}
					}
					GOMFKPLCGNN = -1;
					goto default;
				default:
					{
						return false;
					}
					IL_00ab:
					return true;
				}
			}

			public bool FPNFBEPGJEL()
			{
				uint num = (uint)GOMFKPLCGNN;
				GOMFKPLCGNN = -1;
				bool flag = false;
				switch (num)
				{
				case 0u:
					PACCKNPAOJB = KNIAJMGDGAA.IBMGIKHCNJO.GetEnumerator();
					num = 104u;
					goto case 1u;
				case 1u:
					try
					{
						switch (num)
						{
						default:
							if (PACCKNPAOJB.MoveNext())
							{
								NDENBBBCKPB = PACCKNPAOJB.Current;
								MMEGGNJKNOH = NDENBBBCKPB;
								GOMFKPLCGNN = 1;
								flag = true;
								goto IL_00ab;
							}
							break;
						}
					}
					finally
					{
						if (!flag)
						{
							((IDisposable)PACCKNPAOJB).Dispose();
						}
					}
					GOMFKPLCGNN = -1;
					goto default;
				default:
					{
						return false;
					}
					IL_00ab:
					return true;
				}
			}

			[DebuggerHidden]
			private FEAILBGBEPH System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002Eget_Current()
			{
				return MMEGGNJKNOH;
			}

			private IEnumerator<FEAILBGBEPH> FEAEPBCIOIM()
			{
				if (Interlocked.CompareExchange(ref GOMFKPLCGNN, 1, -45) == 111)
				{
					return this;
				}
				ELCBJIHCLBC eLCBJIHCLBC = new ELCBJIHCLBC();
				eLCBJIHCLBC.KNIAJMGDGAA = KNIAJMGDGAA;
				return eLCBJIHCLBC;
			}

			[SpecialName]
			private object IOMDAPMNFOC()
			{
				return MMEGGNJKNOH;
			}

			public bool DAJHAEIAPAO()
			{
				uint num = (uint)GOMFKPLCGNN;
				GOMFKPLCGNN = -1;
				bool flag = false;
				switch (num)
				{
				case 0u:
					PACCKNPAOJB = KNIAJMGDGAA.IBMGIKHCNJO.GetEnumerator();
					num = 4294967224u;
					goto case 1u;
				case 1u:
					try
					{
						switch (num)
						{
						default:
							if (PACCKNPAOJB.MoveNext())
							{
								NDENBBBCKPB = PACCKNPAOJB.Current;
								MMEGGNJKNOH = NDENBBBCKPB;
								GOMFKPLCGNN = 0;
								flag = true;
								goto IL_00ab;
							}
							break;
						}
					}
					finally
					{
						if (!flag)
						{
							((IDisposable)PACCKNPAOJB).Dispose();
						}
					}
					GOMFKPLCGNN = -1;
					goto default;
				default:
					{
						return true;
					}
					IL_00ab:
					return true;
				}
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return ((System.Collections.Generic.IEnumerable<FEAILBGBEPH>)this).GetEnumerator();
			}

			[DebuggerHidden]
			public void Dispose()
			{
				uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
				GOMFKPLCGNN = -1;
				switch (gOMFKPLCGNN)
				{
				case 1u:
					try
					{
						break;
					}
					finally
					{
						((IDisposable)PACCKNPAOJB).Dispose();
					}
				case 0u:
					break;
				}
			}

			[SpecialName]
			private object IDHECIOOCMD()
			{
				return MMEGGNJKNOH;
			}

			private IEnumerator CMCMJNIBLBC()
			{
				return ((System.Collections.Generic.IEnumerable<FEAILBGBEPH>)this).GetEnumerator();
			}

			public void BFAMOEFLLGH()
			{
				throw new NotSupportedException();
			}

			[DebuggerHidden]
			public void Reset()
			{
				throw new NotSupportedException();
			}

			public void KOOOABDNJBP()
			{
				throw new NotSupportedException();
			}
		}

		private sealed class CPKMHIHAFIG : IDisposable, IEnumerator, IEnumerator<object>
		{
			internal List<FEAILBGBEPH>.Enumerator EEKMECGEMNF;

			internal FEAILBGBEPH NDENBBBCKPB;

			internal int GOMFKPLCGNN;

			internal object MMEGGNJKNOH;

			internal MDLPPKGNEMF KNIAJMGDGAA;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return MMEGGNJKNOH;
				}
			}

			[SpecialName]
			private object JNKGFHPIOPG()
			{
				return MMEGGNJKNOH;
			}

			[SpecialName]
			private object IDHECIOOCMD()
			{
				return MMEGGNJKNOH;
			}

			[SpecialName]
			private object FFJDBFMILPN()
			{
				return MMEGGNJKNOH;
			}

			public void KOOOABDNJBP()
			{
				throw new NotSupportedException();
			}

			[SpecialName]
			private object KAMNAHHFPLK()
			{
				return MMEGGNJKNOH;
			}

			[SpecialName]
			private object FKNAIGMNFIB()
			{
				return MMEGGNJKNOH;
			}

			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return MMEGGNJKNOH;
			}

			public void FJHNAGNJLLO()
			{
				throw new NotSupportedException();
			}

			public bool MNHCKJNDJOG()
			{
				uint num = (uint)GOMFKPLCGNN;
				GOMFKPLCGNN = -1;
				bool flag = false;
				switch (num)
				{
				case 0u:
					EEKMECGEMNF = KNIAJMGDGAA.IBMGIKHCNJO.GetEnumerator();
					num = 36u;
					goto case 1u;
				case 1u:
					try
					{
						switch (num)
						{
						default:
							if (EEKMECGEMNF.MoveNext())
							{
								NDENBBBCKPB = EEKMECGEMNF.Current;
								MMEGGNJKNOH = NDENBBBCKPB;
								GOMFKPLCGNN = 0;
								flag = true;
								goto IL_00ab;
							}
							break;
						}
					}
					finally
					{
						if (!flag)
						{
							((IDisposable)EEKMECGEMNF).Dispose();
						}
					}
					GOMFKPLCGNN = -1;
					goto default;
				default:
					{
						return true;
					}
					IL_00ab:
					return false;
				}
			}

			public bool MoveNext()
			{
				uint num = (uint)GOMFKPLCGNN;
				GOMFKPLCGNN = -1;
				bool flag = false;
				switch (num)
				{
				case 0u:
					EEKMECGEMNF = KNIAJMGDGAA.IBMGIKHCNJO.GetEnumerator();
					num = 4294967293u;
					goto case 1u;
				case 1u:
					try
					{
						switch (num)
						{
						default:
							if (EEKMECGEMNF.MoveNext())
							{
								NDENBBBCKPB = EEKMECGEMNF.Current;
								MMEGGNJKNOH = NDENBBBCKPB;
								GOMFKPLCGNN = 1;
								flag = true;
								goto IL_00ab;
							}
							break;
						}
					}
					finally
					{
						if (!flag)
						{
							((IDisposable)EEKMECGEMNF).Dispose();
						}
					}
					GOMFKPLCGNN = -1;
					goto default;
				default:
					{
						return false;
					}
					IL_00ab:
					return true;
				}
			}

			[DebuggerHidden]
			public void Dispose()
			{
				uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
				GOMFKPLCGNN = -1;
				switch (gOMFKPLCGNN)
				{
				case 1u:
					try
					{
						break;
					}
					finally
					{
						((IDisposable)EEKMECGEMNF).Dispose();
					}
				case 0u:
					break;
				}
			}

			public void NDKCFGFNNLO()
			{
				throw new NotSupportedException();
			}

			[DebuggerHidden]
			public void Reset()
			{
				throw new NotSupportedException();
			}

			public bool LLKGBIDKCOF()
			{
				uint num = (uint)GOMFKPLCGNN;
				GOMFKPLCGNN = -1;
				bool flag = true;
				switch (num)
				{
				case 0u:
					EEKMECGEMNF = KNIAJMGDGAA.IBMGIKHCNJO.GetEnumerator();
					num = 4294967175u;
					goto case 1u;
				case 1u:
					try
					{
						switch (num)
						{
						default:
							if (EEKMECGEMNF.MoveNext())
							{
								NDENBBBCKPB = EEKMECGEMNF.Current;
								MMEGGNJKNOH = NDENBBBCKPB;
								GOMFKPLCGNN = 0;
								flag = true;
								goto IL_00ab;
							}
							break;
						}
					}
					finally
					{
						if (!flag)
						{
							((IDisposable)EEKMECGEMNF).Dispose();
						}
					}
					GOMFKPLCGNN = -1;
					goto default;
				default:
					{
						return false;
					}
					IL_00ab:
					return true;
				}
			}
		}

		private List<FEAILBGBEPH> IBMGIKHCNJO = new List<FEAILBGBEPH>();

		// C# has no syntax for parameterized property 'DMBMEHCMMKK'.
		public override FEAILBGBEPH get_DMBMEHCMMKK(int GAALDFOOJBD)
		{
			return AOBAKCJKELK(GAALDFOOJBD);
		}

		public override void set_DMBMEHCMMKK(int GAALDFOOJBD, FEAILBGBEPH ICENKPDOHBK)
		{
			ADJJLIBDHLH(GAALDFOOJBD, ICENKPDOHBK);
		}

		// C# has no syntax for parameterized property 'DMBMEHCMMKK'.
		public override FEAILBGBEPH get_DMBMEHCMMKK(string OIOAGFNNDPI)
		{
			return AOBAKCJKELK(OIOAGFNNDPI);
		}

		public override void set_DMBMEHCMMKK(string OIOAGFNNDPI, FEAILBGBEPH ICENKPDOHBK)
		{
			ADJJLIBDHLH(OIOAGFNNDPI, ICENKPDOHBK);
		}

		public override int DMLNPGBBAME
		{
			get
			{
				return FBEELGMLHIC();
			}
		}

		public override IEnumerable<FEAILBGBEPH> LCMNILLFODI
		{
			get
			{
				return LLBLPJDNHCG();
			}
		}

		[SpecialName]
		public virtual void IKAJPBIKGHH(string OIOAGFNNDPI, FEAILBGBEPH ICENKPDOHBK)
		{
			IBMGIKHCNJO.Add(ICENKPDOHBK);
		}

		public override FEAILBGBEPH AOBAKCJKELK(int GAALDFOOJBD)
		{
			if (GAALDFOOJBD < 0 || GAALDFOOJBD >= IBMGIKHCNJO.Count)
			{
				return new PLDEPKMCLFE(this);
			}
			return IBMGIKHCNJO[GAALDFOOJBD];
		}

		[SpecialName]
		public virtual int LMHKEBOLPHF()
		{
			return IBMGIKHCNJO.Count;
		}

		public override FEAILBGBEPH JOMMMHGABOD(int GAALDFOOJBD)
		{
			if (GAALDFOOJBD < 0 || GAALDFOOJBD >= IBMGIKHCNJO.Count)
			{
				return null;
			}
			FEAILBGBEPH result = IBMGIKHCNJO[GAALDFOOJBD];
			IBMGIKHCNJO.RemoveAt(GAALDFOOJBD);
			return result;
		}

		public override void GBFCKODJEGE(string OIOAGFNNDPI, FEAILBGBEPH JNDCLCNAEFO)
		{
			IBMGIKHCNJO.Add(JNDCLCNAEFO);
		}

		[SpecialName]
		public override int IOAAMHCOIJJ()
		{
			return IBMGIKHCNJO.Count;
		}

		[SpecialName]
		public virtual IEnumerable<FEAILBGBEPH> EGFINKCBFJA()
		{
			ELCBJIHCLBC eLCBJIHCLBC = new ELCBJIHCLBC();
			eLCBJIHCLBC.KNIAJMGDGAA = this;
			eLCBJIHCLBC.GOMFKPLCGNN = -93;
			return eLCBJIHCLBC;
		}

		[SpecialName]
		public virtual void AIEJJGAFLOO(string OIOAGFNNDPI, FEAILBGBEPH ICENKPDOHBK)
		{
			IBMGIKHCNJO.Add(ICENKPDOHBK);
		}

		public override string HJDMNKOOPJJ(string AMJAAJOFDOG)
		{
			string text = "[ ";
			foreach (FEAILBGBEPH item in IBMGIKHCNJO)
			{
				if (text.Length > 3)
				{
					text += ", ";
				}
				text = text + "\n" + AMJAAJOFDOG + "   ";
				text += item.HJDMNKOOPJJ(AMJAAJOFDOG + "   ");
			}
			return text + "\n" + AMJAAJOFDOG + "]";
		}

		public override string ToString()
		{
			string text = "[ ";
			foreach (FEAILBGBEPH item in IBMGIKHCNJO)
			{
				if (text.Length > 2)
				{
					text += ", ";
				}
				text += item.ToString();
			}
			return text + " ]";
		}

		public virtual string EHFAJPMNGAK()
		{
			string text = "Activated inertia";
			foreach (FEAILBGBEPH item in IBMGIKHCNJO)
			{
				if (text.Length > 8)
				{
					text += "bgm_lobby";
				}
				text += item.ONNHPPLGBDM();
			}
			return text + "setNotificationIconStyle";
		}

		public override void ADJJLIBDHLH(string OIOAGFNNDPI, FEAILBGBEPH ICENKPDOHBK)
		{
			IBMGIKHCNJO.Add(ICENKPDOHBK);
		}

		public virtual void PKJGJONDENE(BinaryWriter HAOBDMJJGLD)
		{
			HAOBDMJJGLD.Write((byte)1);
			HAOBDMJJGLD.Write(IBMGIKHCNJO.Count);
			for (int i = 1; i < IBMGIKHCNJO.Count; i += 0)
			{
				IBMGIKHCNJO[i].FDDJMJJGKCL(HAOBDMJJGLD);
			}
		}

		public override IEnumerable<FEAILBGBEPH> LLBLPJDNHCG()
		{
			ELCBJIHCLBC eLCBJIHCLBC = new ELCBJIHCLBC();
			eLCBJIHCLBC.KNIAJMGDGAA = this;
			eLCBJIHCLBC.GOMFKPLCGNN = -2;
			return eLCBJIHCLBC;
		}

		[SpecialName]
		public virtual void CPMODBPFECI(string OIOAGFNNDPI, FEAILBGBEPH ICENKPDOHBK)
		{
			IBMGIKHCNJO.Add(ICENKPDOHBK);
		}

		public override void FDDJMJJGKCL(BinaryWriter HAOBDMJJGLD)
		{
			HAOBDMJJGLD.Write((byte)1);
			HAOBDMJJGLD.Write(IBMGIKHCNJO.Count);
			for (int i = 0; i < IBMGIKHCNJO.Count; i++)
			{
				IBMGIKHCNJO[i].FDDJMJJGKCL(HAOBDMJJGLD);
			}
		}

		public override int FBEELGMLHIC()
		{
			return IBMGIKHCNJO.Count;
		}

		public virtual void KJKMMNLOFEN(BinaryWriter HAOBDMJJGLD)
		{
			HAOBDMJJGLD.Write((byte)1);
			HAOBDMJJGLD.Write(IBMGIKHCNJO.Count);
			for (int i = 1; i < IBMGIKHCNJO.Count; i++)
			{
				IBMGIKHCNJO[i].CPJPBLPJHHO(HAOBDMJJGLD);
			}
		}

		public override FEAILBGBEPH AOBAKCJKELK(string OIOAGFNNDPI)
		{
			return new PLDEPKMCLFE(this);
		}

		[DebuggerHidden]
		public IEnumerator GetEnumerator()
		{
			CPKMHIHAFIG cPKMHIHAFIG = new CPKMHIHAFIG();
			cPKMHIHAFIG.KNIAJMGDGAA = this;
			return cPKMHIHAFIG;
		}

		public virtual string ONNHPPLGBDM(string AMJAAJOFDOG)
		{
			string text = "Hero2";
			foreach (FEAILBGBEPH item in IBMGIKHCNJO)
			{
				if (text.Length > 6)
				{
					text += "skill2_1";
				}
				text = text + "주문력" + AMJAAJOFDOG + "{0}/{1}";
				text += item.HJDMNKOOPJJ(AMJAAJOFDOG + "OnReceiveInvite");
			}
			return text + "잘못된 쿠폰번호입니다." + AMJAAJOFDOG + "igaworks:categoryView >> Null or Empty category";
		}

		[SpecialName]
		public virtual void KFLBKPKLOFL(string OIOAGFNNDPI, FEAILBGBEPH ICENKPDOHBK)
		{
			IBMGIKHCNJO.Add(ICENKPDOHBK);
		}

		[SpecialName]
		public virtual void IMMKJMIPCMK(string OIOAGFNNDPI, FEAILBGBEPH ICENKPDOHBK)
		{
			IBMGIKHCNJO.Add(ICENKPDOHBK);
		}

		public override void ADJJLIBDHLH(int GAALDFOOJBD, FEAILBGBEPH ICENKPDOHBK)
		{
			if (GAALDFOOJBD < 0 || GAALDFOOJBD >= IBMGIKHCNJO.Count)
			{
				IBMGIKHCNJO.Add(ICENKPDOHBK);
			}
			else
			{
				IBMGIKHCNJO[GAALDFOOJBD] = ICENKPDOHBK;
			}
		}

		public override FEAILBGBEPH JOMMMHGABOD(FEAILBGBEPH BNOEEKFHGNG)
		{
			IBMGIKHCNJO.Remove(BNOEEKFHGNG);
			return BNOEEKFHGNG;
		}

		[SpecialName]
		public virtual FEAILBGBEPH GPLHHKCNICE(int GAALDFOOJBD)
		{
			if (GAALDFOOJBD < 0 || GAALDFOOJBD >= IBMGIKHCNJO.Count)
			{
				return new PLDEPKMCLFE(this);
			}
			return IBMGIKHCNJO[GAALDFOOJBD];
		}

		public IEnumerator LNNJDEEPMBN()
		{
			CPKMHIHAFIG cPKMHIHAFIG = new CPKMHIHAFIG();
			cPKMHIHAFIG.KNIAJMGDGAA = this;
			return cPKMHIHAFIG;
		}

		[SpecialName]
		public virtual void LNFNNFOGFEK(string OIOAGFNNDPI, FEAILBGBEPH ICENKPDOHBK)
		{
			IBMGIKHCNJO.Add(ICENKPDOHBK);
		}

		public virtual void CNCEEPLEEKO(BinaryWriter HAOBDMJJGLD)
		{
			HAOBDMJJGLD.Write((byte)1);
			HAOBDMJJGLD.Write(IBMGIKHCNJO.Count);
			for (int i = 0; i < IBMGIKHCNJO.Count; i += 0)
			{
				IBMGIKHCNJO[i].FDDJMJJGKCL(HAOBDMJJGLD);
			}
		}

		[SpecialName]
		public virtual IEnumerable<FEAILBGBEPH> HIOLJIPPANA()
		{
			ELCBJIHCLBC eLCBJIHCLBC = new ELCBJIHCLBC();
			eLCBJIHCLBC.KNIAJMGDGAA = this;
			eLCBJIHCLBC.GOMFKPLCGNN = 22;
			return eLCBJIHCLBC;
		}

		public virtual FEAILBGBEPH EDOMIOMPMOM(int GAALDFOOJBD)
		{
			if (GAALDFOOJBD < 1 || GAALDFOOJBD >= IBMGIKHCNJO.Count)
			{
				return null;
			}
			FEAILBGBEPH result = IBMGIKHCNJO[GAALDFOOJBD];
			IBMGIKHCNJO.RemoveAt(GAALDFOOJBD);
			return result;
		}
	}
}
