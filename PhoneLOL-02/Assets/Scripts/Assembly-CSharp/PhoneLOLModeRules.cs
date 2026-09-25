using System;
using UnityEngine;

// Rules are derived from the server's room snapshot on every peer.
public static class PhoneLOLModeRules
{
    public static bool Enabled {
        get {
            var network = NetworkManager.get_Instance();
            var battle = network == null ? null : network.get_m_battleNetClient();
            var room = battle == null ? null : battle.IMKOGBNIJBO();
            return room != null && (room.EHCPMLKEBME == 10 || room.EHCPMLKEBME == 103);
        }
    }
    public static float AttackSpeed(float value) { return Enabled ? value : Mathf.Min(value, 2.5f); }
    public static float LifeSteal(float value) { return Enabled ? value : Mathf.Min(value, 0.55f); }
    public static float CooldownReduction(float value)
    {
        if (!Enabled) return Mathf.Min(value, 0.4f);
        // Each complete 40 percentage points multiplies remaining cooldown by 0.6.
        double points = Math.Max(0.0, (double)value * 100.0);
        double blocks = Math.Floor(points / 40.0);
        double remainder = points - blocks * 40.0;
        return (float)(1.0 - Math.Pow(0.6, blocks) * (1.0 - remainder / 100.0));
    }
    public static int ItemSlots { get { return Enabled ? 8 : 5; } }
    public static float Respawn(float seconds) { return Enabled ? seconds * 0.5f : seconds; }
    public static UIGameItem[] ExpandItems(UIGameItem[] items)
    {
        if (!Enabled || items == null || items.Length != 5) return items;
        var expanded = new UIGameItem[8];
        Array.Copy(items, expanded, items.Length);
        var first = items[0].transform.localPosition;
        var step = (items[4].transform.localPosition - first) / 4f;
        for (int i = 5; i < 8; i++) expanded[i] = UnityEngine.Object.Instantiate(items[4], items[4].transform.parent, false);
        for (int i = 0; i < 8; i++) {
            expanded[i].transform.localPosition = first + step * (i * 4f / 7f);
            expanded[i].transform.localScale *= 0.625f;
        }
        return expanded;
    }
    public static void ExpandUseButtons(UIGameItemUseButtons ui)
    {
        if (!Enabled || ui.m_itemIconList.Length != 5) return;
        var source = ui.m_itemIconList[4].transform.parent;
        var first = ui.m_itemIconList[0].transform.parent.localPosition;
        var step = (source.localPosition - first) / 4f;
        Array.Resize(ref ui.m_itemIconList, 8);
        Array.Resize(ref ui.m_itemIconBackList, 8);
        Array.Resize(ref ui.m_castableList, 8);
        Array.Resize(ref ui.m_itemCountLabelList, 8);
        for (int i = 5; i < 8; i++) {
            var clone = UnityEngine.Object.Instantiate(source.gameObject, source.parent, false);
            clone.name = "Item" + i + "UseButton";
            ui.m_itemIconList[i] = FindClone(clone.transform, source, ui.m_itemIconList[4].transform).GetComponent<UISprite>();
            ui.m_itemIconBackList[i] = FindClone(clone.transform, source, ui.m_itemIconBackList[4].transform).GetComponent<UISprite>();
            ui.m_castableList[i] = FindClone(clone.transform, source, ui.m_castableList[4].transform).gameObject;
            ui.m_itemCountLabelList[i] = FindClone(clone.transform, source, ui.m_itemCountLabelList[4].transform).GetComponent<UILabel>();

        }
        for (int i = 0; i < 8; i++) {
            var t = ui.m_itemIconList[i].transform.parent;
            var trigger = t.GetComponent<UIEventTrigger>();
            if (trigger == null) throw new InvalidOperationException("Item use button has no press trigger");
            int slot = i;
            trigger.onPress.Clear();
            trigger.onPress.Add(new EventDelegate(() => UseItem(slot)));
            // Keep full-size touch targets in two rows instead of shrinking eight into five.
            t.localPosition = first + new Vector3((i % 4) * 60f, (i / 4) * 50f, 0f);
        }
    }
    private static Transform FindClone(Transform clone, Transform root, Transform original)
    {
        if (root == original) return clone;
        string path = original.name;
        for (var p = original.parent; p != root; p = p.parent) {
            if (p == null) throw new InvalidOperationException("Item UI reference is outside its button");
            path = p.name + "/" + path;
        }
        var result = clone.Find(path);
        if (result == null) throw new InvalidOperationException("Missing cloned item UI: " + path);
        return result;
    }
    private static void UseItem(int slot)
    {
        GameManager.get_Instance().m_actionElapsedTime = 0f;
        var actor = ActorManager.get_Instance().GetControlActor();
        if (actor != null) actor.get_m_gameItems().OPDJKDJPNDN((byte)slot);
    }
    public static UISprite[] ExpandResultItems(UISprite[] items)
    {
        if (!Enabled || items.Length != 5) return items;
        var expanded = new UISprite[8];
        Array.Copy(items, expanded, 5);
        var first = items[0].transform.localPosition;
        var step = (items[4].transform.localPosition - first) / 4f;
        for (int i = 5; i < 8; i++) expanded[i] = UnityEngine.Object.Instantiate(items[4], items[4].transform.parent, false);
        for (int i = 0; i < 8; i++) {
            expanded[i].transform.localPosition = first + step * (i * 4f / 7f);
            expanded[i].transform.localScale *= 0.625f;
        }
        return expanded;
    }
}
