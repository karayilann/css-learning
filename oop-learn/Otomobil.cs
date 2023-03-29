using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_learn
{
    internal class Otomobil
    {
        public string horsePower;
        public string renk;                 // Public yaptığımız ögelere dışarıdan erişilip değiştirilebilir.
        private string paketAdi;
        private string marka = "Audi";       // Private yaptığımız ögeler dışarıdan erişilemez ve değiştirilemez.
        private string model = "A7";


        // Constructor Yöntemi ile ek tanımlamalardan kurtulabiliriz.
        public Otomobil(string renk, string paketAdi)  
        {
            this.renk = renk;
            this.paketAdi = paketAdi;
        }

        // constructor yöntemini hızlı işlemler menüsü ile oluşturmak dışında kendimizde oluşturabiliriz.
        public Otomobil(string marka)
        {
            this.marka = marka;
        }

        // NOT : Eğer iki tane constructor oluşturursak ve parametre sayıları farklı ise kaç tane parametre verirsek o constructoru çalıştırır.
        // NOT : Eğer iki tane aynı isimde constructora, aynı sayıda parametre verirseniz hata verir.

        public string showMarka()     // private ögeleri görüntülemek için bu methodu kullanabiliriz.  İnt değerler içinde geçerlidir.
        {
            return marka;
        }
        
        
        // Encapsulation ==> Kapsülleme
        
        public void setMarka(string marka)       // bu yöntem ile private değişkenleri değiştirebiliriz.
        {
            this.marka = marka;
        }

        // Kapsülleme 2.yöntem
        public string PaketAdi { get => paketAdi; set => paketAdi = value; }
        // Bu yöntemde public öge sağ tık > hızlı eylemler > Alanı kapsülle ve özelliği kullan ile düzenlenir. Aynı zamanda kullandığımız diğer scriptlerde de düzeltir.
    }
}
