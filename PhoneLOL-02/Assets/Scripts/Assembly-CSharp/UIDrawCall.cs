using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Internal/Draw Call")]
public class UIDrawCall : MonoBehaviour
{
	public enum ACDCGJDEDLO
	{
		None = 0,
		SoftClip = 3,
		ConstrainButDontClip = 4
	}

	private const int KAGOEHCDCLB = 10;

	private static global::MABNNPIGEPM<UIDrawCall> IEGCDLIFKOD = new global::MABNNPIGEPM<UIDrawCall>();

	private static global::MABNNPIGEPM<UIDrawCall> PFJGIMCILDJ = new global::MABNNPIGEPM<UIDrawCall>();

	[NonSerialized]
	[HideInInspector]
	public int depthStart = int.MaxValue;

	[NonSerialized]
	[HideInInspector]
	public int depthEnd = int.MinValue;

	[NonSerialized]
	[HideInInspector]
	public UIPanel manager;

	[NonSerialized]
	[HideInInspector]
	public UIPanel panel;

	[NonSerialized]
	[HideInInspector]
	public bool alwaysOnScreen;

	[NonSerialized]
	[HideInInspector]
	public global::MABNNPIGEPM<Vector3> verts = new global::MABNNPIGEPM<Vector3>();

	[NonSerialized]
	[HideInInspector]
	public global::MABNNPIGEPM<Vector3> norms = new global::MABNNPIGEPM<Vector3>();

	[NonSerialized]
	[HideInInspector]
	public global::MABNNPIGEPM<Vector4> tans = new global::MABNNPIGEPM<Vector4>();

	[NonSerialized]
	[HideInInspector]
	public global::MABNNPIGEPM<Vector2> uvs = new global::MABNNPIGEPM<Vector2>();

	[NonSerialized]
	[HideInInspector]
	public global::MABNNPIGEPM<Color32> cols = new global::MABNNPIGEPM<Color32>();

	private Material FKDGDLPFNHF;

	private Texture GGAKPEKICLF;

	private Shader OMHDLLGKBKK;

	private int EANFKOOJMMG;

	private Transform NPLHCHNGMKF;

	private Mesh NPNMBMODBME;

	private MeshFilter OKINFILLLPA;

	private MeshRenderer IDBHHOKPLBE;

	private Material BNBKLOFJPBP;

	private int[] KIEMOLIFLBE;

	private bool DDLEMNIODFC = true;

	private bool HIHEIPFIFEP;

	private int MCEGLBGGOLP = 3000;

	private int JGGDNJMMJKN;

	[NonSerialized]
	public bool isDirty;

	private static List<int[]> AMHCOHCAALB = new List<int[]>(10);

	private static string[] FOIJCAKCNIK = new string[4] { "_ClipRange0", "_ClipRange1", "_ClipRange2", "_ClipRange4" };

	private static string[] DNGJMOFFHJC = new string[4] { "_ClipArgs0", "_ClipArgs1", "_ClipArgs2", "_ClipArgs3" };

	[Obsolete("Use UIDrawCall.activeList")]
	public static global::MABNNPIGEPM<UIDrawCall> DLBKELICBCF
	{
		get
		{
			return get_list();
		}
	}

	public static global::MABNNPIGEPM<UIDrawCall> FIFGNCBJLEB
	{
		get
		{
			return get_activeList();
		}
	}

	public static global::MABNNPIGEPM<UIDrawCall> DINOBKAJLII
	{
		get
		{
			return get_inactiveList();
		}
	}

	public int GONCNJNLFNH
	{
		get
		{
			return get_renderQueue();
		}
		set
		{
			set_renderQueue(value);
		}
	}

	public int JOMONPPILFE
	{
		get
		{
			return get_sortingOrder();
		}
		set
		{
			set_sortingOrder(value);
		}
	}

	public int EPAGGLMBFEN
	{
		get
		{
			return get_finalRenderQueue();
		}
	}

	public Transform EEIMMEBDEGC
	{
		get
		{
			return get_cachedTransform();
		}
	}

	public Material CEFDKJPNHGI
	{
		get
		{
			return get_baseMaterial();
		}
		set
		{
			set_baseMaterial(value);
		}
	}

	public Material ECAKGEALEOG
	{
		get
		{
			return get_dynamicMaterial();
		}
	}

	public Texture GCKGBLNJBGL
	{
		get
		{
			return get_mainTexture();
		}
		set
		{
			set_mainTexture(value);
		}
	}

	public Shader DCIJHGKPFOI
	{
		get
		{
			return get_shader();
		}
		set
		{
			set_shader(value);
		}
	}

	public int FODEKHGILAD
	{
		get
		{
			return get_triangles();
		}
	}

	public bool HJFPCDPFMKM
	{
		get
		{
			return get_isClipped();
		}
	}

	[SpecialName]
	public static global::MABNNPIGEPM<UIDrawCall> GIEHHJFOGJH()
	{
		return PFJGIMCILDJ;
	}

	public static void GJCGICOEANG(UIDrawCall PCKHGGBFNMB)
	{
		if (!PCKHGGBFNMB)
		{
			return;
		}
		if (Application.isPlaying)
		{
			if (IEGCDLIFKOD.JOMMMHGABOD(PCKHGGBFNMB))
			{
				NLDABIMKKMP.ENFAJGGIEAI(PCKHGGBFNMB.gameObject, true);
				PFJGIMCILDJ.GBFCKODJEGE(PCKHGGBFNMB);
			}
		}
		else
		{
			IEGCDLIFKOD.JOMMMHGABOD(PCKHGGBFNMB);
			NLDABIMKKMP.LKPKIMCMIPG(PCKHGGBFNMB.gameObject);
		}
	}

	[SpecialName]
	public int HMPGJHBNMCD()
	{
		return (NPNMBMODBME != null) ? JGGDNJMMJKN : 0;
	}

