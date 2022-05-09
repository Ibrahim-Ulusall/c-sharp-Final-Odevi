using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Odevi
{
    public partial class Filmler : Form
    {
        public Filmler()
        {
            InitializeComponent();
        }
        Movies film = new Movies();

        private void FreeGuyButton_Click(object sender, EventArgs e)
        {
            film.filmAdi = "Free Guy";
            film.yil = "2021";
            film.yonetmen = "Shawn Levy";
            film.tur = "Aksiyon / Komedi";
            film.oyuncular = "Ryan Reynolds Jodie Comer Dwayne Johnson Taika Waititi Joe Kerry";
            film.imdb = "7,1";
            film.ozet = "Gerçek Kahraman, Matt Lieberman ve Zak Penn'in senaryosundan ve Lieberman'ın bir hikâyesinden Shawn Levy tarafından yönetilen, Amerikan bilimkurgu aksiyon komedi filmidir.";
            film.resimyol = "FreeGuy";
            film.Show();
            this.Hide();
        }

        private void NefesiniTutButon_Click(object sender, EventArgs e)
        {
            film.filmAdi = "Nefesini Tut";
            film.yil = "12 Mart 2016";
            film.yonetmen = "Fede Álvarez";
            film.tur = "Korku / Gerilim";
            film.oyuncular = "Jane Levy Stephen Lanh Dylon Minnette Daniel Zovatto Emma Bercovici";
            film.imdb = "7,1";
            film.ozet = "Nefesini Tut, 2016 yılı ABD yapımı korku türündeki Fede Alvarez filmi. Senaryosu Alvarez ve Rodo Sayagues tarafından yazılan filmin başrollerini Jane Levy, Dylan Minnette, Daniel Zovatto ve Stephen Lang paylaşıyor.";
            film.resimyol = "NefesiniTut";
            film.Show();
            this.Hide();
        }

        private void JackReacherButon_Click(object sender, EventArgs e)
        {
            film.filmAdi = "Jack Reacher";
            film.yil = "21 Aralık 2012";
            film.yonetmen = "Christopher McQuarrie";
            film.tur = "Aksiyon / Gerilim";
            film.oyuncular = "Tom Cruise Rosamund Pike Richard Jenkins David Oyelowo Werner Herzog";
            film.imdb = "7";
            film.ozet = "Masum bir kalp bölgesinde, beş kişi uzman bir keskin nişancı tarafından vurularak öldürülür. Polis, suçluyu çabucak belirleyip tutuklar ve bir smaç vakası oluşturur.Ama suçlanan adam itiraf etmek yerine \"Jack Reacher'ı yakalayın\" yazıyor. Reacher haberi kendisi görür ve şehre gelir. Savunma son derece rahatladı,ama Reacher adamı gömmeye geldi. Sanığın talebi karşısında şok olan Reacher, adamın suçluluğunun mutlak kesinliğini doğrulamak için yola koyulur, ancak umduğundan fazlasını bulur.";
            film.resimyol = "jackReacher";
            film.Show();
            this.Hide();
        }

        private void SilBaştanButton_Click(object sender, EventArgs e)
        {
            film.filmAdi = "Sil Baştan";
            film.yil = "2004";
            film.yonetmen = "Michel Gondry";
            film.tur = "Romantik / Bilim Kurgu";
            film.oyuncular = "Jim Carrey ve Kate Winslet Kirsten Dunst Mark Ruffalo Charlie Kaufman";
            film.imdb = "8,3";
            film.ozet = "Çekingen Joel Barish, hayatının aşkı olan ışıltılı Clementine'in onu hafızasından sildiğini öğrenince şok olur. Zavallı Joel, aynı parayı ona geri ödemek için, karanlığın ışığın önemli bir parçası olduğundan tamamen habersiz, acısız ama karmaşık bir tıbbi prosedürden geçme cesaretini toplar. Şimdi, kırgın ve öfkeli Joel'in Clementine'le ilgili çirkin anıları yavaş yavaş silinip yerini ruhsuz, kara bir boşluğa bırakırken, birdenbire ikinci kez düşünmeye, geri dönüşü olmayan süreci durdurma fikriyle oynamaya başlar. Sonunda, cehalet gerçekten mutluluk mu?";
            film.resimyol = "SilBaştan";
            film.Show();
            this.Hide();
        }

        private void AvangersEndGameButton_Click(object sender, EventArgs e)
        {
            film.filmAdi = "Avangers Endgame";
            film.yil = "2019";
            film.yonetmen = "Anthony Russo, Joe Russo";
            film.tur = "Aksiyon / Drama";
            film.oyuncular = "Robert Downey Jr., Chris Evans, Mark Ruffalo";
            film.imdb = "8,4";
            film.ozet = "\"Avengers Infinity War\"un ardından pek çok süper kahraman küle dönüşmüştür. Doktor Strange, Gamora, Drax, Mantis, genç Örümcek Adam, Black Panther, Bucky Barnes, Groot, Scarlet Witch, Vision, Star Lord, Maria Hill, The Wasp ve Nick Fury gibi pek çok kahraman, Thanos'un Sonsuzluk Eldiveni'ni ele geçirmesi ve kendi dengesini kurması yüzünden yok olmuştur ve dünya umutsuz haldedir. Dünya üzerinde kalan Black Widow, Kaptan Amerika, Thor ve Hulk kendi yaslarını tutmaktayken, Iron ve Nebula ise kontrol edemedikleri bir uzay gemisinin içinde, uzay boşluğunda sürüklenmektedirler. Süper kahramanlar takımı için işler pek de iyi görünmemektedir. Ancak Kuantum Bölgesi'nden çıkmanın bir yolunu bularak Avengers ekibinin kalan üyelerine giden Ant-Man, yeni bir umut ışığı olacaktır. Daha önce var olduğunu bilmedikleri bölgeler, kahramanlar ve evrenlerin varlığını öğrenen ekip, Thanos'un kurduğu bu çarpık dengeyi değiştirmek ve kendilerinden alınanı geri getirmek için hayatlarının en büyük mücadelesine girişeceklerdir. Hepsi kişisel olarak önem verdikleri şeyleri kaybetmiş olan kahramanlarımız için intikam vakti gelmiştir.";
            film.resimyol = "avengersEndGame";
            film.Show();
            this.Hide();
        }

        private void Underground6Button_Click(object sender, EventArgs e)
        {
            film.filmAdi = "Underground 6";
            film.yil = "10 Aralık 2019";
            film.yonetmen = "Michael Bay";
            film.tur = "Aksiyon / Gerilim";
            film.oyuncular = "Ryan Reynolds, Mélanie Laurent, Manuel Garcia-Rulfo";
            film.imdb = "6,1";
            film.ozet = "6 Underground, kenti suçlulardan kurtarmak için kendilerini ölü olarak gösterip, suçluların peşine düşen 6 kişilik milyalder grubun hikayesini konu ediyor. 2007'de başlayan uzun soluklu Transformers serisinin ünlü yönetmeni Michael Bay'in kamera arkasına geçeceği aksiyon filminin başrolünü Ryan Reynolds üstleniyor.";
            film.resimyol = "underground6";
            film.Show();
            this.Hide();
        }

        private void RecepIvedik6Button_Click(object sender, EventArgs e)
        {
            film.filmAdi = "Recep İvedik 6";
            film.yil = "8 Kasım 2019";
            film.yonetmen = "Togan Gökbakar";
            film.tur = "Komedi";
            film.oyuncular = "Şahan Gökbakar, Nurullah Çelebi, Somer Karvan";
            film.imdb = "2,9";
            film.ozet = "Recep İvedik 6, Konya'ya giderken kendisini Kenya'da bulan Recep İvedik'in maceralarını konu ediyor. Recep İvedik'in hayatı kendisine gelen bir davet ile bambaşka bir hal alır. Davet ile Recep İvedik, kuru fasulye festivaline çağırılmaktadır. Daveti memnuniyetle karşılayan Recep, arkadaşı Nurullah'ı da yanına alarak Konya'ya doğru yola koyulur. Daha yolculuğa başlar başlamaz türlü talihsizlikler yaşayan ikili, yolculuğun sonunda kendilerini Konya yerine Kenya'da bulur. Seyahat acentesinin hatası sonucu Kenya'ya gelen Recep ve Nurullah, Türkiye'ye geri dönmenin yolunu arar. Bilmedikleri bir coğrafyada bulunan Recep ile Nurullah, kendilerini birden iki düşman yerli kabilenin arasında bulur. Kendisine has yöntemlerle içinde bulunduğu vahşi dünyada ayakta kalmaya çalışan Recep'in başına bu süreçte birbirinden ilginç olaylar gelir.";
            film.resimyol = "Recepİvedik6";
            film.Show();
            this.Hide();
        }

        private void OrumcekAdam3Button_Click(object sender, EventArgs e)
        {
            film.filmAdi = "Örümcek Adam 3";
            film.yil = "2007";
            film.yonetmen = "Sam Raimi";
            film.tur = "Aksiyon / Bilim Kurgu";
            film.oyuncular = "Kirsten Dunst James Franco Tobey Maguire James Franco Thomas Haden Church";
            film.imdb = "6,2";
            film.ozet = "Peter Parker ya da Örümcek Adam, bir kez daha izleyicisi ile buluşuyor. Her ne kadar nihayet hayatını bir düzen üzerine kurmuş olsa da Peter Parker özel hayatı bir yanda, Örümcek Adam kimliği diğer yanda yaşarken zorlanır. Örümcek Adam olmanın en temel tehlikesi ise her an nerede geleceğini kestiremediği tehlikeler ile kuşatılmış olma ihtimalidir. Bu sırada Peter’ın rahatsız edici bir kibri çıkar ortaya. Sevenleri bu durumdan olumsuz etkilenirler. Sadece üzülmek açısından değil, onun sırf bu özelliğinden ötürü Venom ile Kum Adam’ın saldırılarına kulak asmayarak ailesini ve tüm sevdiklerini farkında olmadan tehlikeye atacaktır.";
            film.resimyol = "ÖrümcekAdam3";
            film.Show();
            this.Hide();
        }

        private void SihirbazlarCetesi2Button_Click(object sender, EventArgs e)
        {
            film.filmAdi = "Sihirbazlar Çetesi 2";
            film.yil = "2016";
            film.yonetmen = "Jon M. Chu";
            film.tur = "Macera / Gerilim";
            film.oyuncular = "Jesse Eisenberg, Mark Ruffalo, Woody Harrelson";
            film.imdb = "6,4";
            film.ozet = "İzleyenlerin nefesini kesen ve toplumun hayranlığını kazandıkları Robin Hood stili gösterilerinin ardından bir sene geçmiştir. Atlılar çetesi geri dönüşünü müjdeleyen gösteri ile kaçmanın onlar için çocuk oyuncağından farksız olduğunu kanıtlayacaktır.  J. Daniel Atlas, Merritt McKinney, Jack Wilder ve grubun yeni üyesi Lula ile birlikte, yeni gösterilerini Owen Case’i ifşa etme umuduyla sergilerler. Bu sefer FBI özel ajanı Dylan Rhodes’un  da yardımını almışlardır fakat Rhodes'un ekibe katılımı gösteri öncesi ifşa olur; ve planlar geri teper. İtibarlarını geri kazanmka isteyen Atlılar kariyerlerinin en zorlu soygunu ile karşı karşıya kalacaklardır... İlki 2013 yılında seyircisiyle buluşan ve ilüzyon marifetiyle çok başarılı bir soygun/intikam hikayesini konu alan suç gerilimi Sihirbazlar Çetesi'nin devamı olan filmin yönetmenliğini Jon M. Chu üstleniyor. Kadroda ilk filmden J. Daniel Atlas olarak tanıdığımız Jesse Eisenberg'e Mark Ruffalo, Dave Franco, Woody Harrelson, Lizzy Caplan ve Michael Caine eşlik ediyor.";
            film.resimyol = "SihirbazlarCetesi3";
            film.Show();
            this.Hide();
        }

        private void Dag2_Click(object sender, EventArgs e)
        {
            film.filmAdi = "DAĞ 2";
            film.yil = "2016";
            film.yonetmen = "Alper Çağlar";
            film.tur = "Savaş / Aksiyon";
            film.oyuncular = "Çağlar Ertuğrul, Ufuk Bayraktar, Murat Serezli";
            film.imdb = "8,2";
            film.ozet = "Teröristlerin elinden kurtulmayı başaran iki arkadaş Oğuz ve Bekir,  6 yıl sonra özel bir görev için Özel Kuvvetler 8. Muharebe Arama Kurtarma Timi'ne katılır. Timin özel görevi ise Kuzey Irak'ta bir terör örgütü tarafından kaçırılan gazeteci Ceyda Balaban'ı kurtarmaktır. Ancak bu sefer düşman geçmişteki gibi bir tane değildir. MAK'ın karşısında bu acımasız coğrafyada birbiriyle çatışan birden fazla kuvvet vardır ve işler bu sefer hiç olmadığı kadar zordur.Gişede başarı kazanan Dağ filminin ardından gelen devam filmi Dağ 2 filminde yine başrolleri Çağlar Ertuğrul ve Ufuk Bayraktar paylaşırken Alper Çağlar da filmin yönetmenliğini ve senaristliğini üstleniyor.";
            film.resimyol = "Dag2";
            film.Show();
            this.Hide();
        }
    }
}
