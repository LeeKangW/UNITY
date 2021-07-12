using System;
using System.Collections.Generic;

namespace Helper
{
    public static class TagDictionary
    {
        public enum ETag
        {
            Respawn,
            Finish,
            EditorOnly,
            MainCamera,
            Player,
            GameController,
            Enemy,
        }

        static Dictionary<ETag, string> tagDictionary = new Dictionary<ETag, string>();
        
        static void Init()
        {
            tagDictionary = new Dictionary<ETag, string>(Enum.GetValues(typeof(ETag)).Length);

            string temp = string.Empty;

            foreach (var item in ETag.GetValues(typeof(ETag)))
            {
                // 이름 중 띄어쓰기 대체
                if (item.ToString().Contains("_"))
                {
                    temp = item.ToString().Replace("_", " ");
                }
                else
                {
                    temp = item.ToString();
                }
                tagDictionary.Add((ETag)item, temp);
            }
        }

        static public string GetTagName(ETag tag)
        {
            if (tagDictionary == null || tagDictionary.Count == 0)
                Init();

            return tagDictionary.GetOrDefault(tag);
        }
    }
}
