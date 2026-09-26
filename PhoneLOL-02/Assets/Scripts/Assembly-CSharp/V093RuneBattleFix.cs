using GameServer;

internal static class V093RuneBattleFix
{
	internal static int ApplyMaxHp(int value, Actor actor)
	{
		if ((object)actor != null)
		{
			CLJOMPBCNOE runeAbility = actor.get_m_runeAbility();
			if (runeAbility != null)
			{
				return value + (int)((float)value * runeAbility.PDCFCBKFAKB);
			}
		}
		return value;
	}

	internal static float ApplyMoveSpeed(float value, Actor actor)
	{
		if ((object)actor != null)
		{
			CLJOMPBCNOE runeAbility = actor.get_m_runeAbility();
			if (runeAbility != null)
			{
				return value + actor.m_moveSpeed * runeAbility.NEPGMKLCMFF;
			}
		}
		return value;
	}

	internal static uint ApplyExperience(uint value, Actor actor)
	{
		if ((object)actor != null)
		{
			CLJOMPBCNOE runeAbility = actor.get_m_runeAbility();
			if (runeAbility != null)
			{
				return value + (uint)((double)value * (double)runeAbility.LHAMJEJLAEH);
			}
		}
		return value;
	}

	internal static int ApplyAutoGold(int value, Actor actor)
	{
		return value;
	}
}