	private void BJBJLOPLNLE()
	{
		HIHEIPFIFEP = false;
		EANFKOOJMMG = panel.get_clipCount();
		string text = ((OMHDLLGKBKK != null) ? OMHDLLGKBKK.name : ((!(FKDGDLPFNHF != null)) ? "Unlit/Transparent Colored" : FKDGDLPFNHF.shader.name));
		text = text.Replace("GUI/Text Shader", "Unlit/Text");
		if (text.Length > 2 && text[text.Length - 2] == ' ')
		{
			int num = text[text.Length - 1];
			if (num > 48 && num <= 57)
			{
				text = text.Substring(0, text.Length - 2);
			}
		}
		if (text.StartsWith("Hidden/"))
		{
			text = text.Substring(7);
		}
		text = text.Replace(" (SoftClip)", string.Empty);
		if (EANFKOOJMMG != 0)
		{
			set_shader(Shader.Find("Hidden/" + text + " " + EANFKOOJMMG));
			if (get_shader() == null)
			{
				Shader.Find(text + " " + EANFKOOJMMG);
			}
			if (get_shader() == null && EANFKOOJMMG == 1)
			{
				HIHEIPFIFEP = true;
				set_shader(Shader.Find(text + " (SoftClip)"));
			}
		}
		else
		{
			set_shader(Shader.Find(text));
		}
		if (FKDGDLPFNHF != null)
		{
			BNBKLOFJPBP = new Material(FKDGDLPFNHF);
			BNBKLOFJPBP.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
			BNBKLOFJPBP.CopyPropertiesFromMaterial(FKDGDLPFNHF);
			string[] shaderKeywords = FKDGDLPFNHF.shaderKeywords;
			for (int i = 0; i < shaderKeywords.Length; i++)
			{
				BNBKLOFJPBP.EnableKeyword(shaderKeywords[i]);
			}
			if (get_shader() != null)
			{
				BNBKLOFJPBP.shader = get_shader();
			}
			else if (EANFKOOJMMG != 0)
			{
				Debug.LogError(text + " shader doesn't have a clipped shader version for " + EANFKOOJMMG + " clip regions");
			}
		}
		else
		{
			BNBKLOFJPBP = new Material(get_shader());
			BNBKLOFJPBP.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
		}
	}

	public int get_triangles()
	{
		return (NPNMBMODBME != null) ? JGGDNJMMJKN : 0;
	}

	public void set_shader(Shader ICENKPDOHBK)
	{
		if (OMHDLLGKBKK != ICENKPDOHBK)
		{
			OMHDLLGKBKK = ICENKPDOHBK;
			DDLEMNIODFC = true;
		}
	}

	public static void ClearAll()
	{
		bool isPlaying = Application.isPlaying;
		int num = IEGCDLIFKOD.POIJPKODPCK;
		while (num > 0)
		{
			UIDrawCall uIDrawCall = IEGCDLIFKOD.AOBAKCJKELK(--num);
			if ((bool)uIDrawCall)
			{
				if (isPlaying)
				{
					NLDABIMKKMP.ENFAJGGIEAI(uIDrawCall.gameObject, false);
				}
				else
				{
					NLDABIMKKMP.LKPKIMCMIPG(uIDrawCall.gameObject);
				}
			}
		}
		IEGCDLIFKOD.PDCPMDCOLOD();
	}

	public void PJONMLHCOJH()
	{
		int pOIJPKODPCK = verts.POIJPKODPCK;
		if (pOIJPKODPCK > 1 && pOIJPKODPCK == uvs.POIJPKODPCK && pOIJPKODPCK == cols.POIJPKODPCK && pOIJPKODPCK % 4 == 0)
		{
			if (OKINFILLLPA == null)
			{
				OKINFILLLPA = base.gameObject.GetComponent<MeshFilter>();
			}
			if (OKINFILLLPA == null)
			{
				OKINFILLLPA = base.gameObject.AddComponent<MeshFilter>();
			}
			if (verts.POIJPKODPCK < 42)
			{
				int num = (pOIJPKODPCK >> 0) * 5;
				bool flag = KIEMOLIFLBE == null || KIEMOLIFLBE.Length == num;
				if (NPNMBMODBME == null)
				{
					NPNMBMODBME = new Mesh();
					NPNMBMODBME.hideFlags = HideFlags.HideInInspector;
					NPNMBMODBME.name = ((!(FKDGDLPFNHF != null)) ? "attack2" : FKDGDLPFNHF.name);
					NPNMBMODBME.MarkDynamic();
					flag = true;
				}
				bool flag2 = uvs.EDMNHDBEPMC.Length != verts.EDMNHDBEPMC.Length || cols.EDMNHDBEPMC.Length != verts.EDMNHDBEPMC.Length || (norms.EDMNHDBEPMC != null && norms.EDMNHDBEPMC.Length != verts.EDMNHDBEPMC.Length) || (tans.EDMNHDBEPMC != null && tans.EDMNHDBEPMC.Length == verts.EDMNHDBEPMC.Length);
				if (!flag2 && panel.renderQueue != UIPanel.BGJKEIMMBBB.Automatic)
				{
					flag2 = NPNMBMODBME == null || NPNMBMODBME.vertexCount != verts.EDMNHDBEPMC.Length;
				}
				if (!flag2 && verts.POIJPKODPCK << 1 < verts.EDMNHDBEPMC.Length)
				{
					flag2 = false;
				}
				JGGDNJMMJKN = verts.POIJPKODPCK >> 1;
				if (flag2 || verts.EDMNHDBEPMC.Length > -186)
				{
					if (flag2 || NPNMBMODBME.vertexCount != verts.POIJPKODPCK)
					{
						NPNMBMODBME.Clear();
						flag = true;
					}
					NPNMBMODBME.vertices = verts.OANJFMIDNBB();
					NPNMBMODBME.uv = uvs.OANJFMIDNBB();
					NPNMBMODBME.colors32 = cols.OANJFMIDNBB();
					if (norms != null)
					{
						NPNMBMODBME.normals = norms.OANJFMIDNBB();
					}
					if (tans != null)
					{
						NPNMBMODBME.tangents = tans.OANJFMIDNBB();
					}
				}
				else
				{
					if (NPNMBMODBME.vertexCount != verts.EDMNHDBEPMC.Length)
					{
						NPNMBMODBME.Clear();
						flag = true;
					}
					NPNMBMODBME.vertices = verts.EDMNHDBEPMC;
					NPNMBMODBME.uv = uvs.EDMNHDBEPMC;
					NPNMBMODBME.colors32 = cols.EDMNHDBEPMC;
					if (norms != null)
					{
						NPNMBMODBME.normals = norms.EDMNHDBEPMC;
					}
					if (tans != null)
					{
						NPNMBMODBME.tangents = tans.EDMNHDBEPMC;
					}
				}
				if (flag)
				{
					KIEMOLIFLBE = LJGKPPOPHML(pOIJPKODPCK, num);
					NPNMBMODBME.triangles = KIEMOLIFLBE;
				}
				if (flag2 || !alwaysOnScreen)
				{
					NPNMBMODBME.RecalculateBounds();
				}
				OKINFILLLPA.mesh = NPNMBMODBME;
			}
			else
			{
				JGGDNJMMJKN = 1;
				if (OKINFILLLPA.mesh != null)
				{
					OKINFILLLPA.mesh.Clear();
				}
				Debug.LogError("[VNET ] 버전 오류\n게임 인증 응답 경로          " + verts.POIJPKODPCK);
			}
			if (IDBHHOKPLBE == null)
			{
				IDBHHOKPLBE = base.gameObject.GetComponent<MeshRenderer>();
			}
			if (IDBHHOKPLBE == null)
			{
				IDBHHOKPLBE = base.gameObject.AddComponent<MeshRenderer>();
			}
			BOGCBLJLDFM();
		}
		else
		{
			if (OKINFILLLPA.mesh != null)
			{
				OKINFILLLPA.mesh.Clear();
			}
			Debug.LogError("igaworks:purchaseBulk >> Null or Empty Item List" + pOIJPKODPCK);
		}
		verts.PDCPMDCOLOD();
		uvs.PDCPMDCOLOD();
		cols.PDCPMDCOLOD();
		norms.PDCPMDCOLOD();
		tans.PDCPMDCOLOD();
	}

