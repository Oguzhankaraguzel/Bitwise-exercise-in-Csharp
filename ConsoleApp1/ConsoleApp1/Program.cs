// Bit temelli değişken atama
// Bit-based variable assignment 

using ConsoleApp1;

int bitWise = 0b1001;
Console.WriteLine("int bitWise = 0b1001; => bitwise = " + bitWise);
Console.WriteLine("****************************************************************************");

// C# bit temelli değişken atamalarında, atama işlemini kolaylaştırmak adına, "_" kullanımını münkün kılar ve sayıları 4'lü gruplar halinde yazabiliriz.
// In C# bit-based variable assignments, we can use "_" to facilitate assignment and write numbers in groups of 4.

bitWise = 0b_1001;
Console.WriteLine("int bitWise = 0b_1001; => bitwise = " + bitWise);
Console.WriteLine("****************************************************************************");

// Hexadecimal atama için
// For hexadecimal assignment

int hexaDecimal = 0x_1001;
Console.WriteLine("int hexaDecimal = 0x_1001; => hexaDecimal = " + hexaDecimal);
Console.WriteLine("****************************************************************************");

// Rastgele onluk  bir sayıyı diğer tabanlarda yazdırma.
// Printing a random decimal number in other bases.
// "decimal" bir anahtar kelimedir kullanılamaz!!!
// "decimal" is a keyword cannot be used!!!
Random rnd = new Random();
int random = rnd.Next(1, 255);
string binaryBase = Convert.ToString(random, 2);
string octalBase = Convert.ToString(random, 8);
string baseTen = Convert.ToString(random, 10);
string hexaDecimalBase = Convert.ToString(random, 16);
Console.WriteLine(
    "number = " + random +
    "\nbinaryBase = " + binaryBase +
    "\noctalBase = " + octalBase +
    "\nbaseTen = " + baseTen +
    "\nhexaDecimalBase = " + hexaDecimalBase);
Console.WriteLine("****************************************************************************");

// Bellek Adresleri
// Memory Addresses 

int value = 42;

unsafe
{
    int* ptr = &value;

    Console.WriteLine($"Değer - value: {value}");
    Console.WriteLine($"Bellek Adresi - Memory Address: 0x{(ulong)ptr:x}");

}
Console.WriteLine("****************************************************************************");

// ~ 

uint a = 5;
uint b = ~a;
Console.WriteLine(
    "sayı - value = " + a +
    "\nikilik - binary = " + Convert.ToString(a, toBase: 2) +
    "\nTerslenmiş hali - inverted state = " + b +
    "\nbit bazında terslenmiş hali - bitwise inverted = " + Convert.ToString(b, toBase: 2));
Console.WriteLine("****************************************************************************");
// min - max, negative integers

int min = int.MinValue;
int max = -1;
Console.WriteLine("min - max, negative integers; " +
    "\nmin = " + min +
    "\nBinary min = " + Convert.ToString(min, 2) +
    "\nmax = " + max +
    "\nBinary max = " + Convert.ToString(max, 2)
    );
Console.WriteLine("****************************************************************************");
// Sola kaydırma - Lest shift

uint number1 = 5;
uint leftShifted = number1 << 1;
Console.WriteLine(
    "number1 = " + number1 +
    "\nleftShifted = " + leftShifted +
    "\nBitwise number1 = " + Convert.ToString(number1, 2) +
    "\nBitwise leftShifted = " + Convert.ToString(leftShifted, 2)
    );
Console.WriteLine("****************************************************************************");
// iki kere Sağa kaydırma - shifted right twice

uint number3 = 10;
uint shiftedRightTwice = number3 >> 2;
Console.WriteLine(
    "number3 = " + number3 +
    "\nshiftedRightTwice = " + shiftedRightTwice +
    "\nBitwise number3 = " + Convert.ToString(number3, 2) +
    "\nBitwise shiftedRightTwice = " + Convert.ToString(shiftedRightTwice, 2)
    );
Console.WriteLine("****************************************************************************");
// İşaretki sağa kaydırma - Signed right shift

int number4 = -10;
int signedRightShifted = number4 >> 1;
Console.WriteLine(
    "number4 = " + number4 +
    "\nsignedRightShifted = " + signedRightShifted +
    "\nBitwise number4 = " + Convert.ToString(number4, 2) +
    "\nBitwise signedRightShifted = " + Convert.ToString(signedRightShifted, 2)
    );
Console.WriteLine("****************************************************************************");
// işaretli iki kere Sağa kaydırma - Signed shifted right twice

int number5 = -10;
int signedRightShiftedTwice = number5 >> 2;
Console.WriteLine(
    "number5 = " + number5 +
    "\nsignedRightShiftedTwice = " + signedRightShiftedTwice +
    "\nBitwise number5 = " + Convert.ToString(number5, 2) +
    "\nBitwise signedRightShiftedTwice = " + Convert.ToString(signedRightShiftedTwice, 2)
    );
Console.WriteLine("****************************************************************************");
// işaretli sola kaydırma - Signed shifted left

