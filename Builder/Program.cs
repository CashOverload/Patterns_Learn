// Патерн "Будівельник" використовується для створення складних об'єктів поетапно.

using Builder;
using Builder.Builder;

Baker baker = new Baker();

BreadBuilder builder = new RyeBreadBuilder();
Bread ryeBread = baker.Bake(builder);
Console.WriteLine(ryeBread.ToString());

builder = new WheatBreadBuilder();
Bread wheatBread = baker.Bake(builder);
Console.WriteLine(wheatBread.ToString());

//У цьому випадку за допомогою конкретних будівельників RyeBreadBuilder і WheatBreadBuilder створюються об'єкти Bread з певним набором.
//У ролі розпорядника виступає клас пекаря Baker, який викликає методи конкретних будівельників для побудови нового об'єкта.