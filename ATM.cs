using System;

public abstract class ATM
{
    private int bakiye;
    public int Bakiye
    {
        get { return bakiye; }
        set { bakiye = value; }
    }
    public abstract string paraCek(int x);
    public abstract int paraYatir(int x);

    public abstract string gosterBakiye();
}
class Islem : ATM
{

    public override string paraCek(int money)
    {
        if (Bakiye >= money) { Bakiye -= money; return ("Kalan bakiye : " + Bakiye); }
        else { return ("Yeterli bakiye yok."); }

    }
    public override int paraYatir(int money)
    {
        Bakiye += money;
        return Bakiye;
    }
    public override string gosterBakiye()
    {
        return ("Bakiyeniz : " + Bakiye);
    }
}
class Show
{
    static void Main(string[] args)
    {
        Console.WriteLine("1.Bakiye Görüntüle\n2.Para çekme\n3.Para yatirma");
        Console.WriteLine("Yapmak istediðiniz iþlemi seçiniz..");
        int sec = Convert.ToInt32(Console.ReadLine());

        ATM islem = new Islem();
        islem.Bakiye = 2500;
        switch (sec)
        {
            case 1: Console.WriteLine(islem.gosterBakiye()); break;
            case 2:
                {
                    Console.WriteLine("Cekmek istediðiniz tutari giriniz.");
                    int tutar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(islem.paraCek(tutar));
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Yatirmak istediðiniz tutari giriniz.");
                    int tutar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(islem.paraYatir(tutar));
                    break;
                }
            default:
                Console.WriteLine("Ýþleminiz iptal edildi.");
                break;
        }
    }
}
