using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.Models.Tables
{
    public class TableModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public ReactivePropertySlim<int> Id { get; } = new ReactivePropertySlim<int>();

        /// <summary>
        /// カテゴリー
        /// </summary>
        public ReactivePropertySlim<string> Category { get; } = new ReactivePropertySlim<string>();

        /// <summary>
        /// 名称
        /// </summary>
        public ReactivePropertySlim<string> Name { get; } = new ReactivePropertySlim<string>();

        /// <summary>
        /// コード
        /// </summary>
        public ReactivePropertySlim<string> Code { get; } = new ReactivePropertySlim<string>();

        /// <summary>
        /// 説明
        /// </summary>
        public ReactivePropertySlim<string> Description { get; } = new ReactivePropertySlim<string>();

        /// <summary>
        /// 参照
        /// </summary>
        public ReactivePropertySlim<string> Reference { get; } = new ReactivePropertySlim<string>();

    }

    

}
