using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Linq;
using System.Reactive.Linq;

namespace ListViewTest.ViewModels
{
	public class ViewCellPageViewModel : BindableBase
	{
        public class MenuItem
        {
            public string Title { get; set; }
            public ReactiveProperty<string> Detail { get; set; } = new ReactiveProperty<string>();
            public ReactiveCommand Input { get; set; } = new ReactiveCommand();
            public ReactiveCommand Delete { get; set; } = new ReactiveCommand();

            public MenuItem()
            {
                Input.Subscribe(() => Detail.Value = "入力ボタンを押しました");
                Delete.Subscribe(() => Detail.Value = "消去ボタンを押しました");
            }
        }

        public ReactiveCollection<MenuItem> ListView { get; set; } = new ReactiveCollection<MenuItem>();
        public ReactiveProperty<MenuItem> SelectItem { get; set; } = new ReactiveProperty<MenuItem>();

        public ViewCellPageViewModel()
        {
            ListView = new ReactiveCollection<MenuItem>();
            foreach (var i in Enumerable.Range(1, 1000))
            {
                ListView.Add(new MenuItem { Title = $"No.{i.ToString("00000")}" });
            }

            SelectItem.Where(x => x != null).Subscribe(x =>
            {
                x.Detail.Value = "リストを押しました";
            });
        }
	}
}
