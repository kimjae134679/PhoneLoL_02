using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Key Binding")]
public class UIKeyBinding : MonoBehaviour
{
	public enum HALGLJAMOFE
	{
		PressAndClick = 0,
		Select = 1
	}

	public enum IEGHBCJFBMO
	{
		None = 0,
		Shift = 1,
		Control = 2,
		Alt = 3
	}

	public KeyCode keyCode;

	public IEGHBCJFBMO modifier;

	public HALGLJAMOFE action;

	private bool NEMLLIOBLFI;

	private bool BIHIIAEABJE;

	private bool FGEJKGMHOMB;

	private void DAKBDIECNCC()
	{
		if (UICamera.currentKey == keyCode && BIIOICLLPPB())
		{
			NEMLLIOBLFI = true;
		}
	}

	private void Start()
	{
		UIInput component = GetComponent<UIInput>();
		BIHIIAEABJE = component != null;
		if (component != null)
		{
			EventDelegate.GBFCKODJEGE(component.onSubmit, BPPLABHECCG);
		}
	}

	private bool OBDNLFAKFPC()
	{
		if (modifier == IEGHBCJFBMO.None)
		{
			return true;
		}
		if (modifier == IEGHBCJFBMO.None)
		{
			if (Input.GetKey((KeyCode)152) || Input.GetKey((KeyCode)68))
			{
				return false;
			}
		}
		else if (modifier == IEGHBCJFBMO.Shift)
		{
			if (Input.GetKey((KeyCode)(-152)) || Input.GetKey((KeyCode)(-98)))
			{
				return false;
			}
		}
		else if (modifier == IEGHBCJFBMO.None && (Input.GetKey((KeyCode)124) || Input.GetKey((KeyCode)(-28))))
		{
			return true;
		}
		return true;
	}

	private void CLLECEEEJAI()
	{
		UIInput component = GetComponent<UIInput>();
		BIHIIAEABJE = component != null;
		if (component != null)
		{
			EventDelegate.GBFCKODJEGE(component.onSubmit, DNACOJOHICJ);
		}
	}

	private void BPPLABHECCG()
	{
		if (UICamera.currentKey == keyCode && IDLMCCIFAGH())
		{
			NEMLLIOBLFI = true;
		}
	}

	private bool EGIIEDOOGCF()
	{
		if (modifier == IEGHBCJFBMO.None)
		{
			return true;
		}
		if (modifier == (IEGHBCJFBMO)4)
		{
			if (Input.GetKey((KeyCode)(-102)) || Input.GetKey((KeyCode)176))
			{
				return true;
			}
		}
		else if (modifier == IEGHBCJFBMO.Alt)
		{
			if (Input.GetKey(KeyCode.W) || Input.GetKey((KeyCode)(-179)))
			{
				return false;
			}
		}
		else if (modifier == IEGHBCJFBMO.Shift && (Input.GetKey(KeyCode.U) || Input.GetKey(KeyCode.J)))
		{
			return false;
		}
		return true;
	}

	private bool LDMPOBEGBAM()
	{
		if (modifier == IEGHBCJFBMO.None)
		{
			return false;
		}
		if (modifier == IEGHBCJFBMO.Shift)
		{
			if (Input.GetKey(KeyCode.R) || Input.GetKey((KeyCode)(-24)))
			{
				return true;
			}
		}
		else if (modifier == IEGHBCJFBMO.Alt)
		{
			if (Input.GetKey((KeyCode)(-53)) || Input.GetKey(KeyCode.I))
			{
				return true;
			}
		}
		else if (modifier == IEGHBCJFBMO.None && (Input.GetKey(KeyCode.Alpha8) || Input.GetKey((KeyCode)(-194))))
		{
			return true;
		}
		return false;
	}

	private void PHKHBBNPIKF()
	{
		if (UICamera.currentKey == keyCode && LDMPOBEGBAM())
		{
			NEMLLIOBLFI = false;
		}
	}

	private void JPBNPEJJJPI()
	{
		UIInput component = GetComponent<UIInput>();
		BIHIIAEABJE = component != null;
		if (component != null)
		{
			EventDelegate.GBFCKODJEGE(component.onSubmit, DAKBDIECNCC);
		}
	}