int number6 = -10;
int signedLeftShifted = number5 << 1;
Console.WriteLine(
    "number6 = " + number6 +
    "\nsignedLeftShifted = " + signedLeftShifted +
    "\nBitwise number6 = " + Convert.ToString(number6, 2) +
    "\nBitwise signedLeftShifted = " + Convert.ToString(signedLeftShifted, 2)
    );
Console.WriteLine("****************************************************************************");
// Bit temelli işaretli ve işaretsiz atama
// Bitwise signed and unsigned assignment

// Bu şekilde atama yapılamaz - It cannot be assigned in this way.

// int number7 = 0b_1000_1111_0000_1111_0000_1111_0000_1100;

// hata - error = Cannot implicitly convert type 'uint' to 'int'. An explicit conversion exists (are you missing a cast?)

// Bu şekilde atama yapılabilir - This way you can assign
int number8 = 0b_0000_1111_0000_1111_0000_1111_0000_1100;

// veya - or

uint number9 = 0b_1000_1111_0000_1111_0000_1111_0000_1100;
uint number10 = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
/*************************************************************************************************************************/
// & operatörü - & operators

int number11 = 10;
int number12 = 7;
int number13 = number11 & number12;
Console.WriteLine(
    "number11 = " + number11 +
    "\nnumber12 = " + number12 +
    "\nnumber13 = number11 & number12 = " + number13 +
    "\nBitwise number11 = " + Convert.ToString(number11, 2) +
    "\nBitwise number12 = " + Convert.ToString(number12, 2) +
    "\nBitwise number13 = " + Convert.ToString(number13, 2)
    );
Console.WriteLine("****************************************************************************");

// | operatörü - | operators

int number14 = 10;
int number15 = 7;
int number16 = number14 | number15;
Console.WriteLine(
    "number14 = " + number14 +
    "\nnumber15 = " + number15 +
    "\nnumber16 = number14 | number15 = " + number16 +
    "\nBitwise number14 = " + Convert.ToString(number14, 2) +
    "\nBitwise number15 = " + Convert.ToString(number15, 2) +
    "\nBitwise number16 = " + Convert.ToString(number16, 2)
    );
Console.WriteLine("****************************************************************************");

// ^ operatörü - ^ operators

int number17 = 10;
int number18 = 7;
int number19 = number14 ^ number15;
Console.WriteLine(
    "number17 = " + number17 +
    "\nnumber18 = " + number18 +
    "\nnumber19 = number17 ^ number18 = " + number19 +
    "\nBitwise number17 = " + Convert.ToString(number17, 2) +
    "\nBitwise number18 = " + Convert.ToString(number18, 2) +
    "\nBitwise number19 = " + Convert.ToString(number19, 2)
    );
Console.WriteLine("****************************************************************************");

// negatif sayılar ile | operatörü - | operators with negative numbers

int number20 = 10;
int number21 = -7;
int number22 = number20 | number21;
Console.WriteLine(
    "number20 = " + number20 +
    "\nnumber21 = " + number21 +
    "\nnumber22 = number20 | number21 = " + number22 +
    "\nBitwise number20 = " + Convert.ToString(number20, 2) +
    "\nBitwise number21 = " + Convert.ToString(number21, 2) +
    "\nBitwise number22 = " + Convert.ToString(number22, 2)
    );
Console.WriteLine("****************************************************************************");

// negatif sayılar ile ^ operatörü - ^ operators with negative numbers

int number23 = 10;
int number24 = -7;
int number25 = number20 ^ number21;
Console.WriteLine(
    "number23 = " + number23 +
    "\nnumber24 = " + number24 +
    "\nnumber25 = number23 ^ number24 = " + number25 +
    "\nBitwise number23 = " + Convert.ToString(number23, 2) +
    "\nBitwise number24 = " + Convert.ToString(number24, 2) +
    "\nBitwise number25 = " + Convert.ToString(number25, 2)
    );
Console.WriteLine("****************************************************************************");

// TEK Mİ ÇİFT Mİ? - ODD OR EVEN?
Console.WriteLine("Lütfen bir sayı giriniz - Please enter a number");
int number26 = Convert.ToInt32(Console.ReadLine());
int number27 = number26 & 1;
if (number27 == 1)
{
    Console.WriteLine("tek - odd");
}
else
{
    Console.WriteLine("çift - even");
}
Console.WriteLine("****************************************************************************");

// 30 GÜNLÜK AYLARI BULMA - FIND 30 DAY MONTHS

Aylar_Months ay_Month = Aylar_Months.Ocak_January | Aylar_Months.Mart_March | Aylar_Months.Mayıs_May | Aylar_Months.Temmuz_July | Aylar_Months.Ağustos_August | Aylar_Months.Ekim_October | Aylar_Months.Aralık_December;

Console.WriteLine("30 gün çeken aylar - Months with 30 days:");
foreach (Aylar_Months bit in Enum.GetValues(typeof(Aylar_Months)))
{
    if (bit == Aylar_Months.Hiçbiri_None)
        continue;
    if ((ay_Month & bit) != 0)
    {
        Console.WriteLine(bit.ToString());
    }
}
