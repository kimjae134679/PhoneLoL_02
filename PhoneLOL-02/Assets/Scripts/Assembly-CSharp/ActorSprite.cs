using UnityEngine;

public abstract class ActorSprite : MonoBehaviour
{
	public enum BDHHCPEJAIP
	{
		Idle = 0,
		Walk = 1,
		Attack = 2,
		Death = 3
	}

	public delegate void DKJBKFGEBPH(BDHHCPEJAIP APDGMJNBIHE);

	public delegate void HODBAJBAFBJ();

	public DKJBKFGEBPH m_animationCompleteDelegate;

	public HODBAJBAFBJ m_animationEventAttackDelegate;

	public HODBAJBAFBJ m_animationEventHealDelegate;

	public ActorSprite()
	{
	}

	public abstract void SetColor(Color BEAKIPPBGAF);

	public abstract void SetAlpha(float KHMMAABNHJI);

	public abstract void Play(BDHHCPEJAIP APDGMJNBIHE);

	public virtual void Start()
	{
	}

	public void OnAnimationEventAttack()
	{
		if (m_animationEventAttackDelegate != null)
		{
			m_animationEventAttackDelegate();
		}
	}

	public void OnAnimationEventHeal()
	{
		if (m_animationEventHealDelegate != null)
		{
			m_animationEventHealDelegate();
		}
	}
}
