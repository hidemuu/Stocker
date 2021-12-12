using Reactive.Bindings;
using Stocker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.Models.Panels
{
    public class ProductModel
    {
        /// <summary>
        /// カテゴリー
        /// </summary>
        public ReactivePropertySlim<string> Category { get; } = new ReactivePropertySlim<string>();

        /// <summary>
        /// 名称
        /// </summary>
        public ReactivePropertySlim<string> Name { get; } = new ReactivePropertySlim<string>();

        /// <summary>
        /// 型式
        /// </summary>
        public ReactivePropertySlim<string> Code { get; } = new ReactivePropertySlim<string>();

        /// <summary>
        /// メーカー
        /// </summary>
        public ReactivePropertySlim<string> Maker { get; } = new ReactivePropertySlim<string>();

        /// <summary>
        /// Url
        /// </summary>
        public ReactivePropertySlim<string> Url { get; } = new ReactivePropertySlim<string>();

        /// <summary>
        /// コンストラクター 
        /// </summary>
        public ProductModel(Product product)
        {
            Category.Value = product.Category;
            Name.Value = product.Name;
            Code.Value = product.Code;
            Maker.Value = product.Maker;
            Url.Value = product.Url;
        }
    }
}
