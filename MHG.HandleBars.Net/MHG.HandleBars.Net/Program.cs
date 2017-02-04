using System.IO;

namespace HandleBars.Net {

    using System;
    using HandlebarsDotNet;

    class Program {
        static void Main( string[] args ) {
            var sonuc = "";

            #region Örnek 1 - Temel Kullanım
            //var source = @"
            //    <div class='baslik'>
            //        <h1>{{baslik}}</h1>
            //        <div class='govde'>
            //            {{govde}}
            //        </div>
            //    </div>";

            //var template = Handlebars.Compile( source );

            //var veri = new {
            //    baslik = "Yeni makalem",
            //    govde = "Bu makalede Handlebarsjs kullanıyoruz!"
            //};

            //sonuc = template( veri );
            #endregion

            #region Örnek 2 - Partial Kayıt ve Kullanımı
            //var source = @"
            //    <h2>İsimler</h2>
            //    {{#isimler}}
            //        {{> kullanici}}
            //    {{/isimler}}";
            //var partialSource = "<strong>{{ad}}</strong>\n";
            //using (var reader = new StringReader(partialSource))
            //{
            //    var partialTemplate = Handlebars.Compile( reader );
            //    Handlebars.RegisterTemplate( "kullanici", partialTemplate );
            //}

            //var template = Handlebars.Compile(source);

            //var veri = new
            //{
            //    isimler = new[]
            //    {
            //        new
            //        {
            //            ad = "Murat"
            //        },
            //        new
            //        {
            //            ad = "John"
            //        }
            //    }
            //};

            //sonuc = template(veri);
            #endregion

            #region Örnek 3 - Helpers(Yardımcı) Kaydı ve Kullanımı
            //Handlebars.RegisterHelper( "link_to", ( writer, context, arguments ) => {
            //    string str = "<a href='" + context.url + "'>" + context.text + "</a>";
            //    writer.WriteSafeString( str );
            //} );

            //var source = "Click here: {{link_to}}";
            //var template = Handlebars.Compile( source );

            //var veri = new {
            //    url = "http://github.com/rexm/handlebars.net",
            //    text = "Handlebars.Net"
            //};

            //sonuc = template( veri );
            #endregion

            #region Örnek 4 - Each ile döngü kullanımı
            //var source = "{{#each people}}" +
            //               "<h1>{{ad}} {{soyad}}</h1>\n" +
            //             "{{/each}}";

            //var veri = new {
            //    people = new[] {
            //        new
            //        {
            //            ad = "Murat",
            //            soyad = "ÖNER"
            //        },
            //        new
            //        {
            //            ad = "Sakine",
            //            soyad = "Salmanlı"
            //        }
            //    }
            //};
            //var template = Handlebars.Compile( source );
            //sonuc = template( veri );
            #endregion

            #region Örnek 5 - If bloğu kullanımı
            var kaynak = "{{#each kisiler}}" +
                           "{{! Yorumunuz buraya yazılacak. }}" +
                           "{{#if @first}}" +
                                "<h1>İlk: {{ad}} {{soyad}}</h1>\n" +
                           "{{/if}}" +
                           "{{!-- Yorumunuz buraya yazılacak. --}}" +
                           "{{#if @last}}" +
                                "<h1>Son: {{ad}} {{soyad}}</h1>\n" +
                           "{{/if}}" +
                         "{{/each}}";

            var veri = new {
                kisiler = new[] {
                    new
                    {
                        ad = "Murat",
                        soyad = "ÖNER"
                    },
                    new
                    {
                      ad = "Ramazan",
                      soyad = "ÖNER"  
                    },
                    new
                    {
                        ad = "Sakine",
                        soyad = "Salmanlı"
                    }
                }
            };
            var template = Handlebars.Compile( kaynak );
            sonuc = template( veri );
            #endregion

            Console.WriteLine( sonuc );
            Console.ReadLine();
        }
    }
}