// Патерн "Одинак" гарантує, що клас має тільки один екземпляр, і надає глобальну точку доступу до нього.

using Singleton;

Computer comp = new Computer();
comp.Launch("Windows 8.1");
Console.WriteLine(comp.OS.Name);

// We can't change instance cause the object was created  
comp.OS = OS.getInstance("Windows 10");
Console.WriteLine(comp.OS.Name);

