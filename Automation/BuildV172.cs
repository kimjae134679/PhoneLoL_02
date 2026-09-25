UnityEditor.AssetDatabase.Refresh(UnityEditor.ImportAssetOptions.ForceSynchronousImport);
PhoneLOLBuild.BuildAndroidCandidate();
return System.IO.File.ReadAllText("Builds/build-result.txt");
