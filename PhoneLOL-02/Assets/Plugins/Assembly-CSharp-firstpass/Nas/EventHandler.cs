using System.Collections.Generic;
using Nas.MiniJSON;
using UnityEngine;

namespace Nas
{
	public class EventHandler : MonoBehaviour
	{
		public string _handlerName;

		private void Awake()
		{
			Debug.Log("##### Awake " + _handlerName);
			base.gameObject.name = _handlerName;
			Object.DontDestroyOnLoad(base.gameObject);
		}

		public void OnNASWallCloseBinding(string type)
		{
			OnNASWallClose();
		}

		public void OnUserPointSuccessBinding(string json)
		{
			Dictionary<string, object> dictionary = Json.Deserialize(json) as Dictionary<string, object>;
			int point = (int)(long)dictionary["point"];
			string unit = (string)dictionary["unit"];
			OnUserPointSuccess(point, unit);
		}

		public void OnUserPointErrorBinding(string json)
		{
			Dictionary<string, object> dictionary = Json.Deserialize(json) as Dictionary<string, object>;
			int code = (int)(long)dictionary["code"];
			OnUserPointError(code);
		}

		public void OnPurchaseItemSuccessBinding(string json)
		{
			Dictionary<string, object> dictionary = Json.Deserialize(json) as Dictionary<string, object>;
			string itemId = (string)dictionary["itemId"];
			int purchaseCount = (int)(long)dictionary["purchaseCount"];
			int point = (int)(long)dictionary["point"];
			string unit = (string)dictionary["unit"];
			OnPurchaseItemSuccess(itemId, purchaseCount, point, unit);
		}

		public void OnPurchaseItemNotEnoughPointBinding(string json)
		{
			Dictionary<string, object> dictionary = Json.Deserialize(json) as Dictionary<string, object>;
			string itemId = (string)dictionary["itemId"];
			int purchaseCount = (int)(long)dictionary["purchaseCount"];
			OnPurchaseItemNotEnoughPoint(itemId, purchaseCount);
		}

		public void OnPurchaseItemErrorBinding(string json)
		{
			Dictionary<string, object> dictionary = Json.Deserialize(json) as Dictionary<string, object>;
			string itemId = (string)dictionary["itemId"];
			int purchaseCount = (int)(long)dictionary["purchaseCount"];
			int errorCode = (int)(long)dictionary["errorCode"];
			OnPurchaseItemError(itemId, purchaseCount, errorCode);
		}

		public virtual void OnNASWallClose()
		{
		}

		public virtual void OnUserPointSuccess(int point, string unit)
		{
		}

		public virtual void OnUserPointError(int code)
		{
		}

		public virtual void OnPurchaseItemSuccess(string itemId, int purchaseCount, int point, string unit)
		{
		}

		public virtual void OnPurchaseItemNotEnoughPoint(string itemId, int purchaseCount)
		{
		}

		public virtual void OnPurchaseItemError(string itemId, int purchaseCount, int errorCode)
		{
		}
	}
}
