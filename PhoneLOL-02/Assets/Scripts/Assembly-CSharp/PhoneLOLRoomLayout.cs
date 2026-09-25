using System;
using UnityEngine;

public static class PhoneLOLRoomLayout
{
    public static int Capacity {
        get {
            var network = NetworkManager.get_Instance();
            var battle = network == null ? null : network.get_m_battleNetClient();
            var room = battle == null ? null : battle.IMKOGBNIJBO();
            return room == null ? 6 : room.IFOLDPBLAGD();
        }
    }

    public static T[] Expand<T>(T[] rows, bool ready) where T : Component
    {
        int count = Capacity;
        if (rows == null || rows.Length < 6 || count <= 6 && rows.Length == 6) return rows;
        if (rows.Length == 6) {
            var expanded = new T[10];
            Array.Copy(rows, expanded, 6);
            for (int i = 6; i < 10; i++) {
                var original = rows[4 + i % 2];
                expanded[i] = UnityEngine.Object.Instantiate(original, original.transform.parent, false);
                expanded[i].name = original.name + "Slot" + i;
            }
            rows = expanded;
        }
        for (int i = 0; i < rows.Length; i++) {
            var t = rows[i].transform;
            float scale = count > 6 ? 0.6f : 1f;
            var pos = t.localPosition;
            if (ready) pos.y = count > 6 ? 110.2f - (i / 2) * 57.6f : 91f - (i / 2) * 96f;
            else {
                // Each team retains its own half of the original table.
                float center = i % 2 == 0 ? 59f : -60f;
                pos.y = center + (count > 6 ? 43.2f - (i / 2) * 21.6f : 36f - (i / 2) * 36f);
            }
            t.localPosition = pos;
            t.localScale = Vector3.one * scale;
        }
        return rows;
    }
}
