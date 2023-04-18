using labo10;
//task2(a-c)
//string path = @"C:\Users\rusla\source\repos\labor10\labor10\bin\basedir\dir0";
//DirectoryInfo directory = new DirectoryInfo(path);
//if (directory.Exists)
//{
//    Console.WriteLine("Подкаталоги:");
//    DirectoryInfo[] dirs = directory.GetDirectories();
//    foreach (DirectoryInfo dir in dirs)
//    {
//        Console.WriteLine(dir.Name);
//    }
//    Console.WriteLine();
//    Console.WriteLine("Файлы:");
//    FileInfo[] files = directory.GetFiles();
//    foreach (FileInfo file in files)
//    {
//        Console.WriteLine(file.Name);   
//    }
//    Console.WriteLine("Файлы с расширением .txt:");
//    FileInfo[] filestxt = directory.GetFiles("*.txt");
//    foreach (FileInfo file in filestxt)
//    {
//        Console.WriteLine(file.Name);
//    }
//    Console.WriteLine("Всего файлов 1 уровня: " +(dirs.Length+files.Length)) ;
//}

//task2(d)
//static void EmptySubDir(DirectoryInfo Dir)
//{
//    DirectoryInfo[] SubDir = Dir.GetDirectories();
//    foreach(DirectoryInfo directoryInfo in SubDir)
//    {
//        if (directoryInfo.GetFileSystemInfos().Length == 0) { Console.WriteLine(directoryInfo.Name); }
//        else { EmptySubDir(directoryInfo); }
//    }
//}
//string path = @"C:\Users\rusla\source\repos\labor10\labor10\bin\basedir";

//DirectoryInfo directory = new DirectoryInfo(path);
//if (directory.Exists) { EmptySubDir(directory); }


//task2(e)
//string path = @"C:\Users\rusla\source\repos\labor10\labor10\bin\basedir\dir0\елки.txt";
//FileInfo fileInfo = new FileInfo(path);
//if (fileInfo.Exists)
//{
//    Console.WriteLine(fileInfo.FullName);
//}


//task3


//string path = @"..\..\basedir";         //create 3 other directory
//string subpath = "Picture";
//string subpath1 = @"Texts/History";
//string subpath2 = @"Texts/Horror/First";
//DirectoryInfo dirInfo = new DirectoryInfo(path);
//if (!dirInfo.Exists)
//{
//    dirInfo.Create();
//}
//dirInfo.CreateSubdirectory(subpath);
//dirInfo.CreateSubdirectory(subpath1);
//dirInfo.CreateSubdirectory(subpath2);


//for (int i = 1; i <= 6; i++)             //create 6 other file
//{
//    FileInfo file = new FileInfo(@"..\..\basedir\Picture\" + i + ".txt");
//    if (!file.Exists) { file.Create(); }
//}





//FileInfo file1 = new FileInfo(@"..\..\basedir\Picture\5.txt");  // Переименоватьbasedir/Picture/5.txt вbasedir/Picture/5000.txt
//if (file1.Exists)
//{
//    file1.MoveTo(@"..\..\basedir/Picture/5000.txt");
//}


//FileInfo file1 = new FileInfo(@"..\..\basedir\Picture\5000.txt");     //Переместитьфайлbasedir/Picture/5000.txt вдиректориюbasedir/Texts/History
//file1.MoveTo(@"..\..\basedir\Texts\History\5000.txt");


//FileInfo fileInfo = new FileInfo(@"..\..\basedir\Picture\6.txt");      //task3c
//if (fileInfo.Exists) { fileInfo.Delete(); }
//Console.WriteLine("Какой файл из Picture  вы хотите удалить?");
//string file = Console.ReadLine();
//FileInfo fileInfo = new FileInfo(@"..\..\basedir\Picture\" + file + ".txt");
//if (fileInfo.Exists) { fileInfo.Delete(); }


//DirectoryInfo directoryInfo = new DirectoryInfo(@"..\..\basedir\Picture");     //path picture
//DirectoryInfo directory = new DirectoryInfo(@"..\..\basedir\Texts\Horror");    //path Horror
//FileInfo[] filestxt = directoryInfo.GetFiles("*.txt");                         //файлы внутри директории picture
//DirectoryInfo[] directoryInfo1 = directory.GetDirectories();                   //directories inside Horror
//if (directoryInfo.Exists)                                                      //delite picture
//{
//    for(int i=0;i<filestxt.Length; i++)
//    {
//        filestxt[i].Delete();
//    }   
//    directoryInfo.Delete();
//}
//if (directory.Exists) {                                                        //delete Horror
//    for(int i = 0; i < directoryInfo1.Length; i++)
//    {
//        directoryInfo1[i].Delete();
//    }
//    directory.Delete(); }

//string path = @"C:\Users\rusla\source\repos\labor10\labor10\bin\basedir\data\dataset_1.txt";   //datase1
//string file = await File.ReadAllTextAsync(path);
//string[] str = file.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//int[] a = new int[str.Length];
//for (int i = 0; i < str.Length; i++)
//{
//    a[i] = Convert.ToInt32(str[i]);
//}
//Console.WriteLine("a + b = " + (a[0] + a[1]) + ";\ta*b = ;" + (a[0] * a[1]) + "\ta+b^2 = " + (a[0] + Math.Pow(a[1],2)));


