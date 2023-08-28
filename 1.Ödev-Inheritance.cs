//using System;

//public class Powers
//{

//    public string name;


//    public Powers()
//    {
//        this.name = name;

//    }
//    public string showName()
//    {

//        return ("İsmi : " + this.name);
//    }
//}
//class Strength : Powers
//{
//    public string strength;
//    public Strength() { this.strength = strength; }
//    public string showStrength()
//    {
//        return ("Fiziksel Güc");
//    }

//}
//class Magic : Powers
//{
//    public string magics;

//    public Magic()
//    {
//        this.magics = magics;
//    }
//    public string showMagic() { return ("Büyü gücü : " + magics); }
//}
//class SuperWeapons : Powers
//{
//    private String weaponName;
//    private String weaponType;
//    public string WeponName
//    {
//        get { return this.weaponName; }
//        set { this.weaponName = value; }
//    }
//    public string WeponType
//    {
//        get { return this.weaponType; }
//        set { this.weaponType = value; }
//    }

//    public SuperWeapons()
//    {
//        this.weaponName = weaponName;
//        this.weaponType = weaponType;
//    }
//    public string useWeapon()
//    {
//        return ("Silah ismi : " + WeponName
//            + "Silahın özelliği : " + WeponType);
//    }
//}
//class Sodo
//{
//    public static void Main(String[] args)
//    {
//        Strength guc = new Strength();
//        guc.name = "Hulk, ";
//        guc.strength = "Fiziksel Guc";
//        Console.WriteLine(guc.showName() +
//            " " + guc.showStrength());

//        Magic buyu = new Magic();
//        buyu.name = "Scarlet Witch, ";
//        buyu.magics = "Mistisizm";
//        Console.WriteLine(buyu.showName() +
//            " " + buyu.showMagic());

//        SuperWeapons zırh = new SuperWeapons();
//        zırh.name = "Iron Man, ";
//        zırh.WeponName = "Mark 6, ";
//        zırh.WeponType = "Zırh";
//        Console.WriteLine(zırh.showName() + " " +
//            zırh.useWeapon());

//    }
//}
