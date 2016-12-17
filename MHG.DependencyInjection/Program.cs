using System;
using System.Drawing;
using static System.Console;

namespace MHG.DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Injection Types
            #region Constructor Injectin
            var aracYonetimi = new AracYonetimi(new Fiat("Fiat", "500L", Color.Red, 2));
            aracYonetimi.TekerSayisiDegistir(4);
            aracYonetimi.ModelDegistir("500X");
            aracYonetimi.RenkDegistir(Color.Blue);

            WriteLine(aracYonetimi.TumOzellikler());
            #endregion
            #region Method Injection
            //var aracYonetimi = new AracYonetimi();
            //var araba = new Fiat("Fiat", "500L", Color.Red, 2);

            //aracYonetimi.TekerSayisiDegistir(araba, 4);
            //aracYonetimi.ModelDegistir(araba, "500X");
            //aracYonetimi.RenkDegistir(araba, Color.Blue);

            //WriteLine(aracYonetimi.TumOzellikler(araba));
            #endregion
            #region Property Injection
            //var aracYonetimi = new AracYonetimi
            //{
            //    Araba = new Fiat("Fiat", "500L", Color.Red, 2)
            //};
            //aracYonetimi.TekerSayisiDegistir(4);
            //aracYonetimi.ModelDegistir("500X");
            //aracYonetimi.RenkDegistir(Color.Blue);

            //WriteLine(aracYonetimi.TumOzellikler());
            #endregion
            #endregion
            ReadLine();
        }
    }

    #region Injection Types
    #region Contructor Injection
    class AracYonetimi
    {
        readonly IAraba _araba;

        public AracYonetimi(IAraba araba)
        {
            _araba = araba;
        }

        public void RenkDegistir(Color renk) => _araba.Renk = renk;

        public void ModelDegistir(string model) => _araba.Model = model;

        public void TekerSayisiDegistir(byte tekerSayisi) => _araba.TekerSayisi = tekerSayisi;

        public string TumOzellikler()
        {
            var arry = new string[4];
            arry[0] = $"{nameof(_araba.TekerSayisi)}:{_araba.TekerSayisi}";
            arry[1] = $"{nameof(_araba.Renk)}:{_araba.Renk}";
            arry[3] = $"{nameof(_araba.Marka)}:{_araba.Marka}";
            arry[2] = $"{nameof(_araba.Model)}:{_araba.Model}";
            return string.Join(Environment.NewLine, arry);
        }
    }
    #endregion
    #region  Method Injection
    //class AracYonetimi
    //{

    //    public void RenkDegistir(IAraba araba, Color renk) => araba.Renk = renk;

    //    public void ModelDegistir(IAraba araba, string model) => araba.Model = model;

    //    public void TekerSayisiDegistir(IAraba araba, byte tekerSayisi) => araba.TekerSayisi = tekerSayisi;

    //    public string TumOzellikler(IAraba araba)
    //    {
    //        var arry = new string[4];
    //        arry[0] = $"{nameof(araba.TekerSayisi)}:{araba.TekerSayisi}";
    //        arry[1] = $"{nameof(araba.Renk)}:{araba.Renk}";
    //        arry[3] = $"{nameof(araba.Marka)}:{araba.Marka}";
    //        arry[2] = $"{nameof(araba.Model)}:{araba.Model}";
    //        return string.Join(Environment.NewLine, arry);
    //    }
    //}
    #endregion
    #region Property Injection
    //class AracYonetimi
    //{
    //    public IAraba Araba { get; set; }

    //    public void RenkDegistir(Color renk) => Araba.Renk = renk;

    //    public void ModelDegistir(string model) => Araba.Model = model;

    //    public void TekerSayisiDegistir(byte tekerSayisi) => Araba.TekerSayisi = tekerSayisi;

    //    public string TumOzellikler()
    //    {
    //        var arry = new string[4];
    //        arry[0] = $"{nameof(Araba.TekerSayisi)}:{Araba.TekerSayisi}";
    //        arry[1] = $"{nameof(Araba.Renk)}:{Araba.Renk}";
    //        arry[3] = $"{nameof(Araba.Marka)}:{Araba.Marka}";
    //        arry[2] = $"{nameof(Araba.Model)}:{Araba.Model}";
    //        return string.Join(Environment.NewLine, arry);
    //    }
    //}
    #endregion
    #endregion

    interface IAraba
    {
        string Marka { get; set; }
        string Model { get; set; }
        Color Renk { get; set; }
        byte TekerSayisi { get; set; }
    }

    class Renault : IAraba
    {
        public Renault(string marka, string model, Color renk, byte tekerSayisi)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            TekerSayisi = tekerSayisi;
        }

        public string Marka { get; set; }
        public string Model { get; set; }
        public Color Renk { get; set; }
        public byte TekerSayisi { get; set; }
    }

    class Fiat : IAraba
    {
        public Fiat(string marka, string model, Color renk, byte tekerSayisi)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            TekerSayisi = tekerSayisi;
        }

        public string Marka { get; set; }
        public string Model { get; set; }
        public Color Renk { get; set; }
        public byte TekerSayisi { get; set; }
    }
}