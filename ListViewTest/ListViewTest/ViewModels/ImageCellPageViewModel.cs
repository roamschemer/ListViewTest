using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Linq;
using System.Reactive.Linq;

namespace ListViewTest.ViewModels
{
	public class ImageCellPageViewModel : BindableBase
	{
        public class MenuItem
        {
            public string Title { get; set; }
            public string Target { get; set; }
            public string Image { get; set; }
        }

        public ReactiveCollection<MenuItem> ListView { get; set; } = new ReactiveCollection<MenuItem>();
        public ReactiveProperty<MenuItem> SelectItem { get; set; } = new ReactiveProperty<MenuItem>();
        public ReactiveProperty<string> Text { get; set; } = new ReactiveProperty<string>();

        public ImageCellPageViewModel()
        {
            ListView = new ReactiveCollection<MenuItem>
            {
                new MenuItem {Title="藤崎詩織",Target="幼馴染というだけでも嫌なのに",Image="ListViewTest.Resources.藤崎詩織.JPG" },
                new MenuItem {Title="陽ノ下光",Target="ちょっと無理だよ…ごめんね！",Image="ListViewTest.Resources.陽ノ下光.JPG" },
                new MenuItem {Title="麻生華澄",Target="教師とのアバンチュール",Image="ListViewTest.Resources.麻生華澄.JPG" },
                new MenuItem {Title="佐倉楓子",Target="遠距離恋愛",Image="ListViewTest.Resources.佐倉楓子.JPG" },
                new MenuItem {Title="伊集院メイ",Target="めっちゃかわいい",Image="ListViewTest.Resources.伊集院メイ.JPG" },
                new MenuItem {Title="藤崎詩織",Target="幼馴染というだけでも嫌なのに",Image="ListViewTest.Resources.藤崎詩織.JPG" },
                new MenuItem {Title="陽ノ下光",Target="ちょっと無理だよ…ごめんね！",Image="ListViewTest.Resources.陽ノ下光.JPG" },
                new MenuItem {Title="麻生華澄",Target="教師とのアバンチュール",Image="ListViewTest.Resources.麻生華澄.JPG" },
                new MenuItem {Title="佐倉楓子",Target="遠距離恋愛",Image="ListViewTest.Resources.佐倉楓子.JPG" },
                new MenuItem {Title="伊集院メイ",Target="めっちゃかわいい",Image="ListViewTest.Resources.伊集院メイ.JPG" },
                new MenuItem {Title="藤崎詩織",Target="幼馴染というだけでも嫌なのに",Image="ListViewTest.Resources.藤崎詩織.JPG" },
                new MenuItem {Title="陽ノ下光",Target="ちょっと無理だよ…ごめんね！",Image="ListViewTest.Resources.陽ノ下光.JPG" },
                new MenuItem {Title="麻生華澄",Target="教師とのアバンチュール",Image="ListViewTest.Resources.麻生華澄.JPG" },
                new MenuItem {Title="佐倉楓子",Target="遠距離恋愛",Image="ListViewTest.Resources.佐倉楓子.JPG" },
                new MenuItem {Title="伊集院メイ",Target="めっちゃかわいい",Image="ListViewTest.Resources.伊集院メイ.JPG" },
            };

            //LinQで書く
            SelectItem.Where(x => x != null).Subscribe(x => Text.Value = x.Target);

        }
    }
}
