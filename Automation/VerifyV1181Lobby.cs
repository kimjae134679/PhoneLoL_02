var scene=UnityEditor.SceneManagement.EditorSceneManager.OpenScene("Assets/Scenes/Lobby.unity",UnityEditor.SceneManagement.OpenSceneMode.Additive);
try {
 UILobbyFriendPanel panel=null;UILobbyFriendshipSelect select=null;
 foreach(var root in scene.GetRootGameObjects()){
  if(panel==null)panel=root.GetComponentInChildren<UILobbyFriendPanel>(true);
  if(select==null)select=root.GetComponentInChildren<UILobbyFriendshipSelect>(true);
 }
 if(panel==null||select==null)throw new System.Exception("Lobby panels missing");
 typeof(UILobbyFriendPanel).GetMethod("SetupPublicChat",System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.Instance).Invoke(panel,null);
 var window=panel.m_guildWindow.transform.parent.Find("PublicChatWindow");
 var chat=window.GetComponent<PhoneLOLPublicChatPanel>();
 var send=window.GetComponentInChildren<UIInput>(true).transform.parent.Find("PublicChatSend");
 var input=window.GetComponentInChildren<UIInput>(true);
 if(chat==null||send==null||send.GetComponent<BoxCollider>()==null||send.GetComponentInChildren<UILabel>().get_text()!="보내기")throw new System.Exception("Chat send control missing");
 if(input.onReturnKey!=UIInput.NBNDGIACPBN.Submit||input.label.get_multiLine()||input.label.get_width()!=296)throw new System.Exception("Chat input not single-line with reserved send area");
 var texts=select.GetComponentsInChildren<UILabel>(true).Select(x=>x.get_text()).ToArray();
 if(!texts.Any(x=>x=="URF 모드"))throw new System.Exception("URF title missing");
 return "PASS visible send button, single-line enter, editable composer, URF mode title";
} finally {UnityEditor.SceneManagement.EditorSceneManager.CloseScene(scene,true);}
