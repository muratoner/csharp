using System;
using WatiN.Core;

namespace MHG.Library.WatIn
{
    /// <summary>
    /// -Oluşabilecek hatalar-
    /// Eğer "Additional information: Could not load file or assembly 'Interop.SHDocVw, Version=1.1.0.0, Culture=neutral, PublicKeyToken=db7cfd3acb5ad44e' 
    /// or one of its dependencies.The system cannot find the file specified." gibi bir hata alırsanız yapmanız gereken referanslarda yer alan Interop.SHDocVw
    /// adlı kütüphanenin özelliklerinde yer alan Ember Interop Type özelliğini False yapmalısınız.
    /// 
    /// Eğer "Additional information: The CurrentThread needs to have it's ApartmentState set to ApartmentState.STA to be able to automate Internet Explorer." gibi bir hata
    /// alırsanız o zaman altta yer alan Program sınıfı altındaki Main adlı metoda tanımlanan STAThread adlı attribute'ü tanımlayarak bu sorunu aşabilirsiniz.
    /// </summary>
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Internet explorer'in açılması sağlanıyor.
            using (var ie = new IE("http://www.google.com.tr"))
            //Firefox'un açılması sağlanıyor.
            //using (var firefox = new FireFox())
            {
                #region ShowWindow Options
                //Tarayıcıyı Küçültülmüş olarak açılmaya zorlar.
                //ie.ShowWindow(WatiN.Core.Native.Windows.NativeMethods.WindowShowStyle.ForceMinimized);
                //Tarayıcının gizli olarak açılması sağlanacak böylelikle işlemler arkaplanda gerçekleşmiş olacak.
                //ie.ShowWindow(WatiN.Core.Native.Windows.NativeMethods.WindowShowStyle.Hide);
                //Tarayıcıyı gösterilmesini sağlar.
                //ie.ShowWindow(WatiN.Core.Native.Windows.NativeMethods.WindowShowStyle.Show);
                //Tarayıyı tam ekran olarak çalıştırır.
                //ie.ShowWindow(WatiN.Core.Native.Windows.NativeMethods.WindowShowStyle.Maximize);
                //Tarayıcıyı Küçültülmüş olarak açılmasını sağlar.
                //ie.ShowWindow(WatiN.Core.Native.Windows.NativeMethods.WindowShowStyle.Minimize);
                #endregion

                //lst-ib id'li input elementine site:muratoner.net yazılıyor.
                ie.TextField("lst-ib").TypeText("site:muratoner.net");
                //name attribute değeri btnG olan button elementinin Click event'i tetikleniyor.
                ie.Button(Find.ByName("btnG")).Click();

                //search id'li div elementi alınıyor.
                var div = ie.Div("search");

                //search id'li div altındaki h3 html elementleri döngü ile dönülüyor.
                foreach (var item in div.ElementsWithTag("h3"))
                {
                    //search id'li div altında yer alan h3 etiketleri eğer r class'ına sahip ise text'i console'a yazdırılıyor.
                    if (item.ClassName == "r")
                        Console.WriteLine(item.Text);
                }

                //Adres değiştirmek için GoTo metodunu kullanabilirsiniz.
                //ie.GoTo("http://www.muratoner.net/iletisim");

                //Sayfanın ekran görüntüsünü almak için CaptureWebPageToFile metodunu kullanabilirsiniz.
                //browser.CaptureWebPageToFile("1.jpg");

                Console.ReadKey();
            }
        }
    }
}