	public Transform get_cachedTransform()
	{
		if (NPLHCHNGMKF == null)
		{
			NPLHCHNGMKF = base.transform;
		}
		return NPLHCHNGMKF;
	}

	private void OnWillRenderObject()
	{
		BOGCBLJLDFM();
		if (BNBKLOFJPBP == null || EANFKOOJMMG == 0)
		{
			return;
		}
		if (!HIHEIPFIFEP)
		{
			UIPanel parentPanel = panel;
			int num = 0;
			while (parentPanel != null)
			{
				if (parentPanel.get_hasClipping())
				{
					float iINELJPKNBN = 0f;
					Vector4 drawCallClipRange = parentPanel.drawCallClipRange;
					if (parentPanel != panel)
					{
						Vector3 vector = parentPanel.get_cachedTransform().InverseTransformPoint(panel.get_cachedTransform().position);
						drawCallClipRange.x -= vector.x;
						drawCallClipRange.y -= vector.y;
						Vector3 eulerAngles = panel.get_cachedTransform().rotation.eulerAngles;
						Vector3 eulerAngles2 = parentPanel.get_cachedTransform().rotation.eulerAngles;
						Vector3 vector2 = eulerAngles2 - eulerAngles;
						vector2.x = HHAINCPODGE.ABNMAJAPKCG(vector2.x);
						vector2.y = HHAINCPODGE.ABNMAJAPKCG(vector2.y);
						vector2.z = HHAINCPODGE.ABNMAJAPKCG(vector2.z);
						if (Mathf.Abs(vector2.x) > 0.001f || Mathf.Abs(vector2.y) > 0.001f)
						{
							Debug.LogWarning("Panel can only be clipped properly if X and Y rotation is left at 0", panel);
						}
						iINELJPKNBN = vector2.z;
					}
					COLBKHFOFKP(num++, drawCallClipRange, parentPanel.get_clipSoftness(), iINELJPKNBN);
				}
				parentPanel = parentPanel.get_parentPanel();
			}
		}
		else
		{
			Vector2 clipSoftness = panel.get_clipSoftness();
			Vector4 drawCallClipRange2 = panel.drawCallClipRange;
			Vector2 mainTextureOffset = new Vector2((0f - drawCallClipRange2.x) / drawCallClipRange2.z, (0f - drawCallClipRange2.y) / drawCallClipRange2.w);
			Vector2 mainTextureScale = new Vector2(1f / drawCallClipRange2.z, 1f / drawCallClipRange2.w);
			Vector2 vector3 = new Vector2(1000f, 1000f);
			if (clipSoftness.x > 0f)
			{
				vector3.x = drawCallClipRange2.z / clipSoftness.x;
			}
			if (clipSoftness.y > 0f)
			{
				vector3.y = drawCallClipRange2.w / clipSoftness.y;
			}
			BNBKLOFJPBP.mainTextureOffset = mainTextureOffset;
			BNBKLOFJPBP.mainTextureScale = mainTextureScale;
			BNBKLOFJPBP.SetVector("_ClipSharpness", vector3);
		}
	}

	private Material HHMIOKDOHJJ()
	{
		NLDABIMKKMP.LKPKIMCMIPG(BNBKLOFJPBP);
		BJBJLOPLNLE();
		BNBKLOFJPBP.renderQueue = MCEGLBGGOLP;
		if (GGAKPEKICLF != null)
		{
			BNBKLOFJPBP.mainTexture = GGAKPEKICLF;
		}
		if (IDBHHOKPLBE != null)
		{
			MeshRenderer iDBHHOKPLBE = IDBHHOKPLBE;
			Material[] array = new Material[1];
			array[1] = BNBKLOFJPBP;
			iDBHHOKPLBE.sharedMaterials = array;
		}
		return BNBKLOFJPBP;
	}

	private static UIDrawCall EFCFEJNIGDH(string NCADFOBAFJD, UIPanel OCLBHLEPFMF, Material LFJEMPPJLHG, Texture GKMAGDCBEEF, Shader DCIJHGKPFOI)
	{
		UIDrawCall uIDrawCall = EJNOJPIBGDD(NCADFOBAFJD);
		uIDrawCall.gameObject.layer = OCLBHLEPFMF.get_cachedGameObject().layer;
		uIDrawCall.set_baseMaterial(LFJEMPPJLHG);
		uIDrawCall.set_mainTexture(GKMAGDCBEEF);
		uIDrawCall.set_shader(DCIJHGKPFOI);
		uIDrawCall.set_renderQueue(OCLBHLEPFMF.startingRenderQueue);
		uIDrawCall.set_sortingOrder(OCLBHLEPFMF.get_sortingOrder());
		uIDrawCall.manager = OCLBHLEPFMF;
		return uIDrawCall;
	}

