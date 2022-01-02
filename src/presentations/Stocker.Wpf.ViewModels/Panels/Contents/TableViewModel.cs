using Authorizer.Models;
using Configurator.Models;
using Language.Models;
using Reactive.Bindings;
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
        private readonly IConfiguratorRepository configurator;
        private readonly IAuthorizerRepository authorizer;
        private readonly ILanguageRepository language;

        public ReactiveCollection<TableModel> Models { get; } = new ReactiveCollection<TableModel>();

        public TableAttribute Attribute { get; private set; } = new TableAttribute();

        public ReactiveCommand ClickProductCommand { get; } = new ReactiveCommand();
        public ReactiveCommand ClickOrderCommand { get; } = new ReactiveCommand();
        public ReactiveCommand ClickCustomerCommand { get; } = new ReactiveCommand();
        public ReactiveCommand ClickUserCommand { get; } = new ReactiveCommand();
        public ReactiveCommand ClickUserSettingCommand { get; } = new ReactiveCommand();
        public ReactiveCommand ClickCommentCommand { get; } = new ReactiveCommand();

        public TableViewModel(IStockerRepository repository, IConfiguratorRepository configurator, IAuthorizerRepository authorizer, ILanguageRepository language) : base(repository)
        {
            this.configurator = configurator;
            this.authorizer = authorizer;
            this.language = language;

            LoadProduct();

            ClickProductCommand.Subscribe(LoadProduct);
            ClickOrderCommand.Subscribe(LoadOrder);
            ClickCustomerCommand.Subscribe(LoadCustomer);
            ClickUserCommand.Subscribe(LoadUser);
            ClickUserSettingCommand.Subscribe(LoadUserSetting);
            ClickCommentCommand.Subscribe(LoadComment);
        }

        protected override void OnLoaded()
        {

        }

        private void LoadProduct()
        {
            var task = this.repository.Products.GetAsync();
            Task.WaitAll(task);
            Models.Clear();
            foreach (var item in task.Result)
            {
                Models.Add(new ProductTableModel(item));
            }
        }

        private void LoadOrder()
        {
            var task = this.repository.Orders.GetAsync();
            Task.WaitAll(task);
            Models.Clear();
            foreach (var item in task.Result)
            {
                Models.Add(new OrderTableModel(item));
            }
        }

        private void LoadCustomer()
        {
            var task = this.repository.Customers.GetAsync();
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
            foreach (var item in this.language.Comments.Gets())
            {
                Models.Add(new CommentTableModel(item));
            }
        }

    }
}
