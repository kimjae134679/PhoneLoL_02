using UnityEngine;

// Runtime replacement for the removed viewport-positioned debug text component.
public class GUIText : MonoBehaviour
{
    public string text = "";
    public Vector2 pixelOffset;
    public Font font;
    public Material material;
    public TextAnchor anchor = TextAnchor.UpperLeft;
    public TextAlignment alignment;
    public Color color = Color.white;
    public float lineSpacing = 1, tabSize = 4;
    public int fontSize = 14;
    public FontStyle fontStyle;
    public bool richText = true;
    private void Awake()
    {
        if (material == null)
        {
            var shader = Shader.Find("GUI/Text Shader");
            if (shader != null) { material = new Material(shader); material.color = color; }
        }
    }
    private void OnGUI()
    {
        var style = new GUIStyle(GUI.skin.label)
        { font = font, fontSize = fontSize, fontStyle = fontStyle, alignment = anchor, richText = richText };
        style.normal.textColor = material != null ? material.color : color;
        Vector2 size = style.CalcSize(new GUIContent(text));
        Vector3 position = transform.position;
        float x = position.x * Screen.width + pixelOffset.x;
        float y = Screen.height - position.y * Screen.height - pixelOffset.y;
        int a = (int)anchor;
        x -= (a % 3) * size.x * 0.5f;
        y -= (a / 3) * size.y * 0.5f;
        GUI.Label(new Rect(x, y, size.x, size.y), text, style);
    }
}