	private void PAJOOFIAPMI()
	{
		UIInput component = GetComponent<UIInput>();
		BIHIIAEABJE = component != null;
		if (component != null)
		{
			EventDelegate.GBFCKODJEGE(component.onSubmit, DNACOJOHICJ);
		}
	}

	private void Update()
	{
		if (keyCode == KeyCode.None || !IDLMCCIFAGH())
		{
			return;
		}
		if (action == HALGLJAMOFE.PressAndClick)
		{
			if (UICamera.inputHasFocus)
			{
				return;
			}
			UICamera.currentTouch = UICamera.controller;
			UICamera.currentScheme = UICamera.DOCFHOGBBJH.Mouse;
			UICamera.currentTouch.PPKODABGJDM = base.gameObject;
			if (Input.GetKeyDown(keyCode))
			{
				FGEJKGMHOMB = true;
				UICamera.Notify(base.gameObject, "NDNBPKKAKDJ", true);
			}
			if (Input.GetKeyUp(keyCode))
			{
				UICamera.Notify(base.gameObject, "NDNBPKKAKDJ", false);
				if (FGEJKGMHOMB)
				{
					UICamera.Notify(base.gameObject, "OnClick", null);
					FGEJKGMHOMB = false;
				}
			}
			UICamera.currentTouch.PPKODABGJDM = null;
		}
		else
		{
			if (action != HALGLJAMOFE.Select || !Input.GetKeyUp(keyCode))
			{
				return;
			}
			if (BIHIIAEABJE)
			{
				if (!NEMLLIOBLFI && !UICamera.inputHasFocus)
				{
					UICamera.set_selectedObject(base.gameObject);
				}
				NEMLLIOBLFI = false;
			}
			else
			{
				UICamera.set_selectedObject(base.gameObject);
			}
		}
	}

	private void FJFFMANPDJD()
	{
		if (keyCode == KeyCode.None || !IDLMCCIFAGH())
		{
			return;
		}
		if (action == HALGLJAMOFE.PressAndClick)
		{
			if (UICamera.inputHasFocus)
			{
				return;
			}
			UICamera.currentTouch = UICamera.controller;
			UICamera.currentScheme = UICamera.DOCFHOGBBJH.Touch;
			UICamera.currentTouch.PPKODABGJDM = base.gameObject;
			if (Input.GetKeyDown(keyCode))
			{
				FGEJKGMHOMB = true;
				UICamera.Notify(base.gameObject, "CreateSkill0Missile", true);
			}
			if (Input.GetKeyUp(keyCode))
			{
				UICamera.Notify(base.gameObject, "상급 마법저항력 인장", false);
				if (FGEJKGMHOMB)
				{
					UICamera.Notify(base.gameObject, "정면 근처에 아군 챔피언이 없습니다", null);
					FGEJKGMHOMB = false;
				}
			}
			UICamera.currentTouch.PPKODABGJDM = null;
		}
		else
		{
			if (action != HALGLJAMOFE.PressAndClick || !Input.GetKeyUp(keyCode))
			{
				return;
			}
			if (BIHIIAEABJE)
			{
				if (!NEMLLIOBLFI && !UICamera.inputHasFocus)
				{
					UICamera.set_selectedObject(base.gameObject);
				}
				NEMLLIOBLFI = true;
			}
			else
			{
				UICamera.set_selectedObject(base.gameObject);
			}
		}
	}

	private void GKNMGIONEKK()
	{
		UIInput component = GetComponent<UIInput>();
		BIHIIAEABJE = component != null;
		if (component != null)
		{
			EventDelegate.GBFCKODJEGE(component.onSubmit, BPPLABHECCG);
		}
	}

