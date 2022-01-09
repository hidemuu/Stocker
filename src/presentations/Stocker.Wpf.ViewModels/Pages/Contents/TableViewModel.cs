using Mov.Authorizer.Models;
using Mov.Configurator.Models;
using Mov.Translator.Models;
using Mov.WpfControls.ViewModels;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using Stocker.Models;
using Stocker.Wpf.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf.ViewModels.Panels.Contents
{
    public class TableViewModel : ViewModelBase, ITableViewModel
    {
        #region フィールド

        private readonly IStockerRepository stocker;
        private readonly IConfiguratorRepository configurator;
        private readonly IAuthorizerRepository authorizer;
        private readonly ITranslatorRepository translator;

        public ReactiveCollection<TableModel> Models { get; } = new ReactiveCollection<TableModel>();

        public TableAttribute Attribute { get; private set; } = new TableAttribute();

        #endregion

        #region コマンド

        public ReactiveCommand ClickProductCommand { get; } = new ReactiveCommand();
        public ReactiveCommand ClickOrderCommand { get; } = new ReactiveCommand();
        public ReactiveCommand ClickCustomerCommand { get; } = new ReactiveCommand();
        public ReactiveCommand ClickUserCommand { get; } = new ReactiveCommand();
        public ReactiveCommand ClickUserSettingCommand { get; } = new ReactiveCommand();
        public ReactiveCommand ClickCommentCommand { get; } = new ReactiveCommand();

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="stocker"></param>
        /// <param name="configurator"></param>
        /// <param name="authorizer"></param>
        /// <param name="translator"></param>
        public TableViewModel(IStockerRepository stocker, IConfiguratorRepository configurator, IAuthorizerRepository authorizer, ITranslatorRepository translator)
        {
            this.stocker = stocker;
            this.configurator = configurator;
            this.authorizer = authorizer;
            this.translator = translator;

            LoadProduct();

            ClickProductCommand.Subscribe(LoadProduct).AddTo(Disposables);
            ClickOrderCommand.Subscribe(LoadOrder).AddTo(Disposables);
            ClickCustomerCommand.Subscribe(LoadCustomer).AddTo(Disposables);
            ClickUserCommand.Subscribe(LoadUser).AddTo(Disposables);
            ClickUserSettingCommand.Subscribe(LoadUserSetting).AddTo(Disposables);
            ClickCommentCommand.Subscribe(LoadComment).AddTo(Disposables);
        }

        #region メソッド

        protected override void OnLoaded()
        {

        }

        private void LoadProduct()
        {
            var task = this.stocker.Products.GetAsync();
            Task.WaitAll(task);
            Models.Clear();
            foreach (var item in task.Result)
            {
                Models.Add(new ProductTableModel(item));
            }
        }

        private void LoadOrder()
        {
            var task = this.stocker.Orders.GetAsync();
            Task.WaitAll(task);
            Models.Clear();
            foreach (var item in task.Result)
            {
                Models.Add(new OrderTableModel(item));
            }
        }

        private void LoadCustomer()
        {
            var task = this.stocker.Customers.GetAsync();
            Task.WaitAll(task);
            Models.Clear();
            foreach (var item in task.Result)
            {
                Models.Add(new CustomerTableModel(item));
            }
        }

        private void LoadUser()
        {
            Models.Clear();
            foreach (var item in this.authorizer.Users.Gets())
            {
                Models.Add(new UserTableModel(item));
            }
        }

        private void LoadUserSetting()
        {
            Models.Clear();
            foreach (var item in this.configurator.UserSettings.Gets())
            {
                Models.Add(new UserSettingTableModel(item));
            }
        }

        private void LoadComment()
        {
            Models.Clear();
            foreach (var item in this.translator.Comments.Gets())
            {
                Models.Add(new CommentTableModel(item));
            }
        }

        #endregion
    }
}