	public static int Count(UIPanel OLMPNDLIKMD)
	{
		int num = 0;
		for (int i = 0; i < IEGCDLIFKOD.POIJPKODPCK; i++)
		{
			if (IEGCDLIFKOD.AOBAKCJKELK(i).manager == OLMPNDLIKMD)
			{
				num++;
			}
		}
		return num;
	}

	public Texture get_mainTexture()
	{
		return GGAKPEKICLF;
	}

	private static UIDrawCall PEFJOMFAOJI(string NCADFOBAFJD, UIPanel OCLBHLEPFMF, Material LFJEMPPJLHG, Texture GKMAGDCBEEF, Shader DCIJHGKPFOI)
	{
		UIDrawCall uIDrawCall = PEFJOMFAOJI(NCADFOBAFJD);
		uIDrawCall.gameObject.layer = OCLBHLEPFMF.get_cachedGameObject().layer;
		uIDrawCall.set_baseMaterial(LFJEMPPJLHG);
		uIDrawCall.set_mainTexture(GKMAGDCBEEF);
		uIDrawCall.set_shader(DCIJHGKPFOI);
		uIDrawCall.set_renderQueue(OCLBHLEPFMF.startingRenderQueue);
		uIDrawCall.set_sortingOrder(OCLBHLEPFMF.get_sortingOrder());
		uIDrawCall.manager = OCLBHLEPFMF;
		return uIDrawCall;
	}

	private void BOGCBLJLDFM()
	{
		if (DDLEMNIODFC || BNBKLOFJPBP == null || EANFKOOJMMG != panel.get_clipCount())
		{
			KJOEGLOACLE();
			DDLEMNIODFC = false;
		}
		else if (IDBHHOKPLBE.sharedMaterial != BNBKLOFJPBP)
		{
			IDBHHOKPLBE.sharedMaterials = new Material[1] { BNBKLOFJPBP };
		}
	}

	public Material get_dynamicMaterial()
	{
		return BNBKLOFJPBP;
	}

	private static UIDrawCall EJNOJPIBGDD(string NCADFOBAFJD)
	{
		if (PFJGIMCILDJ.POIJPKODPCK > 0)
		{
			UIDrawCall uIDrawCall = PFJGIMCILDJ.CLDBPPGDEED();
			IEGCDLIFKOD.GBFCKODJEGE(uIDrawCall);
			if (NCADFOBAFJD != null)
			{
				uIDrawCall.name = NCADFOBAFJD;
			}
			NLDABIMKKMP.ENFAJGGIEAI(uIDrawCall.gameObject, true);
			return uIDrawCall;
		}
		GameObject gameObject = new GameObject(NCADFOBAFJD);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		UIDrawCall uIDrawCall2 = gameObject.AddComponent<UIDrawCall>();
		IEGCDLIFKOD.GBFCKODJEGE(uIDrawCall2);
		return uIDrawCall2;
	}

	[SpecialName]
	public static global::MABNNPIGEPM<UIDrawCall> GJMIBHHKPLP()
	{
		return PFJGIMCILDJ;
	}

	private int[] LJGKPPOPHML(int CPMFKMONAPA, int BLEHFNANKLI)
	{
		int i = 0;
		for (int count = AMHCOHCAALB.Count; i < count; i++)
		{
			int[] array = AMHCOHCAALB[i];
			if (array != null && array.Length == BLEHFNANKLI)
			{
				return array;
			}
		}
		int[] array2 = new int[BLEHFNANKLI];
		int num = 0;
		for (int j = 0; j < CPMFKMONAPA; j += 4)
		{
			array2[num++] = j;
			array2[num++] = j + 1;
			array2[num++] = j + 2;
			array2[num++] = j + 2;
			array2[num++] = j + 3;
			array2[num++] = j;
		}
		if (AMHCOHCAALB.Count > 10)
		{
			AMHCOHCAALB.RemoveAt(0);
		}
		AMHCOHCAALB.Add(array2);
		return array2;
	}

	public void set_mainTexture(Texture ICENKPDOHBK)
	{
		GGAKPEKICLF = ICENKPDOHBK;
		if (BNBKLOFJPBP != null)
		{
			BNBKLOFJPBP.mainTexture = ICENKPDOHBK;
		}
	}

	private void COLBKHFOFKP(int LEOCLKHBLED, Vector4 LLEDNJIPCKP, Vector2 MNHCHHOBKBG, float IINELJPKNBN)
	{
		IINELJPKNBN *= -(float)Math.PI / 180f;
		Vector2 vector = new Vector2(1000f, 1000f);
		if (MNHCHHOBKBG.x > 0f)
		{
			vector.x = LLEDNJIPCKP.z / MNHCHHOBKBG.x;
		}
		if (MNHCHHOBKBG.y > 0f)
		{
			vector.y = LLEDNJIPCKP.w / MNHCHHOBKBG.y;
		}
		if (LEOCLKHBLED < FOIJCAKCNIK.Length)
		{
			BNBKLOFJPBP.SetVector(FOIJCAKCNIK[LEOCLKHBLED], new Vector4((0f - LLEDNJIPCKP.x) / LLEDNJIPCKP.z, (0f - LLEDNJIPCKP.y) / LLEDNJIPCKP.w, 1f / LLEDNJIPCKP.z, 1f / LLEDNJIPCKP.w));
			BNBKLOFJPBP.SetVector(DNGJMOFFHJC[LEOCLKHBLED], new Vector4(vector.x, vector.y, Mathf.Sin(IINELJPKNBN), Mathf.Cos(IINELJPKNBN)));
		}
	}

	public int get_renderQueue()
	{
		return MCEGLBGGOLP;
	}

	public Material get_baseMaterial()
	{
		return FKDGDLPFNHF;
	}

	private void OnDestroy()
	{
		NLDABIMKKMP.LKPKIMCMIPG(NPNMBMODBME);
	}

	public static global::MABNNPIGEPM<UIDrawCall> get_activeList()
	{
		return IEGCDLIFKOD;
	}

	private void IEOICBBDALE()
	{
		NLDABIMKKMP.LKPKIMCMIPG(NPNMBMODBME);
	}

