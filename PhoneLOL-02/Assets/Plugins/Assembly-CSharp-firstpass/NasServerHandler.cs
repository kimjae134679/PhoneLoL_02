using Nas;
using UnityEngine;

public class NasServerHandler : EventHandler
{
	public override void OnNASWallClose()
	{
		Debug.Log("OnNASWallClose");
	}

	public override void OnUserPointSuccess(int point, string unit)
	{
		Debug.Log("OnUserPointSuccess > 적립금 조회가 완료되었습니다. 남은 적립금 : " + point + " " + unit);
	}

	public override void OnUserPointError(int code)
	{
		Debug.Log("OnUserPointError > 적립금 조회 중 오류가 발생했습니다. 오류 코드 : " + code);
	}

	public override void OnPurchaseItemSuccess(string itemId, int purchaseCount, int point, string unit)
	{
		Debug.Log("OnPurchaseItemSuccess > 아이템 구매가 완료되었습니다. 남은 적립금 : " + point + " " + unit + " / itemId > " + itemId + " / purchaseCount > " + purchaseCount);
	}

	public override void OnPurchaseItemNotEnoughPoint(string itemId, int purchaseCount)
	{
		Debug.Log("OnPurchaseItemNotEnoughPoint > 적립금이 부족해서 아이템을 구매할 수 없습니다. / itemId > " + itemId + " / purchaseCount > " + purchaseCount);
	}

	public override void OnPurchaseItemError(string itemId, int purchaseCount, int errorCode)
	{
		Debug.Log("OnPurchaseItemError > 아이템 구매 시 오류가 발생했습니다. 오류 코드 : " + errorCode + " / itemId > " + itemId + " / purchaseCount > " + purchaseCount);
	}
}