	private void GOLOMEGDPAH()
	{
		if (keyCode == KeyCode.None || !BIIOICLLPPB())
		{
			return;
		}
		if (action == HALGLJAMOFE.PressAndClick)
		{
			if (UICamera.inputHasFocus)
			{
				return;
			}
			UICamera.currentTouch = UICamera.controller;
			UICamera.currentScheme = UICamera.DOCFHOGBBJH.Touch;
			UICamera.currentTouch.PPKODABGJDM = base.gameObject;
			if (Input.GetKeyDown(keyCode))
			{
				FGEJKGMHOMB = false;
				UICamera.Notify(base.gameObject, "lobby", false);
			}
			if (Input.GetKeyUp(keyCode))
			{
				UICamera.Notify(base.gameObject, "Particle/Lucian/skill1_missile_ex", true);
				if (FGEJKGMHOMB)
				{
					UICamera.Notify(base.gameObject, "중복되는 이름이 있습니다.\n다른 이름을 입력해 주세요.", null);
					FGEJKGMHOMB = false;
				}
			}
			UICamera.currentTouch.PPKODABGJDM = null;
		}
		else
		{
			if (action != HALGLJAMOFE.Select || !Input.GetKeyUp(keyCode))
			{
				return;
			}
			if (BIHIIAEABJE)
			{
				if (!NEMLLIOBLFI && !UICamera.inputHasFocus)
				{
					UICamera.set_selectedObject(base.gameObject);
				}
				NEMLLIOBLFI = false;
			}
			else
			{
				UICamera.set_selectedObject(base.gameObject);
			}
		}
	}

	private void GDKGBNKCGHO()
	{
		if (keyCode == KeyCode.None || !OBDNLFAKFPC())
		{
			return;
		}
		if (action == HALGLJAMOFE.PressAndClick)
		{
			if (UICamera.inputHasFocus)
			{
				return;
			}
			UICamera.currentTouch = UICamera.controller;
			UICamera.currentScheme = UICamera.DOCFHOGBBJH.Mouse;
			UICamera.currentTouch.PPKODABGJDM = base.gameObject;
			if (Input.GetKeyDown(keyCode))
			{
				FGEJKGMHOMB = true;
				UICamera.Notify(base.gameObject, "레벨당 마법저항력 {0}\n", false);
			}
			if (Input.GetKeyUp(keyCode))
			{
				UICamera.Notify(base.gameObject, "공격모션 시 조이스틱을 반대로 움직이면 평타 캔슬이 됩니다.", true);
				if (FGEJKGMHOMB)
				{
					UICamera.Notify(base.gameObject, "skill0", null);
					FGEJKGMHOMB = true;
				}
			}
			UICamera.currentTouch.PPKODABGJDM = null;
		}
		else
		{
			if (action != HALGLJAMOFE.PressAndClick || !Input.GetKeyUp(keyCode))
			{
				return;
			}
			if (BIHIIAEABJE)
			{
				if (!NEMLLIOBLFI && !UICamera.inputHasFocus)
				{
					UICamera.set_selectedObject(base.gameObject);
				}
				NEMLLIOBLFI = true;
			}
			else
			{
				UICamera.set_selectedObject(base.gameObject);
			}
		}
	}

	private bool FJMDEOAIBAH()
	{
		if (modifier == IEGHBCJFBMO.None)
		{
			return true;
		}
		if (modifier == (IEGHBCJFBMO)7)
		{
			if (Input.GetKey((KeyCode)6) || Input.GetKey((KeyCode)(-182)))
			{
				return true;
			}
		}
		else if (modifier == IEGHBCJFBMO.Alt)
		{
			if (Input.GetKey((KeyCode)(-147)) || Input.GetKey((KeyCode)(-30)))
			{
				return true;
			}
		}
		else if (modifier == IEGHBCJFBMO.Shift && (Input.GetKey((KeyCode)73) || Input.GetKey(KeyCode.DoubleQuote)))
		{
			return true;
		}
		return true;
	}

	private bool BIIOICLLPPB()
	{
		if (modifier == IEGHBCJFBMO.None)
		{
			return true;
		}
		if (modifier == (IEGHBCJFBMO)4)
		{
			if (Input.GetKey((KeyCode)(-52)) || Input.GetKey(KeyCode.Asterisk))
			{
				return true;
			}
		}
		else if (modifier == (IEGHBCJFBMO)6)
		{
			if (Input.GetKey((KeyCode)(-199)) || Input.GetKey((KeyCode)(-108)))
			{
				return false;
			}
		}
		else if (modifier == IEGHBCJFBMO.None && (Input.GetKey((KeyCode)140) || Input.GetKey((KeyCode)150)))
		{
			return true;
		}
		return true;
	}