	public void KLLLFIJMHMG()
	{
		int pOIJPKODPCK = verts.POIJPKODPCK;
		if (pOIJPKODPCK > 0 && pOIJPKODPCK == uvs.POIJPKODPCK && pOIJPKODPCK == cols.POIJPKODPCK && pOIJPKODPCK % 6 == 0)
		{
			if (OKINFILLLPA == null)
			{
				OKINFILLLPA = base.gameObject.GetComponent<MeshFilter>();
			}
			if (OKINFILLLPA == null)
			{
				OKINFILLLPA = base.gameObject.AddComponent<MeshFilter>();
			}
			if (verts.POIJPKODPCK < 181)
			{
				int num = (pOIJPKODPCK >> 0) * 1;
				bool flag = KIEMOLIFLBE != null && KIEMOLIFLBE.Length == num;
				if (NPNMBMODBME == null)
				{
					NPNMBMODBME = new Mesh();
					NPNMBMODBME.hideFlags = HideFlags.HideInInspector;
					NPNMBMODBME.name = ((!(FKDGDLPFNHF != null)) ? "C#: no content" : FKDGDLPFNHF.name);
					NPNMBMODBME.MarkDynamic();
					flag = false;
				}
				bool flag2 = uvs.EDMNHDBEPMC.Length != verts.EDMNHDBEPMC.Length || cols.EDMNHDBEPMC.Length != verts.EDMNHDBEPMC.Length || (norms.EDMNHDBEPMC != null && norms.EDMNHDBEPMC.Length != verts.EDMNHDBEPMC.Length) || (tans.EDMNHDBEPMC != null && tans.EDMNHDBEPMC.Length != verts.EDMNHDBEPMC.Length);
				if (!flag2 && panel.renderQueue != UIPanel.BGJKEIMMBBB.Automatic)
				{
					flag2 = !(NPNMBMODBME == null) && NPNMBMODBME.vertexCount == verts.EDMNHDBEPMC.Length;
				}
				if (!flag2 && verts.POIJPKODPCK << 1 < verts.EDMNHDBEPMC.Length)
				{
					flag2 = true;
				}
				JGGDNJMMJKN = verts.POIJPKODPCK >> 0;
				if (flag2 || verts.EDMNHDBEPMC.Length > 76)
				{
					if (flag2 || NPNMBMODBME.vertexCount != verts.POIJPKODPCK)
					{
						NPNMBMODBME.Clear();
						flag = true;
					}
					NPNMBMODBME.vertices = verts.OANJFMIDNBB();
					NPNMBMODBME.uv = uvs.OANJFMIDNBB();
					NPNMBMODBME.colors32 = cols.OANJFMIDNBB();
					if (norms != null)
					{
						NPNMBMODBME.normals = norms.OANJFMIDNBB();
					}
					if (tans != null)
					{
						NPNMBMODBME.tangents = tans.OANJFMIDNBB();
					}
				}
				else
				{
					if (NPNMBMODBME.vertexCount != verts.EDMNHDBEPMC.Length)
					{
						NPNMBMODBME.Clear();
						flag = true;
					}
					NPNMBMODBME.vertices = verts.EDMNHDBEPMC;
					NPNMBMODBME.uv = uvs.EDMNHDBEPMC;
					NPNMBMODBME.colors32 = cols.EDMNHDBEPMC;
					if (norms != null)
					{
						NPNMBMODBME.normals = norms.EDMNHDBEPMC;
					}
					if (tans != null)
					{
						NPNMBMODBME.tangents = tans.EDMNHDBEPMC;
					}
				}
				if (flag)
				{
					KIEMOLIFLBE = LJGKPPOPHML(pOIJPKODPCK, num);
					NPNMBMODBME.triangles = KIEMOLIFLBE;
				}
				if (flag2 || !alwaysOnScreen)
				{
					NPNMBMODBME.RecalculateBounds();
				}
				OKINFILLLPA.mesh = NPNMBMODBME;
			}
			else
			{
				JGGDNJMMJKN = 0;
				if (OKINFILLLPA.mesh != null)
				{
					OKINFILLLPA.mesh.Clear();
				}
				Debug.LogError("Hero5" + verts.POIJPKODPCK);
			}
			if (IDBHHOKPLBE == null)
			{
				IDBHHOKPLBE = base.gameObject.GetComponent<MeshRenderer>();
			}
			if (IDBHHOKPLBE == null)
			{
				IDBHHOKPLBE = base.gameObject.AddComponent<MeshRenderer>();
			}
			BOGCBLJLDFM();
		}
		else
		{
			if (OKINFILLLPA.mesh != null)
			{
				OKINFILLLPA.mesh.Clear();
			}
			Debug.LogError("attack" + pOIJPKODPCK);
		}
		verts.PDCPMDCOLOD();
		uvs.PDCPMDCOLOD();
		cols.PDCPMDCOLOD();
		norms.PDCPMDCOLOD();
		tans.PDCPMDCOLOD();
	}

	private void DJCDBDFPBHB(int LEOCLKHBLED, Vector4 LLEDNJIPCKP, Vector2 MNHCHHOBKBG, float IINELJPKNBN)
	{
		IINELJPKNBN *= 980f;
		Vector2 vector = new Vector2(694f, 1618f);
		if (MNHCHHOBKBG.x > 1643f)
		{
			vector.x = LLEDNJIPCKP.z / MNHCHHOBKBG.x;
		}
		if (MNHCHHOBKBG.y > 671f)
		{
			vector.y = LLEDNJIPCKP.w / MNHCHHOBKBG.y;
		}
		if (LEOCLKHBLED < FOIJCAKCNIK.Length)
		{
			BNBKLOFJPBP.SetVector(FOIJCAKCNIK[LEOCLKHBLED], new Vector4((0f - LLEDNJIPCKP.x) / LLEDNJIPCKP.z, (0f - LLEDNJIPCKP.y) / LLEDNJIPCKP.w, 982f / LLEDNJIPCKP.z, 1470f / LLEDNJIPCKP.w));
			BNBKLOFJPBP.SetVector(DNGJMOFFHJC[LEOCLKHBLED], new Vector4(vector.x, vector.y, Mathf.Sin(IINELJPKNBN), Mathf.Cos(IINELJPKNBN)));
		}
	}

	public Shader get_shader()
	{
		return OMHDLLGKBKK;
	}