//string path = @"C:\Users\rusla\source\repos\labor10\labor10\bin\basedir\data\dataset_2.txt";   //dataset2
//string file = await File.ReadAllTextAsync(path);
//string[] str = file.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
//int[] a = new int[str.Length];
//for (int i = 0; i < str.Length; i++)
//{
//    a[i] = Convert.ToInt32(str[i]);
//    if (a[i] % 2 == 0)
//    {
//        Console.Write(a[i]+ "\t");
//    }
//}


//string path = @"C:\Users\rusla\source\repos\labor10\labor10\bin\basedir\data\dataset_3.txt";     //dataset3
//string file = await File.ReadAllTextAsync(path);
//string[] str = file.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//int[] a = new int[str.Length];

//FileInfo files = new FileInfo(@"C:\Users\rusla\source\repos\labor10\labor10\bin\basedir\data\res_3.txt");
//if (!files.Exists) { files.Create(); }
//for (int i = 0; i < str.Length; i++)
//{
//    a[i] = Convert.ToInt32(str[i]);
//    if (a[i] < 9999)
//    {
//        await File.AppendAllTextAsync(@"C:\Users\rusla\source\repos\labor10\labor10\bin\basedir\data\res_3.txt", str[i] + " ");
//    }
//}


//string path = @"C:\Users\rusla\source\repos\labor10\labor10\bin\basedir\data\dataset_4.txt";     //dataset4
//string file = await File.ReadAllTextAsync(path);
//string[] str = file.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//int[] a = new int[str.Length];

//for (int i = 0; i < str.Length; i++)
//{
//    a[i] = int.Parse(str[i]);
//}
//int max = a[0];
//int k = 0;
//for(int i = 1; i < a.Length; i++)
//{
//    if (a[i] > max)
//    {
//        k = i;
//    }
//}
//await File.AppendAllTextAsync(@"C:\Users\rusla\source\repos\labor10\labor10\bin\basedir\data\res_3.txt", str[k] + " ");



//string path = @"C:\Users\rusla\source\repos\labor10\labor10\bin\basedir\data\dataset_5.txt";     //dataset5
//string file = await File.ReadAllTextAsync(path);
//string[] str = file.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//for(int i = 0; i < str.Length; i++)
//{
//    Console.Write(str[i].ToUpper()+"  ");
//}





Person[] a = new Person[5];       //class task5
a[0] = new Person("Bagymanov", 162, 58, new DateTime(2004,12,7)); int k1 = a[0].Age();
a[1] = new Person("Pupkov", 171, 65, new DateTime(2002, 06, 06)); int k2 = a[0].Age();
a[2] = new Person("Amangeldi", 157, 45, new DateTime(2005, 01, 20)); int k3 = a[0].Age();
FileInfo files = new FileInfo(@"C:\Users\rusla\source\repos\labor10\labor10\bin\basedir\data\persons.txt");
if (!files.Exists) { files.Create(); }
//for(int i = 0; i < 3; i++)
//{
//    await File.AppendAllTextAsync(@"C:\Users\rusla\source\repos\labor10\labor10\bin\basedir\data\persons.txt", a[i].Surname + " " + a[i].Height + " " + a[i].Weight + " " + a[i].Birth+"\n");
//}
a[3] = new Person("Raskolnikov", 182, 90, new DateTime(2000, 12, 7)); int k4 = a[0].Age();
a[4] = new Person("Hermes", 171, 80, new DateTime(2006, 06, 06)); int k5 = a[0].Age();
//for (int i = 3; i < 5; i++)
//{
//    await File.AppendAllTextAsync(@"C:\Users\rusla\source\repos\labor10\labor10\bin\basedir\data\persons.txt", a[i].Surname + " " + a[i].Height + " " + a[i].Weight + " " + a[i].Birth + "\n");
//}
string path = @"C:\Users\rusla\source\repos\labor10\labor10\bin\basedir\data\persons.txt";
string file = await File.ReadAllTextAsync(path);
string[] str = file.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
for(int i = 0; i < str.Length; i++)
{
    if (i == 0)
    {
        Console.WriteLine(str[i] + " " + k1);
    }
    else if (i == 4)
    {
        Console.WriteLine(str[i]+ " " + k2);
    }
    else if (i ==8) { Console.WriteLine(str[i] + " " + k3); }
    else if (i == 12) { Console.WriteLine(str[i]+ " "+ k4); }
    else if(i==16) { Console.WriteLine(str[i] + " "+ k5); }
}
Console.WriteLine();
int[] f = new int[10];
int k = 0;
for(int i = 0; i < str.Length; i++)
{
    if (i == 1 || i == 2 || i == 5 || i == 6 || i == 9 || i == 10 || i == 13 || i == 14 || i == 17 || i == 18)
    {
        f[k] = int.Parse(str[i]);
        k++;
    }
}
double avgHei = 0;
double avgWei = 0;
for(int i=0; i < f.Length; i++)
{
    if (i % 2 == 0)
    {
        avgHei += f[i];
    }
    else { avgWei += f[i]; }
}
avgWei /= 5;
avgHei /= 5;
Console.WriteLine("Средний рост: {0};\n Средний вес: {1}",avgHei,avgWei);
//await File.AppendAllTextAsync(@"C:\Users\rusla\source\repos\labor10\labor10\bin\basedir\data\persons.txt", "Средний рост: " + avgHei + ";\n Средний вес: " + avgWei);