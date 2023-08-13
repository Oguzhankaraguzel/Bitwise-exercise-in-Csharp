namespace ConsoleApp1
{
    [Flags]
    public enum Aylar_Months
    {
        Hiçbiri_None = 0,
        Ocak_January = 1,
        Şubat_February = 2,
        Mart_March = 4,
        Nisan_April = 8,
        Mayıs_May = 16,
        Haziran_June = 32,
        Temmuz_July = 64,
        Ağustos_August = 128,
        Eylül_September = 256,
        Ekim_October = 512,
        Kasım_November = 1024,
        Aralık_December = 2048
    }
}