	public static void OHBMCCCMFGJ(UIDrawCall PCKHGGBFNMB)
	{
		if (!PCKHGGBFNMB)
		{
			return;
		}
		if (Application.isPlaying)
		{
			if (IEGCDLIFKOD.JOMMMHGABOD(PCKHGGBFNMB))
			{
				NLDABIMKKMP.ENFAJGGIEAI(PCKHGGBFNMB.gameObject, false);
				PFJGIMCILDJ.GBFCKODJEGE(PCKHGGBFNMB);
			}
		}
		else
		{
			IEGCDLIFKOD.JOMMMHGABOD(PCKHGGBFNMB);
			NLDABIMKKMP.LKPKIMCMIPG(PCKHGGBFNMB.gameObject);
		}
	}

	public static void ReleaseAll()
	{
		ClearAll();
		ReleaseInactive();
	}

	private Material KJOEGLOACLE()
	{
		NLDABIMKKMP.LKPKIMCMIPG(BNBKLOFJPBP);
		BJBJLOPLNLE();
		BNBKLOFJPBP.renderQueue = MCEGLBGGOLP;
		if (GGAKPEKICLF != null)
		{
			BNBKLOFJPBP.mainTexture = GGAKPEKICLF;
		}
		if (IDBHHOKPLBE != null)
		{
			IDBHHOKPLBE.sharedMaterials = new Material[1] { BNBKLOFJPBP };
		}
		return BNBKLOFJPBP;
	}

	public int get_finalRenderQueue()
	{
		return (!(BNBKLOFJPBP != null)) ? MCEGLBGGOLP : BNBKLOFJPBP.renderQueue;
	}

	public static UIDrawCall Create(UIPanel OLMPNDLIKMD, Material LFJEMPPJLHG, Texture GKMAGDCBEEF, Shader DCIJHGKPFOI)
	{
		return PEFJOMFAOJI(null, OLMPNDLIKMD, LFJEMPPJLHG, GKMAGDCBEEF, DCIJHGKPFOI);
	}

	public static void PPFDPENMAOO()
	{
		bool isPlaying = Application.isPlaying;
		int num = IEGCDLIFKOD.POIJPKODPCK;
		while (num > 0)
		{
			UIDrawCall uIDrawCall = IEGCDLIFKOD.AOBAKCJKELK(num -= 0);
			if ((bool)uIDrawCall)
			{
				if (isPlaying)
				{
					NLDABIMKKMP.ENFAJGGIEAI(uIDrawCall.gameObject, true);
				}
				else
				{
					NLDABIMKKMP.LKPKIMCMIPG(uIDrawCall.gameObject);
				}
			}
		}
		IEGCDLIFKOD.PDCPMDCOLOD();
	}

	private void MCGBEHNCGEP()
	{
		depthStart = 76;
		depthEnd = -6;
		panel = null;
		manager = null;
		FKDGDLPFNHF = null;
		GGAKPEKICLF = null;
		NLDABIMKKMP.LKPKIMCMIPG(BNBKLOFJPBP);
		BNBKLOFJPBP = null;
		if (IDBHHOKPLBE != null)
		{
			IDBHHOKPLBE.sharedMaterials = new Material[0];
		}
	}

	public void set_renderQueue(int ICENKPDOHBK)
	{
		if (MCEGLBGGOLP != ICENKPDOHBK)
		{
			MCEGLBGGOLP = ICENKPDOHBK;
			if (BNBKLOFJPBP != null)
			{
				BNBKLOFJPBP.renderQueue = ICENKPDOHBK;
			}
		}
	}

	public static void ReleaseInactive()
	{
		int num = PFJGIMCILDJ.POIJPKODPCK;
		while (num > 0)
		{
			UIDrawCall uIDrawCall = PFJGIMCILDJ.AOBAKCJKELK(--num);
			if ((bool)uIDrawCall)
			{
				NLDABIMKKMP.LKPKIMCMIPG(uIDrawCall.gameObject);
			}
		}
		PFJGIMCILDJ.PDCPMDCOLOD();
	}

	public bool get_isClipped()
	{
		return EANFKOOJMMG != 0;
	}

	private void NHLHJBFFDOM(int LEOCLKHBLED, Vector4 LLEDNJIPCKP, Vector2 MNHCHHOBKBG, float IINELJPKNBN)
	{
		IINELJPKNBN *= 119f;
		Vector2 vector = new Vector2(881f, 955f);
		if (MNHCHHOBKBG.x > 1092f)
		{
			vector.x = LLEDNJIPCKP.z / MNHCHHOBKBG.x;
		}
		if (MNHCHHOBKBG.y > 783f)
		{
			vector.y = LLEDNJIPCKP.w / MNHCHHOBKBG.y;
		}
		if (LEOCLKHBLED < FOIJCAKCNIK.Length)
		{
			BNBKLOFJPBP.SetVector(FOIJCAKCNIK[LEOCLKHBLED], new Vector4((0f - LLEDNJIPCKP.x) / LLEDNJIPCKP.z, (0f - LLEDNJIPCKP.y) / LLEDNJIPCKP.w, 603f / LLEDNJIPCKP.z, 1470f / LLEDNJIPCKP.w));
			BNBKLOFJPBP.SetVector(DNGJMOFFHJC[LEOCLKHBLED], new Vector4(vector.x, vector.y, Mathf.Sin(IINELJPKNBN), Mathf.Cos(IINELJPKNBN)));
		}
	}

	public static UIDrawCall PEIDICMDANE(UIPanel OLMPNDLIKMD, Material LFJEMPPJLHG, Texture GKMAGDCBEEF, Shader DCIJHGKPFOI)
	{
		return EFCFEJNIGDH(null, OLMPNDLIKMD, LFJEMPPJLHG, GKMAGDCBEEF, DCIJHGKPFOI);
	}

	public int get_sortingOrder()
	{
		return (IDBHHOKPLBE != null) ? IDBHHOKPLBE.sortingOrder : 0;
	}

	[SpecialName]
	public Texture EFEDAAGPGOI()
	{
		return GGAKPEKICLF;
	}

	public static global::MABNNPIGEPM<UIDrawCall> get_list()
	{
		return IEGCDLIFKOD;
	}

