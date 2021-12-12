using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Stocker.Accessors
{
    public class XmlFileHelper : IFileHelper
    {
        private string _path;
        
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="path">ファイルパス</param>
        public XmlFileHelper(string path)
        {
            _path = path;
        }

        /// <summary>
        /// データをファイルから読み出して指定クラスにデシリアライズ
        /// </summary>
        /// <returns></returns>
        public T Read<T>()
        {
            using (var stream = new StreamReader(_path))
            {
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(stream);
            }

        }

        /// <summary>
        /// シリアライズしてファイルに書き込み
        /// </summary>
        /// <param name="obj"></param>
        public void Write<T>(T obj)
        {
            using (var stream = new StreamWriter(_path, false, new UTF8Encoding(false)))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stream, obj);
            }
        }
    }
}
