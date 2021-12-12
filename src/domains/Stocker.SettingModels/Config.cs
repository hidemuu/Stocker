using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Stocker.SettingModels
{

    public class Config
    {
        /// <summary>
        /// データ番号
        /// </summary>
        public int Number { get; set; } = 0;
        /// <summary>
        /// ユニット種別
        /// </summary>
        public string UnitGroup { get; set; } = "";
        /// <summary>
        /// ユニットNo
        /// </summary>
        public int UnitNumber { get; set; } = -1;
        /// <summary>
        /// カテゴリー
        /// </summary>
        public string Category { get; set; } = "";
        /// <summary>
        /// キーコード
        /// </summary>
        public string Code { get; set; } = "";
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// 設定値
        /// </summary>
        public string SetValue { get; set; } = "";
        /// <summary>
        /// 初期値
        /// </summary>
        public string DefaultValue { get; set; } = "";
        /// <summary>
        /// 内容説明
        /// </summary>
        [StringLength(100)]
        public string Info { get; set; } = "";
        /// <summary>
        /// データタイプ
        /// </summary>
        public string DataType { get; set; } = "";
        /// <summary>
        /// 下限値
        /// </summary>
        public string LowerLimit { get; set; } = "";
        /// <summary>
        /// 上限値
        /// </summary>
        public string UpperLimit { get; set; } = "";
        /// <summary>
        /// 登録日時
        /// </summary>
        public DateTime ResisterDate { get; set; } = DateTime.Now;
        /// <summary>
        /// アクセスレベル
        /// </summary>
        public int AccessLv { get; set; } = 0;
    }
}