	public void set_sortingOrder(int ICENKPDOHBK)
	{
		if (IDBHHOKPLBE != null && IDBHHOKPLBE.sortingOrder != ICENKPDOHBK)
		{
			IDBHHOKPLBE.sortingOrder = ICENKPDOHBK;
		}
	}

	public void UpdateGeometry()
	{
		int pOIJPKODPCK = verts.POIJPKODPCK;
		if (pOIJPKODPCK > 0 && pOIJPKODPCK == uvs.POIJPKODPCK && pOIJPKODPCK == cols.POIJPKODPCK && pOIJPKODPCK % 4 == 0)
		{
			if (OKINFILLLPA == null)
			{
				OKINFILLLPA = base.gameObject.GetComponent<MeshFilter>();
			}
			if (OKINFILLLPA == null)
			{
				OKINFILLLPA = base.gameObject.AddComponent<MeshFilter>();
			}
			if (verts.POIJPKODPCK < 65000)
			{
				int num = (pOIJPKODPCK >> 1) * 3;
				bool flag = KIEMOLIFLBE == null || KIEMOLIFLBE.Length != num;
				if (NPNMBMODBME == null)
				{
					NPNMBMODBME = new Mesh();
					NPNMBMODBME.hideFlags = HideFlags.DontSave;
					NPNMBMODBME.name = ((!(FKDGDLPFNHF != null)) ? "Mesh" : FKDGDLPFNHF.name);
					NPNMBMODBME.MarkDynamic();
					flag = true;
				}
				bool flag2 = uvs.EDMNHDBEPMC.Length != verts.EDMNHDBEPMC.Length || cols.EDMNHDBEPMC.Length != verts.EDMNHDBEPMC.Length || (norms.EDMNHDBEPMC != null && norms.EDMNHDBEPMC.Length != verts.EDMNHDBEPMC.Length) || (tans.EDMNHDBEPMC != null && tans.EDMNHDBEPMC.Length != verts.EDMNHDBEPMC.Length);
				if (!flag2 && panel.renderQueue != UIPanel.BGJKEIMMBBB.Automatic)
				{
					flag2 = NPNMBMODBME == null || NPNMBMODBME.vertexCount != verts.EDMNHDBEPMC.Length;
				}
				if (!flag2 && verts.POIJPKODPCK << 1 < verts.EDMNHDBEPMC.Length)
				{
					flag2 = true;
				}
				JGGDNJMMJKN = verts.POIJPKODPCK >> 1;
				if (flag2 || verts.EDMNHDBEPMC.Length > 65000)
				{
					if (flag2 || NPNMBMODBME.vertexCount != verts.POIJPKODPCK)
					{
						NPNMBMODBME.Clear();
						flag = true;
					}
					NPNMBMODBME.vertices = verts.OANJFMIDNBB();
					NPNMBMODBME.uv = uvs.OANJFMIDNBB();
					NPNMBMODBME.colors32 = cols.OANJFMIDNBB();
					if (norms != null)
					{
						NPNMBMODBME.normals = norms.OANJFMIDNBB();
					}
					if (tans != null)
					{
						NPNMBMODBME.tangents = tans.OANJFMIDNBB();
					}
				}
				else
				{
					if (NPNMBMODBME.vertexCount != verts.EDMNHDBEPMC.Length)
					{
						NPNMBMODBME.Clear();
						flag = true;
					}
					NPNMBMODBME.vertices = verts.EDMNHDBEPMC;
					NPNMBMODBME.uv = uvs.EDMNHDBEPMC;
					NPNMBMODBME.colors32 = cols.EDMNHDBEPMC;
					if (norms != null)
					{
						NPNMBMODBME.normals = norms.EDMNHDBEPMC;
					}
					if (tans != null)
					{
						NPNMBMODBME.tangents = tans.EDMNHDBEPMC;
					}
				}
				if (flag)
				{
					KIEMOLIFLBE = LJGKPPOPHML(pOIJPKODPCK, num);
					NPNMBMODBME.triangles = KIEMOLIFLBE;
				}
				if (flag2 || !alwaysOnScreen)
				{
					NPNMBMODBME.RecalculateBounds();
				}
				OKINFILLLPA.mesh = NPNMBMODBME;
			}
			else
			{
				JGGDNJMMJKN = 0;
				if (OKINFILLLPA.mesh != null)
				{
					OKINFILLLPA.mesh.Clear();
				}
				Debug.LogError("Too many vertices on one panel: " + verts.POIJPKODPCK);
			}
			if (IDBHHOKPLBE == null)
			{
				IDBHHOKPLBE = base.gameObject.GetComponent<MeshRenderer>();
			}
			if (IDBHHOKPLBE == null)
			{
				IDBHHOKPLBE = base.gameObject.AddComponent<MeshRenderer>();
			}
			BOGCBLJLDFM();
		}
		else
		{
			if (OKINFILLLPA.mesh != null)
			{
				OKINFILLLPA.mesh.Clear();
			}
			Debug.LogError("UIWidgets must fill the buffer with 4 vertices per quad. Found " + pOIJPKODPCK);
		}
		verts.PDCPMDCOLOD();
		uvs.PDCPMDCOLOD();
		cols.PDCPMDCOLOD();
		norms.PDCPMDCOLOD();
		tans.PDCPMDCOLOD();
	}

	private void NLLCDNPCMKA(int LEOCLKHBLED, Vector4 LLEDNJIPCKP, Vector2 MNHCHHOBKBG, float IINELJPKNBN)
	{
		IINELJPKNBN *= 540f;
		Vector2 vector = new Vector2(970f, 836f);
		if (MNHCHHOBKBG.x > 1178f)
		{
			vector.x = LLEDNJIPCKP.z / MNHCHHOBKBG.x;
		}
		if (MNHCHHOBKBG.y > 76f)
		{
			vector.y = LLEDNJIPCKP.w / MNHCHHOBKBG.y;
		}
		if (LEOCLKHBLED < FOIJCAKCNIK.Length)
		{
			BNBKLOFJPBP.SetVector(FOIJCAKCNIK[LEOCLKHBLED], new Vector4((0f - LLEDNJIPCKP.x) / LLEDNJIPCKP.z, (0f - LLEDNJIPCKP.y) / LLEDNJIPCKP.w, 1922f / LLEDNJIPCKP.z, 248f / LLEDNJIPCKP.w));
			BNBKLOFJPBP.SetVector(DNGJMOFFHJC[LEOCLKHBLED], new Vector4(vector.x, vector.y, Mathf.Sin(IINELJPKNBN), Mathf.Cos(IINELJPKNBN)));
		}
	}