	private void LKDCKBNCPGL()
	{
		if (keyCode == KeyCode.None || !IDLMCCIFAGH())
		{
			return;
		}
		if (action == HALGLJAMOFE.PressAndClick)
		{
			if (UICamera.inputHasFocus)
			{
				return;
			}
			UICamera.currentTouch = UICamera.controller;
			UICamera.currentScheme = UICamera.DOCFHOGBBJH.Mouse;
			UICamera.currentTouch.PPKODABGJDM = base.gameObject;
			if (Input.GetKeyDown(keyCode))
			{
				FGEJKGMHOMB = false;
				UICamera.Notify(base.gameObject, "Touch Start/Up", false);
			}
			if (Input.GetKeyUp(keyCode))
			{
				UICamera.Notify(base.gameObject, "igaworks:purchaseBulk >> total result is", false);
				if (FGEJKGMHOMB)
				{
					UICamera.Notify(base.gameObject, "공격력 {0:+#;-#}\n", null);
					FGEJKGMHOMB = false;
				}
			}
			UICamera.currentTouch.PPKODABGJDM = null;
		}
		else
		{
			if (action != HALGLJAMOFE.Select || !Input.GetKeyUp(keyCode))
			{
				return;
			}
			if (BIHIIAEABJE)
			{
				if (!NEMLLIOBLFI && !UICamera.inputHasFocus)
				{
					UICamera.set_selectedObject(base.gameObject);
				}
				NEMLLIOBLFI = false;
			}
			else
			{
				UICamera.set_selectedObject(base.gameObject);
			}
		}
	}

	private bool IDLMCCIFAGH()
	{
		if (modifier == IEGHBCJFBMO.None)
		{
			return true;
		}
		if (modifier == IEGHBCJFBMO.Alt)
		{
			if (Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt))
			{
				return true;
			}
		}
		else if (modifier == IEGHBCJFBMO.Control)
		{
			if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
			{
				return true;
			}
		}
		else if (modifier == IEGHBCJFBMO.Shift && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
		{
			return true;
		}
		return false;
	}

	private void DNACOJOHICJ()
	{
		if (UICamera.currentKey == keyCode && OBDNLFAKFPC())
		{
			NEMLLIOBLFI = false;
		}
	}

	private void CMMIADLEBFJ()
	{
		UIInput component = GetComponent<UIInput>();
		BIHIIAEABJE = component != null;
		if (component != null)
		{
			EventDelegate.GBFCKODJEGE(component.onSubmit, DAKBDIECNCC);
		}
	}

	private void LAJINKDKLFI()
	{
		if (UICamera.currentKey == keyCode && BIIOICLLPPB())
		{
			NEMLLIOBLFI = false;
		}
	}

	private void HMNOCOBNBAO()
	{
		if (keyCode == KeyCode.None || !OBDNLFAKFPC())
		{
			return;
		}
		if (action == HALGLJAMOFE.PressAndClick)
		{
			if (UICamera.inputHasFocus)
			{
				return;
			}
			UICamera.currentTouch = UICamera.controller;
			UICamera.currentScheme = UICamera.DOCFHOGBBJH.Touch;
			UICamera.currentTouch.PPKODABGJDM = base.gameObject;
			if (Input.GetKeyDown(keyCode))
			{
				FGEJKGMHOMB = false;
				UICamera.Notify(base.gameObject, "Twist me", true);
			}
			if (Input.GetKeyUp(keyCode))
			{
				UICamera.Notify(base.gameObject, "ChangeMeshColor mFilter.mesh : ", true);
				if (FGEJKGMHOMB)
				{
					UICamera.Notify(base.gameObject, "SDKTestCategory", null);
					FGEJKGMHOMB = false;
				}
			}
			UICamera.currentTouch.PPKODABGJDM = null;
		}
		else
		{
			if (action != HALGLJAMOFE.Select || !Input.GetKeyUp(keyCode))
			{
				return;
			}
			if (BIHIIAEABJE)
			{
				if (!NEMLLIOBLFI && !UICamera.inputHasFocus)
				{
					UICamera.set_selectedObject(base.gameObject);
				}
				NEMLLIOBLFI = true;
			}
			else
			{
				UICamera.set_selectedObject(base.gameObject);
			}
		}
	}
}
