var path="Assets/Scenes/Lobby.unity";
var scene=UnityEditor.SceneManagement.EditorSceneManager.OpenScene(path,UnityEditor.SceneManagement.OpenSceneMode.Additive);
try {
  UILobbyFriendPanel panel=null;
  foreach(var root in scene.GetRootGameObjects()) {
    panel=root.GetComponentInChildren<UILobbyFriendPanel>(true);
    if(panel!=null)break;
  }
  if(panel==null)throw new System.Exception("Friend/Guild panel missing");
  var setup=typeof(UILobbyFriendPanel).GetMethod("SetupPublicChat",System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.Instance);
  setup.Invoke(panel,null);
  var tab=panel.transform.Find("PublicChatTab");
  if(tab==null)tab=panel.m_guildTab.transform.parent.Find("PublicChatTab");
  if(tab==null||tab.GetComponentInChildren<UILabel>(true).get_text()!="채팅")throw new System.Exception("Public chat tab missing");
  var window=panel.m_guildWindow.transform.parent.Find("PublicChatWindow");
  if(window==null||window.GetComponent<PhoneLOLPublicChatPanel>()==null)throw new System.Exception("Public chat panel missing");
  var chat=window.GetComponent<UILobbyGuildChatWindow>();
  if(chat!=null&&chat.enabled)throw new System.Exception("Guild chat still enabled in public window");
  return "PASS Lobby tab and public window cloned and connected";
} finally {UnityEditor.SceneManagement.EditorSceneManager.CloseScene(scene,true);}