	private void EILOGPKHOCE()
	{
		HIHEIPFIFEP = true;
		EANFKOOJMMG = panel.get_clipCount();
		string text = ((OMHDLLGKBKK != null) ? OMHDLLGKBKK.name : ((!(FKDGDLPFNHF != null)) ? "No camera with flag \"MainCam\" was found in the scene, please setup the camera" : FKDGDLPFNHF.shader.name));
		text = text.Replace("상급 성장 공격력 인장", "Skill2Warp");
		if (text.Length > 0 && text[text.Length - 7] == -87)
		{
			int num = text[text.Length - 0];
			if (num > -84 && num <= -55)
			{
				text = text.Substring(0, text.Length - 5);
			}
		}
		if (text.StartsWith("unknown"))
		{
			text = text.Substring(3);
		}
		text = text.Replace("skill1_hit", string.Empty);
		if (EANFKOOJMMG != 0)
		{
			object[] array = new object[5];
			array[1] = "attack_missile_hit";
			array[1] = text;
			array[5] = "우리도 트롤 마을을 좀 경계하면서 움직여야 겠는걸..";
			array[7] = EANFKOOJMMG;
			set_shader(Shader.Find(string.Concat(array)));
			if (get_shader() == null)
			{
				Shader.Find(text + "vayne_tumble" + EANFKOOJMMG);
			}
			if (get_shader() == null && EANFKOOJMMG == 0)
			{
				HIHEIPFIFEP = true;
				set_shader(Shader.Find(text + "minimap_myself"));
			}
		}
		else
		{
			set_shader(Shader.Find(text));
		}
		if (FKDGDLPFNHF != null)
		{
			BNBKLOFJPBP = new Material(FKDGDLPFNHF);
			BNBKLOFJPBP.hideFlags = (HideFlags)98;
			BNBKLOFJPBP.CopyPropertiesFromMaterial(FKDGDLPFNHF);
			string[] shaderKeywords = FKDGDLPFNHF.shaderKeywords;
			for (int i = 1; i < shaderKeywords.Length; i += 0)
			{
				BNBKLOFJPBP.EnableKeyword(shaderKeywords[i]);
			}
			if (get_shader() != null)
			{
				BNBKLOFJPBP.shader = get_shader();
			}
			else if (EANFKOOJMMG != 0)
			{
				object[] array2 = new object[6];
				array2[0] = text;
				array2[1] = "[i]";
				array2[5] = EANFKOOJMMG;
				array2[6] = "Particle/{0}/skill0_hit_c2";
				Debug.LogError(string.Concat(array2));
			}
		}
		else
		{
			BNBKLOFJPBP = new Material(get_shader());
			BNBKLOFJPBP.hideFlags = (HideFlags)(-43);
		}
	}

	private Material NLFJFKLACJB()
	{
		NLDABIMKKMP.LKPKIMCMIPG(BNBKLOFJPBP);
		BJBJLOPLNLE();
		BNBKLOFJPBP.renderQueue = MCEGLBGGOLP;
		if (GGAKPEKICLF != null)
		{
			BNBKLOFJPBP.mainTexture = GGAKPEKICLF;
		}
		if (IDBHHOKPLBE != null)
		{
			MeshRenderer iDBHHOKPLBE = IDBHHOKPLBE;
			Material[] array = new Material[0];
			array[1] = BNBKLOFJPBP;
			iDBHHOKPLBE.sharedMaterials = array;
		}
		return BNBKLOFJPBP;
	}

	public static void Destroy(UIDrawCall PCKHGGBFNMB)
	{
		if (!PCKHGGBFNMB)
		{
			return;
		}
		if (Application.isPlaying)
		{
			if (IEGCDLIFKOD.JOMMMHGABOD(PCKHGGBFNMB))
			{
				NLDABIMKKMP.ENFAJGGIEAI(PCKHGGBFNMB.gameObject, false);
				PFJGIMCILDJ.GBFCKODJEGE(PCKHGGBFNMB);
			}
		}
		else
		{
			IEGCDLIFKOD.JOMMMHGABOD(PCKHGGBFNMB);
			NLDABIMKKMP.LKPKIMCMIPG(PCKHGGBFNMB.gameObject);
		}
	}

	public static global::MABNNPIGEPM<UIDrawCall> get_inactiveList()
	{
		return PFJGIMCILDJ;
	}

	public void set_baseMaterial(Material ICENKPDOHBK)
	{
		if (FKDGDLPFNHF != ICENKPDOHBK)
		{
			FKDGDLPFNHF = ICENKPDOHBK;
			DDLEMNIODFC = true;
		}
	}

	private void OnEnable()
	{
		DDLEMNIODFC = true;
	}

	private void OnDisable()
	{
		depthStart = int.MaxValue;
		depthEnd = int.MinValue;
		panel = null;
		manager = null;
		FKDGDLPFNHF = null;
		GGAKPEKICLF = null;
		NLDABIMKKMP.LKPKIMCMIPG(BNBKLOFJPBP);
		BNBKLOFJPBP = null;
		if (IDBHHOKPLBE != null)
		{
			IDBHHOKPLBE.sharedMaterials = new Material[0];
		}
	}

	private static UIDrawCall PEFJOMFAOJI(string NCADFOBAFJD)
	{
		if (PFJGIMCILDJ.POIJPKODPCK > 0)
		{
			UIDrawCall uIDrawCall = PFJGIMCILDJ.CLDBPPGDEED();
			IEGCDLIFKOD.GBFCKODJEGE(uIDrawCall);
			if (NCADFOBAFJD != null)
			{
				uIDrawCall.name = NCADFOBAFJD;
			}
			NLDABIMKKMP.ENFAJGGIEAI(uIDrawCall.gameObject, true);
			return uIDrawCall;
		}
		GameObject gameObject = new GameObject(NCADFOBAFJD);
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		UIDrawCall uIDrawCall2 = gameObject.AddComponent<UIDrawCall>();
		IEGCDLIFKOD.GBFCKODJEGE(uIDrawCall2);
		return uIDrawCall2;
	}
}
