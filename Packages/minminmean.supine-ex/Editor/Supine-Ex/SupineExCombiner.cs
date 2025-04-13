using UnityEngine;
using UnityEditor;
using UnityEditor.Animations;
using System.IO;

public class SupineExCombiner : SupineCombiner
{
    private string _appVersionTextGuid = "0e3ca72d31adafa45ab752ce60b7c255";
    private string _maPrefabGuid = "53c2fb51ef8e9804aa712d877203b4cf";
    private string _animatorGuid = "c22e5b6c49df9ff4f9a7c6e1c3442cea";
    public SupineExCombiner(GameObject avatar) : base(avatar) { Debug.Log("[VRCSupine EX] Overridden"); }

    protected override AnimatorController GetTemplateController()
    {
        return base.CopyAssetFromGuid<AnimatorController>(_animatorGuid);
    }

    protected override GameObject GetMAPrefab()
    {
        string maPrefabPath = AssetDatabase.GUIDToAssetPath(_maPrefabGuid);
        return AssetDatabase.LoadAssetAtPath<GameObject>(maPrefabPath);
    }

    protected override GameObject FindOtherSupinePrefab()
    {
        return GameObject.Find("SupineMA");
    }

    protected override string GetAppVersion()
    {
        string path = AssetDatabase.GUIDToAssetPath(_appVersionTextGuid);
        return File.ReadAllText(path);
    }
}