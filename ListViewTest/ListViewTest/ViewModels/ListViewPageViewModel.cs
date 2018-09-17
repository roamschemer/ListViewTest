using Prism.Mvvm;
using Reactive.Bindings;
using System;

namespace ListViewTest.ViewModels
{
    public class ListViewPageViewModel : BindableBase
    {
        public ReactiveCollection<string> ListView { get; set; } = new ReactiveCollection<string>();
        public ReactiveProperty<string> SelectItem { get; set; } = new ReactiveProperty<string>();
        public ReactiveProperty<string> Text { get; set; } = new ReactiveProperty<string>();
        public ListViewPageViewModel()
        {
            ListView = new ReactiveCollection<string>
            {
                "藤崎詩織", "ボンバーガール", "伝説の樹", "植林", "自爆", "無敵特攻", "無双", "悪い噂", "ファイヤーマン",
                "大倉都子", "爆発", "包帯", "怖い", "無理ゲー"
            };

            SelectItem.Subscribe(x => Text.Value = x);
        }
    }
}
