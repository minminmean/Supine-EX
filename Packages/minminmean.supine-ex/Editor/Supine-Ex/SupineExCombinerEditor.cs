using UnityEditor;
using Supine.Utilities;

namespace Supine
{
    /// <summary>
    /// EX版ごろ寝システムの組込ウィンドウ。
    /// 通常版のウィンドウとは継承関係を持たない「兄弟」として実装する
    /// （GetWindowが派生型のインスタンスを拾い、互いのウィンドウを奪い合うのを防ぐため）。
    /// </summary>
    public sealed class SupineExCombinerEditor : SupineCombinerWindowBase
    {
        // 自パッケージのguids.jsonへの起点参照。
        // EX版が使うアセットのGUIDはすべてそのJSON側で管理する。
        private const string ExGuidsJsonGuid = "a7dd1ea72bbb4619a4115e799b17af49";

        protected override SupineVariant Variant  => JsonHelper.GetGuidList(ExGuidsJsonGuid).variant;
        protected override string FolderLabel     => "Supine-EX";
        protected override string PrefsKeyPrefix  => "MinMinMart.SupineEx";

        [MenuItem("Tools/MinMinMart/Supine Combiner (EX)")]
        private static void Create()
        {
            GetWindow<SupineExCombinerEditor>("Supine Combiner (EX)");
        }
    }
}
