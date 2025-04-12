using UnityEngine;
using UnityEditor;

public class SupineExCombinerEditor : SupineCombinerEditor
{
    [MenuItem("Tools/MinMinMart/Supine Combiner (EX)")]
    private static void Create()
    {
        GetWindow<SupineExCombinerEditor>("Supine Combiner (EX)");
    }

    protected override SupineCombiner InstantiateCombiner(GameObject avatar)
    {
        return new SupineExCombiner(avatar);
    }
}